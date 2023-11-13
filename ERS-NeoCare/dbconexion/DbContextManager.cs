using ERS_NeoCare.dbconexion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class DbContextManager
{
    public static ApplicationDbContext dbContext;
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


    public static void DisposeContext()
    {
        if (dbContext != null)
        {
            dbContext.Dispose();
            dbContext = null;
        }
    }
}


