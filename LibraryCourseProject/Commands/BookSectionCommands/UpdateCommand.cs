using LibraryCourseProject.Entities;
using LibraryCourseProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace LibraryCourseProject.Commands.BookSectionCommands
{
    public class UpdateCommand : ICommand
    {
        public UpdateCommand(BookViewModel bookViewModel)
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
            var item = BookViewModel.AllBooks.FirstOrDefault(x => x.Id == BookViewModel.CurrentBook.Id);

            if (item != null)
            {
                var index = BookViewModel.AllBooks.IndexOf(item);
                BookViewModel.AllBooks[index] = BookViewModel.CurrentBook;
                App.Config.Books = new List<Book>(BookViewModel.AllBooks);
                App.Config.SeriailizeBooksToJson();
                MessageBoxResult update = MessageBox.Show("updated");
                BookViewModel.CurrentBook = new Book();
                BookViewModel.SelectedBook = new Book();
                BookViewModel.State = 1;
            }
            else
            {
                MessageBox.Show("You can not update this user");
            }
        }
    }
}
