using System;
using ComputerInfo.Graph;
using MetroSuite;
using System.Threading;
using System.ComponentModel;
using ComputerInfo.WMI;
using ComputerInfo.Source_code.tabPage;
using ComputerInfo.TabPage;
using GChartLib;

namespace ComputerInfo
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        //Interface arrays
        private ITabPage[] tabPageArr;
        private IGraph[] graphArr;
        //Graph
        private readonly CPUGraph cpuGraph;
        private readonly MemoryGraph memoryGraph;
        //DO NOT put in graphArr
        private readonly StorageGraph storageGraph;
        //Auto refresh
        private MetroComboBox[] comboBoxList;
        private MetroSwitch[] switchList;
        //WMI
        private CPU cpu;
        private Motherboard motherboard;
        private Memory memory;
        private Storage storage;
        private GPU gpu;
        private OS os;
        //Dialog
        private DetailDiskInfo diskDialog;

        private readonly bool DEBUG = true;

        public Form1()
        {
            InitializeComponent();

            if (DEBUG) return;

            cpuGraph = new CPUGraph(
                trkCpu,
                gcpCpuUsage
                );
            memoryGraph = new MemoryGraph(
                memory,
                trkMemory,
                gcpPhysicalMemoryUsage,
                gcpPhysicalMemoryUsage,
                lblPhysicalMemoryUsed,
                lblVirtualMemoryUsed
                );

            //Auto refresh
            comboBoxList = new MetroComboBox[] { cboCpuRefreshSpeed, cboMemoryRefreshSpeed };
            switchList = new MetroSwitch[] { swCpuRefresh, swMemoryRefresh };

            BackgroundWorker worker = new BackgroundWorker();
            worker.DoWork += BackgroundWorker_InitWMI;
            worker.RunWorkerCompleted += BackgroundWorker_InitCompleted;
            worker.RunWorkerAsync();
        }

        private void BackgroundWorker_InitWMI(object sender, DoWorkEventArgs e)
        {
            cpu = new CPU();
            motherboard = new Motherboard();
            memory = new Memory();
            storage = new Storage();
            gpu = new GPU();
            os = new OS();

            #region Arrays initializaion
            tabPageArr = new ITabPage[] {
                new CPUTabPage(
                    cpu,lblCpuName,
                    lblCpuClock,
                    lblCpuVoltage,
                    lblCpuL2Cache,
                    lblCpuL3Cache,
                    lblCpuCore,
                    lblCpuThread
                    ),
                new MemoryTabPage(
                    memory,
                    lblMemoryManufacturer,
                    lblMemorySpeed,
                    lblMemoryVoltage,
                    lblMemoryPhysicalSize,
                    lblVirtualMemorySize
                    ),
                new StorageTabPage(
                    storage,
                    null//TODO array needed
                    ),
                new GPUTabPage(
                    gpu,
                    lblGpuManufacturer,
                    lblGpuCaption,
                    lblGpuVideoProcessName,
                    lblGpuMemorySize,
                    lblMonitorCurrentRefreshRate,
                    lblMonitorMaxRefreshRate,
                    lblMonitorMinRefreshRate,
                    lblMonitorCurrentResolution,
                    lblGpuDriverVersion,
                    lblGpuDriverDate
                    ),
                new MotherBoardTabPage(
                    motherboard,
                    lblMotherboardManufacturer,
                    lblMotherboardProduct,
                    lblMotherboardVersion,
                    lblBiosReleaseDate,
                    lblBiosVersion,
                    lblBiosVendor,
                    lblMotherboardSystemProductName,
                    lblMotherboardSystemManufacturer,
                    lblMotherboardSystemVersion
                    ),
                new OSTabPage(
                    os,
                    lblOsCaption,
                    lblOsArchitecture,
                    lblOsBuildNumber,
                    lblOsVersion,
                    lblOsSerialNumber,
                    lblOsContryCode,
                    lblOsCurrentTimeZone,
                    lblOsMuiLanguagesCode,
                    lblOsLanguage,
                    lblOsInstallTime,
                    lblOsLastBootUpTime
                    )
            };

            graphArr = new IGraph[] { cpuGraph, memoryGraph };
            #endregion
        }

        private void BackgroundWorker_InitCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            foreach(ITabPage page in tabPageArr) page.update();

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
                combobox.SelectedIndex = speed;

            int interval;
            if (speed == 0) interval = 400;
            else if (speed == 1) interval = 1000;
            else interval = 4000;

            tmrGraphUpdater.Interval = interval;
        }

        void Auto_Refresh_Setting(bool ischeck)
        {
            tmrGraphUpdater.Enabled = !ischeck;
            foreach (MetroSwitch refresh in switchList)
                refresh.Checked = ischeck;
        }

        private void GraphUpdater_Tick(object sender, EventArgs e)
        {
            foreach (IGraph graph in graphArr)
                graph.update();
        }

        private void CpuRefreshSpeed_SelectedIndexChanged(object sender, EventArgs e) => Refresh_Timer_Setting(cboCpuRefreshSpeed.SelectedIndex);
        private void MemoryRefreshSpeed_SelectedIndexChanged(object sender, EventArgs e) => Refresh_Timer_Setting(cboMemoryRefreshSpeed.SelectedIndex);
        private void Disk_Refresh_Click(object sender, EventArgs e) => storageGraph.update();
        private void CpuRefresh_CheckedChanged(object sender, bool isChecked) => Auto_Refresh_Setting(isChecked);
        private void MemoryRefresh_CheckedChanged(object sender, bool isChecked) => Auto_Refresh_Setting(isChecked);

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
    }
}
