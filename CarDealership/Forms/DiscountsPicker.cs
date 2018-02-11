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
    public partial class DiscountsPicker : Form
    {
        private int orderID;
        public DiscountsPicker(int orderID)
        {
            this.orderID = orderID;
            InitializeComponent();
            var discounts = DataAcquisition.GetDiscounts();
            var active = DataAcquisition.GetActiveDiscounts(orderID);
            foreach (var disc in discounts)
            {
                bool check = active.Contains(disc.DISCOUNT_ID);
                DiscountsListBox.Items.Add(disc.DISCOUNT_ID + ": " + disc.NAME + ", Value: " + disc.VALUE, check);
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            var active = new List<int>();
            foreach (var obj in this.DiscountsListBox.CheckedItems)
            {
                var id = obj.ToString().Substring(0, obj.ToString().IndexOf(':'));
                active.Add(Int32.Parse(id));
            }
            DataUpdate.SetActiveDiscounts(orderID, active);
            this.DialogResult = DialogResult.Yes;

        }
    }
}
