using System.Collections.Generic;
using Bogus;
using Hotel_Management.Models;

namespace Hotel_Management.Seeders
{
    public static class PaymentSeeder
    {
        public static List<Payment> Seed(int count, int reservationCount)
        {
            var paymentId = 1;

            var faker = new Faker<Payment>()
                .RuleFor(payment => payment.Id, f => paymentId++)
                .RuleFor(payment => payment.ReservationId, f => f.Random.Number(1, reservationCount))
                .RuleFor(payment => payment.PaymentDate, f => f.Date.Recent(30))
                .RuleFor(payment => payment.Amount, f => Math.Round(f.Random.Double(50, 1000), 2))
                .RuleFor(payment => payment.PaymentMethod, f => f.PickRandom<PMethod>())
                .RuleFor(payment => payment.Status, f => f.PickRandom<PaymentStatus>());

            return faker.Generate(count);
        }
    }
}
