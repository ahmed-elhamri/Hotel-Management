using Bogus;
using Hotel_Management.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management.Data.Seeders
{
    class UserSeeder
    {
        private readonly DatabaseContext _context;

        public UserSeeder(DatabaseContext context)
        {
            _context = context;
        }

        public static List<User> Seed(int count)
        {
            var userId = 2;
            var faker = new Faker<User>()
                .RuleFor(r => r.Id, f => userId++)
                .RuleFor(user => user.FirstName, f => f.Name.FirstName())
                .RuleFor(user => user.LastName, f => f.Name.LastName())
                .RuleFor(user => user.FirstName, f => f.Name.FirstName())
                .RuleFor(user => user.PhoneNumber, f => f.Phone.PhoneNumber())
                .RuleFor(user => user.Email, f => f.Internet.Email())
                .RuleFor(user => user.Password, f => PasswordHasher.HashPassword("DefaultPassword123"))
                .RuleFor(user => user.Role, f => f.PickRandom<UserRole>());

            return faker.Generate(count);
        }
    }
}
