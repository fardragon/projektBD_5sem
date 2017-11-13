using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer;

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
    }
}
