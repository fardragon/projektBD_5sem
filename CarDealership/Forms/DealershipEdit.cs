using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer;
using BusinessLayer;

namespace CarDealership
{
    public partial class DealershipEdit : Form
    {
        int DealershipID;
        public DealershipEdit(int DealershipID)
        {
            InitializeComponent();
            //
            this.comboBoxManager.Items.Add("");
            this.DealershipID = DealershipID;
            var managers = BusinessLayer.DataAcquisition.GetManagers(DealershipID);
            foreach (Employee man in managers)
            {
                this.comboBoxManager.Items.Add(man.EMPLOYEE_ID);
            }
            this.comboBoxManager.SelectedIndex = 0;
            //
            this.labelID.Text = DealershipID.ToString();
            //

        }

        private void textBoxAdress_Enter(object sender, EventArgs e)
        {
            if (this.textBoxAdress.Text.Length > 0)
            {
                this.textBoxAdress.SelectionStart = 0;
                this.textBoxAdress.SelectionLength = this.textBoxAdress.Text.Length;
            }
        }

        private void textBoxCity_Enter(object sender, EventArgs e)
        {
            if (this.textBoxCity.Text.Length > 0)
            {
                this.textBoxCity.SelectionStart = 0;
                this.textBoxCity.SelectionLength = this.textBoxCity.Text.Length;
            }
        }

        private void textBoxZipcode_Enter(object sender, EventArgs e)
        {
            if (this.textBoxZipcode.Text.Length > 0)
            {
                this.textBoxZipcode.SelectionStart = 0;
                this.textBoxZipcode.SelectionLength = this.textBoxZipcode.Text.Length;
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Abort;
            this.Close();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            if (this.textBoxAdress.Text.Length < 0)
            {
                this.toolTip.Show("Address cannot be empty", this.textBoxAdress);
                System.Media.SystemSounds.Asterisk.Play();
                return;
            }
            if (this.textBoxCity.Text.Length < 0)
            {
                this.toolTip.Show("City cannot be empty", this.textBoxCity);
                System.Media.SystemSounds.Asterisk.Play();
                return;
            }
            if (this.textBoxZipcode.Text.Length < 0)
            {
                this.toolTip.Show("Zipcode cannot be empty", this.textBoxZipcode);
                System.Media.SystemSounds.Asterisk.Play();
                return;
            }
            BusinessLayer.DataUpdate.DealershipUpdate(DealershipID, this.textBoxAdress.Text, this.textBoxCity.Text, this.textBoxZipcode.Text, this.comboBoxManager.SelectedItem.ToString());
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }
    }
}
