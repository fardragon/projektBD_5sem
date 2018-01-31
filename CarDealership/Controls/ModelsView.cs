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


namespace CarDealership.Controls
{
    public partial class ModelsView : UserControl
    {
        public ModelsView()
        {
            InitializeComponent();
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public void View()
        {
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor;
            dataGridView.Rows.Clear();
            var models = BusinessLayer.DataAcquisition.GetModels();
            foreach (Model m in models)
            {
                dataGridView.Rows.Add(m.MODEL_ID, m.NAME, m.BASE_PRICE);
            }
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default;
        }

    }
}
