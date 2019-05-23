using LibraryCourseProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace LibraryCourseProject.Commands
{
    public abstract class BaseCommand : ICommand
    {
        protected MainViewModel MainVM { get; set; }
        public BaseCommand(MainViewModel MainVM)
        {
            this.MainVM = MainVM;
        }


        public event EventHandler CanExecuteChanged;

        public virtual bool CanExecute(object parameter)
        {
            return true;
        }

        public abstract void Execute(object parameter);
    }
}
