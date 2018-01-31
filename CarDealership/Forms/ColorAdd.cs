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
    public partial class ColorAdd : Form
    {
        public ColorAdd()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void ConfirnButton_Click(object sender, EventArgs e)
        {
            if (this.ColorNameTextBox.Text.Length == 0)
            {
                this.toolTip.Show("Insert color name", this.ColorNameTextBox);
                System.Media.SystemSounds.Asterisk.Play();
                this.DialogResult = DialogResult.None;
                return;
            }

            BusinessLayer.DataAddition.AddColor(this.ColorNameTextBox.Text);
            this.DialogResult = DialogResult.Yes;

        }
    }
}
