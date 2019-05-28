using LibraryCourseProject.Commands.SaleSectionCommands;
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
   public class SaleViewModel:BaseViewModel
    {
        public AddCommand AddCommand => new AddCommand(this);
        public DeleteCommand DeleteCommand => new DeleteCommand(this);
        public UpdateCommand UpdateCommand => new UpdateCommand(this);
        //public ObservableCollection<Client> Clients { get; set; }
        public ClientViewModel ClientViewModel { get; set; }
        private ObservableCollection<Sale> allSales;
        public ObservableCollection<Sale> AllSales
        {
            get
            {
                return allSales;
            }
            set
            {
                allSales = value;
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(AllSales)));
            }
        }
        public SaleViewModel()
        {
            CurrentSale = new Sale();
        }
        private Sale currentSale;
        public Sale CurrentSale
        {
            get
            {
                return currentSale;
            }
            set
            {
                currentSale = value;
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(CurrentSale)));
            }
        }

        private Sale selectedSale;
        public Sale SelectedSale
        {
            get
            {
                return selectedSale;
            }
            set
            {
                selectedSale = value;
                if (value != null)
                {
                    CurrentSale = SelectedSale.Clone();
                }
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(SelectedSale)));
            }
        }
    }
}
