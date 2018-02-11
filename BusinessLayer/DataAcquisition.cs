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

        public static List<DataLayer.Employee> GetEmployees(Employee criteria)
        {
            try
            {
                var database = DataLayer.Utility.GetContext();
                if (criteria == null)
                {
                    var res = database.Employees.ToList();
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
                    return res.ToList();
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
            return new List<DataLayer.Employee>();
        }
        public static List<DataLayer.Employee> GetEmployees(string name, string surname, string dealership, string role)
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
        public static List<DataLayer.Dealership> GetDealerships(Dealership criteria)
        {
            try
            {
                var database = DataLayer.Utility.GetContext();
                if (criteria == null)
                {
                    return database.Dealerships.ToList();
                }
                else
                {
                    var res = from deal in database.Dealerships
                              where

                              ((criteria.DEALERSHIP_ID == 0) || (deal.DEALERSHIP_ID == criteria.DEALERSHIP_ID))


                              select deal;
                    return res.ToList();
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
            return new List<DataLayer.Dealership>();
        }
        public static List<DataLayer.Role> GetRoles(Role criteria)
        {
            try
            {
                var database = DataLayer.Utility.GetContext();
                if (criteria == null)
                {
                   return database.Roles.ToList();
                }
                else
                {
                    var res = from rol in database.Roles
                              where

                              ((criteria.ROLE_ID == 0) || (rol.ROLE_ID == criteria.ROLE_ID))
                              &&
                              (String.IsNullOrEmpty(criteria.ROLE_NAME) || rol.ROLE_NAME == criteria.ROLE_NAME)

                              select rol;
                    return res.ToList();
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
            return new List<DataLayer.Role>();
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
        public static List<DataLayer.Employee> GetManagers(int dealershipid)
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

                return res.ToList();
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                MessageBox.Show(ex.Message + " " + ex.Number, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return new List<DataLayer.Employee>();
        }
        public static DataLayer.Dealership GetDealership(int id)
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
        public static List<DataLayer.Model> GetModels()
        {
            try
            {
                var database = DataLayer.Utility.GetContext();
                var res = database.Models.AsQueryable();
                return res.ToList();
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                MessageBox.Show(ex.Message + " " + ex.Number, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return new List<DataLayer.Model>();
        }
        public static List<DataLayer.Color> GetColors()
        {
            try
            {
                var database = DataLayer.Utility.GetContext();
                var res = database.Colors.AsQueryable();
                return res.ToList();
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                MessageBox.Show(ex.Message + " " + ex.Number, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return new List<DataLayer.Color>();
        }
        public static List<DataLayer.Cars_for_Sale> GetCars(int? DealershipID, bool ShowOrderedCars)
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
                return res.ToList();
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                MessageBox.Show(ex.Message + " " + ex.Number, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return new List<DataLayer.Cars_for_Sale>();
        }
        public static DataLayer.Cars_for_Sale GetCar(String VIN)
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
        public static List<DataLayer.Customer> GetCustomers(string Id, string Name, string City)
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
        public static List<DataLayer.Customer> GetCustomers(Customer criteria)
        {
            try
            {
                var database = DataLayer.Utility.GetContext();
                if (criteria == null)
                {
                    return database.Customers.ToList();
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
                    return res.ToList();
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
            return new List<DataLayer.Customer>();
        }
        public static List<DataLayer.Active_Order> GetOrders(int? DealershipID, int? EmployeeID, int? OrderStatus)
        {
            try
            {
                var database = DataLayer.Utility.GetContext();
                var criteria = new Active_Order
                {
                    Cars_for_Sale = new Cars_for_Sale
                    {
                        DEALERSHIP_ID = (DealershipID.HasValue) ? DealershipID.Value : 0
                    },
                    EMPLOYEE_ID = (EmployeeID.HasValue)? EmployeeID.Value:0,
                    ORDER_STATUS_ID = (OrderStatus.HasValue)?OrderStatus.Value:0
                };

                var res = from ord in database.Active_Orders
                          where
                              ((criteria.Cars_for_Sale.DEALERSHIP_ID == 0) || (ord.Cars_for_Sale.DEALERSHIP_ID == criteria.Cars_for_Sale.DEALERSHIP_ID))
                              &&
                              ((criteria.EMPLOYEE_ID == 0) || (ord.EMPLOYEE_ID == criteria.EMPLOYEE_ID))
                              &&
                              ((criteria.ORDER_STATUS_ID == 0) || (ord.ORDER_STATUS_ID ==criteria.ORDER_STATUS_ID))
                          select ord;
                return res.ToList();

            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                MessageBox.Show(ex.Message + " " + ex.Number, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return new List<DataLayer.Active_Order>();
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
        public static List<DataLayer.Accessories_Type> GetAccesssoriesTypes()
        {
            try
            {
                var database = DataLayer.Utility.GetContext();
                return database.Accessories_Types.ToList();
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                MessageBox.Show(ex.Message + " " + ex.Number, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return new List<DataLayer.Accessories_Type>();
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
        public static Decimal CalculatePrice(int orderID)
        {
            try
            {
                var database = DataLayer.Utility.GetContext();
                var order = (from ord in database.Active_Orders
                             where ord.ORDER_ID == orderID
                             select ord).Single();
                Decimal price = order.Cars_for_Sale.Model.BASE_PRICE;
                var accessories = order.Cars_for_Sale.Mounted_Accessories;
                foreach (var acc in accessories)
                {
                    price += acc.Accessory.PRICE;
                }
                var discounts = order.Active_Discounts;
                foreach (var disc in discounts)
                {
                    price -= disc.Discount.VALUE;
                }
                return price;
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
        public static List<DataLayer.Discount> GetDiscounts()
        {
            try
            {
                var database = DataLayer.Utility.GetContext();
                return database.Discounts.ToList();
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                MessageBox.Show(ex.Message + " " + ex.Number, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return new List<DataLayer.Discount>();
        }
        public static List<int> GetMountedAccessoriesIDsFromOrderID(int orderID)
        {
            try
            {
                var database = DataLayer.Utility.GetContext();
                var order = (from ord in database.Active_Orders
                             where
                             ord.ORDER_ID == orderID
                             select ord).Single();
                var result = new List<int>();
                foreach (var item in order.Cars_for_Sale.Mounted_Accessories)
                {
                    result.Add(item.ACCESSORY_ID);
                }
                return result;
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                MessageBox.Show(ex.Message + " " + ex.Number, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return new List<int>();
        }
        public static List<int> GetOrderedAccessoriesIdsFromOrderID(int orderID)
        {
            try
            {
                var database = DataLayer.Utility.GetContext();
                var order = (from ord in database.Active_Orders
                             where
                             ord.ORDER_ID == orderID
                             select ord).Single();
                var result = new List<int>();
                foreach (var item in order.Accessories_Install_Orders)
                {
                    result.Add(item.ACCESSORY_ID);
                }
                return result;
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                MessageBox.Show(ex.Message + " " + ex.Number, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return new List<int>();
        }
        public static DataLayer.Customer LoadCustomer(int customerID)
        {
            try
            {
                var database = DataLayer.Utility.GetContext();
                var customer = (from cust in database.Customers
                                where
                                cust.CUSTOMER_ID == customerID
                                select cust).Single();
                return customer;
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                MessageBox.Show(ex.Message + " " + ex.Number, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return new DataLayer.Customer();
        }
        public static List<DataLayer.Accessory> GetAccessories(int Type)
        {
            try
            {
                var database = DataLayer.Utility.GetContext();
                var accessories = from acc in database.Accessories
                                  where
                                  acc.TYPE_ID == Type
                                  select acc;
                return accessories.ToList();
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                MessageBox.Show(ex.Message + " " + ex.Number, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return new List<DataLayer.Accessory>();
        }
        public static List<DataLayer.Sold_Car> GetArchive(int? DealershipID, int? ModelID, int? EmployeeID)
        {
            try
            {
                var database = DataLayer.Utility.GetContext();
                var criteria = new Sold_Car
                {
                    DEALERSHIP_ID = (DealershipID == null) ? 0 : DealershipID.Value,
                    MODEL_ID = (ModelID == null) ? 0 : ModelID.Value,
                    EMPLOYEE_ID = (EmployeeID == null) ? 0 : EmployeeID.Value
                };


                var sales = from sal in database.Sold_Cars
                            where
                            ((criteria.DEALERSHIP_ID == 0) || (sal.DEALERSHIP_ID == criteria.DEALERSHIP_ID))
                            &&
                            ((criteria.MODEL_ID == 0) || (sal.MODEL_ID == criteria.MODEL_ID))
                            &&
                            ((criteria.EMPLOYEE_ID == 0) || (sal.EMPLOYEE_ID == criteria.EMPLOYEE_ID))
                            select sal;

                return sales.ToList();
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                MessageBox.Show(ex.Message + " " + ex.Number, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            return new List<DataLayer.Sold_Car>();
        }
        public static List<int> GetActiveDiscounts(int orderID)
        {
            try
            {
                var database = DataLayer.Utility.GetContext();
                var discounts = from disc in database.Active_Discounts
                                where
                                disc.ORDER_ID == orderID
                                select disc;
                var result = new List<int>();
                foreach (var disc in discounts)
                {
                    result.Add(disc.DISCOUNT_ID);
                }
                return result;
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                MessageBox.Show(ex.Message + " " + ex.Number, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return new List<int>();
        }
        public static Sold_Car GetSale(int saleID)
        {
            try
            {
                var database = DataLayer.Utility.GetContext();
                var sale = (from sal in database.Sold_Cars
                            where
                            sal.SALE_ID == saleID
                            select sal).Single();

                return sale;
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                MessageBox.Show(ex.Message + " " + ex.Number, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return new Sold_Car();
        }

        public static List<Cars_for_Sale> CarsWithAccInstallOrders(int? DealershipID)
        {
            try
            {
                var database = DataLayer.Utility.GetContext();
                var criteria = new Cars_for_Sale
                {
                    DEALERSHIP_ID = (DealershipID == null) ? 0 : DealershipID.Value
                };


                var cars = from car in database.Cars_for_Sales
                            where
                            ((criteria.DEALERSHIP_ID == 0) || (car.DEALERSHIP_ID == criteria.DEALERSHIP_ID))
                            &&
                            (car.Active_Orders.Single().Accessories_Install_Orders.Count > 0)
                            select car;

                return cars.ToList();
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                MessageBox.Show(ex.Message + " " + ex.Number, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            return new List<DataLayer.Cars_for_Sale>();
        }

        public static bool CanDeleteAccessory(int accID)
        {
            try
            {
                var database = DataLayer.Utility.GetContext();
                var accessory= (from acc in database.Accessories
                                where
                                acc.ACCESSORY_ID == accID
                                select acc).Single();

                if (accessory.Mounted_Accessories.Count > 0) return false;
                if (accessory.Sold_Accessories.Count > 0) return false;
                if (accessory.Accessories_Install_Orders.Count > 0) return false;
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
        public static bool CanDeleteDiscount(int DiscID)
        {
            try
            {
                var database = DataLayer.Utility.GetContext();
                var discount = (from disc in database.Discounts
                                where
                                disc.DISCOUNT_ID == DiscID
                                select disc).Single();

                if (discount.Active_Discounts.Count > 0) return false;
                if (discount.Sold_Discounts.Count > 0) return false;
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
        public static bool CanDeleteModel(int ModelID)
        {
            try
            {
                var database = DataLayer.Utility.GetContext();
                var model = (from mod in database.Models
                            where
                            mod.MODEL_ID == ModelID
                            select mod).Single();

                if (model.Cars_for_Sales.Count > 0) return false;
                if (model.Sold_Cars.Count > 0) return false;
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
        public static bool CanDeleteColor(int ColorID)
        {
            try
            {
                var database = DataLayer.Utility.GetContext();
                var color = (from col in database.Colors
                             where
                             col.COLOR_ID == ColorID
                             select col).Single();

                if (color.Cars_for_Sales.Count > 0) return false;
                if (color.Sold_Cars.Count > 0) return false;
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
