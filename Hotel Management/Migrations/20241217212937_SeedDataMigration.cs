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
                    RoomTypeId = table.Column<int>(type: "int", nullable: false)
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
                    { 1, "admin@hotel.com", "admin", "admin", "H/+UM3n6N9TDKtzotUqq1CgrVlZPLy8nRpp8YPdBsQvpyHD9i/WX84Mr1D/Y3vO6", "0600000000", 0 },
                    { 2, "Clark_Williamson@yahoo.com", "Micheal", "Franecki", "N2ZrSRIfaK6J4JVZ8p6EdAXP7NElnfW7fphnQZvlAt/2Teh+u7kXv1M78aSluhHg", "779-491-4341", 2 },
                    { 3, "Elsa_Turner20@yahoo.com", "Antone", "Cassin", "kS32sQrlynBnOiltHa4XCaPvQdkKXELEHlDyWAVAcPAdoz0/+PIrw/vPceHGtyVu", "(926) 689-8552 x3108", 1 },
                    { 4, "Deonte_Hahn72@gmail.com", "Armand", "Pfeffer", "BGPW6ih5q2jEIwFdpmAEZAShcpf54064SjWT1tyY0DKzwY57vdmXHi5j7y/kwWVc", "1-687-520-1509 x781", 0 },
                    { 5, "Madonna_Mann@gmail.com", "Kristoffer", "Halvorson", "R9LGI0OHCRPI4bhSufWZ++xT7zgfhB7vnqRUGY5sv44nvZlH0ZInBDyKqrxjOvWq", "456-974-7501 x438", 2 },
                    { 6, "Giovanny.Wunsch95@gmail.com", "Brenna", "Prosacco", "XpIMAhs44Ayr5W58F3MVxC4Vdqri2nfNP7i/I0RjNI92VlLIaV6iMTwgmizRtEyF", "(796) 200-2177", 2 },
                    { 7, "Maverick_Luettgen84@gmail.com", "Vella", "Haag", "RAY27tSj6lnqFv2peEEWPdJtQTYGwhSoTYia7fzOSQtJPJSQXOgx5up2MDwmgKGR", "908.302.1095 x02395", 0 },
                    { 8, "Ardith87@hotmail.com", "Jovani", "Mohr", "bBrx39n8FNXDfw5fZPKyg6TmOM9SYK1egIKl4ZDaKrpEA1Eo1BgMj+DGaZMDi35u", "1-985-464-9457 x5275", 2 },
                    { 9, "Lessie24@gmail.com", "Reginald", "Wyman", "J8Fkh4Nu13R5u5Wd4x17Luc2bvY6K1b9j/o7fcsJRk3BAlbHjwAQzybisoDptv4j", "(709) 280-9814", 0 },
                    { 10, "Nadia74@yahoo.com", "Tressa", "Goyette", "NkjN2B/ewHmP2io5t/gmDK5p6npi/Tg6iII4DvKq8ikaXpvT03r3tkjCaXodsSZS", "1-930-605-6273 x4599", 2 },
                    { 11, "Brooks_Grady@gmail.com", "Dalton", "Jakubowski", "9S3Bnhwi6o2ZcA2XMSVf3l6TRucT0/evqpWFwZqKMC0NlJ5O5GwcGQD2orjpkRH0", "416-497-4198 x0996", 0 },
                    { 12, "Cortney.Toy80@gmail.com", "Elvis", "Hessel", "FjCq3tkgWxrHvJIkyb+sxRz0ALjG7SBvIIfkMWaMNdzhVMg0yS4uu4RXJC01O9Vx", "446.978.8999 x1719", 1 },
                    { 13, "Brody.Hirthe@yahoo.com", "Santina", "Kerluke", "ZdMLX/iLttpgVX8AwqjNb8SoUpEhRYLmx6+vWRFnHgG1SJHkZRsceXazQp7U8uvg", "362-834-4583", 2 },
                    { 14, "Madalyn_Dickinson52@hotmail.com", "Chase", "Koepp", "RbxVrSb5+yRiPAvfp1jyACGOE2aq31ZajtDObSY4UGoHqUZC5Eh5MVp7lWu8WVcH", "266.934.7175 x2496", 0 },
                    { 15, "Litzy49@gmail.com", "Francisca", "Mraz", "0lEw2FxT3nnvKfJNLrJGvm2pSWXzwcBWGvv9YCv4ajCPjIl6bYXXLBYhj1+X4rBI", "1-961-366-0547", 0 },
                    { 16, "Bobbie_Adams17@hotmail.com", "Rhett", "Zemlak", "fEj/g5KicM8DyDLlad/SiJGba3ux8Y5FPErWmNd2qeAByrwDVA6IFGa8x+pGHhRt", "853-548-8635 x05972", 1 },
                    { 17, "Jalyn.Flatley7@gmail.com", "Janick", "Steuber", "hvZhddqSDVH+ZRwDg4IXnlurDBqwxaq6itzvXTszykd6OamgPWGJbAVEWQ+K32GQ", "591.322.8436 x8131", 1 },
                    { 18, "Dorothy84@yahoo.com", "Dimitri", "Raynor", "m9GviJRpLfhYMrtCG4S24wXg2tgQqlr5zB/DkyyhLUqwh2sfnJ7GpIBh3RDmcaHn", "(852) 779-3709 x513", 2 },
                    { 19, "Leo_Cormier@gmail.com", "Macie", "Zieme", "JsPgSCn3J/XQvjtSjXIvV6tm+o30oOx9iVfsnvbH7tJeWzyv4QhX1O8LlciCQ5b5", "740.474.5724 x2313", 1 },
                    { 20, "Ruthe_Kutch@hotmail.com", "Johnpaul", "Witting", "agC6F7pHZtsIK4z8RuA5J3v8huSfjGrfZMfMe1IT16r/9boZZrk4rtK6XNjZO7g+", "(210) 937-4518", 2 },
                    { 21, "Toni97@yahoo.com", "Jamarcus", "Emard", "QMNsCIEquRjVJRGKjrL2kIOs+e5Bnj1Dvnb/5w5GOubC6oANiPBoG/mlo92XxY5s", "586-984-4137 x40005", 0 },
                    { 22, "Brayan_Prosacco15@hotmail.com", "Beryl", "Rippin", "7HZjMJttHk6p2duDrX+xxrpQeIevdgJzfwErYfBdwdFBIN3QexXTOJnRQUsjkjzh", "487.687.7564 x879", 1 },
                    { 23, "Ezra.Gutkowski@gmail.com", "Dustin", "Gerhold", "EwePm1jns2oQuX/7tzAMdkLk51NXE/mAnP5cHtdXjOm81rIP4ZsHsfwSmKuHl7UF", "1-392-490-5199 x2050", 2 },
                    { 24, "Lucius63@gmail.com", "Fatima", "Lynch", "rQp4jpLxLtGfDLe1EjqJOWDOR/nJr6e3xzlbrPPrI68xK5HQMUW6wo5QUuGfGqAQ", "201.534.5331", 0 },
                    { 25, "Deven44@yahoo.com", "Willie", "Oberbrunner", "wYOQUqJbRMkdx9bkOfYlCY9JwFkDrZwJOeqPYAPWf98oChbla653mwu9AqNMTQIi", "(996) 620-1398", 0 },
                    { 26, "Ramona.Tillman@hotmail.com", "Kaycee", "Osinski", "CpmC7IELh0mzHu9KuVk/ARHzvA0PvGgxRlYCQR2m2qj/Ci7mHfGueN8KyDAlwPLD", "1-408-794-3418", 1 }
                });

            migrationBuilder.InsertData(
                table: "Room",
                columns: new[] { "Id", "Capacity", "IsAvailable", "Name", "Price", "RoomTypeId" },
                values: new object[,]
                {
                    { 1, 9, true, "Room 168", 292.92438086197626, 1 },
                    { 2, 3, true, "Room 435", 332.22203844101494, 3 },
                    { 3, 1, false, "Room 270", 428.50054970198772, 2 },
                    { 4, 3, true, "Room 385", 148.88228471472064, 3 },
                    { 5, 4, false, "Room 293", 901.3233571425676, 2 },
                    { 6, 1, false, "Room 462", 630.5526158749866, 3 },
                    { 7, 4, false, "Room 394", 416.68341221163809, 2 },
                    { 8, 1, true, "Room 307", 291.46791270400877, 3 },
                    { 9, 8, true, "Room 398", 761.55975418321736, 3 },
                    { 10, 8, true, "Room 438", 825.5413675417185, 1 },
                    { 11, 3, true, "Room 143", 262.90108163358343, 3 },
                    { 12, 4, true, "Room 124", 808.37506645113945, 2 },
                    { 13, 10, false, "Room 263", 907.33643707205613, 2 },
                    { 14, 9, true, "Room 126", 476.90202722131386, 1 },
                    { 15, 3, false, "Room 270", 627.10914619297387, 2 },
                    { 16, 7, false, "Room 176", 971.26233706713276, 1 },
                    { 17, 1, true, "Room 124", 821.39474398892344, 3 },
                    { 18, 3, false, "Room 414", 637.61532565879111, 3 },
                    { 19, 1, true, "Room 361", 618.9591051236514, 1 },
                    { 20, 5, false, "Room 115", 290.02557808318772, 3 },
                    { 21, 5, false, "Room 139", 430.69229969607426, 2 },
                    { 22, 10, false, "Room 369", 227.83652219329494, 1 },
                    { 23, 4, false, "Room 405", 918.98949407959594, 1 },
                    { 24, 7, true, "Room 238", 289.78307569928739, 1 },
                    { 25, 2, true, "Room 257", 763.50412555439323, 2 },
                    { 26, 7, false, "Room 263", 603.38183568404588, 2 },
                    { 27, 1, true, "Room 224", 214.76423420925565, 2 },
                    { 28, 10, false, "Room 383", 808.54570587383057, 1 },
                    { 29, 3, true, "Room 250", 937.04978217262271, 1 },
                    { 30, 5, true, "Room 151", 958.84608031500727, 3 },
                    { 31, 1, true, "Room 229", 213.26684182967912, 1 },
                    { 32, 8, false, "Room 232", 785.19052006768004, 3 },
                    { 33, 2, false, "Room 297", 721.92023930529319, 3 },
                    { 34, 8, true, "Room 240", 847.29186611637374, 3 },
                    { 35, 5, true, "Room 214", 985.96037631120862, 3 },
                    { 36, 6, true, "Room 377", 780.80575041412908, 1 },
                    { 37, 8, true, "Room 177", 327.3172377070436, 1 },
                    { 38, 7, true, "Room 467", 697.50912634299073, 1 },
                    { 39, 1, false, "Room 303", 951.155164979093, 2 },
                    { 40, 7, true, "Room 205", 85.14640915604221, 2 },
                    { 41, 7, false, "Room 242", 840.13592484587548, 3 },
                    { 42, 2, true, "Room 267", 520.06715100178144, 2 },
                    { 43, 2, false, "Room 444", 752.49705441942558, 1 },
                    { 44, 1, true, "Room 273", 734.05279515750283, 2 },
                    { 45, 1, true, "Room 457", 462.37851832626296, 3 },
                    { 46, 6, false, "Room 357", 317.25637920328273, 2 },
                    { 47, 8, false, "Room 384", 828.17828798997493, 2 },
                    { 48, 9, true, "Room 365", 74.865709582620369, 2 },
                    { 49, 1, false, "Room 384", 438.80805764615337, 1 },
                    { 50, 3, false, "Room 265", 116.20793806790181, 3 }
                });

            migrationBuilder.InsertData(
                table: "Reservation",
                columns: new[] { "Id", "CheckInDate", "CheckOutDate", "RoomId", "Status", "TotalPrice", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 12, 13, 2, 4, 20, 942, DateTimeKind.Local).AddTicks(3163), new DateTime(2024, 12, 17, 2, 4, 20, 942, DateTimeKind.Local).AddTicks(3163), 4, 0, 3676.0, 10 },
                    { 2, new DateTime(2024, 12, 29, 23, 17, 12, 848, DateTimeKind.Local).AddTicks(4208), new DateTime(2025, 1, 6, 23, 17, 12, 848, DateTimeKind.Local).AddTicks(4208), 38, 1, 3698.0, 1 },
                    { 3, new DateTime(2024, 12, 20, 9, 13, 20, 434, DateTimeKind.Local).AddTicks(3430), new DateTime(2024, 12, 21, 9, 13, 20, 434, DateTimeKind.Local).AddTicks(3430), 29, 0, 351.0, 5 },
                    { 4, new DateTime(2024, 11, 27, 1, 27, 0, 251, DateTimeKind.Local).AddTicks(6981), new DateTime(2024, 12, 7, 1, 27, 0, 251, DateTimeKind.Local).AddTicks(6981), 27, 0, 810.0, 8 },
                    { 5, new DateTime(2025, 1, 10, 0, 1, 12, 433, DateTimeKind.Local).AddTicks(7171), new DateTime(2025, 1, 15, 0, 1, 12, 433, DateTimeKind.Local).AddTicks(7171), 4, 2, 2087.0, 1 },
                    { 6, new DateTime(2024, 12, 18, 14, 17, 35, 786, DateTimeKind.Local).AddTicks(803), new DateTime(2024, 12, 21, 14, 17, 35, 786, DateTimeKind.Local).AddTicks(803), 32, 2, 1394.0, 6 },
                    { 7, new DateTime(2025, 1, 3, 13, 55, 17, 382, DateTimeKind.Local).AddTicks(5106), new DateTime(2025, 1, 4, 13, 55, 17, 382, DateTimeKind.Local).AddTicks(5106), 19, 2, 2115.0, 4 },
                    { 8, new DateTime(2024, 12, 24, 5, 28, 10, 928, DateTimeKind.Local).AddTicks(1316), new DateTime(2025, 1, 2, 5, 28, 10, 928, DateTimeKind.Local).AddTicks(1316), 36, 0, 3191.0, 4 },
                    { 9, new DateTime(2025, 1, 6, 16, 8, 0, 338, DateTimeKind.Local).AddTicks(2667), new DateTime(2025, 1, 10, 16, 8, 0, 338, DateTimeKind.Local).AddTicks(2667), 2, 2, 1841.0, 8 },
                    { 10, new DateTime(2024, 12, 21, 0, 42, 3, 98, DateTimeKind.Local).AddTicks(3201), new DateTime(2024, 12, 24, 0, 42, 3, 98, DateTimeKind.Local).AddTicks(3201), 9, 1, 3702.0, 9 },
                    { 11, new DateTime(2024, 12, 8, 10, 4, 1, 158, DateTimeKind.Local).AddTicks(6228), new DateTime(2024, 12, 16, 10, 4, 1, 158, DateTimeKind.Local).AddTicks(6228), 47, 1, 1238.0, 7 },
                    { 12, new DateTime(2024, 12, 15, 15, 53, 42, 213, DateTimeKind.Local).AddTicks(5726), new DateTime(2024, 12, 18, 15, 53, 42, 213, DateTimeKind.Local).AddTicks(5726), 11, 1, 240.0, 1 },
                    { 13, new DateTime(2024, 11, 19, 21, 38, 49, 734, DateTimeKind.Local).AddTicks(8801), new DateTime(2024, 11, 20, 21, 38, 49, 734, DateTimeKind.Local).AddTicks(8801), 44, 1, 257.0, 9 },
                    { 14, new DateTime(2024, 11, 25, 17, 35, 30, 141, DateTimeKind.Local).AddTicks(4508), new DateTime(2024, 12, 2, 17, 35, 30, 141, DateTimeKind.Local).AddTicks(4508), 39, 1, 2123.0, 4 },
                    { 15, new DateTime(2025, 1, 8, 6, 10, 27, 302, DateTimeKind.Local).AddTicks(199), new DateTime(2025, 1, 12, 6, 10, 27, 302, DateTimeKind.Local).AddTicks(199), 46, 2, 4756.0, 2 },
                    { 16, new DateTime(2024, 12, 31, 19, 4, 21, 318, DateTimeKind.Local).AddTicks(8996), new DateTime(2025, 1, 1, 19, 4, 21, 318, DateTimeKind.Local).AddTicks(8996), 30, 1, 987.0, 2 },
                    { 17, new DateTime(2024, 12, 10, 1, 4, 42, 5, DateTimeKind.Local).AddTicks(6824), new DateTime(2024, 12, 14, 1, 4, 42, 5, DateTimeKind.Local).AddTicks(6824), 23, 1, 1621.0, 3 },
                    { 18, new DateTime(2024, 11, 29, 12, 12, 31, 732, DateTimeKind.Local).AddTicks(1101), new DateTime(2024, 12, 3, 12, 12, 31, 732, DateTimeKind.Local).AddTicks(1101), 29, 2, 3244.0, 5 },
                    { 19, new DateTime(2024, 11, 20, 23, 48, 42, 520, DateTimeKind.Local).AddTicks(9884), new DateTime(2024, 11, 23, 23, 48, 42, 520, DateTimeKind.Local).AddTicks(9884), 21, 2, 4537.0, 1 },
                    { 20, new DateTime(2024, 11, 20, 13, 27, 17, 959, DateTimeKind.Local).AddTicks(9156), new DateTime(2024, 11, 30, 13, 27, 17, 959, DateTimeKind.Local).AddTicks(9156), 2, 1, 3581.0, 6 },
                    { 21, new DateTime(2024, 12, 31, 23, 57, 11, 956, DateTimeKind.Local).AddTicks(5433), new DateTime(2025, 1, 1, 23, 57, 11, 956, DateTimeKind.Local).AddTicks(5433), 26, 1, 4647.0, 10 },
                    { 22, new DateTime(2024, 12, 30, 15, 37, 45, 293, DateTimeKind.Local).AddTicks(9498), new DateTime(2025, 1, 1, 15, 37, 45, 293, DateTimeKind.Local).AddTicks(9498), 28, 0, 3386.0, 4 },
                    { 23, new DateTime(2024, 12, 17, 7, 42, 34, 919, DateTimeKind.Local).AddTicks(7443), new DateTime(2024, 12, 21, 7, 42, 34, 919, DateTimeKind.Local).AddTicks(7443), 19, 1, 3909.0, 5 },
                    { 24, new DateTime(2025, 1, 11, 9, 40, 44, 209, DateTimeKind.Local).AddTicks(9163), new DateTime(2025, 1, 21, 9, 40, 44, 209, DateTimeKind.Local).AddTicks(9163), 2, 1, 2311.0, 3 },
                    { 25, new DateTime(2024, 12, 13, 18, 51, 47, 156, DateTimeKind.Local).AddTicks(5205), new DateTime(2024, 12, 18, 18, 51, 47, 156, DateTimeKind.Local).AddTicks(5205), 34, 1, 2724.0, 8 },
                    { 26, new DateTime(2024, 12, 9, 23, 27, 57, 472, DateTimeKind.Local).AddTicks(3782), new DateTime(2024, 12, 10, 23, 27, 57, 472, DateTimeKind.Local).AddTicks(3782), 8, 0, 1859.0, 8 },
                    { 27, new DateTime(2024, 12, 31, 3, 55, 18, 40, DateTimeKind.Local).AddTicks(523), new DateTime(2025, 1, 8, 3, 55, 18, 40, DateTimeKind.Local).AddTicks(523), 41, 0, 2709.0, 2 },
                    { 28, new DateTime(2024, 11, 30, 4, 41, 3, 129, DateTimeKind.Local).AddTicks(8237), new DateTime(2024, 12, 9, 4, 41, 3, 129, DateTimeKind.Local).AddTicks(8237), 21, 0, 4576.0, 9 },
                    { 29, new DateTime(2024, 12, 4, 23, 1, 40, 227, DateTimeKind.Local).AddTicks(7562), new DateTime(2024, 12, 12, 23, 1, 40, 227, DateTimeKind.Local).AddTicks(7562), 7, 1, 3798.0, 10 },
                    { 30, new DateTime(2024, 12, 17, 4, 39, 30, 756, DateTimeKind.Local).AddTicks(9156), new DateTime(2024, 12, 22, 4, 39, 30, 756, DateTimeKind.Local).AddTicks(9156), 33, 2, 2997.0, 1 },
                    { 31, new DateTime(2024, 12, 18, 6, 42, 54, 439, DateTimeKind.Local).AddTicks(2451), new DateTime(2024, 12, 20, 6, 42, 54, 439, DateTimeKind.Local).AddTicks(2451), 44, 0, 1335.0, 6 },
                    { 32, new DateTime(2024, 12, 1, 22, 25, 13, 21, DateTimeKind.Local).AddTicks(8088), new DateTime(2024, 12, 4, 22, 25, 13, 21, DateTimeKind.Local).AddTicks(8088), 6, 1, 1199.0, 4 },
                    { 33, new DateTime(2024, 12, 6, 9, 30, 50, 887, DateTimeKind.Local).AddTicks(5950), new DateTime(2024, 12, 14, 9, 30, 50, 887, DateTimeKind.Local).AddTicks(5950), 39, 2, 766.0, 7 },
                    { 34, new DateTime(2024, 12, 16, 5, 24, 6, 48, DateTimeKind.Local).AddTicks(9543), new DateTime(2024, 12, 26, 5, 24, 6, 48, DateTimeKind.Local).AddTicks(9543), 8, 2, 3008.0, 9 },
                    { 35, new DateTime(2025, 1, 2, 11, 53, 59, 57, DateTimeKind.Local).AddTicks(765), new DateTime(2025, 1, 12, 11, 53, 59, 57, DateTimeKind.Local).AddTicks(765), 44, 0, 4418.0, 9 },
                    { 36, new DateTime(2024, 12, 13, 0, 3, 50, 521, DateTimeKind.Local).AddTicks(8768), new DateTime(2024, 12, 16, 0, 3, 50, 521, DateTimeKind.Local).AddTicks(8768), 20, 1, 4931.0, 2 },
                    { 37, new DateTime(2024, 12, 1, 1, 48, 48, 313, DateTimeKind.Local).AddTicks(6156), new DateTime(2024, 12, 8, 1, 48, 48, 313, DateTimeKind.Local).AddTicks(6156), 21, 1, 4019.0, 9 },
                    { 38, new DateTime(2024, 12, 11, 7, 40, 29, 360, DateTimeKind.Local).AddTicks(6634), new DateTime(2024, 12, 17, 7, 40, 29, 360, DateTimeKind.Local).AddTicks(6634), 14, 0, 2383.0, 3 },
                    { 39, new DateTime(2024, 11, 18, 3, 14, 7, 197, DateTimeKind.Local).AddTicks(9871), new DateTime(2024, 11, 19, 3, 14, 7, 197, DateTimeKind.Local).AddTicks(9871), 47, 2, 3194.0, 2 },
                    { 40, new DateTime(2025, 1, 13, 15, 28, 37, 860, DateTimeKind.Local).AddTicks(1509), new DateTime(2025, 1, 16, 15, 28, 37, 860, DateTimeKind.Local).AddTicks(1509), 14, 0, 700.0, 1 },
                    { 41, new DateTime(2025, 1, 12, 10, 19, 20, 803, DateTimeKind.Local).AddTicks(7130), new DateTime(2025, 1, 13, 10, 19, 20, 803, DateTimeKind.Local).AddTicks(7130), 23, 2, 2043.0, 3 },
                    { 42, new DateTime(2024, 11, 20, 18, 51, 18, 887, DateTimeKind.Local).AddTicks(9228), new DateTime(2024, 11, 21, 18, 51, 18, 887, DateTimeKind.Local).AddTicks(9228), 45, 2, 3567.0, 10 },
                    { 43, new DateTime(2024, 12, 30, 22, 58, 46, 109, DateTimeKind.Local).AddTicks(2825), new DateTime(2025, 1, 6, 22, 58, 46, 109, DateTimeKind.Local).AddTicks(2825), 37, 1, 2851.0, 6 },
                    { 44, new DateTime(2024, 11, 28, 4, 17, 13, 675, DateTimeKind.Local).AddTicks(2759), new DateTime(2024, 12, 1, 4, 17, 13, 675, DateTimeKind.Local).AddTicks(2759), 37, 2, 3626.0, 5 },
                    { 45, new DateTime(2024, 12, 18, 14, 14, 31, 278, DateTimeKind.Local).AddTicks(453), new DateTime(2024, 12, 21, 14, 14, 31, 278, DateTimeKind.Local).AddTicks(453), 6, 0, 3984.0, 7 },
                    { 46, new DateTime(2024, 12, 14, 17, 30, 3, 585, DateTimeKind.Local).AddTicks(3431), new DateTime(2024, 12, 19, 17, 30, 3, 585, DateTimeKind.Local).AddTicks(3431), 29, 1, 3680.0, 6 },
                    { 47, new DateTime(2024, 11, 18, 14, 27, 29, 526, DateTimeKind.Local).AddTicks(7457), new DateTime(2024, 11, 25, 14, 27, 29, 526, DateTimeKind.Local).AddTicks(7457), 6, 2, 4399.0, 4 },
                    { 48, new DateTime(2025, 1, 10, 9, 20, 19, 929, DateTimeKind.Local).AddTicks(349), new DateTime(2025, 1, 12, 9, 20, 19, 929, DateTimeKind.Local).AddTicks(349), 25, 0, 4666.0, 1 },
                    { 49, new DateTime(2024, 12, 6, 22, 12, 47, 321, DateTimeKind.Local).AddTicks(7105), new DateTime(2024, 12, 13, 22, 12, 47, 321, DateTimeKind.Local).AddTicks(7105), 16, 2, 2794.0, 4 },
                    { 50, new DateTime(2024, 11, 28, 9, 43, 43, 242, DateTimeKind.Local).AddTicks(6708), new DateTime(2024, 12, 5, 9, 43, 43, 242, DateTimeKind.Local).AddTicks(6708), 35, 1, 1443.0, 9 },
                    { 51, new DateTime(2024, 11, 26, 9, 46, 29, 453, DateTimeKind.Local).AddTicks(2350), new DateTime(2024, 12, 4, 9, 46, 29, 453, DateTimeKind.Local).AddTicks(2350), 8, 0, 4486.0, 1 },
                    { 52, new DateTime(2024, 11, 17, 23, 20, 23, 860, DateTimeKind.Local).AddTicks(6242), new DateTime(2024, 11, 22, 23, 20, 23, 860, DateTimeKind.Local).AddTicks(6242), 10, 2, 3146.0, 4 },
                    { 53, new DateTime(2024, 12, 6, 13, 6, 1, 967, DateTimeKind.Local).AddTicks(8171), new DateTime(2024, 12, 16, 13, 6, 1, 967, DateTimeKind.Local).AddTicks(8171), 36, 0, 3645.0, 4 },
                    { 54, new DateTime(2024, 12, 17, 4, 23, 43, 694, DateTimeKind.Local).AddTicks(9468), new DateTime(2024, 12, 24, 4, 23, 43, 694, DateTimeKind.Local).AddTicks(9468), 17, 2, 2232.0, 5 },
                    { 55, new DateTime(2025, 1, 5, 22, 11, 48, 763, DateTimeKind.Local).AddTicks(1251), new DateTime(2025, 1, 8, 22, 11, 48, 763, DateTimeKind.Local).AddTicks(1251), 37, 2, 1373.0, 9 },
                    { 56, new DateTime(2024, 11, 25, 14, 30, 31, 170, DateTimeKind.Local).AddTicks(3751), new DateTime(2024, 11, 30, 14, 30, 31, 170, DateTimeKind.Local).AddTicks(3751), 16, 1, 1111.0, 2 },
                    { 57, new DateTime(2024, 11, 21, 13, 36, 53, 119, DateTimeKind.Local).AddTicks(2659), new DateTime(2024, 11, 30, 13, 36, 53, 119, DateTimeKind.Local).AddTicks(2659), 40, 0, 4307.0, 2 },
                    { 58, new DateTime(2025, 1, 3, 5, 21, 17, 156, DateTimeKind.Local).AddTicks(9664), new DateTime(2025, 1, 12, 5, 21, 17, 156, DateTimeKind.Local).AddTicks(9664), 5, 1, 2715.0, 5 },
                    { 59, new DateTime(2024, 12, 4, 16, 53, 57, 558, DateTimeKind.Local).AddTicks(7042), new DateTime(2024, 12, 5, 16, 53, 57, 558, DateTimeKind.Local).AddTicks(7042), 4, 2, 3576.0, 3 },
                    { 60, new DateTime(2024, 12, 10, 9, 43, 8, 32, DateTimeKind.Local).AddTicks(3702), new DateTime(2024, 12, 16, 9, 43, 8, 32, DateTimeKind.Local).AddTicks(3702), 24, 1, 2999.0, 9 },
                    { 61, new DateTime(2024, 12, 31, 3, 35, 15, 605, DateTimeKind.Local).AddTicks(7683), new DateTime(2025, 1, 3, 3, 35, 15, 605, DateTimeKind.Local).AddTicks(7683), 2, 1, 4815.0, 10 },
                    { 62, new DateTime(2025, 1, 12, 17, 7, 19, 509, DateTimeKind.Local).AddTicks(8720), new DateTime(2025, 1, 22, 17, 7, 19, 509, DateTimeKind.Local).AddTicks(8720), 35, 2, 1654.0, 4 },
                    { 63, new DateTime(2024, 12, 25, 5, 22, 59, 776, DateTimeKind.Local).AddTicks(183), new DateTime(2025, 1, 1, 5, 22, 59, 776, DateTimeKind.Local).AddTicks(183), 45, 1, 4524.0, 6 },
                    { 64, new DateTime(2024, 12, 4, 0, 28, 2, 980, DateTimeKind.Local).AddTicks(843), new DateTime(2024, 12, 8, 0, 28, 2, 980, DateTimeKind.Local).AddTicks(843), 26, 0, 3939.0, 4 },
                    { 65, new DateTime(2024, 12, 18, 14, 41, 20, 791, DateTimeKind.Local).AddTicks(8553), new DateTime(2024, 12, 27, 14, 41, 20, 791, DateTimeKind.Local).AddTicks(8553), 33, 1, 1247.0, 1 },
                    { 66, new DateTime(2024, 12, 31, 16, 47, 13, 991, DateTimeKind.Local).AddTicks(6279), new DateTime(2025, 1, 2, 16, 47, 13, 991, DateTimeKind.Local).AddTicks(6279), 40, 2, 766.0, 10 },
                    { 67, new DateTime(2024, 11, 28, 0, 38, 4, 50, DateTimeKind.Local).AddTicks(3717), new DateTime(2024, 12, 5, 0, 38, 4, 50, DateTimeKind.Local).AddTicks(3717), 20, 0, 3158.0, 6 },
                    { 68, new DateTime(2025, 1, 6, 18, 56, 38, 319, DateTimeKind.Local).AddTicks(8254), new DateTime(2025, 1, 13, 18, 56, 38, 319, DateTimeKind.Local).AddTicks(8254), 25, 0, 3556.0, 6 },
                    { 69, new DateTime(2024, 12, 4, 23, 15, 58, 862, DateTimeKind.Local).AddTicks(9783), new DateTime(2024, 12, 7, 23, 15, 58, 862, DateTimeKind.Local).AddTicks(9783), 6, 2, 3905.0, 1 },
                    { 70, new DateTime(2024, 12, 18, 10, 29, 58, 370, DateTimeKind.Local).AddTicks(3948), new DateTime(2024, 12, 25, 10, 29, 58, 370, DateTimeKind.Local).AddTicks(3948), 36, 2, 1820.0, 7 },
                    { 71, new DateTime(2024, 12, 28, 8, 29, 13, 681, DateTimeKind.Local).AddTicks(1507), new DateTime(2025, 1, 7, 8, 29, 13, 681, DateTimeKind.Local).AddTicks(1507), 36, 2, 2590.0, 1 },
                    { 72, new DateTime(2024, 11, 20, 9, 12, 33, 877, DateTimeKind.Local).AddTicks(3556), new DateTime(2024, 11, 29, 9, 12, 33, 877, DateTimeKind.Local).AddTicks(3556), 29, 0, 377.0, 6 },
                    { 73, new DateTime(2025, 1, 3, 19, 33, 52, 704, DateTimeKind.Local).AddTicks(6320), new DateTime(2025, 1, 6, 19, 33, 52, 704, DateTimeKind.Local).AddTicks(6320), 35, 0, 1777.0, 4 },
                    { 74, new DateTime(2024, 12, 21, 12, 29, 46, 703, DateTimeKind.Local).AddTicks(7763), new DateTime(2024, 12, 29, 12, 29, 46, 703, DateTimeKind.Local).AddTicks(7763), 25, 1, 2000.0, 7 },
                    { 75, new DateTime(2024, 11, 22, 10, 13, 15, 237, DateTimeKind.Local).AddTicks(7312), new DateTime(2024, 11, 24, 10, 13, 15, 237, DateTimeKind.Local).AddTicks(7312), 15, 1, 2271.0, 8 },
                    { 76, new DateTime(2025, 1, 5, 0, 27, 34, 100, DateTimeKind.Local).AddTicks(1474), new DateTime(2025, 1, 6, 0, 27, 34, 100, DateTimeKind.Local).AddTicks(1474), 9, 1, 1490.0, 7 },
                    { 77, new DateTime(2025, 1, 10, 22, 53, 15, 381, DateTimeKind.Local).AddTicks(8016), new DateTime(2025, 1, 14, 22, 53, 15, 381, DateTimeKind.Local).AddTicks(8016), 34, 2, 2759.0, 1 },
                    { 78, new DateTime(2024, 12, 28, 0, 7, 15, 184, DateTimeKind.Local).AddTicks(5691), new DateTime(2025, 1, 4, 0, 7, 15, 184, DateTimeKind.Local).AddTicks(5691), 40, 0, 4368.0, 2 },
                    { 79, new DateTime(2025, 1, 1, 6, 33, 10, 31, DateTimeKind.Local).AddTicks(285), new DateTime(2025, 1, 4, 6, 33, 10, 31, DateTimeKind.Local).AddTicks(285), 15, 1, 3063.0, 4 },
                    { 80, new DateTime(2025, 1, 15, 5, 5, 2, 873, DateTimeKind.Local).AddTicks(4300), new DateTime(2025, 1, 25, 5, 5, 2, 873, DateTimeKind.Local).AddTicks(4300), 6, 0, 2085.0, 3 },
                    { 81, new DateTime(2025, 1, 12, 19, 18, 40, 401, DateTimeKind.Local).AddTicks(9119), new DateTime(2025, 1, 13, 19, 18, 40, 401, DateTimeKind.Local).AddTicks(9119), 1, 2, 4685.0, 2 },
                    { 82, new DateTime(2024, 11, 23, 2, 40, 44, 147, DateTimeKind.Local).AddTicks(2981), new DateTime(2024, 11, 30, 2, 40, 44, 147, DateTimeKind.Local).AddTicks(2981), 44, 1, 299.0, 3 },
                    { 83, new DateTime(2024, 12, 4, 14, 43, 46, 290, DateTimeKind.Local).AddTicks(3191), new DateTime(2024, 12, 10, 14, 43, 46, 290, DateTimeKind.Local).AddTicks(3191), 24, 2, 233.0, 3 },
                    { 84, new DateTime(2025, 1, 3, 2, 11, 45, 341, DateTimeKind.Local).AddTicks(274), new DateTime(2025, 1, 6, 2, 11, 45, 341, DateTimeKind.Local).AddTicks(274), 14, 1, 1241.0, 3 },
                    { 85, new DateTime(2024, 11, 20, 19, 57, 18, 489, DateTimeKind.Local).AddTicks(2991), new DateTime(2024, 11, 26, 19, 57, 18, 489, DateTimeKind.Local).AddTicks(2991), 15, 2, 1660.0, 5 },
                    { 86, new DateTime(2024, 12, 22, 20, 0, 52, 616, DateTimeKind.Local).AddTicks(8446), new DateTime(2024, 12, 30, 20, 0, 52, 616, DateTimeKind.Local).AddTicks(8446), 24, 2, 846.0, 3 },
                    { 87, new DateTime(2024, 11, 19, 6, 40, 21, 989, DateTimeKind.Local).AddTicks(3790), new DateTime(2024, 11, 24, 6, 40, 21, 989, DateTimeKind.Local).AddTicks(3790), 44, 0, 4385.0, 8 },
                    { 88, new DateTime(2025, 1, 10, 16, 31, 39, 611, DateTimeKind.Local).AddTicks(2128), new DateTime(2025, 1, 15, 16, 31, 39, 611, DateTimeKind.Local).AddTicks(2128), 20, 0, 286.0, 5 },
                    { 89, new DateTime(2024, 12, 26, 2, 9, 30, 866, DateTimeKind.Local).AddTicks(5570), new DateTime(2025, 1, 4, 2, 9, 30, 866, DateTimeKind.Local).AddTicks(5570), 31, 1, 4529.0, 5 },
                    { 90, new DateTime(2025, 1, 8, 6, 48, 9, 336, DateTimeKind.Local).AddTicks(3800), new DateTime(2025, 1, 12, 6, 48, 9, 336, DateTimeKind.Local).AddTicks(3800), 48, 2, 3348.0, 7 },
                    { 91, new DateTime(2024, 12, 18, 8, 6, 54, 894, DateTimeKind.Local).AddTicks(3518), new DateTime(2024, 12, 21, 8, 6, 54, 894, DateTimeKind.Local).AddTicks(3518), 45, 0, 339.0, 3 },
                    { 92, new DateTime(2024, 12, 10, 23, 10, 51, 187, DateTimeKind.Local).AddTicks(3021), new DateTime(2024, 12, 20, 23, 10, 51, 187, DateTimeKind.Local).AddTicks(3021), 22, 2, 1324.0, 6 },
                    { 93, new DateTime(2024, 12, 10, 6, 9, 41, 617, DateTimeKind.Local).AddTicks(9395), new DateTime(2024, 12, 12, 6, 9, 41, 617, DateTimeKind.Local).AddTicks(9395), 4, 1, 4501.0, 6 },
                    { 94, new DateTime(2024, 11, 22, 2, 30, 52, 578, DateTimeKind.Local).AddTicks(9506), new DateTime(2024, 11, 25, 2, 30, 52, 578, DateTimeKind.Local).AddTicks(9506), 39, 2, 3897.0, 4 },
                    { 95, new DateTime(2024, 12, 9, 12, 24, 40, 106, DateTimeKind.Local).AddTicks(3491), new DateTime(2024, 12, 11, 12, 24, 40, 106, DateTimeKind.Local).AddTicks(3491), 4, 0, 2052.0, 10 },
                    { 96, new DateTime(2024, 12, 20, 14, 23, 57, 711, DateTimeKind.Local).AddTicks(2807), new DateTime(2024, 12, 22, 14, 23, 57, 711, DateTimeKind.Local).AddTicks(2807), 37, 0, 2266.0, 3 },
                    { 97, new DateTime(2024, 12, 29, 1, 38, 58, 691, DateTimeKind.Local).AddTicks(5070), new DateTime(2024, 12, 30, 1, 38, 58, 691, DateTimeKind.Local).AddTicks(5070), 8, 1, 4145.0, 2 },
                    { 98, new DateTime(2024, 12, 28, 4, 14, 23, 389, DateTimeKind.Local).AddTicks(5539), new DateTime(2025, 1, 5, 4, 14, 23, 389, DateTimeKind.Local).AddTicks(5539), 34, 1, 152.0, 3 },
                    { 99, new DateTime(2025, 1, 14, 6, 2, 1, 245, DateTimeKind.Local).AddTicks(6316), new DateTime(2025, 1, 15, 6, 2, 1, 245, DateTimeKind.Local).AddTicks(6316), 27, 1, 4834.0, 6 },
                    { 100, new DateTime(2024, 11, 24, 12, 16, 49, 472, DateTimeKind.Local).AddTicks(3386), new DateTime(2024, 11, 25, 12, 16, 49, 472, DateTimeKind.Local).AddTicks(3386), 29, 2, 4187.0, 8 }
                });

            migrationBuilder.InsertData(
                table: "Payment",
                columns: new[] { "Id", "Amount", "PaymentDate", "PaymentMethod", "ReservationId", "Status" },
                values: new object[,]
                {
                    { 1, 914.30999999999995, new DateTime(2024, 11, 19, 12, 50, 10, 346, DateTimeKind.Local).AddTicks(2068), 0, 35, 0 },
                    { 2, 637.16999999999996, new DateTime(2024, 12, 17, 7, 9, 48, 816, DateTimeKind.Local).AddTicks(2629), 1, 55, 1 },
                    { 3, 267.07999999999998, new DateTime(2024, 11, 24, 13, 48, 48, 504, DateTimeKind.Local).AddTicks(8199), 1, 31, 0 },
                    { 4, 683.53999999999996, new DateTime(2024, 12, 10, 22, 23, 26, 471, DateTimeKind.Local).AddTicks(9252), 1, 47, 0 },
                    { 5, 835.04999999999995, new DateTime(2024, 12, 16, 5, 39, 56, 92, DateTimeKind.Local).AddTicks(6068), 1, 71, 1 },
                    { 6, 131.72999999999999, new DateTime(2024, 11, 24, 12, 45, 19, 714, DateTimeKind.Local).AddTicks(1448), 1, 6, 1 },
                    { 7, 851.64999999999998, new DateTime(2024, 12, 9, 23, 55, 50, 948, DateTimeKind.Local).AddTicks(3296), 0, 72, 1 },
                    { 8, 861.72000000000003, new DateTime(2024, 12, 15, 12, 5, 7, 24, DateTimeKind.Local).AddTicks(6284), 0, 42, 1 },
                    { 9, 125.36, new DateTime(2024, 12, 10, 23, 19, 2, 117, DateTimeKind.Local).AddTicks(9543), 0, 8, 1 },
                    { 10, 258.75999999999999, new DateTime(2024, 12, 9, 16, 20, 44, 608, DateTimeKind.Local).AddTicks(1671), 0, 91, 0 },
                    { 11, 734.27999999999997, new DateTime(2024, 11, 29, 1, 59, 19, 683, DateTimeKind.Local).AddTicks(7613), 0, 75, 1 },
                    { 12, 172.69, new DateTime(2024, 11, 25, 10, 48, 29, 115, DateTimeKind.Local).AddTicks(5667), 1, 83, 0 },
                    { 13, 129.37, new DateTime(2024, 12, 5, 9, 5, 7, 443, DateTimeKind.Local).AddTicks(1913), 0, 52, 1 },
                    { 14, 372.94, new DateTime(2024, 12, 9, 15, 49, 33, 867, DateTimeKind.Local).AddTicks(2888), 0, 27, 1 },
                    { 15, 147.28999999999999, new DateTime(2024, 12, 3, 2, 31, 41, 754, DateTimeKind.Local).AddTicks(5371), 0, 50, 0 },
                    { 16, 247.19, new DateTime(2024, 11, 22, 7, 11, 29, 947, DateTimeKind.Local).AddTicks(6491), 0, 10, 1 },
                    { 17, 760.49000000000001, new DateTime(2024, 11, 27, 2, 55, 2, 916, DateTimeKind.Local).AddTicks(2506), 0, 21, 0 },
                    { 18, 85.599999999999994, new DateTime(2024, 11, 18, 11, 0, 6, 713, DateTimeKind.Local).AddTicks(7206), 1, 48, 1 },
                    { 19, 716.92999999999995, new DateTime(2024, 11, 20, 21, 30, 26, 740, DateTimeKind.Local).AddTicks(9527), 1, 97, 1 },
                    { 20, 776.63999999999999, new DateTime(2024, 11, 22, 5, 50, 15, 41, DateTimeKind.Local).AddTicks(7851), 0, 17, 1 },
                    { 21, 796.32000000000005, new DateTime(2024, 12, 7, 6, 12, 52, 166, DateTimeKind.Local).AddTicks(3816), 1, 16, 0 },
                    { 22, 846.33000000000004, new DateTime(2024, 12, 17, 0, 9, 56, 299, DateTimeKind.Local).AddTicks(3685), 1, 4, 1 },
                    { 23, 794.16999999999996, new DateTime(2024, 12, 12, 9, 40, 39, 871, DateTimeKind.Local).AddTicks(9780), 1, 37, 1 },
                    { 24, 319.06, new DateTime(2024, 11, 20, 23, 46, 19, 263, DateTimeKind.Local).AddTicks(5814), 1, 69, 1 },
                    { 25, 919.65999999999997, new DateTime(2024, 12, 15, 2, 2, 23, 495, DateTimeKind.Local).AddTicks(8112), 1, 3, 1 },
                    { 26, 880.17999999999995, new DateTime(2024, 12, 10, 16, 3, 41, 140, DateTimeKind.Local).AddTicks(7647), 1, 88, 1 },
                    { 27, 306.19, new DateTime(2024, 12, 10, 2, 37, 48, 433, DateTimeKind.Local).AddTicks(7164), 1, 39, 0 },
                    { 28, 731.20000000000005, new DateTime(2024, 12, 8, 6, 22, 26, 641, DateTimeKind.Local).AddTicks(7194), 0, 44, 0 },
                    { 29, 390.16000000000003, new DateTime(2024, 11, 20, 14, 29, 19, 7, DateTimeKind.Local).AddTicks(7585), 0, 32, 1 },
                    { 30, 559.11000000000001, new DateTime(2024, 11, 19, 15, 40, 0, 88, DateTimeKind.Local).AddTicks(2482), 1, 74, 1 },
                    { 31, 892.61000000000001, new DateTime(2024, 11, 19, 10, 34, 57, 746, DateTimeKind.Local).AddTicks(1678), 0, 44, 0 },
                    { 32, 256.49000000000001, new DateTime(2024, 12, 11, 6, 13, 15, 719, DateTimeKind.Local).AddTicks(7566), 0, 15, 0 },
                    { 33, 639.57000000000005, new DateTime(2024, 12, 1, 1, 14, 19, 574, DateTimeKind.Local).AddTicks(4526), 1, 1, 0 },
                    { 34, 197.66, new DateTime(2024, 11, 19, 9, 38, 0, 100, DateTimeKind.Local).AddTicks(178), 0, 76, 0 },
                    { 35, 769.46000000000004, new DateTime(2024, 11, 29, 19, 51, 57, 576, DateTimeKind.Local).AddTicks(150), 1, 74, 0 },
                    { 36, 745.94000000000005, new DateTime(2024, 11, 27, 12, 20, 7, 384, DateTimeKind.Local).AddTicks(5293), 0, 68, 1 },
                    { 37, 503.72000000000003, new DateTime(2024, 12, 10, 13, 59, 54, 840, DateTimeKind.Local).AddTicks(4571), 0, 15, 1 },
                    { 38, 823.87, new DateTime(2024, 11, 29, 18, 23, 51, 538, DateTimeKind.Local).AddTicks(8939), 0, 13, 0 },
                    { 39, 929.76999999999998, new DateTime(2024, 12, 1, 16, 47, 15, 516, DateTimeKind.Local).AddTicks(4236), 1, 46, 1 },
                    { 40, 774.82000000000005, new DateTime(2024, 12, 12, 23, 9, 18, 454, DateTimeKind.Local).AddTicks(5775), 1, 32, 0 },
                    { 41, 901.09000000000003, new DateTime(2024, 12, 9, 10, 59, 24, 232, DateTimeKind.Local).AddTicks(4419), 1, 21, 1 },
                    { 42, 333.5, new DateTime(2024, 12, 11, 21, 15, 7, 592, DateTimeKind.Local).AddTicks(9432), 0, 88, 1 },
                    { 43, 183.90000000000001, new DateTime(2024, 11, 24, 1, 29, 25, 539, DateTimeKind.Local).AddTicks(7066), 1, 10, 0 },
                    { 44, 568.67999999999995, new DateTime(2024, 12, 11, 3, 21, 10, 147, DateTimeKind.Local).AddTicks(6186), 1, 75, 1 },
                    { 45, 409.66000000000003, new DateTime(2024, 12, 11, 18, 47, 7, 173, DateTimeKind.Local).AddTicks(8422), 1, 38, 1 },
                    { 46, 478.24000000000001, new DateTime(2024, 11, 21, 5, 57, 4, 877, DateTimeKind.Local).AddTicks(9730), 1, 23, 0 },
                    { 47, 176.74000000000001, new DateTime(2024, 11, 28, 20, 48, 36, 717, DateTimeKind.Local).AddTicks(3898), 0, 40, 0 },
                    { 48, 237.18000000000001, new DateTime(2024, 11, 19, 3, 31, 54, 463, DateTimeKind.Local).AddTicks(8102), 1, 66, 0 },
                    { 49, 445.79000000000002, new DateTime(2024, 12, 16, 20, 42, 5, 882, DateTimeKind.Local).AddTicks(3044), 1, 53, 0 },
                    { 50, 654.78999999999996, new DateTime(2024, 11, 18, 10, 20, 45, 229, DateTimeKind.Local).AddTicks(992), 0, 22, 0 },
                    { 51, 290.66000000000003, new DateTime(2024, 12, 13, 11, 37, 48, 449, DateTimeKind.Local).AddTicks(6849), 0, 24, 0 },
                    { 52, 261.19999999999999, new DateTime(2024, 12, 16, 2, 23, 40, 875, DateTimeKind.Local).AddTicks(5104), 0, 21, 0 },
                    { 53, 470.14999999999998, new DateTime(2024, 11, 27, 19, 18, 43, 176, DateTimeKind.Local).AddTicks(2706), 0, 33, 0 },
                    { 54, 489.5, new DateTime(2024, 11, 29, 5, 56, 28, 501, DateTimeKind.Local).AddTicks(2167), 0, 95, 0 },
                    { 55, 685.75, new DateTime(2024, 12, 1, 4, 29, 49, 457, DateTimeKind.Local).AddTicks(1341), 1, 72, 1 },
                    { 56, 590.86000000000001, new DateTime(2024, 11, 26, 18, 3, 40, 304, DateTimeKind.Local).AddTicks(7400), 1, 6, 0 },
                    { 57, 564.51999999999998, new DateTime(2024, 11, 28, 4, 47, 44, 318, DateTimeKind.Local).AddTicks(3538), 1, 49, 1 },
                    { 58, 577.33000000000004, new DateTime(2024, 12, 14, 2, 30, 14, 365, DateTimeKind.Local).AddTicks(6038), 0, 56, 0 },
                    { 59, 889.47000000000003, new DateTime(2024, 11, 22, 14, 6, 35, 542, DateTimeKind.Local).AddTicks(3743), 1, 93, 0 },
                    { 60, 222.87, new DateTime(2024, 12, 10, 6, 6, 20, 630, DateTimeKind.Local).AddTicks(3711), 1, 5, 0 },
                    { 61, 327.48000000000002, new DateTime(2024, 12, 6, 16, 45, 52, 925, DateTimeKind.Local).AddTicks(5529), 0, 18, 0 },
                    { 62, 843.34000000000003, new DateTime(2024, 11, 23, 20, 2, 26, 871, DateTimeKind.Local).AddTicks(8), 0, 13, 1 },
                    { 63, 682.78999999999996, new DateTime(2024, 12, 1, 8, 13, 33, 383, DateTimeKind.Local).AddTicks(9092), 1, 47, 1 },
                    { 64, 398.56999999999999, new DateTime(2024, 11, 23, 1, 59, 8, 125, DateTimeKind.Local).AddTicks(6257), 0, 14, 1 },
                    { 65, 623.46000000000004, new DateTime(2024, 11, 22, 1, 6, 43, 140, DateTimeKind.Local).AddTicks(3976), 1, 61, 0 },
                    { 66, 199.15000000000001, new DateTime(2024, 12, 13, 14, 0, 24, 598, DateTimeKind.Local).AddTicks(3057), 0, 6, 0 },
                    { 67, 734.85000000000002, new DateTime(2024, 11, 24, 11, 49, 38, 293, DateTimeKind.Local).AddTicks(172), 1, 6, 1 },
                    { 68, 929.69000000000005, new DateTime(2024, 12, 1, 21, 35, 37, 115, DateTimeKind.Local).AddTicks(5006), 1, 23, 1 },
                    { 69, 896.27999999999997, new DateTime(2024, 11, 17, 22, 32, 28, 46, DateTimeKind.Local).AddTicks(7686), 1, 87, 1 },
                    { 70, 505.75999999999999, new DateTime(2024, 12, 11, 6, 27, 56, 252, DateTimeKind.Local).AddTicks(9674), 0, 76, 0 },
                    { 71, 159.86000000000001, new DateTime(2024, 11, 25, 18, 55, 33, 591, DateTimeKind.Local).AddTicks(4941), 0, 14, 0 },
                    { 72, 667.75, new DateTime(2024, 12, 9, 19, 33, 18, 790, DateTimeKind.Local).AddTicks(3059), 1, 55, 1 },
                    { 73, 956.14999999999998, new DateTime(2024, 12, 5, 6, 56, 27, 678, DateTimeKind.Local).AddTicks(2451), 0, 95, 0 },
                    { 74, 623.27999999999997, new DateTime(2024, 11, 20, 8, 58, 46, 911, DateTimeKind.Local).AddTicks(3171), 1, 24, 0 },
                    { 75, 716.91999999999996, new DateTime(2024, 11, 30, 0, 58, 4, 226, DateTimeKind.Local).AddTicks(6056), 0, 9, 1 },
                    { 76, 399.06999999999999, new DateTime(2024, 12, 1, 11, 42, 47, 749, DateTimeKind.Local).AddTicks(5797), 0, 56, 0 },
                    { 77, 296.13, new DateTime(2024, 12, 11, 9, 45, 59, 35, DateTimeKind.Local).AddTicks(8472), 1, 79, 0 },
                    { 78, 365.92000000000002, new DateTime(2024, 11, 18, 7, 36, 9, 683, DateTimeKind.Local).AddTicks(3297), 1, 91, 0 },
                    { 79, 785.86000000000001, new DateTime(2024, 11, 21, 19, 10, 10, 46, DateTimeKind.Local).AddTicks(5371), 1, 48, 0 },
                    { 80, 91.489999999999995, new DateTime(2024, 12, 10, 16, 47, 46, 852, DateTimeKind.Local).AddTicks(8556), 0, 75, 1 }
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
