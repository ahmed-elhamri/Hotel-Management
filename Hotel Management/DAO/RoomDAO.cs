using Hotel_Management.Data;
using Hotel_Management.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

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
            using (var freshContext = new DatabaseContext())
            {
                var existingRoom = freshContext.Room.Find(room.Id);
                if (existingRoom != null)
                {
                    existingRoom.Name = room.Name;
                    existingRoom.Capacity = room.Capacity;
                    existingRoom.Price = room.Price;
                    existingRoom.IsAvailable = room.IsAvailable;
                    existingRoom.RoomTypeId = room.RoomType.Id; // Only use the ID

                    freshContext.SaveChanges();
                }
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
