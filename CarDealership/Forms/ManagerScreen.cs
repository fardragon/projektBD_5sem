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
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch ((sender as TabControl).SelectedIndex)
            {
                case 0:
                    break;
                case 1:
                    this.employeesManagerView1.View();
                    break;
                case 2:
                    this.carsView1.View();
                    break;
            }
        }

        private void CarDetailsButton_Click(object sender, EventArgs e)
        {
            var dialog = new CarDetails(this.carsView1.SelectedCar());
            dialog.ShowDialog(this);
        }
    }
}
