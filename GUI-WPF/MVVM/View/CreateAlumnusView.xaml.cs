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
using GUI_WPF.MVVM.View;

namespace GUI_WPF.MVVM.View
{
    /// <summary>
    /// Interaction logic for CreateAlumnusView1.xaml
    /// </summary>
    public partial class CreateAlumnusView : Window
    {
        CreateAlumnusViewModel vm = new CreateAlumnusViewModel();
        public CreateAlumnusView()
        {
            InitializeComponent();

            DataContext = vm;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            vm.CreateAlumnus();
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}