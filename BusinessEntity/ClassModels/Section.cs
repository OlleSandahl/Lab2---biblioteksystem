using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntity.ClassModels
{
    public partial class Section
    {
        public int SectionId { get; set; }
        public string Name { get; set; }

        public Section ()
        {
            this.Employees = new HashSet<Employee>();
            this.Programs = new HashSet<Program>();
        }

        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<Program> Programs { get; set; }

    }
}
