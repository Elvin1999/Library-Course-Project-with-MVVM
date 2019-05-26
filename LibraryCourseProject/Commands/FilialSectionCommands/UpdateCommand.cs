using LibraryCourseProject.Entities;
using LibraryCourseProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace LibraryCourseProject.Commands.FilialSectionCommands
{
    public class UpdateCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        public FilialViewModel FilialViewModel { get; set; }
        public UpdateCommand(FilialViewModel filialViewModel)
        {
            FilialViewModel = filialViewModel;
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {

            var item = FilialViewModel.AllFilials.FirstOrDefault(x => x.Id == FilialViewModel.CurrentFilial.Id);

            if (item != null)
            {
                var index = FilialViewModel.AllFilials.IndexOf(item);
                FilialViewModel.AllFilials[index] = FilialViewModel.CurrentFilial;
                MessageBoxResult update = MessageBox.Show("updated");
                FilialViewModel.CurrentFilial = new Filial();
                FilialViewModel.SelectedFilial = new Filial();
            }
            else
            {
                MessageBox.Show("You can not this user");
            }
        }
    }
}
