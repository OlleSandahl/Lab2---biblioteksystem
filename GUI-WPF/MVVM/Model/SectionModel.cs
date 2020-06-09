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
    public class SectionModel : INotifyPropertyChanged
    {
        private int sectionId;
        private string name;

        BusinessManager businessManager = new BusinessManager();

        public event PropertyChangedEventHandler PropertyChanged;
        public void Changed([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public int SectionId
        {
            get { return sectionId; }
            set { sectionId = value; Changed(); }
        }

        public string Name
        {
            get { return name; }
            set { name = value; Changed(); }
        }

        public void GetSection()
        {
            businessManager.GetSection(SectionId);
        }

        public void GetSections()
        {
            businessManager.GetSections();
        }
    }
}
