using Hotel_Management.DAO;
using Hotel_Management.Models;
using Hotel_Management.Views;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Hotel_Management
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //private readonly UserDAO _userDAO;
        //public List<User> Users { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            //_userDAO = new UserDAO();
            //Users = _userDAO.GetAllUsers();
            //DataContext = this;
        }

        //private void AddUserButton_Click(object sender, RoutedEventArgs e)
        //{
        //    var addUserWindow = new UserAddUpdateWindow();
        //    addUserWindow.ShowDialog();
        //    Users = _userDAO.GetAllUsers();  // Refresh the list after adding
        //    DataContext = this;
        //}

        //private void EditUserButton_Click(object sender, RoutedEventArgs e)
        //{
        //    if (UserDataGrid.SelectedItem is User selectedUser)
        //    {
        //        var editUserWindow = new UserAddUpdateWindow(selectedUser.Id);
        //        editUserWindow.ShowDialog();
        //        Users = _userDAO.GetAllUsers();  // Refresh the list after editing
        //        DataContext = this;
        //    }
        //    else
        //    {
        //        MessageBox.Show("Please select a user to edit.");
        //    }
        //}
    }
}