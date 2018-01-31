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
    public partial class MechanicScreen : ScreenForm
    {
        public MechanicScreen()
        {
            InitializeComponent();
            this.NextScreen = Screens.Exit;
        }
    }
}
