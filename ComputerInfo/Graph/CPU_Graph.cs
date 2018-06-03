using MetroSuite;
using GChartLib;
using System;
using System.Diagnostics;

namespace ComputerInfo.Graph
{
    class CPU_Graph
    {
       
        private static PerformanceCounter cpuCounter;

        public MetroTrackerPath GraphPath { get; } = new MetroTrackerPath();

        public CPU_Graph()
        {
            GraphPath.Name = "CPU";
            GraphPath.Style = MetroTrackerPath.PathStyle.CPU;

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
            GraphPath.Add(usage);
            CPU_Usage.Value = usage;
        }

    }
}
