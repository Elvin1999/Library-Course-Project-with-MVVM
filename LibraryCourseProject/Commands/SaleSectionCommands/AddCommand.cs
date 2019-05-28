using LibraryCourseProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            throw new NotImplementedException();
        }
    }
}
