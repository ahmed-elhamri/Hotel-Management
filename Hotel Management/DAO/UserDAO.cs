using Hotel_Management.Data;
using Hotel_Management.Models;
using Microsoft.AspNet.Identity;
using Microsoft.Win32;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


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

        public void ExportExcel(List<User> users)
        {
            try
            {
                // Set EPPlus license context
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

                using (var package = new ExcelPackage())
                {
                    var worksheet = package.Workbook.Worksheets.Add("Reservations");

                    // Add headers
                    worksheet.Cells[1, 1].Value = "Employe ID";
                    worksheet.Cells[1, 2].Value = "FirstName";
                    worksheet.Cells[1, 3].Value = "LastName";
                    worksheet.Cells[1, 4].Value = "PhoneNumber";
                    worksheet.Cells[1, 5].Value = "Email";
         

                    // Style the header
                    using (var headerRange = worksheet.Cells[1, 1, 1, 5])
                    {
                        headerRange.Style.Font.Bold = true;
                        headerRange.Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                        headerRange.Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.LightGray);
                    }

                    // Add data
                    int row = 2;
                    foreach (var user in users)
                    {
                        worksheet.Cells[row, 1].Value = user.Id;
                        worksheet.Cells[row, 2].Value = user.FirstName;
                        worksheet.Cells[row, 3].Value = user.LastName;
                        worksheet.Cells[row, 4].Value = user.PhoneNumber;
                        worksheet.Cells[row, 5].Value = user.Email;

                        row++;
                    }

                    // Auto-fit columns
                    worksheet.Cells.AutoFitColumns();

                    // Create save file dialog
                    SaveFileDialog saveFileDialog = new SaveFileDialog
                    {
                        Filter = "Excel Files (*.xlsx)|*.xlsx",
                        DefaultExt = "xlsx",
                        FileName = $"Employes_{DateTime.Now:yyyyMMdd}"
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
    }
}
