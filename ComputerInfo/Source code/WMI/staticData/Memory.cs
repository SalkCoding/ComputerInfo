using ComputerInfo.Define;
using System;
using System.Collections.Generic;
using System.Management;

namespace ComputerInfo.WMI
{
    class Memory : WMIQuery
    {
        private static readonly Microsoft.VisualBasic.Devices.ComputerInfo info = new Microsoft.VisualBasic.Devices.ComputerInfo();

        private static class Query
        {
            internal static readonly string WMI = @"select * from  Win32_PhysicalMemory";
            internal static readonly string Speed = "Speed";
            internal static readonly string ConfiguredVoltage = "ConfiguredVoltage";
            internal static readonly string Manufacturer = "Manufacturer";
        }

        public Memory()
        {
            IEnumerator<ManagementBaseObject> enumerator = WMIExecQuery(Query.WMI).GetEnumerator();
            while (enumerator.MoveNext())
            {
                ManagementBaseObject wmi = enumerator.Current;
                Speed = wmi[Query.Speed].ToString();
                //Not includ floating point
                int notFormatted = Convert.ToInt32(wmi[Query.ConfiguredVoltage].ToString());
                //Adding floating point
                Voltage = string.Format("%.4f", notFormatted / 1000f);
                Manufacturer = wmi[Query.Manufacturer].ToString();
            }
            PysicalSize = info.TotalPhysicalMemory;
            VirtualSize = info.TotalVirtualMemory;
        }

        public ulong PysicalSize { get; private set; }

        public ulong VirtualSize { get; private set; }

        public ulong AvailablePhysicalSize => info.AvailablePhysicalMemory;

        public ulong AvailableVirtualSize => info.AvailableVirtualMemory;

        public string Speed { get; private set; }

        public string Voltage { get; private set; }

        public string Manufacturer { get; private set; }

    }
}
