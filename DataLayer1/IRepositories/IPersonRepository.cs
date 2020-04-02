using BusinessEntity.ClassModels;
using System.Collections.Generic;

namespace DataLayer1.Repositories
{
    public interface IPersonRepository
    {
        LibarysystemDBcontext LibarysystemDBcontext { get; }

        List<Person> GetPerson();
    }
}