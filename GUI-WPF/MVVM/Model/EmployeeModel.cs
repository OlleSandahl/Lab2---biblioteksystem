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

namespace GUI_WPF
{
    public class EmployeeModel
    {
        private string signature;

        BusinessManager businessManager = new BusinessManager();

        public event PropertyChangedEventHandler PropertyChanged;
        public void Changed([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public string Signature
        {
            get { return signature; }
            set { signature = value; Changed(); }
        }

        public void CreateEmployee()
        {
            Employee employee = new Employee();
            employee.Password = password;
            employee.Email = email;
            employee.Username = username;
            employee.Fname = fname;
            employee.Lname = lname;
            employee.Signature = signature;
            employee.PersCode = persCode;

            businessManager.CreateEmployee(employee);
        }

        public void GetEmployee()
        {
            businessManager.GetEmployee(PersId);
        }
    }
}
