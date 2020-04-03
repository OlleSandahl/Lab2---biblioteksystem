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


        public static Alumnus Convert(Alumnus alumn)
        {
            return new Alumnus()
            {
                Username = alumn.Username,
                Password = alumn.Password,
                PersonCode = alumn.PersonCode,
                AlumnusId = alumn.AlumnusId,
                Fname = alumn.Fname,
                Lname = alumn.Lname,
                Email = alumn.Email,
            };
        }
    }
}
