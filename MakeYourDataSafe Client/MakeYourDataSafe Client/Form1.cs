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
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DriveInfo drive;
            DriveInfo[] allDrives = DriveInfo.GetDrives();
            foreach (DriveInfo item in allDrives)
            {
                if (item.Name[0] == 'C')
                {
                    drive = item;
                    break;
                }
            }
            //Appdataba rakni fájlokat, ha még van elég hely
            //System.IO.File.WriteAllBytes("file.txt", new byte[10000]);
        }
    }
}
