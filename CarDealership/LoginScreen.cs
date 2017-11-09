using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CarDealership
{
    public partial class LoginScreen : ScreenForm
    {
        public LoginScreen()
        {
            InitializeComponent();
            this.NextScreen = Screens.Exit;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {

            this.toolTipPassword.Hide(textBox_password);
            this.toolTipUsername.Hide(textBox_username);
            string username = this.textBox_username.Text;
            string password = this.textBox_password.Text;
            if ((password.Length == 0) || (username.Length == 0))
            {
                //username or password is empty
                System.Media.SystemSounds.Asterisk.Play();


                if (password.Length == 0)
                {
                    this.toolTipPassword.Show("Empty password", this.textBox_password);
                }

                if (username.Length == 0)
                {
                    this.toolTipUsername.Show("Empty username", this.textBox_username);
                }

                return;
            }

            password = CarDealership.Utility.CalculateMD5Hash(password);

            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor;

            var database = new DealershipDataContext
            {
                Log = System.Console.Out
            };


            try
            {
                var user = (from users in database.Employees where users.LOGIN == username && users.PASSWORD == password select users).Single();

                switch(user.Role.ROLE1.ToString())
                {
                    case "Administrator":
                        this.NextScreen = Screens.AdminScreen;
                        break;
                    case "Manager":
                        this.NextScreen = Screens.ManagerScreen;
                        break;
                    case "Seller":
                        this.NextScreen = Screens.SellerScreen;
                        break;
                    case "Mechanic":
                        this.NextScreen = Screens.MechanicScreen;
                        break;
                }

                



                this.Close();
            }
            catch (System.InvalidOperationException)
            {
                System.Media.SystemSounds.Asterisk.Play();
                this.toolTipPassword.Show("Incorrect username or password", this.textBox_password);
            }
            catch(System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default;

        }

        private void textBox_username_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 127)
            {
                e.Handled = true;
            }

        }

        private void textBox_password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 127)
            {
                e.Handled = true;
            }

        }

        private void textBox_password_Enter(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox_password.Text))
            {
                textBox_password.SelectionStart = 0;
                textBox_password.SelectionLength = textBox_password.Text.Length;
            }
        }

        private void textBox_username_Enter(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox_username.Text))
            {
                textBox_username.SelectionStart = 0;
                textBox_username.SelectionLength = textBox_username.Text.Length;
            }
        }

    }
}
