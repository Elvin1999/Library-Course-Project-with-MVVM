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

namespace LibraryCourseProject.Commands.FilialSectionCommands
{
   public class AddCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        public FilialViewModel FilialViewModel { get; set; }
        public AddCommand(FilialViewModel filialViewModel)
        {
            FilialViewModel = filialViewModel;
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if (FilialViewModel.AllFilials == null)
            {
                FilialViewModel.AllFilials = new ObservableCollection<Filial>();
            }
            if (FilialViewModel.AllFilials.Count == 0)
            {
                FilialViewModel.CurrentFilial.Id = 0;
                FilialViewModel.CurrentFilial.No = 0;
            }
            else if (FilialViewModel.AllFilials.Count != 0)
            {
                int index = FilialViewModel.AllFilials.Count - 1;
                int newID = FilialViewModel.AllFilials[index].Id + 1;
                FilialViewModel.CurrentFilial.Id = newID;
                FilialViewModel.CurrentFilial.No = newID;
            }
            var item = FilialViewModel.AllFilials.FirstOrDefault(x => x.Id == FilialViewModel.CurrentFilial.Id);

            if (item == null)
            {
                var newitem = FilialViewModel.CurrentFilial;
                FilialViewModel.AllFilials.Add(newitem);
                App.Config.Filials.Add(newitem);
                App.Config.SeriailizeFilialsToJson();
                MessageBoxResult add = MessageBox.Show("Added");
                FilialViewModel.CurrentFilial = new Filial();
                FilialViewModel.SelectedFilial = new Filial();
            }
            else
            {
                MessageBoxResult add = MessageBox.Show("Can not add this item, you can only update and delete");
            }
        }
    }
}
