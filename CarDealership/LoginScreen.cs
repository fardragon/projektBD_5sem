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
            string username = this.textBox_username.Text;
            string password = CarDealership.Utility.CalculateMD5Hash(this.textBox_password.Text);

            var database = new DealershipDataContext();

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
            catch (System.InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }

        private void textBox_username_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 127)
            {
                e.Handled = true;
            }
            else if (e.KeyChar == (char)13)
            {
                e.Handled = true;
                this.loginButton.PerformClick();
            }
        }

        private void textBox_password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 127)
            {
                e.Handled = true;
            }
            else if (e.KeyChar == (char)13)
            {
                e.Handled = true;
                this.loginButton.PerformClick();
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
                textBox_username.SelectionLength = textBox_password.Text.Length;
            }
        }
    }
}
