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
using GUI_WPF.MVVM.Model;


namespace GUI_WPF.MVVM
{
    class AlumnusModel : PersonModel ,INotifyPropertyChanged
    {
        private string alumnusId;

        BusinessManager businessManager = new BusinessManager();

        public event PropertyChangedEventHandler PropertyChanged;
        public void Changed([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public string AlumnusId
        {
            get { return alumnusId; }
            set { alumnusId = value; Changed(); }
        }

        public void CreateAlumn()
        {
         
           Alumnus alumn = new Alumnus();
           alumn.AlumnusId = int.Parse(alumnusId);
           alumn.Username = username;
           alumn.Fname = fname;
           alumn.Lname = lname;
           alumn.Password = password;
           alumn.Email = email;

           businessManager.CreateAlumnus(alumn);
        }

        public void GetAlumn()
        {
            businessManager.GetAlumnus(personId);
        }

        public void GetAlumns()
        {
            businessManager.GetAlumni();
        }
    }
}
