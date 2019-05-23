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
    public class LoginCommand : BaseCommand
    {
        public LoginCommand(MainViewModel MainVM) : base(MainVM) { }
        

        public override void Execute(object parameter)
        {
            MessageBox.Show("TestLogin");
        }
    }
}
