using Hotel_Management.Commands;
using Hotel_Management.DAO;
using Hotel_Management.Models;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using Hotel_Management.Views.Admin.Paiements;

namespace Hotel_Management.ViewModels
{
    public class PaiementManagementViewModel : INotifyPropertyChanged
    {
        private readonly PaiementDAO _paiementDAO;
        private readonly ReservationDAO _reservationDAO;
        private Window _currentWindow;

        public ObservableCollection<Payment> Payments { get; set; }
        public ObservableCollection<Reservation> Reservations { get; set; }

        private Payment _currentPaiement;
        public Payment CurrentPaiement
        {
            get => _currentPaiement;
            set
            {
                _currentPaiement = value;
                OnPropertyChanged(nameof(CurrentPaiement));
            }
        }

        private Reservation _selectedReservation;
        public Reservation SelectedReservation
        {
            get => _selectedReservation;
            set
            {
                _selectedReservation = value;
                if (_currentPaiement != null && value != null)
                {
                    _currentPaiement.ReservationId = value.Id;
                    _currentPaiement.Reservation = value;
                }
                OnPropertyChanged(nameof(SelectedReservation));
            }
        }

        public ICommand AddCommand { get; set; }
        public ICommand UpdateCommand { get; set; }
        public ICommand DeleteCommand { get; set; }
        public ICommand SaveCommand { get; set; }

        public PaiementManagementViewModel()
        {
            _paiementDAO = new PaiementDAO();
            _reservationDAO = new ReservationDAO();

            LoadData();

            // Initialize commands
            AddCommand = new RelayCommand(_ => OpenPopup(new Payment()));
            UpdateCommand = new RelayCommand(paiement => OpenPopup((Payment)paiement));
            DeleteCommand = new RelayCommand(paiement => DeletePaiement((Payment)paiement));
            SaveCommand = new RelayCommand(_ => SavePaiement());
        }

        private void OpenPopup(Payment paiement)
        {
            // Créer un nouveau paiement avec des valeurs par défaut
            CurrentPaiement = new Payment
            {
                Id = paiement.Id,
                PaymentDate = DateTime.Now,
                Amount = 10,
                PaymentMethod = PMethod.Cash,
                Status = PaymentStatus.Pending
            };

            // Sélectionner la première réservation par défaut
            if (Reservations.Any())
            {
                SelectedReservation = Reservations.First();
                CurrentPaiement.ReservationId = SelectedReservation.Id;
            }

            _currentWindow = new AddUpdatePaiementWindow { DataContext = this };
            _currentWindow.ShowDialog();
        }

        private void DeletePaiement(Payment paiement)
        {
            try
            {
                _paiementDAO.DeletePaiement(paiement);
                Payments.Remove(paiement);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la suppression : {ex.Message}");
            }
        }

        private void SavePaiement()
        {
            try
            {
                if (SelectedReservation == null)
                {
                    MessageBox.Show("POPO " +SelectedReservation);
                    throw new InvalidOperationException("Veuillez sélectionner une réservation valide.");
                }

                if (CurrentPaiement.Amount <= 0)
                {
                    throw new InvalidOperationException("Le montant doit être supérieur à 0.");
                }

                CurrentPaiement.ReservationId = SelectedReservation.Id;
                CurrentPaiement.Reservation = null; // Important : nettoyer la référence de navigation

                if (CurrentPaiement.Id == 0)
                {
                    _paiementDAO.AddPaiement(CurrentPaiement);
                }
                else
                {
                    _paiementDAO.UpdatePaiement(CurrentPaiement);
                }

                LoadData();
                _currentWindow?.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'enregistrement : {ex.Message}");
            }
        }
        private void LoadData()
        {
            Payments = new ObservableCollection<Payment>(_paiementDAO.GetAllPaiement());
            Reservations = new ObservableCollection<Reservation>(_reservationDAO.GetAllReservations());
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
