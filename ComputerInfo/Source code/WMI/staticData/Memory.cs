using ComputerInfo.Define;
using System;
using System.Collections.Generic;
using System.Management;

namespace ComputerInfo.WMI
{
    class Memory : WMIQuery
    {
        private static readonly Microsoft.VisualBasic.Devices.ComputerInfo info = new Microsoft.VisualBasic.Devices.ComputerInfo();
        //https://learn.microsoft.com/ko-kr/windows/win32/cimwin32prov/win32-heatpipe
        private static class Query
        {
            internal static readonly string WMI = @"select * from  Win32_PhysicalMemory";
            internal static readonly string Speed = "Speed";
            internal static readonly string ConfiguredVoltage = "ConfiguredVoltage";
            internal static readonly string Manufacturer = "Manufacturer";
            internal static readonly string SMBIOSMemoryType = "SMBIOSMemoryType";
        }

        public Memory()
        {
            speed = new List<string>();
            voltage = new List<string>();
            manufacturer = new List<string>();
            memoryType = new List<string>();
            IEnumerator<ManagementBaseObject> enumerator = WMIExecQuery(Query.WMI).GetEnumerator();
            while (enumerator.MoveNext())
            {
                ManagementBaseObject wmi = enumerator.Current;
                speed.Add(wmi[Query.Speed].ToString());
                //Not includ floating point
                int notFormatted = Convert.ToInt32(wmi[Query.ConfiguredVoltage].ToString());
                //Adding floating point
                voltage.Add(string.Format("{0:F4} V", notFormatted / 1000.0));
                manufacturer.Add(wmi[Query.Manufacturer].ToString());
                switch (wmi[Query.SMBIOSMemoryType].ToString())
                {
                    //IDK DDR5 value
                    case "26":
                        memoryType.Add("DDR4");
                        break;
                    case "24":
                        memoryType.Add("DDR3");
                        break;
                    case "21":
                        memoryType.Add("DDR2");
                        break;
                    case "20":
                        memoryType.Add("DDR1");
                        break;
                    default:
                        memoryType.Add("UNKNOWN");
                        break;
                }
            }
            PhysicalSize = info.TotalPhysicalMemory;
            VirtualSize = info.TotalVirtualMemory;
        }

        public ulong PhysicalSize { get; private set; }

        public ulong VirtualSize { get; private set; }

        public ulong AvailablePhysicalSize => info.AvailablePhysicalMemory;

        public ulong AvailableVirtualSize => info.AvailableVirtualMemory;

        private readonly List<string> speed;
        public string[] Speed => speed.ToArray();

        private readonly List<string> voltage;
        public string[] Voltage => voltage.ToArray();

        private readonly List<string> manufacturer;
        public string[] Manufacturer => manufacturer.ToArray();

        private readonly List<string> memoryType;
        public string[] MemoryType => memoryType.ToArray();

    }
}
