using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace MakeYourDataSafe_Client
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
            try
            {
                checkAutoBoot();            

            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string path = (Environment.UserName + "\\Appdata\\LocalLow");
            //Appdata pathet meg kéne mán csinálni mert agyhúgykövet kapok ettől a fostól. (A lenti megoldások mindig ugyanannak a felhasználónak a Roaming mappáját nyitják meg, attól független, hogy ki van épp bejelentkezve)

            label1.Text = path;
            Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\MakeYourDataSafe");
            if (Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\MakeYourDataSafe") == false)
            {
                
            }
            /*while (getFreeDiskSpace('C') < getDiskSize('C') * 0.91)
            {
                File.WriteAllBytes(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/MakeYourDataSafe/file.txt", new byte[10000]);
            }*/

            //Appdataba rakni fájlokat, ha még van elég hely
        }

        private long getFreeDiskSpace(char driveName)
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

        private long getDiskSize(char driveName)
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

        private void checkAutoBoot()
        {
            DirectoryInfo info = new DirectoryInfo(".");
            string o = info.Root + "ProgramData\\Microsoft\\Windows\\Start Menu\\Programs\\StartUp\\MakeYourDataSafe Client.exe";
            string i = System.Reflection.Assembly.GetEntryAssembly().Location;
            i = i.Substring(0, i.Length - 61) + ("StartUp\\bin\\Debug\\StartUp.exe");
            if (File.Exists(o)==false)
            {
                if (File.Exists(i) == true)
                {
                    Process.Start(i);
                }
                else
                {
                 throw new FileNotFoundException("Corrupted Program");
                }
            }
        }

    }
}
