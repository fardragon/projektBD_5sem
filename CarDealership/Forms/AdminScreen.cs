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

namespace CarDealership
{
    public partial class AdminScreen : ScreenForm
    {
        public AdminScreen()
        {
            InitializeComponent();
            this.NextScreen = Screens.Exit;
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor;
            BusinessLayer.DataAcquisition.DEBUG_RESET();
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default;
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
            BusinessLayer.DataDeletion.DeleteEmployee(id);
            this.employeesView1.View();
        }

        private void buttonAddEmp_Click(object sender, EventArgs e)
        {
            var dialog = new EmployeeAdd();
            var result = dialog.ShowDialog(this);
            if (result == DialogResult.Yes) this.employeesView1.View();
        }
    }
}
