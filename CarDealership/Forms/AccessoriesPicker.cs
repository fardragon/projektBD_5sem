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
    public partial class AccessoriesPicker : Form
    {
        private int m_orderID;
        public AccessoriesPicker(int orderID)
        {
            InitializeComponent();
            m_orderID = orderID;
            this.LoadData();
        }

        private void LoadData()
        {
            var categories = BusinessLayer.DataAcquisition.GetAccesssoriesTypes();
            foreach (var cat in categories)
            {
                var tab = new TabPage
                {
                    Text = cat.TYPE
                };

                var clbox = new CheckedListBox();
                clbox.Dock = DockStyle.Fill;

                var collection = cat.Accessories;

                if (collection.Count > 0)
                {
                    foreach (var acc in collection)
                    {
                        clbox.Items.Add(acc.ACCESSORY_ID + " " + acc.NAME + " " + acc.PRICE, false);
                    }
                }
                

                tab.Controls.Add(clbox);
                this.tabControl1.TabPages.Add(tab);
            }


        }

        private void InstallButton_Click(object sender, EventArgs e)
        {
            int installed = 0;
            bool success = true;
            foreach (TabPage tab in this.tabControl1.TabPages)
            {
                var selected = (tab.Controls[0] as CheckedListBox).CheckedItems;
                
                foreach(var item in selected)
                {
                    int accID = int.Parse(item.ToString().Substring(0, item.ToString().IndexOf(' ')));
                    if (BusinessLayer.DataAcquisition.CanInstallAcc(m_orderID, accID))
                    {
                        BusinessLayer.DataAddition.AccessoryInstall(m_orderID, accID);
                        ++installed;
                    }
                    else
                    {
                        success = false;
                    }

                }
            }
            if (installed != 0) BusinessLayer.DataUpdate.ChangeOrderStauts(m_orderID, "Waiting");
            if (!success)
            {
                MessageBox.Show("Some of the selected accessories are already installed or are waiting to be installed", "Duplicates", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            this.DialogResult = DialogResult.Yes;

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            foreach (TabPage tab in this.tabControl1.TabPages)
            {
                var list = (tab.Controls[0] as CheckedListBox);
                for (int i = 0; i < list.Items.Count; i++)

                {

                    list.SetItemChecked(i, false);

                }
            }
        }
    }
}
