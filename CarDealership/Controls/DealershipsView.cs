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

namespace CarDealership.Controls
{
    public partial class DealershipsView : UserControl
    {
        public DealershipsView()
        {
            InitializeComponent();
        }

        public void View()
        {
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor;
            dataGridView.Rows.Clear();
            var list = BusinessLayer.DataAcquisition.GetDealerships(null);
            foreach (Dealership deal in list)
            {
                dataGridView.Rows.Add(deal.DEALERSHIP_ID,deal.STREET_ADDRESS,deal.CITY,deal.ZIPCODE,deal.MANAGER_ID);
            }
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default;
        }

        public int CurrentID()
        {
            return (int)dataGridView.CurrentRow.Cells[0].Value;
        }
    }


}
