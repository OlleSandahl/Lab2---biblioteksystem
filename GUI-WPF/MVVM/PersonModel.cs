using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using BuisnessLayer1;
using BusinessEntity.ClassModels;
using GUI_WPF.MVVM;
using System.Collections.ObjectModel;
using AutoMapper;

namespace GUI_WPF.MVVM
{
    public class PersonModel : INotifyPropertyChanged
    {
        BusinessManager businessManager = new BusinessManager();

        protected int persId;
        protected string persCode;
        protected string fname;
        protected string lname;
        protected string email;
        protected string username;
        protected string password;

        public event PropertyChangedEventHandler PropertyChanged;
        public void Changed([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public int PersId
        {
            get { return persId; }
            set { persId = value; Changed(); }
        }

        public string PersCode
        {
            get { return persCode; }
            set { persCode = value; Changed(); }
        }

        public string Fname
        {
            get { return fname; }
            set { fname = value; Changed(); }
        }

        public string Lname
        {
            get { return lname; }
            set { lname = value; Changed(); }
        }

        public string Email
        {
            get { return email; }
            set { email = value; Changed(); }
        }

        public string Username
        {
            get { return username; }
            set { username = value; Changed(); }
        }

        public string Password
        {
            get { return password; }
            set { password = value; Changed(); }
        }

        public static PersonModel GetUser(string username, string password)
        {
            BusinessManager bm = new BusinessManager();
            IMapper mapper = new MapperConfiguration(cfg => cfg.CreateMap<PersonModel, Person>()).CreateMapper();
            return mapper.Map<PersonModel>(bm.GetUser(username, password));
        }

        public static bool IsAlumnus(PersonModel currentUser)
        {
            BusinessManager bm = new BusinessManager();
            IMapper mapper = new MapperConfiguration(cfg => cfg.CreateMap<PersonModel, Person>()).CreateMapper();
            return bm.(mapper.Map<Person>(currentUser));
        }

        public static bool IsEmployee(PersonModel currentUser)
        {
            BusinessManager bm = new BusinessManager();
            IMapper mapper = new MapperConfiguration(cfg => cfg.CreateMap<PersonModel, Person>()).CreateMapper();
            return bm.IsEmployee(mapper.Map<Person>(currentUser));
        }
    }
}
