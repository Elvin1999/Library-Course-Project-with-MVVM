using LibraryCourseProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace LibraryCourseProject.Commands.MenuSectionCommands
{
    public class LanguageCommand : ICommand
    {
        public LanguageCommand(MenuViewModel menuViewModel)
        {
            MenuViewModel = menuViewModel;
        }

        public event EventHandler CanExecuteChanged;
        public MenuViewModel MenuViewModel { get; set; }
        public bool CanExecute(object parameter)
        {
            return true;
        }
        public void Execute(object parameter)
        {
            if (MenuViewModel.State == 1)
            {
                MenuViewModel.State = 2;
            }
            else
            {
                MenuViewModel.State = 1;
            }
        }
    }
}
