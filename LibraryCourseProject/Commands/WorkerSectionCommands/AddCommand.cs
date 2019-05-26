﻿using LibraryCourseProject.Entities;
using LibraryCourseProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace LibraryCourseProject.Commands.WorkerSectionCommands
{
    public class AddCommand : ICommand
    {
        public WorkerViewModel WorkerViewModel { get; set; }       
        public AddCommand(WorkerViewModel workerViewModel)
        {
            WorkerViewModel = workerViewModel;
        }
        public event EventHandler CanExecuteChanged;
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if (WorkerViewModel.AllWorkers == null)
            {
                WorkerViewModel.AllWorkers = new ObservableCollection<Worker>();
            }
            if (WorkerViewModel.AllWorkers.Count == 0)
            {
                WorkerViewModel.CurrentWorker.Id = 0;
                WorkerViewModel.CurrentWorker.No = 0;
            }
            else if (WorkerViewModel.AllWorkers.Count != 0)
            {
                int index = WorkerViewModel.AllWorkers.Count - 1;
                int newID = WorkerViewModel.AllWorkers[index].Id + 1;
                WorkerViewModel.CurrentWorker.Id = newID;
                WorkerViewModel.CurrentWorker.No = newID;
            }
            var item = WorkerViewModel.AllWorkers.FirstOrDefault(x => x.Id == WorkerViewModel.CurrentWorker.Id);

            if (item == null)
            {

                WorkerViewModel.AllWorkers.Add(WorkerViewModel.CurrentWorker);
                MessageBoxResult add = MessageBox.Show("Added");
                WorkerViewModel.CurrentWorker = new Worker();
                WorkerViewModel.SelectedWorker = new Worker();
            }
            else
            {
                MessageBoxResult add = MessageBox.Show("Can not add this item, you can only update and delete");
            }
        }
    }
}