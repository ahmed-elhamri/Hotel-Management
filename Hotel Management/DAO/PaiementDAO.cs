using Hotel_Management.Data;
using Hotel_Management.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Hotel_Management.DAO
{
    internal class PaiementDAO
    {
        private readonly DatabaseContext _context;

        public PaiementDAO()
        {
            _context = new DatabaseContext();
        }

        public List<Payment> GetAllPaiement()
        {
            return _context.Payment
                .Include(r => r.Reservation)
                .ToList();
        }

        public Payment GetPaiementById(int id)
        {
            // Include Reservation without causing tracking issues
            return _context.Payment.Include(r => r.Reservation).FirstOrDefault(u => u.Id == id);
        }

        public void AddPaiement(Payment paiement)
        {
            // Only set the foreign key, not the navigation property
            paiement.ReservationId = paiement.Reservation?.Id ?? 0;
            paiement.Reservation = null;  // Clear the navigation property

            _context.Payment.Add(paiement);
            _context.SaveChanges();
        }

        public void UpdatePaiement(Payment paiement)
        {
            var existingPaiement = _context.Payment.Find(paiement.Id);
            if (existingPaiement != null)
            {
                existingPaiement.ReservationId = paiement.Reservation?.Id ?? 0;
                existingPaiement.PaymentDate = paiement.PaymentDate;
                existingPaiement.Amount = paiement.Amount;
                existingPaiement.PaymentMethod = paiement.PaymentMethod;
                existingPaiement.Status = paiement.Status;

                _context.SaveChanges();
            }
        }

        public void DeletePaiement(Payment paiement)
        {
            if (paiement != null)
            {
                _context.Payment.Remove(paiement);
                _context.SaveChanges();
            }
        }
    }
}
