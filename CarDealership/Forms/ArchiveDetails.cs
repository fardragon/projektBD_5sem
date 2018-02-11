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
    public partial class ArchiveDetails : Form
    {
        public ArchiveDetails(int SaleID)
        {
            InitializeComponent();
            this.View(SaleID);
        }

        private void View(int SaleID)
        {
            var sale = BusinessLayer.DataAcquisition.GetSale(SaleID);
            decimal sum = 0;
            var full = new TreeNode();
            decimal basePrice = sale.Model.BASE_PRICE;
            sum += basePrice;
            var _base = new TreeNode
            {
                Text = "Base price: " + basePrice.ToString()
            };
            full.Nodes.Add(_base);

            var _acc = new TreeNode();
            decimal acc_sum = 0;
            foreach (var acc in sale.Sold_Accessories)
            {
                var _temp = new TreeNode
                {
                    Text = acc.Accessory.NAME + ": " + acc.Accessory.PRICE
                };
                acc_sum += acc.Accessory.PRICE;
                _acc.Nodes.Add(_temp);
            }
            sum += acc_sum;
            _acc.Text = "Accessories: " + acc_sum.ToString();
            full.Nodes.Add(_acc);

            var _disc = new TreeNode();
            decimal disc_sum = 0;
            foreach (var disc in sale.Sold_Discounts)
            {
                var _temp = new TreeNode
                {
                    Text = disc.Discount.NAME + ": " + (-disc.Discount.VALUE).ToString()
                };
                disc_sum -= disc.Discount.VALUE;
                _disc.Nodes.Add(_temp);
            }
            sum += disc_sum;
            _disc.Text = "Discounts: " + disc_sum.ToString();
            full.Nodes.Add(_disc);

            full.Text = "Final price: " + sum.ToString();
            this.treeView1.Nodes.Add(full);
            full.Expand();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
