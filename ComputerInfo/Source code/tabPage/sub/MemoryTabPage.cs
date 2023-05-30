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

        public MemoryTabPage(
            Memory memory,
            MetroLabel lblMemoryManufacturer,
            MetroLabel lblMemorySpeed,
            MetroLabel lblMemoryVoltage,
            MetroLabel lblMemoryPhysicalSize,
            MetroLabel lblVirtualMemorySize
            )
        {
            this.memory = memory;
            this.lblMemoryManufacturer = lblMemoryManufacturer;
            this.lblMemorySpeed = lblMemorySpeed;
            this.lblMemoryVoltage = lblMemoryVoltage;
            this.lblMemoryPhysicalSize = lblMemoryPhysicalSize;
            this.lblVirtualMemorySize = lblVirtualMemorySize;
        }

        public void update()
        {
            double Pysical_Size = (memory.PysicalSize / Constants.GIGABYTE_DIVIDE_CONSTANTS);
            double Virtual_Size = (memory.VirtualSize / Constants.GIGABYTE_DIVIDE_CONSTANTS);
            lblMemoryManufacturer.Text = memory.Manufacturer;
            lblMemorySpeed.Text = string.Format("{0} Mhz", memory.Speed);
            lblMemoryVoltage.Text = string.Format("{0} V", memory.Voltage);
            lblMemoryPhysicalSize.Text = string.Format("{0:F2} GB", Pysical_Size);
            lblVirtualMemorySize.Text = string.Format("{0:F2} GB", Virtual_Size);
        }
    }
}
