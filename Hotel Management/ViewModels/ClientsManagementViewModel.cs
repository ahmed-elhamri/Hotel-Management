using Hotel_Management.Commands;
using Hotel_Management.DAO;
using Hotel_Management.Models;
using Hotel_Management.Views;
using Hotel_Management.Views.Admin;
using Hotel_Management.Views.Admin.Employes;
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
    public class ClientsManagementViewModel
    {
        private readonly UserDAO _userDao;
        private Window _currentWindow;
        private string _tempPassword;

        private string _searchQuery;
        public string SearchQuery
        {
            get => _searchQuery;
            set
            {
                _searchQuery = value;
                //OnPropertyChanged(nameof(SearchQuery));
                FilterClients(); // Automatically filter when the query changes
            }
        }

        public ObservableCollection<User> FilteredClients { get; set; }

        public ObservableCollection<User> Clients { get; set; }
        public User CurrentClient { get; set; }

        public ICommand AddCommand { get; set; }
        public ICommand UpdateCommand { get; set; }
        public ICommand DeleteCommand { get; set; }
        public ICommand SaveCommand { get; set; }
        public ICommand ExportExcelCommand { get; set; }


        public ClientsManagementViewModel()
        {
            _userDao = new UserDAO();
            Clients = new ObservableCollection<User>(_userDao.GetAllClients());
            FilteredClients = new ObservableCollection<User>(Clients);
            AddCommand = new RelayCommand(_ => OpenPopup(new User()));
            UpdateCommand = new RelayCommand(user => OpenPopup((User)user));
            DeleteCommand = new RelayCommand(user => DeleteUser((User)user));
            SaveCommand = new RelayCommand(_ => SaveUser());
            ExportExcelCommand = new RelayCommand(_ => ExportToExcel());
        }

        private void OpenPopup(User user)
        {
            CurrentClient = user;
            // Store the current hashed password if it's an update
            _tempPassword = user.Id != 0 ? user.Password : null;
            // Clear password in the UI
            CurrentClient.Password = string.Empty;

            _currentWindow = new AddUpdateEmployeWindow { DataContext = this };
            _currentWindow.ShowDialog();
        }

        private void DeleteUser(User user)
        {
            _userDao.DeleteUser(user);
            Clients.Remove(user);
        }

        private void FilterClients()
        {
            if (string.IsNullOrWhiteSpace(SearchQuery))
            {
                FilteredClients.Clear();
                foreach (var user in Clients)
                    FilteredClients.Add(user);
            }
            else
            {
                var filtered = Clients.Where(u =>
                    u.LastName != null && u.LastName.Contains(SearchQuery, StringComparison.OrdinalIgnoreCase)
                ).ToList();

                FilteredClients.Clear();
                foreach (var user in filtered)
                    FilteredClients.Add(user);
            }
        }

        private void ExportToExcel()
        {
            try
            {
                _userDao.ExportExcel(Clients.ToList());
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
            if (string.IsNullOrWhiteSpace(CurrentClient.FirstName))
            {
                MessageBox.Show("Le prénom est obligatoire.", "Erreur de validation", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(CurrentClient.LastName))
            {
                MessageBox.Show("Le nom est obligatoire.", "Erreur de validation", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(CurrentClient.Email) || !IsValidEmail(CurrentClient.Email))
            {
                MessageBox.Show("Veuillez entrer une adresse email valide.", "Erreur de validation", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(CurrentClient.PhoneNumber) || !IsValidPhone(CurrentClient.PhoneNumber))
            {
                MessageBox.Show("Veuillez entrer un numéro de téléphone valide.", "Erreur de validation", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (string.IsNullOrEmpty(CurrentClient.Password) && CurrentClient.Id == 0) // Check for password only on new users
            {
                MessageBox.Show("Le mot de passe est obligatoire.", "Erreur de validation", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (CurrentClient.Password.Length < 6 && CurrentClient.Id == 0) // Check length only on new passwords
            {
                MessageBox.Show("Le mot de passe doit contenir au moins 6 caractères.", "Erreur de validation", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            // Only hash password if it's not empty
            if (!string.IsNullOrEmpty(CurrentClient.Password))
            {
                CurrentClient.Password = BCrypt.Net.BCrypt.HashPassword(CurrentClient.Password);
            }
            else if (CurrentClient.Id != 0)
            {
                // If updating and password is empty, restore the original password
                CurrentClient.Password = _tempPassword;
            }

            if (CurrentClient.Id == 0)
            {
                CurrentClient.Role = UserRole.Employe;
                _userDao.AddUser(CurrentClient);
                Clients.Add(CurrentClient);
            }
            else
            {
                _userDao.UpdateUser(CurrentClient);
                // Update the item in the collection
                var index = Clients.IndexOf(Clients.First(u => u.Id == CurrentClient.Id));
                Clients[index] = CurrentClient;
            }

            _currentWindow?.Close();
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
    }
}
