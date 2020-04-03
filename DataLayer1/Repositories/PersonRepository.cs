using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntity.ClassModels;

namespace DataLayer1.Repositories
{
    public class PersonRepository : Repository<Person>, IPersonRepository
    {
        public PersonRepository(LibarysystemDBcontext context) : base(context)
        {

        }
        public List<Person> GetPersons()
        {
            using (var db = new LibarysystemDBcontext())
            {
                return db.Persons.ToList();
            }
        }
        public Person GetUser(string username, string password)
        {
            using (var db = new LibarysystemDBcontext())
            {
                return db.Persons.Where(x => x.Username == username && x.Password == password).FirstOrDefault();
            }
        }
        public LibarysystemDBcontext LibarysystemDBcontext
        {
            get { return Context as LibarysystemDBcontext; }
        }
    }
}
