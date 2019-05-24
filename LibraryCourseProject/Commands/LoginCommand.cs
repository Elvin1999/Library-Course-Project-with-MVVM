using LibraryCourseProject.ViewModels;
using System;
using System.Collections.Generic;
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
            MessageBox.Show(LoginViewModel.Username);
            var passwordTxtb = parameter as PasswordBox;
            MessageBox.Show(passwordTxtb.Password);
        }
    }
}





