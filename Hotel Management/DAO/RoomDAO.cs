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
            
            return _context.Room.Include(r => r.RoomType).ToList();
        }

        public Room GetRoomById(int id)
        {
            
            return _context.Room.Include(r => r.RoomType).FirstOrDefault(u => u.Id == id);
        }
        public List<Room> GetAvailableRooms()
        {
            return _context.Room.Where(r => r.IsAvailable == true).ToList();
        }
        public int GetAvailableRoomsCount()
        {
            
            int totalRooms = _context.Room.Count();

            int reservedRooms = _context.Reservation
                                        .Where(r => r.Status == ReservationStatus.Confirmed).Count();

            return totalRooms - reservedRooms;
        }
        public void AddRoom(Room room)
        {
            
            room.RoomTypeId = room.RoomType.Id;
            room.RoomType = null;  

            _context.Room.Add(room);
            _context.SaveChanges();
        }

        public void UpdateRoom(Room room)
        {
            using (var freshContext = new DatabaseContext())
            {
                var existingRoom = freshContext.Room.Find(room.Id);
                if (existingRoom != null)
                {
                    existingRoom.Name = room.Name;
                    existingRoom.Capacity = room.Capacity;
                    existingRoom.Price = room.Price;
                    existingRoom.IsAvailable = room.IsAvailable;
                    existingRoom.RoomTypeId = room.RoomType.Id; 

                    freshContext.SaveChanges();
                }
            }
        }

        public void ExportExcel(List<Room> rooms)
        {
            try
            {
                
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

                using (var package = new ExcelPackage())
                {
                    var worksheet = package.Workbook.Worksheets.Add("Reservations");

                    
                    worksheet.Cells[1, 1].Value = "Room ID";
                    worksheet.Cells[1, 2].Value = "Room Name";
                    worksheet.Cells[1, 3].Value = "Room Capacity";
                    worksheet.Cells[1, 4].Value = "Price";
                    worksheet.Cells[1, 5].Value = "IsAvailable";
                    worksheet.Cells[1, 6].Value = "RoomType";
                    

                    
                    using (var headerRange = worksheet.Cells[1, 1, 1, 6])
                    {
                        headerRange.Style.Font.Bold = true;
                        headerRange.Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                        headerRange.Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.LightGray);
                    }

                    
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

                    
                    worksheet.Cells.AutoFitColumns();

                    
                    SaveFileDialog saveFileDialog = new SaveFileDialog
                    {
                        Filter = "Excel Files (*.xlsx)|*.xlsx",
                        DefaultExt = "xlsx",
                        FileName = $"Rooms_{DateTime.Now:yyyyMMdd}"
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
