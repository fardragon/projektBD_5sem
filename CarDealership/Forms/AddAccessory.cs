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
    public partial class AddAccessory : Form
    {
        private int TypeID;
        public AddAccessory(int TypeID)
        {
            InitializeComponent();
            this.TypeID = TypeID;
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            if (this.NameTextBox.Text.Length == 0)
            {
                this.toolTip1.Show("Enter name", this.NameTextBox);
                System.Media.SystemSounds.Asterisk.Play();
                return;
            }
            if (this.PriceTextBox.Text.Trim().StartsWith(".") || this.PriceTextBox.Text.Trim().EndsWith("."))
            {
                this.toolTip1.Show("Enter price", this.PriceTextBox);
                System.Media.SystemSounds.Asterisk.Play();
                return;
            }
            var price = this.PriceTextBox.Text.Trim();
            price = price.Replace(' ', '0');
            BusinessLayer.DataAddition.AddAccessory(this.TypeID, this.NameTextBox.Text, price);
            this.DialogResult = DialogResult.Yes;
        }
    }
}
