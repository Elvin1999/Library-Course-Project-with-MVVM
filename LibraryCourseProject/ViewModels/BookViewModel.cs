using LibraryCourseProject.Commands.BookSectionCommands;
using LibraryCourseProject.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCourseProject.ViewModels
{
    public class BookViewModel : BaseViewModel
    {
        public List<Genre> Genres { get; set; }
        public List<Author> Authors { get; set; }
        public AddCommand AddCommand => new AddCommand(this);
        public DeleteCommand DeleteCommand => new DeleteCommand(this);
        public UpdateCommand UpdateCommand => new UpdateCommand(this);

        private int state = 1;

        public int State
        {
            get
            {
                return state;
            }
            set
            {
                state = value;
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(State)));
            }
        }

        private ObservableCollection<Book> allBooks;
        public ObservableCollection<Book> AllBooks
        {
            get
            {
                return allBooks;
            }
            set
            {
                allBooks = value;
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(AllBooks)));
            }
        }
        public BookViewModel()
        {
            CurrentBook = new Book();
        }
        private Book currentBook;
        public Book CurrentBook
        {
            get
            {
                return currentBook;
            }
            set
            {
                currentBook = value;
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(CurrentBook)));
            }
        }

        private Book selectedBook;
        public Book SelectedBook
        {
            get
            {
                return selectedBook;
            }
            set
            {
                selectedBook = value;
                if (value != null)
                {
                    
                    CurrentBook = SelectedBook.Clone();
                }
                if (SelectedBook != null)
                {
                    State = 2;
                }
                else
                {
                    State = 1;
                }
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(SelectedBook)));
            }
        }
    }
}
