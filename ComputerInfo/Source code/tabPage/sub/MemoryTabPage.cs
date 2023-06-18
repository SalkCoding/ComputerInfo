using ComputerInfo.Define;
using ComputerInfo.Source_code.tabPage;
using ComputerInfo.WMI;
using MetroSuite;

namespace ComputerInfo.TabPage
{
    internal class MemoryTabPage : ITabPage
    {
        private readonly Memory memory;

        private readonly MetroLabel lblMemoryManufacturer;
        private readonly MetroLabel lblMemorySpeed;
        private readonly MetroLabel lblMemoryVoltage;
        private readonly MetroLabel lblMemoryPhysicalSize;
        private readonly MetroLabel lblVirtualMemorySize;
        private readonly MetroLabel lblMemorySummary;

        public MemoryTabPage(
            Memory memory,
            MetroLabel lblMemoryManufacturer,
            MetroLabel lblMemorySpeed,
            MetroLabel lblMemoryVoltage,
            MetroLabel lblMemoryPhysicalSize,
            MetroLabel lblVirtualMemorySize,
            MetroLabel lblMemorySummary
            )
        {
            this.memory = memory;
            this.lblMemoryManufacturer = lblMemoryManufacturer;
            this.lblMemorySpeed = lblMemorySpeed;
            this.lblMemoryVoltage = lblMemoryVoltage;
            this.lblMemoryPhysicalSize = lblMemoryPhysicalSize;
            this.lblVirtualMemorySize = lblVirtualMemorySize;
            this.lblMemorySummary = lblMemorySummary;
        }

        public void update()
        {
            double physicalSize = (memory.PhysicalSize / Constants.GIGABYTE_DIVIDE_CONSTANTS);
            double virtualSize = (memory.VirtualSize / Constants.GIGABYTE_DIVIDE_CONSTANTS);
            //TODO add feature that show each memory information
            lblMemoryManufacturer.Text = memory.Manufacturer[0];
            lblMemorySpeed.Text = string.Format("{0} Mhz", memory.Speed[0]);
            lblMemoryVoltage.Text = string.Format("{0}", memory.Voltage[0]);
            lblMemoryPhysicalSize.Text = string.Format("{0:F2} GB", physicalSize);
            lblVirtualMemorySize.Text = string.Format("{0:F2} GB", virtualSize);
            lblMemorySummary.Text = string.Format("{0:S} {1:F2} GB", memory.MemoryType[0], physicalSize);
        }
    }
}
