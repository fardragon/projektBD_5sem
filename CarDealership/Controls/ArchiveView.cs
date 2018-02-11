using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarDealership.Controls
{
    public partial class ArchiveView : UserControl
    {
        private int? ModelID;
        private int? DealershipID;
        private int? EmployeeID;
        public ArchiveView()
        {
            InitializeComponent();
            ModelID = null;
            DealershipID = null;
            EmployeeID = null;
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public void View()
        {
            this.dataGridView1.Rows.Clear();
            var sales = BusinessLayer.DataAcquisition.GetArchive(DealershipID, ModelID, EmployeeID);
            foreach(var sale in sales)
            {
                this.dataGridView1.Rows.Add(sale.SALE_ID, sale.CAR_VIN, sale.Model.NAME, sale.Color.NAME, sale.PRODUCTION_YEAR, sale.EMPLOYEE_ID, sale.CUSTOMER_ID, sale.SALE_DATE);
            }
        }

        public void SetDealership(int? Dealership)
        {
            DealershipID = Dealership;
        }

        public void SetEmployee(int? Employee)
        {
            EmployeeID = Employee;
        }

        public void SetModel(int? Model)
        {
            ModelID = Model;
        }

        public int SelectedSaleID()
        {
            if (this.dataGridView1.SelectedRows.Count == 0) return 0;
            return (int)this.dataGridView1.CurrentRow.Cells[0].Value;
        }
    }
}
