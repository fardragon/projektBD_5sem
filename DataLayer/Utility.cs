using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public static class Utility
    {
        public static DealershipDatabaseDataContext GetContext()
        {
#if DEBUG
            return new DealershipDatabaseDataContext { Log = System.Console.Out };
#else
            return new DealershipDatabaseDataContext();
#endif
        }

    }
}
