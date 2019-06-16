using LibraryCourseProject.Entities;
using LibraryCourseProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace LibraryCourseProject.Commands.UserSectionCommands
{
   public class UpdateCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        public UserViewModel UserViewModel { get; set; }
        public UpdateCommand(UserViewModel userViewModel)
        {
            UserViewModel = userViewModel;
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            var item = UserViewModel.CurrentUser;
            if (item != null && UserViewModel.CurrentUser.Username != "admin")
            {
                App.DB.UserRepository.UpdateData(item);
                App.DB.PermissionRepository.UpdateData(item.Permission);
                UserViewModel.AllUsers = App.DB.UserRepository.GetAllData();
                MessageBoxResult update = MessageBox.Show("updated");
                UserViewModel.CurrentUser = new User();
                UserViewModel.SelectedUser = new User();
            }
            else
            {
                MessageBox.Show("You can not update this user");
            }
        }
    }
}
