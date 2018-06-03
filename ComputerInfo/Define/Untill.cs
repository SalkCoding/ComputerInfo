using Microsoft.Win32;
using MetroSuite;
using System;
using System.Windows.Forms;
using System.IO;
using GChartLib;
using ComputerInfo.WMI;

namespace ComputerInfo.Define
{
    public class Untill
    {
        public static string ReadRegistry(RegistryKey key, String root, String subkey)
        {

            key = key.OpenSubKey(root, false);

            if (key == null) return "null";

            Object value = key.GetValue(subkey);
            if (value != null)
                return Convert.ToString(value);
            else
                return "null";
        }

        public static void PrintCPUInformation(
            MetroLabel CPU_Name_Label,
            MetroLabel CPU_Current_Clock_Label,
            MetroLabel CPU_Voltage_Label,
            MetroLabel CPU_L2Cache_Label,
            MetroLabel CPU_L3Cache_Label,
            MetroLabel CPU_Core_Label,
            MetroLabel CPU_Thread_Label)
        {
            CPU_Name_Label.Text = CPU.CPU_Name;
            CPU_Current_Clock_Label.Text = String.Format("{0:F2} Ghz", (CPU.CPU_Current_Clock / 1000f));
            CPU_Voltage_Label.Text = String.Format("{0:F3} V", CPU.CPU_Voltage);
            CPU_L2Cache_Label.Text = String.Format("{0:F2} Mb", (CPU.CPU_L2Cache_Size / 1024f));
            CPU_L3Cache_Label.Text = String.Format("{0:F2} Mb", (CPU.CPU_L3Cache_Size / 1024f));
            CPU_Core_Label.Text = CPU.CPU_Core_Count.ToString();
            CPU_Thread_Label.Text = CPU.CPU_Thread_Count.ToString();
        }

        public static void PrintBIOSInformation(
            MetroLabel BIOS_Base_Board_Manufacturer,
            MetroLabel BIOS_Base_Board_Product,
            MetroLabel BIOS_Base_Board_Version,
            MetroLabel BIOS_Release_Date,
            MetroLabel BIOS_Version,
            MetroLabel BIOS_Vendor,
            MetroLabel BIOS_System_Product_Name,
            MetroLabel BIOS_System_Manufacturer,
            MetroLabel BIOS_System_Version,
            WebBrowser BIOS_Logo)
        {
            BIOS_Base_Board_Manufacturer.Text = Bios.BIOS_Base_Manufacturer;
            BIOS_Base_Board_Product.Text = Bios.BIOS_Base_Product;
            BIOS_Base_Board_Version.Text = Bios.BIOS_Base_Version;
            BIOS_Release_Date.Text = Bios.BIOS_Release_Date;
            BIOS_Version.Text = Bios.BIOS_Version;
            BIOS_Vendor.Text = Bios.BIOS_Vendor;
            BIOS_System_Product_Name.Text = Bios.BIOS_System_Product_Name;
            BIOS_System_Manufacturer.Text = Bios.BIOS_System_Manufacturer;
            BIOS_System_Version.Text = Bios.BIOS_System_Version;
            String Manufacturer = Bios.BIOS_Base_Manufacturer;
            if (Manufacturer.ToLower().Contains("msi"))
                BIOS_Logo.Url = new Uri(Constants.MSI_LOGO);
            else if (Manufacturer.ToLower().Contains("asus"))
                BIOS_Logo.Url = new Uri(Constants.ASUS_LOGO);
            else if (Manufacturer.ToLower().Contains("asrock"))
                BIOS_Logo.Url = new Uri(Constants.ASROCK_LOGO);
            else if (Manufacturer.ToLower().Contains("gigabyte"))
                BIOS_Logo.Url = new Uri(Constants.GIGABYTE_LOGO);
            else if (Manufacturer.ToLower().Contains("intel"))
                BIOS_Logo.Url = new Uri(Constants.INTEL_LOGO);
            else if (Manufacturer.ToLower().Contains("biostar"))
                BIOS_Logo.Url = new Uri(Constants.BIOSTAR_LOGO);
            else if (Manufacturer.ToLower().Contains("dell"))
                BIOS_Logo.Url = new Uri(Constants.DELL_LOGO);
            else if (Manufacturer.ToLower().Contains("hp"))
                BIOS_Logo.Url = new Uri(Constants.HP_LOGO);
        }

