using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using BusinessEntity;
using BuisnessLayer1;
using DataLayer1;
using System.Runtime.CompilerServices;
using BusinessEntity.ClassModels;
using GUI_WPF.MVVM.Model;

namespace GUI_WPF
{
    public class EmployeeModel : PersonModel ,INotifyPropertyChanged
    {
        private string employeeId;

        BusinessManager businessManager = new BusinessManager();

        public event PropertyChangedEventHandler PropertyChanged;
        public void Changed([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public string EmployeeId
        {
            get { return employeeId; }
            set { employeeId = value; Changed(); }
        }

        public void CreateEmployee()
        {
            Employee employee = new Employee();
            employee.Password = password;
            employee.Email = email;
            employee.Username = username;
            employee.Fname = fname;
            employee.Lname = lname;
            employee.EmployeeId = employeeId;
            employee.PersonCode = personCode;

            businessManager.CreateEmployee(employee);
        }

        public void GetEmployee()
        {
            businessManager.GetEmployee(personId);
        }
    }
}
