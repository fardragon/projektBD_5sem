using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using DataLayer;

namespace CarDealership
{
    public partial class EmployeesView : UserControl
    {
        public EmployeesView()
        {
            InitializeComponent();
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            
        }

        private void EmployeesView_Enter(object sender, EventArgs e)
        {
        }

        private void Populate()
        {
            dataGridView.Rows.Clear();
            var list = BusinessLayer.AdminLogic.GetEmployees();
            foreach (Employee emp in list)
            {
                dataGridView.Rows.Add(emp.EMPLOYEE_ID, emp.NAME, emp.SURNAME, emp.DEALERSHIP_ID, emp.Role.ROLE1.ToString(), emp.LOGIN, emp.PASSWORD);
            }
        }

        public void View()
        {
            this.Populate();
        }
        public int CurrentID()
        {
            return (int)dataGridView.CurrentRow.Cells[0].Value;
        }
    }
}
