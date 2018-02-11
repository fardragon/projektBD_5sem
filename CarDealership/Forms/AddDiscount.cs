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
    public partial class AddDiscount : Form
    {
        public AddDiscount()
        {
            InitializeComponent();
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            if(this.NameTextBox.Text.Length == 0)
            {
                this.toolTip1.Show("Enter new discount", this.NameTextBox);
                System.Media.SystemSounds.Asterisk.Play();
                return;
            }
            if (this.ValueTextBox.Text.Trim().StartsWith(".") || this.ValueTextBox.Text.Trim().EndsWith("."))
            {
                this.toolTip1.Show("Value cannot be empty", this.ValueTextBox);
                System.Media.SystemSounds.Asterisk.Play();
                this.DialogResult = DialogResult.None;
                return;
            }
            var value = this.ValueTextBox.Text.Trim();
            value = value.Replace(' ', '0');
            BusinessLayer.DataAddition.AddDiscount(this.NameTextBox.Text, Decimal.Parse(value));
            this.DialogResult = DialogResult.Yes;
        }
    }
}
