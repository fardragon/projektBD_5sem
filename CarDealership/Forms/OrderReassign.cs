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
    public partial class OrderReassign : Form
    {
        private int Dealership;
        private int Order;
        public OrderReassign(int DealershipID, int OrderID)
        {
            Dealership = DealershipID;
            Order = OrderID;
            InitializeComponent();
        }

        private void OrderReassign_Load(object sender, EventArgs e)
        {
            try
            {
                this.employeesBindingSource.Filter = "DEALERSHIP_ID = " + Dealership.ToString();
                this.employeesTableAdapter.FillBy(this.sellersDataSet.Employees);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            var seller = (DataRowView)SellerComboBox.SelectedItem;
            if (seller == null)
            {

                return;
            }
            int sellerID = (int)seller.Row.ItemArray[0];
            BusinessLayer.DataUpdate.ChangeOrderSeller(this.Order, sellerID);
            this.DialogResult = DialogResult.Yes;
        }
    }
}
