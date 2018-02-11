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
    public partial class OrdersView : UserControl
    {
        private int? m_DealershipID;
        private int? m_EmployeeID;
        private int? m_OrderStatusID;
        public OrdersView()
        {
            InitializeComponent();
            m_DealershipID = null;
            m_EmployeeID = null;
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            m_OrderStatusID = null;
        }

        public void SetDealershipID(int? DealershipID)
        {
            m_DealershipID = DealershipID;
        }

        public void SetEmployeeID(int? EmployeeID)
        {
            m_EmployeeID = EmployeeID;
            dataGridView1.Columns[4].Visible = false;
        }

        public void View()
        {
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor;
            this.dataGridView1.Rows.Clear();
            var orders = BusinessLayer.DataAcquisition.GetOrders(m_DealershipID, m_EmployeeID, m_OrderStatusID);
            foreach (var ord in orders)
            {
                var price = BusinessLayer.DataAcquisition.CalculatePrice(ord.ORDER_ID);
                this.dataGridView1.Rows.Add(ord.ORDER_ID, ord.CAR_VIN, ord.Customer.NAME, price, ord.EMPLOYEE_ID, ord.Order_Statuse.STATUS, ord.Accessories_Install_Orders.Count, ord.OPENED_DATE, ord.LAST_UPDATE);
            }
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default;
        }

        public String SelectedCarVIN()
        {
            if (this.dataGridView1.SelectedRows.Count == 0) return String.Empty;
            return this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        public int SelectedOrderID()
        {
            if (this.dataGridView1.SelectedRows.Count == 0) return 0;
            return (int) this.dataGridView1.CurrentRow.Cells[0].Value;
        }

        public String GetOrderStatus()
        {
            if (this.dataGridView1.SelectedRows.Count == 0) return String.Empty;
            return this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }

        public List<int> GetOrdersWithStatus(String status)
        {
            List<int> result = new List<int>();
            foreach (DataGridViewRow row in this.dataGridView1.Rows)
            {
                if (row.Cells[5].Value.ToString() == status)
                {
                    result.Add((int)row.Cells[0].Value);
                }
            }
            return result;
        }

        public void SelectOrderByVIN(String VIN)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if(row.Cells[1].Value.ToString() == VIN)
                {
                    row.Selected = true;
                    return;
                }
            }
        }

    }
}
