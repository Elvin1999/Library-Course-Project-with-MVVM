using LibraryCourseProject.Commands.MenuSectionCommands;
using LibraryCourseProject.Entities;
using System;
using System.Collections.Generic;
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
        public User CurrentUser { get; set; }
    }
}
