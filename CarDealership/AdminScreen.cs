﻿using System;
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
    public partial class AdminScreen : ScreenForm
    {
        public AdminScreen()
        {
            InitializeComponent();
            this.NextScreen = Screens.Exit;

        }
    }
}