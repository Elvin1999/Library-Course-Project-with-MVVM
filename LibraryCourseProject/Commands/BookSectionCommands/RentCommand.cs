using LibraryCourseProject.ViewModels;
using LibraryCourseProject.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace LibraryCourseProject.Commands.BookSectionCommands
{
    public class RentCommand : ICommand
    {
        public RentCommand(BookViewModel bookViewModel)
        {
            BookViewModel = bookViewModel;
        }

        public event EventHandler CanExecuteChanged;
        public BookViewModel BookViewModel { get; set; }
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            RentViewModel rentViewModel = new RentViewModel();
            RentWindow rentWindow = new RentWindow(rentViewModel);
            rentWindow.ShowDialog();
        }
    }
}
