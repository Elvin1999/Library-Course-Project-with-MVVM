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
                var clients = App.Config.DeserializeClientsFromJson();
                saleViewModel.Clients = new ObservableCollection<Client>(clients);
            }
            catch (Exception)
            {

            }
            saleViewModel.CurrentSale = new Sale()
            {
                Book = BookViewModel.SelectedBook,
                //Client = clientViewModel.SelectedClient,
                SaleDateTime = DateTime.Now,
                Note = "",
                No = 1,
                RealPrice = 12.5,
                SalePrice = 18.9,
                Id = 1,
                User = users[1]
            };
            SaleWindow saleWindow = new SaleWindow(saleViewModel);
            saleWindow.ShowDialog();

        }
    }
}
