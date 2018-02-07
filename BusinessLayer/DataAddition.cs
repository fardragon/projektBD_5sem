using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer;

namespace BusinessLayer
{
    public static class DataAddition
    {
        public static void AddEmployee (string name, string surname, string role, string dealership, string login, string password)
        {
            try
            {
                var database = DataLayer.Utility.GetContext();

                int? deal;
                if (String.IsNullOrEmpty(dealership))
                {
                    deal = null;
                }
                else
                {
                    deal = System.Int32.Parse(dealership);
                }

                var emp = new Employee
                {
                    NAME = name,
                    SURNAME = surname,
                    ROLE_ID = BusinessLayer.DataAcquisition.GetRoleID(role),
                    DEALERSHIP_ID = deal,
                    LOGIN = login,
                    PASSWORD = BusinessLayer.Utility.CalculateMD5Hash(password)
                };
                if (emp.ROLE_ID == 0) throw new System.ArgumentException("Role ID not found!");
                database.Employees.InsertOnSubmit(emp);
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
        public static void AddDealership(string address, string city, string zipcode)
        {
            try
            {
                var database = DataLayer.Utility.GetContext();

                var deal = new Dealership()
                {
                    STREET_ADDRESS = address,
                    CITY = city,
                    ZIPCODE = zipcode              
                };

                database.Dealerships.InsertOnSubmit(deal);
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

        public static void AddModel(string name, string price)
        {
            try
            {
                var database = DataLayer.Utility.GetContext();
                price.Replace('.', ',');
                var model = new Model()
                {
                    NAME = name,
                    BASE_PRICE = Decimal.Parse(price)
                };

                database.Models.InsertOnSubmit(model);
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

        public static void AddColor(String name)
        {
            try
            {
                var database = DataLayer.Utility.GetContext();
                var color = new DataLayer.Color()
                {
                    NAME = name
                };

                database.Colors.InsertOnSubmit(color);
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

        public static void OpenOrder(String CarVIN, int CustomerID, int SellerID)
        {
            try
            {
                var database = DataLayer.Utility.GetContext();
                var Order = new DataLayer.Active_Order
                {
                    CAR_VIN = CarVIN,
                    CUSTOMER_ID = CustomerID,
                    EMPLOYEE_ID = SellerID,
                    OPENED_DATE = DateTime.Now.Date,
                    LAST_UPDATE = DateTime.Now,
                    ORDER_STATUS_ID = 1
                };
                database.Active_Orders.InsertOnSubmit(Order);
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

        public static void AccessoryInstall(int orderID, int accID)
        {
            try
            {
                var database = DataLayer.Utility.GetContext();
                var install = new DataLayer.Accessories_Install_Order
                {
                    ORDER_ID = orderID,
                    ACCESSORY_ID = accID
                };
                database.Accessories_Install_Orders.InsertOnSubmit(install);
                database.SubmitChanges();
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

        public static void AddCustomer(string name, string address, string city, string zipcode, string phone, string mail)
        {
            try
            {
                var database = DataLayer.Utility.GetContext();

                var customer = new Customer
                {
                    NAME = name,
                    STREET_ADDRESS = address,
                    CITY = city,
                    ZIPCODE = zipcode,
                    PHONE = phone,
                    MAIL = mail
                };
                database.Customers.InsertOnSubmit(customer);
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

        public static void AddCar(string VIN, int model, int color, int dealership, string prodyear)
        {
            try
            {
                var database = DataLayer.Utility.GetContext();

                var car = new Cars_for_Sale
                {
                    CAR_VIN = VIN,
                    MODEL_ID = model,
                    DEALERSHIP_ID = dealership,
                    COLOR_ID = color,
                    PRODUCTION_YEAR = prodyear
                };
                database.Cars_for_Sales.InsertOnSubmit(car);
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

        public static void AddMountedAccessory(string VIN, List<int> AccId)
        {
            foreach(int id in AccId)
            {
                DataAddition.AddMountedAccessory(VIN, id);
            }
        }
        public static void AddMountedAccessory(string VIN, int AccID)
        {
            try
            {
                var database = DataLayer.Utility.GetContext();

                var car = new Mounted_Accessory
                {
                    CAR_VIN = VIN,
                    ACCESSORY_ID = AccID
                };
                database.Mounted_Accessories.InsertOnSubmit(car);
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

        public static void AddAccessoryType(string name)
        {
            try
            {
                var database = DataLayer.Utility.GetContext();

                var type = new Accessories_Type
                {
                    TYPE = name
                };
                database.Accessories_Types.InsertOnSubmit(type);
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
