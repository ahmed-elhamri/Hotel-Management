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

namespace Hotel_Management.Views.Admin.Clients
{
    /// <summary>
    /// Interaction logic for AddUpdateClientsWindow.xaml
    /// </summary>
    public partial class AddUpdateClientsWindow : Window
    {
        public AddUpdateClientsWindow()
        {
            InitializeComponent();
            this.DataContext = new ClientsManagementViewModel();

        }
    }
}
