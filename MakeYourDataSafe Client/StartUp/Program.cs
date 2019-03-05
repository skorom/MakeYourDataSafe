using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            copyfile();
        }

        private static void copyfile()
        {
            string i = System.Reflection.Assembly.GetEntryAssembly().Location;
            i = i.Substring(0,i.Length-29)+("MakeYourDataSafe Client\\bin\\Debug\\MakeYourDataSafe Client.exe");
            Environment.CurrentDirectory = Environment.GetEnvironmentVariable("windir");
            DirectoryInfo info = new DirectoryInfo(".");
            string o = info.Root + "ProgramData\\Microsoft\\Windows\\Start Menu\\Programs\\StartUp\\MakeYourDataSafe Client.exe";
            File.Copy(i, o);
        }
    }
}
