using Hotel_Management.DAO;
using Hotel_Management.Models;
using Hotel_Management.Services;
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
    /// Interaction logic for LoginView.xaml
    /// </summary>
    public partial class LoginView : Window
    {
        private readonly UserDAO _userDAO;
        public LoginView()
        {
            InitializeComponent();
            _userDAO = new UserDAO();
        }
        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string email = EmailTextBox.Text;
            string password = PasswordBox.Password; 

            var user = _userDAO.GetUserByLogin(email, password);

            if (user != null)
            {
                if (user.Role == UserRole.Admin)
                {
                    var adminView = new AdminView();
                    adminView.Show();
                }
                else if (user.Role == UserRole.Client)
                {
                    var clientView = new ClientView();
                    clientView.Show();
                }

                this.Close();
            }
            else
            {
                MessageBox.Show($"Invalid email or password. {UserRole.Admin}", "Login Failed", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void TestButton_Click(object sender, RoutedEventArgs e)
        {
            var message = new EmailMessage
            {
                To = "elhamriahmed41@gmail.com",
                Subject = "Test Email",
                Body = "Hello, this is a test email!"
            };

            EmailService.SendEmail(message);

        }
    }
}
