using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using DataLayer1;
using BusinessEntity.ClassModels;
using BuisnessLayer1;

namespace GUI_WPF.MVVM.Model
{
    class ProgramModel
    {
        private int programId;
        private string name;

        BusinessManager businessManager = new BusinessManager();

        public event PropertyChangedEventHandler PropertyChanged;
        public void Changed([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public int ProgramId
        {
            get { return programId; }
            set { programId = value; Changed(); }
        }

        public string Name
        {
            get { return name; }
            set { name = value; Changed(); }
        }

        public void GetPrograms()
        {
            businessManager.GetPrograms();
        }
    }
}
