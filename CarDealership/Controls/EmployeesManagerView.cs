using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer;
using BusinessLayer;

namespace CarDealership.Controls
{
    public partial class EmployeesManagerView : UserControl
    {
        private int dealershipID;
        public EmployeesManagerView()
        {
            InitializeComponent();
            dealershipID = 0;
            this.dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public void SetDealershipID(int id)
        {
            dealershipID = id;
        }

        public void View()
        {
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor;
            dataGridView.Rows.Clear();
            var criteria = new Employee()
            {
                DEALERSHIP_ID = dealershipID
            };
            var list = BusinessLayer.DataAcquisition.GetEmployees(criteria);
            foreach (Employee emp in list)
            {
                dataGridView.Rows.Add(emp.EMPLOYEE_ID, emp.NAME, emp.SURNAME, emp.Role.ROLE_NAME,BusinessLayer.DataAcquisition.GetEmployeeOrdersCount(emp.EMPLOYEE_ID),BusinessLayer.DataAcquisition.GetEmployeeSalesCount(emp.EMPLOYEE_ID));
            }
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default;
        }
    }
}
