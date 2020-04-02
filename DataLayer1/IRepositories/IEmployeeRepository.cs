using BusinessEntity.ClassModels;

namespace DataLayer1.Repositories
{
    interface IEmployeeRepository
    {
        LibarysystemDBcontext LibarysystemDBcontext { get; }

        void CreateEmployee(Employee employee);
        Employee GetEmployee(int userId);
        bool IsEmployee(Person currentUser);
    }
}