using LibraryCourseProject.Commands.RentSectionCommands;
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
   public class RentViewModel:BaseViewModel
    {
        public AddCommand AddCommand => new AddCommand(this);
        public ClientViewModel ClientViewModel { get; set; }
        private ObservableCollection<Rent> allRents;
        public ObservableCollection<Rent> AllRents
        {
            get
            {
                return allRents;
            }
            set
            {
                allRents = value;
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(AllRents)));
            }
        }
        public RentViewModel()
        {
            CurrentRent = new Rent();
        }
        private Rent currentRent;
        public Rent CurrentRent
        {
            get
            {
                return currentRent;
            }
            set
            {
                currentRent = value;
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(CurrentRent)));
            }
        }

        private Rent selectedRent;
        public Rent SelectedRent
        {
            get
            {
                return selectedRent;
            }
            set
            {
                selectedRent = value;
                if (value != null)
                {
                    CurrentRent = SelectedRent.Clone();
                }
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(SelectedRent)));
            }
        }
    }
}
