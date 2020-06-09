using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using GUI_WPF.MVVM;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace GUI_WPF.MVVM
{
    class CreateAlumnusViewModel
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void Changed([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public CreateAlumnusViewModel()
        {
            Alumn = new ObservableCollection<AlumnusModel>();
            Alumnus = new AlumnusModel();
        }

        public ObservableCollection<AlumnusModel> Alumn { get; set; }

        private AlumnusModel alumnus;

        public AlumnusModel Alumnus
        {
            get { return alumnus; }
            set { alumnus = value; Changed(); }
        }

        private string verifyPassword;

        public string VerifyPassword
        {
            get { return verifyPassword; }
            set { verifyPassword = value; Changed(); }
        }

        public void CreateAlumnus()
        {
            if (Alumnus. == VerifyPassword)
            {
                Alumnus.CreateAlumn();
            }
            else System.Windows.MessageBox.Show("Test");
        }
    }
}
