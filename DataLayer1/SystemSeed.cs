using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntity.ClassModels;

namespace DataLayer1
{
    public class SystemSeed
    {
        public static void Populate(LibarysystemDBcontext libarysystemDBcontext)
        {
            Alumnus Olle = new Alumnus("OS", "Olle", "Sandahl", "s175313@student.hb.se", "OS1");

            libarysystemDBcontext.Alumni.Add(Olle);

            libarysystemDBcontext.Employees.Add(new Employee("OSU", "olle", "Sandal", "s173513@employee.hb.se", "OSU1"));

            libarysystemDBcontext.Programs.Add(new Program()
            {
                ProgramId = 1,
                Name = "Computer-Economics",
            });
            libarysystemDBcontext.Programs.Add(new Program()
            {
                ProgramId = 2,
                Name = "System-Development"
            });

            Aktivity aktivity = new Aktivity()
            {
                AktivityId = 1,
                Name = "Meeting",
                Description = "discuss common goals"
            };


            libarysystemDBcontext.SaveChanges();


            //adadada
        }
    }
}
