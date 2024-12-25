using Hotel_Management.Data;
using Hotel_Management.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            return _context.Rooms.ToList();
        }

        public Room GetRoomById(int id)
        {
            return _context.Rooms.FirstOrDefault(u => u.Id == id);
        }

        public void AddRoom(Room room)
        {
            _context.Rooms.Add(room);
            _context.SaveChanges();
        }

        public void UpdateRoom(Room room)
        {
            _context.Rooms.Update(room);
            _context.SaveChanges();
        }

        public void DeleteRoom(Room room)
        {
            if (room != null)
            {
                _context.Rooms.Remove(room);
                _context.SaveChanges();
            }
        }
    }
}
