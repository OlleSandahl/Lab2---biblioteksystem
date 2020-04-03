using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntity.ClassModels;

namespace GUI
{
    public static class Global
    {
        public static Person CurrentUser { get; set; }
        public static Section CurrentSection { get; set; }
    }
}
