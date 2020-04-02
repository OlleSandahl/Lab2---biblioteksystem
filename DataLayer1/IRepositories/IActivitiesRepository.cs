using BusinessEntity.ClassModels;
using System.Collections.Generic;

namespace DataLayer1.Repositories
{
    interface IActivitiesRepository
    {
        LibarysystemDBcontext LibarysystemDBcontext { get; }

        void CreateAktivity(Aktivity aktivity);
        void DeleteActivities(Aktivity localaktivity);
        List<Aktivity> GetActivities();
        List<Aktivity> GetActivitiesByAlumnus();
        void UpdateActivity(Aktivity Localaktivty, int aktivityId);
    }
}