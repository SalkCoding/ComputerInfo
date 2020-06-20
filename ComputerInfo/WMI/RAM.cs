using ComputerInfo.Define;
using System;
using System.Management;

namespace ComputerInfo.WMI
{
    class RAM
    {
        private static readonly Microsoft.VisualBasic.Devices.ComputerInfo info = new Microsoft.VisualBasic.Devices.ComputerInfo();

        public RAM()
        {
            var iter = WMIQuery.WMIExecQuery(WMIQuery.RAM.Query).GetEnumerator();
            while (iter.MoveNext())
            {
                var wmi = iter.Current;
                Speed = wmi[WMIQuery.RAM.Speed].ToString();
                Voltage = wmi[WMIQuery.RAM.ConfiguredVoltage].ToString().Insert(1, ".");
                Manufacturer = wmi[WMIQuery.RAM.Manufacturer].ToString();
            }
            PysicalSize = info.TotalPhysicalMemory;
            VirtualSize = info.TotalVirtualMemory;
        }

        public UInt64 PysicalSize { get; private set; }

        public UInt64 VirtualSize { get; private set; }

        public UInt64 AvailablePhysicalSize => info.AvailablePhysicalMemory;

        public UInt64 AvailableVirtualSize => info.AvailableVirtualMemory;

        public String Speed { get; private set; }

        public String Voltage { get; private set; }

        public String Manufacturer { get; private set; }

    }
}
