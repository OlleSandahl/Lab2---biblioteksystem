using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using BuisnessLayer1;
using BusinessEntity.ClassModels;
using DataLayer1;

namespace GUI_WPF.MVVM.Model
{
    public class ActivityModel 
    {
        private int eventId;
        private string name;
        private string description;
        private bool choose;

        BusinessManager businessManager = new BusinessManager();

        public event PropertyChangedEventHandler PropertyChanged;
        public void Changed([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public int EventId
        {
            get { return eventId; }
            set { eventId = value; Changed(); }
        }

        public string Name
        {
            get { return name; }
            set { name = value; Changed(); }
        }

        public string Description
        {
            get { return description; }
            set { description = value; Changed(); }
        }

        public bool Choose
        {
            get { return choose; }
            set { choose = value; Changed(); }
        }

        public void CreateEvent()
        {
            Employee employee = new Employee();
            employee = businessManager.GetEmployee(Globals.CurrentUser.personId);

            Aktivity aktivity = new Aktivity();
            aktivity.Name = name;
            aktivity.Description = description;
            aktivity.Employee = employee;

            businessManager.CreateActivity(aktivity);
        }

        public void GetEvents()
        {
            businessManager.GetAktivities();
        }
    }
}
