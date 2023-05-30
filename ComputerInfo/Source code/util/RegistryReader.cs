using Microsoft.Win32;
using System;

namespace ComputerInfo.Define
{
    public class RegistryReader
    {
        public static string ReadRegistry(RegistryKey key, string root, string subkey)
        {
            key = key.OpenSubKey(root, false);
            if (key == null) return "null";

            var value = key.GetValue(subkey);
            return value != null ? value.ToString() : "null";
        }
    }
}
