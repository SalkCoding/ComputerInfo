using Microsoft.Win32;
using System;

namespace ComputerInfo.Define
{
    public class Untill
    {
        public static string ReadRegistry(RegistryKey key, String root, String subkey)
        {

            key = key.OpenSubKey(root, false);

            if (key == null) return "null";

            var value = key.GetValue(subkey);
            if (value != null)
                return Convert.ToString(value);
            else
                return "null";
        }
    }
}
