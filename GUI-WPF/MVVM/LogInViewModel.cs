using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Collections.ObjectModel;
using GUI_WPF;
using GUI_WPF.MVVM.View;
using GUI_WPF.MVVM.Model;

namespace GUI_WPF.MVVM
{
    class LogInViewModel
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void Changed([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public LogInViewModel()
        {
            persoN = new ObservableCollection<PersonModel>();
            Person = new PersonModel();
        }

        public ObservableCollection<PersonModel> persoN { get; set; }

        private PersonModel person;

        public PersonModel Person
        {
            get { return person; }
            set { person = value; Changed(); }
        }

        private string username;

        public string Username
        {
            get { return username; }
            set { username = value; Changed(); }
        }

        private string password;

        public string Password
        {
            get { return password; }
            set { password = value; Changed(); }
        }

        public void Login()
        {
            Globals.CurrentUser = PersonModel.GetUser(Person.username, Person.password);

            if (Globals.CurrentUser == null)
            {
                System.Windows.MessageBox.Show("Ogiltligt användarnamn och/eller lösenord.");
            }
            else
            {
                if (PersonModel.IsAlumnus(Globals.CurrentUser))
                {
                    MainAlumnusView mainAlumnusView = new MainAlumnusView();

                    mainAlumnusView.Show();
                }

                if (PersonModel.IsEmployee(Globals.CurrentUser))
                {
                    MainEmployeeView mainEmployeeView = new MainEmployeeView();

                    mainEmployeeView.Show();
                }
            }
        }
    }
}
