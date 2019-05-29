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
    public class SellCommand : ICommand
    {
        public SellCommand(BookViewModel bookViewModel)
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
            List<User> users = new List<User>();
            try
            {

                users = App.Config.DeserializeFromJson();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            SaleViewModel saleViewModel = new SaleViewModel()
            {
                AllSales = new ObservableCollection<Sale>()
            };
            try
            {
                saleViewModel.ClientViewModel = new ClientViewModel();
                var clients = App.Config.DeserializeClientsFromJson();
                saleViewModel.ClientViewModel.AllClients = new ObservableCollection<Client>(clients);
            }
            catch (Exception)
            {
            }
            Book book = new Book();
            book = BookViewModel.SelectedBook;
            try
            {
                saleViewModel.CurrentSale = new Sale()
                {
                    Book = book,
                    Client = saleViewModel.ClientViewModel.SelectedClient,
                    SaleDateTime = DateTime.Now,
                    Note = "",
                    No = 1,
                    RealPrice = book.PurchasePrice,
                    SalePrice = book.SalePrice,
                    Id = 1, 
                    User = users[0]//current user goturmek lazimdi
                };
            }
            catch (Exception)
            {

            }

            SaleWindow saleWindow = new SaleWindow(saleViewModel);
            saleWindow.ShowDialog();

        }
    }
}
