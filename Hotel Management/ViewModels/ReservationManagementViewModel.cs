using Hotel_Management.Commands;
using Hotel_Management.DAO;
using Hotel_Management.Models;
using Hotel_Management.Services;
using Hotel_Management.Views.Admin.Reservations;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing.Printing;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
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
            MessageBoxResult response = MessageBox.Show("Voulez vous supprimer cette reservation", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (response == MessageBoxResult.No)
            {
                return;
            }
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
                    SendConfirmationEmail(CurrentReservation);
                    MessageBox.Show("Reservation added successfully!", "Success",
                        MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    _reservationDao.UpdateReservation(CurrentReservation);
                    var index = Reservations.IndexOf(Reservations.First(u => u.Id == CurrentReservation.Id));
                    Reservations[index] = CurrentReservation;
                    SendConfirmationEmail(CurrentReservation);
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

        private void SendConfirmationEmail(Reservation reservation)
        {
            try
            {
                var emailMessage = new EmailMessage
                {
                    To = reservation.Client.Email,
                    Subject = "Hotel Reservation Confirmation",
                    Body = $@"
                        <html>
                        <head>
                           <style>
                                body {{
                                    font-family: Arial, sans-serif;
                                    margin: 20px;
                                    color: #333;
                                    line-height: 1.6;
                                }}
                                h1 {{
                                    color: #2ecc71;
                                    text-align: center;
                                }}
                                .reservation-details {{
                                    margin: 20px 0;
                                    padding: 15px;
                                    border: 1px solid #ddd;
                                    border-radius: 8px;
                                    background-color: #f9f9f9;
                                }}
                                .reservation-details h2 {{
                                    margin-bottom: 10px;
                                    color: #2d3748;
                                }}
                                .reservation-details ul {{
                                    list-style-type: none;
                                    padding: 0;
                                }}
                                .reservation-details li {{
                                    margin: 5px 0;
                                }}
                                .footer {{
                                    margin-top: 20px;
                                    text-align: center;
                                    font-size: 0.9em;
                                    color: #777;
                                }}
                            </style>
                        </head>
                        <body>
                            <h1>Merci pour votre réservation !</h1>
                            <p>Cher/Chère {reservation.Client.FirstName} {reservation.Client.LastName},</p>
                            <p>Nous sommes ravis de confirmer votre réservation à notre hôtel. Voici les détails :</p>
                            <div class='reservation-details'>
                                <h2>Détails de la réservation</h2>
                                <ul>
                                    <li><strong>Numéro de réservation :</strong> {reservation.Id}</li>
                                    <li><strong>Date d'arrivée :</strong> {reservation.CheckInDate:dd/MM/yyyy}</li>
                                    <li><strong>Date de départ :</strong> {reservation.CheckOutDate:dd/MM/yyyy}</li>
                                    <li><strong>Numéro de chambre :</strong> {reservation.Room.Name}</li>
                                    <li><strong>Type de chambre :</strong> {reservation.Room.RoomType.Name}</li>
                                    <li><strong>Prix par nuit :</strong> {reservation.Room.Price:F2} MAD</li>
                                    <li><strong>Durée du séjour :</strong> {(reservation.CheckOutDate - reservation.CheckInDate).TotalDays} nuits</li>
                                    <li><strong>Montant total :</strong> {reservation.TotalPrice:F2} MAD</li>
                                    <li><strong>Statut de la réservation :</strong> {reservation.Status}</li>
                                </ul>
                            </div>
                            <p>Si vous avez des questions ou si vous souhaitez modifier votre réservation, n'hésitez pas à nous contacter.</p>
                            <div class='footer'>
                                <p>À bientôt !</p>
                                <p><em>L'équipe de gestion de l'hôtel</em></p>
                            </div>
                        </body>
                        </html>
                        "
                };

                EmailService.SendEmail(emailMessage);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to send confirmation email: {ex.Message}", "Email Error",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
                // Don't throw - we don't want to interrupt the reservation process if email fails
            }
        }
    }
}