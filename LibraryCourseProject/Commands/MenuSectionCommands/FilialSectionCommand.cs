using LibraryCourseProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace LibraryCourseProject.Commands.MenuSectionCommands
{
    public class FilialSectionCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public MenuViewModel MenuViewModel { get; set; }

        public FilialSectionCommand(MenuViewModel menuViewModel)
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
