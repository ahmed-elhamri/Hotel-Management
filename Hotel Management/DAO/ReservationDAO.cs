using Hotel_Management.Data;
using Hotel_Management.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
       .Include(r => r.Client)  // Load related User entity
       .Include(r => r.Room)    // Load related Room entity
       .ToList();

        }

        public Reservation GetReservationById(int id)
        {
            return _context.Reservation.FirstOrDefault(u => u.Id == id);
        }

        public void UpdateReservation(Reservation reservation)
        {
            _context.Reservation.Update(reservation);
            _context.SaveChanges();
        }

        public void DeleteReservation(Reservation reservation)
        {
            if (reservation != null)
            {
                _context.Reservation.Remove(reservation);
                _context.SaveChanges();
            }
        }
        public void AddReservation(Reservation reservation)
        {
            _context.Reservation.Add(reservation);
            _context.SaveChanges();
        }


    }
}
