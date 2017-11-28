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
    public partial class PasswordChange : Form
    {
        private int employeeID;
        public PasswordChange(int EmployeeID)
        {
            InitializeComponent();
            employeeID = EmployeeID;
        }

        private void textBoxOldPWD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar > 127) e.Handled = true;
        }

        private void textBoxOldPWD_Enter(object sender, EventArgs e)
        {
            if (textBoxOldPWD.Text.Length > 0)
            {
                textBoxOldPWD.SelectionStart = 0;
                textBoxOldPWD.SelectionLength = textBoxOldPWD.Text.Length;
            }
        }

        private void textBoxNewPWD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar > 127) e.Handled = true;
        }

        private void textBoxNewPWD_Enter(object sender, EventArgs e)
        {
            if (textBoxNewPWD.Text.Length > 0)
            {
                textBoxNewPWD.SelectionStart = 0;
                textBoxNewPWD.SelectionLength = textBoxNewPWD.Text.Length;
            }
        }

        private void textBoxRepeatPWD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar > 127) e.Handled = true;
        }

        private void textBoxRepeatPWD_Enter(object sender, EventArgs e)
        {
            if (textBoxRepeatPWD.Text.Length > 0)
            {
                textBoxRepeatPWD.SelectionStart = 0;
                textBoxRepeatPWD.SelectionLength = textBoxRepeatPWD.Text.Length;
            }
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            if (textBoxNewPWD.Text.Length == 0)
            {
                this.toolTip.Show("Enter new password", textBoxNewPWD);
                System.Media.SystemSounds.Asterisk.Play();
                return;
            }
            if (textBoxNewPWD.Text != textBoxRepeatPWD.Text)
            {
                this.toolTip.Show("Passwords don't match", textBoxRepeatPWD);
                System.Media.SystemSounds.Asterisk.Play();
                return;
            }
            if (!BusinessLayer.DataAcquisition.CheckPassword(this.employeeID, textBoxOldPWD.Text))
            {
                this.toolTip.Show("Old password does not match", textBoxOldPWD);
                System.Media.SystemSounds.Asterisk.Play();
                return;
            }
            BusinessLayer.DataUpdate.ChangePassword(employeeID, textBoxNewPWD.Text);
            this.DialogResult = DialogResult.Yes;
            this.Close();

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Abort;
            this.Close();
        }
    }
}
