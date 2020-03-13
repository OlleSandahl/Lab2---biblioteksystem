using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntity.ClassModels
{
    class Aktivity
    {
        public int AktivityId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Choose { get; set; }

        public Aktivity ()
        {
            this.Alumnus = new HashSet<Alumnus>();
        }

        public virtual Employee Employee { get; set; }
        public virtual ICollection<Alumnus> Alumnus { get; set; }
    }
}
