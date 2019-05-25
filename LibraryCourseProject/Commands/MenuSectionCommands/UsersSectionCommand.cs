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
            userViewModel.AllUsers = new ObservableCollection<User>() {

                new User()
                {
                     Email="mymail@gmail.com",
                      Id=1,
                       No=1,
                        Note="empty",
                         Password="elvinelvin",
                          Permission=new Permission()
                          {
                               No=1,
                                Id=1,
                                 CanCreateBook=true
                          },
                           Username="ElvinElvin"
                }
            };

            UserWindow userWindow = new UserWindow(userViewModel);
            userWindow.ShowDialog();
        }
    }
}
