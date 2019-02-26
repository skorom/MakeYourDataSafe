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
using Firebase.Database.Query;
using System.Reactive.Linq;
using Firebase.Database.Streaming;

namespace MakeYourDataSafe_Admin
{
    public partial class Keys : Form
    {
        public Keys(int id)
        {
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private const string database = "https://myds-5f6f8.firebaseio.com/";
        private FirebaseClient client = new FirebaseClient(database);
        private async Task Run()
        {
            try
            {
                var child = client.Child("Messages");
                var observable = child.AsObservable<GetKeystrokes>();
                var subscription = observable.Where(item => !string.IsNullOrEmpty(item.Key)).Subscribe(item => displayKey(item));
            }
            catch (FirebaseException ex)
            {
                MessageBox.Show("Hiba a felhasználók beolvasása során.\r\n" + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nem várt hiba történt.\r\n" + ex.Message);
            }
        }

        private void displayKey(FirebaseEvent<GetKeystrokes> item)
        {
            if (this.InvokeRequired)
                this.Invoke(new displayMessageDelegate(this.displayMessage), item);
            else
            {
                if (item.Object?.id == Form1.username && item.Object?.Author == partner)
                {
                    textBox3.Text += item.Object.Author + ": " + item.Object.Content + "\r\n";
                }
                else if (item.Object?.Recipient == Form1.username && item.Object?.Author == partner && item.Object?.File != null)
                {
                    textBox3.Text += item.Object.Author + ": " + item.Object.Filename + "\r\n";
                    File.WriteAllLines("C:\\Users\\szicsa\\Downloads" + item.Object.Filename, item.Object.File);

                }

            }
        }

        private void Keys_Load(object sender, EventArgs e)
        {

        }
    }
}
