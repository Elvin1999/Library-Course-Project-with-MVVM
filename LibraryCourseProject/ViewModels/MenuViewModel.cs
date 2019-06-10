using LibraryCourseProject.Commands.MenuSectionCommands;
using LibraryCourseProject.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace LibraryCourseProject.ViewModels
{
    public class MenuViewModel : BaseViewModel
    {
        public UsersSectionCommand UsersSectionCommand => new UsersSectionCommand(this);
        public BookSectionCommand BookSectionCommand => new BookSectionCommand(this);
        public FilialSectionCommand FilialSectionCommand => new FilialSectionCommand(this);
        public ClientSectionCommand ClientSectionCommand => new ClientSectionCommand(this);
        public WorkerSectionCommand WorkerSectionCommand => new WorkerSectionCommand(this);
        public LanguageCommand LanguageCommand => new LanguageCommand(this);
        public User CurrentUser { get; set; }
        private int state = 1;

        public MenuViewModel(MainWindow mainWindow)
        {
            MainWindow = mainWindow;
        }

        public MainWindow MainWindow { get; set; }

        public int State
        {
            get
            {
                return state;
            }
            set
            {
                state = value;
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(State)));
            }
        }
    }
}
