using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarDealership
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            CarDealership.ScreenForm Screen = new Forms.LoginScreen();
            Application.Run(Screen);

            while (Screen.NextScreen != Screens.Exit)
            {
                switch (Screen.NextScreen)
                {
                    case Screens.LoginScreen:
                        Screen = new Forms.LoginScreen();
                        break;
                    case Screens.AdminScreen:
                        Screen = new Forms.AdminScreen(Screen.EmployeeID);
                        break;
                    case Screens.SellerScreen:
                        Screen = new Forms.SellerScreen(Screen.DefaultDealership,Screen.EmployeeID);
                        break;
                    case Screens.ManagerScreen:
                        Screen = new Forms.ManagerScreen(Screen.DefaultDealership,Screen.EmployeeID);
                        break;
                    case Screens.MechanicScreen:
                        Screen = new Forms.MechanicScreen();
                        break;
                }
                Application.Run(Screen);
            }


        }
    }
}
