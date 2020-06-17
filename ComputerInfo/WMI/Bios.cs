using System;
using Microsoft.Win32;
using ComputerInfo.Define;

namespace ComputerInfo.WMI
{
    public class Bios
    {
        public Bios()
        {
            BaseManufacturer = Untill.ReadRegistry(Registry.LocalMachine, WMIQuery.Bios.Query, WMIQuery.Bios.BaseBoardManufacturer);
            BaseProduct = Untill.ReadRegistry(Registry.LocalMachine, WMIQuery.Bios.Query, WMIQuery.Bios.BaseBoardProduct);
            BaseVersion = Untill.ReadRegistry(Registry.LocalMachine, WMIQuery.Bios.Query, WMIQuery.Bios.BaseBoardVersion);
            ReleaseDate = Untill.ReadRegistry(Registry.LocalMachine, WMIQuery.Bios.Query, WMIQuery.Bios.BiosReleaseDate);
            BiosVersion = Untill.ReadRegistry(Registry.LocalMachine, WMIQuery.Bios.Query, WMIQuery.Bios.BiosVersion);
            BiosVendor = Untill.ReadRegistry(Registry.LocalMachine, WMIQuery.Bios.Query, WMIQuery.Bios.BiosVendor);
            SystemProductName = Untill.ReadRegistry(Registry.LocalMachine, WMIQuery.Bios.Query, WMIQuery.Bios.SystemProductName);
            SystemManufacturer = Untill.ReadRegistry(Registry.LocalMachine, WMIQuery.Bios.Query, WMIQuery.Bios.SystemManufacturer);
            SystemVersion = Untill.ReadRegistry(Registry.LocalMachine, WMIQuery.Bios.Query, WMIQuery.Bios.SystemVersion);
        }

        public String BaseManufacturer { get; private set; }

        public String BaseProduct { get; private set; }

        public String BaseVersion { get; private set; }

        public String ReleaseDate { get; private set; }

        public String BiosVersion { get; private set; }

        public String BiosVendor { get; private set; }

        public String SystemProductName { get; private set; }

        public String SystemManufacturer { get; private set; }

        public String SystemVersion { get; private set; }
    }
}
