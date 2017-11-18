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
            CarDealership.ScreenForm Screen = new LoginScreen();
            Application.Run(Screen);

            while (Screen.NextScreen != Screens.Exit)
            {
                switch (Screen.NextScreen)
                {
                    case Screens.LoginScreen:
                        Screen = new LoginScreen();
                        break;
                    case Screens.AdminScreen:
                        Screen = new AdminScreen();
                        break;
                    case Screens.SellerScreen:
                        Screen = new SellerScreen(Screen.DefaultDealership);
                        break;
                    case Screens.ManagerScreen:
                        Screen = new ManagerScreen(Screen.DefaultDealership);
                        break;
                    case Screens.MechanicScreen:
                        Screen = new MechanicScreen();
                        break;
                }
                Application.Run(Screen);
            }


        }
    }
}
