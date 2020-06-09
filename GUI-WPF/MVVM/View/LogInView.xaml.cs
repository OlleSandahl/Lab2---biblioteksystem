﻿using System;
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
    /// Interaction logic for LogInView.xaml
    /// </summary>
    public partial class LogInView : Window
    {
        LoginViewModel vm = new LoginViewModel();
        public LogInView()
        {
            InitializeComponent();
            DataContext = vm;
        }
        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CreateAlumnusView createAlumnusWindow = new CreateAlumnusWindow();

            createAlumnusWindow.Show();
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            CreateEmployeeWindow createEmployeeWindow = new CreateEmployeeWindow();

            createEmployeeWindow.Show();
        }

        private void Button_Click4(object sender, RoutedEventArgs e)
        {
            vm.Login();
        }
    }
}
