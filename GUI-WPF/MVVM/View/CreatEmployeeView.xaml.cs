using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace GUI_WPF.MVVM.View
{
    /// <summary>
    /// Interaction logic for CreatEmployeeView.xaml
    /// </summary>
    public partial class CreatEmployeeView : Window
    {
        CreateEmployeeViewModel vm = new CreateEmployeeViewModel();
        public CreatEmployeeView()
        {
            InitializeComponent();

            DataContext = vm;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            vm.CreateEmployee();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
