using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GUI_WPF.MVVM.Model;
using BusinessEntity.ClassModels;

namespace GUI_WPF.MVVM
{
    class Globals
    {
        public static PersonModel CurrentUser { get; set; }
        public static Section CurrentSection { get; set; }
    }
}
