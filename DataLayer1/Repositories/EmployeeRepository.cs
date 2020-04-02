using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntity.ClassModels;

namespace DataLayer1.Repositories
{
    public class EmployeeRepository : Repository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(LibarysystemDBcontext context) : base(context)
        {

        }
        public void CreateEmployee(Employee employee)
        {
            using (var db = new LibarysystemDBcontext())
            {
                db.Persons.Add(employee);
                db.SaveChanges();
            }
        }

        public Employee GetEmployee(int userId)
        {
            using (var db = new LibarysystemDBcontext())
            {
                return db.Persons.OfType<Employee>().Where(x => x.PersonId == userId).FirstOrDefault();
            }
        }

        public bool IsEmployee(Person currentUser)
        {
            using (var db = new LibarysystemDBcontext())
            {
                if (db.Persons.OfType<Employee>().Where(x => x.PersonId == currentUser.PersonId).FirstOrDefault() != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public LibarysystemDBcontext LibarysystemDBcontext
        {
            get { return Context as LibarysystemDBcontext; }
        }
    }
}
