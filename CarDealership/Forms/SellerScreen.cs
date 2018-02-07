using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarDealership.Forms;

namespace CarDealership.Forms
{
    public partial class SellerScreen : ScreenForm
    {

        private String m_CarVIN;
        private int? m_CustomerID;

        public SellerScreen(int Dealership, int EmployeeID)
        {
            InitializeComponent();
            this.NextScreen = Screens.Exit;
            this.DefaultDealership = Dealership;
            this.DealerShipSelector1.Value = Dealership;
            this.carsView1.SetDealership(Dealership);
            this.EmployeeID = EmployeeID;
            this.ordersView1.SetEmployeeID(EmployeeID);
            m_CarVIN = null;
            m_CustomerID = null;
        }


        private void UpdateCarToOrder()
        {
            this.CarTextBox.Text = this.carsView1.GetSelectedCarInfo();
        }

        private void UpdateCustomerOrder()
        {
            this.CustomerTextBox.Text = this.customersView1.GetSelectedCustomerInfo();
        }

        private void DealerShipSelector1_ValueChanged(object sender, EventArgs e)
        {
            int? val = (int)(sender as NumericUpDown).Value;
            if (val == 0) val = null;
            this.carsView1.SetDealership(val);
            this.carsView1.View();
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch ((sender as TabControl).SelectedIndex)
            {
                case 0:
                    break;
                case 1:
                    this.carsView1.View();
                    break;
                case 2:
                    this.customersView1.View(this.NameTextBox.Text, this.CityTextBox.Text);
                    break;
                case 3:
                    this.ordersView1.View();
                    break;

            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.NextScreen = Screens.Exit;
            this.Close();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            this.NextScreen = Screens.LoginScreen;
            this.Close();
        }

        private void FilterButton_Click(object sender, EventArgs e)
        {
            this.customersView1.View(this.NameTextBox.Text, this.CityTextBox.Text);
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            this.customersView1.View(null, null);
            this.NameTextBox.Clear();
            this.CityTextBox.Clear();
        }

        private void ShowOrderedCarsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            this.carsView1.SetShowOrderedCars((sender as CheckBox).Checked);
            this.carsView1.View();
        }

