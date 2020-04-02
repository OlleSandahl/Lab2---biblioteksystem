using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer1.Repositories;

namespace DataLayer1.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly LibarysystemDBcontext _context;

        public UnitOfWork(LibarysystemDBcontext context)
        {
            _context = context;
            Alumnus = new AlumnusRepository(_context);
            Employee = new EmployeeRepository(_context);
            Activities = new ActivitiesRepository(_context);
            Person = new PersonRepository(_context);
            Program = new ProgramRepository(_context);
            Section = new SectionRepository(_context);

        }
        public IAlumnusRepository Alumnus { get; private set; }
        public IEmployeeRepository Employee { get; private set; }
        public IActivitiesRepository Activities { get; private set; }
        public IPersonRepository Person { get; private set; }

        public IProgramRepository Program { get; private set; }
        public ISectionRepository Section { get; private set; }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
