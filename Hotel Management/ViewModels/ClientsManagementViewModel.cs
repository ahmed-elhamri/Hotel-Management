using Hotel_Management.Commands;
using Hotel_Management.DAO;
using Hotel_Management.Models;
using Hotel_Management.Views;
using Hotel_Management.Views.Admin;
using Hotel_Management.Views.Admin.Employes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Hotel_Management.ViewModels
{
    public class ClientsManagementViewModel
    {
        private readonly UserDAO _userDao;
        private Window _currentWindow;
        private string _tempPassword;
        private ObservableCollection<User> _users;
        private ObservableCollection<User> _filteredUsers;
        private string _searchQuery;

        public ObservableCollection<User> Users
        {
            get => _users;
            set
            {
                _users = value;
                OnPropertyChanged(nameof(Users));
            }
        }

        public ObservableCollection<User> FilteredUsers
        {
            get => _filteredUsers;
            set
            {
                _filteredUsers = value;
                OnPropertyChanged(nameof(FilteredUsers));
            }
        }

        public string SearchQuery
        {
            get => _searchQuery;
            set
            {
                _searchQuery = value;
                OnPropertyChanged(nameof(SearchQuery));
                FilterUsers();
            }
        }

        public User CurrentUser { get; set; }
        public bool IsPasswordVisible { get; set; }

        public ICommand AddCommand { get; set; }
        public ICommand UpdateCommand { get; set; }
        public ICommand DeleteCommand { get; set; }
        public ICommand SaveCommand { get; set; }
        public ICommand ExportExcelCommand { get; set; }

        public ClientsManagementViewModel()
        {
            _userDao = new UserDAO();
            LoadUsers();

            AddCommand = new RelayCommand(_ => OpenPopup(new User()));
            UpdateCommand = new RelayCommand(user => OpenPopup((User)user));
            DeleteCommand = new RelayCommand(user => DeleteUser((User)user));
            SaveCommand = new RelayCommand(_ => SaveUser());
            ExportExcelCommand = new RelayCommand(_ => ExportToExcel());
        }

        private void LoadUsers()
        {
            var usersList = _userDao.GetAllClients();
            Users = new ObservableCollection<User>(usersList);
            FilteredUsers = new ObservableCollection<User>(Users);
        }

        private void OpenPopup(User user)
        {
            CurrentUser = user;
            _tempPassword = user.Id != 0 ? user.Password : null;
            IsPasswordVisible = user.Id != 0; // Show password field only for existing users
            CurrentUser.Password = string.Empty; // Clear password field for UI

            _currentWindow = new AddUpdateEmployeWindow { DataContext = this };
            _currentWindow.ShowDialog();
        }

        private void DeleteUser(User user)
        {
            MessageBoxResult response = MessageBox.Show("Voulez vous supprimer ce client", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (response == MessageBoxResult.No)
            {
                return;
            }
            _userDao.DeleteUser(user);
            Users.Remove(user);
        }

        private void FilterUsers()
        {
            if (string.IsNullOrWhiteSpace(SearchQuery))
            {
                FilteredUsers = new ObservableCollection<User>(Users);
            }
            else
            {
                var filtered = Users.Where(u =>
                    u.LastName != null && u.LastName.Contains(SearchQuery, StringComparison.OrdinalIgnoreCase)
                ).ToList();

                FilteredUsers = new ObservableCollection<User>(filtered);
            }
        }

        private void ExportToExcel()
        {
            try
            {
                _userDao.ExportExcel(Users.ToList());
                MessageBox.Show("Excel file exported successfully!", "Success",
                    MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error exporting to Excel: {ex.Message}", "Error",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void SaveUser()
        {
            // Basic validation checks
            if (string.IsNullOrWhiteSpace(CurrentUser.FirstName))
            {
                MessageBox.Show("Le prénom est obligatoire.", "Erreur de validation", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(CurrentUser.LastName))
            {
                MessageBox.Show("Le nom est obligatoire.", "Erreur de validation", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(CurrentUser.Email) || !IsValidEmail(CurrentUser.Email))
            {
                MessageBox.Show("Veuillez entrer une adresse email valide.", "Erreur de validation", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(CurrentUser.PhoneNumber) || !IsValidPhone(CurrentUser.PhoneNumber))
            {
                MessageBox.Show("Veuillez entrer un numéro de téléphone valide.", "Erreur de validation", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            try
            {
                bool isNewUser = CurrentUser.Id == 0;

                if (isNewUser)
                {
                    // Set default password for new user
                    CurrentUser.Password = BCrypt.Net.BCrypt.HashPassword("DefaultPassword123");
                    CurrentUser.Role = UserRole.Client;
                    _userDao.AddUser(CurrentUser);

                    // Reload the full list to ensure we have the correct ID
                    LoadUsers();
                }
                else
                {
                    // For existing user, only update password if a new one was provided
                    if (!string.IsNullOrWhiteSpace(CurrentUser.Password))
                    {
                        if (CurrentUser.Password.Length < 6)
                        {
                            MessageBox.Show("Le mot de passe doit contenir au moins 6 caractères.", "Erreur de validation", MessageBoxButton.OK, MessageBoxImage.Error);
                            return;
                        }
                        CurrentUser.Password = BCrypt.Net.BCrypt.HashPassword(CurrentUser.Password);
                    }
                    else
                    {
                        CurrentUser.Password = _tempPassword;
                    }

                    _userDao.UpdateUser(CurrentUser);
                    LoadUsers();
                }

                _currentWindow?.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'enregistrement: {ex.Message}", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private bool IsValidPhone(string phoneNumber)
        {
            return phoneNumber.All(char.IsDigit) && phoneNumber.Length >= 10; // Adjust length if needed
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
