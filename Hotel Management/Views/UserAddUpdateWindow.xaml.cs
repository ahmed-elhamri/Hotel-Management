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
        private readonly int _userId; 
        private bool _isEditMode;

        public UserAddUpdateWindow(int? userId = null)
        {
            InitializeComponent();
            _userDAO = new UserDAO();

            if (userId.HasValue)
            {
                _userId = userId.Value;
                _isEditMode = true;

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
                user.Id = _userId;
                _userDAO.UpdateUser(user);
                MessageBox.Show("User updated successfully!");
            }
            else
            {
                _userDAO.AddUser(user);
                MessageBox.Show("User added successfully!");
            }

            this.Close();
        }
    }
}
