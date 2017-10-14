using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerInfo.WMI
{
    class Memory
    {

        private static UInt64 RAM_Total_Physical_Size;
        private static UInt64 RAM_Total_Virtual_Size;
        private static Microsoft.VisualBasic.Devices.ComputerInfo info = new Microsoft.VisualBasic.Devices.ComputerInfo();

        public static void Initialization()
        {
            RAM_Total_Physical_Size = info.TotalPhysicalMemory;
            RAM_Total_Virtual_Size = info.TotalVirtualMemory;
        }

        public static UInt64 RAM_Pysical_Size => RAM_Total_Physical_Size;

        public static UInt64 RAM_Virtual_Size => RAM_Total_Virtual_Size;

        public static UInt64 RAM_Available_Physical => info.AvailablePhysicalMemory;

        public static UInt64 RAM_Available_Virtual => info.AvailableVirtualMemory;

    }
}
