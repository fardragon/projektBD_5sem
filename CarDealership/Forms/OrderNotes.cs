using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;

namespace CarDealership.Forms
{
    public partial class OrderNotes : Form
    {
        private int m_orderID;
        public OrderNotes(int orderID)
        {
            InitializeComponent();
            m_orderID = orderID;
            this.textBox1.Text = BusinessLayer.DataAcquisition.GetOrderNotes(m_orderID);
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (this.textBox1.ReadOnly == false) BusinessLayer.DataUpdate.UpdateOrderNotes(m_orderID, this.textBox1.Text);
            this.DialogResult = DialogResult.Yes;
        }

        public void ReadOnly()
        {
            this.textBox1.ReadOnly = true;
        }
    }
}
