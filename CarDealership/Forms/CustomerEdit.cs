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
    public partial class CustomerEdit : Form
    {
        private int customerID;
        public CustomerEdit(int customerID)
        {
            this.customerID = customerID;
            InitializeComponent();
            var customer = DataAcquisition.GetCustomer(customerID);
            this.NameTextbox.Text = customer.NAME;
            this.AddressTextbox.Text = customer.STREET_ADDRESS;
            this.CityTextbox.Text = customer.CITY;
            this.ZipcodeTextbox.Text = customer.ZIPCODE;
            this.PhoneTextbox.Text = customer.PHONE;
            this.MailTextbox.Text = customer.MAIL;
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
            DataUpdate.ModifyCustomer(this.customerID, this.NameTextbox.Text, this.AddressTextbox.Text, this.CityTextbox.Text, this.ZipcodeTextbox.Text, this.PhoneTextbox.Text, this.MailTextbox.Text);
            this.DialogResult = DialogResult.OK;

        }
    }
}
