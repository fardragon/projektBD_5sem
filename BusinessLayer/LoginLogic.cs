using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer;

namespace BusinessLayer
{
    public static class LoginLogic
    {
        public static UserTypes Login(string username, string password)
        {
            if ((password.Length == 0) || (username.Length == 0))
            {
                return UserTypes.BadLogin;
            }
            var hashedPassword = BusinessLayer.Utility.CalculateMD5Hash(password);         
            try
            {
                var database = new DataLayer.DealershipDatabaseDataContext();
#if DEBUG
                database.Log = System.Console.Out;
#endif
                var user = (from users in database.Employees where users.LOGIN == username && users.PASSWORD == hashedPassword select users).Single();          
                switch (user.Role.ROLE1.ToString())
                {
                    case "Administrator":
                        return UserTypes.Administrator;
                    case "Manager":
                        return UserTypes.Manager;
                    case "Seller":
                        return UserTypes.Seller;
                    case "Mechanic":
                        return UserTypes.Mechanic;
                    default:
                        return UserTypes.BadLogin;
                }
            }
            catch (System.InvalidOperationException)
            {
                return UserTypes.BadLogin;
            }
#if DEBUG
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
                return UserTypes.Error;
            }
#else
            catch (System.Exception)
            {
                return UserTypes.Error;
            }
#endif

        }

    }
}
