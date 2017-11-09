using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    public static class AdminLogic
    {
        public static void DEBUG_RESET()
        {
            try
            {
                var database = new DealershipDatabaseDataContext();
#if DEBUG
                database.Log = System.Console.Out;
#endif
                database.ExecuteCommand("EXEC dbo.reset;");
            }
            catch (System.Exception ex)
            {
            	
            }           
        }
    }
}
