using LibraryCourseProject.DataAccess.EntityFrameworkServer;
using LibraryCourseProject.Entities;
using LibraryCourseProject.ViewModels;
using LibraryCourseProject.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
namespace LibraryCourseProject.Commands.MenuSectionCommands
{
    public class UsersSectionCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        public MenuViewModel  MenuViewModel { get; set; }
        public UsersSectionCommand(MenuViewModel nenuViewModel)
        {
            MenuViewModel = MenuViewModel;
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            UserViewModel userViewModel = new UserViewModel();
            var items = App.DB.UserRepository.GetAllData();
            userViewModel.AllUsers = items;
            //var items = App.Config.DeserializeFromJson();
            //if (items != null)
            //{
            //    userViewModel.AllUsers = new ObservableCollection<User>(items);
            //}
            //else
            //{
            //    userViewModel.AllUsers = new ObservableCollection<User>();
            //}
            UserWindow userWindow = new UserWindow(userViewModel);
            userWindow.ShowDialog();
        }
    }
}
