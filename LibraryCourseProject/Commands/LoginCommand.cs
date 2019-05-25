using LibraryCourseProject.Entities;
using LibraryCourseProject.ViewModels;
using LibraryCourseProject.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
namespace LibraryCourseProject.Commands
{
   public class LoginCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        public LoginViewModel LoginViewModel { get; set; }
        public LoginCommand(LoginViewModel LoginViewModel)
        {
            this.LoginViewModel = LoginViewModel;
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }
        public void Execute(object parameter)
        {
      
            var passwordFromClient = (parameter as PasswordBox).Password;
      
            var usernameFromClient = LoginViewModel.Username;
            var user = LoginViewModel.Users.SingleOrDefault(x => x.Username == usernameFromClient && x.Password == passwordFromClient);
            if (user != null)
            {
                MessageBox.Show("Okay");
                UserViewModel userViewModel = new UserViewModel();
                UserWindow userWindow = new UserWindow(userViewModel);
                userWindow.ShowDialog();
            }
            else
            {
                MessageBox.Show("No");
            }

        }
    }
}





