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
    public partial class Message : Form
    {
        private static string uid; //selected computer's ID
        private const string database = "https://myds-5f6f8.firebaseio.com/";
        private FirebaseClient client = new FirebaseClient(database);
        public Message()
        {
            InitializeComponent();
        }

        public Message(string id) : this()
        {
            uid = id;
        }

        private void Message_Load(object sender, EventArgs e)
        {

        }

        private void send_msg_Click(object sender, EventArgs e)
        {
            try
            {
                var child = client.Child("Messages");
                child.PostAsync(new SetMessages { id = uid, message = textBox1.Text });
                MessageBox.Show("Sikeresen elküldted az üzenetet.");
                textBox1.Clear();
            }
            catch (FirebaseException ex)
            {
                MessageBox.Show("Hiba az üzenet elküldése során.\r\n" + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nem várt hiba történt.\r\n" + ex.Message);
            }
        }
    }
}
