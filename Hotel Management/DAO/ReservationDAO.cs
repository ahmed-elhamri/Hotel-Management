using Hotel_Management.Data;
using Hotel_Management.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Win32;
using OfficeOpenXml;
using System.IO;

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
    }
}