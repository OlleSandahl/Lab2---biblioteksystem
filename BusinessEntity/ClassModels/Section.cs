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
            this.Employee = new HashSet<Employee>();

        }

        public virtual ICollection<Employee> Employee { get; set; }

    }
}
