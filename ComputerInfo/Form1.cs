using System;
using ComputerInfo.Graph;
using ComputerInfo.Define;
using GChartLib;
using MetroSuite;
using System.Threading;
using System.ComponentModel;

namespace ComputerInfo
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {

        CPU_Graph Cpu_Graph = new CPU_Graph();
        RAM_Graph Ram_Graph = new RAM_Graph();
        //Auto refresh
        MetroComboBox[] ComboBoxlist;
        MetroSwitch[] Switchlist;
        System.Windows.Forms.Timer[] Timerlist;
        //Disk
        GCircularProgress[] Progresslist;
        MetroLabel[] Labellist;

        public Form1()
        {
            //init
            InitializeComponent();
            Visible = false;
            BackgroundWorker worker = new BackgroundWorker
            {
                WorkerReportsProgress = true,
                WorkerSupportsCancellation = false
            };
            worker.RunWorkerCompleted += delegate
            {
                Text = "Loading...";
                Invalidate();
                WMI.CPU.Initialization();
                WMI.Bios.Initialization();
                WMI.Memory.Initialization();
                WMI.Disk.Initialization();
                WMI.GPU.Initialization();
                WMI.OperatingSystem.Initialization();

                //Auto refresh
                ComboBoxlist = new MetroComboBox[] { Refresh_Speed, RAM_Refresh_Speed };
                Switchlist = new MetroSwitch[] { Refresh_Switch, RAM_Auto_Refresh };
                Timerlist = new System.Windows.Forms.Timer[] { timer1 };
                //Disk
                Labellist = new MetroLabel[] {
                Disk_C_Caption, Disk_C_Total, Disk_C_Used,
                Disk_D_Caption, Disk_D_Total, Disk_D_Used,
                Disk_E_Caption, Disk_E_Total, Disk_E_Used,
                Disk_F_Caption, Disk_F_Total, Disk_F_Used,
                Disk_G_Caption, Disk_G_Total, Disk_G_Used,
                Disk_H_Caption, Disk_H_Total, Disk_H_Used };
                Progresslist = new GCircularProgress[] {
                Disk_C_Progress, Disk_D_Progress, Disk_E_Progress,
                Disk_F_Progress, Disk_G_Progress, Disk_H_Progress };

                CPU_Tracker.Paths.Add(Cpu_Graph.GraphPath);
                RAM_Tracker.Paths.Add(Ram_Graph.GraphPath);
                Untill.PrintCPUInformation(CPUName, CPU_Clock, CPU_Voltage, CPU_L2CACHE, CPU_L3CACHE, CPU_CORE, CPU_THREAD);
                Untill.PrintBIOSInformation(BIOS_Base_Board_Manufacturer, BIOS_Base_Board_Product, BIOS_Base_Board_Version, BIOS_Release_Date, BIOS_Version, BIOS_Vendor, BIOS_System_Product_Name, BIOS_System_Manufacturer, BIOS_System_Version, BIOS_Logo);
                Untill.PrintRAMInfomation(RAM_Manufacturer, RAM_Speed, RAM_Voltage, RAM_Physical_Size, RAM_Virtual_Size);
                Untill.PrintDiskInformation(Progresslist, Labellist);
                Untill.PrintGPUInformation(GPU_Manufacturer, GPU_Caption, GPU_Video_Processor_Name, GPU_RAM, GPU_Current_Refresh_Rate, GPU_Max_Refresh_Rate, GPU_Min_Refresh_Rate, GPU_Current_Resolution, GPU_Driver_Version, GPU_Driver_Date, GPU_Logo);
                Untill.PrintOSInformation(OS_Caption, OS_Architecture, OS_BuildNumber, OS_Version, OS_SerialNumber, OS_ProductKey, OS_ContryCode, OS_CurrentTimeZone, OS_MUILanguages, OS_Language, OS_InstallTime, OS_LastBootUpTime);
                Untill.PrintSummaryInformation(
                    Summary_CPU_Caption,
                    Summary_CPU_Clock,
                    Summary_CPU_Voltage,
                    Summary_RAM_Clock,
                    Summary_RAM_Size,
                    Summary_MB_Caption,
                    Summary_MB_System_Caption,
                    Summary_MB_Manufacturer,
                    Summary_GPU_Caption,
                    Summary_GPU_RAM,
                    Summary_GPU_Manufacturer,
                    Summary_OS_Caption,
                    Summary_OS_Architecturer,
                    Summary_OS_Build_Number,
                    Summary_OS_Version,
                    Summary_OS_Install_Time,
                    Summary_OS_Last_Boot_Up_Time
                    );
                timer1.Enabled = true;
                Text = "Loading completed!";
                Invalidate();
                BackgroundWorker w = new BackgroundWorker();
                w.RunWorkerCompleted += delegate { Text = "Computer information"; Invalidate(); };
                w.DoWork += delegate { Thread.Sleep(5000); };
                w.RunWorkerAsync();
            };
            worker.RunWorkerAsync();
        }

        void Refresh_Timer_Setting(int speed)
        {
            foreach (MetroComboBox combobox in ComboBoxlist)
            {
                combobox.SelectedIndex = speed;
            }
            switch (speed)
            {
                case 0:
                    foreach (System.Windows.Forms.Timer timer in Timerlist)
                        timer.Interval = 400;
                    break;
                case 1:
                    foreach (System.Windows.Forms.Timer timer in Timerlist)
                        timer.Interval = 1000;
                    break;
                case 2:
                    foreach (System.Windows.Forms.Timer timer in Timerlist)
                        timer.Interval = 4000;
                    break;
            }
        }

        void Auto_Refresh_Setting(bool ischeck)
        {
            if (!ischeck)
            {
                foreach (System.Windows.Forms.Timer timer in Timerlist)
                    timer.Enabled = true;
                foreach (MetroSwitch refresh in Switchlist)
                    refresh.Checked = false;
            }
            else
            {
                foreach (System.Windows.Forms.Timer timer in Timerlist)
                    timer.Enabled = false;
                foreach (MetroSwitch refresh in Switchlist)
                    refresh.Checked = true;
            }
        }

        #region events

        private void Timer1_Tick(object sender, EventArgs e)
        {
            Cpu_Graph.RefreshGraph(CPU_Tracker, CPU_Usage);
            Ram_Graph.RefreshGraph(RAM_Tracker, RAM_Physical_Progress, RAM_Virtual_Progress, RAM_Physical_Used, RAM_Virtual_Used);
        }

        private void Disk_Refresh_Click(object sender, EventArgs e)
        {
            Disk_Graph.RefreshGraph(Progresslist, Labellist);
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

        /*private void Disk_More_Info_Click(object sender, EventArgs e)
        {
            var form = new DiskMoreInfo();
            if(form.IsDisposed)
                form.Show();
        }*/

        #endregion

    }
}
