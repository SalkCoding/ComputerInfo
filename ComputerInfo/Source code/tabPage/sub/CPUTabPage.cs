using ComputerInfo.Source_code.tabPage;
using ComputerInfo.WMI;
using MetroSuite;

namespace ComputerInfo.TabPage
{
    internal class CPUTabPage : ITabPage
    {
        private readonly CPU cpu;

        private readonly MetroLabel lblCpuName;
        private readonly MetroLabel lblCpuClock;
        private readonly MetroLabel lblCpuVoltage;
        private readonly MetroLabel lblCpuL2Cache;
        private readonly MetroLabel lblCpuL3Cache;
        private readonly MetroLabel lblCpuCore;
        private readonly MetroLabel lblCpuThread;

        public CPUTabPage(
            CPU cpu,
            MetroLabel lblCpuName,
            MetroLabel lblCpuClock,
            MetroLabel lblCpuVoltage,
            MetroLabel lblCpuL2Cache,
            MetroLabel lblCpuL3Cache,
            MetroLabel lblCpuCore,
            MetroLabel lblCpuThread
            )
        {
            this.cpu = cpu;
            this.lblCpuName = lblCpuName;
            this.lblCpuClock = lblCpuClock;
            this.lblCpuVoltage = lblCpuVoltage;
            this.lblCpuL2Cache = lblCpuL2Cache;
            this.lblCpuL3Cache = lblCpuL3Cache;
            this.lblCpuCore = lblCpuCore;
            this.lblCpuThread = lblCpuThread;
        }

        public void update()
        {
            lblCpuName.Text = cpu.Name;
            lblCpuClock.Text = string.Format("{0:F2} Ghz", (cpu.CurrentClock / 1000f));
            lblCpuVoltage.Text = string.Format("{0:F3} V", cpu.Voltage);
            lblCpuL2Cache.Text = string.Format("{0:F2} Mb", (cpu.L2CacheSize / 1024f));
            lblCpuL3Cache.Text = string.Format("{0:F2} Mb", (cpu.L3CacheSize / 1024f));
            lblCpuCore.Text = cpu.CoreCount.ToString();
            lblCpuThread.Text = cpu.ThreadCount.ToString();
        }
    }
}
