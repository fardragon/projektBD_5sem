using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CarDealership
{
    public class ScreenForm : Form
    {
        private CarDealership.Screens nextScreen;
        private int defaultDealership;
        private int employeeID;
        public CarDealership.Screens NextScreen
        {
            get { return nextScreen; }
            protected set { nextScreen = value; }
        }
        public int DefaultDealership
        {
            get { return defaultDealership; }
            set { defaultDealership = value; }
        }
        public int EmployeeID
        {
            get { return employeeID; }
            set { employeeID = value; }
        }
    }
}
