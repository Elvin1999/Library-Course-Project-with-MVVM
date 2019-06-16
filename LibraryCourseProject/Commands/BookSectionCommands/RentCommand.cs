using LibraryCourseProject.Entities;
using LibraryCourseProject.ViewModels;
using LibraryCourseProject.Views;
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
    public class RentCommand : ICommand
    {

        public BookViewModel BookViewModel { get; set; }
        public RentCommand(BookViewModel bookViewModel)
        {
            BookViewModel = bookViewModel;
        }
        public event EventHandler CanExecuteChanged;
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {


            List<User> users = new List<User>();
            try
            {
                
                users = new List<User>(App.DB.UserRepository.GetAllData());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            RentViewModel rentViewModel = new RentViewModel()
            {
                AllRents = App.DB.RentRepository.GetAllData()
            };
            try
            {
                rentViewModel.ClientViewModel = new ClientViewModel();
                var clients = App.DB.ClientRepository.GetAllData();
                rentViewModel.ClientViewModel.AllClients = clients;
            }
            catch (Exception)
            {
            }
            Book book = new Book();
            book = BookViewModel.SelectedBook;
            try
            {
                rentViewModel.CurrentRent = new Rent()
                {
                    Book = book,
                    Client = rentViewModel.ClientViewModel.SelectedClient,
                    RentDateTime = DateTime.Now,
                    ExactDateTime = DateTime.Now,
                    Note = "",
                    No = 1,                    
                    Id = 1,
                    User = BookViewModel.CurrentUser
                };
                rentViewModel.CurrentRent.RealPrice = book.SalePrice;
                if (book.SalePrice > 10)
                {
                    rentViewModel.CurrentRent.PricePerDay = book.SalePrice / 10;
                }
                else
                {
                    rentViewModel.CurrentRent.PricePerDay = 1;
                }
            }
            catch (Exception)
            {

            }
            RentWindow rentWindow = new RentWindow(rentViewModel);
            rentWindow.ShowDialog();
        }
    }
}
