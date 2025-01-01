using Hotel_Management.Commands;
using Hotel_Management.DAO;
using Hotel_Management.Models;
using Hotel_Management.Views.Admin.Reservations;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Input;

namespace Hotel_Management.ViewModels
{
    public class ReservationsManagementViewModel
    {
        private readonly ReservationDAO _reservationDao;
        private readonly UserDAO _userDao;
        private readonly RoomDAO _roomDao;
        private Window _currentWindow;

        public ObservableCollection<Reservation> Reservations { get; set; }
        public ObservableCollection<User> Users { get; set; }
        public ObservableCollection<Room> Rooms { get; set; }
        public List<ReservationStatus> ReservationStatuses { get; set; }
        public Reservation CurrentReservation { get; set; }

        public ICommand AddCommand { get; set; }
        public ICommand UpdateCommand { get; set; }
        public ICommand DeleteCommand { get; set; }
        public ICommand SaveCommand { get; set; }
        public ICommand CancelCommand { get; set; }
        public ICommand ExportExcelCommand { get; set; }

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

        }

        private void LoadData()
        {
            
            Reservations = new ObservableCollection<Reservation>(_reservationDao.GetAllReservations());
            Users = new ObservableCollection<User>(_userDao.GetAllUsers());
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

        private void OpenPopup(Reservation reservation)
        {
            if (reservation.Id == 0) 
            {
                CurrentReservation = new Reservation
                {
                    CheckInDate = DateTime.Today,
                    CheckOutDate = DateTime.Today.AddDays(1),
                    Status = ReservationStatus.Pending
                };
            }
            else 
            {
                
                CurrentReservation = _reservationDao.GetReservationById(reservation.Id);

                
                if (CurrentReservation.Client != null)
                {
                    var selectedUser = Users.FirstOrDefault(u => u.Id == CurrentReservation.UserId);
                    CurrentReservation.Client = selectedUser;
                }

                if (CurrentReservation.Room != null)
                {
                    var selectedRoom = Rooms.FirstOrDefault(r => r.Id == CurrentReservation.RoomId);
                    CurrentReservation.Room = selectedRoom;
                }
            }

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

                    try
                    {
                        _reservationDao.ExportReservationToPdf(CurrentReservation);
                    }
                    catch (Exception pdfEx)
                    {
                        MessageBox.Show($"Reservation was saved but there was an error generating the PDF: {pdfEx.Message}",
                            "PDF Generation Error",
                            MessageBoxButton.OK,
                            MessageBoxImage.Warning);
                    }
                }
                else
                {
                    _reservationDao.UpdateReservation(CurrentReservation);
                    var index = Reservations.IndexOf(Reservations.First(u => u.Id == CurrentReservation.Id));
                    Reservations[index] = CurrentReservation;
                    MessageBox.Show("Reservation updated successfully!", "Success",
                        MessageBoxButton.OK, MessageBoxImage.Information);
                }

                
                var updatedList = _reservationDao.GetAllReservations();
                Reservations.Clear();
                foreach (var res in updatedList)
                {
                    Reservations.Add(res);
                }

                _currentWindow?.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving reservation: {ex.Message}", "Error",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void ExportToExcel()
        {
            try
            {
                _reservationDao.ExportExcel(Reservations.ToList());
                MessageBox.Show("Excel file exported successfully!", "Success",
                    MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error exporting to Excel: {ex.Message}", "Error",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}