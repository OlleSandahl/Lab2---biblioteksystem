using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;



namespace DataLayer1
{
    public class LibarysystemDBcontext : DbContext
    {
        public LibarysystemDBcontext() : base("Lab2 - biblioteksystem")
        {
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<LibarysystemDBcontext
        }

        // public DbSet<Aktivity> aktivities { get; set; }
        


    }
}
