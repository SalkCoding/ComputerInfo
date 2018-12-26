using System;
using System.Management;
using ComputerInfo.Define;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ComputerInfo.WMI
{
    public class CPU
    {
        public static void Initialization()
        {
            foreach (ManagementObject wmi in new ManagementObjectSearcher(WMIQuery.WMI_CPU).Get())
            {
                try
                {
                    CPU_Name = wmi[WMIQuery.WMI_CPU_NAME].ToString();
                    CPU_Current_Clock = Convert.ToInt32(wmi[WMIQuery.WMI_CPU_MAX_CLOCK]);
                    CPU_Voltage = Convert.ToDouble(wmi[WMIQuery.WMI_CPU_VOLTAGE]) / 10;
                    CPU_L2Cache_Size = Convert.ToInt32(wmi[WMIQuery.WMI_CPU_L2CACHE_SIZE]);
                    CPU_L3Cache_Size = Convert.ToInt32(wmi[WMIQuery.WMI_CPU_L3CACHE_SIZE]);
                    CPU_Core_Count = Convert.ToInt32(wmi[WMIQuery.WMI_CPU_CORE_COUNT]);
                    CPU_Thread_Count = Convert.ToInt32(wmi[WMIQuery.WMI_CPU_THREAD_COUNT]);
                }
                catch
                {
                    continue;
                }
            }
        }

        public static String CPU_Name { get; private set; }

        public static Int32 CPU_Current_Clock { get; private set; }

        public static Double CPU_Voltage { get; private set; }

        public static Int32 CPU_L2Cache_Size { get; private set; }

        public static Int32 CPU_L3Cache_Size { get; private set; }

        public static Int32 CPU_Core_Count { get; private set; }

        public static Int32 CPU_Thread_Count { get; private set; }
    }
}
