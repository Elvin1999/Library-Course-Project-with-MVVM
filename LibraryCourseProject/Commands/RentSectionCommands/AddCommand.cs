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

namespace LibraryCourseProject.Commands.RentSectionCommands
{
    public class AddCommand : ICommand
    {
        public AddCommand(RentViewModel rentViewModel)
        {
            RentViewModel = rentViewModel;
        }
        public RentViewModel RentViewModel { get; set; }
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if (RentViewModel.AllRents == null)
            {
                RentViewModel.AllRents = new ObservableCollection<Rent>();
            }
            if (RentViewModel.AllRents.Count == 0)
            {
                RentViewModel.CurrentRent.Id = 0;
                RentViewModel.CurrentRent.No = 0;
            }
            else if (RentViewModel.AllRents.Count != 0)
            {
                int index = RentViewModel.AllRents.Count - 1;
                int newID = RentViewModel.AllRents[index].Id + 1;
                RentViewModel.CurrentRent.Id = newID;
                RentViewModel.CurrentRent.No = newID;
            }
            var item = RentViewModel.AllRents.FirstOrDefault(x => x.Id == RentViewModel.CurrentRent.Id);

            if (item == null)
            {
                RentViewModel.CurrentRent.Client = RentViewModel.ClientViewModel.SelectedClient;
                var rentitem = RentViewModel.CurrentRent;
                //rentitem.BookId = RentViewModel.CurrentRent.Book.Id;
                //rentitem.Book = null;
                //rentitem.UserId = RentViewModel.CurrentRent.User.Id;
                //rentitem.User = null;
                //rentitem.ClientId = RentViewModel.CurrentRent.Client.Id;
                //rentitem.Client = null;
                App.DB.RentRepository.AddData(rentitem);
                RentViewModel.AllRents = App.DB.RentRepository.GetAllData();
                MessageBoxResult add = MessageBox.Show("Added");
                RentViewModel.CurrentRent = new Rent();
            }
            else
            {
                MessageBoxResult add = MessageBox.Show("Can not add this item, you can only update and delete");
            }
        }
    }
}
