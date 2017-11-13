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
        public static LoginData Login(string username, string password)
        {
            var result = new LoginData
            {
                Dealership = -1
            };

            if ((password.Length == 0) || (username.Length == 0))
            {
                result.Type = UserTypes.BadLogin;
                return result;
            }
            var hashedPassword = BusinessLayer.Utility.CalculateMD5Hash(password);         
            try
            {
                var database = DataLayer.Utility.GetContext();

                var user = (from users in database.Employees where users.LOGIN == username && users.PASSWORD == hashedPassword select users).Single();     
                if (user.DEALERSHIP_ID.HasValue)
                {
                    result.Dealership = user.DEALERSHIP_ID.Value;
                }

                switch (user.Role.ROLE1.ToString())
                {
                    case "Administrator":
                        result.Type = UserTypes.Administrator;
                        break;
                    case "Manager":
                        result.Type = UserTypes.Manager;
                        break;
                    case "Seller":
                        result.Type = UserTypes.Seller;
                        break;
                    case "Mechanic":
                        result.Type = UserTypes.Mechanic;
                        break;
                    default:
                        result.Type = UserTypes.BadLogin;
                        break;
                }

                return result;

            }
            catch (System.InvalidOperationException)
            {
                result.Type = UserTypes.BadLogin;
                return result;
            }
#if DEBUG
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                result.Type = UserTypes.Error;
                return result;
            }
#else
            catch (System.Exception)
            {
                result.Type = UserTypes.Error;
                return result;
            }
#endif

        }

    }
}
