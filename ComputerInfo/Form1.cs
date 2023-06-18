using System;
using ComputerInfo.Graph;
using MetroSuite;
using System.ComponentModel;
using ComputerInfo.WMI;
using ComputerInfo.Source_code.tabPage;
using ComputerInfo.TabPage;
using GChartLib;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerInfo
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        //Interface arrays
        private ITabPage[] tabPageArr;
        private IGraph[] graphArr;
        //Graph
        private CPUGraph cpuGraph;
        private MemoryGraph memoryGraph;
        //DO NOT put in graphArr
        private StorageGraph storageGraph;
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

        public Form1()
        {
            InitializeComponent();

            picGpu.SizeMode = PictureBoxSizeMode.Zoom;
            picMotherboard.SizeMode = PictureBoxSizeMode.StretchImage;

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
        }

        private void BackgroundWorker_InitCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            cpuGraph = new CPUGraph(trkCpu);
            memoryGraph = new MemoryGraph(memory, trkMemory);
            storageGraph = new StorageGraph(storage, new GCircularProgress[]
            {
                gcpCUsage, gcpDUsage, gcpEUsage, gcpFUsage, gcpGUsage, gcpHUsage
            });
            graphArr = new IGraph[] { cpuGraph, memoryGraph };
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
                    lblVirtualMemorySize,
                    lblMemorySummary
                    ),
                new StorageTabPage(
                    storage,
                    new MetroLabel[]{
                        lblDiskCCaption,lblDiskCStatus,
                        lblDiskDCaption,lblDiskDStatus,
                        lblDiskECaption,lblDiskEStatus,
                        lblDiskFCaption,lblDiskFStatus,
                        lblDiskGCaption,lblDiskGStatus,
                        lblDiskHCaption,lblDiskHStatus
                    }
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
                    lblGpuDriverDate,
                    picGpu
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
                    picMotherboard
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

            foreach (ITabPage page in tabPageArr) page.update();
            storageGraph.update();

            tmrGraphUpdater.Enabled = true;
            tmrGraphUpdater.Start();

            Text = "Loading completed!";
            Invalidate(false);
            Task.Delay(3000).ContinueWith(t =>
            {
                Invoke(new MethodInvoker(delegate ()
                {
                    Text = "Computer information";
                    Invalidate(false);
                }));
            });
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
