using GChartLib;
using System.IO;
using ComputerInfo.WMI;

namespace ComputerInfo.Graph
{
    class StorageGraph : IGraph
    {

        private readonly Storage storage;
        private readonly GCircularProgress[] gcpArray;

        public StorageGraph(
            Storage storage,
            GCircularProgress[] gcpArray
            )
        {
            this.storage = storage;
            this.gcpArray = gcpArray;
        }

        public void update()
        {
            for (int i = 0; i < gcpArray.Length && i < storage.VolumeCount; i++)
            {
                DriveInfo driveInfo = storage.VolumeList[i];
                gcpArray[i].Value = (int)(((driveInfo.TotalSize - driveInfo.TotalFreeSpace) / (double)driveInfo.TotalSize) * 100);
            }
        }
    }
}
