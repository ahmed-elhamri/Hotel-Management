using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Hotel_Management.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataMigrations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "RoomType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomType", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LastName = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneNumber = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Password = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Role = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Capacity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<double>(type: "double", nullable: false),
                    IsAvailable = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    RoomTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rooms_RoomType_RoomTypeId",
                        column: x => x.RoomTypeId,
                        principalTable: "RoomType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Reservation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoomId = table.Column<int>(type: "int", nullable: false),
                    CheckInDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    CheckOutDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    TotalPrice = table.Column<double>(type: "double", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reservation_Rooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Rooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reservation_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Payment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ReservationId = table.Column<int>(type: "int", nullable: false),
                    PaymentDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Amount = table.Column<double>(type: "double", nullable: false),
                    PaymentMethod = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Payment_Reservation_ReservationId",
                        column: x => x.ReservationId,
                        principalTable: "Reservation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "RoomType",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "A single room for one person.", "Single" },
                    { 2, "A double room for two people.", "Double" },
                    { 3, "A luxury suite for families or VIPs.", "Suite" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "Password", "PhoneNumber", "Role" },
                values: new object[,]
                {
                    { 1, "admin@hotel.com", "admin", "admin", "$2a$11$WBXYonNfwb2kUw5tYbHGc.VAiSkDtGAmuvE5iyYJABiEzr/BBexcq", "0600000000", 0 },
                    { 2, "Mercedes.Ondricka88@hotmail.com", "Ahmad", "Schaefer", "$2a$11$68ixrISoVbIJoaqhZvF1j.kiDz3h8yYNcpEd98IGk6qRspRBPO6ru", "1-948-794-0451 x065", 0 },
                    { 3, "Lionel.Hegmann91@hotmail.com", "Mavis", "O'Keefe", "$2a$11$EQJsIzw.Ddd/XBvD6w2MYuD1bq1JO/Nt8/1/s7ErMoAu0Zeb0cUZ6", "687.351.1442 x66011", 2 },
                    { 4, "Kurtis_Hansen@hotmail.com", "Shaniya", "Shields", "$2a$11$0qVztEJiWbatt0Ns3fSbP.SQPA9VjCBKj0qxBGGP88rcfRixdY5Q.", "(267) 737-1146 x74723", 1 },
                    { 5, "Zackery_Baumbach@hotmail.com", "Cecil", "Hermann", "$2a$11$6/VegGlFsH5u38sXo2DCoO939R3HETcUAGR2bRWcCPo1.U4wkBJBy", "636-870-3062", 0 },
                    { 6, "Verla10@gmail.com", "Augusta", "Koelpin", "$2a$11$B/zrl8IKucbpMFkNx0iIlu1ZmR1GseyQZx5V0IVjT88Ge8cIsfujm", "(712) 979-5454", 0 },
                    { 7, "Jacinthe.Turner@gmail.com", "Danial", "Hane", "$2a$11$sSizrVeA7nZPDaf5xSvYRul97oTQvN394HIwGgoqxiBYunWB/jd7y", "273.649.0747 x528", 1 },
                    { 8, "Garry_Walker47@gmail.com", "Wade", "Gutkowski", "$2a$11$YJPKhFp6SZimRKLQz8zXyuIQ88iX04zCG7Pit7IB9OWSCp2Yblcdm", "638-563-6844 x802", 2 },
                    { 9, "Moises6@yahoo.com", "Sincere", "Dooley", "$2a$11$8vF8A9CpUs7h05a1qngBBO0WdaFZPlKXO315Yi3nbx3mNcpBd4/1S", "1-995-575-6612 x196", 1 },
                    { 10, "Rebekah.Robel@gmail.com", "Oswald", "Howell", "$2a$11$tFc/VI2Wi8eHI4DaD8ys4et1u9gPF6hj3Pp69y1jsuUjBmhufGjVS", "1-379-962-2738 x9656", 0 },
                    { 11, "Laurel21@hotmail.com", "June", "Heidenreich", "$2a$11$brKvRcOZEuQ1/xQe9GZ9y.85ix0u3sJLTwkLaA1uf8J4tLJLaZP6S", "1-255-326-2676", 2 },
                    { 12, "Jocelyn_Rempel25@hotmail.com", "Johanna", "Stehr", "$2a$11$6e5DG/FTcpyTzK01svfgheR08/hLpRJzKwx97J7mDLr04.PWfjDom", "256-769-6525", 2 },
                    { 13, "Everette_Reinger12@gmail.com", "Giovanny", "Stark", "$2a$11$1GbE1wDmeBf8U71KLzpF5OjztUIYr/Wb7BRPtw1/zZSX5NonqsqEi", "1-636-297-6589", 2 },
                    { 14, "Manley.White@hotmail.com", "Kendall", "Huels", "$2a$11$zKErQIwTvQ0fB6y9rw32uOk3U4BQAwKQc/z1eNKf.CXuvdnLDAl12", "(555) 821-6933 x7546", 2 },
                    { 15, "Sigmund.Grady44@hotmail.com", "Florine", "Senger", "$2a$11$/hynQC8TPvLEBEZ7yF4h6uWpmYehNDjy1pZDRAn/zuM6z1KBGAEFW", "1-537-360-8713 x01787", 2 },
                    { 16, "Will11@hotmail.com", "Bret", "Simonis", "$2a$11$oahYamTUgR68CtiDzJM9w.nGiqJ00M2isemVYuDigSQtFXwxk962u", "1-445-896-7670", 1 },
                    { 17, "Alicia.Wyman@hotmail.com", "Jakob", "Langworth", "$2a$11$K1vZlVxNUbDsO.1zw/kKl.hFCiOkAm3UBwcvXf8Bb.IDfEIOIO6Ry", "665.881.8073 x5735", 0 },
                    { 18, "Deshawn_Medhurst22@hotmail.com", "Luz", "Mertz", "$2a$11$FWcqVE3iQU91ecdQ8aVGKe2U9Pf4aG16XN82uMLuRHbgeAV2zZUo.", "912-508-3039", 2 },
                    { 19, "Billie_Kshlerin@hotmail.com", "Dejuan", "Frami", "$2a$11$YyHSSjUcG0/r7U.D6Pg3UeqaGIASkN1zOJHCFh5mXcPg44bKZIR82", "1-682-838-2838 x74299", 0 },
                    { 20, "Keyshawn.Effertz@gmail.com", "Arno", "Rutherford", "$2a$11$1WDEy51YrEYHOJxHpksmgur9kXjPH/U24HwutzGUjpRFJAH9XYKW.", "588-323-3903", 0 },
                    { 21, "Lawrence.Waters87@gmail.com", "Curt", "Orn", "$2a$11$VdUVf1YL7KrNd5t5Q.cjB.TeAmw9UvvXfC7e.1ZkB6vUvrFGT2qua", "1-852-820-5889 x315", 1 },
                    { 22, "Stephania_Hammes59@gmail.com", "Justine", "Lueilwitz", "$2a$11$deGpcQXMVAQ3Sr9E7OPbOeH37sNKCqpwC6iVoO7eF/YIK.WSIFzAq", "762.810.6737", 0 },
                    { 23, "Vidal63@hotmail.com", "Gracie", "Johns", "$2a$11$bfhK3TjKZ7zzcv7OGQKS/ey3y1a.lpIprlmdnOGzHuB03unYKsqxi", "914.411.9861 x043", 2 },
                    { 24, "Leonard16@yahoo.com", "Juana", "Legros", "$2a$11$gnrk5iTuBrhXQsK2KvBvYOu6HCryZsnjPwrzIKrC15KfT9zEEhJlq", "(669) 718-2553", 2 },
                    { 25, "Wilfred_Predovic47@hotmail.com", "Christiana", "Zulauf", "$2a$11$oqwXze0ziK7ZZV0QOludNeeu2BdUK33ZDu2tbZKY.SA4l4aPAwohW", "470-470-7471", 2 },
                    { 26, "Rick.Kovacek@gmail.com", "Augusta", "Schmeler", "$2a$11$K/JF8qVnvAG1wAiuKqHaWuVSlp22rAOymMmNPYflQGfRsC3yonTmm", "1-982-548-6043 x587", 1 }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Capacity", "IsAvailable", "Name", "Price", "RoomTypeId" },
                values: new object[,]
                {
                    { 1, 10, false, "Room 347", 785.0, 3 },
                    { 2, 5, false, "Room 415", 696.0, 3 },
                    { 3, 6, true, "Room 249", 602.0, 3 },
                    { 4, 7, false, "Room 121", 791.0, 2 },
                    { 5, 5, false, "Room 318", 599.0, 3 },
                    { 6, 6, false, "Room 123", 584.0, 2 },
                    { 7, 3, false, "Room 391", 121.0, 2 },
                    { 8, 6, true, "Room 230", 416.0, 1 },
                    { 9, 1, false, "Room 262", 538.0, 3 },
                    { 10, 1, true, "Room 291", 856.0, 1 },
                    { 11, 1, false, "Room 401", 905.0, 1 },
                    { 12, 8, true, "Room 478", 811.0, 2 },
                    { 13, 9, true, "Room 200", 960.0, 2 },
                    { 14, 10, false, "Room 335", 69.0, 1 },
                    { 15, 10, true, "Room 310", 980.0, 1 },
                    { 16, 9, true, "Room 274", 752.0, 3 },
                    { 17, 1, false, "Room 373", 558.0, 1 },
                    { 18, 10, false, "Room 138", 253.0, 1 },
                    { 19, 2, false, "Room 445", 979.0, 3 },
                    { 20, 8, true, "Room 144", 671.0, 2 },
                    { 21, 7, false, "Room 384", 604.0, 3 },
                    { 22, 5, true, "Room 183", 692.0, 1 },
                    { 23, 10, true, "Room 293", 900.0, 1 },
                    { 24, 10, true, "Room 194", 289.0, 3 },
                    { 25, 7, false, "Room 134", 910.0, 2 },
                    { 26, 10, false, "Room 206", 823.0, 3 },
                    { 27, 5, true, "Room 483", 688.0, 3 },
                    { 28, 10, false, "Room 412", 426.0, 1 },
                    { 29, 6, true, "Room 175", 816.0, 2 },
                    { 30, 8, false, "Room 190", 470.0, 3 },
                    { 31, 6, true, "Room 213", 332.0, 3 },
                    { 32, 10, false, "Room 256", 915.0, 2 },
                    { 33, 2, true, "Room 163", 601.0, 2 },
                    { 34, 1, false, "Room 186", 413.0, 1 },
                    { 35, 1, false, "Room 276", 831.0, 3 },
                    { 36, 5, true, "Room 383", 655.0, 3 },
                    { 37, 6, true, "Room 406", 437.0, 3 },
                    { 38, 7, false, "Room 225", 497.0, 1 },
                    { 39, 1, false, "Room 260", 560.0, 2 },
                    { 40, 4, false, "Room 384", 245.0, 3 },
                    { 41, 9, true, "Room 317", 813.0, 3 },
                    { 42, 7, false, "Room 446", 67.0, 1 },
                    { 43, 3, false, "Room 404", 717.0, 3 },
                    { 44, 5, false, "Room 225", 869.0, 3 },
                    { 45, 9, false, "Room 466", 571.0, 3 },
                    { 46, 6, false, "Room 283", 384.0, 1 },
                    { 47, 5, false, "Room 234", 701.0, 3 },
                    { 48, 1, false, "Room 228", 773.0, 2 },
                    { 49, 10, true, "Room 319", 307.0, 2 },
                    { 50, 1, true, "Room 305", 667.0, 1 }
                });

            migrationBuilder.InsertData(
                table: "Reservation",
                columns: new[] { "Id", "CheckInDate", "CheckOutDate", "RoomId", "Status", "TotalPrice", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 1, 12, 23, 28, 18, 509, DateTimeKind.Local).AddTicks(9095), new DateTime(2025, 1, 20, 23, 28, 18, 509, DateTimeKind.Local).AddTicks(9095), 12, 1, 3027.0, 9 },
                    { 2, new DateTime(2024, 11, 30, 17, 5, 40, 226, DateTimeKind.Local).AddTicks(1788), new DateTime(2024, 12, 2, 17, 5, 40, 226, DateTimeKind.Local).AddTicks(1788), 14, 0, 489.0, 2 },
                    { 3, new DateTime(2024, 12, 26, 12, 6, 26, 835, DateTimeKind.Local).AddTicks(3206), new DateTime(2024, 12, 28, 12, 6, 26, 835, DateTimeKind.Local).AddTicks(3206), 9, 2, 4671.0, 8 },
                    { 4, new DateTime(2024, 11, 26, 14, 28, 22, 642, DateTimeKind.Local).AddTicks(6315), new DateTime(2024, 11, 30, 14, 28, 22, 642, DateTimeKind.Local).AddTicks(6315), 5, 2, 1701.0, 10 },
                    { 5, new DateTime(2024, 12, 31, 17, 3, 27, 98, DateTimeKind.Local).AddTicks(8933), new DateTime(2025, 1, 9, 17, 3, 27, 98, DateTimeKind.Local).AddTicks(8933), 8, 1, 4846.0, 8 },
                    { 6, new DateTime(2024, 12, 4, 4, 46, 48, 826, DateTimeKind.Local).AddTicks(3533), new DateTime(2024, 12, 10, 4, 46, 48, 826, DateTimeKind.Local).AddTicks(3533), 1, 0, 551.0, 10 },
                    { 7, new DateTime(2024, 12, 9, 13, 20, 20, 290, DateTimeKind.Local).AddTicks(3380), new DateTime(2024, 12, 16, 13, 20, 20, 290, DateTimeKind.Local).AddTicks(3380), 32, 0, 3603.0, 4 },
                    { 8, new DateTime(2025, 1, 14, 9, 8, 24, 662, DateTimeKind.Local).AddTicks(1186), new DateTime(2025, 1, 18, 9, 8, 24, 662, DateTimeKind.Local).AddTicks(1186), 46, 0, 3862.0, 3 },
                    { 9, new DateTime(2025, 1, 15, 6, 52, 36, 434, DateTimeKind.Local).AddTicks(542), new DateTime(2025, 1, 20, 6, 52, 36, 434, DateTimeKind.Local).AddTicks(542), 47, 0, 673.0, 3 },
                    { 10, new DateTime(2025, 1, 20, 6, 50, 34, 598, DateTimeKind.Local).AddTicks(1097), new DateTime(2025, 1, 23, 6, 50, 34, 598, DateTimeKind.Local).AddTicks(1097), 38, 1, 2846.0, 5 },
                    { 11, new DateTime(2025, 1, 3, 13, 32, 5, 213, DateTimeKind.Local).AddTicks(4348), new DateTime(2025, 1, 10, 13, 32, 5, 213, DateTimeKind.Local).AddTicks(4348), 40, 0, 2843.0, 8 },
                    { 12, new DateTime(2025, 1, 23, 11, 16, 5, 157, DateTimeKind.Local).AddTicks(2337), new DateTime(2025, 1, 24, 11, 16, 5, 157, DateTimeKind.Local).AddTicks(2337), 19, 2, 4791.0, 2 },
                    { 13, new DateTime(2025, 1, 8, 15, 17, 4, 275, DateTimeKind.Local).AddTicks(2086), new DateTime(2025, 1, 14, 15, 17, 4, 275, DateTimeKind.Local).AddTicks(2086), 39, 0, 2183.0, 10 },
                    { 14, new DateTime(2024, 11, 26, 20, 38, 42, 183, DateTimeKind.Local).AddTicks(9386), new DateTime(2024, 11, 27, 20, 38, 42, 183, DateTimeKind.Local).AddTicks(9386), 25, 1, 434.0, 9 },
                    { 15, new DateTime(2025, 1, 1, 1, 54, 12, 192, DateTimeKind.Local).AddTicks(7129), new DateTime(2025, 1, 3, 1, 54, 12, 192, DateTimeKind.Local).AddTicks(7129), 45, 1, 1195.0, 1 },
                    { 16, new DateTime(2025, 1, 14, 3, 17, 49, 904, DateTimeKind.Local).AddTicks(5631), new DateTime(2025, 1, 16, 3, 17, 49, 904, DateTimeKind.Local).AddTicks(5631), 27, 1, 4147.0, 10 },
                    { 17, new DateTime(2025, 1, 12, 13, 41, 3, 315, DateTimeKind.Local).AddTicks(1058), new DateTime(2025, 1, 20, 13, 41, 3, 315, DateTimeKind.Local).AddTicks(1058), 22, 2, 1770.0, 2 },
                    { 18, new DateTime(2024, 12, 10, 2, 45, 9, 140, DateTimeKind.Local).AddTicks(8851), new DateTime(2024, 12, 11, 2, 45, 9, 140, DateTimeKind.Local).AddTicks(8851), 9, 0, 4378.0, 2 },
                    { 19, new DateTime(2024, 12, 6, 22, 55, 30, 732, DateTimeKind.Local).AddTicks(3602), new DateTime(2024, 12, 9, 22, 55, 30, 732, DateTimeKind.Local).AddTicks(3602), 12, 0, 1978.0, 7 },
                    { 20, new DateTime(2025, 1, 12, 11, 5, 3, 665, DateTimeKind.Local).AddTicks(6392), new DateTime(2025, 1, 19, 11, 5, 3, 665, DateTimeKind.Local).AddTicks(6392), 19, 2, 521.0, 2 },
                    { 21, new DateTime(2025, 1, 15, 22, 40, 55, 529, DateTimeKind.Local).AddTicks(9239), new DateTime(2025, 1, 21, 22, 40, 55, 529, DateTimeKind.Local).AddTicks(9239), 47, 0, 3389.0, 6 },
                    { 22, new DateTime(2025, 1, 18, 22, 7, 11, 270, DateTimeKind.Local).AddTicks(9370), new DateTime(2025, 1, 28, 22, 7, 11, 270, DateTimeKind.Local).AddTicks(9370), 10, 1, 678.0, 3 },
                    { 23, new DateTime(2025, 1, 23, 3, 33, 38, 670, DateTimeKind.Local).AddTicks(9390), new DateTime(2025, 1, 28, 3, 33, 38, 670, DateTimeKind.Local).AddTicks(9390), 50, 0, 3503.0, 8 },
                    { 24, new DateTime(2024, 12, 3, 4, 3, 1, 718, DateTimeKind.Local).AddTicks(3309), new DateTime(2024, 12, 11, 4, 3, 1, 718, DateTimeKind.Local).AddTicks(3309), 44, 2, 2915.0, 9 },
                    { 25, new DateTime(2024, 12, 11, 10, 40, 43, 289, DateTimeKind.Local).AddTicks(858), new DateTime(2024, 12, 19, 10, 40, 43, 289, DateTimeKind.Local).AddTicks(858), 35, 1, 1995.0, 9 },
                    { 26, new DateTime(2025, 1, 12, 14, 5, 59, 300, DateTimeKind.Local).AddTicks(3777), new DateTime(2025, 1, 19, 14, 5, 59, 300, DateTimeKind.Local).AddTicks(3777), 46, 1, 4621.0, 7 },
                    { 27, new DateTime(2025, 1, 6, 23, 48, 44, 99, DateTimeKind.Local).AddTicks(673), new DateTime(2025, 1, 16, 23, 48, 44, 99, DateTimeKind.Local).AddTicks(673), 45, 0, 4891.0, 4 },
                    { 28, new DateTime(2024, 12, 23, 1, 30, 19, 59, DateTimeKind.Local).AddTicks(2333), new DateTime(2024, 12, 28, 1, 30, 19, 59, DateTimeKind.Local).AddTicks(2333), 45, 2, 1014.0, 9 },
                    { 29, new DateTime(2024, 12, 21, 18, 20, 15, 475, DateTimeKind.Local).AddTicks(4699), new DateTime(2024, 12, 23, 18, 20, 15, 475, DateTimeKind.Local).AddTicks(4699), 20, 1, 4454.0, 9 },
                    { 30, new DateTime(2025, 1, 7, 11, 27, 42, 428, DateTimeKind.Local).AddTicks(7548), new DateTime(2025, 1, 13, 11, 27, 42, 428, DateTimeKind.Local).AddTicks(7548), 2, 1, 2495.0, 9 },
                    { 31, new DateTime(2025, 1, 2, 17, 15, 55, 855, DateTimeKind.Local).AddTicks(5480), new DateTime(2025, 1, 11, 17, 15, 55, 855, DateTimeKind.Local).AddTicks(5480), 7, 0, 907.0, 5 },
                    { 32, new DateTime(2024, 12, 9, 4, 3, 37, 882, DateTimeKind.Local).AddTicks(715), new DateTime(2024, 12, 17, 4, 3, 37, 882, DateTimeKind.Local).AddTicks(715), 18, 0, 1256.0, 2 },
                    { 33, new DateTime(2024, 12, 29, 23, 16, 21, 964, DateTimeKind.Local).AddTicks(7083), new DateTime(2025, 1, 2, 23, 16, 21, 964, DateTimeKind.Local).AddTicks(7083), 40, 1, 199.0, 4 },
                    { 34, new DateTime(2024, 11, 26, 15, 37, 54, 645, DateTimeKind.Local).AddTicks(5422), new DateTime(2024, 11, 28, 15, 37, 54, 645, DateTimeKind.Local).AddTicks(5422), 3, 1, 246.0, 5 },
                    { 35, new DateTime(2025, 1, 14, 6, 28, 36, 298, DateTimeKind.Local).AddTicks(909), new DateTime(2025, 1, 22, 6, 28, 36, 298, DateTimeKind.Local).AddTicks(909), 28, 1, 2783.0, 10 },
                    { 36, new DateTime(2025, 1, 2, 16, 20, 9, 419, DateTimeKind.Local).AddTicks(6678), new DateTime(2025, 1, 7, 16, 20, 9, 419, DateTimeKind.Local).AddTicks(6678), 29, 2, 4865.0, 5 },
                    { 37, new DateTime(2024, 12, 30, 13, 6, 13, 945, DateTimeKind.Local).AddTicks(7023), new DateTime(2025, 1, 1, 13, 6, 13, 945, DateTimeKind.Local).AddTicks(7023), 14, 2, 2416.0, 8 },
                    { 38, new DateTime(2024, 12, 29, 1, 14, 8, 324, DateTimeKind.Local).AddTicks(7169), new DateTime(2025, 1, 3, 1, 14, 8, 324, DateTimeKind.Local).AddTicks(7169), 30, 1, 3678.0, 5 },
                    { 39, new DateTime(2025, 1, 16, 9, 11, 13, 64, DateTimeKind.Local).AddTicks(2626), new DateTime(2025, 1, 20, 9, 11, 13, 64, DateTimeKind.Local).AddTicks(2626), 14, 1, 2508.0, 6 },
                    { 40, new DateTime(2024, 11, 29, 7, 31, 43, 879, DateTimeKind.Local).AddTicks(3059), new DateTime(2024, 12, 1, 7, 31, 43, 879, DateTimeKind.Local).AddTicks(3059), 7, 2, 142.0, 10 },
                    { 41, new DateTime(2024, 12, 15, 23, 58, 48, 986, DateTimeKind.Local).AddTicks(3860), new DateTime(2024, 12, 16, 23, 58, 48, 986, DateTimeKind.Local).AddTicks(3860), 20, 2, 1356.0, 6 },
                    { 42, new DateTime(2025, 1, 22, 3, 44, 19, 429, DateTimeKind.Local).AddTicks(5410), new DateTime(2025, 1, 29, 3, 44, 19, 429, DateTimeKind.Local).AddTicks(5410), 30, 0, 4186.0, 1 },
                    { 43, new DateTime(2024, 12, 3, 0, 37, 41, 6, DateTimeKind.Local).AddTicks(2021), new DateTime(2024, 12, 10, 0, 37, 41, 6, DateTimeKind.Local).AddTicks(2021), 29, 1, 2017.0, 8 },
                    { 44, new DateTime(2025, 1, 17, 5, 26, 12, 518, DateTimeKind.Local).AddTicks(4944), new DateTime(2025, 1, 23, 5, 26, 12, 518, DateTimeKind.Local).AddTicks(4944), 27, 0, 2843.0, 1 },
                    { 45, new DateTime(2025, 1, 11, 0, 59, 22, 17, DateTimeKind.Local).AddTicks(8991), new DateTime(2025, 1, 19, 0, 59, 22, 17, DateTimeKind.Local).AddTicks(8991), 5, 2, 1531.0, 3 },
                    { 46, new DateTime(2025, 1, 5, 1, 53, 19, 265, DateTimeKind.Local).AddTicks(1024), new DateTime(2025, 1, 12, 1, 53, 19, 265, DateTimeKind.Local).AddTicks(1024), 44, 1, 2325.0, 4 },
                    { 47, new DateTime(2024, 12, 8, 12, 58, 19, 785, DateTimeKind.Local).AddTicks(3063), new DateTime(2024, 12, 14, 12, 58, 19, 785, DateTimeKind.Local).AddTicks(3063), 9, 0, 793.0, 8 },
                    { 48, new DateTime(2025, 1, 11, 8, 3, 22, 774, DateTimeKind.Local).AddTicks(9330), new DateTime(2025, 1, 16, 8, 3, 22, 774, DateTimeKind.Local).AddTicks(9330), 16, 2, 3937.0, 8 },
                    { 49, new DateTime(2024, 12, 13, 19, 25, 11, 668, DateTimeKind.Local).AddTicks(3207), new DateTime(2024, 12, 16, 19, 25, 11, 668, DateTimeKind.Local).AddTicks(3207), 16, 0, 1537.0, 2 },
                    { 50, new DateTime(2025, 1, 13, 10, 51, 32, 834, DateTimeKind.Local).AddTicks(2817), new DateTime(2025, 1, 18, 10, 51, 32, 834, DateTimeKind.Local).AddTicks(2817), 23, 0, 1072.0, 9 },
                    { 51, new DateTime(2025, 1, 4, 15, 33, 59, 647, DateTimeKind.Local).AddTicks(5511), new DateTime(2025, 1, 9, 15, 33, 59, 647, DateTimeKind.Local).AddTicks(5511), 34, 1, 1092.0, 4 },
                    { 52, new DateTime(2025, 1, 9, 21, 12, 17, 299, DateTimeKind.Local).AddTicks(5559), new DateTime(2025, 1, 12, 21, 12, 17, 299, DateTimeKind.Local).AddTicks(5559), 42, 2, 2001.0, 2 },
                    { 53, new DateTime(2024, 12, 7, 21, 40, 17, 220, DateTimeKind.Local).AddTicks(2996), new DateTime(2024, 12, 11, 21, 40, 17, 220, DateTimeKind.Local).AddTicks(2996), 28, 1, 1435.0, 6 },
                    { 54, new DateTime(2025, 1, 8, 18, 33, 25, 928, DateTimeKind.Local).AddTicks(5024), new DateTime(2025, 1, 12, 18, 33, 25, 928, DateTimeKind.Local).AddTicks(5024), 48, 1, 2638.0, 4 },
                    { 55, new DateTime(2024, 12, 31, 3, 30, 29, 131, DateTimeKind.Local).AddTicks(3056), new DateTime(2025, 1, 3, 3, 30, 29, 131, DateTimeKind.Local).AddTicks(3056), 31, 1, 3571.0, 10 },
                    { 56, new DateTime(2024, 12, 29, 4, 11, 38, 915, DateTimeKind.Local).AddTicks(5886), new DateTime(2025, 1, 8, 4, 11, 38, 915, DateTimeKind.Local).AddTicks(5886), 39, 2, 3163.0, 9 },
                    { 57, new DateTime(2025, 1, 18, 12, 21, 47, 355, DateTimeKind.Local).AddTicks(1365), new DateTime(2025, 1, 19, 12, 21, 47, 355, DateTimeKind.Local).AddTicks(1365), 2, 2, 4778.0, 7 },
                    { 58, new DateTime(2024, 12, 27, 4, 41, 42, 248, DateTimeKind.Local).AddTicks(6945), new DateTime(2024, 12, 28, 4, 41, 42, 248, DateTimeKind.Local).AddTicks(6945), 11, 0, 161.0, 4 },
                    { 59, new DateTime(2024, 12, 18, 4, 48, 29, 161, DateTimeKind.Local).AddTicks(8034), new DateTime(2024, 12, 25, 4, 48, 29, 161, DateTimeKind.Local).AddTicks(8034), 6, 2, 4911.0, 8 },
                    { 60, new DateTime(2024, 12, 11, 4, 31, 59, 892, DateTimeKind.Local).AddTicks(8494), new DateTime(2024, 12, 17, 4, 31, 59, 892, DateTimeKind.Local).AddTicks(8494), 11, 2, 2643.0, 3 },
                    { 61, new DateTime(2024, 12, 25, 4, 30, 7, 394, DateTimeKind.Local).AddTicks(5187), new DateTime(2025, 1, 4, 4, 30, 7, 394, DateTimeKind.Local).AddTicks(5187), 48, 2, 2260.0, 10 },
                    { 62, new DateTime(2025, 1, 16, 23, 36, 31, 669, DateTimeKind.Local).AddTicks(4033), new DateTime(2025, 1, 17, 23, 36, 31, 669, DateTimeKind.Local).AddTicks(4033), 45, 2, 3114.0, 1 },
                    { 63, new DateTime(2025, 1, 9, 11, 8, 20, 936, DateTimeKind.Local).AddTicks(1915), new DateTime(2025, 1, 11, 11, 8, 20, 936, DateTimeKind.Local).AddTicks(1915), 39, 0, 4191.0, 10 },
                    { 64, new DateTime(2025, 1, 2, 3, 20, 54, 699, DateTimeKind.Local).AddTicks(9628), new DateTime(2025, 1, 4, 3, 20, 54, 699, DateTimeKind.Local).AddTicks(9628), 30, 1, 1116.0, 2 },
                    { 65, new DateTime(2025, 1, 22, 8, 10, 6, 37, DateTimeKind.Local).AddTicks(3931), new DateTime(2025, 1, 30, 8, 10, 6, 37, DateTimeKind.Local).AddTicks(3931), 7, 2, 3756.0, 5 },
                    { 66, new DateTime(2024, 12, 11, 22, 47, 38, 306, DateTimeKind.Local).AddTicks(5885), new DateTime(2024, 12, 12, 22, 47, 38, 306, DateTimeKind.Local).AddTicks(5885), 16, 1, 4595.0, 8 },
                    { 67, new DateTime(2025, 1, 15, 12, 22, 4, 33, DateTimeKind.Local).AddTicks(9893), new DateTime(2025, 1, 25, 12, 22, 4, 33, DateTimeKind.Local).AddTicks(9893), 42, 1, 943.0, 8 },
                    { 68, new DateTime(2024, 12, 7, 2, 47, 33, 56, DateTimeKind.Local).AddTicks(1296), new DateTime(2024, 12, 15, 2, 47, 33, 56, DateTimeKind.Local).AddTicks(1296), 43, 2, 1463.0, 7 },
                    { 69, new DateTime(2025, 1, 23, 7, 59, 31, 792, DateTimeKind.Local).AddTicks(7774), new DateTime(2025, 1, 29, 7, 59, 31, 792, DateTimeKind.Local).AddTicks(7774), 45, 1, 4516.0, 4 },
                    { 70, new DateTime(2025, 1, 24, 11, 42, 52, 603, DateTimeKind.Local).AddTicks(5895), new DateTime(2025, 2, 3, 11, 42, 52, 603, DateTimeKind.Local).AddTicks(5895), 41, 0, 3093.0, 2 },
                    { 71, new DateTime(2024, 12, 26, 10, 3, 7, 328, DateTimeKind.Local).AddTicks(2413), new DateTime(2025, 1, 2, 10, 3, 7, 328, DateTimeKind.Local).AddTicks(2413), 16, 1, 3901.0, 6 },
                    { 72, new DateTime(2025, 1, 6, 18, 11, 28, 516, DateTimeKind.Local).AddTicks(2472), new DateTime(2025, 1, 12, 18, 11, 28, 516, DateTimeKind.Local).AddTicks(2472), 27, 1, 3597.0, 2 },
                    { 73, new DateTime(2024, 12, 20, 17, 12, 48, 427, DateTimeKind.Local).AddTicks(6814), new DateTime(2024, 12, 26, 17, 12, 48, 427, DateTimeKind.Local).AddTicks(6814), 2, 0, 3566.0, 3 },
                    { 74, new DateTime(2024, 12, 29, 20, 25, 35, 905, DateTimeKind.Local).AddTicks(967), new DateTime(2025, 1, 2, 20, 25, 35, 905, DateTimeKind.Local).AddTicks(967), 28, 0, 1488.0, 6 },
                    { 75, new DateTime(2024, 12, 15, 20, 20, 58, 293, DateTimeKind.Local).AddTicks(7211), new DateTime(2024, 12, 21, 20, 20, 58, 293, DateTimeKind.Local).AddTicks(7211), 29, 0, 2884.0, 8 },
                    { 76, new DateTime(2025, 1, 7, 8, 35, 23, 4, DateTimeKind.Local).AddTicks(6244), new DateTime(2025, 1, 13, 8, 35, 23, 4, DateTimeKind.Local).AddTicks(6244), 20, 2, 1323.0, 2 },
                    { 77, new DateTime(2024, 12, 1, 18, 53, 13, 581, DateTimeKind.Local).AddTicks(3058), new DateTime(2024, 12, 2, 18, 53, 13, 581, DateTimeKind.Local).AddTicks(3058), 25, 0, 2417.0, 3 },
                    { 78, new DateTime(2024, 12, 20, 21, 26, 38, 691, DateTimeKind.Local).AddTicks(5622), new DateTime(2024, 12, 26, 21, 26, 38, 691, DateTimeKind.Local).AddTicks(5622), 7, 1, 2376.0, 4 },
                    { 79, new DateTime(2025, 1, 13, 17, 41, 52, 41, DateTimeKind.Local).AddTicks(5524), new DateTime(2025, 1, 20, 17, 41, 52, 41, DateTimeKind.Local).AddTicks(5524), 36, 2, 2974.0, 3 },
                    { 80, new DateTime(2025, 1, 4, 15, 50, 39, 648, DateTimeKind.Local).AddTicks(8157), new DateTime(2025, 1, 8, 15, 50, 39, 648, DateTimeKind.Local).AddTicks(8157), 44, 1, 2300.0, 7 },
                    { 81, new DateTime(2024, 12, 11, 5, 1, 9, 406, DateTimeKind.Local).AddTicks(7084), new DateTime(2024, 12, 19, 5, 1, 9, 406, DateTimeKind.Local).AddTicks(7084), 6, 2, 564.0, 4 },
                    { 82, new DateTime(2025, 1, 14, 5, 33, 31, 606, DateTimeKind.Local).AddTicks(6894), new DateTime(2025, 1, 20, 5, 33, 31, 606, DateTimeKind.Local).AddTicks(6894), 4, 2, 3189.0, 2 },
                    { 83, new DateTime(2024, 12, 30, 23, 51, 47, 390, DateTimeKind.Local).AddTicks(6381), new DateTime(2024, 12, 31, 23, 51, 47, 390, DateTimeKind.Local).AddTicks(6381), 19, 2, 1305.0, 9 },
                    { 84, new DateTime(2024, 12, 21, 7, 2, 17, 624, DateTimeKind.Local).AddTicks(8129), new DateTime(2024, 12, 24, 7, 2, 17, 624, DateTimeKind.Local).AddTicks(8129), 44, 1, 3839.0, 5 },
                    { 85, new DateTime(2025, 1, 23, 15, 11, 49, 753, DateTimeKind.Local).AddTicks(7985), new DateTime(2025, 1, 27, 15, 11, 49, 753, DateTimeKind.Local).AddTicks(7985), 21, 0, 3066.0, 10 },
                    { 86, new DateTime(2024, 11, 28, 23, 12, 4, 671, DateTimeKind.Local).AddTicks(744), new DateTime(2024, 12, 6, 23, 12, 4, 671, DateTimeKind.Local).AddTicks(744), 32, 2, 212.0, 10 },
                    { 87, new DateTime(2024, 11, 26, 14, 28, 56, 857, DateTimeKind.Local).AddTicks(3877), new DateTime(2024, 11, 30, 14, 28, 56, 857, DateTimeKind.Local).AddTicks(3877), 15, 1, 2913.0, 5 },
                    { 88, new DateTime(2025, 1, 23, 12, 37, 3, 592, DateTimeKind.Local).AddTicks(3981), new DateTime(2025, 1, 31, 12, 37, 3, 592, DateTimeKind.Local).AddTicks(3981), 33, 1, 3130.0, 2 },
                    { 89, new DateTime(2024, 12, 30, 6, 16, 35, 450, DateTimeKind.Local).AddTicks(3115), new DateTime(2025, 1, 6, 6, 16, 35, 450, DateTimeKind.Local).AddTicks(3115), 31, 2, 3441.0, 5 },
                    { 90, new DateTime(2025, 1, 5, 17, 4, 42, 686, DateTimeKind.Local).AddTicks(288), new DateTime(2025, 1, 7, 17, 4, 42, 686, DateTimeKind.Local).AddTicks(288), 36, 2, 3103.0, 5 },
                    { 91, new DateTime(2024, 11, 30, 14, 55, 36, 142, DateTimeKind.Local).AddTicks(4588), new DateTime(2024, 12, 5, 14, 55, 36, 142, DateTimeKind.Local).AddTicks(4588), 34, 2, 4256.0, 9 },
                    { 92, new DateTime(2024, 12, 5, 4, 49, 39, 268, DateTimeKind.Local).AddTicks(507), new DateTime(2024, 12, 14, 4, 49, 39, 268, DateTimeKind.Local).AddTicks(507), 24, 1, 4972.0, 6 },
                    { 93, new DateTime(2024, 12, 19, 22, 8, 59, 35, DateTimeKind.Local).AddTicks(1123), new DateTime(2024, 12, 24, 22, 8, 59, 35, DateTimeKind.Local).AddTicks(1123), 18, 0, 191.0, 5 },
                    { 94, new DateTime(2024, 12, 5, 21, 8, 5, 397, DateTimeKind.Local).AddTicks(6762), new DateTime(2024, 12, 11, 21, 8, 5, 397, DateTimeKind.Local).AddTicks(6762), 47, 2, 3189.0, 2 },
                    { 95, new DateTime(2024, 12, 27, 1, 2, 23, 93, DateTimeKind.Local).AddTicks(4760), new DateTime(2024, 12, 31, 1, 2, 23, 93, DateTimeKind.Local).AddTicks(4760), 23, 1, 600.0, 7 },
                    { 96, new DateTime(2024, 12, 5, 4, 34, 46, 541, DateTimeKind.Local).AddTicks(882), new DateTime(2024, 12, 10, 4, 34, 46, 541, DateTimeKind.Local).AddTicks(882), 25, 2, 4360.0, 10 },
                    { 97, new DateTime(2025, 1, 8, 4, 37, 32, 262, DateTimeKind.Local).AddTicks(1514), new DateTime(2025, 1, 10, 4, 37, 32, 262, DateTimeKind.Local).AddTicks(1514), 48, 1, 3650.0, 10 },
                    { 98, new DateTime(2024, 12, 9, 11, 2, 54, 548, DateTimeKind.Local).AddTicks(8455), new DateTime(2024, 12, 16, 11, 2, 54, 548, DateTimeKind.Local).AddTicks(8455), 5, 2, 4844.0, 2 },
                    { 99, new DateTime(2024, 12, 24, 13, 25, 16, 785, DateTimeKind.Local).AddTicks(2957), new DateTime(2024, 12, 31, 13, 25, 16, 785, DateTimeKind.Local).AddTicks(2957), 8, 1, 4576.0, 4 },
                    { 100, new DateTime(2024, 12, 13, 4, 25, 29, 841, DateTimeKind.Local).AddTicks(3779), new DateTime(2024, 12, 21, 4, 25, 29, 841, DateTimeKind.Local).AddTicks(3779), 2, 1, 3080.0, 7 }
                });

            migrationBuilder.InsertData(
                table: "Payment",
                columns: new[] { "Id", "Amount", "PaymentDate", "PaymentMethod", "ReservationId", "Status" },
                values: new object[,]
                {
                    { 1, 340.48000000000002, new DateTime(2024, 12, 25, 12, 15, 43, 823, DateTimeKind.Local).AddTicks(2723), 1, 87, 1 },
                    { 2, 853.05999999999995, new DateTime(2024, 11, 30, 0, 42, 49, 347, DateTimeKind.Local).AddTicks(1806), 0, 1, 1 },
                    { 3, 605.39999999999998, new DateTime(2024, 12, 23, 10, 30, 50, 77, DateTimeKind.Local).AddTicks(7025), 1, 69, 0 },
                    { 4, 539.09000000000003, new DateTime(2024, 12, 24, 16, 4, 10, 787, DateTimeKind.Local).AddTicks(7082), 1, 93, 1 },
                    { 5, 432.23000000000002, new DateTime(2024, 11, 29, 8, 31, 0, 857, DateTimeKind.Local).AddTicks(5621), 1, 83, 1 },
                    { 6, 673.05999999999995, new DateTime(2024, 12, 11, 3, 25, 34, 228, DateTimeKind.Local).AddTicks(2321), 1, 4, 0 },
                    { 7, 804.13, new DateTime(2024, 11, 28, 16, 27, 42, 129, DateTimeKind.Local).AddTicks(2194), 1, 85, 0 },
                    { 8, 596.75999999999999, new DateTime(2024, 12, 13, 12, 31, 5, 824, DateTimeKind.Local).AddTicks(7064), 0, 22, 1 },
                    { 9, 151.15000000000001, new DateTime(2024, 12, 23, 13, 58, 46, 806, DateTimeKind.Local).AddTicks(8220), 0, 1, 0 },
                    { 10, 821.92999999999995, new DateTime(2024, 12, 10, 18, 53, 33, 411, DateTimeKind.Local).AddTicks(3491), 1, 91, 0 },
                    { 11, 781.0, new DateTime(2024, 12, 16, 20, 45, 36, 520, DateTimeKind.Local).AddTicks(8123), 1, 21, 1 },
                    { 12, 367.13999999999999, new DateTime(2024, 12, 21, 6, 44, 32, 491, DateTimeKind.Local).AddTicks(4181), 0, 46, 1 },
                    { 13, 149.15000000000001, new DateTime(2024, 11, 30, 16, 40, 57, 870, DateTimeKind.Local).AddTicks(3369), 1, 52, 1 },
                    { 14, 806.57000000000005, new DateTime(2024, 12, 4, 13, 17, 55, 649, DateTimeKind.Local).AddTicks(2857), 1, 97, 0 },
                    { 15, 264.43000000000001, new DateTime(2024, 12, 19, 13, 56, 3, 677, DateTimeKind.Local).AddTicks(9177), 1, 40, 1 },
                    { 16, 481.44999999999999, new DateTime(2024, 11, 27, 1, 15, 56, 376, DateTimeKind.Local).AddTicks(7100), 1, 75, 0 },
                    { 17, 265.98000000000002, new DateTime(2024, 11, 26, 6, 15, 42, 152, DateTimeKind.Local).AddTicks(7080), 0, 99, 0 },
                    { 18, 345.32999999999998, new DateTime(2024, 12, 15, 7, 58, 44, 577, DateTimeKind.Local).AddTicks(7749), 0, 54, 1 },
                    { 19, 771.52999999999997, new DateTime(2024, 12, 13, 8, 17, 23, 320, DateTimeKind.Local).AddTicks(116), 1, 89, 0 },
                    { 20, 235.94, new DateTime(2024, 12, 18, 10, 32, 39, 164, DateTimeKind.Local).AddTicks(155), 1, 24, 0 },
                    { 21, 523.47000000000003, new DateTime(2024, 12, 23, 3, 35, 43, 830, DateTimeKind.Local).AddTicks(437), 0, 30, 0 },
                    { 22, 212.44, new DateTime(2024, 12, 19, 23, 26, 0, 427, DateTimeKind.Local).AddTicks(19), 1, 1, 1 },
                    { 23, 794.84000000000003, new DateTime(2024, 11, 27, 18, 16, 44, 575, DateTimeKind.Local).AddTicks(7575), 0, 58, 1 },
                    { 24, 87.349999999999994, new DateTime(2024, 12, 12, 20, 12, 5, 957, DateTimeKind.Local).AddTicks(970), 1, 5, 0 },
                    { 25, 733.01999999999998, new DateTime(2024, 12, 18, 7, 28, 58, 651, DateTimeKind.Local).AddTicks(5161), 0, 77, 0 },
                    { 26, 910.89999999999998, new DateTime(2024, 12, 23, 6, 6, 7, 318, DateTimeKind.Local).AddTicks(9100), 0, 7, 0 },
                    { 27, 552.26999999999998, new DateTime(2024, 12, 25, 10, 11, 36, 551, DateTimeKind.Local).AddTicks(4767), 0, 75, 1 },
                    { 28, 534.41999999999996, new DateTime(2024, 12, 18, 9, 50, 8, 209, DateTimeKind.Local).AddTicks(6854), 1, 40, 0 },
                    { 29, 277.80000000000001, new DateTime(2024, 12, 4, 17, 59, 59, 25, DateTimeKind.Local).AddTicks(9477), 1, 94, 0 },
                    { 30, 479.62, new DateTime(2024, 11, 29, 2, 34, 29, 756, DateTimeKind.Local).AddTicks(3109), 1, 84, 1 },
                    { 31, 126.08, new DateTime(2024, 12, 1, 19, 19, 22, 97, DateTimeKind.Local).AddTicks(5351), 1, 88, 0 },
                    { 32, 349.52999999999997, new DateTime(2024, 12, 1, 21, 52, 5, 233, DateTimeKind.Local).AddTicks(6737), 1, 34, 1 },
                    { 33, 990.67999999999995, new DateTime(2024, 12, 6, 18, 42, 41, 866, DateTimeKind.Local).AddTicks(3315), 1, 56, 0 },
                    { 34, 777.96000000000004, new DateTime(2024, 12, 21, 21, 47, 53, 773, DateTimeKind.Local).AddTicks(3814), 1, 95, 0 },
                    { 35, 515.14999999999998, new DateTime(2024, 12, 14, 5, 18, 42, 723, DateTimeKind.Local).AddTicks(7721), 1, 53, 0 },
                    { 36, 416.97000000000003, new DateTime(2024, 12, 12, 15, 56, 45, 922, DateTimeKind.Local).AddTicks(9045), 1, 87, 1 },
                    { 37, 508.38999999999999, new DateTime(2024, 12, 1, 23, 37, 53, 794, DateTimeKind.Local).AddTicks(6786), 0, 37, 0 },
                    { 38, 422.73000000000002, new DateTime(2024, 12, 16, 6, 20, 54, 93, DateTimeKind.Local).AddTicks(2644), 1, 3, 0 },
                    { 39, 790.32000000000005, new DateTime(2024, 12, 8, 18, 20, 52, 965, DateTimeKind.Local).AddTicks(6155), 0, 97, 0 },
                    { 40, 812.63999999999999, new DateTime(2024, 12, 18, 7, 39, 31, 454, DateTimeKind.Local).AddTicks(4166), 0, 90, 1 },
                    { 41, 689.03999999999996, new DateTime(2024, 11, 27, 3, 40, 0, 359, DateTimeKind.Local).AddTicks(7136), 0, 26, 0 },
                    { 42, 288.19999999999999, new DateTime(2024, 12, 23, 0, 15, 17, 556, DateTimeKind.Local).AddTicks(7569), 0, 58, 0 },
                    { 43, 599.74000000000001, new DateTime(2024, 12, 6, 11, 25, 11, 547, DateTimeKind.Local).AddTicks(1327), 1, 63, 1 },
                    { 44, 786.26999999999998, new DateTime(2024, 12, 8, 4, 21, 12, 921, DateTimeKind.Local).AddTicks(1547), 1, 16, 0 },
                    { 45, 348.75, new DateTime(2024, 12, 13, 22, 7, 3, 955, DateTimeKind.Local).AddTicks(5027), 1, 41, 0 },
                    { 46, 228.59999999999999, new DateTime(2024, 11, 27, 6, 0, 19, 831, DateTimeKind.Local).AddTicks(4521), 0, 66, 0 },
                    { 47, 516.97000000000003, new DateTime(2024, 12, 11, 8, 24, 15, 438, DateTimeKind.Local).AddTicks(4452), 0, 43, 0 },
                    { 48, 539.26999999999998, new DateTime(2024, 12, 24, 19, 22, 26, 649, DateTimeKind.Local).AddTicks(6188), 1, 71, 1 },
                    { 49, 180.13999999999999, new DateTime(2024, 12, 3, 12, 6, 47, 7, DateTimeKind.Local).AddTicks(7724), 0, 91, 0 },
                    { 50, 325.33999999999997, new DateTime(2024, 11, 30, 20, 24, 43, 35, DateTimeKind.Local).AddTicks(8521), 0, 17, 1 },
                    { 51, 452.00999999999999, new DateTime(2024, 12, 9, 0, 2, 25, 249, DateTimeKind.Local).AddTicks(7869), 1, 41, 0 },
                    { 52, 241.58000000000001, new DateTime(2024, 12, 15, 2, 30, 44, 901, DateTimeKind.Local).AddTicks(1944), 1, 78, 1 },
                    { 53, 481.13999999999999, new DateTime(2024, 12, 15, 22, 53, 51, 250, DateTimeKind.Local).AddTicks(7289), 0, 15, 0 },
                    { 54, 94.680000000000007, new DateTime(2024, 12, 19, 18, 33, 37, 372, DateTimeKind.Local).AddTicks(2421), 0, 72, 0 },
                    { 55, 134.65000000000001, new DateTime(2024, 12, 14, 13, 52, 33, 267, DateTimeKind.Local).AddTicks(3048), 0, 87, 0 },
                    { 56, 164.78999999999999, new DateTime(2024, 12, 14, 4, 10, 55, 195, DateTimeKind.Local).AddTicks(8535), 0, 67, 0 },
                    { 57, 723.88999999999999, new DateTime(2024, 12, 20, 2, 31, 40, 947, DateTimeKind.Local).AddTicks(1524), 0, 7, 0 },
                    { 58, 208.94999999999999, new DateTime(2024, 12, 4, 12, 57, 25, 696, DateTimeKind.Local).AddTicks(1936), 1, 11, 1 },
                    { 59, 399.73000000000002, new DateTime(2024, 11, 29, 6, 29, 44, 89, DateTimeKind.Local).AddTicks(7669), 0, 79, 1 },
                    { 60, 565.70000000000005, new DateTime(2024, 12, 1, 5, 14, 10, 603, DateTimeKind.Local).AddTicks(5935), 1, 98, 0 },
                    { 61, 258.37, new DateTime(2024, 12, 20, 13, 27, 56, 757, DateTimeKind.Local).AddTicks(4808), 1, 65, 1 },
                    { 62, 554.54999999999995, new DateTime(2024, 12, 4, 12, 43, 27, 154, DateTimeKind.Local).AddTicks(1643), 0, 69, 0 },
                    { 63, 966.95000000000005, new DateTime(2024, 12, 11, 22, 41, 30, 939, DateTimeKind.Local).AddTicks(9102), 1, 4, 0 },
                    { 64, 985.30999999999995, new DateTime(2024, 12, 6, 2, 4, 16, 560, DateTimeKind.Local).AddTicks(5054), 0, 44, 0 },
                    { 65, 921.03999999999996, new DateTime(2024, 12, 24, 6, 44, 41, 450, DateTimeKind.Local).AddTicks(1106), 0, 31, 0 },
                    { 66, 966.24000000000001, new DateTime(2024, 12, 22, 22, 14, 19, 886, DateTimeKind.Local).AddTicks(3540), 1, 87, 1 },
                    { 67, 364.42000000000002, new DateTime(2024, 12, 4, 13, 11, 39, 764, DateTimeKind.Local).AddTicks(8902), 1, 75, 1 },
                    { 68, 843.11000000000001, new DateTime(2024, 12, 1, 10, 0, 49, 973, DateTimeKind.Local).AddTicks(5290), 1, 31, 1 },
                    { 69, 358.81999999999999, new DateTime(2024, 11, 29, 9, 51, 48, 944, DateTimeKind.Local).AddTicks(6160), 0, 9, 1 },
                    { 70, 525.76999999999998, new DateTime(2024, 12, 20, 7, 57, 37, 526, DateTimeKind.Local).AddTicks(1647), 0, 22, 1 },
                    { 71, 287.76999999999998, new DateTime(2024, 12, 1, 18, 4, 1, 192, DateTimeKind.Local).AddTicks(9165), 1, 47, 1 },
                    { 72, 512.64999999999998, new DateTime(2024, 12, 17, 8, 50, 4, 354, DateTimeKind.Local).AddTicks(1162), 0, 53, 1 },
                    { 73, 523.89999999999998, new DateTime(2024, 11, 25, 15, 17, 34, 173, DateTimeKind.Local).AddTicks(8734), 0, 4, 0 },
                    { 74, 676.40999999999997, new DateTime(2024, 12, 18, 14, 6, 32, 89, DateTimeKind.Local).AddTicks(2097), 1, 99, 0 },
                    { 75, 359.19999999999999, new DateTime(2024, 12, 7, 20, 49, 13, 869, DateTimeKind.Local).AddTicks(5368), 1, 94, 1 },
                    { 76, 692.62, new DateTime(2024, 12, 6, 14, 41, 14, 379, DateTimeKind.Local).AddTicks(8383), 0, 35, 0 },
                    { 77, 501.61000000000001, new DateTime(2024, 12, 2, 21, 52, 23, 276, DateTimeKind.Local).AddTicks(7410), 0, 74, 0 },
                    { 78, 894.34000000000003, new DateTime(2024, 12, 6, 3, 0, 18, 409, DateTimeKind.Local).AddTicks(2419), 1, 84, 0 },
                    { 79, 757.27999999999997, new DateTime(2024, 12, 20, 13, 9, 31, 687, DateTimeKind.Local).AddTicks(422), 0, 21, 1 },
                    { 80, 119.84999999999999, new DateTime(2024, 12, 3, 10, 26, 3, 406, DateTimeKind.Local).AddTicks(8883), 0, 78, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Payment_ReservationId",
                table: "Payment",
                column: "ReservationId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservation_RoomId",
                table: "Reservation",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservation_UserId",
                table: "Reservation",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_RoomTypeId",
                table: "Rooms",
                column: "RoomTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Payment");

            migrationBuilder.DropTable(
                name: "Reservation");

            migrationBuilder.DropTable(
                name: "Rooms");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "RoomType");
        }
    }
}
