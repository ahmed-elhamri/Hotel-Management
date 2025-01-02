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
        public ObservableCollection<PMethod> PaymentMethods { get; set; }
        public ObservableCollection<PaymentStatus> PaymentStatuses { get; set; }

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
        public ICommand ExportExcelCommand { get; set; }

        public PaiementManagementViewModel()
        {
            _paiementDAO = new PaiementDAO();
            _reservationDAO = new ReservationDAO();

            LoadData();

            // Charger les énumérations
            PaymentMethods = new ObservableCollection<PMethod>((PMethod[])Enum.GetValues(typeof(PMethod)));
            PaymentStatuses = new ObservableCollection<PaymentStatus>((PaymentStatus[])Enum.GetValues(typeof(PaymentStatus)));

            // Initialiser les commandes
            AddCommand = new RelayCommand(_ => OpenPopup(new Payment()));
            UpdateCommand = new RelayCommand(paiement => OpenPopup((Payment)paiement));
            DeleteCommand = new RelayCommand(paiement => DeletePaiement((Payment)paiement));
            SaveCommand = new RelayCommand(_ => SavePaiement());
            ExportExcelCommand = new RelayCommand(_ => ExportToExcel());
        }

        private void OpenPopup(Payment paiement)
        {
            if (paiement.Id == 0) // Nouveau paiement
            {
                CurrentPaiement = new Payment
                {
                    PaymentDate = DateTime.Now,
                    Amount = 0,
                    PaymentMethod = PMethod.Cash,
                    Status = PaymentStatus.Pending
                };

                if (Reservations.Any())
                {
                    SelectedReservation = Reservations.First();
                    CurrentPaiement.ReservationId = SelectedReservation.Id;
                }
            }
            else // Modification
            {
                CurrentPaiement = new Payment
                {
                    Id = paiement.Id,
                    ReservationId = paiement.ReservationId,
                    PaymentDate = paiement.PaymentDate,
                    Amount = paiement.Amount,
                    PaymentMethod = paiement.PaymentMethod,
                    Status = paiement.Status
                };

                SelectedReservation = Reservations.FirstOrDefault(r => r.Id == paiement.ReservationId);
            }

            _currentWindow = new AddUpdatePaiementWindow { DataContext = this };
            _currentWindow.ShowDialog();
        }

        private void DeletePaiement(Payment paiement)
        {
            MessageBoxResult response = MessageBox.Show("Voulez vous supprimer ce paiement", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (response == MessageBoxResult.No)
            {
                return;
            }
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
                    throw new InvalidOperationException("Veuillez sélectionner une réservation valide.");
                }

                if (CurrentPaiement.Amount <= 0)
                {
                    throw new InvalidOperationException("Le montant doit être supérieur à 0.");
                }

                CurrentPaiement.ReservationId = SelectedReservation.Id;
                CurrentPaiement.Reservation = null;

                if (CurrentPaiement.Id == 0)
                {
                    _paiementDAO.AddPaiement(CurrentPaiement);
                }
                else
                {
                    _paiementDAO.UpdatePaiement(CurrentPaiement);
                }

                _currentWindow?.Close();

                // Rafraîchir la liste
                var newPayments = _paiementDAO.GetAllPaiement();
                Payments = new ObservableCollection<Payment>(newPayments);
                OnPropertyChanged(nameof(Payments));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'enregistrement : {ex.Message}");
            }
        }

        private void ExportToExcel()
        {
            try
            {
                _paiementDAO.ExportExcel(Payments.ToList());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error exporting to Excel: {ex.Message}", "Error",
                    MessageBoxButton.OK, MessageBoxImage.Error);
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
