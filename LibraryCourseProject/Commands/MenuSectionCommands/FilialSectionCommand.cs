using LibraryCourseProject.Entities;
using LibraryCourseProject.ViewModels;
using LibraryCourseProject.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace LibraryCourseProject.Commands.MenuSectionCommands
{
    public class FilialSectionCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public MenuViewModel MenuViewModel { get; set; }

        public FilialSectionCommand(MenuViewModel menuViewModel)
        {
            MenuViewModel = MenuViewModel;
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            FilialViewModel filialViewModel = new FilialViewModel();
            List<Filial> items = new List<Filial>();
            try
            {

                items = new List<Filial>(App.DB.FilialRepository.GetAllData());
            }
            catch (Exception)
            {
            }
            if (items != null)
            {

                filialViewModel.AllFilials = new ObservableCollection<Filial>(items);
            }
            FilialWindow filialWindow = new FilialWindow(filialViewModel);
            filialWindow.ShowDialog();
        }
    }
}
