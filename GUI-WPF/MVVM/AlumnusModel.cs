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
using BusinessEntity.ClassModels;


namespace GUI_WPF.MVVM
{
    class AlumnusModel : Model.PersonModel, INotifyPropertyChanged
    {
        private string sNumber;

        BusinessManager businessManager = new BusinessManager();

        public event PropertyChangedEventHandler PropertyChanged;
        public void Changed([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public string SNumber
        {
            get { return sNumber; }
            set { sNumber = value; Changed(); }
        }

        public void CreateAlumn()
        {
         
           Alumnus alumn = new Alumnus();
            alumn.Username = username;
            alumn.Fname = fname;
           alumn.Lname = lname;
           alumn.Password = password;
           alumn.Email = email;

           businessManager.CreateAlumnus(alumn);
        }

        public void GetAlumn()
        {
            businessManager.GetAlumnus(id);
        }

        public void GetAlumns()
        {
            businessManager.GetAlumni();
        }
    }
}
