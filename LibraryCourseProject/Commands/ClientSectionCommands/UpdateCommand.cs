using LibraryCourseProject.Entities;
using LibraryCourseProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace LibraryCourseProject.Commands.ClientSectionCommands
{
    public class UpdateCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        public ClientViewModel ClientViewModel { get; set; }
        public UpdateCommand(ClientViewModel clientViewModel)
        {
            ClientViewModel = clientViewModel;
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            var item = ClientViewModel.CurrentClient;
            if (item != null)
            {
                App.DB.ClientRepository.UpdateData(item);
                ClientViewModel.AllClients = App.DB.ClientRepository.GetAllData();
                MessageBoxResult update = MessageBox.Show("updated");
                ClientViewModel.CurrentClient = new Client();
                ClientViewModel.SelectedClient = new Client();
            }
            else
            {
                MessageBox.Show("You can not update this client");
            }
        }
    }
}
