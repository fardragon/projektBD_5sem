using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarDealership.Forms
{
    public partial class PeriodSelect : Form
    {
        private DateTime From;
        private DateTime To;
        public PeriodSelect()
        {
            InitializeComponent();
            var date = DateTime.Now;
            this.dateTimePickerTo.Value = date;
            To = date;
            this.dateTimePickerTo.MaxDate = date;
            this.dateTimePickerFrom.MaxDate = date;
            date = date.AddMonths(-1);
            this.dateTimePickerFrom.Value = date;
            From = date;
        }

        private void dateTimePickerTo_ValueChanged(object sender, EventArgs e)
        {
            if (this.dateTimePickerTo.Value.CompareTo(this.dateTimePickerFrom.Value) < 0)
            {
                this.dateTimePickerFrom.Value = this.dateTimePickerTo.Value;
            }
            To = dateTimePickerTo.Value;
        }

        private void dateTimePickerFrom_ValueChanged(object sender, EventArgs e)
        {
            if (this.dateTimePickerFrom.Value.CompareTo(this.dateTimePickerTo.Value) > 0)
            {
                this.dateTimePickerTo.Value = this.dateTimePickerFrom.Value;
            }
            From = dateTimePickerFrom.Value;
        }

        public DateTime GetFromDate()
        {
            return From;
        }
        public DateTime GetToDate()
        {
            return To;
        }
    }
}
