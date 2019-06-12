using LibraryCourseProject.Commands;
using LibraryCourseProject.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCourseProject.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        public MainWindow MainWindow { get; set; }

        public LoginCommand LoginCommand => new LoginCommand(this);
        public List<User> Users { get; set; }
        private string username;
        public string Username
        {
            get
            {
                return username;
            }
            set
            {
                username = value;
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(Username)));
            }
        }
        private string password;

        public LoginViewModel(MainWindow mainWindow)
        {
            MainWindow = mainWindow;
        }

        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(Password)));
            }
        }
        public void SetUsers()
        {
            
            string filename = "config.json";
            if (File.Exists(filename))
            {
                Users = App.Config.DeserializeFromJson();
            }
            else
            {
                User admin = new User()
                {
                    Email = "admin@gmail.com",
                    Id = 1,
                    No = 1,
                    Note = "none",
                    Password = "admin",
                    Permission = new Permission()
                    {
                        No = 1,
                        Id = 1,
                        CanCreateBook = true,
                        CanCreateClient = true,
                        CanCreateFilial = true,
                        CanCreateUser = true,
                        CanCreateWorker = true
                    },
                    PermissionId = 1,
                    Username = "admin"

                };
                App.Config.Users = new List<User>();
                App.Config.Users.Add(admin);
                Users = App.Config.Users;
                App.Config.SeriailizeToJson();
            }
        }
    }
}
