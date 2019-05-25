using LibraryCourseProject.ViewModels;
using System;
using System.Collections.Generic;
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
            throw new NotImplementedException();
        }
    }
}
