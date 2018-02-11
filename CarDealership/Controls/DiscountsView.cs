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
    public partial class DiscountsView : UserControl
    {
        public DiscountsView()
        {
            InitializeComponent();
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public void View()
        {
            var discounts = BusinessLayer.DataAcquisition.GetDiscounts();
            this.dataGridView1.Rows.Clear();
            foreach (var disc in discounts)
            {
                this.dataGridView1.Rows.Add(disc.DISCOUNT_ID, disc.NAME, disc.VALUE);
            }
        }
        public int GetSelectedDiscountID()
        {
            if (this.dataGridView1.SelectedRows.Count == 0) return 0;
            return (int)this.dataGridView1.CurrentRow.Cells[0].Value;
        }

    }
}
