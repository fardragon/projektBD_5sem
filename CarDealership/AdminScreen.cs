using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            var database = new DealershipDataContext();
            database.ExecuteCommand("EXEC dbo.reset;");

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void EmployeesTab_Enter(object sender, EventArgs e)
        {
            
        }
    }
}
