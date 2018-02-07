using System.Security.Cryptography;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Windows.Forms;

namespace BusinessLayer
{
    public enum UserTypes { Error, BadLogin, Administrator, Manager, Seller, Mechanic};
    public static class Utility
    {
        public static string CalculateMD5Hash(string data)
        {
            var hash = MD5.Create();
            var passBytes = System.Text.Encoding.ASCII.GetBytes(data);
            var hashBytes = hash.ComputeHash(passBytes);
            var hexString = new SoapHexBinary(hashBytes);
            return hexString.ToString();
        }

        public static void DEBUG_RESET()
        {
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor;
            try
            {
                var database = DataLayer.Utility.GetContext();
                database.ExecuteCommand("EXEC dbo.reset;");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default;
        }

    }

    public struct LoginData 
    {
        public UserTypes Type;
        public int Dealership;
        public int ID;
    }
}
