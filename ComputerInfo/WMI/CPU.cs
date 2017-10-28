using System;
using System.Management;
using ComputerInfo.Define;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerInfo.WMI
{
    public class CPU
    {
        private static String CPU_NAME;
        private static Int32 CPU_CURRENT_CLOCK;
        private static Double CPU_VOLTAGE;
        private static Int32 CPU_L2CACHE_SIZE;
        private static Int32 CPU_L3CACHE_SIZE;
        private static Int32 CPU_CORE_COUNT;
        private static Int32 CPU_THREAD_COUNT;

        public static void Initialization()
        {
            foreach (ManagementObject wmi in new ManagementObjectSearcher(Constants.WMI_CPU).Get())
            {
                try
                {
                    CPU_NAME = wmi[Constants.WMI_CPU_NAME].ToString();
                    CPU_CURRENT_CLOCK = Convert.ToInt32(wmi[Constants.WMI_CPU_MAX_CLOCK]);
                    CPU_VOLTAGE = Convert.ToDouble(wmi[Constants.WMI_CPU_VOLTAGE]) / 10;
                    CPU_L2CACHE_SIZE = Convert.ToInt32(wmi[Constants.WMI_CPU_L2CACHE_SIZE]);
                    CPU_L3CACHE_SIZE = Convert.ToInt32(wmi[Constants.WMI_CPU_L3CACHE_SIZE]);
                    CPU_CORE_COUNT = Convert.ToInt32(wmi[Constants.WMI_CPU_CORE_COUNT]);
                    CPU_THREAD_COUNT = Convert.ToInt32(wmi[Constants.WMI_CPU_THREAD_COUNT]);
                }
                catch
                {
                    continue;
                }
            }
        }

        public static String CPU_Name => CPU_NAME;

        public static Int32 CPU_Current_Clock => CPU_CURRENT_CLOCK;

        public static Double CPU_Voltage => CPU_VOLTAGE;

        public static Int32 CPU_L2Cache_Size => CPU_L2CACHE_SIZE;

        public static Int32 CPU_L3Cache_Size => CPU_L3CACHE_SIZE;

        public static Int32 CPU_Core_Count => CPU_CORE_COUNT;

        public static Int32 CPU_Thread_Count => CPU_THREAD_COUNT;

    }
}
