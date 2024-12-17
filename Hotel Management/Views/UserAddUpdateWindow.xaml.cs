using Hotel_Management.DAO;
using Hotel_Management.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Hotel_Management.Views
{
    /// <summary>
    /// Interaction logic for UserAddUpdateWindow.xaml
    /// </summary>
    public partial class UserAddUpdateWindow : Window
    {
        private readonly UserDAO _userDAO;
        private readonly int _userId; // To determine if we're adding or editing
        private bool _isEditMode;

        public UserAddUpdateWindow(int? userId = null)
        {
            InitializeComponent();
            _userDAO = new UserDAO();

            // Check if we're editing an existing user or adding a new one
            if (userId.HasValue)
            {
                _userId = userId.Value;
                _isEditMode = true;

                // Load the user details for editing
                var user = _userDAO.GetUserById(_userId);
                if (user != null)
                {
                    NameTextBox.Text = user.FirstName;
                    EmailTextBox.Text = user.Email;
                    PasswordTextBox.Text = user.Password;
                }
            }
            else
            {
                _isEditMode = false;
                _userId = 0;
            }
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            var user = new User
            {
                FirstName = NameTextBox.Text,
                Email = EmailTextBox.Text,
                Password = PasswordTextBox.Text
            };

            if (_isEditMode)
            {
                // Update the existing user
                user.Id = _userId;
                _userDAO.UpdateUser(user);
                MessageBox.Show("User updated successfully!");
            }
            else
            {
                // Add a new user
                _userDAO.AddUser(user);
                MessageBox.Show("User added successfully!");
            }

            this.Close(); // Close the window after saving
        }
    }
}
