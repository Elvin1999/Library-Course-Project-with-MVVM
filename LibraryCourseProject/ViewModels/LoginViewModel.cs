﻿using LibraryCourseProject.Commands;
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
        public LoginCommand LoginCommand => new LoginCommand();
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
            Config config = new Config();
            string filename = "config.json";
            if (File.Exists(filename))
            {
                Users = config.DeserializeFromJson();
            }
            else
            {
                config.SeriailizeToJson();
            }
        }
    }
}
