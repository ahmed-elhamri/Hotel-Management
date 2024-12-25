using Hotel_Management.Data;
using Hotel_Management.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management.DAO
{
    public class RoomTypeDAO
    {
        private readonly DatabaseContext _context;

        public RoomTypeDAO()
        {
            _context = new DatabaseContext();
        }

        public List<RoomType> GetAllRoomTypes()
        {
            return _context.RoomType.ToList();
        }

        public RoomType GetRoomTypeById(int id)
        {
            return _context.RoomType.FirstOrDefault(u => u.Id == id);
        }

        public void AddRoomType(RoomType roomType)
        {
            _context.RoomType.Add(roomType);
            _context.SaveChanges();
        }

        public void UpdateRoomType(RoomType roomType)
        {
            _context.RoomType.Update(roomType);
            _context.SaveChanges();
        }

        public void DeleteRoomType(RoomType roomType)
        {
            if (roomType != null)
            {
                _context.RoomType.Remove(roomType);
                _context.SaveChanges();
            }
        }
    }
}
