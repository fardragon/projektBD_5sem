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
            try
            {
                var database = DataLayer.Utility.GetContext();
                database.ExecuteCommand("EXEC dbo.reset;");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }           
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

    }


    
}
