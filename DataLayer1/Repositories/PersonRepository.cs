using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntity.ClassModels;

namespace DataLayer1.Repositories
{
    class PersonRepository : Repository<Person>, IPersonRepository
    {
        public PersonRepository(LibarysystemDBcontext context) : base(context)
        {

        }
        public List<Person> GetPerson()
        {
            using (var db = new LibarysystemDBcontext())
            {
                return db.Persons.ToList();
            }
        }

        public LibarysystemDBcontext LibarysystemDBcontext
        {
            get { return Context as LibarysystemDBcontext; }
        }
    }
}
