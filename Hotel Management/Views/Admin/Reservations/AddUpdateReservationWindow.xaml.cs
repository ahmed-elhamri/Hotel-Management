using Hotel_Management.Models;
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

namespace Hotel_Management.Views.Admin.Reservations
{
    /// <summary>
    /// Interaction logic for AddUpdateReservationWindow.xaml
    /// </summary>
    public partial class AddUpdateReservationWindow : Window
    {
        public AddUpdateReservationWindow()
        {
            InitializeComponent();

        }
        private void DatePicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DataContext is ReservationsManagementViewModel viewModel)
            {
                viewModel.OnCheckInDateChanged();
            }
        }
        private void Room_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           
            if (DataContext is ReservationsManagementViewModel viewModel)
            {
                viewModel.OnRoomChanged();
            }
        }
    }
}
