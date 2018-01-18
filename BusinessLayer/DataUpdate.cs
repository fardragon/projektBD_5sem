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

        public static void UpdateOrderNotes(int orderID, String Notes)
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

    }
}
