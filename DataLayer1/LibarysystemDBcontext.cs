using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using BusinessEntity.ClassModels;



namespace DataLayer1
{
    public class LibarysystemDBcontext : DbContext
    {
        public LibarysystemDBcontext() : base("Lab2 - biblioteksystem")
        {
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<LibarysystemDBcontext
        }

        public DbSet<Aktivity> aktivities { get; set; }
        public DbSet<Alumnus> alumni { get; set; }
        public DbSet<Employee> employees { get; set; }  
        public DbSet<Person> persons { get; set; }
        public DbSet<Program> programs { get; set; }
        public DbSet<Section> sections { get; set; }
        


    }
  




}
