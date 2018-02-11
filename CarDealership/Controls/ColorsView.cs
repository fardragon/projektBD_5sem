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
    public partial class ColorsView : UserControl
    {
        public ColorsView()
        {
            InitializeComponent();
            this.dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public void View()
        {
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor;
            this.dataGridView.Rows.Clear();
            var colors = BusinessLayer.DataAcquisition.GetColors();
            foreach (DataLayer.Color col in colors)
            {
                this.dataGridView.Rows.Add(col.COLOR_ID, col.NAME);
            }
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default;
        }
        public int GetSelectedColorID()
        {
            if (this.dataGridView.SelectedRows.Count == 0) return 0;
            return (int)this.dataGridView.CurrentRow.Cells[0].Value;
        }
    }
}
