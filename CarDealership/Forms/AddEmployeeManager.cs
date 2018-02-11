using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarDealership.Forms
{
    public partial class AddEmployeeManager : Form
    {
        private String Role;
        private int DealershipID;
        public AddEmployeeManager(String role, int dealershipID)
        {
            InitializeComponent();
            this.DealershipID = dealershipID;
            this.Role = role;
            this.Text = "Add " + role;
        }

        private void LoginTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar > 127)
            {
                e.Handled = true;
            }
        }

        private void NameTextbox_Enter(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(this.NameTextbox.Text))
            {
                this.NameTextbox.SelectionStart = 0;
                this.NameTextbox.SelectionLength = this.NameTextbox.Text.Length;
            }
        }

        private void SurnameTextbox_Enter(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(this.SurnameTextbox.Text))
            {
                this.SurnameTextbox.SelectionStart = 0;
                this.SurnameTextbox.SelectionLength = this.SurnameTextbox.Text.Length;
            }
        }

        private void LoginTextbox_Enter(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(this.LoginTextbox.Text))
            {
                this.LoginTextbox.SelectionStart = 0;
                this.LoginTextbox.SelectionLength = this.LoginTextbox.Text.Length;
            }
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.NameTextbox.Text))
            {
                this.toolTip1.Show("Enter employee's name", this.NameTextbox);
                System.Media.SystemSounds.Asterisk.Play();
                return;
            }
            if (String.IsNullOrEmpty(this.SurnameTextbox.Text))
            {
                this.toolTip1.Show("Enter employee's surname", this.SurnameTextbox);
                System.Media.SystemSounds.Asterisk.Play();
                return;
            }
            if (String.IsNullOrEmpty(this.LoginTextbox.Text))
            {
                this.toolTip1.Show("Enter employee's login", this.LoginTextbox);
                System.Media.SystemSounds.Asterisk.Play();
                return;
            }
            BusinessLayer.DataAddition.AddEmployee(NameTextbox.Text, SurnameTextbox.Text, this.Role, this.DealershipID.ToString(), LoginTextbox.Text, LoginTextbox.Text);
            this.DialogResult = DialogResult.Yes;
        }
    }
}
