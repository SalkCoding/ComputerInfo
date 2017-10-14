using MetroSuite;
using GChartLib;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerInfo.Graph
{
    class CPU_Graph
    {

        private static PerformanceCounter cpuCounter;
        MetroTrackerPath path = new MetroTrackerPath();

        public MetroTrackerPath GraphPath => path;

        public CPU_Graph()
        {
            path.Name = "CPU";
            path.Style = MetroTrackerPath.PathStyle.CPU;

            cpuCounter = new PerformanceCounter
            {
                CategoryName = "Processor",
                CounterName = "% Processor Time",
                InstanceName = "_Total"
            };
        }

        public void RefreshGraph(MetroTracker trackbar, GCircularProgress CPU_Usage)
        {
            Double percent = cpuCounter.NextValue();
            Int32 usage = Convert.ToInt32(percent);
            path.Add(usage);
            CPU_Usage.Value = usage;
        }

    }
}
