﻿using LibraryCourseProject.ViewModels;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LibraryCourseProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
    
        public MainWindow()
        {
            InitializeComponent();
            LoginViewModel loginViewModel = new LoginViewModel();
            loginViewModel.SetUsers();
            DataContext = loginViewModel;
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();//it is temporary
        }
    }
}
