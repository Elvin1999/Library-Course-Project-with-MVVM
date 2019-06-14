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
    public class WorkerSectionCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        public MenuViewModel MenuViewModel { get; set; }
        public WorkerSectionCommand(MenuViewModel menuViewModel)
        {
            MenuViewModel = menuViewModel;
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            WorkerViewModel workerViewModel = new WorkerViewModel();



            try
            {

            workerViewModel.AllWorkers = App.DB.WorkerRepository.GetAllData();
                workerViewModel.Filials = new List<Filial>(App.DB.FilialRepository.GetAllData());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //workerViewModel.Filials = new List<Filial>()
            //{
            //    new Filial()
            //    {
            //         Address="Nizami metrosu yaxinligi",
            //          Id=0,
            //           Name="Caspian plaza",
            //            No=0,
            //             Note="En boyuk filial",
            //              OpeningDate=DateTime.Now
            //    },
            //    new Filial()
            //    {
            //         Address="Ehmedli metrosu yaxinligi",
            //          Id=0,
            //           Name="Ehmedli",
            //            No=0,
            //             Note="En kichik filial",
            //              OpeningDate=DateTime.Now
            //    },
            //    new Filial()
            //    {
            //         Address="Gence",
            //          Id=0,
            //           Name="LIB plaza",
            //            No=0,
            //             Note="none",
            //              OpeningDate=DateTime.Now
            //    }
            //};
            WorkerWindow workerWindow = new WorkerWindow(workerViewModel);
            workerWindow.ShowDialog();
        }
    }
}
