using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarDealership
{
    public partial class ManagerScreen : ScreenForm
    {
        private int dealershipID;
        public ManagerScreen(int DealershipID)
        {
            InitializeComponent();
            this.NextScreen = Screens.Exit;
            dealershipID = DealershipID;
            this.employeesManagerView1.SetDealershipID(DealershipID);
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch ((sender as TabControl).SelectedIndex)
            {
                case 0:
                    break;
                case 1:
                    this.employeesManagerView1.View();
                    break;
            }
        }
    }
}
