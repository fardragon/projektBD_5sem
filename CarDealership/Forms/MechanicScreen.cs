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
    public partial class MechanicScreen : ScreenForm
    {
        public MechanicScreen(int Dealership, int Employee)
        {
            InitializeComponent();
            this.EmployeeID = Employee;
            this.DefaultDealership = Dealership;
            this.NextScreen = Screens.Exit;
            this.accInstallView1.SetDealership(Dealership);
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            this.NextScreen = Screens.LoginScreen;
            this.Close();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.NextScreen = Screens.Exit;
            this.Close();
        }

        private void ChPwdButton_Click(object sender, EventArgs e)
        {
            var dialog = new Forms.PasswordChange(this.EmployeeID);
            dialog.ShowDialog(this);
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.tabControl1.SelectedIndex)
            {
                case 0:
                    break;
                case 1:
                    this.accInstallView1.View();
                    break;
            }
        }

        private void InstallButton_Click(object sender, EventArgs e)
        {
            var level = this.accInstallView1.GetLevel();
            if (level == null) return;
            if (level == 0)
            {
                MessageBox.Show(this, "Select individual accessories", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            var VIN = this.accInstallView1.GetCarVin();
            var accID = this.accInstallView1.GetAccID();
            BusinessLayer.DataUpdate.CompleteInstallOrder(VIN, accID);
            this.accInstallView1.View();
        }
    }
}
