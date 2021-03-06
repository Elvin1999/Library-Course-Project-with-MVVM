﻿using LibraryCourseProject.Domain.AdditionalClasses;
using LibraryCourseProject.Entities;
using LibraryCourseProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace LibraryCourseProject.Commands.UserSectionCommands
{
    public class AddCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        public UserViewModel UserViewModel { get; set; }
        public AddCommand(UserViewModel UserViewModel)
        {
            this.UserViewModel = UserViewModel;
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }
        public void Execute(object parameter)
        {
            var passwordFromClient = (parameter as PasswordBox).Password;
            HashHelper hashHelper = new HashHelper();
            var hashpassword = hashHelper.GetHashOfString(passwordFromClient);
            MessageBox.Show(hashpassword);
            UserViewModel.CurrentUser.Password = hashpassword;
            LogUpHelper logupHelper = new LogUpHelper();
            var username = UserViewModel.CurrentUser.Username;
            var email = UserViewModel.CurrentUser.Email;
            var isExistUsername = logupHelper.IsExistUsername(username);
            var IsExistEmail = logupHelper.IsExistEmail(email);
            bool isAccessable = true;
            var isFullRequestingplaces = logupHelper.IsFullRequestingPlaces(username, email, passwordFromClient);
            if (isFullRequestingplaces)
            {
                if (IsExistEmail)
                {
                    MessageBox.Show("This email is already exist .");
                    isAccessable = false;
                }
                if (isExistUsername)
                {
                    MessageBox.Show("This username is already exist .");
                    isAccessable = false;
                }
            }
            else
            {
                isAccessable = false;
                MessageBox.Show("You did not fill username,email and password places");
            }
            if (isAccessable)
            {

                if (UserViewModel.AllUsers == null)
                {
                    UserViewModel.AllUsers = new ObservableCollection<User>();
                }
                if (UserViewModel.AllUsers.Count == 0)
                {
                    UserViewModel.CurrentUser.Id = 0;
                    UserViewModel.CurrentUser.No = 0;
                }
                else if (UserViewModel.AllUsers.Count != 0)
                {
                    int index = UserViewModel.AllUsers.Count - 1;
                    int newID = UserViewModel.AllUsers[index].Id + 1;
                    UserViewModel.CurrentUser.Id = newID;
                    UserViewModel.CurrentUser.No = newID;
                }
                var item = UserViewModel.AllUsers.FirstOrDefault(x => x.Id == UserViewModel.CurrentUser.Id);

                if (item == null)
                {
                    Permission permission = UserViewModel.CurrentUser.Permission;
                    App.DB.PermissionRepository.AddData(permission);
                    var newitem = UserViewModel.CurrentUser;     
                    App.DB.UserRepository.AddData(newitem);
                    UserViewModel.AllUsers = App.DB.UserRepository.GetAllData();
                    UserViewModel.SelectedUser = new User();
                    MessageBoxResult add = MessageBox.Show("Added");
                    UserViewModel.CurrentUser = new User();
                    UserViewModel.CurrentUser.Password = String.Empty;
                    UserViewModel.SelectedUser = new User();
                }
                else
                {
                    MessageBoxResult add = MessageBox.Show("Can not add this item");
                }
            }


        }
    }
}
