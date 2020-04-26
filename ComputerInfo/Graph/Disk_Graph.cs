using System;
using GChartLib;
using MetroSuite;
using System.IO;
using ComputerInfo.WMI;

namespace ComputerInfo.Graph
{
    class DiskGraph
    {

        public void RefreshGraph(Disk disk, GCircularProgress[] progressList)
        {
            int i = 0;
            foreach (DriveInfo drive in disk.VolumeList)
            {
                if (i >= disk.VolumeCount)
                    break;
                progressList[i].Value = (Int32)(((drive.TotalSize - drive.TotalFreeSpace) / (Double)drive.TotalSize) * 100);
                i++;
            }
        }

    }
}
