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
            DataDeletion.DeleteActiveDiscounts(id);
            DataDeletion.ClearAccessoriesInstallOrders(id);
            try
            {
                
                var database = DataLayer.Utility.GetContext();
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
        public static void DeleteMountedAccessories(String VIN)
        {
            try
            {
                var database = DataLayer.Utility.GetContext();
                var accessories = from acc in database.Mounted_Accessories
                          where
                          acc.CAR_VIN == VIN
                          select acc;
                foreach (var acc in accessories)
                {
                    database.Mounted_Accessories.DeleteOnSubmit(acc);
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
        public static void DeleteMountedAccessories(int orderID)
        {
            try
            {
                var database = DataLayer.Utility.GetContext();
                var order = (from ord in database.Active_Orders
                            where
                            ord.ORDER_ID == orderID
                            select ord).Single(); 
                foreach (var acc in order.Cars_for_Sale.Mounted_Accessories)
                {
                    database.Mounted_Accessories.DeleteOnSubmit(acc);
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
        public static void RemoveCar(String VIN)
        {
            DataDeletion.DeleteMountedAccessories(VIN);
            try
            {
                var database = DataLayer.Utility.GetContext();
                var del = (from car in database.Cars_for_Sales
                                  where
                                  car.CAR_VIN == VIN
                                  select car).Single();

                database.Cars_for_Sales.DeleteOnSubmit(del);
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
        public static void DeleteActiveDiscounts(int orderID)
        {
            try
            {
                var database = DataLayer.Utility.GetContext();
                var discounts = from disc in database.Active_Discounts
                                where
                                disc.ORDER_ID == orderID
                                select disc;
                foreach (var disc in discounts)
                {
                    database.Active_Discounts.DeleteOnSubmit(disc);
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
        public static void DeleteAccOrdOnComplete(string VIN, int accID)
        {
            try
            {
                var database = DataLayer.Utility.GetContext();
                var order = (from ord in database.Active_Orders
                            where
                            ord.CAR_VIN == VIN
                            select ord).Single();
                foreach (var install in order.Accessories_Install_Orders)
                {
                    if (install.ACCESSORY_ID == accID)
                    {
                        database.Accessories_Install_Orders.DeleteOnSubmit(install);
                        break;
                    }
                }
                database.SubmitChanges();
                if (order.Accessories_Install_Orders.Count == 0)
                {
                    DataUpdate.ChangeOrderStauts(order.ORDER_ID, "Open");
                }
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
        public static void DeleteAccessory(int AccID)
        {
            try
            {
                var database = DataLayer.Utility.GetContext();
                var accessory = (from acc in database.Accessories
                                 where
                                 acc.ACCESSORY_ID == AccID
                                 select acc).Single();
                database.Accessories.DeleteOnSubmit(accessory);
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
        public static void DeleteDiscount(int DiscID)
        {
            try
            {
                var database = DataLayer.Utility.GetContext();
                var discount = (from disc in database.Discounts
                                where
                                disc.DISCOUNT_ID == DiscID
                                select disc).Single();

                database.Discounts.DeleteOnSubmit(discount);
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
        public static void DeleteModel(int ModelID)
        {
            try
            {
                var database = DataLayer.Utility.GetContext();
                var model = (from mod in database.Models
                             where
                             mod.MODEL_ID == ModelID
                             select mod).Single();
                database.Models.DeleteOnSubmit(model);
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
        public static void DeleteColor(int ColorID)
        {
            try
            {
                var database = DataLayer.Utility.GetContext();
                var color = (from col in database.Colors
                             where
                             col.COLOR_ID == ColorID
                             select col).Single();
                database.Colors.DeleteOnSubmit(color);
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
