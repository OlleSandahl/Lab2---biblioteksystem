using BusinessEntity.ClassModels;
using System.Collections.Generic;

namespace DataLayer1.Repositories
{
    public interface IAlumnusRepository
    {
        LibarysystemDBcontext LibarysystemDBcontext { get; }

        void CreateAlumn(Alumnus alumn);
        List<Alumnus> GetAlumns();
        Alumnus GetAlumnus(int userId);
        bool IsAlumnus(Person currentUser);
    }
}