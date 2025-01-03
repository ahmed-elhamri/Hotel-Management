using Hotel_Management.ViewModels;
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
    /// Interaction logic for AdminView.xaml
    /// </summary>
    public partial class AdminView : Window
    {
        public AdminView()
        {
            InitializeComponent();
            DataContext = new MainViewModel();
        }

        private void CloseWindow_Click(object sender, RoutedEventArgs e)
        {
            this.Close(); // Ferme la fenêtre
        }

        private void MinimizeWindow_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized; // Réduit la fenêtre
        }

        private void MaximizeRestoreWindow_Click(object sender, RoutedEventArgs e)
        {
            if (this.WindowState == WindowState.Maximized)
            {
                this.WindowState = WindowState.Normal; // Restaure la taille normale
            }
            else
            {
                this.WindowState = WindowState.Maximized; // Agrandit la fenêtre
            }
        }

        private void Deconnexion_Click(object sender, RoutedEventArgs e)
        {
                var loginView = new LoginView();
                loginView.Show();
                this.Close();
        }
    }
}
