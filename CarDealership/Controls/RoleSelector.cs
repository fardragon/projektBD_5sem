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

        public void Initialize()
        {
            this.Items.Clear();
            var roles = BusinessLayer.DataAcquisition.GetRoles(null);
            foreach (Role rol in roles)
            {
                this.Items.Add(rol.ROLE_NAME);
            }
            this.DropDownStyle = ComboBoxStyle.DropDownList;
            if (this.Items.Count > 0) this.SelectedIndex = 0;
        }

        public void ChangeSelected(string selection)
        {
            this.SelectedIndex = this.FindStringExact(selection);
        }

        public void AllowNull()
        {
            this.Items.Insert(0, "");
            this.SelectedIndex = 0;
        }
    }
}
