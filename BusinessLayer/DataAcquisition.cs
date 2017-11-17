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


    }
}
