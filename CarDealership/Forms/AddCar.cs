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
    public partial class AddCar : Form
    {
        private int DealershipID;
        private List<int> Accessories;
        public AddCar(int DealershipID)
        {
            this.DealershipID = DealershipID;
            Accessories = new List<int>();
            InitializeComponent();
        }

        private void AddCar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'colorsDataSet.Colors' table. You can move, or remove it, as needed.
            this.colorsTableAdapter.Fill(this.colorsDataSet.Colors);
            // TODO: This line of code loads data into the 'modelsDataSet.Models' table. You can move, or remove it, as needed.
            this.modelsTableAdapter.Fill(this.modelsDataSet.Models);

        }

        private bool CarAdd()
        {
            if (ProdYearTextbox.Text.Length != 4)
            {
                this.toolTip1.Show("Enter corret year", ProdYearTextbox);
                System.Media.SystemSounds.Asterisk.Play();
                return false;
            }
            if (VINTextbox.Text.Length != 17)
            {
                this.toolTip1.Show("Enter corret VIN", VINTextbox);
                System.Media.SystemSounds.Asterisk.Play();
                return false;
            }
            var model = (DataRowView)ModelComboBox.SelectedItem;
            int modelID = (int)model.Row.ItemArray[0];
            var color = (DataRowView)ColorsComboBox.SelectedItem;
            int colorID = (int)color.Row.ItemArray[0];
            DataAddition.AddCar(VINTextbox.Text, modelID, colorID, DealershipID, ProdYearTextbox.Text);
            DataAddition.AddMountedAccessory(VINTextbox.Text, this.Accessories);
            return true;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (this.CarAdd())
            {
                this.DialogResult = DialogResult.Yes;
            }
            else
            {
                this.DialogResult = DialogResult.None;
            }
        }

        private void AddNextButton_Click(object sender, EventArgs e)
        {
            if (this.CarAdd())
            {
                this.VINTextbox.Clear();
                this.VINTextbox.Select();
            }
            this.DialogResult = DialogResult.None;
        }

        private void PickAccessoriessButton_Click(object sender, EventArgs e)
        {
            var dialog = new Forms.AccessoriesPicker();
            var result = dialog.ShowDialog(this);
            if (result == DialogResult.Yes) this.Accessories = dialog.GetSelected();
        }
    }
}
