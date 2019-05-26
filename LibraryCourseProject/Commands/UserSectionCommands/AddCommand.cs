using LibraryCourseProject.Entities;
using LibraryCourseProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
            UserViewModel.CurrentUser.Password = passwordFromClient;
            if (UserViewModel.AllUsers == null)
            {
                UserViewModel.AllUsers = new ObservableCollection<User>();
            }
            if (UserViewModel.AllUsers.Count == 0)
            {
                UserViewModel.CurrentUser.Id = 0;
                UserViewModel.CurrentUser.No = 0;
            }
            else if (UserViewModel.AllUsers.Count != 0)
            {
                int index = UserViewModel.AllUsers.Count - 1;
                int newID = UserViewModel.AllUsers[index].Id + 1;
                UserViewModel.CurrentUser.Id = newID;
                UserViewModel.CurrentUser.No = newID;
            }
            var item = UserViewModel.AllUsers.FirstOrDefault(x => x.Id == UserViewModel.CurrentUser.Id);
            
            if (item == null)
            {

                UserViewModel.AllUsers.Add(UserViewModel.CurrentUser);
                MessageBoxResult add = MessageBox.Show("Added");
                UserViewModel.CurrentUser = new User();
                UserViewModel.CurrentUser.Password = String.Empty;
                //UserViewModel.CurrentUser.Permission = new Permission();
                UserViewModel.SelectedUser = new User();
            }
            else
            {
                MessageBoxResult add = MessageBox.Show("Can not add this item, you can only update and delete");
            }
        }
    }
}
