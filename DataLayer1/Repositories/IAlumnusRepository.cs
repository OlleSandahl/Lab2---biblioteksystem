using BusinessEntity.ClassModels;
using System.Collections.Generic;

namespace DataLayer1.Repositories
{
    public interface IAlumnusRepository
    {
        List<Alumnus> GetAll();
    }
}