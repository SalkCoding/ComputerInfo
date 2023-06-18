using ComputerInfo.Define;
using ComputerInfo.WMI;
using GChartLib;
using MetroSuite;
using System.Drawing;

namespace ComputerInfo.Graph
{
    class MemoryGraph : IGraph
    {
        private readonly Memory memory;

        private readonly double physicalSize;
        private readonly double virtualSize;

        private readonly MetroTracker trkMemory;

        private readonly MetroTrackerPath physicalPath;
        private readonly MetroTrackerPath virtualPath;

        public MemoryGraph(Memory memory, MetroTracker trkMemory)
        {
            this.memory = memory;
            this.trkMemory = trkMemory;

            physicalSize = (memory.PhysicalSize / Constants.GIGABYTE_DIVIDE_CONSTANTS);
            virtualSize = (memory.VirtualSize / Constants.GIGABYTE_DIVIDE_CONSTANTS);

            physicalPath = new MetroTrackerPath
            {
                Name = "Physical memory",
                Style = MetroTrackerPath.PathStyle.Memory,
                LineWidth = 2
            };

            virtualPath = new MetroTrackerPath
            {
                Name = "Virtual memory",
                LineColor = Color.FromArgb(242, 184, 233),
                LineWidth = 2,
                FillColor = Color.FromArgb(199, 107, 184)
            };

            trkMemory.Paths.Add(physicalPath);
            trkMemory.Paths.Add(virtualPath);
        }

        public void update()
        {
            ulong physicalTotal = memory.PhysicalSize;
            ulong physicalAvailable = memory.AvailablePhysicalSize;
            ulong virtualTotal = memory.VirtualSize;
            ulong virtualAvailable = memory.AvailableVirtualSize;
            double physicalPercentage = (physicalTotal - physicalAvailable) * 100 / physicalTotal;
            double virtualPercentage = (virtualTotal - virtualAvailable) * 100 / virtualTotal;
            physicalPath.Add((int)physicalPercentage);
            virtualPath.Add((int)virtualPercentage);
            trkMemory.Text = string.Format("{0:F2}/{1:F2} GB in use\n{2:F2}/{3:F2} GB in use",
                (physicalTotal - physicalAvailable) / Constants.GIGABYTE_DIVIDE_CONSTANTS, physicalSize,
                (virtualTotal - virtualAvailable) / Constants.GIGABYTE_DIVIDE_CONSTANTS, virtualSize);
        }
    }
}