        public static void PrintRAMInfomation(
            MetroLabel RAM_Speed,
            MetroLabel RAM_Voltage,
            MetroLabel RAM_Total_Physical_Size,
            MetroLabel RAM_Total_Virtual_Size)
        {
            Double Pysical_Size = (Memory.RAM_Pysical_Size / 1024f / 1024f / 1024f);
            Double Virtual_Size = (Memory.RAM_Pysical_Size / 1024f / 1024f / 1024f);
            RAM_Speed.Text = String.Format("{0} Mhz", Memory.RAM_Speed);
            RAM_Voltage.Text = String.Format("{0} V", Memory.RAM_Voltage);
            RAM_Total_Physical_Size.Text = String.Format("{0:F2} GB", Pysical_Size);
            RAM_Total_Virtual_Size.Text = String.Format("{0:F2} GB", Virtual_Size);
        }

        public static void PrintDiskInformation(GCircularProgress[] Progresslist, MetroLabel[] Labellist)
        {
            for (int i = Constants.DISK_MAX_COUNT; i > Disk.GetVolumeCount; i--)
            {
                for (int j = (i * 3) - 1; j > (i * 3) - 4; j--)
                {
                    Labellist[j].Text = "Not found";
                }
            }
            DriveInfo[] driver = Disk.DISK_Volumes;
            for (int i = 0; i < Disk.GetVolumeCount; i++)
            {
                Labellist[i * 3].Text = driver[i].Name;
                Labellist[(i * 3) + 1].Text = String.Format("{0:F2} GB", (Double)driver[i].TotalSize / 1024f / 1024f / 1024f);
            }
            Graph.Disk_Graph.RefreshGraph(Progresslist, Labellist);
        }

        internal static void PrintGPUInformation(
            MetroLabel GPU_Manufacturer,
            MetroLabel GPU_Caption,
            MetroLabel GPU_Video_Processor_Name,
            MetroLabel GPU_RAM,
            MetroLabel GPU_Current_Refresh_Rate,
            MetroLabel GPU_Max_Refresh_Rate,
            MetroLabel GPU_Min_Refresh_Rate,
            MetroLabel GPU_Current_Resolution,
            MetroLabel GPU_Driver_Version,
            MetroLabel GPU_Driver_Date,
            WebBrowser GPU_Logo)
        {
            if (GPU.GPU_Adapter_Compatiability.ToLower().Equals("nvidia"))
                GPU_Logo.Url = new Uri(Constants.NVIDIA_LOGO);
            else
                GPU_Logo.Url = new Uri(Constants.AMD_LOGO);
            GPU_Manufacturer.Text = GPU.GPU_Adapter_Compatiability;
            GPU_Caption.Text = GPU.GPU_Caption;
            GPU_Video_Processor_Name.Text = GPU.GPU_Video_Processor;
            GPU_RAM.Text = String.Format("{0:F2} GB", (Convert.ToInt64(GPU.GPU_Adapter_RAM) / 1024f / 1024f / 1024f));
            GPU_Current_Refresh_Rate.Text = GPU.GPU_Current_Refresh_Rate + "hz";
            GPU_Max_Refresh_Rate.Text = GPU.GPU_Max_Refresh_Rate + "hz";
            GPU_Min_Refresh_Rate.Text = GPU.GPU_Min_Refresh_Rate + "hz";
            GPU_Current_Resolution.Text = GPU.GPU_Video_Mode_Description;
            GPU_Driver_Version.Text = GPU.GPU_Driver_Version;
            DateTime driverTime = DateTime.ParseExact(GPU.GPU_Driver_Date, "yyyyMMddHHmmss", null);
            GPU_Driver_Date.Text = String.Format("{0}/{1}/{2}", driverTime.Month, driverTime.Day, driverTime.Year);
        }

        public static void PrintOSInformation()
        {

        }

        public static void PrintOtherInformation()
        {

        }

    }
}
