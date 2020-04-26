using System;
using Microsoft.Win32;
using ComputerInfo.Define;

namespace ComputerInfo.WMI
{
    public class Bios
    {
        public Bios()
        {
            BIOS_Base_Manufacturer = Untill.ReadRegistry(Registry.LocalMachine, WMIQuery.REG_BIOS, WMIQuery.REG_BIOS_BASE_MANUFACTURER);
            BIOS_Base_Product = Untill.ReadRegistry(Registry.LocalMachine, WMIQuery.REG_BIOS, WMIQuery.REG_BIOS_BASE_PRODUCT);
            BIOS_Base_Version = Untill.ReadRegistry(Registry.LocalMachine, WMIQuery.REG_BIOS, WMIQuery.REG_BIOS_BASE_VERSION);
            BIOS_Release_Date = Untill.ReadRegistry(Registry.LocalMachine, WMIQuery.REG_BIOS, WMIQuery.REG_BIOS_RELEASE_DATE);
            BIOS_Version = Untill.ReadRegistry(Registry.LocalMachine, WMIQuery.REG_BIOS, WMIQuery.REG_BIOS_VERSION);
            BIOS_Vendor = Untill.ReadRegistry(Registry.LocalMachine, WMIQuery.REG_BIOS, WMIQuery.REG_BIOS_VENDOR);
            BIOS_System_Product_Name = Untill.ReadRegistry(Registry.LocalMachine, WMIQuery.REG_BIOS, WMIQuery.REG_BIOS_SYSTEM_PRODUCTNAME);
            BIOS_System_Manufacturer = Untill.ReadRegistry(Registry.LocalMachine, WMIQuery.REG_BIOS, WMIQuery.REG_BIOS_SYSTEM_MANUFACTURER);
            BIOS_System_Version = Untill.ReadRegistry(Registry.LocalMachine, WMIQuery.REG_BIOS, WMIQuery.REG_BIOS_SYSTEM_VERSION);
        }

        public String BIOS_Base_Manufacturer { get; private set; }

        public String BIOS_Base_Product { get; private set; }

        public String BIOS_Base_Version { get; private set; }

        public String BIOS_Release_Date { get; private set; }

        public String BIOS_Version { get; private set; }

        public String BIOS_Vendor { get; private set; }

        public String BIOS_System_Product_Name { get; private set; }

        public String BIOS_System_Manufacturer { get; private set; }

        public String BIOS_System_Version { get; private set; }
    }
}
