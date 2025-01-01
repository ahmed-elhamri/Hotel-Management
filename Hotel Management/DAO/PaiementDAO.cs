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
            using (var context = new DatabaseContext())
            {
                var cleanPayment = new Payment
                {
                    ReservationId = paiement.ReservationId,
                    PaymentDate = paiement.PaymentDate,
                    Amount = paiement.Amount,
                    PaymentMethod = paiement.PaymentMethod,
                    Status = paiement.Status
                };
                context.Payment.Add(cleanPayment);
                context.SaveChanges();
            }
        }

        public void UpdatePaiement(Payment paiement)
        {
            using (var context = new DatabaseContext())
            {
                var existingPayment = context.Payment.Find(paiement.Id);
                if (existingPayment != null)
                {
                    existingPayment.ReservationId = paiement.ReservationId;
                    existingPayment.PaymentDate = paiement.PaymentDate;
                    existingPayment.Amount = paiement.Amount;
                    existingPayment.PaymentMethod = paiement.PaymentMethod;
                    existingPayment.Status = paiement.Status;
                    context.SaveChanges();
                }
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
