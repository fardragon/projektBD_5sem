using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using DataLayer;

namespace CarDealership.Controls
{
    public partial class RoleSelector : ComboBox
    {
        public RoleSelector()
        {
            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
           var roles = BusinessLayer.DataAcquisition.GetRoles(null);
           this.BindingContext = new BindingContext();
           this.DataSource = roles;
           this.DisplayMember = "ROLE_NAME";
           this.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public void ChangeSelected(string selection)
        {
            this.SelectedIndex = this.FindStringExact(selection);
        }
    }
}
