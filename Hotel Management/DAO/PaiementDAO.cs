using Hotel_Management.Data;
using Hotel_Management.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Win32;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

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

                var reservation = _context.Reservation.Find(paiement.ReservationId);
                if (reservation != null && paiement.Status == PaymentStatus.Paid)
                {
                    reservation.Status = ReservationStatus.Confirmed;
                    _context.SaveChanges();
                }
                

            }
        }


        public void ExportExcel(List<Payment> Payments)
        {
            try
            {
                // Set EPPlus license context
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

                using (var package = new ExcelPackage())
                {
                    var worksheet = package.Workbook.Worksheets.Add("Reservations");

                    // Add headers
                    worksheet.Cells[1, 1].Value = "Payment ID";
                    worksheet.Cells[1, 2].Value = "Reservation Id";
                    worksheet.Cells[1, 3].Value = "Payment Date";
                    worksheet.Cells[1, 4].Value = "Amount";
                    worksheet.Cells[1, 5].Value = "Payment Method";
                    worksheet.Cells[1, 6].Value = "Status";
                    

                    // Style the header
                    using (var headerRange = worksheet.Cells[1, 1, 1, 6])
                    {
                        headerRange.Style.Font.Bold = true;
                        headerRange.Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                        headerRange.Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.LightGray);
                    }

                    // Add data
                    int row = 2;
                    foreach (var payment in Payments)
                    {
                        worksheet.Cells[row, 1].Value = payment.Id;
                        worksheet.Cells[row, 2].Value = payment.Reservation.Id;
                        worksheet.Cells[row, 3].Value = payment.PaymentDate.ToShortDateString();
                        worksheet.Cells[row, 4].Value = payment.Amount;
                        worksheet.Cells[row, 5].Value = payment.PaymentMethod;
                        worksheet.Cells[row, 6].Value = payment.Status;
                       

                        row++;
                    }

                    // Auto-fit columns
                    worksheet.Cells.AutoFitColumns();

                    // Create save file dialog
                    SaveFileDialog saveFileDialog = new SaveFileDialog
                    {
                        Filter = "Excel Files (*.xlsx)|*.xlsx",
                        DefaultExt = "xlsx",
                        FileName = $"Payments_{DateTime.Now:yyyyMMdd}"
                    };

                    if (saveFileDialog.ShowDialog() == true)
                    {
                        // Save the file
                        File.WriteAllBytes(saveFileDialog.FileName, package.GetAsByteArray());
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error exporting to Excel: {ex.Message}", ex);
            }
        }

        public void UpdatePaiement(Payment paiement)
        {
            using (var context = new DatabaseContext())
            {
                var existingPayment = context.Payment.Find(paiement.Id);
                if (existingPayment != null)
                {
                    // Store the old room ID before updating
                    int oldReservationId = existingPayment.ReservationId;

                    existingPayment.ReservationId = paiement.ReservationId;
                    existingPayment.PaymentDate = paiement.PaymentDate;
                    existingPayment.Amount = paiement.Amount;
                    existingPayment.PaymentMethod = paiement.PaymentMethod;
                    existingPayment.Status = paiement.Status;

                    // Update rooms' availability using the same context
                    var newReservation = context.Reservation.Find(paiement.ReservationId);
                    var oldReservation = context.Reservation.Find(oldReservationId);

                    if (newReservation != null && oldReservation != null && 
                        oldReservationId != paiement.ReservationId && 
                        paiement.Status == PaymentStatus.Paid)
                    {
                        newReservation.Status = ReservationStatus.Confirmed;
                        oldReservation.Status = ReservationStatus.Pending;
                    }
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

            var reservation = _context.Reservation.Find(paiement.ReservationId);
            if (reservation != null && paiement.Status == PaymentStatus.Paid)
            {
                reservation.Status = ReservationStatus.Pending;
                _context.SaveChanges();
            }
        }
    }
}
