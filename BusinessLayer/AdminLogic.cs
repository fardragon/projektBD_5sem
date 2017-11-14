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
    public static class AdminLogic
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

        public static IQueryable<Employee> GetEmployees()
        {

            try
            {
                var database = DataLayer.Utility.GetContext();
                var res = database.Employees.AsQueryable();
                return res;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return Enumerable.Empty<Employee>().AsQueryable();
        }
        public static IQueryable<Employee> GetEmployees(Employee criteria)
        {
            try
            {
                var database = DataLayer.Utility.GetContext();
                var res = from emp in database.Employees
                          where 
                          ((criteria.EMPLOYEE_ID == 0) || (emp.EMPLOYEE_ID == criteria.EMPLOYEE_ID))
                          &&
                          (String.IsNullOrEmpty(criteria.NAME) || emp.NAME.StartsWith(criteria.NAME))
                          &&
                          (String.IsNullOrEmpty(criteria.SURNAME) || emp.SURNAME.StartsWith(criteria.SURNAME))
                          select emp;
                return res;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return Enumerable.Empty<Employee>().AsQueryable();
        }


    }
}
