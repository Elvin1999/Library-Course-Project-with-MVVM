using LibraryCourseProject.Commands.WorkerSectionCommands;
using LibraryCourseProject.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCourseProject.ViewModels
{
   public class WorkerViewModel:BaseViewModel
    {
        public AddCommand AddCommand => new AddCommand(this);
        public DeleteCommand DeleteCommand => new DeleteCommand(this);
        public UpdateCommand UpdateCommand => new UpdateCommand(this);
        public List<Filial> Filials { get; set; }
        private ObservableCollection<Worker> allWorkers;
        public ObservableCollection<Worker> AllWorkers
        {
            get
            {
                return allWorkers;
            }
            set
            {
                allWorkers = value;
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(AllWorkers)));
            }
        }
        public WorkerViewModel()
        {
            CurrentWorker = new Worker();
        }
        private Worker currentWorker;
        public Worker CurrentWorker
        {
            get
            {
                return currentWorker;
            }
            set
            {
                currentWorker = value;
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(CurrentWorker)));
            }
        }
    
        private Worker selectedWorker;
        public Worker SelectedWorker
        {
            get
            {
                return selectedWorker;
            }
            set
            {
                selectedWorker = value;
                if (value != null)
                {
                    CurrentWorker = SelectedWorker.Clone();
                }
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(SelectedWorker)));
            }
        }
    }
}
