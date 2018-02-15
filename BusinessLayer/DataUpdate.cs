using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using System.Windows.Forms;

namespace BusinessLayer
{
    public static class DataUpdate
    {
        public static void EmployeeUpdate(int id, string name, string surname, string role, string dealership, string login, string password)
        {
            try
            {
                var database = DataLayer.Utility.GetContext();
                var emp = (
                          from res in database.Employees
                          where
                          res.EMPLOYEE_ID == id
                          select res
                          ).Single();             
                emp.NAME = name;
                emp.SURNAME = surname;
                emp.ROLE_ID = BusinessLayer.DataAcquisition.GetRoleID(role);
                if (String.IsNullOrEmpty(dealership))
                {
                    emp.DEALERSHIP_ID = null;
                }
                else
                {
                    emp.DEALERSHIP_ID = System.Int32.Parse(dealership);
                }
                emp.LOGIN = login;
                if (emp.ROLE_ID == 0) throw new System.ArgumentException("Role ID not found!");
                if (password.Length > 0) emp.PASSWORD = BusinessLayer.Utility.CalculateMD5Hash(password);
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
        public static void DealershipUpdate(int id, string address, string city, string zipcode, string manager)
        {
            try
            {
                var database = DataLayer.Utility.GetContext();
                var deal = (
                          from res in database.Dealerships
                          where
                          res.DEALERSHIP_ID == id
                          select res
                          ).Single();


                deal.STREET_ADDRESS = address;
                deal.ZIPCODE = zipcode;
                deal.CITY = city;
                if (String.IsNullOrEmpty(manager))
                {
                    deal.MANAGER_ID = null;
                }
                else
                {
                    deal.MANAGER_ID = Int32.Parse(manager);
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
        public static void ChangePassword(int id, string password)
        {
            try
            {
                var database = DataLayer.Utility.GetContext();
                var emp = (
                          from res in database.Employees
                          where
                          res.EMPLOYEE_ID == id
                          select res
                          ).Single();
                emp.PASSWORD = BusinessLayer.Utility.CalculateMD5Hash(password);              
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
        public static void UpdateOrderNotes(int orderID, string Notes)
        {
            try
            {
                var database = DataLayer.Utility.GetContext();
                var ord = (
                          from res in database.Active_Orders
                          where
                          res.ORDER_ID == orderID
                          select res
                          ).Single();
                ord.NOTES = Notes;
                ord.LAST_UPDATE = DateTime.Now;
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
        public static void ChangeOrderStauts(int orderID, String newStatus)
        {
            try
            {
                var database = DataLayer.Utility.GetContext();
                var ord = (
                          from res in database.Active_Orders
                          where
                          res.ORDER_ID == orderID
                          select res
                          ).Single();
                
                switch (newStatus)
                {
                    case "Open":
                        ord.ORDER_STATUS_ID = 1;
                        break;
                    case "Waiting":
                        ord.ORDER_STATUS_ID = 2;
                        break;
                    case "Complete":
                        ord.ORDER_STATUS_ID = 3;
                        break;
                }
                ord.LAST_UPDATE = DateTime.Now;
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
        public static void SetActiveDiscounts(int orderID, List<int> activeDiscounts)
        {
            try
            {
                var database = DataLayer.Utility.GetContext();
                var old = from disc in database.Active_Discounts
                          where disc.ORDER_ID == orderID
                          select disc;
                foreach (var disc in old)
                {
                    database.Active_Discounts.DeleteOnSubmit(disc);
                }
                database.SubmitChanges();
                foreach(var act in activeDiscounts)
                {
                    var active = new Active_Discount
                    {
                        ORDER_ID = orderID,
                        DISCOUNT_ID = act
                    };
                    database.Active_Discounts.InsertOnSubmit(active);
                    database.SubmitChanges();
                }
                DataUpdate.ChangeOrderUpdateTime(orderID);
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
        public static void ModifyCustomer(int CustomerID, string name, string address, string city, string zipcode, string phone, string mail)
        {
            try
            {
                var database = DataLayer.Utility.GetContext();

                var customer = (from cust in database.Customers
                                where cust.CUSTOMER_ID == CustomerID
                                select cust).Single();
                customer.NAME = name;
                customer.STREET_ADDRESS = address;
                customer.CITY = city;
                customer.ZIPCODE = zipcode;
                customer.PHONE = phone;
                customer.MAIL = mail;
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
        public static void ChangeOrderSeller(int OrderID, int SellerID)
        {
            try
            {
                var database = DataLayer.Utility.GetContext();
                var ord = (
                          from res in database.Active_Orders
                          where
                          res.ORDER_ID == OrderID
                          select res
                          ).Single();

                ord.EMPLOYEE_ID = SellerID;
                ord.LAST_UPDATE = DateTime.Now;
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
        public static void ChangeOrderUpdateTime(int OrderID)
        {
            try
            {
                var database = DataLayer.Utility.GetContext();
                var ord = (
                          from res in database.Active_Orders
                          where
                          res.ORDER_ID == OrderID
                          select res
                          ).Single();
                ord.LAST_UPDATE = DateTime.Now;
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
        public static void ArchivizeOrder(int OrderID)
        {
            var accessories = DataAcquisition.GetMountedAccessoriesIDsFromOrderID(OrderID);
            DataDeletion.DeleteMountedAccessories(OrderID);
            var discounts = DataAcquisition.GetActiveDiscounts(OrderID);
            DataDeletion.DeleteActiveDiscounts(OrderID);
            try
            {
                var database = DataLayer.Utility.GetContext();
                var order = (from ord in database.Active_Orders
                             where ord.ORDER_ID == OrderID
                             select ord).Single();

                var sale = new Sold_Car
                {
                    CAR_VIN = order.CAR_VIN,
                    MODEL_ID = order.Cars_for_Sale.MODEL_ID,
                    DEALERSHIP_ID = order.Cars_for_Sale.DEALERSHIP_ID,
                    COLOR_ID = order.Cars_for_Sale.COLOR_ID,
                    PRODUCTION_YEAR = order.Cars_for_Sale.PRODUCTION_YEAR,
                    EMPLOYEE_ID = order.EMPLOYEE_ID,
                    CUSTOMER_ID = order.CUSTOMER_ID,
                    SALE_DATE = order.LAST_UPDATE
                };
                database.Sold_Cars.InsertOnSubmit(sale);
                database.Active_Orders.DeleteOnSubmit(order);
                database.Cars_for_Sales.DeleteOnSubmit(order.Cars_for_Sale);
                database.SubmitChanges();
                DataAddition.AddSoldAccessory(sale.SALE_ID, accessories);
                DataAddition.AddSoldDiscount(sale.SALE_ID, discounts);
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
        public static void CompleteInstallOrder(string VIN, int accID)
        {
            DataAddition.AddMountedAccessory(VIN, accID);
            DataDeletion.DeleteAccOrdOnComplete(VIN, accID);
        }
    }
}
