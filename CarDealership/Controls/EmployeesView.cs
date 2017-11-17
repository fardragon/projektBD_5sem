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
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor;
            dataGridView.Rows.Clear();
            var list = BusinessLayer.DataAcquisition.GetEmployees(null);
            foreach (Employee emp in list)
            {
                dataGridView.Rows.Add(emp.EMPLOYEE_ID, emp.NAME, emp.SURNAME, emp.DEALERSHIP_ID, emp.Role.ROLE_NAME, emp.LOGIN, emp.PASSWORD);
            }
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default;
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
