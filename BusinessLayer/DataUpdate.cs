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
        public static void EmployeeUpdate(int id, string name, string surname, int role, int? dealership, string login, string password)
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
                res.NAME = name;
                res.SURNAME = surname;
                res.ROLE_ID = role; 
                res.DEALERSHIP_ID = dealership;
                res.LOGIN = login;
                if (password.Length > 0) res.PASSWORD = BusinessLayer.Utility.CalculateMD5Hash(password);
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
