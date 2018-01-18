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
    public partial class CustomersView : UserControl
    {
        public CustomersView()
        {
            InitializeComponent();
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public void View(string Name, string City)
        {
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor;
            this.dataGridView1.Rows.Clear();
            var customers = BusinessLayer.DataAcquisition.GetCustomers(null, Name, City);
            foreach (var cust in customers)
            {
                this.dataGridView1.Rows.Add(cust.CUSTOMER_ID, cust.NAME, cust.STREET_ADDRESS, cust.CITY, cust.ZIPCODE, cust.PHONE, cust.MAIL);
            }

            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default;
        }

        public int? SelectedCustomer()
        {
            if (this.dataGridView1.SelectedRows.Count > 0)
            {
                return (int)this.dataGridView1.CurrentRow.Cells[0].Value;
            }
            return null;
        }

        public String GetSelectedCustomerInfo()
        {
            return this.dataGridView1.CurrentRow.Cells[0].Value.ToString() + " " + this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        public void ChangeSelectedCustomer(int ID)
        {
            this.dataGridView1.ClearSelection();
            foreach (DataGridViewRow row in this.dataGridView1.Rows)
            {
                if (((int)row.Cells[0].Value) == ID)
                {
                    row.Selected = true;
                    return;
                }
            }
        }

    }
}
