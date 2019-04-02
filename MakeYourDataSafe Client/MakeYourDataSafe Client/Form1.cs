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
        //pubic string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\MakeYourDataSafe";
        public string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\MakeYourDataSafe\\Important Files";

        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            infoLabel.Text = "";
            label1.ReadOnly = true;
            label1.BorderStyle = 0;
            label1.BackColor = this.BackColor;
            label1.TabStop = false;
            cleanButton.BackColor = this.BackColor;

            Process.Start(@"C:\Users\Spenot\source\repos\MakeYourDataSafe\MakeYourDataSafe Client\FileCreate\bin\Debug\FileCreate.exe");

            try
            {
               // checkAutoBoot();            

            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
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

        private void cleanButton_Click(object sender, EventArgs e)
        {
            DirectoryInfo di = new DirectoryInfo(path);
            di.Delete(true);
            Directory.CreateDirectory(path);
            infoLabel.Text = "Cleaning up was successfull! :)";
        }
    }
}
