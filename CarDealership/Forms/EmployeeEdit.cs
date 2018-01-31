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
    public partial class EmployeeEdit : Form
    {
        int id;
        public EmployeeEdit(int EmployeeID)
        {
            InitializeComponent();
            id = EmployeeID;
            Initialize();
        }

        private void Initialize()
        {
            var criteria = new Employee()
            {
                EMPLOYEE_ID = id
            };
            var emp = BusinessLayer.DataAcquisition.GetEmployees(criteria).Single();
            this.textBoxNAME.Text = emp.NAME;
            this.textBoxSURNAME.Text = emp.SURNAME;
            this.textBoxUSERNAME.Text = emp.LOGIN;
            this.labelID.Text = id.ToString();

            this.dealershipSelector1.ChangeSelected(emp.DEALERSHIP_ID);
            this.roleSelector1.ChangeSelected(emp.Role.ROLE_NAME);
        }


        private void buttonEXIT_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
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
                this.DialogResult = DialogResult.None;
                return;
            }
            if (this.textBoxSURNAME.Text.Length == 0)
            {
                System.Media.SystemSounds.Asterisk.Play();
                this.toolTipEdit.Show("Surname cannot be empty", this.textBoxSURNAME);
                this.DialogResult = DialogResult.None;
                return;
            }
            if (this.textBoxUSERNAME.Text.Length == 0)
            {
                System.Media.SystemSounds.Asterisk.Play();
                this.toolTipEdit.Show("Login cannot be empty", this.textBoxUSERNAME);
                this.DialogResult = DialogResult.None;
                return;
            }
            string name = this.textBoxNAME.Text;
            string surname = this.textBoxSURNAME.Text;
            string login = this.textBoxUSERNAME.Text;
            string password = this.textBoxPASSWORD.Text;
            string role = this.roleSelector1.SelectedItem.ToString();
            string dealership = this.dealershipSelector1.SelectedItem.ToString();
            BusinessLayer.DataUpdate.EmployeeUpdate(id,name,surname,role,dealership,login,password);
            this.DialogResult = DialogResult.Yes;
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

    }
}
