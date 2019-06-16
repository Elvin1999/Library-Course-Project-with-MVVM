using LibraryCourseProject.Entities;
using LibraryCourseProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace LibraryCourseProject.Commands.WorkerSectionCommands
{
    public class UpdateCommand : ICommand
    {
        public UpdateCommand(WorkerViewModel workerViewModel)
        {
            WorkerViewModel = workerViewModel;
        }
        public event EventHandler CanExecuteChanged;
        public WorkerViewModel WorkerViewModel { get; set; }
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {

            var item = WorkerViewModel.AllWorkers.FirstOrDefault(x => x.Id == WorkerViewModel.CurrentWorker.Id);

            if (item != null)
            {
                var index = WorkerViewModel.AllWorkers.IndexOf(item);
                App.DB.WorkerRepository.UpdateData(item);
                WorkerViewModel.AllWorkers = App.DB.WorkerRepository.GetAllData();
                MessageBoxResult update = MessageBox.Show("updated");
                WorkerViewModel.CurrentWorker = new Worker();
                WorkerViewModel.SelectedWorker = new Worker();
            }
            else
            {
                MessageBox.Show("You can not update this user");
            }
        }
    }
}
