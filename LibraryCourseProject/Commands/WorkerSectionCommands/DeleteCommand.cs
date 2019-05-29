using LibraryCourseProject.Entities;
using LibraryCourseProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace LibraryCourseProject.Commands.WorkerSectionCommands
{
    public class DeleteCommand : ICommand
    {
        public DeleteCommand(WorkerViewModel workerViewModel)
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
            var item = WorkerViewModel.SelectedWorker;
            WorkerViewModel.AllWorkers.Remove(item);
            App.Config.Workers = new List<Worker>(WorkerViewModel.AllWorkers);
            App.Config.SeriailizeWorkersToJson();
            WorkerViewModel.SelectedWorker = new Worker();
        }
    }
}
