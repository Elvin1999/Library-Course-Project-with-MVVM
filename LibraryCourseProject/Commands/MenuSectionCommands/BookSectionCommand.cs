using LibraryCourseProject.Entities;
using LibraryCourseProject.ViewModels;
using LibraryCourseProject.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace LibraryCourseProject.Commands.MenuSectionCommands
{
    public class BookSectionCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        public MenuViewModel MenuViewModel { get; set; }
        public BookSectionCommand(MenuViewModel menuViewModel)
        {
            MenuViewModel = menuViewModel;
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            BookViewModel bookViewModel = new BookViewModel() { };
            bookViewModel.Authors = new List<Author>()
            {
                new Author(){
                     Id=0,
                      Name="John",
                       No=1,
                        Surname="Mie"
                },
                 new Author(){
                     Id=1,
                      Name="Jimmy",
                       No=1,
                        Surname="Don"
                },
                  new Author(){
                     Id=2,
                      Name="Mike",
                       No=1,
                        Surname="Mi"
                }

            };
            bookViewModel.Genres = new List<Genre>()
            {
                new Genre()
                {
                     No=1, Name="Drama", Id=0
                },

                new Genre()
                {
                     No=2, Name="Love", Id=1
                },

                new Genre()
                {
                     No=3, Name="Crime", Id=2
                }
                ,

                new Genre()
                {
                     No=3, Name="Romance", Id=2
                }
                ,

                new Genre()
                {
                     No=3, Name="Satire", Id=2
                },

                new Genre()
                {
                     No=3, Name="Children's", Id=2
                }
            };
            BookWindow bookWindow = new BookWindow(bookViewModel);
            bookWindow.ShowDialog();
        }
    }
}
