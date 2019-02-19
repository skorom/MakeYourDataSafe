using Firebase.Login;
using Firebase.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using Firebase.Database.Query;
using System.Reactive.Linq;

namespace MakeYourDataSafe_Admin
{
    class Functions
    {
        private const string database = "https://myds-5f6f8.firebaseio.com/";
        private FirebaseClient client = new FirebaseClient(database);
        private async Task GetKeystrokes()
        {
            try
            {
                var client = new FirebaseClient(database);
                var child = client.Child("Keystrokes");
                var users = await child.OnceAsync<Login>();
                foreach (var i in users)
                {
                    if (i.Object.username == log_user.Text && i.Object.password == Hash(log_pass.Text))
                    {
                        if (i.Key != "")
                        {
                            username = i.Object.username;
                            await child.Child(i.Key).PutAsync(new Login() { username = i.Object.username, password = i.Object.password, Timestamp = i.Object.Timestamp, online = true });
                            Chat ablak = new Chat();
                            ablak.Show();
                            this.Hide();
                        }
                        else
                        {
                            throw new DataException("Helytelen felhasználónév vagy jelszó.");
                        }
                        break;
                    }
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
    }
}
