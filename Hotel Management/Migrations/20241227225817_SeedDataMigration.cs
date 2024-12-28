using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Hotel_Management.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataMigration : Migration
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
                name: "Room",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Capacity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<double>(type: "double", nullable: false),
                    IsAvailable = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    RoomTypeId = table.Column<int>(type: "int", nullable: false),
                    ImagePath = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Room", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Room_RoomType_RoomTypeId",
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
                        name: "FK_Reservation_Room_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Room",
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
                    { 1, "admin@hotel.com", "admin", "admin", "$2a$11$6GpwJnkOKT76B1.3Dlk52uAyxsku3nnvm1MvjEutpraBnWASM8j8q", "0600000000", 0 },
                    { 2, "Jammie_Braun@yahoo.com", "Finn", "Hoppe", "$2a$11$ttlOBDXsjFUUPUjpVJraq.gEI/V0FQu1KnuPwfzJp5P9uoDtliM8W", "1-583-645-0208", 1 },
                    { 3, "Keira1@hotmail.com", "Paxton", "Osinski", "$2a$11$3UjAaF6rc0nabWT.9Gly2OF/DPdSJe/0HYKUMWAr36552txikUQ9W", "(307) 940-3476 x067", 1 },
                    { 4, "Ollie.Rogahn34@gmail.com", "Adrian", "Kub", "$2a$11$sPoGRs9zdxr66cqXQZq/fO3MLoAzrFIcR2fqbRU4dNtuA0ke0DuKy", "(861) 937-6673", 0 },
                    { 5, "Rex95@gmail.com", "Mafalda", "Baumbach", "$2a$11$VAR7LyyzZEh3XnTqxzMUQugtmzEp1BUrduX8PeaC3dR6DmREY7D.m", "1-725-952-1978 x0510", 1 },
                    { 6, "Jaida.Klein10@gmail.com", "Grace", "Price", "$2a$11$IYtCjTQ0pAFYpt94BMW8G.yIaS1MWFQYw/BJBcDOqaKZ/p3pJHdha", "625-685-3700 x17047", 1 },
                    { 7, "Rosalyn_Botsford10@yahoo.com", "Donnie", "Littel", "$2a$11$ORY0vUgPh6xq6R.fDVxBaOTzobydMOl6FB4H8O88huzIHsodsP5Ee", "214-706-5084 x031", 0 },
                    { 8, "Bernice.Murazik64@gmail.com", "Keenan", "Nikolaus", "$2a$11$0fqv20980hAl/uiXFdwT3OCDO3rgllOHdRxyVqbWBQ9cr4T9P5QCW", "(254) 271-0220 x5619", 1 },
                    { 9, "Jacques1@yahoo.com", "Libby", "Langworth", "$2a$11$PSVj7P90SIYJLxIi.pQD/u8CVHgNIfE40KPS7LoHedtje4suTr9We", "(846) 801-2582 x9655", 2 },
                    { 10, "Kiana_Cruickshank26@hotmail.com", "Lorena", "Miller", "$2a$11$myMm4lzabpYt/8I/z3ptdu5XnG7J2jJT/A1VE9MKwVCIuVYq6PpwC", "1-411-587-3765 x8135", 1 },
                    { 11, "Ezekiel_Nikolaus@yahoo.com", "Bernita", "Bruen", "$2a$11$pAektwjuj9hDLicaXbwT0.Lhm0p/CcCSdOEJ9k7OiIfmt5cJZdm9S", "1-208-357-3519 x5213", 2 },
                    { 12, "Daron_Gutmann10@gmail.com", "Wilfrid", "Koss", "$2a$11$ZKtf0vpyn4SGMM4H48a9HubHRIiy4heG4yJXDiIi35bUYMrfo9see", "(384) 265-2873 x6223", 0 },
                    { 13, "Ardella70@yahoo.com", "Maegan", "Murazik", "$2a$11$vi9HE3pCH/ctqa3Js1jRCujaUqXZ5Q6BANdYGuIh.dnFD7vEJ6pdO", "529-859-7414 x407", 1 },
                    { 14, "Dedric11@yahoo.com", "Sigrid", "Kertzmann", "$2a$11$17OTTsvDZm0j.7k6vV6nP.bxJw34UKgn9xA2KbE.e5KZOjh6FFm7q", "(631) 260-9406", 2 },
                    { 15, "Ulises87@gmail.com", "Scarlett", "Haley", "$2a$11$p2hVOLhw1Ab2hSPyIVe3U.F4m/77L0h54Wa1ObVOUATGoj1yTQYLe", "929-448-8168 x572", 2 },
                    { 16, "Ida0@gmail.com", "Elvis", "Parker", "$2a$11$ITHV2Kue3udz1MtRh9asaervjK/r3Ap.lnsJpkDoslOi/EUJFHytu", "323.254.0834 x6602", 2 },
                    { 17, "Kamille.Miller9@yahoo.com", "Onie", "Russel", "$2a$11$N/cgCPaXBjSTqQ6KyCb/muJ5DK3AY8r19YPGwNpblQOjAenhlqxTW", "(385) 991-5541", 2 },
                    { 18, "Cielo38@yahoo.com", "Tobin", "Purdy", "$2a$11$9qX0KehfZC87QKZ2VQP/cuMYoz77Bb0sTmVek1RfeNFELcdq6ld/e", "(593) 919-7415 x656", 2 },
                    { 19, "Brandyn58@yahoo.com", "Aidan", "Dietrich", "$2a$11$LbLMM7ZoXKy5jexvbI28cO.TVuQWuQ1ya2ludrzRKhg/SSJpf5rbm", "933.761.9339 x01211", 1 },
                    { 20, "Kay.Goldner14@yahoo.com", "Joanny", "Hickle", "$2a$11$/zgmGON9H9AGQcIsl1vPiOIuz7qEuIOPe1GsN3aqnKrOkEfJNmVzq", "(267) 455-7003", 2 },
                    { 21, "Diana.Nikolaus94@yahoo.com", "Myrtis", "Botsford", "$2a$11$Sq/EH.MAgflBsDiq17AKIOFyeoZ4TGqVT20T4BubOcqevi7nYFo5a", "1-755-423-7031 x13407", 2 },
                    { 22, "Jeffry_Koepp97@yahoo.com", "Shaylee", "Quitzon", "$2a$11$JJwvR.zDOB1ucu2e3/Tguelh2c9B51QTtU5bBnUO8PE5SCsTUaRMu", "213-467-7815", 0 },
                    { 23, "Connie_Marks@gmail.com", "Alisha", "Morar", "$2a$11$E4Dis.OE9zi9klHIdky.z.tGPImucm5/w31Qg6i03elIn4a0ndAHe", "378-946-6856 x3495", 1 },
                    { 24, "Tyrique0@yahoo.com", "Jan", "Larkin", "$2a$11$ZZwtk9s1BRdD3IPBOiCfMO8DTmDUB7xOp8rcqCCvKhY2SPiJPW4yy", "519.443.9630 x4510", 2 },
                    { 25, "Burley_Streich@gmail.com", "Rafaela", "Bayer", "$2a$11$rxc3XGpX7hwDeiBRA0RcMeXVL3nolTa0r4kO6QWz12BJrbirhKiZy", "504.502.3930", 2 },
                    { 26, "Roderick_Padberg@yahoo.com", "Bradley", "Cassin", "$2a$11$KOy9qtsGaNfLK3aOUY33dOPsmaamFh8MxL4fkcRxPKxCBfQ2AYofm", "931.309.1319", 2 }
                });

            migrationBuilder.InsertData(
                table: "Room",
                columns: new[] { "Id", "Capacity", "ImagePath", "IsAvailable", "Name", "Price", "RoomTypeId" },
                values: new object[,]
                {
                    { 1, 1, "Assets/coming-soon-photo.png", false, "Room 124", 934.0, 1 },
                    { 2, 4, "Assets/coming-soon-photo.png", false, "Room 156", 704.0, 1 },
                    { 3, 1, "Assets/coming-soon-photo.png", true, "Room 104", 894.0, 2 },
                    { 4, 4, "Assets/coming-soon-photo.png", false, "Room 245", 923.0, 2 },
                    { 5, 10, "Assets/coming-soon-photo.png", false, "Room 418", 482.0, 1 },
                    { 6, 3, "Assets/coming-soon-photo.png", true, "Room 358", 144.0, 2 },
                    { 7, 10, "Assets/coming-soon-photo.png", false, "Room 495", 148.0, 2 },
                    { 8, 2, "Assets/coming-soon-photo.png", false, "Room 308", 419.0, 2 },
                    { 9, 9, "Assets/coming-soon-photo.png", false, "Room 299", 181.0, 3 },
                    { 10, 2, "Assets/coming-soon-photo.png", true, "Room 116", 306.0, 2 },
                    { 11, 10, "Assets/coming-soon-photo.png", false, "Room 162", 525.0, 2 },
                    { 12, 2, "Assets/coming-soon-photo.png", false, "Room 111", 70.0, 2 },
                    { 13, 1, "Assets/coming-soon-photo.png", true, "Room 210", 792.0, 1 },
                    { 14, 5, "Assets/coming-soon-photo.png", true, "Room 152", 293.0, 2 },
                    { 15, 7, "Assets/coming-soon-photo.png", false, "Room 213", 433.0, 1 },
                    { 16, 6, "Assets/coming-soon-photo.png", false, "Room 473", 72.0, 1 },
                    { 17, 6, "Assets/coming-soon-photo.png", false, "Room 232", 247.0, 2 },
                    { 18, 2, "Assets/coming-soon-photo.png", false, "Room 287", 712.0, 3 },
                    { 19, 5, "Assets/coming-soon-photo.png", false, "Room 329", 885.0, 2 },
                    { 20, 7, "Assets/coming-soon-photo.png", false, "Room 388", 755.0, 2 },
                    { 21, 2, "Assets/coming-soon-photo.png", true, "Room 281", 161.0, 1 },
                    { 22, 4, "Assets/coming-soon-photo.png", false, "Room 282", 501.0, 1 },
                    { 23, 10, "Assets/coming-soon-photo.png", false, "Room 284", 542.0, 3 },
                    { 24, 5, "Assets/coming-soon-photo.png", false, "Room 146", 112.0, 1 },
                    { 25, 4, "Assets/coming-soon-photo.png", true, "Room 352", 359.0, 1 },
                    { 26, 8, "Assets/coming-soon-photo.png", false, "Room 413", 783.0, 1 },
                    { 27, 1, "Assets/coming-soon-photo.png", false, "Room 334", 391.0, 1 },
                    { 28, 5, "Assets/coming-soon-photo.png", false, "Room 140", 321.0, 1 },
                    { 29, 7, "Assets/coming-soon-photo.png", true, "Room 159", 341.0, 3 },
                    { 30, 7, "Assets/coming-soon-photo.png", false, "Room 205", 317.0, 2 },
                    { 31, 1, "Assets/coming-soon-photo.png", false, "Room 113", 767.0, 1 },
                    { 32, 4, "Assets/coming-soon-photo.png", false, "Room 438", 217.0, 3 },
                    { 33, 10, "Assets/coming-soon-photo.png", false, "Room 133", 426.0, 3 },
                    { 34, 8, "Assets/coming-soon-photo.png", false, "Room 378", 261.0, 1 },
                    { 35, 4, "Assets/coming-soon-photo.png", true, "Room 249", 705.0, 1 },
                    { 36, 9, "Assets/coming-soon-photo.png", true, "Room 279", 611.0, 2 },
                    { 37, 1, "Assets/coming-soon-photo.png", true, "Room 419", 228.0, 1 },
                    { 38, 5, "Assets/coming-soon-photo.png", true, "Room 276", 732.0, 2 },
                    { 39, 6, "Assets/coming-soon-photo.png", true, "Room 437", 825.0, 3 },
                    { 40, 4, "Assets/coming-soon-photo.png", true, "Room 302", 290.0, 1 },
                    { 41, 10, "Assets/coming-soon-photo.png", true, "Room 179", 958.0, 1 },
                    { 42, 8, "Assets/coming-soon-photo.png", false, "Room 163", 563.0, 1 },
                    { 43, 1, "Assets/coming-soon-photo.png", false, "Room 500", 987.0, 1 },
                    { 44, 10, "Assets/coming-soon-photo.png", true, "Room 239", 280.0, 2 },
                    { 45, 6, "Assets/coming-soon-photo.png", false, "Room 310", 791.0, 3 },
                    { 46, 3, "Assets/coming-soon-photo.png", false, "Room 486", 815.0, 2 },
                    { 47, 4, "Assets/coming-soon-photo.png", false, "Room 456", 594.0, 1 },
                    { 48, 5, "Assets/coming-soon-photo.png", false, "Room 102", 894.0, 1 },
                    { 49, 2, "Assets/coming-soon-photo.png", false, "Room 213", 84.0, 2 },
                    { 50, 5, "Assets/coming-soon-photo.png", true, "Room 165", 249.0, 3 }
                });

            migrationBuilder.InsertData(
                table: "Reservation",
                columns: new[] { "Id", "CheckInDate", "CheckOutDate", "RoomId", "Status", "TotalPrice", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 1, 9, 13, 12, 48, 972, DateTimeKind.Local).AddTicks(3132), new DateTime(2025, 1, 10, 13, 12, 48, 972, DateTimeKind.Local).AddTicks(3132), 24, 0, 3715.0, 1 },
                    { 2, new DateTime(2024, 12, 25, 6, 6, 48, 323, DateTimeKind.Local).AddTicks(1541), new DateTime(2024, 12, 28, 6, 6, 48, 323, DateTimeKind.Local).AddTicks(1541), 9, 0, 940.0, 10 },
                    { 3, new DateTime(2024, 12, 11, 18, 41, 51, 440, DateTimeKind.Local).AddTicks(8409), new DateTime(2024, 12, 16, 18, 41, 51, 440, DateTimeKind.Local).AddTicks(8409), 24, 1, 1212.0, 2 },
                    { 4, new DateTime(2024, 12, 14, 22, 59, 26, 645, DateTimeKind.Local).AddTicks(3823), new DateTime(2024, 12, 17, 22, 59, 26, 645, DateTimeKind.Local).AddTicks(3823), 8, 2, 2748.0, 1 },
                    { 5, new DateTime(2025, 1, 25, 5, 14, 20, 15, DateTimeKind.Local).AddTicks(1777), new DateTime(2025, 2, 2, 5, 14, 20, 15, DateTimeKind.Local).AddTicks(1777), 38, 2, 2675.0, 2 },
                    { 6, new DateTime(2024, 12, 13, 0, 13, 22, 302, DateTimeKind.Local).AddTicks(727), new DateTime(2024, 12, 14, 0, 13, 22, 302, DateTimeKind.Local).AddTicks(727), 3, 0, 4321.0, 8 },
                    { 7, new DateTime(2024, 12, 12, 16, 33, 43, 245, DateTimeKind.Local).AddTicks(529), new DateTime(2024, 12, 20, 16, 33, 43, 245, DateTimeKind.Local).AddTicks(529), 8, 0, 1767.0, 5 },
                    { 8, new DateTime(2025, 1, 25, 14, 8, 59, 994, DateTimeKind.Local).AddTicks(5617), new DateTime(2025, 2, 1, 14, 8, 59, 994, DateTimeKind.Local).AddTicks(5617), 12, 0, 4605.0, 4 },
                    { 9, new DateTime(2024, 12, 8, 6, 11, 27, 630, DateTimeKind.Local).AddTicks(6328), new DateTime(2024, 12, 10, 6, 11, 27, 630, DateTimeKind.Local).AddTicks(6328), 46, 0, 2415.0, 10 },
                    { 10, new DateTime(2024, 12, 11, 6, 52, 56, 729, DateTimeKind.Local).AddTicks(473), new DateTime(2024, 12, 16, 6, 52, 56, 729, DateTimeKind.Local).AddTicks(473), 37, 0, 2072.0, 7 },
                    { 11, new DateTime(2024, 12, 20, 7, 35, 10, 378, DateTimeKind.Local).AddTicks(1435), new DateTime(2024, 12, 28, 7, 35, 10, 378, DateTimeKind.Local).AddTicks(1435), 37, 0, 3103.0, 3 },
                    { 12, new DateTime(2024, 12, 1, 5, 0, 21, 900, DateTimeKind.Local).AddTicks(7722), new DateTime(2024, 12, 6, 5, 0, 21, 900, DateTimeKind.Local).AddTicks(7722), 42, 2, 2942.0, 6 },
                    { 13, new DateTime(2024, 12, 19, 8, 21, 37, 686, DateTimeKind.Local).AddTicks(519), new DateTime(2024, 12, 22, 8, 21, 37, 686, DateTimeKind.Local).AddTicks(519), 5, 1, 4636.0, 6 },
                    { 14, new DateTime(2024, 12, 5, 18, 21, 27, 904, DateTimeKind.Local).AddTicks(6656), new DateTime(2024, 12, 15, 18, 21, 27, 904, DateTimeKind.Local).AddTicks(6656), 9, 2, 1808.0, 9 },
                    { 15, new DateTime(2024, 12, 9, 7, 18, 14, 828, DateTimeKind.Local).AddTicks(8949), new DateTime(2024, 12, 12, 7, 18, 14, 828, DateTimeKind.Local).AddTicks(8949), 42, 0, 619.0, 10 },
                    { 16, new DateTime(2025, 1, 20, 0, 14, 42, 941, DateTimeKind.Local).AddTicks(7367), new DateTime(2025, 1, 25, 0, 14, 42, 941, DateTimeKind.Local).AddTicks(7367), 18, 2, 544.0, 2 },
                    { 17, new DateTime(2024, 12, 10, 14, 44, 7, 105, DateTimeKind.Local).AddTicks(6877), new DateTime(2024, 12, 16, 14, 44, 7, 105, DateTimeKind.Local).AddTicks(6877), 25, 1, 2108.0, 4 },
                    { 18, new DateTime(2025, 1, 11, 19, 2, 18, 139, DateTimeKind.Local).AddTicks(1560), new DateTime(2025, 1, 21, 19, 2, 18, 139, DateTimeKind.Local).AddTicks(1560), 40, 1, 3104.0, 3 },
                    { 19, new DateTime(2025, 1, 24, 19, 19, 6, 844, DateTimeKind.Local).AddTicks(2640), new DateTime(2025, 1, 27, 19, 19, 6, 844, DateTimeKind.Local).AddTicks(2640), 21, 2, 532.0, 9 },
                    { 20, new DateTime(2024, 12, 21, 15, 28, 33, 28, DateTimeKind.Local).AddTicks(9752), new DateTime(2024, 12, 30, 15, 28, 33, 28, DateTimeKind.Local).AddTicks(9752), 15, 1, 470.0, 7 },
                    { 21, new DateTime(2025, 1, 3, 0, 3, 40, 404, DateTimeKind.Local).AddTicks(3895), new DateTime(2025, 1, 13, 0, 3, 40, 404, DateTimeKind.Local).AddTicks(3895), 9, 2, 1013.0, 3 },
                    { 22, new DateTime(2024, 12, 25, 1, 23, 33, 519, DateTimeKind.Local).AddTicks(2258), new DateTime(2024, 12, 26, 1, 23, 33, 519, DateTimeKind.Local).AddTicks(2258), 48, 0, 1493.0, 9 },
                    { 23, new DateTime(2024, 12, 22, 19, 54, 5, 241, DateTimeKind.Local).AddTicks(6847), new DateTime(2025, 1, 1, 19, 54, 5, 241, DateTimeKind.Local).AddTicks(6847), 9, 2, 2853.0, 3 },
                    { 24, new DateTime(2024, 12, 12, 9, 35, 56, 364, DateTimeKind.Local).AddTicks(1437), new DateTime(2024, 12, 16, 9, 35, 56, 364, DateTimeKind.Local).AddTicks(1437), 36, 2, 3675.0, 5 },
                    { 25, new DateTime(2025, 1, 17, 5, 56, 41, 511, DateTimeKind.Local).AddTicks(4151), new DateTime(2025, 1, 18, 5, 56, 41, 511, DateTimeKind.Local).AddTicks(4151), 48, 0, 2552.0, 9 },
                    { 26, new DateTime(2025, 1, 13, 22, 16, 34, 93, DateTimeKind.Local).AddTicks(384), new DateTime(2025, 1, 22, 22, 16, 34, 93, DateTimeKind.Local).AddTicks(384), 48, 2, 1825.0, 7 },
                    { 27, new DateTime(2024, 12, 10, 13, 40, 25, 908, DateTimeKind.Local).AddTicks(199), new DateTime(2024, 12, 14, 13, 40, 25, 908, DateTimeKind.Local).AddTicks(199), 9, 2, 4146.0, 6 },
                    { 28, new DateTime(2024, 12, 17, 0, 15, 54, 491, DateTimeKind.Local).AddTicks(9129), new DateTime(2024, 12, 20, 0, 15, 54, 491, DateTimeKind.Local).AddTicks(9129), 35, 1, 4251.0, 8 },
                    { 29, new DateTime(2024, 12, 28, 2, 17, 7, 908, DateTimeKind.Local).AddTicks(4081), new DateTime(2025, 1, 5, 2, 17, 7, 908, DateTimeKind.Local).AddTicks(4081), 30, 1, 790.0, 5 },
                    { 30, new DateTime(2024, 12, 14, 23, 12, 28, 164, DateTimeKind.Local).AddTicks(8444), new DateTime(2024, 12, 20, 23, 12, 28, 164, DateTimeKind.Local).AddTicks(8444), 27, 1, 2201.0, 8 },
                    { 31, new DateTime(2025, 1, 6, 0, 16, 30, 165, DateTimeKind.Local).AddTicks(2529), new DateTime(2025, 1, 8, 0, 16, 30, 165, DateTimeKind.Local).AddTicks(2529), 12, 2, 4449.0, 10 },
                    { 32, new DateTime(2024, 12, 31, 21, 20, 58, 491, DateTimeKind.Local).AddTicks(7896), new DateTime(2025, 1, 5, 21, 20, 58, 491, DateTimeKind.Local).AddTicks(7896), 40, 2, 3216.0, 6 },
                    { 33, new DateTime(2025, 1, 16, 19, 14, 41, 198, DateTimeKind.Local).AddTicks(8711), new DateTime(2025, 1, 22, 19, 14, 41, 198, DateTimeKind.Local).AddTicks(8711), 13, 0, 4368.0, 6 },
                    { 34, new DateTime(2024, 12, 10, 1, 28, 35, 904, DateTimeKind.Local).AddTicks(5790), new DateTime(2024, 12, 20, 1, 28, 35, 904, DateTimeKind.Local).AddTicks(5790), 18, 2, 3723.0, 10 },
                    { 35, new DateTime(2024, 12, 7, 20, 4, 38, 370, DateTimeKind.Local).AddTicks(6030), new DateTime(2024, 12, 9, 20, 4, 38, 370, DateTimeKind.Local).AddTicks(6030), 10, 2, 2835.0, 8 },
                    { 36, new DateTime(2025, 1, 17, 0, 59, 30, 286, DateTimeKind.Local).AddTicks(693), new DateTime(2025, 1, 27, 0, 59, 30, 286, DateTimeKind.Local).AddTicks(693), 30, 2, 1654.0, 1 },
                    { 37, new DateTime(2024, 12, 21, 8, 1, 48, 983, DateTimeKind.Local).AddTicks(2303), new DateTime(2024, 12, 25, 8, 1, 48, 983, DateTimeKind.Local).AddTicks(2303), 7, 2, 4391.0, 2 },
                    { 38, new DateTime(2025, 1, 13, 10, 23, 26, 171, DateTimeKind.Local).AddTicks(7801), new DateTime(2025, 1, 16, 10, 23, 26, 171, DateTimeKind.Local).AddTicks(7801), 4, 0, 3853.0, 5 },
                    { 39, new DateTime(2025, 1, 2, 22, 28, 57, 504, DateTimeKind.Local).AddTicks(5713), new DateTime(2025, 1, 5, 22, 28, 57, 504, DateTimeKind.Local).AddTicks(5713), 45, 1, 1060.0, 1 },
                    { 40, new DateTime(2025, 1, 11, 23, 1, 33, 779, DateTimeKind.Local).AddTicks(369), new DateTime(2025, 1, 21, 23, 1, 33, 779, DateTimeKind.Local).AddTicks(369), 19, 2, 3191.0, 9 },
                    { 41, new DateTime(2024, 12, 4, 13, 42, 48, 102, DateTimeKind.Local).AddTicks(7445), new DateTime(2024, 12, 9, 13, 42, 48, 102, DateTimeKind.Local).AddTicks(7445), 8, 2, 2059.0, 2 },
                    { 42, new DateTime(2025, 1, 6, 7, 0, 43, 875, DateTimeKind.Local).AddTicks(8972), new DateTime(2025, 1, 10, 7, 0, 43, 875, DateTimeKind.Local).AddTicks(8972), 18, 1, 540.0, 8 },
                    { 43, new DateTime(2025, 1, 14, 13, 47, 1, 512, DateTimeKind.Local).AddTicks(361), new DateTime(2025, 1, 15, 13, 47, 1, 512, DateTimeKind.Local).AddTicks(361), 36, 2, 1731.0, 5 },
                    { 44, new DateTime(2024, 12, 30, 14, 36, 3, 819, DateTimeKind.Local).AddTicks(653), new DateTime(2025, 1, 6, 14, 36, 3, 819, DateTimeKind.Local).AddTicks(653), 14, 2, 1286.0, 5 },
                    { 45, new DateTime(2024, 12, 19, 17, 6, 44, 923, DateTimeKind.Local).AddTicks(6199), new DateTime(2024, 12, 26, 17, 6, 44, 923, DateTimeKind.Local).AddTicks(6199), 42, 0, 3512.0, 2 },
                    { 46, new DateTime(2024, 12, 19, 15, 59, 47, 502, DateTimeKind.Local).AddTicks(4580), new DateTime(2024, 12, 26, 15, 59, 47, 502, DateTimeKind.Local).AddTicks(4580), 34, 2, 2666.0, 3 },
                    { 47, new DateTime(2024, 11, 30, 19, 2, 5, 77, DateTimeKind.Local).AddTicks(2548), new DateTime(2024, 12, 5, 19, 2, 5, 77, DateTimeKind.Local).AddTicks(2548), 23, 1, 3546.0, 10 },
                    { 48, new DateTime(2024, 12, 22, 3, 48, 39, 817, DateTimeKind.Local).AddTicks(5962), new DateTime(2024, 12, 31, 3, 48, 39, 817, DateTimeKind.Local).AddTicks(5962), 39, 2, 2331.0, 5 },
                    { 49, new DateTime(2024, 12, 26, 19, 21, 17, 590, DateTimeKind.Local).AddTicks(8417), new DateTime(2025, 1, 3, 19, 21, 17, 590, DateTimeKind.Local).AddTicks(8417), 9, 2, 4839.0, 6 },
                    { 50, new DateTime(2024, 12, 12, 11, 18, 47, 337, DateTimeKind.Local).AddTicks(7741), new DateTime(2024, 12, 22, 11, 18, 47, 337, DateTimeKind.Local).AddTicks(7741), 50, 0, 3876.0, 1 },
                    { 51, new DateTime(2025, 1, 19, 1, 17, 26, 833, DateTimeKind.Local).AddTicks(8784), new DateTime(2025, 1, 20, 1, 17, 26, 833, DateTimeKind.Local).AddTicks(8784), 40, 1, 3066.0, 4 },
                    { 52, new DateTime(2025, 1, 7, 10, 3, 20, 655, DateTimeKind.Local).AddTicks(9865), new DateTime(2025, 1, 12, 10, 3, 20, 655, DateTimeKind.Local).AddTicks(9865), 40, 2, 3483.0, 2 },
                    { 53, new DateTime(2024, 12, 15, 7, 30, 18, 352, DateTimeKind.Local).AddTicks(6417), new DateTime(2024, 12, 22, 7, 30, 18, 352, DateTimeKind.Local).AddTicks(6417), 34, 1, 3529.0, 9 },
                    { 54, new DateTime(2025, 1, 16, 6, 58, 30, 719, DateTimeKind.Local).AddTicks(49), new DateTime(2025, 1, 20, 6, 58, 30, 719, DateTimeKind.Local).AddTicks(49), 44, 1, 3627.0, 1 },
                    { 55, new DateTime(2024, 12, 31, 22, 27, 55, 104, DateTimeKind.Local).AddTicks(3132), new DateTime(2025, 1, 8, 22, 27, 55, 104, DateTimeKind.Local).AddTicks(3132), 20, 2, 2089.0, 5 },
                    { 56, new DateTime(2025, 1, 9, 5, 12, 45, 853, DateTimeKind.Local).AddTicks(1633), new DateTime(2025, 1, 10, 5, 12, 45, 853, DateTimeKind.Local).AddTicks(1633), 46, 1, 931.0, 10 },
                    { 57, new DateTime(2024, 12, 20, 13, 21, 59, 442, DateTimeKind.Local).AddTicks(5415), new DateTime(2024, 12, 23, 13, 21, 59, 442, DateTimeKind.Local).AddTicks(5415), 48, 2, 3427.0, 1 },
                    { 58, new DateTime(2024, 12, 6, 5, 18, 32, 950, DateTimeKind.Local).AddTicks(3892), new DateTime(2024, 12, 7, 5, 18, 32, 950, DateTimeKind.Local).AddTicks(3892), 48, 2, 1546.0, 9 },
                    { 59, new DateTime(2024, 12, 19, 18, 30, 59, 382, DateTimeKind.Local).AddTicks(5423), new DateTime(2024, 12, 23, 18, 30, 59, 382, DateTimeKind.Local).AddTicks(5423), 33, 0, 697.0, 2 },
                    { 60, new DateTime(2025, 1, 12, 12, 0, 21, 386, DateTimeKind.Local).AddTicks(4198), new DateTime(2025, 1, 15, 12, 0, 21, 386, DateTimeKind.Local).AddTicks(4198), 15, 2, 4228.0, 7 },
                    { 61, new DateTime(2025, 1, 18, 9, 48, 52, 776, DateTimeKind.Local).AddTicks(4517), new DateTime(2025, 1, 23, 9, 48, 52, 776, DateTimeKind.Local).AddTicks(4517), 16, 1, 1336.0, 5 },
                    { 62, new DateTime(2024, 12, 8, 6, 3, 4, 548, DateTimeKind.Local).AddTicks(8552), new DateTime(2024, 12, 10, 6, 3, 4, 548, DateTimeKind.Local).AddTicks(8552), 34, 0, 643.0, 4 },
                    { 63, new DateTime(2024, 12, 24, 7, 57, 46, 256, DateTimeKind.Local).AddTicks(4485), new DateTime(2024, 12, 25, 7, 57, 46, 256, DateTimeKind.Local).AddTicks(4485), 6, 2, 3475.0, 6 },
                    { 64, new DateTime(2025, 1, 18, 20, 8, 9, 187, DateTimeKind.Local).AddTicks(1235), new DateTime(2025, 1, 23, 20, 8, 9, 187, DateTimeKind.Local).AddTicks(1235), 23, 0, 169.0, 9 },
                    { 65, new DateTime(2025, 1, 4, 6, 26, 7, 171, DateTimeKind.Local).AddTicks(9460), new DateTime(2025, 1, 13, 6, 26, 7, 171, DateTimeKind.Local).AddTicks(9460), 41, 2, 1510.0, 7 },
                    { 66, new DateTime(2024, 12, 15, 12, 24, 4, 918, DateTimeKind.Local).AddTicks(8641), new DateTime(2024, 12, 16, 12, 24, 4, 918, DateTimeKind.Local).AddTicks(8641), 7, 2, 3580.0, 5 },
                    { 67, new DateTime(2024, 12, 6, 15, 11, 21, 345, DateTimeKind.Local).AddTicks(9801), new DateTime(2024, 12, 13, 15, 11, 21, 345, DateTimeKind.Local).AddTicks(9801), 42, 0, 3597.0, 10 },
                    { 68, new DateTime(2024, 12, 15, 14, 26, 36, 248, DateTimeKind.Local).AddTicks(9769), new DateTime(2024, 12, 17, 14, 26, 36, 248, DateTimeKind.Local).AddTicks(9769), 19, 1, 3418.0, 8 },
                    { 69, new DateTime(2024, 12, 17, 12, 33, 56, 125, DateTimeKind.Local).AddTicks(140), new DateTime(2024, 12, 24, 12, 33, 56, 125, DateTimeKind.Local).AddTicks(140), 23, 0, 3228.0, 8 },
                    { 70, new DateTime(2025, 1, 5, 1, 27, 20, 544, DateTimeKind.Local).AddTicks(2010), new DateTime(2025, 1, 7, 1, 27, 20, 544, DateTimeKind.Local).AddTicks(2010), 25, 2, 3086.0, 9 },
                    { 71, new DateTime(2024, 12, 9, 12, 43, 15, 974, DateTimeKind.Local).AddTicks(7828), new DateTime(2024, 12, 17, 12, 43, 15, 974, DateTimeKind.Local).AddTicks(7828), 28, 1, 4920.0, 3 },
                    { 72, new DateTime(2024, 12, 8, 8, 24, 44, 399, DateTimeKind.Local).AddTicks(8314), new DateTime(2024, 12, 10, 8, 24, 44, 399, DateTimeKind.Local).AddTicks(8314), 8, 1, 2532.0, 1 },
                    { 73, new DateTime(2025, 1, 17, 2, 41, 59, 153, DateTimeKind.Local).AddTicks(4301), new DateTime(2025, 1, 26, 2, 41, 59, 153, DateTimeKind.Local).AddTicks(4301), 10, 2, 4684.0, 5 },
                    { 74, new DateTime(2024, 12, 21, 20, 1, 27, 265, DateTimeKind.Local).AddTicks(2234), new DateTime(2024, 12, 26, 20, 1, 27, 265, DateTimeKind.Local).AddTicks(2234), 4, 2, 3677.0, 7 },
                    { 75, new DateTime(2024, 12, 17, 11, 46, 43, 964, DateTimeKind.Local).AddTicks(3731), new DateTime(2024, 12, 26, 11, 46, 43, 964, DateTimeKind.Local).AddTicks(3731), 34, 0, 1136.0, 10 },
                    { 76, new DateTime(2024, 12, 4, 0, 37, 56, 116, DateTimeKind.Local).AddTicks(496), new DateTime(2024, 12, 11, 0, 37, 56, 116, DateTimeKind.Local).AddTicks(496), 22, 2, 753.0, 9 },
                    { 77, new DateTime(2025, 1, 3, 21, 50, 45, 52, DateTimeKind.Local).AddTicks(9967), new DateTime(2025, 1, 11, 21, 50, 45, 52, DateTimeKind.Local).AddTicks(9967), 22, 2, 4872.0, 3 },
                    { 78, new DateTime(2025, 1, 19, 5, 45, 43, 616, DateTimeKind.Local).AddTicks(4994), new DateTime(2025, 1, 23, 5, 45, 43, 616, DateTimeKind.Local).AddTicks(4994), 18, 2, 2350.0, 3 },
                    { 79, new DateTime(2024, 12, 11, 21, 16, 21, 998, DateTimeKind.Local).AddTicks(5968), new DateTime(2024, 12, 14, 21, 16, 21, 998, DateTimeKind.Local).AddTicks(5968), 42, 0, 3502.0, 7 },
                    { 80, new DateTime(2024, 11, 28, 10, 25, 49, 415, DateTimeKind.Local).AddTicks(9312), new DateTime(2024, 12, 6, 10, 25, 49, 415, DateTimeKind.Local).AddTicks(9312), 45, 1, 3817.0, 1 },
                    { 81, new DateTime(2024, 12, 17, 10, 40, 25, 874, DateTimeKind.Local).AddTicks(2389), new DateTime(2024, 12, 25, 10, 40, 25, 874, DateTimeKind.Local).AddTicks(2389), 35, 0, 800.0, 1 },
                    { 82, new DateTime(2025, 1, 18, 8, 51, 42, 133, DateTimeKind.Local).AddTicks(1617), new DateTime(2025, 1, 19, 8, 51, 42, 133, DateTimeKind.Local).AddTicks(1617), 8, 1, 1723.0, 5 },
                    { 83, new DateTime(2024, 12, 20, 13, 18, 27, 380, DateTimeKind.Local).AddTicks(8392), new DateTime(2024, 12, 28, 13, 18, 27, 380, DateTimeKind.Local).AddTicks(8392), 38, 1, 4035.0, 3 },
                    { 84, new DateTime(2025, 1, 26, 1, 1, 14, 956, DateTimeKind.Local).AddTicks(9566), new DateTime(2025, 1, 28, 1, 1, 14, 956, DateTimeKind.Local).AddTicks(9566), 5, 0, 3485.0, 10 },
                    { 85, new DateTime(2024, 12, 28, 17, 58, 24, 719, DateTimeKind.Local).AddTicks(1984), new DateTime(2025, 1, 6, 17, 58, 24, 719, DateTimeKind.Local).AddTicks(1984), 21, 2, 1720.0, 7 },
                    { 86, new DateTime(2024, 11, 30, 10, 26, 5, 870, DateTimeKind.Local).AddTicks(5126), new DateTime(2024, 12, 5, 10, 26, 5, 870, DateTimeKind.Local).AddTicks(5126), 28, 1, 4982.0, 1 },
                    { 87, new DateTime(2024, 12, 3, 15, 6, 20, 449, DateTimeKind.Local).AddTicks(947), new DateTime(2024, 12, 13, 15, 6, 20, 449, DateTimeKind.Local).AddTicks(947), 24, 1, 2478.0, 10 },
                    { 88, new DateTime(2024, 12, 18, 14, 24, 3, 268, DateTimeKind.Local).AddTicks(6112), new DateTime(2024, 12, 28, 14, 24, 3, 268, DateTimeKind.Local).AddTicks(6112), 15, 2, 3470.0, 7 },
                    { 89, new DateTime(2025, 1, 2, 9, 13, 32, 450, DateTimeKind.Local).AddTicks(6210), new DateTime(2025, 1, 10, 9, 13, 32, 450, DateTimeKind.Local).AddTicks(6210), 4, 2, 4692.0, 4 },
                    { 90, new DateTime(2024, 12, 19, 15, 55, 12, 527, DateTimeKind.Local).AddTicks(7503), new DateTime(2024, 12, 25, 15, 55, 12, 527, DateTimeKind.Local).AddTicks(7503), 14, 0, 4445.0, 1 },
                    { 91, new DateTime(2024, 12, 13, 10, 33, 44, 663, DateTimeKind.Local).AddTicks(3673), new DateTime(2024, 12, 14, 10, 33, 44, 663, DateTimeKind.Local).AddTicks(3673), 5, 1, 1934.0, 6 },
                    { 92, new DateTime(2024, 12, 5, 6, 45, 28, 357, DateTimeKind.Local).AddTicks(3335), new DateTime(2024, 12, 6, 6, 45, 28, 357, DateTimeKind.Local).AddTicks(3335), 28, 2, 314.0, 5 },
                    { 93, new DateTime(2025, 1, 8, 10, 17, 45, 51, DateTimeKind.Local).AddTicks(6869), new DateTime(2025, 1, 12, 10, 17, 45, 51, DateTimeKind.Local).AddTicks(6869), 8, 0, 2973.0, 8 },
                    { 94, new DateTime(2024, 12, 4, 16, 52, 10, 82, DateTimeKind.Local).AddTicks(7328), new DateTime(2024, 12, 9, 16, 52, 10, 82, DateTimeKind.Local).AddTicks(7328), 14, 1, 1998.0, 2 },
                    { 95, new DateTime(2025, 1, 7, 9, 17, 5, 521, DateTimeKind.Local).AddTicks(2085), new DateTime(2025, 1, 16, 9, 17, 5, 521, DateTimeKind.Local).AddTicks(2085), 11, 1, 3600.0, 5 },
                    { 96, new DateTime(2024, 12, 23, 19, 40, 1, 29, DateTimeKind.Local).AddTicks(2310), new DateTime(2024, 12, 26, 19, 40, 1, 29, DateTimeKind.Local).AddTicks(2310), 27, 0, 4629.0, 4 },
                    { 97, new DateTime(2025, 1, 25, 11, 54, 15, 822, DateTimeKind.Local).AddTicks(6071), new DateTime(2025, 2, 2, 11, 54, 15, 822, DateTimeKind.Local).AddTicks(6071), 49, 0, 1759.0, 7 },
                    { 98, new DateTime(2024, 12, 22, 21, 8, 50, 560, DateTimeKind.Local).AddTicks(2880), new DateTime(2024, 12, 30, 21, 8, 50, 560, DateTimeKind.Local).AddTicks(2880), 48, 0, 4781.0, 6 },
                    { 99, new DateTime(2024, 12, 8, 21, 37, 1, 595, DateTimeKind.Local).AddTicks(454), new DateTime(2024, 12, 10, 21, 37, 1, 595, DateTimeKind.Local).AddTicks(454), 49, 2, 3153.0, 10 },
                    { 100, new DateTime(2025, 1, 24, 5, 46, 49, 769, DateTimeKind.Local).AddTicks(4363), new DateTime(2025, 1, 29, 5, 46, 49, 769, DateTimeKind.Local).AddTicks(4363), 29, 0, 4878.0, 2 }
                });

            migrationBuilder.InsertData(
                table: "Payment",
                columns: new[] { "Id", "Amount", "PaymentDate", "PaymentMethod", "ReservationId", "Status" },
                values: new object[,]
                {
                    { 1, 995.07000000000005, new DateTime(2024, 12, 2, 10, 4, 9, 489, DateTimeKind.Local).AddTicks(7074), 1, 66, 0 },
                    { 2, 639.5, new DateTime(2024, 12, 9, 8, 45, 5, 693, DateTimeKind.Local).AddTicks(4540), 1, 47, 0 },
                    { 3, 50.340000000000003, new DateTime(2024, 11, 29, 1, 48, 53, 862, DateTimeKind.Local).AddTicks(4809), 1, 75, 0 },
                    { 4, 750.14999999999998, new DateTime(2024, 12, 2, 19, 11, 4, 9, DateTimeKind.Local).AddTicks(6654), 0, 3, 1 },
                    { 5, 549.85000000000002, new DateTime(2024, 12, 27, 16, 49, 57, 275, DateTimeKind.Local).AddTicks(5225), 1, 87, 1 },
                    { 6, 419.55000000000001, new DateTime(2024, 12, 23, 6, 42, 47, 13, DateTimeKind.Local).AddTicks(1318), 1, 84, 1 },
                    { 7, 656.00999999999999, new DateTime(2024, 12, 11, 5, 52, 55, 561, DateTimeKind.Local).AddTicks(7593), 0, 70, 0 },
                    { 8, 719.76999999999998, new DateTime(2024, 12, 4, 3, 48, 17, 527, DateTimeKind.Local).AddTicks(5391), 0, 43, 1 },
                    { 9, 236.91999999999999, new DateTime(2024, 12, 9, 8, 47, 19, 275, DateTimeKind.Local).AddTicks(1951), 0, 95, 0 },
                    { 10, 538.11000000000001, new DateTime(2024, 12, 22, 2, 5, 9, 553, DateTimeKind.Local).AddTicks(1239), 0, 3, 1 },
                    { 11, 735.33000000000004, new DateTime(2024, 12, 12, 4, 21, 5, 657, DateTimeKind.Local).AddTicks(78), 0, 99, 0 },
                    { 12, 419.70999999999998, new DateTime(2024, 11, 30, 19, 36, 7, 83, DateTimeKind.Local).AddTicks(8221), 1, 64, 1 },
                    { 13, 938.76999999999998, new DateTime(2024, 12, 25, 3, 3, 17, 874, DateTimeKind.Local).AddTicks(4554), 0, 15, 1 },
                    { 14, 972.42999999999995, new DateTime(2024, 12, 13, 3, 7, 38, 689, DateTimeKind.Local).AddTicks(6280), 0, 70, 0 },
                    { 15, 904.90999999999997, new DateTime(2024, 12, 22, 19, 57, 35, 868, DateTimeKind.Local).AddTicks(2649), 0, 32, 0 },
                    { 16, 329.14999999999998, new DateTime(2024, 12, 15, 15, 14, 47, 990, DateTimeKind.Local).AddTicks(5600), 1, 10, 1 },
                    { 17, 127.52, new DateTime(2024, 12, 9, 5, 40, 27, 239, DateTimeKind.Local).AddTicks(1781), 0, 4, 0 },
                    { 18, 159.71000000000001, new DateTime(2024, 12, 16, 4, 21, 56, 153, DateTimeKind.Local).AddTicks(8532), 1, 32, 0 },
                    { 19, 722.88999999999999, new DateTime(2024, 12, 24, 9, 44, 26, 485, DateTimeKind.Local).AddTicks(8936), 0, 4, 0 },
                    { 20, 566.41999999999996, new DateTime(2024, 12, 1, 1, 14, 48, 613, DateTimeKind.Local).AddTicks(5004), 0, 25, 1 },
                    { 21, 753.20000000000005, new DateTime(2024, 12, 12, 20, 30, 48, 670, DateTimeKind.Local).AddTicks(5020), 1, 19, 1 },
                    { 22, 139.63999999999999, new DateTime(2024, 11, 30, 0, 51, 30, 289, DateTimeKind.Local).AddTicks(6529), 0, 49, 0 },
                    { 23, 585.69000000000005, new DateTime(2024, 12, 3, 18, 19, 8, 426, DateTimeKind.Local).AddTicks(9858), 1, 72, 0 },
                    { 24, 894.67999999999995, new DateTime(2024, 12, 10, 6, 23, 47, 88, DateTimeKind.Local).AddTicks(7302), 0, 65, 0 },
                    { 25, 316.54000000000002, new DateTime(2024, 12, 14, 7, 25, 37, 542, DateTimeKind.Local).AddTicks(4324), 0, 59, 1 },
                    { 26, 333.85000000000002, new DateTime(2024, 12, 1, 20, 16, 41, 632, DateTimeKind.Local).AddTicks(1586), 0, 80, 0 },
                    { 27, 51.700000000000003, new DateTime(2024, 12, 7, 5, 46, 49, 213, DateTimeKind.Local).AddTicks(5499), 1, 19, 0 },
                    { 28, 907.59000000000003, new DateTime(2024, 12, 23, 7, 29, 47, 895, DateTimeKind.Local).AddTicks(3676), 0, 54, 1 },
                    { 29, 180.06999999999999, new DateTime(2024, 12, 23, 2, 16, 13, 782, DateTimeKind.Local).AddTicks(4709), 1, 2, 0 },
                    { 30, 319.13999999999999, new DateTime(2024, 12, 1, 8, 37, 6, 822, DateTimeKind.Local).AddTicks(3932), 0, 46, 0 },
                    { 31, 306.56999999999999, new DateTime(2024, 12, 7, 17, 28, 56, 524, DateTimeKind.Local).AddTicks(6276), 1, 71, 1 },
                    { 32, 67.730000000000004, new DateTime(2024, 12, 25, 5, 18, 55, 330, DateTimeKind.Local).AddTicks(6295), 1, 24, 0 },
                    { 33, 721.59000000000003, new DateTime(2024, 12, 9, 6, 8, 58, 577, DateTimeKind.Local).AddTicks(6989), 1, 92, 1 },
                    { 34, 874.25999999999999, new DateTime(2024, 12, 27, 12, 0, 45, 711, DateTimeKind.Local).AddTicks(1410), 0, 1, 1 },
                    { 35, 693.41999999999996, new DateTime(2024, 12, 1, 11, 57, 43, 385, DateTimeKind.Local).AddTicks(4192), 1, 81, 1 },
                    { 36, 277.92000000000002, new DateTime(2024, 12, 19, 21, 41, 6, 429, DateTimeKind.Local).AddTicks(6433), 1, 51, 0 },
                    { 37, 368.10000000000002, new DateTime(2024, 12, 4, 15, 57, 15, 704, DateTimeKind.Local).AddTicks(965), 0, 6, 1 },
                    { 38, 663.70000000000005, new DateTime(2024, 12, 16, 11, 10, 34, 548, DateTimeKind.Local).AddTicks(1232), 1, 28, 1 },
                    { 39, 407.58999999999997, new DateTime(2024, 12, 8, 15, 47, 19, 279, DateTimeKind.Local).AddTicks(7570), 0, 61, 1 },
                    { 40, 557.19000000000005, new DateTime(2024, 12, 16, 2, 43, 43, 368, DateTimeKind.Local).AddTicks(694), 0, 37, 0 },
                    { 41, 667.79999999999995, new DateTime(2024, 11, 30, 3, 40, 5, 616, DateTimeKind.Local).AddTicks(7112), 0, 14, 0 },
                    { 42, 337.06, new DateTime(2024, 12, 16, 17, 49, 10, 636, DateTimeKind.Local).AddTicks(18), 1, 66, 1 },
                    { 43, 588.92999999999995, new DateTime(2024, 12, 26, 18, 25, 55, 380, DateTimeKind.Local).AddTicks(4537), 0, 79, 0 },
                    { 44, 228.84999999999999, new DateTime(2024, 12, 18, 2, 31, 12, 821, DateTimeKind.Local).AddTicks(8845), 0, 32, 0 },
                    { 45, 459.23000000000002, new DateTime(2024, 12, 9, 2, 58, 9, 595, DateTimeKind.Local).AddTicks(8568), 0, 33, 0 },
                    { 46, 879.08000000000004, new DateTime(2024, 12, 16, 4, 38, 30, 278, DateTimeKind.Local).AddTicks(7510), 0, 33, 0 },
                    { 47, 251.69999999999999, new DateTime(2024, 12, 24, 16, 7, 58, 476, DateTimeKind.Local).AddTicks(3773), 0, 22, 1 },
                    { 48, 960.99000000000001, new DateTime(2024, 12, 7, 16, 46, 49, 101, DateTimeKind.Local).AddTicks(4190), 1, 39, 1 },
                    { 49, 642.63999999999999, new DateTime(2024, 12, 4, 22, 23, 55, 14, DateTimeKind.Local).AddTicks(9831), 1, 55, 1 },
                    { 50, 224.22999999999999, new DateTime(2024, 12, 13, 0, 26, 24, 429, DateTimeKind.Local).AddTicks(1437), 1, 79, 0 },
                    { 51, 602.29999999999995, new DateTime(2024, 12, 21, 6, 16, 32, 768, DateTimeKind.Local).AddTicks(922), 1, 27, 1 },
                    { 52, 344.69999999999999, new DateTime(2024, 12, 22, 3, 55, 17, 403, DateTimeKind.Local).AddTicks(6044), 1, 79, 1 },
                    { 53, 947.30999999999995, new DateTime(2024, 12, 25, 21, 50, 23, 818, DateTimeKind.Local).AddTicks(7737), 0, 10, 1 },
                    { 54, 997.0, new DateTime(2024, 12, 4, 19, 44, 30, 770, DateTimeKind.Local).AddTicks(7814), 1, 79, 0 },
                    { 55, 888.28999999999996, new DateTime(2024, 12, 7, 19, 36, 54, 526, DateTimeKind.Local).AddTicks(7859), 0, 42, 1 },
                    { 56, 420.10000000000002, new DateTime(2024, 12, 14, 15, 41, 12, 853, DateTimeKind.Local).AddTicks(4711), 1, 42, 0 },
                    { 57, 482.50999999999999, new DateTime(2024, 12, 26, 1, 32, 50, 313, DateTimeKind.Local).AddTicks(9281), 0, 77, 0 },
                    { 58, 598.58000000000004, new DateTime(2024, 12, 3, 22, 36, 44, 528, DateTimeKind.Local).AddTicks(4969), 1, 57, 0 },
                    { 59, 685.25, new DateTime(2024, 12, 3, 19, 4, 4, 925, DateTimeKind.Local).AddTicks(190), 1, 20, 1 },
                    { 60, 252.46000000000001, new DateTime(2024, 12, 24, 4, 39, 50, 971, DateTimeKind.Local).AddTicks(6647), 1, 30, 1 },
                    { 61, 655.02999999999997, new DateTime(2024, 12, 2, 11, 16, 40, 219, DateTimeKind.Local).AddTicks(841), 1, 43, 0 },
                    { 62, 350.31999999999999, new DateTime(2024, 12, 21, 14, 33, 51, 356, DateTimeKind.Local).AddTicks(5318), 1, 68, 0 },
                    { 63, 449.54000000000002, new DateTime(2024, 12, 19, 18, 23, 59, 633, DateTimeKind.Local).AddTicks(840), 0, 29, 1 },
                    { 64, 501.92000000000002, new DateTime(2024, 12, 12, 15, 27, 39, 941, DateTimeKind.Local).AddTicks(847), 1, 70, 0 },
                    { 65, 518.0, new DateTime(2024, 12, 19, 15, 46, 15, 260, DateTimeKind.Local).AddTicks(5909), 0, 25, 0 },
                    { 66, 943.74000000000001, new DateTime(2024, 12, 6, 14, 12, 13, 42, DateTimeKind.Local).AddTicks(1767), 1, 57, 1 },
                    { 67, 209.25, new DateTime(2024, 12, 5, 18, 40, 32, 699, DateTimeKind.Local).AddTicks(6102), 0, 78, 0 },
                    { 68, 391.85000000000002, new DateTime(2024, 12, 15, 8, 7, 26, 740, DateTimeKind.Local).AddTicks(1229), 1, 76, 1 },
                    { 69, 702.34000000000003, new DateTime(2024, 12, 7, 18, 31, 56, 145, DateTimeKind.Local).AddTicks(9518), 0, 90, 0 },
                    { 70, 898.77999999999997, new DateTime(2024, 12, 17, 6, 27, 21, 547, DateTimeKind.Local).AddTicks(2748), 0, 78, 0 },
                    { 71, 878.69000000000005, new DateTime(2024, 12, 21, 1, 47, 23, 502, DateTimeKind.Local).AddTicks(7368), 1, 19, 1 },
                    { 72, 527.62, new DateTime(2024, 12, 11, 17, 28, 20, 340, DateTimeKind.Local).AddTicks(9270), 0, 1, 0 },
                    { 73, 579.10000000000002, new DateTime(2024, 12, 5, 17, 5, 53, 291, DateTimeKind.Local).AddTicks(470), 1, 52, 0 },
                    { 74, 755.64999999999998, new DateTime(2024, 12, 15, 9, 20, 47, 25, DateTimeKind.Local).AddTicks(1308), 0, 54, 0 },
                    { 75, 322.89999999999998, new DateTime(2024, 12, 6, 22, 39, 6, 90, DateTimeKind.Local).AddTicks(9096), 0, 100, 1 },
                    { 76, 160.61000000000001, new DateTime(2024, 12, 12, 0, 21, 37, 617, DateTimeKind.Local).AddTicks(4550), 0, 93, 1 },
                    { 77, 93.680000000000007, new DateTime(2024, 12, 5, 9, 13, 33, 300, DateTimeKind.Local).AddTicks(273), 1, 28, 0 },
                    { 78, 348.74000000000001, new DateTime(2024, 12, 24, 7, 57, 2, 735, DateTimeKind.Local).AddTicks(6310), 1, 96, 1 },
                    { 79, 316.54000000000002, new DateTime(2024, 12, 7, 11, 18, 22, 890, DateTimeKind.Local).AddTicks(5411), 0, 75, 0 },
                    { 80, 995.96000000000004, new DateTime(2024, 12, 8, 16, 2, 55, 384, DateTimeKind.Local).AddTicks(1400), 0, 4, 0 }
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
                name: "IX_Room_RoomTypeId",
                table: "Room",
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
                name: "Room");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "RoomType");
        }
    }
}
