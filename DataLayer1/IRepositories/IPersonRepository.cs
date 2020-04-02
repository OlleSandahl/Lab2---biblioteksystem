using BusinessEntity.ClassModels;
using System.Collections.Generic;

namespace DataLayer1.Repositories
{
    interface IPersonRepository
    {
        LibarysystemDBcontext LibarysystemDBcontext { get; }

        List<Person> GetPerson();
    }
}