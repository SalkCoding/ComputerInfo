using ComputerInfo.Define;
using ComputerInfo.Properties;
using ComputerInfo.Source_code.tabPage;
using ComputerInfo.WMI;
using MetroSuite;
using System;
using System.Windows.Forms;

namespace ComputerInfo.TabPage
{
    internal class GPUTabPage : ITabPage
    {
        private readonly GPU gpu;

        private readonly MetroLabel lblGpuManufacturer;
        private readonly MetroLabel lblGpuCaption;
        private readonly MetroLabel lblGpuVideoProcessName;
        private readonly MetroLabel lblGpuMemorySize;
        private readonly MetroLabel lblMonitorCurrentRefreshRate;
        private readonly MetroLabel lblMonitorMaxRefreshRate;
        private readonly MetroLabel lblMonitorMinRefreshRate;
        private readonly MetroLabel lblMonitorCurrentResolution;
        private readonly MetroLabel lblGpuDriverVersion;
        private readonly MetroLabel lblGpuDriverDate;

        private readonly PictureBox picGpu;

        public GPUTabPage(
            GPU gpu,
            MetroLabel lblGpuManufacturer,
            MetroLabel lblGpuCaption,
            MetroLabel lblGpuVideoProcessName,
            MetroLabel lblGpuMemorySize,
            MetroLabel lblMonitorCurrentRefreshRate,
            MetroLabel lblMonitorMaxRefreshRate,
            MetroLabel lblMonitorMinRefreshRate,
            MetroLabel lblMonitorCurrentResolution,
            MetroLabel lblGpuDriverVersion,
            MetroLabel lblGpuDriverDate,
            PictureBox picGpu
            )
        {
            this.gpu = gpu;
            this.lblGpuManufacturer = lblGpuManufacturer;
            this.lblGpuCaption = lblGpuCaption;
            this.lblGpuVideoProcessName = lblGpuVideoProcessName;
            this.lblGpuMemorySize = lblGpuMemorySize;
            this.lblMonitorCurrentRefreshRate = lblMonitorCurrentRefreshRate;
            this.lblMonitorMaxRefreshRate = lblMonitorMaxRefreshRate;
            this.lblMonitorMinRefreshRate = lblMonitorMinRefreshRate;
            this.lblMonitorCurrentResolution = lblMonitorCurrentResolution;
            this.lblGpuDriverVersion = lblGpuDriverVersion;
            this.lblGpuDriverDate = lblGpuDriverDate;
            this.picGpu = picGpu;
        }

        public void update() 
        {
            lblGpuManufacturer.Text = gpu.AdapterCompatiability;
            lblGpuCaption.Text = gpu.Caption;
            lblGpuVideoProcessName.Text = gpu.VideoProcessor;
            lblGpuMemorySize.Text = string.Format("{0:F2} GB", (Convert.ToInt64(gpu.AdapterRAM) / Constants.GIGABYTE_DIVIDE_CONSTANTS));
            lblMonitorCurrentRefreshRate.Text = gpu.CurrentRefreshRate + "hz";
            lblMonitorMaxRefreshRate.Text = gpu.MaxRefreshRate + "hz";
            lblMonitorMinRefreshRate.Text = gpu.MinRefreshRate + "hz";
            lblMonitorCurrentResolution.Text = gpu.VideoModeDescription;
            lblGpuDriverVersion.Text = gpu.DriverVersion;
            DateTime driverTime = DateTime.ParseExact(gpu.DriverDate, "yyyyMMddHHmmss", null);
            lblGpuDriverDate.Text = string.Format("{0}/{1}/{2}", driverTime.Month, driverTime.Day, driverTime.Year);

            string caption = gpu.Caption.ToLower();
            if (caption.Contains("amd")) picGpu.Image = Resources.AMD;
            else if (caption.Contains("nvidia")) picGpu.Image = Resources.NVIDIA;
            else if (caption.Contains("intel")) picGpu.Image = Resources.INTEL;
        }
    }
}
