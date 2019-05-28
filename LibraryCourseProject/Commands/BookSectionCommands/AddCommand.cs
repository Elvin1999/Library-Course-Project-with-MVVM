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
            if (BookViewModel.AllBooks == null)
            {
                BookViewModel.AllBooks = new ObservableCollection<Book>();
            }
            if (BookViewModel.AllBooks.Count == 0)
            {
                BookViewModel.CurrentBook.Id = 0;
                BookViewModel.CurrentBook.No = 0;
            }
            else if (BookViewModel.AllBooks.Count != 0)
            {
                int index = BookViewModel.AllBooks.Count - 1;
                int newID = BookViewModel.AllBooks[index].Id + 1;
                BookViewModel.CurrentBook.Id = newID;
                BookViewModel.CurrentBook.No = newID;
            }
            var item = BookViewModel.AllBooks.FirstOrDefault(x => x.Id == BookViewModel.CurrentBook.Id);

            if (item == null)
            {
                var newitem = BookViewModel.CurrentBook;
                BookViewModel.AllBooks.Add(newitem);
                App.Config.Books.Add(newitem);
                App.Config.SeriailizeBooksToJson();

                MessageBoxResult add = MessageBox.Show("Added");
                BookViewModel.CurrentBook = new Book();
            }
            else
            {
                MessageBoxResult add = MessageBox.Show("Can not add this item, you can only update and delete");
            }
        }
    }
}
