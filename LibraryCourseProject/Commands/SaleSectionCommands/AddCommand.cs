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

namespace LibraryCourseProject.Commands.SaleSectionCommands
{
    public class AddCommand : ICommand
    {
        public AddCommand(SaleViewModel saleViewModel)
        {
            SaleViewModel = saleViewModel;
        }

        public event EventHandler CanExecuteChanged;
        public SaleViewModel SaleViewModel { get; set; }
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {

            if (SaleViewModel.AllSales == null)
            {
                SaleViewModel.AllSales = new ObservableCollection<Sale>();
            }
            if (SaleViewModel.AllSales.Count == 0)
            {
                SaleViewModel.CurrentSale.Id = 0;
                SaleViewModel.CurrentSale.No = 0;
            }
            else if (SaleViewModel.AllSales.Count != 0)
            {
                int index = SaleViewModel.AllSales.Count - 1;
                int newID = SaleViewModel.AllSales[index].Id + 1;
                SaleViewModel.CurrentSale.Id = newID;
                SaleViewModel.CurrentSale.No = newID;
            }
            var item = SaleViewModel.AllSales.FirstOrDefault(x => x.Id == SaleViewModel.CurrentSale.Id);

            if (item == null)
            {
                SaleViewModel.CurrentSale.Client = SaleViewModel.ClientViewModel.SelectedClient;
                var saleitem = SaleViewModel.CurrentSale;
                App.DB.SaleRepository.AddData(saleitem);
                SaleViewModel.AllSales = App.DB.SaleRepository.GetAllData();
                MessageBoxResult add = MessageBox.Show("Added");
                SaleViewModel.CurrentSale = new Sale();
            }
            else
            {
                MessageBoxResult add = MessageBox.Show("Can not add this item");
            }
        }
    }
}
