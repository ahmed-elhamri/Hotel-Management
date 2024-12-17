using Bogus;
using Hotel_Management.Models;

namespace Hotel_Management.Seeders
{
    public static class RoomSeeder
    {
        public static List<Room> Seed(int count)
        {
            var roomId = 1;

            var faker = new Faker<Room>()
                .RuleFor(room => room.Id, f => roomId++)
                .RuleFor(room => room.Name, f => $"Room {f.Random.Number(100, 500)}")
                .RuleFor(room => room.Capacity, f => f.Random.Number(1, 10))
                .RuleFor(room => room.Price, f => Math.Round(f.Random.Double(50, 1000)))
                .RuleFor(room => room.IsAvailable, f => f.Random.Bool())
                .RuleFor(room => room.RoomTypeId, f => f.Random.Number(1, 3)); // Assuming 3 RoomTypes

            return faker.Generate(count);
        }
    }
}
