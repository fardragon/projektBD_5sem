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
    public partial class AdminScreen : ScreenForm
    {
        public AdminScreen(int employeeID)
        {
            InitializeComponent();
            this.EmployeeID = employeeID;
            this.NextScreen = Screens.Exit;
            this.roleSelector1.AllowNull();
            this.carsView1.SetShowOrderedCars(true);
            this.accessories_TypesTableAdapter.Fill(this.accCatDataSet.Accessories_Types);
        }

                  


        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            this.NextScreen = Screens.LoginScreen;
            this.Close();
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch ((sender as TabControl).SelectedIndex)
            {
                case 0:
                    break;
                case 1:
                    this.employeesView1.View();
                    this.textBoxNameEmp.Clear();
                    this.textBoxSurnameEmp.Clear();
                    this.roleSelector1.Initialize();
                    this.roleSelector1.AllowNull();
                    this.roleSelector1.SelectedIndex = 0;
                    this.dealershipSelector1.Initialize();
                    this.dealershipSelector1.SelectedIndex = 0;                 
                    break;
                case 2:
                    this.dealershipsView1.View();
                    break;
                case 3:
                    this.modelsView1.View();
                    this.colorsView.View();
                    break;
                case 4:
                    this.carsView1.View();
                    break;
                case 5:
                    this.customersView.View(null,null);
                    break;
                case 6:
                    this.accessories_TypesTableAdapter.Fill(this.accCatDataSet.Accessories_Types);
                    this.AccessoriesTabLoad();
                    this.discountsView1.View();
                    break;
                default:
                    break;
            }
        }

        private void buttonEDIT_Click(object sender, EventArgs e)
        {
            var id = this.employeesView1.CurrentID();
            var dialog = new EmployeeEdit(id);
            var result = dialog.ShowDialog(this);
            if (result == DialogResult.Yes) this.employeesView1.View();
        }

        private void buttonDelEmp_Click(object sender, EventArgs e)
        {
            var id = this.employeesView1.CurrentID();
            if (id == this.EmployeeID)
            {
                System.Windows.Forms.MessageBox.Show(this, "Cannot delete yourself", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                System.Media.SystemSounds.Asterisk.Play();
                return;
            }
            BusinessLayer.DataDeletion.DeleteEmployee(id);
            this.employeesView1.View();
        }

        private void buttonAddEmp_Click(object sender, EventArgs e)
        {
            var dialog = new EmployeeAdd();
            var result = dialog.ShowDialog(this);
            if (result == DialogResult.Yes) this.employeesView1.View();
        }

        private void buttonFilerEmp_Click(object sender, EventArgs e)
        {
            this.employeesView1.Filter(this.textBoxNameEmp.Text, this.textBoxSurnameEmp.Text, this.dealershipSelector1.SelectedItem.ToString(), this.roleSelector1.SelectedItem.ToString());
        }

        private void buttonResetEmp_Click(object sender, EventArgs e)
        {
            this.textBoxNameEmp.Clear();
            this.textBoxSurnameEmp.Clear();
            this.roleSelector1.SelectedIndex = 0;
            this.dealershipSelector1.SelectedIndex = 0;
            this.employeesView1.View();
        }

        private void buttonAddDeal_Click(object sender, EventArgs e)
        {
            var dialog = new DealershipAdd();
            var result = dialog.ShowDialog(this);
            if (result == DialogResult.Yes) this.dealershipsView1.View();

        }

        private void buttonEditDeal_Click(object sender, EventArgs e)
        {
            var dialog = new Forms.DealershipEdit(this.dealershipsView1.CurrentID());
            var result = dialog.ShowDialog(this);
            if (result == DialogResult.Yes) this.dealershipsView1.View();
        }

        private void ChPwdButton_Click(object sender, EventArgs e)
        {
            var dialog = new CarDealership.Forms.PasswordChange(this.EmployeeID);
            dialog.ShowDialog(this);
        }

        private void ModelAddButton_Click(object sender, EventArgs e)
        {
            var dialog = new Forms.ModelAdd();
            var result = dialog.ShowDialog(this);
            if (result == DialogResult.Yes)
            {
                this.modelsView1.View();
            }
        }

        private void AddClrButton_Click(object sender, EventArgs e)
        {
            var dialog = new CarDealership.Forms.ColorAdd();
            var result = dialog.ShowDialog(this);
            if (result == DialogResult.Yes) this.colorsView.View();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            BusinessLayer.Utility.Reset();
        }
        
        private void AccessoriesTabLoad()
        {
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor;        
            var Type = (DataRowView)this.CategoryComboBox.SelectedItem;
            if (Type != null)
            {
                var TypeID = (int)Type.Row.ItemArray[0];
                this.accView1.SetType(TypeID);
            }
            this.accView1.View();

            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default;
        }

        private void AddAccCatButton_Click(object sender, EventArgs e)
        {
            var dialog = new Forms.AddCategory();
            var result = dialog.ShowDialog(this);
            if (result == DialogResult.Yes)
            {
                this.accessories_TypesTableAdapter.Fill(this.accCatDataSet.Accessories_Types);
                this.AccessoriesTabLoad();
            }
               
        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.AccessoriesTabLoad();   
        }

        private void AddAccButton_Click(object sender, EventArgs e)
        {
            var Type = (DataRowView)this.CategoryComboBox.SelectedItem;
            if (Type != null)
            {
                var TypeID = (int)Type.Row.ItemArray[0];
                var dialog = new Forms.AddAccessory(TypeID);
                var result = dialog.ShowDialog(this);
                if (result == DialogResult.Yes) this.accView1.View();
            }
        }

        private void AddDiscButton_Click(object sender, EventArgs e)
        {
            var dialog = new Forms.AddDiscount();
            var result = dialog.ShowDialog(this);
            if (result == DialogResult.Yes) this.discountsView1.View();
        }

        private void AccDelBUtton_Click(object sender, EventArgs e)
        {
            var id = this.accView1.GetSelectedAccID();
            if (id == 0) return;
            if (BusinessLayer.DataAcquisition.CanDeleteAccessory(id))
            {
                BusinessLayer.DataDeletion.DeleteAccessory(id);
                this.accView1.View();                
            }
            else
            {
                MessageBox.Show(this, "This item is in use", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DiscDelButton_Click(object sender, EventArgs e)
        {
            var id = this.discountsView1.GetSelectedDiscountID();
            if (id == 0) return;
            if (BusinessLayer.DataAcquisition.CanDeleteDiscount(id))
            {
                BusinessLayer.DataDeletion.DeleteDiscount(id);
                this.discountsView1.View();
            }
            else
            {
                MessageBox.Show(this, "This item is in use", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DelColButton_Click(object sender, EventArgs e)
        {
            var id = this.colorsView.GetSelectedColorID();
            if (id == 0) return;
            if (BusinessLayer.DataAcquisition.CanDeleteColor(id))
            {
                BusinessLayer.DataDeletion.DeleteColor(id);
                this.colorsView.View();
            }
            else
            {
                MessageBox.Show(this, "This item is in use", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DelModelButton_Click(object sender, EventArgs e)
        {
            var id = this.modelsView1.GetSelectedModelID();
            if (id == 0) return;
            if (BusinessLayer.DataAcquisition.CanDeleteModel(id))
            {
                BusinessLayer.DataDeletion.DeleteModel(id);
                this.modelsView1.View();
            }
            else
            {
                MessageBox.Show(this, "This item is in use", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
