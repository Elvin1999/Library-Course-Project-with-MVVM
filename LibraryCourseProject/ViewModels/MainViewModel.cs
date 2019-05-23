using LibraryCourseProject.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace LibraryCourseProject.ViewModels
{
    public class MainViewModel:BaseViewModel
    {
        public RegisterCommand RegisterCommand => new RegisterCommand(this);
        public LoginCommand LoginCommand => new LoginCommand(this);
        public Grid MainGrid { get; set; }
    }
}
