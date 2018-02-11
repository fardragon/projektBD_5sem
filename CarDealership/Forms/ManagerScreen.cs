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
    public partial class ManagerScreen : ScreenForm
    {
        public ManagerScreen(int DealershipID,int EmployeeID)
        {
            InitializeComponent();
            this.NextScreen = Screens.Exit;
            this.DefaultDealership = DealershipID;
            this.EmployeeID = EmployeeID;
            this.employeesManagerView1.SetDealershipID(DealershipID);
            this.carsView1.SetDealership(DealershipID);
            this.carsView1.SetShowOrderedCars(true);
            this.ordersView1.SetDealershipID(DealershipID);

            try
            {
                this.employeesTableAdapter.FillBy(this.sellersDataSet.Employees);
                this.dealershipsTableAdapter.FillBy(this.dealershipsDataSet.Dealerships);
                this.modelsTableAdapter.Fill(this.modelsDataSet.Models);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                this.tabControl1.SelectedIndex = 0;
            }

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.tabControl1.SelectedIndex)
            {
                case 0:
                    break;
                case 1:
                    this.employeesManagerView1.View();
                    break;
                case 2:
                    this.carsView1.View();
                    break;
                case 3:
                    this.ordersView1.View();
                    break;
                case 4:                  
                    try
                    {
                        this.employeesTableAdapter.FillBy(this.sellersDataSet.Employees);
                        this.dealershipsTableAdapter.FillBy(this.dealershipsDataSet.Dealerships);
                        this.modelsTableAdapter.Fill(this.modelsDataSet.Models);
                    }
                    catch (System.Exception ex)
                    {
                        System.Windows.Forms.MessageBox.Show(ex.Message);
                        this.tabControl1.SelectedIndex = 0;

                    }
                    this.archiveView1.View();
                    break;
            }
        }

        private void CarDetailsButton_Click(object sender, EventArgs e)
        {
            var dialog = new CarDetails(this.carsView1.SelectedCar());
            dialog.ShowDialog(this);
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            this.NextScreen = Screens.LoginScreen;
            this.Close();
        }

        private void ChPwdButton_Click(object sender, EventArgs e)
        {
            var dialog = new Forms.PasswordChange(EmployeeID);
            dialog.ShowDialog(this);
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.NextScreen = Screens.Exit;
            this.Close();
        }

        private void AddCarsButton_Click(object sender, EventArgs e)
        {
            var dialog = new Forms.AddCar(this.DefaultDealership);
            dialog.ShowDialog(this);
            this.carsView1.View();
        }

        private void GoToOrderButton_Click(object sender, EventArgs e)
        {
            if (!this.carsView1.SelectedCarOrdered()) return;
            var vin = this.carsView1.SelectedCar();
            if (!String.IsNullOrEmpty(vin))
            {
                this.tabControl1.SelectedIndex = 3;
                this.ordersView1.SelectOrderByVIN(vin);
            }
        }

        private void AddSellerButton_Click(object sender, EventArgs e)
        {
            var dialog = new Forms.AddEmployeeManager("Seller", this.DefaultDealership);
            var result = dialog.ShowDialog(this);
            if (result == DialogResult.Yes) this.employeesManagerView1.View();
        }

        private void AddMechanicButton_Click(object sender, EventArgs e)
        {
            var dialog = new Forms.AddEmployeeManager("Mechanic", this.DefaultDealership);
            var result = dialog.ShowDialog(this);
            if (result == DialogResult.Yes) this.employeesManagerView1.View();
        }

        private void RemoveCarButton_Click(object sender, EventArgs e)
        {
            var ordered = this.carsView1.SelectedCarOrdered();
            if (ordered)
            {
                MessageBox.Show("Selected car belongs to an order", "Cannot remove", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var car = this.carsView1.SelectedCar();
            if (!String.IsNullOrEmpty(car))
            {
                BusinessLayer.DataDeletion.RemoveCar(car);
                this.carsView1.View();
            }

        }

        private void OrderNotesButton_Click(object sender, EventArgs e)
        {
            var id = this.ordersView1.SelectedOrderID();
            if (id > 0)
            {
                var dialog = new Forms.OrderNotes(id);
                dialog.ReadOnly(true);
                dialog.ShowDialog(this);
            }          
        }

        private void OrderCancelButton_Click(object sender, EventArgs e)
        {
            var status = this.ordersView1.GetOrderStatus();
            if (String.IsNullOrEmpty(status)) return;
            if (status == "Complete")
            {
                MessageBox.Show("Cannot remove completed orders", "Cannot remove", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            BusinessLayer.DataDeletion.DeleteOrder(this.ordersView1.SelectedOrderID());
            this.ordersView1.View();
        }

        private void ArchivizeButton_Click(object sender, EventArgs e)
        {
            var status = this.ordersView1.GetOrderStatus();
            if (String.IsNullOrEmpty(status)) return;
            if (status != "Complete")
            {
                MessageBox.Show("Cannot archivize orders that are not completed", "Cannot archivize", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            BusinessLayer.DataUpdate.ArchivizeOrder(this.ordersView1.SelectedOrderID());
            this.ordersView1.View();
        }

        private void ArchivizeAllButton_Click(object sender, EventArgs e)
        {
            var orders = this.ordersView1.GetOrdersWithStatus("Complete");
            foreach (int order in orders)
            {
                BusinessLayer.DataUpdate.ArchivizeOrder(order);
            }
            this.ordersView1.View();
        }

        private void OrderReassignButton_Click(object sender, EventArgs e)
        {
            var id = this.ordersView1.SelectedOrderID();
            if (id > 0)
            {
                var dialog = new Forms.OrderReassign(this.DefaultDealership,id);
                var result = dialog.ShowDialog(this);
                if (result == DialogResult.Yes) this.ordersView1.View();
            }
            
        }

        private void LoadArchive()
        {
            if (DealershipCheckBox.Checked)
            {
                var deal = (DataRowView)DealershipComboBox.SelectedItem;
                if (deal != null)
                {
                    var dealID = (int)deal.Row.ItemArray[0];
                    this.employeesBindingSource.Filter = "DEALERSHIP_ID =" + dealID.ToString();
                    this.archiveView1.SetDealership(dealID);
                }
                else
                {
                    this.employeesBindingSource.Filter = null;
                    this.archiveView1.SetDealership(null);
                }
            }
            else
            {
                this.employeesBindingSource.Filter = null;
                this.archiveView1.SetDealership(null);
            }

            if (EmployeeCheckBox.Checked)
            {
                var employee = (DataRowView)EmployeeComboBox.SelectedItem;
                if (employee != null)
                {
                    var employeeID = (int)employee.Row.ItemArray[0];
                    this.archiveView1.SetEmployee(employeeID);
                }
                else
                {
                    this.archiveView1.SetEmployee(null);
                }
            }
            else
            {
                this.archiveView1.SetEmployee(null);
            }

            if (ModelCheckBox.Checked)
            {
                var model = (DataRowView)ModelComboBox.SelectedItem;
                if (model != null)
                {
                    var modelID = (int)model.Row.ItemArray[0];
                    this.archiveView1.SetModel(modelID);
                }
                else
                {
                    this.archiveView1.SetModel(null);
                }
            }
            else
            {
                this.archiveView1.SetModel(null);
            }
            this.archiveView1.View();
        }

        private void DealershipComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadArchive();
        }

        private void DealershipCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            LoadArchive();
        }

        private void EmployeeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            LoadArchive();
        }

        private void EmployeeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadArchive();
        }

        private void ModelCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            LoadArchive();
        }

        private void ModelComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadArchive();
        }

        private void ArchiveDetailsButton_Click(object sender, EventArgs e)
        {
            var id = this.archiveView1.SelectedSaleID();
            if (id != 0)
            {
                var dialog = new ArchiveDetails(id);
                dialog.ShowDialog(this);
            }
        }

        private void RemoveEmployeeButton_Click(object sender, EventArgs e)
        {
            var role = this.employeesManagerView1.SelectedEmployeeRole();
            if (String.IsNullOrEmpty(role)) return;
            if ((role == "Seller") || (role == "Mechanic"))
            {
                var id = this.employeesManagerView1.SelectedEmployeeID();
                var count = BusinessLayer.DataAcquisition.GetEmployeeOrdersCount(id);
                if (count > 0)
                {
                    var result = MessageBox.Show("This employee has an active order. Do you want to proceed?", "Active orders!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result != DialogResult.Yes) return;                
                }
                BusinessLayer.DataDeletion.DeleteEmployee(id);
                this.employeesManagerView1.View();
            }
            else
            {
                MessageBox.Show("Cannot remove this employee", "Cannot remove", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