        private void AddToOrderButton_Click(object sender, EventArgs e)
        {
            if (this.DealerShipSelector1.Value != this.DefaultDealership)
            {
                MessageBox.Show("Viewing cars from another dealership", "Cannot order", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (this.carsView1.SelectedCarOrdered())
            {
                MessageBox.Show("Car already ordered", "Cannot order", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string selected = this.carsView1.SelectedCar();
                if (!String.IsNullOrEmpty(selected))
                {

                    m_CarVIN = selected;
                    this.UpdateCarToOrder();
                    this.tabControl.SelectedIndex = 4;
                }

            }

        }

        private void CarSelectButton_Click(object sender, EventArgs e)
        {
            this.tabControl.SelectedIndex = 1;
            if (m_CarVIN != null) this.carsView1.ChangeSelectedCar(m_CarVIN);

        }

        private void AddCustomerToOrderButton_Click(object sender, EventArgs e)
        {
            var selected = this.customersView1.SelectedCustomer();

            if (selected.HasValue)
            {
                m_CustomerID = selected.Value;
                this.UpdateCustomerOrder();
                this.tabControl.SelectedIndex = 4;
            }
        }

        private void CustomerSelectButton_Click(object sender, EventArgs e)
        {
            this.tabControl.SelectedIndex = 2;
            if (m_CustomerID.HasValue) this.customersView1.ChangeSelectedCustomer(m_CustomerID.Value);
        }

        private void CarDetailsButton_Click(object sender, EventArgs e)
        {
            var selected = this.carsView1.SelectedCar();
            if (selected == null) return;
            var dialog = new CarDetails(selected);
            dialog.ShowDialog(this);
        }

        private void PlaceOrderButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(m_CarVIN))
            {
                this.NewOrderToolTip.Show("Select car to order", this.CarTextBox);
                System.Media.SystemSounds.Asterisk.Play();
            }
            else if (!m_CustomerID.HasValue)
            {
                this.NewOrderToolTip.Show("Select customer", this.CustomerTextBox);
                System.Media.SystemSounds.Asterisk.Play();
            }
            else
            {
                BusinessLayer.DataAddition.OpenOrder(m_CarVIN, m_CustomerID.Value, EmployeeID);             
                this.tabControl.SelectedIndex = 3;
                this.ordersView1.SelectOrderByVIN(m_CarVIN);
                m_CarVIN = null;
                m_CustomerID = null;
                CustomerTextBox.Clear();
                CarTextBox.Clear();
            }
        }

        private void OrderCarDetailsButton_Click(object sender, EventArgs e)
        {
            var selected = this.ordersView1.SelectedCarVIN();
            if (!String.IsNullOrEmpty(selected))
            {
                var dialog = new CarDetails(selected);
                dialog.ShowDialog(this);
            }
        }

        private void OrderCustomerDetailsButton_Click(object sender, EventArgs e)
        {           
            var order = this.ordersView1.SelectedOrderID();
            if (order > 0 )
            {               
                this.tabControl.SelectedIndex = 2;
                this.customersView1.ChangeSelectedCustomer(order);
            }

        }

        private void OrderCancelButton_Click(object sender, EventArgs e)
        {
            var status = this.ordersView1.GetOrderStatus();
            if (status != String.Empty)
            {
                if (status == "Complete")
                {
                    System.Windows.Forms.MessageBox.Show("Cannot change completed orders", "Order complete", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    var id = this.ordersView1.SelectedOrderID();
                    BusinessLayer.DataDeletion.DeleteOrder(id);
                    this.ordersView1.View();
                }
            }
        }

        private void OrderInstallButton_Click(object sender, EventArgs e)
        {
            int id = this.ordersView1.SelectedOrderID();
            if (id == 0) return;
            if (this.ordersView1.GetOrderStatus() == "Complete")
            {
                System.Windows.Forms.MessageBox.Show("Cannot change completed orders", "Order complete", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var picker = new AccessoriesPicker(id);
            var result = picker.ShowDialog(this);
            if (result == DialogResult.Yes) this.ordersView1.View();
        }

        private void OrderCompleteButton_Click(object sender, EventArgs e)
        {
            var status = this.ordersView1.GetOrderStatus();
            if (status != String.Empty)
            {
                if (status == "Waiting")
                {
                    System.Windows.Forms.MessageBox.Show("Accessories are waiting to be installed. Cannot complete this order", "Cannot complete order", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (status == "Open")
                {
                    BusinessLayer.DataUpdate.ChangeOrderStauts(this.ordersView1.SelectedOrderID(), "Complete");
                    this.ordersView1.View();
                }
                else if (status == "Complete")
                {
                    System.Windows.Forms.MessageBox.Show("Cannot change completed orders", "Order complete", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ChPwdButton_Click(object sender, EventArgs e)
        {
            var dialog = new CarDealership.Forms.PasswordChange(this.EmployeeID);
            dialog.ShowDialog(this);
        }

        private void orderNotesButton_Click(object sender, EventArgs e)
        {
            int id = this.ordersView1.SelectedOrderID();
            if (id != 0)
            {
                var dialog = new CarDealership.Forms.OrderNotes(this.ordersView1.SelectedOrderID());
                dialog.ShowDialog(this);
                this.ordersView1.View();
            }
        }

        private void DiscountsButton_Click(object sender, EventArgs e)
        {
            int id = this.ordersView1.SelectedOrderID();
            if (id == 0) return;
            if (this.ordersView1.GetOrderStatus() == "Complete")
            {
                System.Windows.Forms.MessageBox.Show("Cannot change completed orders", "Order complete", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var dialog = new Forms.DiscountsPicker(id);
            dialog.ShowDialog(this);
            this.ordersView1.View();
        }

        private void NewCustomerButton_Click(object sender, EventArgs e)
        {
            var dialog = new Forms.CustomerAdd();
            var result = dialog.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                this.ResetButton.PerformClick();
            }
        }

        private void EditCustomerButton_Click(object sender, EventArgs e)
        {
            var customer = this.customersView1.SelectedCustomer();
            if (customer == null) return;
            var dialog = new Forms.CustomerEdit(customer.Value);
            var result = dialog.ShowDialog(this);
            if (result == DialogResult.OK) this.customersView1.View(this.NameTextBox.Text,this.CityTextBox.Text);
        }
    }
}
