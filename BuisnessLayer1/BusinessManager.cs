using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer1;
using DataLayer1.UnitOfWork;
using BusinessEntity.ClassModels;
using DataLayer1.Repositories;

namespace BuisnessLayer1
{
    class BusinessManager
    {
        private LibarysystemDBcontext context;

        private UnitOfWork unitOfWork { get; set; }

        public BusinessManager()
        {
            unitOfWork = new UnitOfWork(context);
        }

        public void CreateAlumn(Alumnus alumn)
        {
            unitOfWork.Alumnus.CreateAlumn(alumn);
        }

        public void CreateEmployee(Employee employee)
        {
            unitOfWork.Employee.CreateEmployee(employee);
        }

        public void CreateEvent(Aktivity aktivity)
        {
            unitOfWork.Activities.CreateAktivity(aktivity);
        }

        public void CreateSection(Section section)
        {
            unitOfWork.Section.CreateSection(section);
        }

        public void CreateProgram(Program program)
        {
            unitOfWork.Program.CreateProgram(program);
        }

        public bool IsAlumnus(Person currentUser)
        {
            return unitOfWork.Alumnus.IsAlumnus(currentUser);

        }

        public bool IsEmployee(Person currentUser)
        {
            return unitOfWork.Employee.IsEmployee(currentUser);
        }

        public Person GetUser(string Username, string Password)
        {
            Person x = unitOfWork.Person.GetPerson(Username, Password);

            if (x != null)
                return new Person(x);
            else return null;
        }

        public Employee GetEmployee(int PersId)
        {
            return unitOfWork.Employee.GetEmployee(PersId);
        }
        public Section GetSection(int SectionId)
        {
            return unitOfWork.Section.GetSection(SectionId);
        }

        public Alumnus GetAlumn(int PersId)
        {
            return unitOfWork.Alumnus.GetAlumnus(PersId);
        }

        public List<Aktivity> GetAktivity()
        {
            List<Aktivity> aktivities = new List<>();
            foreach (DataLayer.Event eVent in unitOfWork.Events.GetEvents())
                events.Add(EventBL.Convert(eVent));

            return events;
        }

        public List<SectionBL> GetSections()
        {
            List<SectionBL> sections = new List<SectionBL>();
            foreach (DataLayer.Section section in unitOfWork.Sections.GetSections())
                sections.Add(SectionBL.Convert(section));

            return sections;
        }

        public List<AlumnusBL> GetAlumns()
        {
            List<AlumnusBL> alumns = new List<AlumnusBL>();
            foreach (DataLayer.Alumnus alumn in unitOfWork.Alumnuses.GetAlumns())
                alumns.Add(AlumnusBL.Convert(alumn));

            return alumns;
        }

        public List<ProgramBL> GetPrograms()
        {
            List<ProgramBL> programs = new List<ProgramBL>();
            foreach (DataLayer.Program program in unitOfWork.Programs.GetPrograms())
                programs.Add(ProgramBL.Convert(program));

            return programs;
        }

        public void UpdateEvent(Aktivity aktivity, int aktivityId)
        {
            unitOfWork.Activities.UpdateActivity(aktivity, aktivityId);
        }

        public void DeleteEvent(EventBL events)
        {
            unitOfWork.Events.DeleteEvent(events);
        }
    }
}
