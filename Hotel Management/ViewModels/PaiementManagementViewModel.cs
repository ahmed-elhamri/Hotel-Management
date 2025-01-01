using Hotel_Management.Commands;
using Hotel_Management.DAO;
using Hotel_Management.Models;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using System.Windows;
using Hotel_Management.Views.Admin.Paiement;

namespace Hotel_Management.ViewModels
{
    public class PaiementManagementViewModel
    {
        private readonly PaiementDAO _paiementDAO;
        private readonly ReservationDAO _reservationDAO;
        private Window _currentWindow;

        public ObservableCollection<Payment> Payments { get; set; }
        public ObservableCollection<Reservation> Reservations { get; set; }
        public Payment CurrentPaiement { get; set; }

        public ICommand AddCommand { get; set; }
        public ICommand UpdateCommand { get; set; }
        public ICommand DeleteCommand { get; set; }
        public ICommand SaveCommand { get; set; }

        public PaiementManagementViewModel()
        {
            _paiementDAO = new PaiementDAO();
            _reservationDAO = new ReservationDAO();

            // Initialize collections
            Reservations = new ObservableCollection<Reservation>(_reservationDAO.GetAllReservations());
            Payments = new ObservableCollection<Payment>(_paiementDAO.GetAllPaiements());

            // Initialize commands
            AddCommand = new RelayCommand(_ => OpenPopup(new Payment()));
            UpdateCommand = new RelayCommand(paiement => OpenPopup((Payment)paiement));
            DeleteCommand = new RelayCommand(paiement => DeletePaiement((Payment)paiement));
            SaveCommand = new RelayCommand(_ => SavePaiement());
        }

        private void OpenPopup(Payment paiement)
        {
            CurrentPaiement = paiement;
            _currentWindow = new AddUpdatePaiementWindow { DataContext = this };
            _currentWindow.ShowDialog();
        }

        private void DeletePaiement(Payment paiement)
        {
            _paiementDAO.DeletePaiement(paiement);
            Payments.Remove(paiement);
        }

        private void SavePaiement()
        {
            if (CurrentPaiement.Id == 0) // Add new payment
            {
                _paiementDAO.AddPaiement(CurrentPaiement);
                Payments.Add(CurrentPaiement);
            }
            else // Update existing payment
            {
                _paiementDAO.UpdatePaiement(CurrentPaiement);
                var index = Payments.IndexOf(Payments.First(p => p.Id == CurrentPaiement.Id));
                Payments[index] = CurrentPaiement;
            }

            _currentWindow?.Close();
        }
    }
}
