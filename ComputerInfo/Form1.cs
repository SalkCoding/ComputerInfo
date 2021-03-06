﻿using System;
using ComputerInfo.Graph;
using ComputerInfo.Define;
using GChartLib;
using MetroSuite;
using System.Threading;
using System.ComponentModel;
using ComputerInfo.WMI;
using System.Management;
using System.Windows.Forms;
using System.IO;

namespace ComputerInfo
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        //Graph
        private readonly CPUGraph cpuGraph = new CPUGraph();
        private readonly RAMGraph ramGraph = new RAMGraph();
        private readonly DiskGraph diskGraph = new DiskGraph();
        //Auto refresh
        private MetroComboBox[] comboBoxList;
        private MetroSwitch[] switchList;
        System.Windows.Forms.Timer[] timerList;
        //Disk
        private GCircularProgress[] progressList;
        private MetroLabel[] labelList;
        //WMI
        private CPU cpu;
        private Bios bios;
        private RAM ram;
        private Disk disk;
        private GPU gpu;
        private OS os;
        //Dialog
        private DetailDiskInfo diskDialog;

        private readonly bool DEBUG = false;

        public Form1()
        {
            //init
            InitializeComponent();
            if (!DEBUG)
            {
                Text = "Loading...";
                BackgroundWorker worker = new BackgroundWorker
                {
                    WorkerSupportsCancellation = false
                };
                worker.DoWork += BackgroundWorker_InitGraph;
                worker.RunWorkerAsync();

                BackgroundWorker wmiWorker = new BackgroundWorker
                {
                    WorkerSupportsCancellation = false
                };
                wmiWorker.DoWork += BackgroundWorker_InitWMI;
                wmiWorker.RunWorkerCompleted += BackgroundWorker_InitCompleted;
                wmiWorker.RunWorkerAsync();
            }
        }

        private void BackgroundWorker_InitWMI(object sender, DoWorkEventArgs e)
        {
            cpu = new CPU();
            bios = new Bios();
            ram = new RAM();
            disk = new Disk();
            gpu = new GPU();
            os = new OS();
        }

        private void BackgroundWorker_InitGraph(object sender, DoWorkEventArgs e)
        {
            //Auto refresh
            comboBoxList = new MetroComboBox[] { Refresh_Speed, RAM_Refresh_Speed };
            switchList = new MetroSwitch[] { Refresh_Switch, RAM_Auto_Refresh };
            timerList = new System.Windows.Forms.Timer[] { timer1 };
            //Disk
            labelList = new MetroLabel[] {
                Disk_C_Caption, Disk_C_Status,
                Disk_D_Caption, Disk_D_Status,
                Disk_E_Caption, Disk_E_Status,
                Disk_F_Caption, Disk_F_Status,
                Disk_G_Caption, Disk_G_Status,
                Disk_H_Caption, Disk_H_Status };
            progressList = new GCircularProgress[] {
                Disk_C_Usage, Disk_D_Usage, Disk_E_Usage,
                Disk_F_Usage, Disk_G_Usage, Disk_H_Usage };

            CPU_Tracker.Paths.Add(cpuGraph.GraphPath);
            RAM_Tracker.Paths.Add(ramGraph.GraphPath);
        }

        private void BackgroundWorker_InitCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            PrintCPUInformation(CPUName, CPU_Clock, CPU_Voltage, CPU_L2CACHE, CPU_L3CACHE, CPU_CORE, CPU_THREAD);
            PrintBIOSInformation(BIOS_Base_Board_Manufacturer, BIOS_Base_Board_Product, BIOS_Base_Board_Version, BIOS_Release_Date, BIOS_Version, BIOS_Vendor, BIOS_System_Product_Name, BIOS_System_Manufacturer, BIOS_System_Version, BIOS_Logo);
            PrintRAMInfomation(RAM_Manufacturer, RAM_Speed, RAM_Voltage, RAM_Physical_Size, RAM_Virtual_Size);
            PrintDiskInformation(progressList, labelList);
            PrintGPUInformation(GPU_Manufacturer, GPU_Caption, GPU_Video_Processor_Name, GPU_RAM, GPU_Current_Refresh_Rate, GPU_Max_Refresh_Rate, GPU_Min_Refresh_Rate, GPU_Current_Resolution, GPU_Driver_Version, GPU_Driver_Date, GPU_Logo);
            PrintOSInformation(OS_Caption, OS_Architecture, OS_BuildNumber, OS_Version, OS_SerialNumber, OS_ContryCode, OS_CurrentTimeZone, OS_MUILanguages, OS_Language, OS_InstallTime, OS_LastBootUpTime);
            PrintSummaryInformation(Summary_CPU_Caption, Summary_CPU_Clock, Summary_CPU_Voltage, Summary_RAM_Clock, Summary_RAM_Size, Summary_MB_Caption, Summary_MB_System_Caption, Summary_MB_Manufacturer, Summary_GPU_Caption, Summary_GPU_RAM, Summary_GPU_Manufacturer, Summary_OS_Caption, Summary_OS_Architecturer, Summary_OS_Build_Number, Summary_OS_Version, Summary_OS_Install_Time, Summary_OS_Last_Boot_Up_Time);

            timer1.Enabled = true;
            Text = "Loading completed!";
            Invalidate();

            BackgroundWorker textRefresher = new BackgroundWorker();
            textRefresher.DoWork += delegate { Thread.Sleep(3000); };
            textRefresher.RunWorkerCompleted += delegate { Text = "Computer information"; Invalidate(); };
            textRefresher.RunWorkerAsync();
        }

        void Refresh_Timer_Setting(int speed)
        {
            foreach (MetroComboBox combobox in comboBoxList)
            {
                combobox.SelectedIndex = speed;
            }
            switch (speed)
            {
                case 0:
                    foreach (System.Windows.Forms.Timer timer in timerList)
                        timer.Interval = 400;
                    break;
                case 1:
                    foreach (System.Windows.Forms.Timer timer in timerList)
                        timer.Interval = 1000;
                    break;
                case 2:
                    foreach (System.Windows.Forms.Timer timer in timerList)
                        timer.Interval = 4000;
                    break;
            }
        }

        void Auto_Refresh_Setting(bool ischeck)
        {
            if (!ischeck)
            {
                foreach (System.Windows.Forms.Timer timer in timerList)
                    timer.Enabled = true;
                foreach (MetroSwitch refresh in switchList)
                    refresh.Checked = false;
            }
            else
            {
                foreach (System.Windows.Forms.Timer timer in timerList)
                    timer.Enabled = false;
                foreach (MetroSwitch refresh in switchList)
                    refresh.Checked = true;
            }
        }



        #region events

        private void Timer1_Tick(object sender, EventArgs e)
        {
            cpuGraph.RefreshGraph(CPU_Usage);
            ramGraph.RefreshGraph(ram, RAM_Physical_Progress, RAM_Virtual_Progress, RAM_Physical_Used, RAM_Virtual_Used);
        }

        private void Disk_Refresh_Click(object sender, EventArgs e)
        {
            diskGraph.RefreshGraph(disk, progressList);
            PrintDiskInformation(progressList, labelList);
        }

        private void Refresh_Speed_SelectedIndexChanged(object sender, EventArgs e)
        {
            Refresh_Timer_Setting(Refresh_Speed.SelectedIndex);
        }

        private void RefreshSwitch_CheckedChanged(object sender, bool isChecked)
        {
            Auto_Refresh_Setting(isChecked);
        }

        private void RAM_Refresh_Speed_SelectedIndexChanged(object sender, EventArgs e)
        {
            Refresh_Timer_Setting(RAM_Refresh_Speed.SelectedIndex);
        }

        private void RAM_Auto_Refresh_CheckedChanged(object sender, bool isChecked)
        {
            Auto_Refresh_Setting(isChecked);
        }

        //TODO Implement the features...
        private void Disk_More_Info_Click(object sender, EventArgs e)
        {
            if (diskDialog == null)
            {
                diskDialog = new DetailDiskInfo();
                diskDialog.FormClosed += delegate { diskDialog = null; };
                diskDialog.Show();
            }

        }

        #endregion

        #region print methods 

        public void PrintCPUInformation(
            MetroLabel CPU_Name_Label,
            MetroLabel CPU_Current_Clock_Label,
            MetroLabel CPU_Voltage_Label,
            MetroLabel CPU_L2Cache_Label,
            MetroLabel CPU_L3Cache_Label,
            MetroLabel CPU_Core_Label,
            MetroLabel CPU_Thread_Label
            )
        {
            CPU_Name_Label.Text = cpu.Name;
            CPU_Current_Clock_Label.Text = String.Format("{0:F2} Ghz", (cpu.CurrentClock / 1000f));
            CPU_Voltage_Label.Text = String.Format("{0:F3} V", cpu.Voltage);
            CPU_L2Cache_Label.Text = String.Format("{0:F2} Mb", (cpu.L2CacheSize / 1024f));
            CPU_L3Cache_Label.Text = String.Format("{0:F2} Mb", (cpu.L3CacheSize / 1024f));
            CPU_Core_Label.Text = cpu.CoreCount.ToString();
            CPU_Thread_Label.Text = cpu.ThreadCount.ToString();
        }

        public void PrintBIOSInformation(
            MetroLabel BIOS_Base_Board_Manufacturer,
            MetroLabel BIOS_Base_Board_Product,
            MetroLabel BIOS_Base_Board_Version,
            MetroLabel BIOS_Release_Date,
            MetroLabel BIOS_Version,
            MetroLabel BIOS_Vendor,
            MetroLabel BIOS_System_Product_Name,
            MetroLabel BIOS_System_Manufacturer,
            MetroLabel BIOS_System_Version,
            WebBrowser BIOS_Logo
            )
        {
            BIOS_Base_Board_Manufacturer.Text = bios.BaseManufacturer;
            BIOS_Base_Board_Product.Text = bios.BaseProduct;
            BIOS_Base_Board_Version.Text = bios.BaseVersion;
            BIOS_Release_Date.Text = bios.ReleaseDate;
            BIOS_Version.Text = bios.BiosVersion;
            BIOS_Vendor.Text = bios.BiosVendor;
            BIOS_System_Product_Name.Text = bios.SystemProductName;
            BIOS_System_Manufacturer.Text = bios.SystemManufacturer;
            BIOS_System_Version.Text = bios.SystemVersion;

            BackgroundWorker imageWorker = new BackgroundWorker()
            {
                WorkerSupportsCancellation = false
            };

            imageWorker.DoWork += delegate
            {
                String Manufacturer = bios.BaseManufacturer;
                if (Manufacturer.ToLower().Contains("msi"))
                    BIOS_Logo.Url = new Uri(Constants.MSI_LOGO);
                else if (Manufacturer.ToLower().Contains("asus"))
                    BIOS_Logo.Url = new Uri(Constants.ASUS_LOGO);
                else if (Manufacturer.ToLower().Contains("asrock"))
                    BIOS_Logo.Url = new Uri(Constants.ASROCK_LOGO);
                else if (Manufacturer.ToLower().Contains("gigabyte"))
                    BIOS_Logo.Url = new Uri(Constants.GIGABYTE_LOGO);
                else if (Manufacturer.ToLower().Contains("intel"))
                    BIOS_Logo.Url = new Uri(Constants.INTEL_LOGO);
                else if (Manufacturer.ToLower().Contains("biostar"))
                    BIOS_Logo.Url = new Uri(Constants.BIOSTAR_LOGO);
                else if (Manufacturer.ToLower().Contains("dell"))
                    BIOS_Logo.Url = new Uri(Constants.DELL_LOGO);
                else if (Manufacturer.ToLower().Contains("hp"))
                    BIOS_Logo.Url = new Uri(Constants.HP_LOGO);
            };
            imageWorker.RunWorkerAsync();
        }

        public void PrintRAMInfomation(
            MetroLabel RAM_Manafacturer,
            MetroLabel RAM_Speed,
            MetroLabel RAM_Voltage,
            MetroLabel RAM_Total_Physical_Size,
            MetroLabel RAM_Total_Virtual_Size
            )
        {
            Double Pysical_Size = (ram.PysicalSize / 1024f / 1024f / 1024f);
            Double Virtual_Size = (ram.VirtualSize / 1024f / 1024f / 1024f);
            RAM_Manafacturer.Text = ram.Manufacturer;
            RAM_Speed.Text = String.Format("{0} Mhz", ram.Speed);
            RAM_Voltage.Text = String.Format("{0} V", ram.Voltage);
            RAM_Total_Physical_Size.Text = String.Format("{0:F2} GB", Pysical_Size);
            RAM_Total_Virtual_Size.Text = String.Format("{0:F2} GB", Virtual_Size);
        }

        public void PrintDiskInformation(GCircularProgress[] progressList, MetroLabel[] labelList)
        {
            for (int i = Constants.DISK_MAX_COUNT; i > disk.VolumeCount; i--)
            {
                for (int j = (i * 2) - 1; j > (i * 2) - 2; j--)
                {
                    labelList[j].Text = "Not found";
                }
            }
            DriveInfo[] driver = disk.VolumeList.ToArray();
            int count = Math.Min(disk.VolumeCount, 6);
            for (int i = 0; i < count; i++)
            {
                labelList[i * 2].Text = driver[i].Name;
                if (driver[i].IsReady)
                    labelList[(i * 2) + 1].Text = String.Format("{0:F2} GB / {1:F2} GB", (driver[i].TotalFreeSpace / 1024f / 1024f / 1024f), (driver[i].TotalSize / 1024f / 1024f / 1024f));
                else
                    labelList[(i * 2) + 1].Text = "Volumes is not ready";

            }
            diskGraph.RefreshGraph(disk, progressList);
        }

        internal void PrintGPUInformation(
            MetroLabel GPU_Manufacturer,
            MetroLabel GPU_Caption,
            MetroLabel GPU_Video_Processor_Name,
            MetroLabel GPU_RAM,
            MetroLabel GPU_Current_Refresh_Rate,
            MetroLabel GPU_Max_Refresh_Rate,
            MetroLabel GPU_Min_Refresh_Rate,
            MetroLabel GPU_Current_Resolution,
            MetroLabel GPU_Driver_Version,
            MetroLabel GPU_Driver_Date,
            WebBrowser GPU_Logo
            )
        {
            GPU_Manufacturer.Text = gpu.AdapterCompatiability;
            GPU_Caption.Text = gpu.Caption;
            GPU_Video_Processor_Name.Text = gpu.VideoProcessor;
            GPU_RAM.Text = String.Format("{0:F2} GB", (Convert.ToInt64(gpu.AdapterRAM) / 1024f / 1024f / 1024f));
            GPU_Current_Refresh_Rate.Text = gpu.CurrentRefreshRate + "hz";
            GPU_Max_Refresh_Rate.Text = gpu.MaxRefreshRate + "hz";
            GPU_Min_Refresh_Rate.Text = gpu.MinRefreshRate + "hz";
            GPU_Current_Resolution.Text = gpu.VideoModeDescription;
            GPU_Driver_Version.Text = gpu.DriverVersion;
            DateTime driverTime = DateTime.ParseExact(gpu.DriverDate, "yyyyMMddHHmmss", null);
            GPU_Driver_Date.Text = String.Format("{0}/{1}/{2}", driverTime.Month, driverTime.Day, driverTime.Year);

            BackgroundWorker imageWorker = new BackgroundWorker()
            {
                WorkerSupportsCancellation = false
            };

            imageWorker.DoWork += delegate
            {
                String company = gpu.AdapterCompatiability.ToLower();
                if (company.Contains("nvidia"))
                    GPU_Logo.Url = new Uri(Constants.NVIDIA_LOGO);
                else if (company.Contains("intel"))
                    GPU_Logo.Url = new Uri(Constants.INTEL_LOGO);
                else
                    GPU_Logo.Url = new Uri(Constants.AMD_LOGO);
            };
            imageWorker.RunWorkerAsync();
        }

        public void PrintOSInformation(
            MetroLabel OS_Caption,
            MetroLabel OS_Architecture,
            MetroLabel OS_BuildNumber,
            MetroLabel OS_Version,
            MetroLabel OS_SerialNumber,
            MetroLabel OS_ContryCode,
            MetroLabel OS_CurrentTimeZoneCode,
            MetroLabel OS_MUILanuagesCode,
            MetroLabel OS_LanguageCode,
            MetroLabel OS_InstallTime,
            MetroLabel OS_LastBootUpTime
            )
        {
            OS_Caption.Text = os.Caption;
            OS_Architecture.Text = os.Architecture;
            OS_BuildNumber.Text = os.BuildNumber;
            OS_Version.Text = os.Version;
            OS_SerialNumber.Text = os.SerialNumber;
            OS_ContryCode.Text = os.ContryCode;
            OS_CurrentTimeZoneCode.Text = os.CurrentTimeZone;
            OS_MUILanuagesCode.Text = os.MUILanguages;
            OS_LanguageCode.Text = os.Language;
            DateTime time = os.InstallTime;
            OS_InstallTime.Text = time.ToString();
            DateTime time1 = ManagementDateTimeConverter.ToDateTime(os.LastBootUpTime);
            OS_LastBootUpTime.Text = time1.ToString();
        }

        public void PrintSummaryInformation(
            MetroLabel CPU_Caption,
            MetroLabel CPU_Clock,
            MetroLabel CPU_Voltage,
            MetroLabel RAM_Clock,
            MetroLabel RAM_Size,
            MetroLabel MB_Caption,
            MetroLabel MB_System_Caption,
            MetroLabel MB_Manafucturer,
            MetroLabel GPU_Caption,
            MetroLabel GPU_RAM_Size,
            MetroLabel GPU_Manafacturer,
            MetroLabel OS_Cpation,
            MetroLabel OS_Architecture,
            MetroLabel OS_Build_Number,
            MetroLabel OS_Version,
            MetroLabel OS_Install_Time,
            MetroLabel OS_Last_Time_Up_Boot_Time
            )
        {
            CPU_Caption.Text = cpu.Name;
            CPU_Clock.Text = String.Format("{0:F2} Ghz", (cpu.CurrentClock / 1000f));
            CPU_Voltage.Text = String.Format("{0:F3} V", cpu.Voltage);
            Double Pysical_Size = (ram.PysicalSize / 1024f / 1024f / 1024f);
            RAM_Clock.Text = String.Format("{0} Mhz", ram.Speed);
            RAM_Size.Text = String.Format("{0:F2} GB", Pysical_Size);
            MB_Caption.Text = bios.BaseProduct;
            MB_Manafucturer.Text = bios.BaseManufacturer;
            MB_System_Caption.Text = bios.SystemProductName;
            GPU_Caption.Text = gpu.Caption;
            GPU_RAM_Size.Text = String.Format("{0:F2} GB", (Convert.ToInt64(gpu.AdapterRAM) / 1024f / 1024f / 1024f));
            GPU_Manafacturer.Text = gpu.AdapterCompatiability;
            OS_Cpation.Text = os.Caption;
            OS_Architecture.Text = os.Architecture;
            OS_Build_Number.Text = os.BuildNumber;
            OS_Version.Text = os.Version;
            DateTime time = os.InstallTime;
            OS_Install_Time.Text = time.ToString();
            DateTime time1 = ManagementDateTimeConverter.ToDateTime(os.LastBootUpTime);
            OS_Last_Time_Up_Boot_Time.Text = time1.ToString();
        }

        #endregion

    }
}
