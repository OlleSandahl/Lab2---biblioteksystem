using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntity.ClassModels
{
    public class Program
    {
        public int ProgramId { get; set; }
        public string Name { get; set; }
        
        public Program()
        {
            this.Alumnus = new HashSet<Alumnus>();
        }
        public virtual ICollection<Alumnus> Alumnus { get; set; }
        public virtual Section Section { get; set; }
    }
}
