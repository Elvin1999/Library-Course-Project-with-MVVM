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
    public class DeleteCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        public UserViewModel UserViewModel { get; set; }
        public DeleteCommand(UserViewModel userViewModel)
        {
            UserViewModel = userViewModel;
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            var item = UserViewModel.SelectedUser;
            if (item != null && UserViewModel.CurrentUser.Username != "admin")
            {

                App.DB.UserRepository.DeleteData(item);
                UserViewModel.AllUsers = App.DB.UserRepository.GetAllData();
                UserViewModel.SelectedUser = new User();
            }
            else
            {
                //data trigger yaz buttonlar sonsun eger admindise

                MessageBox.Show("You can not delete admin");
            }

        }
    }
}
