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


namespace CarDealership.Forms
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
            this.toolTipLogin.Hide(textBoxPassword);         
            var user = BusinessLayer.LoginLogic.Login(this.textBoxUsername.Text, this.textBoxPassword.Text);
            bool loggedIn = false;
            switch (user.Type)
            {
                case BusinessLayer.UserTypes.Error:
                    MessageBox.Show(this,"Database connection error", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case BusinessLayer.UserTypes.BadLogin:
                    this.toolTipLogin.Show("Invalid login and\\or password", this.textBoxPassword);
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
                this.EmployeeID = user.ID;
                this.Close();
            }
        }

        private void textBoxUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar > 127)
            {
                e.Handled = true;
            }
        }

        private void textBoxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar > 127)
            {
                e.Handled = true;
            }
        }

        private void textBoxPassword_Enter(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBoxPassword.Text))
            {
                textBoxPassword.SelectionStart = 0;
                textBoxPassword.SelectionLength = textBoxPassword.Text.Length;
            }
        }

        private void textBoxUsername_Enter(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBoxUsername.Text))
            {
                textBoxUsername.SelectionStart = 0;
                textBoxUsername.SelectionLength = textBoxUsername.Text.Length;
            }
        }
    }
}
