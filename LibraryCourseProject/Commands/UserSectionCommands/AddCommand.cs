using LibraryCourseProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace LibraryCourseProject.Commands.UserSectionCommands
{
    public class AddCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        public UserViewModel UserViewModel { get; set; }
        public AddCommand(UserViewModel UserViewModel)
        {
            this.UserViewModel = UserViewModel;
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            var passwordFromClient = (parameter as PasswordBox).Password;
            MessageBox.Show(UserViewModel.CurrentUser.Username);
            MessageBox.Show(passwordFromClient);
        }
    }
}
