using LibraryCourseProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCourseProject.Commands
{
    public class LoadCommand : BaseCommand
    {
        public LoadCommand(MainViewModel MainVM) : base(MainVM) { }

        public override void Execute(object parameter)
        {

        }
    }
}
