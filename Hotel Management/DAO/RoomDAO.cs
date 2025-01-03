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
    public class RoomDAO
    {
        private readonly DatabaseContext _context;

        public RoomDAO()
        {
            _context = new DatabaseContext();
        }

        public List<Room> GetAllRooms()
        {
            // Fetch Rooms and include the RoomType properly
            return _context.Room.Include(r => r.RoomType).ToList();
        }

        public Room GetRoomById(int id)
        {
            // Include RoomType without causing tracking issues
            return _context.Room.Include(r => r.RoomType).FirstOrDefault(u => u.Id == id);
        }

        public void AddRoom(Room room)
        {
            // Only set the foreign key, not the navigation property
            room.RoomTypeId = room.RoomType.Id;
            room.RoomType = null;  // Clear the navigation property

            _context.Room.Add(room);
            _context.SaveChanges();
        }

        public void UpdateRoom(Room room)
        {
            var existingRoom = _context.Room
                .Include(r => r.RoomType)
                .FirstOrDefault(r => r.Id == room.Id);

            if (existingRoom != null)
            {
                existingRoom.Name = room.Name;
                existingRoom.Capacity = room.Capacity;
                existingRoom.Price = room.Price;
                existingRoom.IsAvailable = room.IsAvailable;

                // Update RoomType if changed
                if (existingRoom.RoomTypeId != room.RoomType.Id)
                {
                    existingRoom.RoomTypeId = room.RoomType.Id;
                }

                _context.SaveChanges();
            }
        }


        public void ExportExcel(List<Room> rooms)
        {
            try
            {
                // Set EPPlus license context
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

                using (var package = new ExcelPackage())
                {
                    var worksheet = package.Workbook.Worksheets.Add("Reservations");

                    // Add headers
                    worksheet.Cells[1, 1].Value = "Room ID";
                    worksheet.Cells[1, 2].Value = "Room Name";
                    worksheet.Cells[1, 3].Value = "Room Capacity";
                    worksheet.Cells[1, 4].Value = "Price";
                    worksheet.Cells[1, 5].Value = "IsAvailable";
                    worksheet.Cells[1, 6].Value = "RoomType";
                    

                    // Style the header
                    using (var headerRange = worksheet.Cells[1, 1, 1, 6])
                    {
                        headerRange.Style.Font.Bold = true;
                        headerRange.Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                        headerRange.Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.LightGray);
                    }

                    // Add data
                    int row = 2;
                    foreach (var room in rooms)
                    {
                        worksheet.Cells[row, 1].Value =room.Id;
                        worksheet.Cells[row, 2].Value = room.Name;
                        worksheet.Cells[row, 3].Value = room.Capacity;
                        worksheet.Cells[row, 4].Value = room.Price;
                        worksheet.Cells[row, 5].Value = room.IsAvailable;
                        worksheet.Cells[row, 6].Value = room.RoomType?.Name;          

                        row++;
                    }

                    // Auto-fit columns
                    worksheet.Cells.AutoFitColumns();

                    // Create save file dialog
                    SaveFileDialog saveFileDialog = new SaveFileDialog
                    {
                        Filter = "Excel Files (*.xlsx)|*.xlsx",
                        DefaultExt = "xlsx",
                        FileName = $"Rooms_{DateTime.Now:yyyyMMdd}"
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

        public void DeleteRoom(Room room)
        {
            if (room != null)
            {
                _context.Room.Remove(room);
                _context.SaveChanges();
            }
        }
    }
}
