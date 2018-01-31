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
    public partial class CarDetails : Form
    {
        public CarDetails(string VIN)
        {
            InitializeComponent();
            this.View(VIN);
        }

        public void View(String VIN)
        {
            var car = BusinessLayer.DataAcquisition.GetCar(VIN);

            TreeNode full = new TreeNode();
            float basePrice = (float)car.Model.BASE_PRICE;

            TreeNode _base = new TreeNode
            {
                Text = "Base price: " + basePrice.ToString()
            };

            full.Nodes.Add(_base);

            TreeNode accessories = new TreeNode();
            float accPrice = 0;

            foreach (DataLayer.Mounted_Accessory acc in car.Mounted_Accessories)
            {
                accPrice += (float)acc.Accessory.PRICE;
                TreeNode accNode = new TreeNode
                {
                    Text = acc.Accessory.NAME + ": " + acc.Accessory.PRICE
                };
                accessories.Nodes.Add(accNode);
            }

            accessories.Text = "Accessories: " + accPrice.ToString();
            full.Text = "Full price: " + (accPrice + basePrice).ToString();

            full.Nodes.Add(accessories);
            this.PriceTreeView.Nodes.Add(full);
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
