using LibraryCourseProject.Entities;
using LibraryCourseProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace LibraryCourseProject.Commands.ClientSectionCommands
{
    public class DeleteCommand : ICommand
    {
        public DeleteCommand(ClientViewModel clientViewModel)
        {
            ClientViewModel = clientViewModel;
        }

        public event EventHandler CanExecuteChanged;
        public ClientViewModel ClientViewModel { get; set; }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            var item = ClientViewModel.SelectedClient;
            ClientViewModel.AllClients.Remove(item);
            ClientViewModel.SelectedClient = new Client();
        }
    }
}
