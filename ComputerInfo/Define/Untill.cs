using Microsoft.Win32;
using MetroSuite;
using System;
using System.Windows.Forms;
using System.IO;
using GChartLib;
using ComputerInfo.WMI;
using System.Collections;
using System.Management;

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
            DriveInfo[] driver = Disk.DISK_Volumes.ToArray();
            int count = Disk.GetVolumeCount;
            if (count > 6)
                count = 6;
            for (int i = 0; i < count; i++)
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
            String company = GPU.GPU_Adapter_Compatiability.ToLower();
            if (company.Contains("nvidia"))
                GPU_Logo.Url = new Uri(Constants.NVIDIA_LOGO);
            else if (company.Contains("intel"))
                GPU_Logo.Url = new Uri(Constants.INTEL_LOGO);
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

        public static void PrintOSInformation(
            MetroLabel OS_Caption,
            MetroLabel OS_Architecture,
            MetroLabel OS_BuildNumber,
            MetroLabel OS_Version,
            MetroLabel OS_SerialNumber,
            MetroLabel OS_ProductKey,
            MetroLabel OS_ContryCode,
            MetroLabel OS_CurrentTimeZoneCode,
            MetroLabel OS_MUILanuagesCode,
            MetroLabel OS_LanguageCode,
            MetroLabel OS_InstallTime,
            MetroLabel OS_LastBootUpTime
            )
        {
            OS_Caption.Text = WMI.OperatingSystem.OS_Caption;
            OS_Architecture.Text = WMI.OperatingSystem.OS_Architecture;
            OS_BuildNumber.Text = WMI.OperatingSystem.OS_Build_Number;
            OS_Version.Text = WMI.OperatingSystem.OS_Version;
            OS_SerialNumber.Text = WMI.OperatingSystem.OS_Version;
            try
            {
                OS_ProductKey.Text = GetWindowsProductKey();
            }
            catch { }
            OS_ContryCode.Text = WMI.OperatingSystem.OS_Contry_Code;
            OS_CurrentTimeZoneCode.Text = WMI.OperatingSystem.OS_Current_Time_Zone;
            OS_MUILanuagesCode.Text = WMI.OperatingSystem.OS_MUI_Languages;
            OS_LanguageCode.Text = WMI.OperatingSystem.OS_Language;
            DateTime time = WMI.OperatingSystem.OS_Install_Time;
            OS_InstallTime.Text = time.ToString();
            DateTime time1 = ManagementDateTimeConverter.ToDateTime(WMI.OperatingSystem.OS_Last_Boot_Up_Time);
            OS_LastBootUpTime.Text = time1.ToString();
        }

        public static void PrintOtherInformation()
        {

        }

        public static string DecodeProductKeyWin8AndUp(byte[] digitalProductId)
        {
            var key = String.Empty;
            const int keyOffset = 52;
            var isWin8 = (byte)((digitalProductId[66] / 6) & 1);
            digitalProductId[66] = (byte)((digitalProductId[66] & 0xf7) | (isWin8 & 2) * 4);

            // Possible alpha-numeric characters in product key.
            const string digits = "BCDFGHJKMPQRTVWXY2346789";
            int last = 0;
            for (var i = 24; i >= 0; i--)
            {
                var current = 0;
                for (var j = 14; j >= 0; j--)
                {
                    current = current * 256;
                    current = digitalProductId[j + keyOffset] + current;
                    digitalProductId[j + keyOffset] = (byte)(current / 24);
                    current = current % 24;
                    last = current;
                }
                key = digits[current] + key;
            }
            var keypart1 = key.Substring(1, last);
            const string insert = "N";
            key = key.Substring(1).Replace(keypart1, keypart1 + insert);
            if (last == 0)
                key = insert + key;
            for (var i = 5; i < key.Length; i += 6)
            {
                key = key.Insert(i, "-");
            }
            return key;
        }

        public static string DecodeProductKey(byte[] digitalProductId)
        {
            // Offset of first byte of encoded product key in 
            //  'DigitalProductIdxxx" REG_BINARY value. Offset = 34H.
            const int keyStartIndex = 52;
            // Offset of last byte of encoded product key in 
            //  'DigitalProductIdxxx" REG_BINARY value. Offset = 43H.
            const int keyEndIndex = keyStartIndex + 15;
            // Possible alpha-numeric characters in product key.
            char[] digits = new char[]
      {
        'B', 'C', 'D', 'F', 'G', 'H', 'J', 'K', 'M', 'P', 'Q', 'R',
        'T', 'V', 'W', 'X', 'Y', '2', '3', '4', '6', '7', '8', '9',
      };
            // Length of decoded product key
            const int decodeLength = 29;
            // Length of decoded product key in byte-form.
            // Each byte represents 2 chars.
            const int decodeStringLength = 15;
            // Array of containing the decoded product key.
            char[] decodedChars = new char[decodeLength];
            // Extract byte 52 to 67 inclusive.
            ArrayList hexPid = new ArrayList();
            for (int i = keyStartIndex; i <= keyEndIndex; i++)
            {
                hexPid.Add(digitalProductId[i]);
            }
            for (int i = decodeLength - 1; i >= 0; i--)
            {
                // Every sixth char is a separator.
                if ((i + 1) % 6 == 0)
                {
                    decodedChars[i] = '-';
                }
                else
                {
                    // Do the actual decoding.
                    int digitMapIndex = 0;
                    for (int j = decodeStringLength - 1; j >= 0; j--)
                    {
                        int byteValue = (digitMapIndex << 8) | (byte)hexPid[j];
                        hexPid[j] = (byte)(byteValue / 24);
                        digitMapIndex = byteValue % 24;
                        decodedChars[i] = digits[digitMapIndex];
                    }
                }
            }
            return new string(decodedChars);
        }

        public static string GetWindowsProductKey()
        {
            var key = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine,
                                          RegistryView.Default);
            const string keyPath = @"Software\Microsoft\Windows NT\CurrentVersion";
            var digitalProductId = (byte[])key.OpenSubKey(keyPath).GetValue("DigitalProductId4");

            var isWin8OrUp =
                (Environment.OSVersion.Version.Major == 6 && System.Environment.OSVersion.Version.Minor >= 2)
                ||
                (Environment.OSVersion.Version.Major > 6);

            var productKey = isWin8OrUp ? DecodeProductKeyWin8AndUp(digitalProductId) : DecodeProductKey(digitalProductId);
            return productKey;
        }

    }
}
