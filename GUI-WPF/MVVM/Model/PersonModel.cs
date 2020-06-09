using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuisnessLayer1;
using DataLayer1;
using BusinessEntity.ClassModels;
using BusinessEntity;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Collections.ObjectModel;
using AutoMapper;

namespace GUI_WPF.MVVM.Model
{
    class PersonModel
    {
        BusinessManager BusinessManager = new BusinessManager();

        private int PersonId;
        private string PersonCode;
        private string Fname;
        private string Lname;
        private string Email;
        private string Username;
        private string Password;

        public event PropertyChangedEventHandler PropertyChanged;

        public void Changed([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public int personId
        {
            get { return PersonId; }
            set { PersonId = value; Changed(); }
        }

        public string personCode
        {
            get { return PersonCode; }
            set { PersonCode = value; Changed(); }
        }
        public string fname
        {
            get { return Fname; }
            set { Fname = value; Changed(); }
        }
        public string lname
        {
            get { return Lname; }
            set { Lname = value; Changed(); }
        }

        public string email
        {
            get { return Email; }
            set { Email = value; Changed(); }
        }
        public string username
        {
            get { return Username; }
            set { Username = value; Changed(); }
        }
        public string password
        {
            get { return Password; }
            set { Password = value; Changed(); }
        }

        public static PersonModel GetUser(string username, string password)
        {
            BusinessManager bm = new BusinessManager();
            IMapper mapper = new MapperConfiguration(cfg => cfg.CreateMap<PersonModel, Person>()).CreateMapper();
            return mapper.Map<PersonModel>(bm.GetUser(username, password));
        }

        private ObservableCollection<PersonModel> person = new ObservableCollection<PersonModel>();
        public ObservableCollection<PersonModel> Person
        {
            get { return person; }
            set { person = value; Changed(); }
        }   


    }
}


