using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;


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
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor;
            this.toolTipLogin.Hide(textBox_password);         
            var user = BusinessLayer.LoginLogic.Login(this.textBox_username.Text, this.textBox_password.Text);
            bool loggedIn = false;
            switch (user.Type)
            {
                case BusinessLayer.UserTypes.Error:
                    MessageBox.Show(this,"Database connection error", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case BusinessLayer.UserTypes.BadLogin:
                    this.toolTipLogin.Show("Invalid login and\\or password", this.textBox_password);
                    System.Media.SystemSounds.Asterisk.Play();
                    break;
                case BusinessLayer.UserTypes.Administrator:
                    this.NextScreen = Screens.AdminScreen;
                    loggedIn = true;
                    break;
                case BusinessLayer.UserTypes.Manager:
                    this.NextScreen = Screens.ManagerScreen;
                    loggedIn = true;
                    break;
                case BusinessLayer.UserTypes.Seller:
                    this.NextScreen = Screens.SellerScreen;
                    loggedIn = true;
                    break;
                case BusinessLayer.UserTypes.Mechanic:
                    this.NextScreen = Screens.MechanicScreen;
                    loggedIn = true;
                    break;
            }
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default;
            if (loggedIn)
            {
                this.DefaultDealership = user.Dealership;
                this.Close();
            }
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
