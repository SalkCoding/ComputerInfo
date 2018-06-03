using System;
using ComputerInfo.Define;
using System.Management;

namespace ComputerInfo.WMI
{
    class GPU
    {
        public static void Initialization()
        {
            foreach (ManagementObject wmi in new ManagementObjectSearcher(WMIQuery.WMI_GPU).Get())
            {
                try
                {
                    GPU_Adapter_Compatiability = wmi[WMIQuery.WMI_GPU_ADAPTER_COMPATIABILITY].ToString();
                    GPU_Adapter_RAM = wmi[WMIQuery.WMI_GPU_ADAPTER_RAM].ToString();
                    GPU_Caption = wmi[WMIQuery.WMI_GPU_CAPTION].ToString();
                    GPU_Current_Refresh_Rate = wmi[WMIQuery.WMI_GPU_CURRENT_REFRESH_RATE].ToString();
                    GPU_Driver_Date = wmi[WMIQuery.WMI_GPU_DRIVER_DATE].ToString();
                    GPU_Driver_Version = wmi[WMIQuery.WMI_GPU_DRIVER_VERSION].ToString();
                    GPU_Max_Refresh_Rate = wmi[WMIQuery.WMI_GPU_MAX_REFRESH_RATE].ToString();
                    GPU_Min_Refresh_Rate = wmi[WMIQuery.WMI_GPU_MIN_REFRESH_RATE].ToString();
                    GPU_Video_Mode_Description = wmi[WMIQuery.WMI_GPU_VIDEO_MODE_DESCRIPTION].ToString();
                    GPU_Video_Processor = wmi[WMIQuery.WMI_GPU_VIDEO_PROCESSOR].ToString();
                }
                catch
                {
                    continue;
                }
            }
            GPU_Driver_Date = GPU_Driver_Date.Split('.')[0];
        }

        //Company name
        public static String GPU_Adapter_Compatiability { get; private set; }

        public static String GPU_Adapter_RAM { get; private set; }

        //Full name with company name
        public static String GPU_Caption { get; private set; }

        public static String GPU_Current_Refresh_Rate { get; private set; }

        public static String GPU_Driver_Date { get; private set; }

        public static String GPU_Driver_Version { get; private set; }

        public static String GPU_Max_Refresh_Rate { get; private set; }

        public static String GPU_Min_Refresh_Rate { get; private set; }

        public static String GPU_Video_Mode_Description { get; private set; }

        //Get graphic card name that except company name
        public static String GPU_Video_Processor { get; private set; }

    }
}
