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
        public static void AddEmployee (string name, string surname, int role, int? dealership, string login, string password)
        {
            try
            {
                var database = DataLayer.Utility.GetContext();
                var emp = new Employee
                {
                    NAME = name,
                    SURNAME = surname,
                    ROLE_ID = role,
                    DEALERSHIP_ID = dealership,
                    LOGIN = login,
                    PASSWORD = BusinessLayer.Utility.CalculateMD5Hash(password)
                };
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
    }
}
