using System;
using System.Collections.Generic;
using System.Management;
using ComputerInfo.Define;

namespace ComputerInfo.WMI
{
    public class CPU : WMIQuery
    {

        private static class Query
        {
            internal readonly static string WMI = @"select * from  Win32_Processor";
            internal readonly static string Name = "Name";
            internal readonly static string MaxClock = "MaxClockSpeed";
            internal readonly static string Voltage = "CurrentVoltage";
            internal readonly static string L2CacheSize = "L2CacheSize";
            internal readonly static string L3CacheSize = "L3CacheSize";
            internal readonly static string NumberOfCores = "NumberOfCores";
            internal readonly static string ThreadCount = "ThreadCount";
        }

        public CPU()
        {
            IEnumerator<ManagementBaseObject> enumerator = WMIExecQuery(Query.WMI).GetEnumerator();
            while (enumerator.MoveNext())
            {
                ManagementBaseObject wmi = enumerator.Current;
                Name = wmi[Query.Name].ToString().Trim();
                CurrentClock = Convert.ToInt32(wmi[Query.MaxClock]);
                Voltage = Convert.ToDouble(wmi[Query.Voltage]) / 10;
                L2CacheSize = Convert.ToInt32(wmi[Query.L2CacheSize]);
                L3CacheSize = Convert.ToInt32(wmi[Query.L3CacheSize]);
                CoreCount = Convert.ToInt32(wmi[Query.NumberOfCores]);
                ThreadCount = Convert.ToInt32(wmi[Query.ThreadCount]);
            }
        }

        public string Name { get; private set; }

        public int CurrentClock { get; private set; }

        public double Voltage { get; private set; }

        public int L2CacheSize { get; private set; }

        public int L3CacheSize { get; private set; }

        public int CoreCount { get; private set; }

        public int ThreadCount { get; private set; }
    }
}
