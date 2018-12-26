using System;
using System.Management;
using ComputerInfo.Define;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace ComputerInfo.WMI
{
    class OperatingSystem
    {
        public static void Initialization()
        {
            foreach (ManagementBaseObject wmi in new ManagementObjectSearcher(WMIQuery.WMI_OS).Get())
            {
                String[] MUI= null;
                try
                {
                    OS_Caption = wmi[WMIQuery.WMI_OS_NAME].ToString();
                    OS_Architecture = wmi[WMIQuery.WMI_OS_ARCHITECTURE].ToString();
                    OS_Build_Number = wmi[WMIQuery.WMI_OS_BUILD_NUMBER].ToString();
                    OS_Version = wmi[WMIQuery.WMI_OS_VERSION].ToString();
                    OS_Serial_Number = wmi[WMIQuery.WMI_OS_SERIALNUMBER].ToString();
                    OS_Last_Boot_Up_Time = wmi[WMIQuery.WMI_OS_LASTBOOTUPTIME].ToString();
                    OS_Contry_Code = wmi[WMIQuery.WMI_OS_CONTRY_CODE].ToString();
                    OS_Current_Time_Zone = wmi[WMIQuery.WMI_OS_CURRENT_TIME_ZONE].ToString();
                    MUI = (String[])wmi[WMIQuery.WMI_OS_MUI_LANGUAGES];
                    OS_Language = wmi[WMIQuery.WMI_OS_LANGUAGE].ToString();
                }
                catch
                {
                    continue;
                }
                var time = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
                time = time.AddSeconds(Convert.ToInt64(Untill.ReadRegistry(Registry.LocalMachine, WMIQuery.REG_OS, WMIQuery.REG_OS_INSTALLDATE)));
                OS_Install_Time = time;
                OS_MUI_Languages = "";
                if (MUI.Length <= 1)
                    OS_MUI_Languages = MUI[0];
                else
                    foreach (String str in MUI)
                        OS_MUI_Languages += str + " ";
            }
        }

        public static String OS_Caption { get; set; }

        public static String OS_Architecture { get; set; }

        public static String OS_Build_Number { get; set; }

        public static String OS_Version { get; set; }

        public static String OS_Serial_Number { get; set; }

        public static String OS_Product_Key { get; set; }

        public static String OS_Contry_Code { get; set; }

        public static String OS_Current_Time_Zone { get; set; }

        public static String OS_MUI_Languages { get; set; }

        public static String OS_Language { get; set; }

        public static String OS_Last_Boot_Up_Time { get; set; }

        public static DateTime OS_Install_Time { get; set; }

    }
}
