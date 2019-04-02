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
using System.IO;

namespace MakeYourDataSafe_Admin
{
    public partial class Picviewer : Form
    {
        private static string uid; //selected computer's ID
        private static int cmdtype;
        private const string database = "https://myds-5f6f8.firebaseio.com/";
        private FirebaseClient client = new FirebaseClient(database);
        public Picviewer()
        {
            InitializeComponent();
        }

        public Picviewer(string id, int type) : this()
        {
            uid = id;
            cmdtype = type;
        }

        async private void Picviewer_Load(object sender, EventArgs e)
        {
            try
            {
                var child = client.Child("Commands");
                await child.PostAsync(new SetCommands { id = uid, cmd = cmdtype });
                var data = await client.Child("Pictures").OnceAsync<GetPictures>();
                foreach (var i in data)
                {
                    if (i.Object.id == uid)
                    {
                        var img = Image.FromStream(new MemoryStream(Convert.FromBase64String(i.Object.img)));
                        this.pictureBox1.Image = img;
                    }
                }
            }
            catch (FirebaseException ex)
            {
                MessageBox.Show("Hiba a lekérés során.\r\n" + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nem várt hiba történt.\r\n" + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
