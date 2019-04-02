using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileCreate
{
    class Program
    {
        //pubic static string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\MakeYourDataSafe";
        public static string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\MakeYourDataSafe\\Important Files";

        static void Main(string[] args)
        {
            if (Directory.Exists(path) == false)
            {
                Directory.CreateDirectory(path);
            }
            System.Timers.Timer timer1 = new System.Timers.Timer(100);
            timer1.Elapsed += timer1_OnTick;
            timer1.AutoReset = true;
            timer1.Enabled = true;
            Console.ReadLine();
        }

        private static long getFreeDiskSpace(char driveName)
        {
            foreach (DriveInfo item in DriveInfo.GetDrives())
            {
                if (item.Name[0] == driveName)
                {
                    return item.AvailableFreeSpace;
                }
            }
            return 0;
        }

        private static long getDiskSize(char driveName)
        {
            foreach (DriveInfo item in DriveInfo.GetDrives())
            {
                if (item.Name[0] == driveName)
                {
                    return item.TotalSize;
                }
            }
            return 0;
        }

        private static void timer1_OnTick(Object source, System.Timers.ElapsedEventArgs e)
        {
            if (getFreeDiskSpace('C') > getDiskSize('C') * 0.2)
            {
                int i = Directory.GetFiles(path).Length;
                File.WriteAllBytes(path + "\\file" + i + ".txt", new byte[10485760]);
            }
        }
    }
}
