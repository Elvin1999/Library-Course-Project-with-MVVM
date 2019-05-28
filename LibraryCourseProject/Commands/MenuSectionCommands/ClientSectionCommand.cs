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

namespace LibraryCourseProject.Commands.MenuSectionCommands
{
    public class ClientSectionCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        public MenuViewModel MenuViewModel { get; set; }
        public ClientSectionCommand(MenuViewModel menuViewModel)
        {
            MenuViewModel = menuViewModel;
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            ClientViewModel clientViewModel = new ClientViewModel();
            List<Client> items = new List<Client>();
            try
            {

                items = App.Config.DeserializeClientsFromJson();
            }
            catch (Exception ex)
            {
            }
            if (items != null)
            {

                clientViewModel.AllClients = new ObservableCollection<Entities.Client>(items);
            }
            ClientWindow clientWindow = new ClientWindow(clientViewModel);
            clientWindow.ShowDialog();
        }
    }
}
