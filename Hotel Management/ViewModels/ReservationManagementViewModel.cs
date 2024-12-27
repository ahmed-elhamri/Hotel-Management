using Hotel_Management.Commands;
using Hotel_Management.DAO;
using Hotel_Management.Models;
using Hotel_Management.Views.Admin.Reservations;
using Hotel_Management.Views.Admin.RoomTypes;
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
        private readonly UserDAO _userDao;  // Add this
        private readonly RoomDAO _roomDao;  // Add this
        private Window _currentWindow;
        private string _tempPassword;

        public ObservableCollection<Reservation> Reservations { get; set; }
        public ObservableCollection<User> Users { get; set; }  // Add this
        public ObservableCollection<Room> Rooms { get; set; }  // Add this
        public List<string> ReservationStatuses { get; set; }  // Add this
        public Reservation CurrentReservation { get; set; }

        public ICommand AddCommand { get; set; }
        public ICommand UpdateCommand { get; set; }
        public ICommand DeleteCommand { get; set; }
        public ICommand SaveCommand { get; set; }

        public ReservationsManagementViewModel()
        {
            _reservationDao = new ReservationDAO();
            Reservations = new ObservableCollection<Reservation>(_reservationDao.GetAllReservations());
            UpdateCommand = new RelayCommand(reservation => OpenPopup((Reservation)reservation));
            DeleteCommand = new RelayCommand(reservation => DeleteReservation((Reservation)reservation));
            AddCommand = new RelayCommand(_ => OpenPopup(new Reservation()));
            SaveCommand = new RelayCommand(_ => SaveReservation());
        }

    

        private void DeleteReservation(Reservation reservation)
        {
            _reservationDao.DeleteReservation(reservation);
            Reservations.Remove(reservation);
        }

        private void OpenPopup(Reservation reservation)
        {
            CurrentReservation = reservation;
            _currentWindow = new AddUpdateReservationWindow { DataContext = this };
            _currentWindow.ShowDialog();
        }

        private void SaveReservation()
        {
            if (CurrentReservation.Id == 0)
            {
                _reservationDao.AddReservation(CurrentReservation);
                Reservations.Add(CurrentReservation);
            }
            else
            {
                _reservationDao.UpdateReservation(CurrentReservation);
                var index = Reservations.IndexOf(Reservations.First(u => u.Id == CurrentReservation.Id));
                Reservations[index] = CurrentReservation;
            }

            _currentWindow?.Close();
        }
    }
}
