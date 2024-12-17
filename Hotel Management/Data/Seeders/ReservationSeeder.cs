using System.Collections.Generic;
using Bogus;
using Hotel_Management.Models;

namespace Hotel_Management.Seeders
{
    public static class ReservationSeeder
    {
        public static List<Reservation> Seed(int count, int userCount, int roomCount)
        {
            var reservationId = 1;

            var faker = new Faker<Reservation>()
                .RuleFor(r => r.Id, f => reservationId++)
                .RuleFor(reservation => reservation.UserId, f => f.Random.Number(1, userCount))
                .RuleFor(reservation => reservation.RoomId, f => f.Random.Number(1, roomCount))
                .RuleFor(reservation => reservation.CheckInDate, f => f.Date.Between(DateTime.Now.AddDays(-30), DateTime.Now.AddDays(30)))
                .RuleFor(reservation => reservation.CheckOutDate, (f, reservation) => reservation.CheckInDate.AddDays(f.Random.Number(1, 10)))
                .RuleFor(reservation => reservation.TotalPrice, f => Math.Round(f.Random.Double(100, 5000)))
                .RuleFor(reservation => reservation.Status, f => f.PickRandom<ReservationStatus>());

            return faker.Generate(count);
        }
    }
}
