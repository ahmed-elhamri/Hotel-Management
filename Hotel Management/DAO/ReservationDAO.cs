using Hotel_Management.Data;
using Hotel_Management.Models;
using Microsoft.EntityFrameworkCore;

namespace Hotel_Management.DAO
{
    internal class ReservationDAO
    {
        private readonly DatabaseContext _context;

        public ReservationDAO()
        {
            _context = new DatabaseContext();
        }

        public List<Reservation> GetAllReservations()
        {
            return _context.Reservation
                .Include(r => r.Client)
                .Include(r => r.Room)
                .ToList();
        }

        public Reservation GetReservationById(int id)
        {
            return _context.Reservation
                .Include(r => r.Client)
                .Include(r => r.Room)
                .FirstOrDefault(u => u.Id == id);
        }

        public void UpdateReservation(Reservation reservation)
        {
            try
            {
                using (var newContext = new DatabaseContext())
                {
                    
                    var existingReservation = newContext.Reservation
                        .Include(r => r.Client)
                        .Include(r => r.Room)
                        .FirstOrDefault(r => r.Id == reservation.Id);

                    if (existingReservation != null)
                    {
                       
                        existingReservation.UserId = reservation.Client.Id;
                        existingReservation.RoomId = reservation.Room.Id;
                        existingReservation.CheckInDate = reservation.CheckInDate;
                        existingReservation.CheckOutDate = reservation.CheckOutDate;
                        existingReservation.TotalPrice = reservation.TotalPrice;
                        existingReservation.Status = reservation.Status;

                        newContext.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error updating reservation: {ex.Message}", ex);
            }
        }

        public void AddReservation(Reservation reservation)
        {
            try
            {
                
                var newReservation = new Reservation
                {
                    UserId = reservation.Client.Id,
                    RoomId = reservation.Room.Id,
                    CheckInDate = reservation.CheckInDate,
                    CheckOutDate = reservation.CheckOutDate,
                    TotalPrice = reservation.TotalPrice,
                    Status = reservation.Status
                };

                _context.Reservation.Add(newReservation);
                _context.SaveChanges();

                
                reservation.Id = newReservation.Id;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error adding reservation: {ex.Message}", ex);
            }
        }


        public void DeleteReservation(Reservation reservation)
        {
            try
            {
                if (reservation != null)
                {
                    
                    _context.ChangeTracker.Clear();

                    
                    var reservationToDelete = _context.Reservation.Find(reservation.Id);
                    if (reservationToDelete != null)
                    {
                        _context.Reservation.Remove(reservationToDelete);
                        _context.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error deleting reservation: {ex.Message}", ex);
            }
        }
    }
}