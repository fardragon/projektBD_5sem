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
    public partial class CarsView : UserControl
    {
        private int? DealershipID;
        private bool ShowOrderedCars;
        public CarsView()
        {
            InitializeComponent();
            DealershipID = null;
            ShowOrderedCars = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public void SetDealership(int? DealershipID)
        {
            this.DealershipID = DealershipID;
        }

        public void SetShowOrderedCars(bool ShowOrderedCars)
        {
            this.ShowOrderedCars = ShowOrderedCars;
        }

        public void View()
        {
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor;
            this.dataGridView1.Rows.Clear();
            var cars = BusinessLayer.DataAcquisition.GetCars(DealershipID, ShowOrderedCars);
            foreach (var car in cars)
            {
                this.dataGridView1.Rows.Add(car.CAR_VIN, car.Model.NAME, car.Model.BASE_PRICE, car.PRODUCTION_YEAR, car.Color.NAME, car.DEALERSHIP_ID, car.Mounted_Accessories.Count ,car.Active_Orders.Count > 0 );
            }
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default;
        }

        public String SelectedCar()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                return dataGridView1.CurrentRow.Cells[0].Value.ToString();
            }
            return null;
        }

        public bool SelectedCarOrdered()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                return (bool)dataGridView1.CurrentRow.Cells[7].Value;
            }
            return false;
        }

        public String GetSelectedCarInfo()
        {
            return dataGridView1.CurrentRow.Cells[3].Value.ToString() + " " + dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        public void ChangeSelectedCar(String VIN)
        {
            this.dataGridView1.ClearSelection();
            foreach (DataGridViewRow row in this.dataGridView1.Rows)
            {
                if (row.Cells[0].Value.ToString() == VIN)
                {                
                    row.Selected = true;
                    return;
                }
            }
        }
    }

}
