using Hotel_Management.Commands;
using Hotel_Management.DAO;
using Hotel_Management.Models;
using Hotel_Management.Views.Admin.Reservations;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using System.Windows.Input;

namespace Hotel_Management.ViewModels
{
    public class ReservationsManagementViewModel: INotifyPropertyChanged
    {
        private readonly ReservationDAO _reservationDao;
        private readonly UserDAO _userDao;
        private readonly RoomDAO _roomDao;
        private Window _currentWindow;
        private Reservation _tempReservation;

        public event PropertyChangedEventHandler? PropertyChanged;

        public ObservableCollection<Reservation> Reservations { get; set; }
        public ObservableCollection<User> Users { get; set; }
        public ObservableCollection<Room> Rooms { get; set; }
        public List<ReservationStatus> ReservationStatuses { get; set; }
        public Reservation CurrentReservation { get; set; }

        private ObservableCollection<Room> _availableRooms;
        public ObservableCollection<Room> AvailableRooms
        {
            get => _availableRooms;
            set
            {
                _availableRooms = value;
                OnPropertyChanged(nameof(AvailableRooms));
            }
        }
        //public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        private void UpdateAvailableRooms()
        {
            if (CurrentReservation != null &&
                CurrentReservation.CheckInDate != default &&
                CurrentReservation.CheckOutDate != default)
            {
                var availableRooms = _reservationDao.GetAvailableRooms(
                    CurrentReservation.CheckInDate,
                    CurrentReservation.CheckOutDate
                );
                AvailableRooms = new ObservableCollection<Room>(availableRooms);
            }
        }
        public ICommand AddCommand { get; set; }
        public ICommand UpdateCommand { get; set; }
        public ICommand DeleteCommand { get; set; }
        public ICommand SaveCommand { get; set; }
        public ICommand CancelCommand { get; set; }
        public ICommand ExportExcelCommand { get; set; }
        public ICommand ExportPdfCommand { get; set; }

        public ReservationsManagementViewModel()
        {
            
            _reservationDao = new ReservationDAO();
            _userDao = new UserDAO();
            _roomDao = new RoomDAO();

            
            LoadData();

            
            UpdateCommand = new RelayCommand(reservation => OpenPopup((Reservation)reservation));
            DeleteCommand = new RelayCommand(reservation => DeleteReservation((Reservation)reservation));
            AddCommand = new RelayCommand(_ => OpenPopup(new Reservation()));
            SaveCommand = new RelayCommand(_ => SaveReservation());
            CancelCommand = new RelayCommand(_ => _currentWindow?.Close());
            ExportExcelCommand = new RelayCommand(_ => ExportToExcel());
            ExportPdfCommand = new RelayCommand(reservation=> ExportToPdf((Reservation)reservation));

        }

        private void LoadData()
        {
            
            Reservations = new ObservableCollection<Reservation>(_reservationDao.GetAllReservations());
            Users = new ObservableCollection<User>(_userDao.GetAllClients());
            Rooms = new ObservableCollection<Room>(_roomDao.GetAllRooms());

            ReservationStatuses = Enum.GetValues(typeof(ReservationStatus))
                                    .Cast<ReservationStatus>()
                                    .ToList();
        }

        private void DeleteReservation(Reservation reservation)
        {
            _reservationDao.DeleteReservation(reservation);
            Reservations.Remove(reservation);
        }

        private void CalculateTotalPrice()
        {
            if (CurrentReservation != null &&
                CurrentReservation.Room != null &&
                CurrentReservation.CheckInDate != default &&
                CurrentReservation.CheckOutDate != default)
            {
                // Calculer le nombre de jours
                int numberOfDays = (int)(CurrentReservation.CheckOutDate - CurrentReservation.CheckInDate).TotalDays;

                // Calculer le prix total
                CurrentReservation.TotalPrice = CurrentReservation.Room.Price * numberOfDays;

                // Notifier le changement
                OnPropertyChanged(nameof(CurrentReservation));
            }
        }

        //private void OpenPopup(Reservation reservation)
        //{
        //    if (reservation.Id == 0)
        //    {
        //        _tempReservation = new Reservation
        //        {
        //            CheckInDate = DateTime.Today,
        //            CheckOutDate = DateTime.Today.AddDays(1),
        //            Status = ReservationStatus.Pending,
        //            TotalPrice = 0
        //        };
        //        CurrentReservation = _tempReservation;
        //    }
        //    else
        //    {
        //        // Create a deep copy of the reservation
        //        _tempReservation = new Reservation
        //        {
        //            Id = reservation.Id,
        //            UserId = reservation.UserId,
        //            Client = reservation.Client,
        //           //i wanna the client name
        //            RoomId = reservation.RoomId,
        //            Room = reservation.Room,
        //            //i wanna the Room name
        //            CheckInDate = reservation.CheckInDate,
        //            CheckOutDate = reservation.CheckOutDate,
        //            TotalPrice = reservation.TotalPrice,
        //            Status = reservation.Status
        //        };
        //        CurrentReservation = _tempReservation;
        //    }

