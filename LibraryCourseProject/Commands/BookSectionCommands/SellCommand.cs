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
            ClientViewModel clientViewModel = new ClientViewModel();
            clientViewModel.AllClients = new ObservableCollection<Client>()
            {
                 new Client()
                 {
                      ConnectionTime=DateTime.Now,
                       Id=1,
                        Name="Yusif",
                         No=1,
                          Note="",
                           PhoneNumber="+994515448487",
                            Surname="Yusifli"
                 }
            };
            SaleViewModel saleViewModel = new SaleViewModel()
            {
                AllSales = new ObservableCollection<Sale>()
            };
            saleViewModel.CurrentSale = new Sale()
            {
                Book = BookViewModel.SelectedBook,
                Client = clientViewModel.AllClients[0],
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
