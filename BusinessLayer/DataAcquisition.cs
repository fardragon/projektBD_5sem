using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer;
using System.Collections;

namespace BusinessLayer
{
    public static class DataAcquisition
    {
        public static void DEBUG_RESET()
        {
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor;          
            try
            {
                var database = DataLayer.Utility.GetContext();
                database.ExecuteCommand("EXEC dbo.reset;");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default;
        }

        public static IQueryable<Employee> GetEmployees(Employee criteria)
        {
            try
            {
                var database = DataLayer.Utility.GetContext();
                if (criteria == null)
                {
                    var res = database.Employees.AsQueryable();
                    return res;
                }
                else
                {
                    var res = from emp in database.Employees
                              where
                              ((criteria.EMPLOYEE_ID == 0) || (emp.EMPLOYEE_ID == criteria.EMPLOYEE_ID))
                              &&
                              (String.IsNullOrEmpty(criteria.NAME) || emp.NAME.StartsWith(criteria.NAME))
                              &&
                              (String.IsNullOrEmpty(criteria.SURNAME) || emp.SURNAME.StartsWith(criteria.SURNAME))
                              &&
                              ((criteria.ROLE_ID == 0) || (emp.ROLE_ID == criteria.ROLE_ID))
                              &&
                              ((criteria.DEALERSHIP_ID == null) || (emp.DEALERSHIP_ID == criteria.DEALERSHIP_ID))
                              select emp;
                    return res;
                }

                
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return Enumerable.Empty<Employee>().AsQueryable();
        }

        public static IQueryable<Employee> GetEmployees(string name, string surname, string dealership, string role)
        {
            var criteria = new Employee();
            if (!String.IsNullOrEmpty(name)) criteria.NAME = name;
            if (!String.IsNullOrEmpty(surname)) criteria.SURNAME = surname;
            if (!String.IsNullOrEmpty(role)) criteria.ROLE_ID = BusinessLayer.DataAcquisition.GetRoleID(role);
            if (String.IsNullOrEmpty(dealership))
            {
                criteria.DEALERSHIP_ID = null;
            }
            else
            {
                criteria.DEALERSHIP_ID = System.Int32.Parse(dealership);
            }
            return BusinessLayer.DataAcquisition.GetEmployees(criteria);
        }

        public static IQueryable<Dealership> GetDealerships(Dealership criteria)
        {
            try
            {
                var database = DataLayer.Utility.GetContext();
                if (criteria == null)
                {
                    var res = database.Dealerships.AsQueryable();
                    return res;
                }
                else
                {
                    var res = from deal in database.Dealerships
                              where

                              ((criteria.DEALERSHIP_ID == 0) || (deal.DEALERSHIP_ID == criteria.DEALERSHIP_ID))


                              select deal;
                    return res;
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return Enumerable.Empty<Dealership>().AsQueryable();
        }

        public static IQueryable<Role> GetRoles(Role criteria)
        {
            try
            {
                var database = DataLayer.Utility.GetContext();
                if (criteria == null)
                {
                    var res = database.Roles.AsQueryable();
                    return res;
                }
                else
                {
                    var res = from rol in database.Roles
                              where

                              ((criteria.ROLE_ID == 0) || (rol.ROLE_ID == criteria.ROLE_ID))
                              &&
                              (String.IsNullOrEmpty(criteria.ROLE_NAME) || rol.ROLE_NAME == criteria.ROLE_NAME)

                              select rol;
                    return res;
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return Enumerable.Empty<Role>().AsQueryable();
        }

        public static int GetRoleID(string ROLE_NAME)
        {
            try
            {
                var database = DataLayer.Utility.GetContext();
                var res = (
                          from rol in database.Roles
                          where
                          rol.ROLE_NAME == ROLE_NAME
                          select rol
                          ).Single();

                return res.ROLE_ID;
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                MessageBox.Show(ex.Message + " " + ex.Number, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return 0;
        }

        public static IQueryable<Employee> GetManagers(int dealershipid)
        {
            try
            {
                var database = DataLayer.Utility.GetContext();
                var res = 
                          from man in database.Employees
                          where
                          (man.DEALERSHIP_ID == dealershipid)
                          &&
                          (man.Role.ROLE_NAME == "Manager")
                          select man;

                return res;
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                MessageBox.Show(ex.Message + " " + ex.Number, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return Enumerable.Empty<Employee>().AsQueryable();
        }
        public static Dealership GetDealership(int id)
        {
            try
            {
                var database = DataLayer.Utility.GetContext();
                var res = (from deal in database.Dealerships
                           where
                           (deal.DEALERSHIP_ID == id)
                           select deal).Single();
                           return res;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return new Dealership();
        }

        public static int GetEmployeeOrdersCount(int id)
        {
            try
            {
                var database = DataLayer.Utility.GetContext();
                var res =  (from order in database.Active_Orders
                           where
                           (order.EMPLOYEE_ID == id)
                           select order).Count();
                return res;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return 0;
        }
        public static int GetEmployeeSalesCount(int id)
        {
            try
            {
                var database = DataLayer.Utility.GetContext();
                var res = (from sale in database.Sold_Cars
                           where
                           (sale.EMPLOYEE_ID == id)
                           select sale).Count();
                return res;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return 0;
        }
        public static bool CheckPassword(int id, string password)
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

                return res.PASSWORD == BusinessLayer.Utility.CalculateMD5Hash(password);
                
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                MessageBox.Show(ex.Message + " " + ex.Number, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;

        }

        public static IQueryable<Model> GetModels()
        {
            try
            {
                var database = DataLayer.Utility.GetContext();
                var res = database.Models.AsQueryable();
                return res;
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                MessageBox.Show(ex.Message + " " + ex.Number, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return Enumerable.Empty<Model>().AsQueryable();
        }

        public static IQueryable<Color> GetColors()
        {
            try
            {
                var database = DataLayer.Utility.GetContext();
                var res = database.Colors.AsQueryable();
                return res;
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                MessageBox.Show(ex.Message + " " + ex.Number, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return Enumerable.Empty<Color>().AsQueryable();
        }

        public static IQueryable<Cars_for_Sale> GetCars(int? DealershipID, bool ShowOrderedCars)
        {
            try
            {
                var database = DataLayer.Utility.GetContext();
                IQueryable<Cars_for_Sale> res;
                if (DealershipID.HasValue)
                {
                    res = from car in database.Cars_for_Sales
                          where (car.DEALERSHIP_ID == DealershipID)
                            &&
                            ((car.Active_Orders.Count == 0) || ( ShowOrderedCars))
                          select car;
                }
                else
                {
                    res = from car in database.Cars_for_Sales
                          where (car.Active_Orders.Count == 0) || (ShowOrderedCars)
                          select car;
                }
                return res;
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                MessageBox.Show(ex.Message + " " + ex.Number, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return Enumerable.Empty<Cars_for_Sale>().AsQueryable();
        }

        public static Cars_for_Sale GetCar(String VIN)
        {
            try
            {
                var database = DataLayer.Utility.GetContext();
                Cars_for_Sale res = (from car in database.Cars_for_Sales
                                     where car.CAR_VIN == VIN
                                     select car).Single();
                return res;
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                MessageBox.Show(ex.Message + " " + ex.Number, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }



        public static IQueryable<Customer> GetCustomers(string Id, string Name, string City)
        {
            var criteria = new Customer();
            if (!String.IsNullOrEmpty(Id))
            {
                criteria.CUSTOMER_ID = Int32.Parse(Id);
            }
            if (!String.IsNullOrEmpty(Name))
            {
                criteria.NAME = Name;
            }
            if (!String.IsNullOrEmpty(City))
            {
                criteria.CITY = City;
            }
            return BusinessLayer.DataAcquisition.GetCustomers(criteria);
        }

        public static IQueryable<Customer> GetCustomers(Customer criteria)
        {
            try
            {
                var database = DataLayer.Utility.GetContext();
                if (criteria == null)
                {
                    var res = database.Customers.AsQueryable();
                    return res;
                }
                else
                {
                    var res = from cus in database.Customers
                              where
                              ((criteria.CUSTOMER_ID == 0) || (cus.CUSTOMER_ID == criteria.CUSTOMER_ID))
                              &&
                              (String.IsNullOrEmpty(criteria.NAME) || cus.NAME.Contains(criteria.NAME))
                              &&
                              (String.IsNullOrEmpty(criteria.CITY) || cus.CITY.StartsWith(criteria.CITY))
                              select cus;
                    return res;
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
            return Enumerable.Empty<Customer>().AsQueryable();
        }

        public static IQueryable<Active_Order> GetOrders(int? DealershipID, int? EmployeeID, int? OrderStatus)
        {
            try
            {
                var database = DataLayer.Utility.GetContext();
                var criteria = new Active_Order();
                criteria.Cars_for_Sale = new Cars_for_Sale();
                if (DealershipID.HasValue)
                {
                    criteria.Cars_for_Sale.DEALERSHIP_ID = DealershipID.Value;
                }
                else
                {
                    criteria.Cars_for_Sale.DEALERSHIP_ID = 0;
                }
                if (EmployeeID.HasValue)
                {
                    criteria.EMPLOYEE_ID = EmployeeID.Value;
                }
                else
                {
                    criteria.EMPLOYEE_ID = 0;
                }
                if (OrderStatus.HasValue)
                {
                    criteria.ORDER_STATUS_ID = OrderStatus.Value;
                }
                else
                {
                    criteria.ORDER_STATUS_ID = 0;
                }


                var res = from ord in database.Active_Orders
                          where
                              ((criteria.Cars_for_Sale.DEALERSHIP_ID == 0) || (ord.Cars_for_Sale.DEALERSHIP_ID == criteria.Cars_for_Sale.DEALERSHIP_ID))
                              &&
                              ((criteria.EMPLOYEE_ID == 0) || (ord.EMPLOYEE_ID == criteria.EMPLOYEE_ID))
                              &&
                              ((criteria.ORDER_STATUS_ID == 0) || (ord.ORDER_STATUS_ID ==criteria.ORDER_STATUS_ID))
                          select ord;
                return res;

            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                MessageBox.Show(ex.Message + " " + ex.Number, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return Enumerable.Empty<Active_Order>().AsQueryable();
        }

        public static DataLayer.Active_Order GetOrderFromID (int orderID)
        {
            try
            {
                var database = DataLayer.Utility.GetContext();
                var res = (from ord in database.Active_Orders
                          where ord.ORDER_ID == orderID
                          select ord).SingleOrDefault();

                return res;
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                MessageBox.Show(ex.Message + " " + ex.Number, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return new DataLayer.Active_Order();
        }

        public static IQueryable<Accessories_Type> GetAccesssoriesTypes()
        {
            try
            {
                var database = DataLayer.Utility.GetContext();
                return database.Accessories_Types.AsQueryable();
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                MessageBox.Show(ex.Message + " " + ex.Number, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return Enumerable.Empty<Accessories_Type>().AsQueryable();
        }

        public static String GetOrderNotes(int orderID)
        {
            try
            {
                var database = DataLayer.Utility.GetContext();
                var res = (from ord in database.Active_Orders
                           where ord.ORDER_ID == orderID
                           select ord).SingleOrDefault();
                return res.NOTES;
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                MessageBox.Show(ex.Message + " " + ex.Number, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return String.Empty;
        }

        public static bool CanInstallAcc(int orderID, int accID)
        {
            {
                try
                {
                    var order = DataAcquisition.GetOrderFromID(orderID);
                    
                    foreach (var install in order.Accessories_Install_Orders)
                    {
                        if (install.ACCESSORY_ID == accID) return false;
                    }

                    foreach (var acc in order.Cars_for_Sale.Mounted_Accessories)
                    {
                        if (acc.ACCESSORY_ID == accID) return false;
                    }
                    return true;
                }
                catch (System.Data.SqlClient.SqlException ex)
                {
                    MessageBox.Show(ex.Message + " " + ex.Number, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return false;
            }
        }

    }


    
}
