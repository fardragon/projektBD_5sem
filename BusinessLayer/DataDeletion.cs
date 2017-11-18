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


    }
}
