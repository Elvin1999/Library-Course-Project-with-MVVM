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
            //  if (item.Id != 1)
            //  {
            
            App.DB.UserRepository.DeleteData(item);
            UserViewModel.AllUsers = App.DB.UserRepository.GetAllData();

                //App.Config.Users = new List<User>(UserViewModel.AllUsers);
                //App.Config.SeriailizeToJson();
                //App.DB.UserRepository.DeleteData(item);
                UserViewModel.SelectedUser = new User();
           // }
          //  else
          //  {
          //      MessageBox.Show("You can not delete *admin* ");
//}

        }
    }
}
