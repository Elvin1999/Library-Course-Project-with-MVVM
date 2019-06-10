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
        public MainViewModel(MainWindow mainWindow)
        {
            MainWindow = mainWindow;
           
        }

        public MainWindow MainWindow { get; set; }
    }
}
