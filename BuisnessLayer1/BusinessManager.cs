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
            Person x = unitOfWork.Person.GetUser(Username, Password);

            if (x != null)
                return new Person();
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
            List<Aktivity> aktivities = new List<Aktivity>();
            foreach (Aktivity aktivity in unitOfWork.Activities.GetActivities())
                aktivities.Add(aktivity);

            return aktivities;
        }

        public List<Section> GetSections()
        {
            List<Section> sections = new List<Section>();
            foreach (Section section in unitOfWork.Section.GetSections())
                sections.Add(section);

            return sections;
        }

        public List<Alumnus> GetAlumns()
        {
            List<Alumnus> alumns = new List<Alumnus>();
            foreach (Alumnus alumn in unitOfWork.Alumnus.GetAlumns())
                alumns.Add(alumn);

            return alumns;
        }

        public List<Program> GetPrograms()
        {
            List<Program> programs = new List<Program>();
            foreach (Program program in unitOfWork.Program.GetProgram())
                programs.Add(program);

            return programs;
        }

        public void UpdateActivity(Aktivity aktivity, int aktivityId)
        {
            unitOfWork.Activities.UpdateActivity(aktivity, aktivityId);
        }

        public void DeleteEvent(Aktivity aktivity)
        {
            unitOfWork.Activities.DeleteActivities(aktivity);
        }
    }
}
