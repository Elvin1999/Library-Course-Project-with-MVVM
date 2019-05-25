using LibraryCourseProject.Entities;
using LibraryCourseProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
     
            //if (FilialViewModel.AllFilials == null)
            //{
            //    FilialViewModel.AllFilials = new ObservableCollection<Filial>();
            //}
            //if (FilialViewModel.AllFilials.Count == 0)
            //{
            //    FilialViewModel.CurrentFilial.Id = 0;
            //    FilialViewModel.CurrentFilial.No = 0;
            //}
            //else if (FilialViewModel.AllFilials.Count != 0)
            //{
            //    int index = Fil.AllUsers.Count - 1;
            //    int newID = UserViewModel.AllUsers[index].Id + 1;
            //    UserViewModel.CurrentUser.Id = newID;
            //    UserViewModel.CurrentUser.No = newID;
            //}
            //var item = UserViewModel.AllUsers.FirstOrDefault(x => x.Id == UserViewModel.CurrentUser.Id);

            //if (item == null)
            //{

            //    UserViewModel.AllUsers.Add(UserViewModel.CurrentUser);
            //    MessageBoxResult add = MessageBox.Show("Added");
            //    UserViewModel.CurrentUser = new User();
            //    UserViewModel.CurrentUser.Password = String.Empty;
            //    //UserViewModel.CurrentUser.Permission = new Permission();
            //    UserViewModel.SelectedUser = new User();
            //}
            //else
            //{
            //    MessageBoxResult add = MessageBox.Show("Can not add this item, you can only update and delete");
            //}
        }
    }
}
