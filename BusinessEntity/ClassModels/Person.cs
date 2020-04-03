using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntity.ClassModels
{
   public class Person
    {
        public int PersonId { get; set; }
        public int PersonCode { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        //public Person(string fname, string lname, string email, string password, string username)
        //{
        //    Fname = fname;
        //    Lname = lname;
        //    this.Email = email;
        //    this.Username = username;
        //    this.Password = password;
        //}
        public Person(Person person)
        {

        }

    }

}
