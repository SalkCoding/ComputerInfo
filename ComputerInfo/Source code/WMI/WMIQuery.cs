using System;
using System.Collections.Generic;
using System.Management;

namespace ComputerInfo.Define
{
    public abstract class WMIQuery
    {

        protected IEnumerable<ManagementBaseObject> WMIExecQuery(string query)
        {
            using (var searcher = new ManagementObjectSearcher(query))
            {
                using (var collection = searcher.Get())
                {
                    foreach (ManagementBaseObject item in collection)
                    {
                        yield return item;
                    }
                }
            }
        }
    }
}
