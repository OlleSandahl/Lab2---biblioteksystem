using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntity.ClassModels
{
    public class Employee : Person
    {
      
        public string EmployeeId { get; set; }

        public Employee()
        {
            this.Aktivities = new HashSet<Aktivity>();
        }

        public virtual Section Section { get; set; }
        public virtual ICollection<Aktivity> Aktivities { get; set; }

        public Employee(string Username, string Fname, string ename, string Email, string Password)
        {

        }
    }

  

}
