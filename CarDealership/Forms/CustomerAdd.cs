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
    public partial class CustomerAdd : Form
    {
        public CustomerAdd()
        {
            InitializeComponent();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.NameTextbox.Text))
            {
                this.toolTip1.Show("Enter customer's name", this.NameTextbox);
                System.Media.SystemSounds.Asterisk.Play();
                return;
            }
            if (String.IsNullOrEmpty(this.AddressTextbox.Text))
            {
                this.toolTip1.Show("Enter customer's address", this.AddressTextbox);
                System.Media.SystemSounds.Asterisk.Play();
                return;
            }
            if (String.IsNullOrEmpty(this.CityTextbox.Text))
            {
                this.toolTip1.Show("Enter customer's city", this.CityTextbox);
                System.Media.SystemSounds.Asterisk.Play();
                return;
            }
            if (String.IsNullOrEmpty(this.ZipcodeTextbox.Text))
            {
                this.toolTip1.Show("Enter customer's zipcode", this.ZipcodeTextbox);
                System.Media.SystemSounds.Asterisk.Play();
                return;
            }
            if (String.IsNullOrEmpty(this.PhoneTextbox.Text))
            {
                this.toolTip1.Show("Enter customer's phone number", this.PhoneTextbox);
                System.Media.SystemSounds.Asterisk.Play();
                return;
            }
            DataAddition.AddCustomer(this.NameTextbox.Text, this.AddressTextbox.Text, this.CityTextbox.Text, this.ZipcodeTextbox.Text, this.PhoneTextbox.Text, this.MailTextbox.Text);
            this.DialogResult = DialogResult.OK;

        }
    }
}
