using Microsoft.Win32;
using ComputerInfo.Define;

namespace ComputerInfo.WMI
{

    public class Motherboard:WMIQuery
    {
        private static class Query
        {
            internal static readonly string Root = @"HARDWARE\DESCRIPTION\System\BIOS";
            internal static readonly string BaseBoardManufacturer = "BaseBoardManufacturer";
            internal static readonly string BaseBoardProduct = "BaseBoardProduct";
            internal static readonly string BaseBoardVersion = "BaseBoardVersion";
            internal static readonly string BiosReleaseDate = "BIOSReleaseDate";
            internal static readonly string BiosVersion = "BIOSVersion";
            internal static readonly string BiosVendor = "BIOSVendor";
            internal static readonly string SystemProductName = "SystemProductName";
            internal static readonly string SystemManufacturer = "SystemManufacturer";
        }

        public Motherboard()
        {
            BaseManufacturer = RegistryReader.ReadRegistry(Registry.LocalMachine, Query.Root, Query.BaseBoardManufacturer);
            BaseProduct = RegistryReader.ReadRegistry(Registry.LocalMachine, Query.Root, Query.BaseBoardProduct);
            BaseVersion = RegistryReader.ReadRegistry(Registry.LocalMachine, Query.Root, Query.BaseBoardVersion);
            ReleaseDate = RegistryReader.ReadRegistry(Registry.LocalMachine, Query.Root, Query.BiosReleaseDate);
            BiosVersion = RegistryReader.ReadRegistry(Registry.LocalMachine, Query.Root, Query.BiosVersion);
            BiosVendor = RegistryReader.ReadRegistry(Registry.LocalMachine, Query.Root, Query.BiosVendor);
            SystemProductName = RegistryReader.ReadRegistry(Registry.LocalMachine, Query.Root, Query.SystemProductName);
            SystemManufacturer = RegistryReader.ReadRegistry(Registry.LocalMachine, Query.Root, Query.SystemManufacturer);
        }

        public string BaseManufacturer { get; private set; }

        public string BaseProduct { get; private set; }

        public string BaseVersion { get; private set; }

        public string ReleaseDate { get; private set; }

        public string BiosVersion { get; private set; }

        public string BiosVendor { get; private set; }

        public string SystemProductName { get; private set; }

        public string SystemManufacturer { get; private set; }

        public string SystemVersion { get; private set; }
    }
}
