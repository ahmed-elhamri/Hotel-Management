using Hotel_Management.Commands;
using Hotel_Management.DAO;
using Hotel_Management.Models;
using Hotel_Management.Views;
using Hotel_Management.Views.Admin;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Hotel_Management.ViewModels
{
    public class EmployesManagementViewModel
    {
        private readonly UserDAO _userDao;
        private Window _currentWindow;
        private string _tempPassword;

        public ObservableCollection<User> Users { get; set; }
        public User CurrentUser { get; set; }

        public ICommand AddCommand { get; set; }
        public ICommand UpdateCommand { get; set; }
        public ICommand DeleteCommand { get; set; }
        public ICommand SaveCommand { get; set; }

        public EmployesManagementViewModel()
        {
            _userDao = new UserDAO();
            Users = new ObservableCollection<User>(_userDao.GetAllEmployes());

            AddCommand = new RelayCommand(_ => OpenPopup(new User()));
            UpdateCommand = new RelayCommand(user => OpenPopup((User)user));
            DeleteCommand = new RelayCommand(user => DeleteUser((User)user));
            SaveCommand = new RelayCommand(_ => SaveUser());
        }

        private void OpenPopup(User user)
        {
            CurrentUser = user;
            // Store the current hashed password if it's an update
            _tempPassword = user.Id != 0 ? user.Password : null;
            // Clear password in the UI
            CurrentUser.Password = string.Empty;

            _currentWindow = new AddUpdateClientWindow { DataContext = this };
            _currentWindow.ShowDialog();
        }

        private void DeleteUser(User user)
        {
            _userDao.DeleteUser(user);
            Users.Remove(user);
        }

        private void SaveUser()
        {
            // Only hash password if it's not empty
            if (!string.IsNullOrEmpty(CurrentUser.Password))
            {
                CurrentUser.Password = BCrypt.Net.BCrypt.HashPassword(CurrentUser.Password);
            }
            else if (CurrentUser.Id != 0)
            {
                // If updating and password is empty, restore the original password
                CurrentUser.Password = _tempPassword;
            }

            if (CurrentUser.Id == 0)
            {
                CurrentUser.Role = UserRole.Employe;
                _userDao.AddUser(CurrentUser);
                Users.Add(CurrentUser);
            }
            else
            {
                _userDao.UpdateUser(CurrentUser);
                // Update the item in the collection
                var index = Users.IndexOf(Users.First(u => u.Id == CurrentUser.Id));
                Users[index] = CurrentUser;
            }

            _currentWindow?.Close();
        }
    }
}
