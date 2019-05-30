using LibraryCourseProject.Commands.ClientSectionCommands;
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
    public class ClientViewModel : BaseViewModel
    {
        public AddCommand AddCommand => new AddCommand(this);
        public DeleteCommand DeleteCommand => new DeleteCommand(this);
        public UpdateCommand UpdateCommand => new UpdateCommand(this);
        private ObservableCollection<Client> allClients;
        public ObservableCollection<Client> AllClients
        {
            get
            {
                return allClients;
            }
            set
            {
                allClients = value;
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(AllClients)));
            }
        }
        public ClientViewModel()
        {
            CurrentClient = new Client();
        }
        private Client currentClient;
        public Client CurrentClient
        {
            get
            {
                return currentClient;
            }
            set
            {
                currentClient = value;
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(CurrentClient)));
            }
        }
        private int state = 1;

        public int State
        {
            get
            {
                return state;
            }
            set
            {
                state = value;
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(State)));
            }
        }
        private Client selectedClient;
        public Client SelectedClient
        {
            get
            {
                return selectedClient;
            }
            set
            {
                selectedClient = value;
                if (value != null)
                {
                    CurrentClient = SelectedClient.Clone();
                }
                if (SelectedClient != null)
                {
                    State = 2;
                }
                else
                {
                    State = 1;
                }
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(SelectedClient)));
            }
        }
    }
}


