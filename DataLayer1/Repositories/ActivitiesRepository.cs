using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntity.ClassModels;

namespace DataLayer1.Repositories
{
    public class ActivitiesRepository : Repository<Aktivity>, IActivitiesRepository
    {
        public ActivitiesRepository(LibarysystemDBcontext context) : base(context)
        {
        }

        public void CreateAktivity(Aktivity aktivity)
        {
            using (var db = new LibarysystemDBcontext())
            {
                db.Aktivities.Add(aktivity);
                db.SaveChanges();
            }
        }

        public List<Aktivity> GetActivities()
        {
            using (var db = new LibarysystemDBcontext())
            {
                return db.Aktivities.ToList();
            }
        }
        public List<Aktivity> GetActivitiesByAlumnus()
        {
            using (var db = new LibarysystemDBcontext())
            {
                return db.Aktivities.Where(x => x.Alumnus != null).ToList();
            }
        }

        public void DeleteActivities(Aktivity localaktivity)
        {

        }

        public void UpdateActivity(Aktivity Localaktivty, int aktivityId)
        {

        }

        public LibarysystemDBcontext LibarysystemDBcontext
        {
            get { return Context as LibarysystemDBcontext; }
        }


    }
}

