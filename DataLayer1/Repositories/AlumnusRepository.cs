using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntity.ClassModels;

namespace DataLayer1.Repositories
{
    class AlumnusRepository : Repository<Alumnus>, IAlumnusRepository
    {
        public AlumnusRepository(LibarysystemDBcontext context) : base(context)
        {

        }
        public void CreateAlumn(Alumnus alumn)
        {
            using (var db = new LibarysystemDBcontext())
            {
                db.Persons.Add(alumn);
                db.SaveChanges();
            }
        }

        public Alumnus GetAlumnus(int userId)
        {
            using (var db = new LibarysystemDBcontext())
            {
                return db.Persons.OfType<Alumnus>().Where(x => x.PersonId == userId).FirstOrDefault();
            }
        }
        public List<Alumnus> GetAlumns()
        {
            using (var db = new LibarysystemDBcontext())
            {
                return db.Persons.OfType<Alumnus>().ToList();
            }
        }

        public bool IsAlumnus(Person currentUser)
        {
            using (var db = new LibarysystemDBcontext())
            {
                if (db.Persons.OfType<Alumnus>().Where(x => x.PersonId == currentUser.PersonId).FirstOrDefault() != null)
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
