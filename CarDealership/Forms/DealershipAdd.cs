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
    public partial class DealershipAdd : Form
    {
        public DealershipAdd()
        {
            InitializeComponent();
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
            this.DialogResult = DialogResult.Cancel;
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
            BusinessLayer.DataAddition.AddDealership(this.textBoxAdress.Text, this.textBoxCity.Text, this.textBoxZipcode.Text);
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }
    }
}
