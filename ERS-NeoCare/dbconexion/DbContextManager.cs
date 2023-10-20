using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERS_NeoCare.dbconexion
{
    internal class DbContextManager
    {
        private static ApplicationDbContext dbContext;
        private static readonly object lockObject = new object();

        public static ApplicationDbContext GetContext()
        {
            if (dbContext == null)
            {
                lock (lockObject)
                {
                    if (dbContext == null)
                    {
                        dbContext = new ApplicationDbContext();
                    }
                }
            }
            return dbContext;
        }
    }
}