        //    UpdateAvailableRooms();
        //    CalculateTotalPrice();

        //    _currentWindow = new AddUpdateReservationWindow { DataContext = this };
        //    _currentWindow.ShowDialog();
        //}

        private void OpenPopup(Reservation reservation)
        {
            if (reservation.Id == 0)
            {
                _tempReservation = new Reservation
                {
                    CheckInDate = DateTime.Today,
                    CheckOutDate = DateTime.Today.AddDays(1),
                    Status = ReservationStatus.Pending,
                    TotalPrice = 0
                };
                CurrentReservation = _tempReservation;
            }
            else
            {
                // Get the objects from your ObservableCollections to ensure reference matching
                var selectedClient = Users.FirstOrDefault(u => u.Id == reservation.UserId);
                //var selectedRoom = Rooms.FirstOrDefault(r => r.Id == reservation.RoomId);

                // Create a deep copy of the reservation with the correct references
                _tempReservation = new Reservation
                {
                    Id = reservation.Id,
                    UserId = reservation.UserId,
                    Client = selectedClient ?? reservation.Client,  // Use the client from Users collection
                    RoomId = reservation.RoomId,
                    Room = reservation.Room,     // Use the room from Rooms collection
                    CheckInDate = reservation.CheckInDate,
                    CheckOutDate = reservation.CheckOutDate,
                    TotalPrice = reservation.TotalPrice,
                    Status = reservation.Status
                };
                CurrentReservation = _tempReservation;
               
            }
            UpdateAvailableRooms();
            CalculateTotalPrice();
            _currentWindow = new AddUpdateReservationWindow { DataContext = this };
            _currentWindow.ShowDialog();
        }


        private void SaveReservation()
        {
            if (CurrentReservation.Client == null || CurrentReservation.Room == null)
            {
                MessageBox.Show("Please select both a client and a room.", "Validation Error",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            if (CurrentReservation.CheckOutDate <= CurrentReservation.CheckInDate)
            {
                MessageBox.Show("Check-out date must be after check-in date.", "Validation Error",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            try
            {
                if (CurrentReservation.Id == 0)
                {
                    _reservationDao.AddReservation(CurrentReservation);
                    Reservations.Add(CurrentReservation);

                    MessageBox.Show("Reservation added successfully!", "Success",
                        MessageBoxButton.OK, MessageBoxImage.Information);

                    //try
                    //{
                    //    _reservationDao.ExportReservationToPdf(CurrentReservation);
                    //}
                    //catch (Exception pdfEx)
                    //{
                    //    MessageBox.Show($"Reservation was saved but there was an error generating the PDF: {pdfEx.Message}",
                    //        "PDF Generation Error",
                    //        MessageBoxButton.OK,
                    //        MessageBoxImage.Warning);
                    //}
                }
                else
                {
                    _reservationDao.UpdateReservation(CurrentReservation);
                    var index = Reservations.IndexOf(Reservations.First(u => u.Id == CurrentReservation.Id));
                    Reservations[index] = CurrentReservation;
                    MessageBox.Show("Reservation updated successfully!", "Success",
                        MessageBoxButton.OK, MessageBoxImage.Information);
                }

                
                //var updatedList = _reservationDao.GetAllReservations();
                //Reservations.Clear();
                //foreach (var res in updatedList)
                //{
                //    Reservations.Add(res);
                //}

                _currentWindow?.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving reservation: {ex.Message}", "Error",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void ExportToPdf(Reservation reservation)
        {
            try
            {
                _reservationDao.ExportReservationToPdf(reservation);
            }
            catch (Exception pdfEx)
            {
                MessageBox.Show($"Reservation was saved but there was an error generating the PDF: {pdfEx.Message}",
                    "PDF Generation Error",
                    MessageBoxButton.OK,
                    MessageBoxImage.Warning);
            }
        }

        private void ExportToExcel()
        {
            try
            {
                _reservationDao.ExportExcel(Reservations.ToList());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error exporting to Excel: {ex.Message}", "Error",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        // Mettez à jour les méthodes de changement de date
        public void OnCheckInDateChanged()
        {
            UpdateAvailableRooms();
            CalculateTotalPrice();
        }

        public void OnCheckOutDateChanged()
        {
            UpdateAvailableRooms();
            CalculateTotalPrice();
        }

        // Ajoutez cette méthode pour gérer le changement de chambre
        public void OnRoomChanged()
        {
            CalculateTotalPrice();
        }
    }
}