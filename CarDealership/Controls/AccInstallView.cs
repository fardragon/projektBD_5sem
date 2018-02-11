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
    public partial class AccInstallView : UserControl
    {
        private int DealershipID;
        public AccInstallView()
        {
            InitializeComponent();
            this.treeView1.HideSelection = false;
        }

        public void SetDealership(int Dealership)
        {
            this.DealershipID = Dealership;
        }

        public void View()
        {
            this.treeView1.Nodes.Clear();
            var cars = BusinessLayer.DataAcquisition.CarsWithAccInstallOrders(DealershipID);
            foreach (var car in cars)
            {
                var installs = car.Active_Orders.Single().Accessories_Install_Orders;
                var CarNode = new TreeNode
                {
                    Text = car.CAR_VIN + " " + car.PRODUCTION_YEAR + " " + car.Model.NAME + ": " + installs.Count + " order(s)"
                };
                foreach (var inst in installs)
                {
                    var acc = new TreeNode
                    {
                        Text = inst.ACCESSORY_ID + ": " + inst.Accessory.NAME
                    };
                    CarNode.Nodes.Add(acc);
                }
                this.treeView1.Nodes.Add(CarNode);
            }
        }

        public int? GetLevel()
        {
            var node = this.treeView1.SelectedNode;
            if (node == null) return null;
            return node.Level;
        }

        public string GetCarVin()
        {
            var car = this.treeView1.SelectedNode.Parent;
            return car.Text.Substring(0, 17);
        }

        public int GetAccID()
        {
            var acc = this.treeView1.SelectedNode;
            return Int32.Parse(acc.Text.Substring(0, acc.Text.IndexOf(':')));
        }


    }
}
