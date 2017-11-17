using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using DataLayer;

namespace CarDealership
{
    public partial class EmployeeAdd : Form
    {
        public EmployeeAdd()
        {
            InitializeComponent();
        }
        private void dealershipSelector1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right) this.dealershipSelector1.ClearSelection();
        }

        private void buttonEXIT_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Abort;
            this.Close();
        }

        private void textBoxUSERNAME_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar > 127)
            {
                e.Handled = true;
            }
        }

        private void textBoxUSERNAME_Enter(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBoxUSERNAME.Text))
            {
                textBoxUSERNAME.SelectionStart = 0;
                textBoxUSERNAME.SelectionLength = textBoxUSERNAME.Text.Length;
            }
        }

        private void buttonCONFIRM_Click(object sender, EventArgs e)
        {
            if (this.textBoxNAME.Text.Length == 0)
            {
                System.Media.SystemSounds.Asterisk.Play();
                this.toolTipEdit.Show("Name cannot be empty", this.textBoxNAME);
                return;
            }
            if (this.textBoxSURNAME.Text.Length == 0)
            {
                System.Media.SystemSounds.Asterisk.Play();
                this.toolTipEdit.Show("Surname cannot be empty", this.textBoxSURNAME);
                return;
            }
            if (this.textBoxUSERNAME.Text.Length == 0)
            {
                System.Media.SystemSounds.Asterisk.Play();
                this.toolTipEdit.Show("Login cannot be empty", this.textBoxUSERNAME);
                return;
            }
            if (this.textBoxPASSWORD.Text.Length == 0)
            {
                System.Media.SystemSounds.Asterisk.Play();
                this.toolTipEdit.Show("Password cannot be empty", this.textBoxPASSWORD);
                return;
            }
            string name = this.textBoxNAME.Text;
            string surname = this.textBoxSURNAME.Text;
            string login = this.textBoxUSERNAME.Text;
            string password = this.textBoxPASSWORD.Text;
            int role = (this.roleSelector1.SelectedValue as Role).ROLE_ID;
            int? dealership;
            if (this.dealershipSelector1.SelectedIndex == -1)
            {
                dealership = null;
            }
            else
            {
                dealership = (this.dealershipSelector1.SelectedValue as Dealership).DEALERSHIP_ID;
            }

            BusinessLayer.DataAddition.AddEmployee(name, surname, role, dealership, login, password);
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void textBoxPASSWORD_Enter(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBoxPASSWORD.Text))
            {
                textBoxPASSWORD.SelectionStart = 0;
                textBoxPASSWORD.SelectionLength = textBoxPASSWORD.Text.Length;
            }
        }

        private void textBoxPASSWORD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar > 127)
            {
                e.Handled = true;
            }
        }

        private void textBoxSURNAME_Enter(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBoxSURNAME.Text))
            {
                textBoxSURNAME.SelectionStart = 0;
                textBoxSURNAME.SelectionLength = textBoxSURNAME.Text.Length;
            }
        }

        private void textBoxNAME_Enter(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBoxNAME.Text))
            {
                textBoxNAME.SelectionStart = 0;
                textBoxNAME.SelectionLength = textBoxNAME.Text.Length;
            }
        }

        private void dealershipSelector1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back) this.dealershipSelector1.ClearSelection();
        }

    }
}
