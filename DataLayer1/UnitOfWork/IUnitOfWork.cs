using DataLayer1.Repositories;

namespace DataLayer1.UnitOfWork
{
    interface IUnitOfWork
    {
        IActivitiesRepository Activities { get; }
        IAlumnusRepository Alumnus { get; }
        IEmployeeRepository Employee { get; }
        IPersonRepository Person { get; }
        IProgramRepository Program { get; }
        ISectionRepository Section { get; }

        int Complete();
        void Dispose();
    }
}