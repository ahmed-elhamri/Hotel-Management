using Hotel_Management.Data;
using Hotel_Management.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management.DAO
{
    class UserDAO
    {
        private readonly DatabaseContext _context;

        public UserDAO()
        {
            _context = new DatabaseContext();
        }

        public List<User> GetAllUsers()
        {
            return _context.Users.ToList();
        }

        public List<User> GetAllClients()
        {
            return _context.Users.Where(u => u.Role == UserRole.Client).ToList();
        }

        public List<User> GetAllEmployes()
        {
            return _context.Users.Where(u => u.Role == UserRole.Employe).ToList();
        }

        public User GetUserById(int id)
        {
            return _context.Users.FirstOrDefault(u => u.Id == id);
        }

        public User GetUserByLogin(string email, string password)
        {
            var user = _context.Users.FirstOrDefault(u => u.Email == email);
            if (user != null && BCrypt.Net.BCrypt.Verify(password, user.Password)) return user;
            else return null;
        }

        public void AddUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }

        public void UpdateUser(User user)
        {
            _context.Users.Update(user);
            _context.SaveChanges();
        }

        public void DeleteUser(User user)
        {
            if (user != null)
            {
                _context.Users.Remove(user);
                _context.SaveChanges();
            }
        }
    }
}
