using Microsoft.Win32;
using MetroSuite;
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.AccessControl;

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
            CPU_Name_Label.Text = WMI.CPU.CPU_Name;
            CPU_Current_Clock_Label.Text = String.Format("{0:F2} Ghz", (WMI.CPU.CPU_Current_Clock / 1000f));
            CPU_Voltage_Label.Text = String.Format("{0:F3} V", WMI.CPU.CPU_Voltage);
            CPU_L2Cache_Label.Text = String.Format("{0:F2} Mb", (WMI.CPU.CPU_L2Cache_Size / 1024f));
            CPU_L3Cache_Label.Text = String.Format("{0:F2} Mb", (WMI.CPU.CPU_L3Cache_Size / 1024f));
            CPU_Core_Label.Text = WMI.CPU.CPU_Core_Count.ToString();
            CPU_Thread_Label.Text = WMI.CPU.CPU_Thread_Count.ToString();
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
            BIOS_Base_Board_Manufacturer.Text = WMI.Bios.BIOS_Base_Manufacturer;
            BIOS_Base_Board_Product.Text = WMI.Bios.BIOS_Base_Product;
            BIOS_Base_Board_Version.Text = WMI.Bios.BIOS_Base_Version;
            BIOS_Release_Date.Text = WMI.Bios.BIOS_Release_Date;
            BIOS_Version.Text = WMI.Bios.BIOS_Version;
            BIOS_Vendor.Text = WMI.Bios.BIOS_Vendor;
            BIOS_System_Product_Name.Text = WMI.Bios.BIOS_System_Product_Name;
            BIOS_System_Manufacturer.Text = WMI.Bios.BIOS_System_Manufacturer;
            BIOS_System_Version.Text = WMI.Bios.BIOS_System_Version;
            String Manufacturer = WMI.Bios.BIOS_Base_Manufacturer;
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
            Double Pysical_Size = (WMI.Memory.RAM_Pysical_Size / 1024f / 1024f / 1024f);
            Double Virtual_Size = (WMI.Memory.RAM_Pysical_Size / 1024f / 1024f / 1024f);
            RAM_Speed.Text = String.Format("{0} Mhz",WMI.Memory.RAM_Speed);
            RAM_Voltage.Text = String.Format("{0} V",WMI.Memory.RAM_Voltage);
            RAM_Total_Physical_Size.Text = String.Format("{0:F2} GB", Pysical_Size);
            RAM_Total_Virtual_Size.Text = String.Format("{0:F2} GB", Virtual_Size);
        }

        public static void PrintGPUInformation()
        {

        }

        public static void PrintDiskInformation()
        {

        }

        public static void PrintOSInformation()
        {

        }

        public static void PrintOtherInformation()
        {

        }

    }
}
