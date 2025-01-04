
using System;
using Hotel_Management.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Hotel_Management.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Hotel_Management.Models.Payment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<double>("Amount")
                        .HasColumnType("double");

                    b.Property<DateTime>("PaymentDate")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("PaymentMethod")
                        .HasColumnType("int");

                    b.Property<int>("ReservationId")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ReservationId");

                    b.ToTable("Payment");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Amount = 560.86000000000001,
                            PaymentDate = new DateTime(2024, 12, 4, 20, 6, 6, 320, DateTimeKind.Local).AddTicks(4328),
                            PaymentMethod = 0,
                            ReservationId = 98,
                            Status = 0
                        },
                        new
                        {
                            Id = 2,
                            Amount = 797.04999999999995,
                            PaymentDate = new DateTime(2024, 12, 15, 18, 56, 8, 905, DateTimeKind.Local).AddTicks(2211),
                            PaymentMethod = 0,
                            ReservationId = 93,
                            Status = 1
                        },
                        new
                        {
                            Id = 3,
                            Amount = 838.89999999999998,
                            PaymentDate = new DateTime(2024, 12, 17, 8, 42, 47, 249, DateTimeKind.Local).AddTicks(1013),
                            PaymentMethod = 0,
                            ReservationId = 49,
                            Status = 1
                        },
                        new
                        {
                            Id = 4,
                            Amount = 593.63,
                            PaymentDate = new DateTime(2024, 12, 25, 20, 52, 25, 968, DateTimeKind.Local).AddTicks(2349),
                            PaymentMethod = 0,
                            ReservationId = 67,
                            Status = 1
                        },
                        new
                        {
                            Id = 5,
                            Amount = 561.98000000000002,
                            PaymentDate = new DateTime(2024, 12, 13, 14, 27, 5, 516, DateTimeKind.Local).AddTicks(806),
                            PaymentMethod = 1,
                            ReservationId = 65,
                            Status = 0
                        },
                        new
                        {
                            Id = 6,
                            Amount = 496.14999999999998,
                            PaymentDate = new DateTime(2024, 12, 20, 22, 33, 51, 947, DateTimeKind.Local).AddTicks(5181),
                            PaymentMethod = 1,
                            ReservationId = 83,
                            Status = 1
                        },
                        new
                        {
                            Id = 7,
                            Amount = 503.22000000000003,
                            PaymentDate = new DateTime(2024, 12, 31, 1, 11, 9, 12, DateTimeKind.Local).AddTicks(3184),
                            PaymentMethod = 1,
                            ReservationId = 91,
                            Status = 0
                        },
                        new
                        {
                            Id = 8,
                            Amount = 595.25999999999999,
                            PaymentDate = new DateTime(2024, 12, 30, 17, 16, 35, 332, DateTimeKind.Local).AddTicks(5028),
                            PaymentMethod = 1,
                            ReservationId = 75,
                            Status = 0
                        },
                        new
                        {
                            Id = 9,
                            Amount = 367.13999999999999,
                            PaymentDate = new DateTime(2024, 12, 15, 23, 13, 30, 699, DateTimeKind.Local).AddTicks(1608),
                            PaymentMethod = 1,
                            ReservationId = 22,
                            Status = 1
                        },
                        new
                        {
                            Id = 10,
                            Amount = 587.53999999999996,
                            PaymentDate = new DateTime(2024, 12, 28, 1, 34, 37, 206, DateTimeKind.Local).AddTicks(410),
                            PaymentMethod = 1,
                            ReservationId = 33,
                            Status = 0
                        },
                        new
                        {
                            Id = 11,
                            Amount = 79.349999999999994,
                            PaymentDate = new DateTime(2024, 12, 24, 19, 17, 56, 683, DateTimeKind.Local).AddTicks(7435),
                            PaymentMethod = 0,
                            ReservationId = 87,
                            Status = 1
                        },
                        new
                        {
                            Id = 12,
                            Amount = 696.40999999999997,
                            PaymentDate = new DateTime(2024, 12, 22, 8, 28, 14, 33, DateTimeKind.Local).AddTicks(9610),
                            PaymentMethod = 0,
                            ReservationId = 89,
                            Status = 0
                        },
                        new
                        {
                            Id = 13,
                            Amount = 517.99000000000001,
                            PaymentDate = new DateTime(2025, 1, 3, 16, 56, 33, 797, DateTimeKind.Local).AddTicks(9788),
                            PaymentMethod = 1,
                            ReservationId = 31,
                            Status = 0
                        },
                        new
                        {
                            Id = 14,
                            Amount = 860.40999999999997,
                            PaymentDate = new DateTime(2024, 12, 8, 18, 4, 6, 197, DateTimeKind.Local).AddTicks(3106),
                            PaymentMethod = 1,
                            ReservationId = 45,
                            Status = 0
                        },
                        new
                        {
                            Id = 15,
                            Amount = 59.409999999999997,
                            PaymentDate = new DateTime(2024, 12, 5, 14, 47, 11, 842, DateTimeKind.Local).AddTicks(7803),
                            PaymentMethod = 1,
                            ReservationId = 71,
                            Status = 0
                        },
                        new
                        {
                            Id = 16,
                            Amount = 319.37,
                            PaymentDate = new DateTime(2025, 1, 2, 7, 22, 6, 211, DateTimeKind.Local).AddTicks(2276),
                            PaymentMethod = 0,
                            ReservationId = 6,
                            Status = 1
                        },
                        new
                        {
                            Id = 17,
                            Amount = 568.50999999999999,
                            PaymentDate = new DateTime(2024, 12, 24, 8, 56, 31, 574, DateTimeKind.Local).AddTicks(4018),
                            PaymentMethod = 0,
                            ReservationId = 20,
                            Status = 0
                        },
                        new
                        {
                            Id = 18,
                            Amount = 897.47000000000003,
                            PaymentDate = new DateTime(2024, 12, 8, 7, 33, 37, 157, DateTimeKind.Local).AddTicks(7864),
                            PaymentMethod = 1,
                            ReservationId = 95,
                            Status = 0
                        },
                        new
                        {
                            Id = 19,
                            Amount = 159.15000000000001,
                            PaymentDate = new DateTime(2024, 12, 7, 11, 34, 8, 538, DateTimeKind.Local).AddTicks(7664),
                            PaymentMethod = 0,
                            ReservationId = 56,
                            Status = 0
                        },
                        new
                        {
                            Id = 20,
                            Amount = 797.14999999999998,
                            PaymentDate = new DateTime(2024, 12, 23, 0, 13, 57, 595, DateTimeKind.Local).AddTicks(3697),
                            PaymentMethod = 1,
                            ReservationId = 45,
                            Status = 1
                        },
                        new
                        {
                            Id = 21,
                            Amount = 692.63,
                            PaymentDate = new DateTime(2024, 12, 11, 19, 23, 7, 507, DateTimeKind.Local).AddTicks(329),
                            PaymentMethod = 0,
                            ReservationId = 39,
                            Status = 0
                        },
                        new
                        {
                            Id = 22,
                            Amount = 366.72000000000003,
                            PaymentDate = new DateTime(2024, 12, 23, 22, 8, 4, 968, DateTimeKind.Local).AddTicks(4433),
                            PaymentMethod = 0,
                            ReservationId = 61,
                            Status = 1
                        },
                        new
                        {
                            Id = 23,
                            Amount = 311.37,
                            PaymentDate = new DateTime(2024, 12, 8, 2, 0, 6, 295, DateTimeKind.Local).AddTicks(2290),
                            PaymentMethod = 0,
                            ReservationId = 61,
                            Status = 1
                        },
                        new
                        {
                            Id = 24,
                            Amount = 582.07000000000005,
                            PaymentDate = new DateTime(2024, 12, 4, 21, 6, 34, 974, DateTimeKind.Local).AddTicks(8663),
                            PaymentMethod = 1,
                            ReservationId = 67,
                            Status = 1
                        },
                        new
                        {
                            Id = 25,
                            Amount = 424.79000000000002,
                            PaymentDate = new DateTime(2024, 12, 28, 0, 33, 7, 290, DateTimeKind.Local).AddTicks(8410),
                            PaymentMethod = 1,
                            ReservationId = 73,
                            Status = 0
                        },
                        new
                        {
                            Id = 26,
                            Amount = 910.98000000000002,
                            PaymentDate = new DateTime(2024, 12, 19, 20, 47, 22, 113, DateTimeKind.Local).AddTicks(212),
                            PaymentMethod = 0,
                            ReservationId = 38,
                            Status = 1
                        },
                        new
                        {
                            Id = 27,
                            Amount = 134.56,
                            PaymentDate = new DateTime(2024, 12, 10, 14, 27, 32, 122, DateTimeKind.Local).AddTicks(8838),
                            PaymentMethod = 0,
                            ReservationId = 61,
                            Status = 1
                        },
                        new
                        {
                            Id = 28,
                            Amount = 842.75999999999999,
                            PaymentDate = new DateTime(2024, 12, 20, 23, 46, 31, 11, DateTimeKind.Local).AddTicks(7542),
                            PaymentMethod = 0,
                            ReservationId = 79,
                            Status = 0
                        },
                        new
                        {
                            Id = 29,
                            Amount = 612.09000000000003,
                            PaymentDate = new DateTime(2024, 12, 15, 6, 34, 36, 737, DateTimeKind.Local).AddTicks(5330),
                            PaymentMethod = 0,
                            ReservationId = 3,
                            Status = 0
                        },
                        new
                        {
                            Id = 30,
                            Amount = 762.01999999999998,
                            PaymentDate = new DateTime(2024, 12, 20, 8, 28, 2, 385, DateTimeKind.Local).AddTicks(8804),
                            PaymentMethod = 1,
                            ReservationId = 53,
                            Status = 0
                        },
                        new
                        {
                            Id = 31,
                            Amount = 284.45999999999998,
                            PaymentDate = new DateTime(2024, 12, 22, 1, 44, 34, 644, DateTimeKind.Local).AddTicks(162),
                            PaymentMethod = 1,
                            ReservationId = 19,
                            Status = 0
                        },
                        new
                        {
                            Id = 32,
                            Amount = 725.19000000000005,
                            PaymentDate = new DateTime(2024, 12, 5, 3, 34, 45, 848, DateTimeKind.Local).AddTicks(9557),
                            PaymentMethod = 1,
                            ReservationId = 10,
                            Status = 0
                        },
                        new
                        {
                            Id = 33,
                            Amount = 990.38,
                            PaymentDate = new DateTime(2024, 12, 26, 9, 19, 32, 348, DateTimeKind.Local).AddTicks(4029),
                            PaymentMethod = 1,
                            ReservationId = 11,
                            Status = 0
                        },
                        new
                        {
                            Id = 34,
                            Amount = 404.24000000000001,
                            PaymentDate = new DateTime(2024, 12, 19, 11, 19, 8, 821, DateTimeKind.Local).AddTicks(5375),
                            PaymentMethod = 1,
                            ReservationId = 54,
                            Status = 1
                        },
                        new
                        {
                            Id = 35,
                            Amount = 273.44,
                            PaymentDate = new DateTime(2024, 12, 6, 3, 8, 36, 65, DateTimeKind.Local).AddTicks(2167),
                            PaymentMethod = 1,
                            ReservationId = 62,
                            Status = 0
                        },
                        new
                        {
                            Id = 36,
                            Amount = 295.89999999999998,
                            PaymentDate = new DateTime(2024, 12, 7, 0, 0, 52, 947, DateTimeKind.Local).AddTicks(5224),
                            PaymentMethod = 0,
                            ReservationId = 80,
                            Status = 0
                        },
                        new
                        {
                            Id = 37,
                            Amount = 786.25999999999999,
                            PaymentDate = new DateTime(2024, 12, 28, 9, 24, 27, 632, DateTimeKind.Local).AddTicks(4220),
                            PaymentMethod = 1,
                            ReservationId = 22,
                            Status = 1
                        },
                        new
                        {
                            Id = 38,
                            Amount = 945.94000000000005,
                            PaymentDate = new DateTime(2024, 12, 7, 2, 46, 27, 482, DateTimeKind.Local).AddTicks(8904),
                            PaymentMethod = 1,
                            ReservationId = 95,
                            Status = 1
                        },
                        new
                        {
                            Id = 39,
                            Amount = 462.47000000000003,
                            PaymentDate = new DateTime(2024, 12, 16, 15, 58, 15, 999, DateTimeKind.Local).AddTicks(296),
                            PaymentMethod = 0,
                            ReservationId = 44,
                            Status = 0
                        },
                        new
                        {
                            Id = 40,
                            Amount = 97.439999999999998,
                            PaymentDate = new DateTime(2024, 12, 21, 8, 50, 25, 68, DateTimeKind.Local).AddTicks(9642),
                            PaymentMethod = 0,
                            ReservationId = 68,
                            Status = 1
                        },
                        new
                        {
                            Id = 41,
                            Amount = 199.72999999999999,
                            PaymentDate = new DateTime(2024, 12, 17, 18, 34, 35, 999, DateTimeKind.Local).AddTicks(7457),
                            PaymentMethod = 0,
                            ReservationId = 26,
                            Status = 1
                        },
                        new
                        {
                            Id = 42,
                            Amount = 212.33000000000001,
                            PaymentDate = new DateTime(2024, 12, 22, 4, 16, 2, 608, DateTimeKind.Local).AddTicks(1089),
                            PaymentMethod = 1,
                            ReservationId = 29,
                            Status = 0
                        },
                        new
                        {
                            Id = 43,
                            Amount = 920.03999999999996,
                            PaymentDate = new DateTime(2024, 12, 24, 5, 52, 54, 425, DateTimeKind.Local).AddTicks(9406),
                            PaymentMethod = 1,
                            ReservationId = 30,
                            Status = 1
                        },
                        new
                        {
                            Id = 44,
                            Amount = 305.69999999999999,
                            PaymentDate = new DateTime(2024, 12, 8, 11, 37, 46, 505, DateTimeKind.Local).AddTicks(6850),
                            PaymentMethod = 1,
                            ReservationId = 79,
                            Status = 0
                        },
                        new
                        {
                            Id = 45,
                            Amount = 629.38,
                            PaymentDate = new DateTime(2025, 1, 1, 5, 38, 57, 241, DateTimeKind.Local).AddTicks(6227),
                            PaymentMethod = 0,
                            ReservationId = 13,
                            Status = 1
                        },
                        new
                        {
                            Id = 46,
                            Amount = 382.24000000000001,
                            PaymentDate = new DateTime(2024, 12, 6, 22, 28, 8, 607, DateTimeKind.Local).AddTicks(6537),
                            PaymentMethod = 1,
                            ReservationId = 20,
                            Status = 0
                        },
                        new
                        {
                            Id = 47,
                            Amount = 147.96000000000001,
                            PaymentDate = new DateTime(2024, 12, 24, 0, 36, 25, 992, DateTimeKind.Local).AddTicks(388),
                            PaymentMethod = 0,
                            ReservationId = 5,
                            Status = 0
                        },
                        new
                        {
                            Id = 48,
                            Amount = 67.849999999999994,
                            PaymentDate = new DateTime(2024, 12, 8, 0, 1, 45, 142, DateTimeKind.Local).AddTicks(1652),
                            PaymentMethod = 0,
                            ReservationId = 51,
                            Status = 1
                        },
                        new
                        {
                            Id = 49,
                            Amount = 563.01999999999998,
                            PaymentDate = new DateTime(2024, 12, 31, 8, 20, 28, 161, DateTimeKind.Local).AddTicks(1116),
                            PaymentMethod = 0,
                            ReservationId = 30,
                            Status = 0
                        },
                        new
                        {
                            Id = 50,
                            Amount = 613.59000000000003,
                            PaymentDate = new DateTime(2024, 12, 9, 11, 5, 13, 970, DateTimeKind.Local).AddTicks(5435),
                            PaymentMethod = 1,
                            ReservationId = 22,
                            Status = 1
                        },
                        new
                        {
                            Id = 51,
                            Amount = 708.54999999999995,
                            PaymentDate = new DateTime(2024, 12, 22, 2, 52, 53, 140, DateTimeKind.Local).AddTicks(2079),
                            PaymentMethod = 0,
                            ReservationId = 85,
                            Status = 0
                        },
                        new
                        {
                            Id = 52,
                            Amount = 462.22000000000003,
                            PaymentDate = new DateTime(2024, 12, 14, 13, 39, 19, 641, DateTimeKind.Local).AddTicks(9756),
                            PaymentMethod = 0,
                            ReservationId = 16,
                            Status = 1
                        },
                        new
                        {
                            Id = 53,
                            Amount = 941.32000000000005,
                            PaymentDate = new DateTime(2024, 12, 7, 12, 46, 27, 887, DateTimeKind.Local).AddTicks(2911),
                            PaymentMethod = 1,
                            ReservationId = 45,
                            Status = 1
                        },
                        new
                        {
                            Id = 54,
                            Amount = 413.0,
                            PaymentDate = new DateTime(2024, 12, 20, 17, 57, 38, 945, DateTimeKind.Local).AddTicks(4409),
                            PaymentMethod = 1,
                            ReservationId = 40,
                            Status = 0
                        },
                        new
                        {
                            Id = 55,
                            Amount = 466.0,
                            PaymentDate = new DateTime(2024, 12, 16, 18, 45, 10, 358, DateTimeKind.Local).AddTicks(4960),
                            PaymentMethod = 1,
                            ReservationId = 98,
                            Status = 0
                        },
                        new
                        {
                            Id = 56,
                            Amount = 90.969999999999999,
                            PaymentDate = new DateTime(2024, 12, 18, 13, 7, 42, 395, DateTimeKind.Local).AddTicks(8302),
                            PaymentMethod = 1,
                            ReservationId = 49,
                            Status = 1
                        },
                        new
                        {
                            Id = 57,
                            Amount = 113.68000000000001,
                            PaymentDate = new DateTime(2024, 12, 9, 12, 20, 26, 771, DateTimeKind.Local).AddTicks(4644),
                            PaymentMethod = 0,
                            ReservationId = 71,
                            Status = 0
                        },
                        new
                        {
                            Id = 58,
                            Amount = 377.48000000000002,
                            PaymentDate = new DateTime(2024, 12, 6, 1, 11, 41, 254, DateTimeKind.Local).AddTicks(2619),
                            PaymentMethod = 0,
                            ReservationId = 32,
                            Status = 0
                        },
                        new
                        {
                            Id = 59,
                            Amount = 126.5,
                            PaymentDate = new DateTime(2024, 12, 22, 5, 42, 24, 817, DateTimeKind.Local).AddTicks(9798),
                            PaymentMethod = 0,
                            ReservationId = 6,
                            Status = 1
                        },
                        new
                        {
                            Id = 60,
                            Amount = 129.13999999999999,
                            PaymentDate = new DateTime(2024, 12, 23, 8, 1, 39, 997, DateTimeKind.Local).AddTicks(9253),
                            PaymentMethod = 0,
                            ReservationId = 7,
                            Status = 0
                        },
                        new
                        {
                            Id = 61,
                            Amount = 251.24000000000001,
                            PaymentDate = new DateTime(2024, 12, 26, 3, 24, 26, 621, DateTimeKind.Local).AddTicks(7561),
                            PaymentMethod = 0,
                            ReservationId = 24,
                            Status = 1
                        },
                        new
                        {
                            Id = 62,
                            Amount = 208.44,
                            PaymentDate = new DateTime(2024, 12, 18, 1, 25, 16, 770, DateTimeKind.Local).AddTicks(6),
                            PaymentMethod = 0,
                            ReservationId = 50,
                            Status = 0
                        },
                        new
                        {
                            Id = 63,
                            Amount = 84.560000000000002,
                            PaymentDate = new DateTime(2024, 12, 8, 10, 57, 36, 551, DateTimeKind.Local).AddTicks(746),
                            PaymentMethod = 1,
                            ReservationId = 12,
                            Status = 0
                        },
                        new
                        {
                            Id = 64,
                            Amount = 891.95000000000005,
                            PaymentDate = new DateTime(2024, 12, 11, 1, 57, 9, 323, DateTimeKind.Local).AddTicks(9998),
                            PaymentMethod = 0,
                            ReservationId = 6,
                            Status = 0
                        },
                        new
                        {
                            Id = 65,
                            Amount = 294.86000000000001,
                            PaymentDate = new DateTime(2024, 12, 7, 14, 5, 36, 522, DateTimeKind.Local).AddTicks(3305),
                            PaymentMethod = 0,
                            ReservationId = 62,
                            Status = 1
                        },
                        new
                        {
                            Id = 66,
                            Amount = 733.82000000000005,
                            PaymentDate = new DateTime(2025, 1, 2, 15, 7, 38, 649, DateTimeKind.Local).AddTicks(6931),
                            PaymentMethod = 0,
                            ReservationId = 24,
                            Status = 1
                        },
                        new
                        {
                            Id = 67,
                            Amount = 194.56999999999999,
                            PaymentDate = new DateTime(2024, 12, 26, 23, 4, 47, 605, DateTimeKind.Local).AddTicks(4488),
                            PaymentMethod = 0,
                            ReservationId = 36,
                            Status = 1
                        },
                        new
                        {
                            Id = 68,
                            Amount = 202.16999999999999,
                            PaymentDate = new DateTime(2024, 12, 20, 17, 31, 14, 849, DateTimeKind.Local).AddTicks(747),
                            PaymentMethod = 0,
                            ReservationId = 31,
                            Status = 1
                        },
                        new
                        {
                            Id = 69,
                            Amount = 198.56,
                            PaymentDate = new DateTime(2024, 12, 5, 22, 49, 59, 25, DateTimeKind.Local).AddTicks(7136),
                            PaymentMethod = 0,
                            ReservationId = 15,
                            Status = 1
                        },
                        new
                        {
                            Id = 70,
                            Amount = 201.72999999999999,
                            PaymentDate = new DateTime(2024, 12, 7, 9, 12, 5, 454, DateTimeKind.Local).AddTicks(6348),
                            PaymentMethod = 0,
                            ReservationId = 55,
                            Status = 1
                        },
                        new
                        {
                            Id = 71,
                            Amount = 541.13,
                            PaymentDate = new DateTime(2024, 12, 5, 8, 31, 21, 346, DateTimeKind.Local).AddTicks(5290),
                            PaymentMethod = 0,
                            ReservationId = 27,
                            Status = 1
                        },
                        new
                        {
                            Id = 72,
                            Amount = 130.24000000000001,
                            PaymentDate = new DateTime(2024, 12, 18, 12, 16, 53, 612, DateTimeKind.Local).AddTicks(9777),
                            PaymentMethod = 1,
                            ReservationId = 34,
                            Status = 0
                        },
                        new
                        {
                            Id = 73,
                            Amount = 533.38,
                            PaymentDate = new DateTime(2024, 12, 29, 16, 12, 32, 550, DateTimeKind.Local).AddTicks(5233),
                            PaymentMethod = 1,
                            ReservationId = 3,
                            Status = 0
                        },
                        new
                        {
                            Id = 74,
                            Amount = 248.78,
                            PaymentDate = new DateTime(2024, 12, 8, 19, 17, 47, 285, DateTimeKind.Local).AddTicks(2702),
                            PaymentMethod = 0,
                            ReservationId = 59,
                            Status = 1
                        },
                        new
                        {
                            Id = 75,
                            Amount = 672.01999999999998,
                            PaymentDate = new DateTime(2024, 12, 14, 13, 59, 21, 25, DateTimeKind.Local).AddTicks(5543),
                            PaymentMethod = 1,
                            ReservationId = 50,
                            Status = 1
                        },
                        new
                        {
                            Id = 76,
                            Amount = 947.38,
                            PaymentDate = new DateTime(2024, 12, 19, 21, 36, 38, 308, DateTimeKind.Local).AddTicks(3707),
                            PaymentMethod = 0,
                            ReservationId = 1,
                            Status = 0
                        },
                        new
                        {
                            Id = 77,
                            Amount = 591.0,
                            PaymentDate = new DateTime(2024, 12, 9, 9, 14, 7, 448, DateTimeKind.Local).AddTicks(65),
                            PaymentMethod = 0,
                            ReservationId = 61,
                            Status = 1
                        },
                        new
                        {
                            Id = 78,
                            Amount = 341.16000000000003,
                            PaymentDate = new DateTime(2024, 12, 15, 13, 13, 40, 355, DateTimeKind.Local).AddTicks(1428),
                            PaymentMethod = 1,
                            ReservationId = 56,
                            Status = 1
                        },
                        new
                        {
                            Id = 79,
                            Amount = 644.94000000000005,
                            PaymentDate = new DateTime(2024, 12, 5, 20, 53, 3, 954, DateTimeKind.Local).AddTicks(7398),
                            PaymentMethod = 1,
                            ReservationId = 69,
                            Status = 1
                        },
                        new
                        {
                            Id = 80,
                            Amount = 722.44000000000005,
                            PaymentDate = new DateTime(2024, 12, 18, 0, 20, 45, 20, DateTimeKind.Local).AddTicks(7971),
                            PaymentMethod = 0,
                            ReservationId = 89,
                            Status = 0
                        });
                });

            modelBuilder.Entity("Hotel_Management.Models.Reservation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CheckInDate")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("CheckOutDate")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("RoomId")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<double>("TotalPrice")
                        .HasColumnType("double");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoomId");

                    b.HasIndex("UserId");

                    b.ToTable("Reservation");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CheckInDate = new DateTime(2025, 1, 25, 22, 39, 9, 631, DateTimeKind.Local).AddTicks(6077),
                            CheckOutDate = new DateTime(2025, 2, 2, 22, 39, 9, 631, DateTimeKind.Local).AddTicks(6077),
                            RoomId = 19,
                            Status = 0,
                            TotalPrice = 2575.0,
                            UserId = 8
                        },
                        new
                        {
                            Id = 2,
                            CheckInDate = new DateTime(2024, 12, 8, 14, 26, 51, 731, DateTimeKind.Local).AddTicks(300),
                            CheckOutDate = new DateTime(2024, 12, 15, 14, 26, 51, 731, DateTimeKind.Local).AddTicks(300),
                            RoomId = 28,
                            Status = 1,
                            TotalPrice = 3671.0,
                            UserId = 5
                        },
                        new
                        {
                            Id = 3,
                            CheckInDate = new DateTime(2025, 1, 25, 2, 16, 31, 724, DateTimeKind.Local).AddTicks(9919),
                            CheckOutDate = new DateTime(2025, 1, 28, 2, 16, 31, 724, DateTimeKind.Local).AddTicks(9919),
                            RoomId = 20,
                            Status = 1,
                            TotalPrice = 2411.0,
                            UserId = 6
                        },
                        new
                        {
                            Id = 4,
                            CheckInDate = new DateTime(2025, 1, 19, 20, 49, 45, 571, DateTimeKind.Local).AddTicks(1767),
                            CheckOutDate = new DateTime(2025, 1, 22, 20, 49, 45, 571, DateTimeKind.Local).AddTicks(1767),
                            RoomId = 14,
                            Status = 0,
                            TotalPrice = 4111.0,
                            UserId = 9
                        },
                        new
                        {
                            Id = 5,
                            CheckInDate = new DateTime(2025, 1, 7, 0, 43, 16, 161, DateTimeKind.Local).AddTicks(499),
                            CheckOutDate = new DateTime(2025, 1, 12, 0, 43, 16, 161, DateTimeKind.Local).AddTicks(499),
                            RoomId = 30,
                            Status = 0,
                            TotalPrice = 4921.0,
                            UserId = 9
                        },
                        new
                        {
                            Id = 6,
                            CheckInDate = new DateTime(2024, 12, 29, 13, 57, 8, 513, DateTimeKind.Local).AddTicks(3244),
                            CheckOutDate = new DateTime(2024, 12, 30, 13, 57, 8, 513, DateTimeKind.Local).AddTicks(3244),
                            RoomId = 20,
                            Status = 1,
                            TotalPrice = 3172.0,
                            UserId = 2
                        },
                        new
                        {
                            Id = 7,
                            CheckInDate = new DateTime(2025, 2, 1, 2, 12, 32, 31, DateTimeKind.Local).AddTicks(7360),
                            CheckOutDate = new DateTime(2025, 2, 7, 2, 12, 32, 31, DateTimeKind.Local).AddTicks(7360),
                            RoomId = 43,
                            Status = 0,
                            TotalPrice = 354.0,
                            UserId = 4
                        },
                        new
                        {
                            Id = 8,
                            CheckInDate = new DateTime(2024, 12, 13, 4, 40, 41, 65, DateTimeKind.Local).AddTicks(6274),
                            CheckOutDate = new DateTime(2024, 12, 16, 4, 40, 41, 65, DateTimeKind.Local).AddTicks(6274),
                            RoomId = 48,
                            Status = 2,
                            TotalPrice = 3387.0,
                            UserId = 5
                        },
                        new
                        {
                            Id = 9,
                            CheckInDate = new DateTime(2024, 12, 16, 12, 0, 13, 336, DateTimeKind.Local).AddTicks(8226),
                            CheckOutDate = new DateTime(2024, 12, 25, 12, 0, 13, 336, DateTimeKind.Local).AddTicks(8226),
                            RoomId = 41,
                            Status = 2,
                            TotalPrice = 2888.0,
                            UserId = 3
                        },
                        new
                        {
                            Id = 10,
                            CheckInDate = new DateTime(2024, 12, 27, 18, 14, 16, 470, DateTimeKind.Local).AddTicks(837),
                            CheckOutDate = new DateTime(2025, 1, 6, 18, 14, 16, 470, DateTimeKind.Local).AddTicks(837),
                            RoomId = 11,
                            Status = 0,
                            TotalPrice = 1702.0,
                            UserId = 1
                        },
                        new
                        {
                            Id = 11,
                            CheckInDate = new DateTime(2025, 1, 22, 13, 19, 44, 291, DateTimeKind.Local).AddTicks(9742),
                            CheckOutDate = new DateTime(2025, 1, 31, 13, 19, 44, 291, DateTimeKind.Local).AddTicks(9742),
                            RoomId = 48,
                            Status = 0,
                            TotalPrice = 4378.0,
                            UserId = 2
                        },
                        new
                        {
                            Id = 12,
                            CheckInDate = new DateTime(2024, 12, 21, 6, 22, 57, 667, DateTimeKind.Local).AddTicks(1575),
                            CheckOutDate = new DateTime(2024, 12, 23, 6, 22, 57, 667, DateTimeKind.Local).AddTicks(1575),
                            RoomId = 46,
                            Status = 2,
                            TotalPrice = 185.0,
                            UserId = 2
                        },
                        new
                        {
                            Id = 13,
                            CheckInDate = new DateTime(2025, 1, 13, 13, 47, 28, 259, DateTimeKind.Local).AddTicks(6658),
                            CheckOutDate = new DateTime(2025, 1, 21, 13, 47, 28, 259, DateTimeKind.Local).AddTicks(6658),
                            RoomId = 25,
                            Status = 0,
                            TotalPrice = 151.0,
                            UserId = 1
                        },
                        new
                        {
                            Id = 14,
                            CheckInDate = new DateTime(2024, 12, 18, 4, 7, 40, 589, DateTimeKind.Local).AddTicks(6169),
                            CheckOutDate = new DateTime(2024, 12, 21, 4, 7, 40, 589, DateTimeKind.Local).AddTicks(6169),
                            RoomId = 36,
                            Status = 2,
                            TotalPrice = 1821.0,
                            UserId = 8
                        },
                        new
                        {
                            Id = 15,
                            CheckInDate = new DateTime(2025, 1, 29, 12, 22, 5, 652, DateTimeKind.Local).AddTicks(1630),
                            CheckOutDate = new DateTime(2025, 2, 7, 12, 22, 5, 652, DateTimeKind.Local).AddTicks(1630),
                            RoomId = 3,
                            Status = 2,
                            TotalPrice = 2161.0,
                            UserId = 1
                        },
                        new
                        {
                            Id = 16,
                            CheckInDate = new DateTime(2025, 1, 6, 7, 25, 42, 556, DateTimeKind.Local).AddTicks(6929),
                            CheckOutDate = new DateTime(2025, 1, 11, 7, 25, 42, 556, DateTimeKind.Local).AddTicks(6929),
                            RoomId = 25,
                            Status = 0,
                            TotalPrice = 2964.0,
                            UserId = 9
                        },
                        new
                        {
                            Id = 17,
                            CheckInDate = new DateTime(2024, 12, 11, 16, 11, 54, 108, DateTimeKind.Local).AddTicks(268),
                            CheckOutDate = new DateTime(2024, 12, 15, 16, 11, 54, 108, DateTimeKind.Local).AddTicks(268),
                            RoomId = 6,
                            Status = 0,
                            TotalPrice = 4715.0,
                            UserId = 6
                        },
                        new
                        {
                            Id = 18,
                            CheckInDate = new DateTime(2025, 2, 1, 1, 55, 30, 976, DateTimeKind.Local).AddTicks(6082),
                            CheckOutDate = new DateTime(2025, 2, 2, 1, 55, 30, 976, DateTimeKind.Local).AddTicks(6082),
                            RoomId = 21,
                            Status = 2,
                            TotalPrice = 4741.0,
                            UserId = 1
                        },
                        new
                        {
                            Id = 19,
                            CheckInDate = new DateTime(2025, 1, 28, 3, 32, 40, 633, DateTimeKind.Local).AddTicks(7843),
                            CheckOutDate = new DateTime(2025, 2, 7, 3, 32, 40, 633, DateTimeKind.Local).AddTicks(7843),
                            RoomId = 14,
                            Status = 0,
                            TotalPrice = 3921.0,
                            UserId = 10
                        },
                        new
                        {
                            Id = 20,
                            CheckInDate = new DateTime(2025, 1, 15, 20, 4, 33, 179, DateTimeKind.Local).AddTicks(3775),
                            CheckOutDate = new DateTime(2025, 1, 23, 20, 4, 33, 179, DateTimeKind.Local).AddTicks(3775),
                            RoomId = 5,
                            Status = 0,
                            TotalPrice = 3811.0,
                            UserId = 5
                        },
                        new
                        {
                            Id = 21,
                            CheckInDate = new DateTime(2024, 12, 6, 10, 41, 14, 16, DateTimeKind.Local).AddTicks(6062),
                            CheckOutDate = new DateTime(2024, 12, 9, 10, 41, 14, 16, DateTimeKind.Local).AddTicks(6062),
                            RoomId = 12,
                            Status = 2,
                            TotalPrice = 4785.0,
                            UserId = 8
                        },
                        new
                        {
                            Id = 22,
                            CheckInDate = new DateTime(2024, 12, 20, 8, 58, 35, 842, DateTimeKind.Local).AddTicks(1595),
                            CheckOutDate = new DateTime(2024, 12, 23, 8, 58, 35, 842, DateTimeKind.Local).AddTicks(1595),
                            RoomId = 46,
                            Status = 1,
                            TotalPrice = 4224.0,
                            UserId = 7
                        },
                        new
                        {
                            Id = 23,
                            CheckInDate = new DateTime(2025, 1, 24, 14, 4, 9, 752, DateTimeKind.Local).AddTicks(2169),
                            CheckOutDate = new DateTime(2025, 1, 27, 14, 4, 9, 752, DateTimeKind.Local).AddTicks(2169),
                            RoomId = 2,
                            Status = 1,
                            TotalPrice = 3171.0,
                            UserId = 1
                        },
                        new
                        {
                            Id = 24,
                            CheckInDate = new DateTime(2025, 1, 15, 16, 1, 53, 49, DateTimeKind.Local).AddTicks(5306),
                            CheckOutDate = new DateTime(2025, 1, 21, 16, 1, 53, 49, DateTimeKind.Local).AddTicks(5306),
                            RoomId = 15,
                            Status = 2,
                            TotalPrice = 4557.0,
                            UserId = 10
                        },
                        new
                        {
                            Id = 25,
                            CheckInDate = new DateTime(2024, 12, 13, 3, 33, 44, 74, DateTimeKind.Local).AddTicks(8247),
                            CheckOutDate = new DateTime(2024, 12, 17, 3, 33, 44, 74, DateTimeKind.Local).AddTicks(8247),
                            RoomId = 40,
                            Status = 0,
                            TotalPrice = 1631.0,
                            UserId = 2
                        },
                        new
                        {
                            Id = 26,
                            CheckInDate = new DateTime(2025, 1, 3, 1, 55, 44, 353, DateTimeKind.Local).AddTicks(1784),
                            CheckOutDate = new DateTime(2025, 1, 10, 1, 55, 44, 353, DateTimeKind.Local).AddTicks(1784),
                            RoomId = 11,
                            Status = 2,
                            TotalPrice = 210.0,
                            UserId = 7
                        },
                        new
                        {
                            Id = 27,
                            CheckInDate = new DateTime(2024, 12, 12, 3, 37, 28, 674, DateTimeKind.Local).AddTicks(4582),
                            CheckOutDate = new DateTime(2024, 12, 16, 3, 37, 28, 674, DateTimeKind.Local).AddTicks(4582),
                            RoomId = 18,
                            Status = 1,
                            TotalPrice = 1210.0,
                            UserId = 5
                        },
                        new
                        {
                            Id = 28,
                            CheckInDate = new DateTime(2025, 1, 1, 5, 4, 13, 308, DateTimeKind.Local).AddTicks(5561),
                            CheckOutDate = new DateTime(2025, 1, 5, 5, 4, 13, 308, DateTimeKind.Local).AddTicks(5561),
                            RoomId = 17,
                            Status = 0,
                            TotalPrice = 2506.0,
                            UserId = 2
                        },
                        new
                        {
                            Id = 29,
                            CheckInDate = new DateTime(2025, 1, 17, 20, 14, 11, 38, DateTimeKind.Local).AddTicks(7027),
                            CheckOutDate = new DateTime(2025, 1, 19, 20, 14, 11, 38, DateTimeKind.Local).AddTicks(7027),
                            RoomId = 47,
                            Status = 1,
                            TotalPrice = 705.0,
                            UserId = 1
                        },
                        new
                        {
                            Id = 30,
                            CheckInDate = new DateTime(2025, 1, 10, 13, 40, 43, 780, DateTimeKind.Local).AddTicks(9366),
                            CheckOutDate = new DateTime(2025, 1, 15, 13, 40, 43, 780, DateTimeKind.Local).AddTicks(9366),
                            RoomId = 47,
                            Status = 1,
                            TotalPrice = 3058.0,
                            UserId = 6
                        },
                        new
                        {
                            Id = 31,
                            CheckInDate = new DateTime(2025, 2, 2, 9, 22, 25, 339, DateTimeKind.Local).AddTicks(5560),
                            CheckOutDate = new DateTime(2025, 2, 12, 9, 22, 25, 339, DateTimeKind.Local).AddTicks(5560),
                            RoomId = 7,
                            Status = 2,
                            TotalPrice = 4362.0,
                            UserId = 4
                        },
                        new
                        {
                            Id = 32,
                            CheckInDate = new DateTime(2024, 12, 7, 16, 26, 42, 692, DateTimeKind.Local).AddTicks(7145),
                            CheckOutDate = new DateTime(2024, 12, 8, 16, 26, 42, 692, DateTimeKind.Local).AddTicks(7145),
                            RoomId = 5,
                            Status = 1,
                            TotalPrice = 3676.0,
                            UserId = 1
                        },
                        new
                        {
                            Id = 33,
                            CheckInDate = new DateTime(2025, 1, 3, 21, 42, 12, 712, DateTimeKind.Local).AddTicks(6653),
                            CheckOutDate = new DateTime(2025, 1, 4, 21, 42, 12, 712, DateTimeKind.Local).AddTicks(6653),
                            RoomId = 40,
                            Status = 1,
                            TotalPrice = 4970.0,
                            UserId = 3
                        },
                        new
                        {
                            Id = 34,
                            CheckInDate = new DateTime(2025, 1, 11, 20, 28, 8, 236, DateTimeKind.Local).AddTicks(4148),
                            CheckOutDate = new DateTime(2025, 1, 15, 20, 28, 8, 236, DateTimeKind.Local).AddTicks(4148),
                            RoomId = 3,
                            Status = 0,
                            TotalPrice = 1265.0,
                            UserId = 3
                        },
                        new
                        {
                            Id = 35,
                            CheckInDate = new DateTime(2025, 1, 24, 19, 59, 16, 239, DateTimeKind.Local).AddTicks(7190),
                            CheckOutDate = new DateTime(2025, 2, 2, 19, 59, 16, 239, DateTimeKind.Local).AddTicks(7190),
                            RoomId = 32,
                            Status = 0,
                            TotalPrice = 2870.0,
                            UserId = 9
                        },
                        new
                        {
                            Id = 36,
                            CheckInDate = new DateTime(2025, 1, 6, 6, 23, 38, 933, DateTimeKind.Local).AddTicks(8450),
                            CheckOutDate = new DateTime(2025, 1, 11, 6, 23, 38, 933, DateTimeKind.Local).AddTicks(8450),
                            RoomId = 37,
                            Status = 2,
                            TotalPrice = 2471.0,
                            UserId = 1
                        },
                        new
                        {
                            Id = 37,
                            CheckInDate = new DateTime(2024, 12, 4, 23, 34, 21, 516, DateTimeKind.Local).AddTicks(5827),
                            CheckOutDate = new DateTime(2024, 12, 6, 23, 34, 21, 516, DateTimeKind.Local).AddTicks(5827),
                            RoomId = 5,
                            Status = 0,
                            TotalPrice = 1756.0,
                            UserId = 5
                        },
                        new
                        {
                            Id = 38,
                            CheckInDate = new DateTime(2025, 1, 3, 4, 28, 35, 516, DateTimeKind.Local).AddTicks(4048),
                            CheckOutDate = new DateTime(2025, 1, 5, 4, 28, 35, 516, DateTimeKind.Local).AddTicks(4048),
                            RoomId = 42,
                            Status = 2,
                            TotalPrice = 2713.0,
                            UserId = 8
                        },
                        new
                        {
                            Id = 39,
                            CheckInDate = new DateTime(2024, 12, 27, 19, 47, 36, 938, DateTimeKind.Local).AddTicks(6371),
                            CheckOutDate = new DateTime(2025, 1, 1, 19, 47, 36, 938, DateTimeKind.Local).AddTicks(6371),
                            RoomId = 49,
                            Status = 0,
                            TotalPrice = 1882.0,
                            UserId = 6
                        },
                        new
                        {
                            Id = 40,
                            CheckInDate = new DateTime(2024, 12, 30, 12, 46, 55, 664, DateTimeKind.Local).AddTicks(716),
                            CheckOutDate = new DateTime(2025, 1, 9, 12, 46, 55, 664, DateTimeKind.Local).AddTicks(716),
                            RoomId = 16,
                            Status = 0,
                            TotalPrice = 3524.0,
                            UserId = 9
                        },
                        new
                        {
                            Id = 41,
                            CheckInDate = new DateTime(2024, 12, 15, 17, 44, 45, 910, DateTimeKind.Local).AddTicks(487),
                            CheckOutDate = new DateTime(2024, 12, 24, 17, 44, 45, 910, DateTimeKind.Local).AddTicks(487),
                            RoomId = 4,
                            Status = 2,
                            TotalPrice = 4434.0,
                            UserId = 6
                        },
                        new
                        {
                            Id = 42,
                            CheckInDate = new DateTime(2024, 12, 12, 2, 45, 17, 441, DateTimeKind.Local).AddTicks(9444),
                            CheckOutDate = new DateTime(2024, 12, 21, 2, 45, 17, 441, DateTimeKind.Local).AddTicks(9444),
                            RoomId = 41,
                            Status = 2,
                            TotalPrice = 4002.0,
                            UserId = 4
                        },
                        new
                        {
                            Id = 43,
                            CheckInDate = new DateTime(2025, 1, 21, 3, 57, 29, 446, DateTimeKind.Local).AddTicks(8395),
                            CheckOutDate = new DateTime(2025, 1, 25, 3, 57, 29, 446, DateTimeKind.Local).AddTicks(8395),
                            RoomId = 8,
                            Status = 1,
                            TotalPrice = 3827.0,
                            UserId = 10
                        },
                        new
                        {
                            Id = 44,
                            CheckInDate = new DateTime(2025, 1, 28, 4, 36, 0, 200, DateTimeKind.Local).AddTicks(8942),
                            CheckOutDate = new DateTime(2025, 2, 2, 4, 36, 0, 200, DateTimeKind.Local).AddTicks(8942),
                            RoomId = 3,
                            Status = 1,
                            TotalPrice = 3466.0,
                            UserId = 3
                        },
                        new
                        {
                            Id = 45,
                            CheckInDate = new DateTime(2024, 12, 5, 4, 19, 2, 982, DateTimeKind.Local).AddTicks(7818),
                            CheckOutDate = new DateTime(2024, 12, 9, 4, 19, 2, 982, DateTimeKind.Local).AddTicks(7818),
                            RoomId = 11,
                            Status = 0,
                            TotalPrice = 155.0,
                            UserId = 7
                        },
                        new
                        {
                            Id = 46,
                            CheckInDate = new DateTime(2024, 12, 15, 22, 4, 42, 792, DateTimeKind.Local).AddTicks(6443),
                            CheckOutDate = new DateTime(2024, 12, 20, 22, 4, 42, 792, DateTimeKind.Local).AddTicks(6443),
                            RoomId = 26,
                            Status = 1,
                            TotalPrice = 3380.0,
                            UserId = 5
                        },
                        new
                        {
                            Id = 47,
                            CheckInDate = new DateTime(2024, 12, 12, 14, 29, 57, 987, DateTimeKind.Local).AddTicks(4628),
                            CheckOutDate = new DateTime(2024, 12, 19, 14, 29, 57, 987, DateTimeKind.Local).AddTicks(4628),
                            RoomId = 28,
                            Status = 2,
                            TotalPrice = 1041.0,
                            UserId = 3
                        },
                        new
                        {
                            Id = 48,
                            CheckInDate = new DateTime(2025, 1, 3, 4, 30, 59, 273, DateTimeKind.Local).AddTicks(4880),
                            CheckOutDate = new DateTime(2025, 1, 13, 4, 30, 59, 273, DateTimeKind.Local).AddTicks(4880),
                            RoomId = 35,
                            Status = 2,
                            TotalPrice = 4243.0,
                            UserId = 5
                        },
                        new
                        {
                            Id = 49,
                            CheckInDate = new DateTime(2024, 12, 7, 4, 6, 6, 360, DateTimeKind.Local).AddTicks(2497),
                            CheckOutDate = new DateTime(2024, 12, 13, 4, 6, 6, 360, DateTimeKind.Local).AddTicks(2497),
                            RoomId = 16,
                            Status = 1,
                            TotalPrice = 215.0,
                            UserId = 5
                        },
                        new
                        {
                            Id = 50,
                            CheckInDate = new DateTime(2024, 12, 10, 23, 21, 9, 826, DateTimeKind.Local).AddTicks(2274),
                            CheckOutDate = new DateTime(2024, 12, 12, 23, 21, 9, 826, DateTimeKind.Local).AddTicks(2274),
                            RoomId = 16,
                            Status = 2,
                            TotalPrice = 1937.0,
                            UserId = 8
                        },
                        new
                        {
                            Id = 51,
                            CheckInDate = new DateTime(2025, 1, 26, 20, 29, 40, 100, DateTimeKind.Local).AddTicks(1945),
                            CheckOutDate = new DateTime(2025, 1, 29, 20, 29, 40, 100, DateTimeKind.Local).AddTicks(1945),
                            RoomId = 28,
                            Status = 0,
                            TotalPrice = 3991.0,
                            UserId = 1
                        },
                        new
                        {
                            Id = 52,
                            CheckInDate = new DateTime(2025, 1, 5, 20, 44, 41, 284, DateTimeKind.Local).AddTicks(9150),
                            CheckOutDate = new DateTime(2025, 1, 10, 20, 44, 41, 284, DateTimeKind.Local).AddTicks(9150),
                            RoomId = 13,
                            Status = 0,
                            TotalPrice = 1827.0,
                            UserId = 2
                        },
                        new
                        {
                            Id = 53,
                            CheckInDate = new DateTime(2024, 12, 7, 2, 58, 36, 188, DateTimeKind.Local).AddTicks(504),
                            CheckOutDate = new DateTime(2024, 12, 12, 2, 58, 36, 188, DateTimeKind.Local).AddTicks(504),
                            RoomId = 16,
                            Status = 2,
                            TotalPrice = 952.0,
                            UserId = 3
                        },
                        new
                        {
                            Id = 54,
                            CheckInDate = new DateTime(2025, 1, 3, 3, 13, 26, 685, DateTimeKind.Local).AddTicks(759),
                            CheckOutDate = new DateTime(2025, 1, 13, 3, 13, 26, 685, DateTimeKind.Local).AddTicks(759),
                            RoomId = 17,
                            Status = 0,
                            TotalPrice = 2794.0,
                            UserId = 10
                        },
                        new
                        {
                            Id = 55,
                            CheckInDate = new DateTime(2025, 1, 18, 0, 38, 15, 704, DateTimeKind.Local).AddTicks(2029),
                            CheckOutDate = new DateTime(2025, 1, 22, 0, 38, 15, 704, DateTimeKind.Local).AddTicks(2029),
                            RoomId = 14,
                            Status = 1,
                            TotalPrice = 1873.0,
                            UserId = 7
                        },
                        new
                        {
                            Id = 56,
                            CheckInDate = new DateTime(2024, 12, 27, 22, 0, 54, 335, DateTimeKind.Local).AddTicks(5747),
                            CheckOutDate = new DateTime(2025, 1, 1, 22, 0, 54, 335, DateTimeKind.Local).AddTicks(5747),
                            RoomId = 50,
                            Status = 2,
                            TotalPrice = 720.0,
                            UserId = 8
                        },
                        new
                        {
                            Id = 57,
                            CheckInDate = new DateTime(2024, 12, 12, 19, 6, 39, 320, DateTimeKind.Local).AddTicks(6943),
                            CheckOutDate = new DateTime(2024, 12, 22, 19, 6, 39, 320, DateTimeKind.Local).AddTicks(6943),
                            RoomId = 31,
                            Status = 0,
                            TotalPrice = 3633.0,
                            UserId = 6
                        },
                        new
                        {
                            Id = 58,
                            CheckInDate = new DateTime(2024, 12, 7, 0, 16, 20, 963, DateTimeKind.Local).AddTicks(4817),
                            CheckOutDate = new DateTime(2024, 12, 11, 0, 16, 20, 963, DateTimeKind.Local).AddTicks(4817),
                            RoomId = 32,
                            Status = 1,
                            TotalPrice = 812.0,
                            UserId = 4
                        },
                        new
                        {
                            Id = 59,
                            CheckInDate = new DateTime(2025, 1, 10, 20, 26, 50, 491, DateTimeKind.Local).AddTicks(9035),
                            CheckOutDate = new DateTime(2025, 1, 20, 20, 26, 50, 491, DateTimeKind.Local).AddTicks(9035),
                            RoomId = 12,
                            Status = 0,
                            TotalPrice = 1717.0,
                            UserId = 4
                        },
                        new
                        {
                            Id = 60,
                            CheckInDate = new DateTime(2024, 12, 16, 23, 14, 51, 548, DateTimeKind.Local).AddTicks(8131),
                            CheckOutDate = new DateTime(2024, 12, 21, 23, 14, 51, 548, DateTimeKind.Local).AddTicks(8131),
                            RoomId = 7,
                            Status = 2,
                            TotalPrice = 2614.0,
                            UserId = 2
                        },
                        new
                        {
                            Id = 61,
                            CheckInDate = new DateTime(2024, 12, 22, 3, 30, 54, 899, DateTimeKind.Local).AddTicks(899),
                            CheckOutDate = new DateTime(2024, 12, 30, 3, 30, 54, 899, DateTimeKind.Local).AddTicks(899),
                            RoomId = 5,
                            Status = 0,
                            TotalPrice = 3445.0,
                            UserId = 3
                        },
                        new
                        {
                            Id = 62,
                            CheckInDate = new DateTime(2024, 12, 31, 22, 31, 25, 467, DateTimeKind.Local).AddTicks(2891),
                            CheckOutDate = new DateTime(2025, 1, 2, 22, 31, 25, 467, DateTimeKind.Local).AddTicks(2891),
                            RoomId = 37,
                            Status = 0,
                            TotalPrice = 3379.0,
                            UserId = 1
                        },
                        new
                        {
                            Id = 63,
                            CheckInDate = new DateTime(2025, 1, 30, 11, 49, 21, 20, DateTimeKind.Local).AddTicks(2488),
                            CheckOutDate = new DateTime(2025, 2, 7, 11, 49, 21, 20, DateTimeKind.Local).AddTicks(2488),
                            RoomId = 27,
                            Status = 2,
                            TotalPrice = 2049.0,
                            UserId = 1
                        },
                        new
                        {
                            Id = 64,
                            CheckInDate = new DateTime(2024, 12, 30, 23, 25, 49, 86, DateTimeKind.Local).AddTicks(7329),
                            CheckOutDate = new DateTime(2025, 1, 7, 23, 25, 49, 86, DateTimeKind.Local).AddTicks(7329),
                            RoomId = 50,
                            Status = 1,
                            TotalPrice = 3537.0,
                            UserId = 8
                        },
                        new
                        {
                            Id = 65,
                            CheckInDate = new DateTime(2025, 1, 23, 7, 21, 40, 80, DateTimeKind.Local).AddTicks(8033),
                            CheckOutDate = new DateTime(2025, 2, 1, 7, 21, 40, 80, DateTimeKind.Local).AddTicks(8033),
                            RoomId = 17,
                            Status = 1,
                            TotalPrice = 924.0,
                            UserId = 6
                        },
                        new
                        {
                            Id = 66,
                            CheckInDate = new DateTime(2024, 12, 14, 7, 37, 58, 454, DateTimeKind.Local).AddTicks(6918),
                            CheckOutDate = new DateTime(2024, 12, 19, 7, 37, 58, 454, DateTimeKind.Local).AddTicks(6918),
                            RoomId = 8,
                            Status = 1,
                            TotalPrice = 4502.0,
                            UserId = 7
                        },
                        new
                        {
                            Id = 67,
                            CheckInDate = new DateTime(2024, 12, 28, 6, 3, 47, 136, DateTimeKind.Local).AddTicks(8788),
                            CheckOutDate = new DateTime(2024, 12, 29, 6, 3, 47, 136, DateTimeKind.Local).AddTicks(8788),
                            RoomId = 6,
                            Status = 0,
                            TotalPrice = 4968.0,
                            UserId = 9
                        },
                        new
                        {
                            Id = 68,
                            CheckInDate = new DateTime(2024, 12, 18, 21, 28, 37, 6, DateTimeKind.Local).AddTicks(6431),
                            CheckOutDate = new DateTime(2024, 12, 21, 21, 28, 37, 6, DateTimeKind.Local).AddTicks(6431),
                            RoomId = 13,
                            Status = 0,
                            TotalPrice = 1097.0,
                            UserId = 8
                        },
                        new
                        {
                            Id = 69,
                            CheckInDate = new DateTime(2024, 12, 13, 23, 48, 24, 43, DateTimeKind.Local).AddTicks(13),
                            CheckOutDate = new DateTime(2024, 12, 21, 23, 48, 24, 43, DateTimeKind.Local).AddTicks(13),
                            RoomId = 40,
                            Status = 2,
                            TotalPrice = 2200.0,
                            UserId = 4
                        },
                        new
                        {
                            Id = 70,
                            CheckInDate = new DateTime(2024, 12, 17, 10, 6, 1, 235, DateTimeKind.Local).AddTicks(6647),
                            CheckOutDate = new DateTime(2024, 12, 21, 10, 6, 1, 235, DateTimeKind.Local).AddTicks(6647),
                            RoomId = 20,
                            Status = 1,
                            TotalPrice = 1262.0,
                            UserId = 6
                        },
                        new
                        {
                            Id = 71,
                            CheckInDate = new DateTime(2025, 1, 18, 8, 29, 5, 355, DateTimeKind.Local).AddTicks(3708),
                            CheckOutDate = new DateTime(2025, 1, 22, 8, 29, 5, 355, DateTimeKind.Local).AddTicks(3708),
                            RoomId = 25,
                            Status = 1,
                            TotalPrice = 549.0,
                            UserId = 1
                        },
                        new
                        {
                            Id = 72,
                            CheckInDate = new DateTime(2025, 1, 17, 14, 22, 50, 368, DateTimeKind.Local).AddTicks(507),
                            CheckOutDate = new DateTime(2025, 1, 26, 14, 22, 50, 368, DateTimeKind.Local).AddTicks(507),
                            RoomId = 20,
                            Status = 1,
                            TotalPrice = 3061.0,
                            UserId = 1
                        },
                        new
                        {
                            Id = 73,
                            CheckInDate = new DateTime(2025, 1, 26, 22, 21, 24, 77, DateTimeKind.Local).AddTicks(5169),
                            CheckOutDate = new DateTime(2025, 2, 3, 22, 21, 24, 77, DateTimeKind.Local).AddTicks(5169),
                            RoomId = 42,
                            Status = 0,
                            TotalPrice = 4959.0,
                            UserId = 4
                        },
                        new
                        {
                            Id = 74,
                            CheckInDate = new DateTime(2025, 1, 2, 23, 18, 47, 771, DateTimeKind.Local).AddTicks(6576),
                            CheckOutDate = new DateTime(2025, 1, 5, 23, 18, 47, 771, DateTimeKind.Local).AddTicks(6576),
                            RoomId = 36,
                            Status = 1,
                            TotalPrice = 3684.0,
                            UserId = 2
                        },
                        new
                        {
                            Id = 75,
                            CheckInDate = new DateTime(2025, 2, 2, 8, 31, 16, 771, DateTimeKind.Local).AddTicks(2037),
                            CheckOutDate = new DateTime(2025, 2, 5, 8, 31, 16, 771, DateTimeKind.Local).AddTicks(2037),
                            RoomId = 30,
                            Status = 2,
                            TotalPrice = 1881.0,
                            UserId = 1
                        },
                        new
                        {
                            Id = 76,
                            CheckInDate = new DateTime(2024, 12, 15, 9, 22, 0, 354, DateTimeKind.Local).AddTicks(1891),
                            CheckOutDate = new DateTime(2024, 12, 19, 9, 22, 0, 354, DateTimeKind.Local).AddTicks(1891),
                            RoomId = 46,
                            Status = 1,
                            TotalPrice = 366.0,
                            UserId = 2
                        },
                        new
                        {
                            Id = 77,
                            CheckInDate = new DateTime(2025, 1, 21, 11, 30, 28, 915, DateTimeKind.Local).AddTicks(2320),
                            CheckOutDate = new DateTime(2025, 1, 25, 11, 30, 28, 915, DateTimeKind.Local).AddTicks(2320),
                            RoomId = 50,
                            Status = 2,
                            TotalPrice = 1964.0,
                            UserId = 9
                        },
                        new
                        {
                            Id = 78,
                            CheckInDate = new DateTime(2024, 12, 24, 4, 49, 21, 533, DateTimeKind.Local).AddTicks(3121),
                            CheckOutDate = new DateTime(2024, 12, 30, 4, 49, 21, 533, DateTimeKind.Local).AddTicks(3121),
                            RoomId = 19,
                            Status = 1,
                            TotalPrice = 4836.0,
                            UserId = 7
                        },
                        new
                        {
                            Id = 79,
                            CheckInDate = new DateTime(2025, 1, 9, 22, 57, 51, 58, DateTimeKind.Local).AddTicks(6761),
                            CheckOutDate = new DateTime(2025, 1, 19, 22, 57, 51, 58, DateTimeKind.Local).AddTicks(6761),
                            RoomId = 14,
                            Status = 0,
                            TotalPrice = 843.0,
                            UserId = 1
                        },
                        new
                        {
                            Id = 80,
                            CheckInDate = new DateTime(2025, 1, 3, 2, 21, 32, 679, DateTimeKind.Local).AddTicks(1522),
                            CheckOutDate = new DateTime(2025, 1, 7, 2, 21, 32, 679, DateTimeKind.Local).AddTicks(1522),
                            RoomId = 23,
                            Status = 2,
                            TotalPrice = 349.0,
                            UserId = 6
                        },
                        new
                        {
                            Id = 81,
                            CheckInDate = new DateTime(2024, 12, 22, 22, 37, 55, 717, DateTimeKind.Local).AddTicks(2684),
                            CheckOutDate = new DateTime(2024, 12, 29, 22, 37, 55, 717, DateTimeKind.Local).AddTicks(2684),
                            RoomId = 4,
                            Status = 1,
                            TotalPrice = 3865.0,
                            UserId = 9
                        },
                        new
                        {
                            Id = 82,
                            CheckInDate = new DateTime(2025, 1, 1, 0, 42, 12, 187, DateTimeKind.Local).AddTicks(3478),
                            CheckOutDate = new DateTime(2025, 1, 6, 0, 42, 12, 187, DateTimeKind.Local).AddTicks(3478),
                            RoomId = 5,
                            Status = 2,
                            TotalPrice = 104.0,
                            UserId = 2
                        },
                        new
                        {
                            Id = 83,
                            CheckInDate = new DateTime(2025, 1, 13, 15, 46, 10, 686, DateTimeKind.Local).AddTicks(1007),
                            CheckOutDate = new DateTime(2025, 1, 18, 15, 46, 10, 686, DateTimeKind.Local).AddTicks(1007),
                            RoomId = 13,
                            Status = 1,
                            TotalPrice = 1952.0,
                            UserId = 9
                        },
                        new
                        {
                            Id = 84,
                            CheckInDate = new DateTime(2024, 12, 31, 12, 29, 22, 358, DateTimeKind.Local).AddTicks(6937),
                            CheckOutDate = new DateTime(2025, 1, 3, 12, 29, 22, 358, DateTimeKind.Local).AddTicks(6937),
                            RoomId = 34,
                            Status = 1,
                            TotalPrice = 3145.0,
                            UserId = 2
                        },
                        new
                        {
                            Id = 85,
                            CheckInDate = new DateTime(2024, 12, 31, 13, 28, 31, 239, DateTimeKind.Local).AddTicks(101),
                            CheckOutDate = new DateTime(2025, 1, 7, 13, 28, 31, 239, DateTimeKind.Local).AddTicks(101),
                            RoomId = 31,
                            Status = 2,
                            TotalPrice = 1545.0,
                            UserId = 5
                        },
                        new
                        {
                            Id = 86,
                            CheckInDate = new DateTime(2025, 2, 2, 4, 4, 6, 3, DateTimeKind.Local).AddTicks(5784),
                            CheckOutDate = new DateTime(2025, 2, 11, 4, 4, 6, 3, DateTimeKind.Local).AddTicks(5784),
                            RoomId = 1,
                            Status = 0,
                            TotalPrice = 354.0,
                            UserId = 10
                        },
                        new
                        {
                            Id = 87,
                            CheckInDate = new DateTime(2025, 1, 9, 0, 30, 15, 291, DateTimeKind.Local).AddTicks(9921),
                            CheckOutDate = new DateTime(2025, 1, 10, 0, 30, 15, 291, DateTimeKind.Local).AddTicks(9921),
                            RoomId = 2,
                            Status = 0,
                            TotalPrice = 1781.0,
                            UserId = 2
                        },
                        new
                        {
                            Id = 88,
                            CheckInDate = new DateTime(2024, 12, 28, 1, 32, 22, 378, DateTimeKind.Local).AddTicks(3213),
                            CheckOutDate = new DateTime(2024, 12, 29, 1, 32, 22, 378, DateTimeKind.Local).AddTicks(3213),
                            RoomId = 32,
                            Status = 0,
                            TotalPrice = 287.0,
                            UserId = 9
                        },
                        new
                        {
                            Id = 89,
                            CheckInDate = new DateTime(2024, 12, 30, 8, 20, 46, 896, DateTimeKind.Local).AddTicks(612),
                            CheckOutDate = new DateTime(2025, 1, 7, 8, 20, 46, 896, DateTimeKind.Local).AddTicks(612),
                            RoomId = 49,
                            Status = 0,
                            TotalPrice = 1463.0,
                            UserId = 8
                        },
                        new
                        {
                            Id = 90,
                            CheckInDate = new DateTime(2025, 1, 27, 19, 49, 19, 118, DateTimeKind.Local).AddTicks(6795),
                            CheckOutDate = new DateTime(2025, 1, 30, 19, 49, 19, 118, DateTimeKind.Local).AddTicks(6795),
                            RoomId = 27,
                            Status = 1,
                            TotalPrice = 3201.0,
                            UserId = 10
                        },
                        new
                        {
                            Id = 91,
                            CheckInDate = new DateTime(2025, 2, 1, 11, 36, 11, 773, DateTimeKind.Local).AddTicks(7146),
                            CheckOutDate = new DateTime(2025, 2, 5, 11, 36, 11, 773, DateTimeKind.Local).AddTicks(7146),
                            RoomId = 28,
                            Status = 0,
                            TotalPrice = 4829.0,
                            UserId = 2
                        },
                        new
                        {
                            Id = 92,
                            CheckInDate = new DateTime(2024, 12, 16, 2, 15, 19, 838, DateTimeKind.Local).AddTicks(799),
                            CheckOutDate = new DateTime(2024, 12, 23, 2, 15, 19, 838, DateTimeKind.Local).AddTicks(799),
                            RoomId = 18,
                            Status = 2,
                            TotalPrice = 3182.0,
                            UserId = 2
                        },
                        new
                        {
                            Id = 93,
                            CheckInDate = new DateTime(2025, 1, 18, 19, 28, 16, 624, DateTimeKind.Local).AddTicks(5014),
                            CheckOutDate = new DateTime(2025, 1, 21, 19, 28, 16, 624, DateTimeKind.Local).AddTicks(5014),
                            RoomId = 36,
                            Status = 1,
                            TotalPrice = 1474.0,
                            UserId = 1
                        },
                        new
                        {
                            Id = 94,
                            CheckInDate = new DateTime(2025, 1, 17, 23, 6, 48, 64, DateTimeKind.Local).AddTicks(5479),
                            CheckOutDate = new DateTime(2025, 1, 22, 23, 6, 48, 64, DateTimeKind.Local).AddTicks(5479),
                            RoomId = 5,
                            Status = 0,
                            TotalPrice = 4608.0,
                            UserId = 2
                        },
                        new
                        {
                            Id = 95,
                            CheckInDate = new DateTime(2025, 1, 14, 7, 24, 42, 975, DateTimeKind.Local).AddTicks(8647),
                            CheckOutDate = new DateTime(2025, 1, 15, 7, 24, 42, 975, DateTimeKind.Local).AddTicks(8647),
                            RoomId = 44,
                            Status = 2,
                            TotalPrice = 1657.0,
                            UserId = 6
                        },
                        new
                        {
                            Id = 96,
                            CheckInDate = new DateTime(2024, 12, 21, 7, 54, 14, 226, DateTimeKind.Local).AddTicks(7400),
                            CheckOutDate = new DateTime(2024, 12, 26, 7, 54, 14, 226, DateTimeKind.Local).AddTicks(7400),
                            RoomId = 26,
                            Status = 0,
                            TotalPrice = 1883.0,
                            UserId = 6
                        },
                        new
                        {
                            Id = 97,
                            CheckInDate = new DateTime(2024, 12, 23, 4, 19, 0, 224, DateTimeKind.Local).AddTicks(5993),
                            CheckOutDate = new DateTime(2024, 12, 27, 4, 19, 0, 224, DateTimeKind.Local).AddTicks(5993),
                            RoomId = 22,
                            Status = 0,
                            TotalPrice = 413.0,
                            UserId = 10
                        },
                        new
                        {
                            Id = 98,
                            CheckInDate = new DateTime(2025, 1, 17, 9, 13, 40, 201, DateTimeKind.Local).AddTicks(3337),
                            CheckOutDate = new DateTime(2025, 1, 21, 9, 13, 40, 201, DateTimeKind.Local).AddTicks(3337),
                            RoomId = 40,
                            Status = 1,
                            TotalPrice = 4518.0,
                            UserId = 9
                        },
                        new
                        {
                            Id = 99,
                            CheckInDate = new DateTime(2024, 12, 8, 22, 14, 12, 64, DateTimeKind.Local).AddTicks(6874),
                            CheckOutDate = new DateTime(2024, 12, 9, 22, 14, 12, 64, DateTimeKind.Local).AddTicks(6874),
                            RoomId = 4,
                            Status = 0,
                            TotalPrice = 517.0,
                            UserId = 5
                        },
                        new
                        {
                            Id = 100,
                            CheckInDate = new DateTime(2025, 1, 4, 18, 51, 55, 984, DateTimeKind.Local).AddTicks(9491),
                            CheckOutDate = new DateTime(2025, 1, 7, 18, 51, 55, 984, DateTimeKind.Local).AddTicks(9491),
                            RoomId = 44,
                            Status = 2,
                            TotalPrice = 1790.0,
                            UserId = 4
                        });
                });

            modelBuilder.Entity("Hotel_Management.Models.Room", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<bool>("IsAvailable")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<double>("Price")
                        .HasColumnType("double");

                    b.Property<int>("RoomTypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoomTypeId");

                    b.ToTable("Room");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Capacity = 2,
                            IsAvailable = false,
                            Name = "Room 368",
                            Price = 113.0,
                            RoomTypeId = 3
                        },
                        new
                        {
                            Id = 2,
                            Capacity = 3,
                            IsAvailable = true,
                            Name = "Room 340",
                            Price = 724.0,
                            RoomTypeId = 2
                        },
                        new
                        {
                            Id = 3,
                            Capacity = 3,
                            IsAvailable = true,
                            Name = "Room 400",
                            Price = 379.0,
                            RoomTypeId = 3
                        },
                        new
                        {
                            Id = 4,
                            Capacity = 3,
                            IsAvailable = false,
                            Name = "Room 109",
                            Price = 701.0,
                            RoomTypeId = 1
                        },
                        new
                        {
                            Id = 5,
                            Capacity = 5,
                            IsAvailable = false,
                            Name = "Room 180",
                            Price = 990.0,
                            RoomTypeId = 1
                        },
                        new
                        {
                            Id = 6,
                            Capacity = 6,
                            IsAvailable = false,
                            Name = "Room 422",
                            Price = 130.0,
                            RoomTypeId = 1
                        },
                        new
                        {
                            Id = 7,
                            Capacity = 7,
                            IsAvailable = false,
                            Name = "Room 459",
                            Price = 775.0,
                            RoomTypeId = 1
                        },
                        new
                        {
                            Id = 8,
                            Capacity = 10,
                            IsAvailable = false,
                            Name = "Room 113",
                            Price = 872.0,
                            RoomTypeId = 1
                        },
                        new
                        {
                            Id = 9,
                            Capacity = 10,
                            IsAvailable = false,
                            Name = "Room 472",
                            Price = 113.0,
                            RoomTypeId = 1
                        },
                        new
                        {
                            Id = 10,
                            Capacity = 7,
                            IsAvailable = false,
                            Name = "Room 101",
                            Price = 132.0,
                            RoomTypeId = 3
                        },
                        new
                        {
                            Id = 11,
                            Capacity = 2,
                            IsAvailable = false,
                            Name = "Room 286",
                            Price = 417.0,
                            RoomTypeId = 2
                        },
                        new
                        {
                            Id = 12,
                            Capacity = 1,
                            IsAvailable = true,
                            Name = "Room 120",
                            Price = 980.0,
                            RoomTypeId = 1
                        },
                        new
                        {
                            Id = 13,
                            Capacity = 2,
                            IsAvailable = true,
                            Name = "Room 423",
                            Price = 692.0,
                            RoomTypeId = 1
                        },
                        new
                        {
                            Id = 14,
                            Capacity = 3,
                            IsAvailable = false,
                            Name = "Room 404",
                            Price = 486.0,
                            RoomTypeId = 1
                        },
                        new
                        {
                            Id = 15,
                            Capacity = 4,
                            IsAvailable = true,
                            Name = "Room 158",
                            Price = 151.0,
                            RoomTypeId = 3
                        },
                        new
                        {
                            Id = 16,
                            Capacity = 4,
                            IsAvailable = true,
                            Name = "Room 458",
                            Price = 734.0,
                            RoomTypeId = 1
                        },
                        new
                        {
                            Id = 17,
                            Capacity = 2,
                            IsAvailable = false,
                            Name = "Room 254",
                            Price = 503.0,
                            RoomTypeId = 3
                        },
                        new
                        {
                            Id = 18,
                            Capacity = 7,
                            IsAvailable = false,
                            Name = "Room 466",
                            Price = 214.0,
                            RoomTypeId = 1
                        },
                        new
                        {
                            Id = 19,
                            Capacity = 7,
                            IsAvailable = true,
                            Name = "Room 198",
                            Price = 363.0,
                            RoomTypeId = 1
                        },
                        new
                        {
                            Id = 20,
                            Capacity = 4,
                            IsAvailable = true,
                            Name = "Room 180",
                            Price = 986.0,
                            RoomTypeId = 1
                        },
                        new
                        {
                            Id = 21,
                            Capacity = 10,
                            IsAvailable = false,
                            Name = "Room 216",
                            Price = 880.0,
                            RoomTypeId = 2
                        },
                        new
                        {
                            Id = 22,
                            Capacity = 4,
                            IsAvailable = true,
                            Name = "Room 306",
                            Price = 93.0,
                            RoomTypeId = 1
                        },
                        new
                        {
                            Id = 23,
                            Capacity = 6,
                            IsAvailable = true,
                            Name = "Room 279",
                            Price = 709.0,
                            RoomTypeId = 1
                        },
                        new
                        {
                            Id = 24,
                            Capacity = 10,
                            IsAvailable = false,
                            Name = "Room 146",
                            Price = 186.0,
                            RoomTypeId = 3
                        },
                        new
                        {
                            Id = 25,
                            Capacity = 2,
                            IsAvailable = true,
                            Name = "Room 310",
                            Price = 302.0,
                            RoomTypeId = 1
                        },
                        new
                        {
                            Id = 26,
                            Capacity = 4,
                            IsAvailable = false,
                            Name = "Room 296",
                            Price = 988.0,
                            RoomTypeId = 1
                        },
                        new
                        {
                            Id = 27,
                            Capacity = 2,
                            IsAvailable = true,
                            Name = "Room 424",
                            Price = 384.0,
                            RoomTypeId = 3
                        },
                        new
                        {
                            Id = 28,
                            Capacity = 10,
                            IsAvailable = true,
                            Name = "Room 336",
                            Price = 716.0,
                            RoomTypeId = 1
                        },
                        new
                        {
                            Id = 29,
                            Capacity = 6,
                            IsAvailable = true,
                            Name = "Room 104",
                            Price = 846.0,
                            RoomTypeId = 1
                        },
                        new
                        {
                            Id = 30,
                            Capacity = 8,
                            IsAvailable = true,
                            Name = "Room 196",
                            Price = 98.0,
                            RoomTypeId = 1
                        },
                        new
                        {
                            Id = 31,
                            Capacity = 10,
                            IsAvailable = false,
                            Name = "Room 169",
                            Price = 62.0,
                            RoomTypeId = 1
                        },
                        new
                        {
                            Id = 32,
                            Capacity = 3,
                            IsAvailable = false,
                            Name = "Room 348",
                            Price = 340.0,
                            RoomTypeId = 3
                        },
                        new
                        {
                            Id = 33,
                            Capacity = 9,
                            IsAvailable = false,
                            Name = "Room 412",
                            Price = 136.0,
                            RoomTypeId = 3
                        },
                        new
                        {
                            Id = 34,
                            Capacity = 3,
                            IsAvailable = false,
                            Name = "Room 118",
                            Price = 882.0,
                            RoomTypeId = 3
                        },
                        new
                        {
                            Id = 35,
                            Capacity = 5,
                            IsAvailable = true,
                            Name = "Room 487",
                            Price = 329.0,
                            RoomTypeId = 1
                        },
                        new
                        {
                            Id = 36,
                            Capacity = 5,
                            IsAvailable = true,
                            Name = "Room 414",
                            Price = 868.0,
                            RoomTypeId = 1
                        },
                        new
                        {
                            Id = 37,
                            Capacity = 9,
                            IsAvailable = false,
                            Name = "Room 442",
                            Price = 625.0,
                            RoomTypeId = 3
                        },
                        new
                        {
                            Id = 38,
                            Capacity = 1,
                            IsAvailable = true,
                            Name = "Room 135",
                            Price = 765.0,
                            RoomTypeId = 3
                        },
                        new
                        {
                            Id = 39,
                            Capacity = 6,
                            IsAvailable = false,
                            Name = "Room 428",
                            Price = 857.0,
                            RoomTypeId = 3
                        },
                        new
                        {
                            Id = 40,
                            Capacity = 7,
                            IsAvailable = true,
                            Name = "Room 180",
                            Price = 655.0,
                            RoomTypeId = 3
                        },
                        new
                        {
                            Id = 41,
                            Capacity = 2,
                            IsAvailable = true,
                            Name = "Room 331",
                            Price = 590.0,
                            RoomTypeId = 1
                        },
                        new
                        {
                            Id = 42,
                            Capacity = 6,
                            IsAvailable = true,
                            Name = "Room 486",
                            Price = 451.0,
                            RoomTypeId = 1
                        },
                        new
                        {
                            Id = 43,
                            Capacity = 10,
                            IsAvailable = false,
                            Name = "Room 224",
                            Price = 480.0,
                            RoomTypeId = 3
                        },
                        new
                        {
                            Id = 44,
                            Capacity = 4,
                            IsAvailable = false,
                            Name = "Room 163",
                            Price = 132.0,
                            RoomTypeId = 3
                        },
                        new
                        {
                            Id = 45,
                            Capacity = 8,
                            IsAvailable = true,
                            Name = "Room 256",
                            Price = 703.0,
                            RoomTypeId = 2
                        },
                        new
                        {
                            Id = 46,
                            Capacity = 10,
                            IsAvailable = false,
                            Name = "Room 371",
                            Price = 228.0,
                            RoomTypeId = 3
                        },
                        new
                        {
                            Id = 47,
                            Capacity = 4,
                            IsAvailable = false,
                            Name = "Room 496",
                            Price = 568.0,
                            RoomTypeId = 3
                        },
                        new
                        {
                            Id = 48,
                            Capacity = 3,
                            IsAvailable = true,
                            Name = "Room 398",
                            Price = 305.0,
                            RoomTypeId = 2
                        },
                        new
                        {
                            Id = 49,
                            Capacity = 4,
                            IsAvailable = true,
                            Name = "Room 278",
                            Price = 258.0,
                            RoomTypeId = 2
                        },
                        new
                        {
                            Id = 50,
                            Capacity = 2,
                            IsAvailable = false,
                            Name = "Room 436",
                            Price = 66.0,
                            RoomTypeId = 1
                        });
                });

            modelBuilder.Entity("Hotel_Management.Models.RoomType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("RoomType");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "A single room for one person.",
                            Name = "Single"
                        },
                        new
                        {
                            Id = 2,
                            Description = "A double room for two people.",
                            Name = "Double"
                        },
                        new
                        {
                            Id = 3,
                            Description = "A luxury suite for families or VIPs.",
                            Name = "Suite"
                        });
                });

            modelBuilder.Entity("Hotel_Management.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "admin@hotel.com",
                            FirstName = "admin",
                            LastName = "admin",
                            Password = "$2a$11$PA/okAoy08yPb26yiLeH1OQ8b7J8hDwiJ6VlwYkofKRp/b9rybZ9i",
                            PhoneNumber = "0600000000",
                            Role = 0
                        },
                        new
                        {
                            Id = 2,
                            Email = "Joy29@yahoo.com",
                            FirstName = "Pat",
                            LastName = "Streich",
                            Password = "$2a$11$zAlxKA2taD49A.j2sUAE1.0/JTlaN6m7DJKTIQ3qr.5A2iFxJ/cIC",
                            PhoneNumber = "634-738-6549 x10634",
                            Role = 0
                        },
                        new
                        {
                            Id = 3,
                            Email = "Kory8@gmail.com",
                            FirstName = "Americo",
                            LastName = "Langworth",
                            Password = "$2a$11$7y/huFslc0arA0gDvl87FOn4KwGp2RKH/55.Z9lZkjcOWmrQankiS",
                            PhoneNumber = "1-870-222-7598",
                            Role = 2
                        },
                        new
                        {
                            Id = 4,
                            Email = "Rod.Goyette@hotmail.com",
                            FirstName = "Antoinette",
                            LastName = "Kerluke",
                            Password = "$2a$11$p5RUmmFQKCFFe4ciyYDh5uZhRxGPMFsR4xNzXkDRHBsS8nPdO6oDi",
                            PhoneNumber = "856.312.0103",
                            Role = 0
                        },
                        new
                        {
                            Id = 5,
                            Email = "Lucie.Monahan33@gmail.com",
                            FirstName = "Xander",
                            LastName = "Schamberger",
                            Password = "$2a$11$EvI76Hl1QG9sSLxFoD.f2Ocixq9rrjuJupeHr.W7UHkEFqPqKLhom",
                            PhoneNumber = "438-531-5668",
                            Role = 0
                        },
                        new
                        {
                            Id = 6,
                            Email = "Rolando37@yahoo.com",
                            FirstName = "Pat",
                            LastName = "Jaskolski",
                            Password = "$2a$11$bmZSrnu/40TTTPPvvoNOKeJ7Ujp3ed45dbq75t0UFlRhpa9bKRxZa",
                            PhoneNumber = "(292) 730-0767 x702",
                            Role = 2
                        },
                        new
                        {
                            Id = 7,
                            Email = "Efren67@gmail.com",
                            FirstName = "Eudora",
                            LastName = "VonRueden",
                            Password = "$2a$11$rknatDLmSWeDTu.h0.lC6.acYJt0D1.S8HPGaBQK1uY2nSK0kHBfa",
                            PhoneNumber = "911.507.2219 x9332",
                            Role = 1
                        },
                        new
                        {
                            Id = 8,
                            Email = "Alysson.Hettinger@yahoo.com",
                            FirstName = "Geo",
                            LastName = "Lockman",
                            Password = "$2a$11$BtX8a7rV85EQ0cAXWnDAnub3ezEWHnU2fIcBbSLARmaREK5dV7IkC",
                            PhoneNumber = "598.242.0342 x702",
                            Role = 1
                        },
                        new
                        {
                            Id = 9,
                            Email = "Jaydon84@hotmail.com",
                            FirstName = "Abbey",
                            LastName = "Lueilwitz",
                            Password = "$2a$11$y7ZT4/tOjAyl8XYcIFYljOJj7lEJcTxzTAt.A5lU/AzMOaR52hMg6",
                            PhoneNumber = "438-525-2571 x2489",
                            Role = 0
                        },
                        new
                        {
                            Id = 10,
                            Email = "Loyal_Lehner18@hotmail.com",
                            FirstName = "Joanny",
                            LastName = "Auer",
                            Password = "$2a$11$PEsOf/8Huii.5BW059p0beHV62/Jmb1.FIYYsSVLCISKVlDOwAdca",
                            PhoneNumber = "377-428-8700 x31963",
                            Role = 2
                        },
                        new
                        {
                            Id = 11,
                            Email = "Norene_Kunze56@gmail.com",
                            FirstName = "Alessandro",
                            LastName = "Terry",
                            Password = "$2a$11$2u3zVms2qspLQ69e1GSc.eJtKihJeL3koGnOSQjvM4o//UYnVdjS6",
                            PhoneNumber = "(716) 488-5202",
                            Role = 1
                        },
                        new
                        {
                            Id = 12,
                            Email = "Abbigail76@hotmail.com",
                            FirstName = "Alayna",
                            LastName = "Smith",
                            Password = "$2a$11$QxAZ/7yP0qFMOsYiKvcd7u.fl7IrODB2jBwvwK6R9u9RRNZwMlxgC",
                            PhoneNumber = "(236) 500-5995",
                            Role = 1
                        },
                        new
                        {
                            Id = 13,
                            Email = "Dejuan_Leffler72@gmail.com",
                            FirstName = "Beverly",
                            LastName = "Abbott",
                            Password = "$2a$11$7805iBIvzSMuqHXv6j8IKu0NHZg2dTS1/CDNoyfYdOLCWpNZbYHmC",
                            PhoneNumber = "830-621-6293",
                            Role = 2
                        },
                        new
                        {
                            Id = 14,
                            Email = "Harold_Wolf@yahoo.com",
                            FirstName = "Emelie",
                            LastName = "Fritsch",
                            Password = "$2a$11$ij2uK5UyjYf0/ME5RglQ6us2.FRCcLYLKh.VULLSWgqwGwMYegJXu",
                            PhoneNumber = "(510) 260-1845 x566",
                            Role = 0
                        },
                        new
                        {
                            Id = 15,
                            Email = "Salvatore.Bogan91@yahoo.com",
                            FirstName = "Rod",
                            LastName = "Monahan",
                            Password = "$2a$11$rWTjbOfdOcVy.jjXUat.veXmosN//DOnhMAXV7yhmGwLrDcghlFBS",
                            PhoneNumber = "919-836-6811",
                            Role = 1
                        },
                        new
                        {
                            Id = 16,
                            Email = "Berta95@yahoo.com",
                            FirstName = "Ricardo",
                            LastName = "Crist",
                            Password = "$2a$11$wCrRZzvGe1UBaCQSdXCCHe7sx7mLbkZbK34WjtDx0VwalpS3mdqD2",
                            PhoneNumber = "981.933.9218 x49096",
                            Role = 0
                        },
                        new
                        {
                            Id = 17,
                            Email = "Jon6@gmail.com",
                            FirstName = "Jarrell",
                            LastName = "Lesch",
                            Password = "$2a$11$TSbqwDYEX/63DLwbK8ou9.Ryd92XPhcKJH6gP4x2GNTp.CNkTfHO.",
                            PhoneNumber = "873-788-5481",
                            Role = 0
                        },
                        new
                        {
                            Id = 18,
                            Email = "Eloise29@hotmail.com",
                            FirstName = "Myrtis",
                            LastName = "Kessler",
                            Password = "$2a$11$U9DPj.dlcel.h531ZmkTWeA.csNENcWJoyeFKNof88cbe5sxJAjyG",
                            PhoneNumber = "738.461.2103 x274",
                            Role = 0
                        },
                        new
                        {
                            Id = 19,
                            Email = "Gerda.Hayes88@hotmail.com",
                            FirstName = "Albin",
                            LastName = "Kris",
                            Password = "$2a$11$Vl08MRLX.EjXy2VnoBdrHuBdArCmPltZsae4KEXIID6HmuEA3.f.G",
                            PhoneNumber = "614-660-1766 x797",
                            Role = 2
                        },
                        new
                        {
                            Id = 20,
                            Email = "Jerry0@yahoo.com",
                            FirstName = "Marcel",
                            LastName = "Kreiger",
                            Password = "$2a$11$JHM/wHEOed0P8A4t.NzR7OZhDpqu.b9MnoHmpbCpk2AFZeEB3oUyK",
                            PhoneNumber = "1-793-386-0427 x8549",
                            Role = 0
                        },
                        new
                        {
                            Id = 21,
                            Email = "Adolfo.Moore22@gmail.com",
                            FirstName = "Rudolph",
                            LastName = "McLaughlin",
                            Password = "$2a$11$gMpoqdFXUV/Bg4N6z0tYNeVRvQKvBfsO4jLFKeVqK04n.YeUJCRmy",
                            PhoneNumber = "730.616.4743",
                            Role = 0
                        },
                        new
                        {
                            Id = 22,
                            Email = "Berniece_Cummerata43@gmail.com",
                            FirstName = "Joshuah",
                            LastName = "Hagenes",
                            Password = "$2a$11$ejUIueH96e176jHMsXg7yeZ2RQ0FVfNHqcTmz8MmUAAVEKXZcnAf2",
                            PhoneNumber = "889.533.0216 x09580",
                            Role = 2
                        },
                        new
                        {
                            Id = 23,
                            Email = "Ryder.Okuneva@gmail.com",
                            FirstName = "Hortense",
                            LastName = "McCullough",
                            Password = "$2a$11$t8IrAhCNOQK8aRSFdwRvKOp17A8aR9izlrUi0KUqiT588obEJ7k3C",
                            PhoneNumber = "930-696-5390",
                            Role = 0
                        },
                        new
                        {
                            Id = 24,
                            Email = "Sherman_Johnson@gmail.com",
                            FirstName = "Cleo",
                            LastName = "Dicki",
                            Password = "$2a$11$OyFt5.0.MFx/F1V9ipz37.V8Jo4x9hM2IxanaqOLT04PxWPvE.Kb6",
                            PhoneNumber = "640-682-1419 x1659",
                            Role = 2
                        },
                        new
                        {
                            Id = 25,
                            Email = "Wilma_Herman@gmail.com",
                            FirstName = "Cierra",
                            LastName = "Heller",
                            Password = "$2a$11$EH9yT5yZh7/J3qxzwUu0luWcAmk40CL5.8WooxN/2uKENz23NBgDm",
                            PhoneNumber = "329.288.1884 x8809",
                            Role = 1
                        },
                        new
                        {
                            Id = 26,
                            Email = "Anastacio48@gmail.com",
                            FirstName = "Gracie",
                            LastName = "Erdman",
                            Password = "$2a$11$M3dHWP0sf0jaT/5Kt7fzte/nnZObaYM1Nejqbo27ZYeg9xr2DTOPu",
                            PhoneNumber = "909-846-7259",
                            Role = 2
                        });
                });

            modelBuilder.Entity("Hotel_Management.Models.Payment", b =>
                {
                    b.HasOne("Hotel_Management.Models.Reservation", "Reservation")
                        .WithMany()
                        .HasForeignKey("ReservationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Reservation");
                });

            modelBuilder.Entity("Hotel_Management.Models.Reservation", b =>
                {
                    b.HasOne("Hotel_Management.Models.Room", "Room")
                        .WithMany()
                        .HasForeignKey("RoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Hotel_Management.Models.User", "Client")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");

                    b.Navigation("Room");
                });

            modelBuilder.Entity("Hotel_Management.Models.Room", b =>
                {
                    b.HasOne("Hotel_Management.Models.RoomType", "RoomType")
                        .WithMany()
                        .HasForeignKey("RoomTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("RoomType");
                });
#pragma warning restore 612, 618
        }
    }
}
