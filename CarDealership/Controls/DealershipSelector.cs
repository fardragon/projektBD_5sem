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
    public partial class DealershipSelector : ComboBox
    {
        public DealershipSelector()
        {
            InitializeComponent();
            Initialize();
        }

        public void Initialize()
        {
            this.Items.Clear();
            this.Items.Add("");   
            var dealerships = BusinessLayer.DataAcquisition.GetDealerships(null);
            foreach (Dealership deal in dealerships)
            {
                this.Items.Add(deal.DEALERSHIP_ID);
            }
            this.DropDownStyle = ComboBoxStyle.DropDownList;
            
        }
        public void ChangeSelected(int? selection)
        {
            if (selection.HasValue)
            {
                this.SelectedIndex = this.FindStringExact(selection.ToString());
            }
            else
            {
                this.SelectedIndex = 0;
            }
        }
    }
}
