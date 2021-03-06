﻿using LibraryCourseProject.Entities;
using LibraryCourseProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace LibraryCourseProject.Commands.BookSectionCommands
{
    public class DeleteCommand : ICommand
    {
        public DeleteCommand(BookViewModel bookViewModel)
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
            var item = BookViewModel.SelectedBook;
            App.DB.BookRepository.DeleteData(item);
            BookViewModel.AllBooks = App.DB.BookRepository.GetAllData();
            BookViewModel.SelectedBook = new Book();
            BookViewModel.State = 1;
        }
    }
}
