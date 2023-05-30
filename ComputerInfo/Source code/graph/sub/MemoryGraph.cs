using ComputerInfo.Define;
using ComputerInfo.WMI;
using GChartLib;
using MetroSuite;

namespace ComputerInfo.Graph
{
    class MemoryGraph : IGraph
    {
        private readonly Memory memory;

        private readonly MetroTracker trkMemory;
        private readonly GCircularProgress gcpPhysicalMemoryUsage;
        private readonly GCircularProgress gcpVirtualMemoryUsage;
        private readonly MetroLabel lblPhysicalMemoryUsed;
        private readonly MetroLabel lblVirtualMemoryUsed;
        private readonly MetroTrackerPath trackerPath;

        public MemoryGraph(Memory memory, MetroTracker trkMemory, GCircularProgress gcpPhysicalMemoryUsage, GCircularProgress gcpVirtualMemoryUsage, MetroLabel lblPhysicalMemoryUsed, MetroLabel lblVirtualMemoryUsed)
        {
            this.memory = memory;
            this.trkMemory = trkMemory;
            this.gcpPhysicalMemoryUsage = gcpPhysicalMemoryUsage;
            this.gcpVirtualMemoryUsage = gcpVirtualMemoryUsage;
            this.lblPhysicalMemoryUsed = lblPhysicalMemoryUsed;
            this.lblVirtualMemoryUsed = lblVirtualMemoryUsed;

            trackerPath = new MetroTrackerPath
            {
                Name = "RAM",
                Style = MetroTrackerPath.PathStyle.Memory
            };

            trkMemory.Paths.Add(trackerPath);
        }

        public void update()
        {
            ulong physicalTotal = memory.PysicalSize;
            ulong physicalAvailable = memory.AvailablePhysicalSize;
            ulong virtualTotal = memory.VirtualSize;
            ulong virtualAvailable = memory.AvailableVirtualSize;
            double physicalPercentage = (physicalTotal - physicalAvailable) * 100 / physicalTotal;
            double virtualPercentage = (virtualTotal - virtualAvailable) * 100 / virtualTotal;
            trackerPath.Add((int)physicalPercentage);
            gcpPhysicalMemoryUsage.Value = (int)physicalPercentage;
            gcpVirtualMemoryUsage.Value = (int)virtualPercentage;
            lblPhysicalMemoryUsed.Text = string.Format("{0:F2} GB in use", (physicalTotal - physicalAvailable) / Constants.GIGABYTE_DIVIDE_CONSTANTS);
            lblVirtualMemoryUsed.Text = string.Format("{0:F2} GB in use", (virtualTotal - virtualAvailable) / Constants.GIGABYTE_DIVIDE_CONSTANTS);
        }
    }
}
