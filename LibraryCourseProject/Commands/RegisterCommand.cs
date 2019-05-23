using LibraryCourseProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace LibraryCourseProject.Commands
{
    public class RegisterCommand : BaseCommand
    {
        public RegisterCommand(MainViewModel MainVM) : base(MainVM) { }        
        public override void Execute(object parameter)
        {
            MainVM.MainGrid.Children.Clear();
            MainVM.MainGrid.Children.Add(new RegisterUserControl());
        }
    }
}
