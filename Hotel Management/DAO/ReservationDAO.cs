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
        public int   GetTotalPriceOfConfirmedReservations()
        {

            int totalPrice = (int)(_context.Reservation
                                         .Where(r => r.Status == ReservationStatus.Confirmed)
                                         .Sum(r => r.TotalPrice)); 

            
            return totalPrice;
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
                
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

                using (var package = new ExcelPackage())
                {
                    var worksheet = package.Workbook.Worksheets.Add("Reservations");

                    
                    worksheet.Cells[1, 1].Value = "Reservation ID";
                    worksheet.Cells[1, 2].Value = "Client Name";
                    worksheet.Cells[1, 3].Value = "Room Number";
                    worksheet.Cells[1, 4].Value = "Check-In Date";
                    worksheet.Cells[1, 5].Value = "Check-Out Date";
                    worksheet.Cells[1, 6].Value = "Total Price";
                    worksheet.Cells[1, 7].Value = "Status";

                    
                    using (var headerRange = worksheet.Cells[1, 1, 1, 7])
                    {
                        headerRange.Style.Font.Bold = true;
                        headerRange.Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                        headerRange.Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.LightGray);
                    }

                    
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

                    
                    worksheet.Cells.AutoFitColumns();

                    
                    SaveFileDialog saveFileDialog = new SaveFileDialog
                    {
                        Filter = "Excel Files (*.xlsx)|*.xlsx",
                        DefaultExt = "xlsx",
                        FileName = $"Reservations_{DateTime.Now:yyyyMMdd}"
                    };

                    if (saveFileDialog.ShowDialog() == true)
                    {
                        
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
                    FileName = $"Bon_de_Reservation{reservation.Id}_{DateTime.Now:yyyyMMdd}"
                };

                if (saveFileDialog.ShowDialog() == true)
                {
                    using (FileStream fs = new FileStream(saveFileDialog.FileName, FileMode.Create))
                    {
                        Document document = new Document(PageSize.A4, 25, 25, 30, 30);
                        PdfWriter writer = PdfWriter.GetInstance(document, fs);

                        document.Open();

                        
                        document.Add(new Paragraph("HOTEL MANAGEMENT SYSTEM"));
                        document.Add(new Paragraph("Bon de Réservation") { Alignment = Element.ALIGN_CENTER });
                        document.Add(new Paragraph(new Chunk(new iTextSharp.text.pdf.draw.LineSeparator())));
                        document.Add(new Paragraph("\n"));

                        
                        document.Add(new Paragraph($"Référence de Réservation : #{reservation.Id}"));
                        document.Add(new Paragraph($"Date : {DateTime.Now:dd/MM/yyyy}"));
                        document.Add(new Paragraph("\n"));

                        
                        document.Add(new Paragraph("Informations sur le Client", FontFactory.GetFont(FontFactory.HELVETICA_BOLD)));
                        document.Add(new Paragraph($"Nom : {reservation.Client.FirstName} {reservation.Client.LastName}"));
                        document.Add(new Paragraph($"Email : {reservation.Client.Email}"));
                        document.Add(new Paragraph($"Téléphone : {reservation.Client.PhoneNumber}"));
                        document.Add(new Paragraph("\n"));

                        
                        document.Add(new Paragraph("Détails de la Réservation", FontFactory.GetFont(FontFactory.HELVETICA_BOLD)));
                        document.Add(new Paragraph($"Date d'Arrivée : {reservation.CheckInDate:dd/MM/yyyy}"));
                        document.Add(new Paragraph($"Date de Départ : {reservation.CheckOutDate:dd/MM/yyyy}"));
                        document.Add(new Paragraph($"Nombre de Nuits : {(reservation.CheckOutDate - reservation.CheckInDate).Days}"));
                        document.Add(new Paragraph("\n"));

                        
                        document.Add(new Paragraph("Informations sur la Chambre", FontFactory.GetFont(FontFactory.HELVETICA_BOLD)));
                        document.Add(new Paragraph($"Numéro de Chambre : {reservation.Room.Id}"));
                        document.Add(new Paragraph($"Type de Chambre : {reservation.Room.RoomType?.Name ?? "Standard"}"));
                        document.Add(new Paragraph("\n"));

                        
                        document.Add(new Paragraph("Informations sur le Paiement", FontFactory.GetFont(FontFactory.HELVETICA_BOLD)));
                        document.Add(new Paragraph($"Montant Total : {reservation.TotalPrice:F2} MAD"));
                        document.Add(new Paragraph("\n"));

                        
                        document.Add(new Paragraph("Termes et Conditions", FontFactory.GetFont(FontFactory.HELVETICA_BOLD)));
                        document.Add(new Paragraph("1. L'heure d'arrivée est fixée à 14h00 et l'heure de départ à 12h00."));
                        document.Add(new Paragraph("2. Veuillez présenter ce bon lors de votre arrivée."));
                        document.Add(new Paragraph("3. L'arrivée anticipée et le départ tardif sont soumis à disponibilité."));

                        document.Close();
                        ;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error generating PDF: {ex.Message}", ex);
            }
        }
        public List<Room> GetAvailableRooms(DateTime checkIn, DateTime checkOut)
        {
            try
            {
                
                var allRooms = _context.Room.Include(r => r.RoomType).ToList();

                
                var overlappingReservations = _context.Reservation
                    .Where(r => r.Status != ReservationStatus.Cancelled &&
                               ((r.CheckInDate <= checkIn && r.CheckOutDate > checkIn) ||
                                (r.CheckInDate < checkOut && r.CheckOutDate >= checkOut) ||
                                (r.CheckInDate >= checkIn && r.CheckOutDate <= checkOut)))
                    .Select(r => r.RoomId)
                    .Distinct()
                    .ToList();

                
                return allRooms.Where(r => !overlappingReservations.Contains(r.Id)).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error getting available rooms: {ex.Message}", ex);
            }
        }
        public Dictionary<string, double> GetMonthlyRevenue()
        {
            var reservations = GetAllReservations();

            var confirmedReservations = reservations.Where(r => r.Status == ReservationStatus.Confirmed).ToList();

            var monthlyRevenue = confirmedReservations
                .GroupBy(r => new { r.CheckInDate.Year, r.CheckInDate.Month })
                .Select(g => new
                {
                    Month = $"{g.Key.Month:D2}/{g.Key.Year}",
                    Revenue = g.Sum(r => r.TotalPrice)
                })
                .ToDictionary(g => g.Month, g => g.Revenue);

            return monthlyRevenue;
        }

    }
}
          
    
