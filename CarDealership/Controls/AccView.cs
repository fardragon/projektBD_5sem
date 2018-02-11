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
    public partial class AccView : UserControl
    {
        private int Type;
        public AccView()
        {
            InitializeComponent();
            Type = 0;
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public void SetType(int Type)
        {
            this.Type = Type;
        }

        public void View()
        {
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor;
            this.dataGridView1.Rows.Clear();
            if (Type == 0) return;
            var accessories = BusinessLayer.DataAcquisition.GetAccessories(Type);
            foreach (var acc in accessories)
            {
                this.dataGridView1.Rows.Add(acc.ACCESSORY_ID, acc.NAME, acc.PRICE);
            }
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default;
        }

        public int GetSelectedAccID()
        {
            if (this.dataGridView1.SelectedRows.Count == 0) return 0;
            return (int)this.dataGridView1.CurrentRow.Cells[0].Value;
        }
    }
}
