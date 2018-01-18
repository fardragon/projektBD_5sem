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
    public partial class ModelAdd : Form
    {
        public ModelAdd()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            if (this.NameTextbox.Text.Length == 0)
            {
                this.toolTip.Show("Name cannot be empty", this.NameTextbox);
                System.Media.SystemSounds.Asterisk.Play();
                this.DialogResult = DialogResult.None;
                return;
            }
            if (this.PriceTextbox.Text.Trim().StartsWith(".") || this.PriceTextbox.Text.Trim().EndsWith("."))
            {
                this.toolTip.Show("Price cannot be empty", this.PriceTextbox);
                System.Media.SystemSounds.Asterisk.Play();
                this.DialogResult = DialogResult.None;
                return;
            }
            var price = this.PriceTextbox.Text.Trim();
            price = price.Replace(' ', '0');
            BusinessLayer.DataAddition.AddModel(this.NameTextbox.Text.Trim(), price);
            this.DialogResult = DialogResult.Yes;
        }

        private void NameTextbox_Enter(object sender, EventArgs e)
        {
            if (this.NameTextbox.Text.Length > 0)
            {
                this.NameTextbox.SelectionStart = 0;
                this.NameTextbox.SelectionLength = this.NameTextbox.Text.Length;
            }
        }
    }
}
