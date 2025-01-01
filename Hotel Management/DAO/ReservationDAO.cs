using Hotel_Management.Data;
using Hotel_Management.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Win32;
using OfficeOpenXml;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using Microsoft.Win32;

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

        public void ExportExcel(List<Reservation> reservations)
        {
            try
            {
                // Set EPPlus license context
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

                using (var package = new ExcelPackage())
                {
                    var worksheet = package.Workbook.Worksheets.Add("Reservations");

                    // Add headers
                    worksheet.Cells[1, 1].Value = "Reservation ID";
                    worksheet.Cells[1, 2].Value = "Client Name";
                    worksheet.Cells[1, 3].Value = "Room Number";
                    worksheet.Cells[1, 4].Value = "Check-In Date";
                    worksheet.Cells[1, 5].Value = "Check-Out Date";
                    worksheet.Cells[1, 6].Value = "Total Price";
                    worksheet.Cells[1, 7].Value = "Status";

                    // Style the header
                    using (var headerRange = worksheet.Cells[1, 1, 1, 7])
                    {
                        headerRange.Style.Font.Bold = true;
                        headerRange.Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                        headerRange.Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.LightGray);
                    }

                    // Add data
                    int row = 2;
                    foreach (var reservation in reservations)
                    {
                        worksheet.Cells[row, 1].Value = reservation.Id;
                        worksheet.Cells[row, 2].Value = $"{reservation.Client?.FirstName} {reservation.Client?.LastName}";
                        worksheet.Cells[row, 3].Value = reservation.Room?.Id;
                        worksheet.Cells[row, 4].Value = reservation.CheckInDate.ToShortDateString();
                        worksheet.Cells[row, 5].Value = reservation.CheckOutDate.ToShortDateString();
                        worksheet.Cells[row, 6].Value = reservation.TotalPrice;
                        worksheet.Cells[row, 7].Value = reservation.Status.ToString();

                        row++;
                    }

                    // Auto-fit columns
                    worksheet.Cells.AutoFitColumns();

                    // Create save file dialog
                    SaveFileDialog saveFileDialog = new SaveFileDialog
                    {
                        Filter = "Excel Files (*.xlsx)|*.xlsx",
                        DefaultExt = "xlsx",
                        FileName = $"Reservations_{DateTime.Now:yyyyMMdd}"
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

        public void ExportReservationToPdf(Reservation reservation)
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "PDF Files (*.pdf)|*.pdf",
                    DefaultExt = "pdf",
                    FileName = $"Booking_Voucher_{reservation.Id}_{DateTime.Now:yyyyMMdd}"
                };

                if (saveFileDialog.ShowDialog() == true)
                {
                    using (FileStream fs = new FileStream(saveFileDialog.FileName, FileMode.Create))
                    {
                        Document document = new Document(PageSize.A4, 25, 25, 30, 30);
                        PdfWriter writer = PdfWriter.GetInstance(document, fs);

                        document.Open();

                        // Add hotel logo/header
                        document.Add(new Paragraph("HOTEL MANAGEMENT SYSTEM"));
                        document.Add(new Paragraph("Booking Voucher") { Alignment = Element.ALIGN_CENTER });
                        document.Add(new Paragraph(new Chunk(new iTextSharp.text.pdf.draw.LineSeparator())));
                        document.Add(new Paragraph("\n"));

                        // Reservation details
                        document.Add(new Paragraph($"Booking Reference: #{reservation.Id}"));
                        document.Add(new Paragraph($"Date: {DateTime.Now:dd/MM/yyyy}"));
                        document.Add(new Paragraph("\n"));

                        // Guest Information
                        document.Add(new Paragraph("Guest Information", FontFactory.GetFont(FontFactory.HELVETICA_BOLD)));
                        document.Add(new Paragraph($"Name: {reservation.Client.FirstName} {reservation.Client.LastName}"));
                        document.Add(new Paragraph($"Email: {reservation.Client.Email}"));
                        document.Add(new Paragraph($"Phone: {reservation.Client.PhoneNumber}"));
                        document.Add(new Paragraph("\n"));

                        // Booking Details
                        document.Add(new Paragraph("Booking Details", FontFactory.GetFont(FontFactory.HELVETICA_BOLD)));
                        document.Add(new Paragraph($"Check-in Date: {reservation.CheckInDate:dd/MM/yyyy}"));
                        document.Add(new Paragraph($"Check-out Date: {reservation.CheckOutDate:dd/MM/yyyy}"));
                        document.Add(new Paragraph($"Number of Nights: {(reservation.CheckOutDate - reservation.CheckInDate).Days}"));
                        document.Add(new Paragraph("\n"));

                        // Room Details
                        document.Add(new Paragraph("Room Information", FontFactory.GetFont(FontFactory.HELVETICA_BOLD)));
                        document.Add(new Paragraph($"Room Number: {reservation.Room.Id}"));
                        document.Add(new Paragraph($"Room Type: {reservation.Room.RoomType?.Name ?? "Standard"}"));
                        document.Add(new Paragraph("\n"));

                        // Payment Details
                        document.Add(new Paragraph("Payment Information", FontFactory.GetFont(FontFactory.HELVETICA_BOLD)));
                        document.Add(new Paragraph($"Total Amount: ${reservation.TotalPrice:F2}"));
                        document.Add(new Paragraph("\n"));

                        // Terms and Conditions
                        document.Add(new Paragraph("Terms and Conditions", FontFactory.GetFont(FontFactory.HELVETICA_BOLD)));
                        document.Add(new Paragraph("1. Check-in time is 2:00 PM and check-out time is 12:00 PM."));
                        document.Add(new Paragraph("2. Please present this voucher at check-in."));
                        document.Add(new Paragraph("3. Early check-in and late check-out are subject to availability."));

                        document.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error generating PDF: {ex.Message}", ex);
            }
        }
    }
}