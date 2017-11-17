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

        private void Initialize()
        {
            
            var dealerships = BusinessLayer.DataAcquisition.GetDealerships(null);
            this.BindingContext = new BindingContext();
            this.DataSource = dealerships;
            this.DisplayMember = "DEALERSHIP_ID";
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
                this.SelectedIndex = -1;
            }
        }

        public void ClearSelection()
        {
            this.SelectedIndex = -1;
        }
    }
}
