using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using GUI_WPF.MVVM;

namespace GUI_WPF.MVVM
{
    public class CreateEmployeeViewModel
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void Changed([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public CreateEmployeeViewModel()
        {
            Employ = new ObservableCollection<EmployeeModel>();
            Employee = new EmployeeModel();
        }

        public ObservableCollection<EmployeeModel> Employ { get; set; }

        private EmployeeModel employee;

        public EmployeeModel Employee
        {
            get { return employee; }
            set { employee = value; Changed(); }
        }

        private string verifyPassword;

        public string VerifyPassword
        {
            get { return verifyPassword; }
            set { verifyPassword = value; Changed(); }
        }

        public void CreateEmployee()
        {
            if (Employee.Password == VerifyPassword)
            {
                Employee.CreateEmployee();
            }
            else System.Windows.MessageBox.Show("Test");

        }
    }
}
