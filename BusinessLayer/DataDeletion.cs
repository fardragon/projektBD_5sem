using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using System.Windows.Forms;

namespace BusinessLayer
{
    public static class DataDeletion
    {
        public static void DeleteEmployee(int id)
        {
            try
            {
                var database = DataLayer.Utility.GetContext();
                var res = (
                          from emp in database.Employees
                          where
                          emp.EMPLOYEE_ID == id
                          select emp
                          ).Single();

                database.Employees.DeleteOnSubmit(res);
                database.SubmitChanges();
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                MessageBox.Show(ex.Message + " " + ex.Number, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public static void DeleteOrder(int id)
        {
            try
            {
                ClearAccessoriesInstallOrders(id);
                var database = DataLayer.Utility.GetContext();
                var acc = from inst in database.Accessories_Install_Orders
                          where
                          inst.ORDER_ID == id
                          select inst;
                foreach (var inst in acc)
                {
                    database.Accessories_Install_Orders.DeleteOnSubmit(inst);
                }
                var discounts = from disc in database.Active_Discounts
                                where
                                disc.ORDER_ID == id
                                select disc;
                foreach(var disc in discounts)
                {
                    database.Active_Discounts.DeleteOnSubmit(disc);
                }
                var ord = (from orders in database.Active_Orders
                           where orders.ORDER_ID == id
                           select orders).Single();
                database.Active_Orders.DeleteOnSubmit(ord);
                database.SubmitChanges();
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                MessageBox.Show(ex.Message + " " + ex.Number, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void ClearAccessoriesInstallOrders(int orderID)
        {
            try
            {
                var database = DataLayer.Utility.GetContext();
                var acc = from inst in database.Accessories_Install_Orders
                          where
                          inst.ORDER_ID == orderID
                          select inst;
                foreach (var inst in acc)
                {
                    database.Accessories_Install_Orders.DeleteOnSubmit(inst);
                }
                database.SubmitChanges();
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                MessageBox.Show(ex.Message + " " + ex.Number, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
