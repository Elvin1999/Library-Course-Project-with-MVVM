using LibraryCourseProject.Entities;
using LibraryCourseProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace LibraryCourseProject.Commands.BookSectionCommands
{
    public class AddCommand : ICommand
    {
        public AddCommand(BookViewModel bookViewModel)
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
           
        }
    }
}
