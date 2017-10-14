using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
using ComputerInfo.Define;

namespace ComputerInfo.WMI
{
    public class Bios
    {
        private static String BIOS_BASE_MANUFACTURER;
        private static String BIOS_BASE_PRODUCT;
        private static String BIOS_BASE_VERSION;
        private static String BIOS_RELEASE_DATE;
        private static String BIOS_VERSION;
        private static String BIOS_VENDOR;
        private static String BIOS_SYSTEM_PRODUCTNAME;
        private static String BIOS_SYSTEM_MANUFACTURER;
        private static String BIOS_SYSTEM_VERSION;

        public static void Initialization()
        {
            BIOS_BASE_MANUFACTURER = Untill.ReadRegistry(Registry.LocalMachine, Constants.REG_BIOS, Constants.REG_BIOS_BASE_MANUFACTURER);
            BIOS_BASE_PRODUCT = Untill.ReadRegistry(Registry.LocalMachine, Constants.REG_BIOS, Constants.REG_BIOS_BASE_PRODUCT);
            BIOS_BASE_VERSION = Untill.ReadRegistry(Registry.LocalMachine, Constants.REG_BIOS, Constants.REG_BIOS_BASE_VERSION);
            BIOS_RELEASE_DATE = Untill.ReadRegistry(Registry.LocalMachine, Constants.REG_BIOS, Constants.REG_BIOS_RELEASE_DATE);
            BIOS_VERSION = Untill.ReadRegistry(Registry.LocalMachine, Constants.REG_BIOS, Constants.REG_BIOS_VERSION);
            BIOS_VENDOR = Untill.ReadRegistry(Registry.LocalMachine, Constants.REG_BIOS, Constants.REG_BIOS_VENDOR);
            BIOS_SYSTEM_PRODUCTNAME = Untill.ReadRegistry(Registry.LocalMachine, Constants.REG_BIOS, Constants.REG_BIOS_SYSTEM_PRODUCTNAME);
            BIOS_SYSTEM_MANUFACTURER = Untill.ReadRegistry(Registry.LocalMachine, Constants.REG_BIOS, Constants.REG_BIOS_SYSTEM_MANUFACTURER);
            BIOS_SYSTEM_VERSION = Untill.ReadRegistry(Registry.LocalMachine, Constants.REG_BIOS, Constants.REG_BIOS_SYSTEM_VERSION);
        }

        public static String BIOS_Base_Manufacturer => BIOS_BASE_MANUFACTURER;

        public static String BIOS_Base_Product => BIOS_BASE_PRODUCT;
        
        public static String BIOS_Base_Version => BIOS_BASE_VERSION;

        public static String BIOS_Release_Date => BIOS_RELEASE_DATE;

        public static String BIOS_Version => BIOS_VERSION;

        public static String BIOS_Vendor => BIOS_VENDOR;

        public static String BIOS_System_Product_Name => BIOS_SYSTEM_PRODUCTNAME;

        public static String BIOS_System_Manufacturer => BIOS_SYSTEM_MANUFACTURER;

        public static String BIOS_System_Version => BIOS_SYSTEM_VERSION;

    }
}
