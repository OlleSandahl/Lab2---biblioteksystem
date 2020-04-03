using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntity.ClassModels
{
    public partial class Alumnus : Person
    {
        public string AlumnusId { get; set; }

        public virtual Program Program { get; set; }
        public virtual Aktivity Aktivity { get; set; }

    }
}
