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
                    { 1, "admin@hotel.com", "admin", "admin", "$2a$11$h49I6ZaNinQT3oC.sfnj1.W398sce05FSEOufqzbMjxMO74Dz9FSi", "0600000000", 0 },
                    { 2, "Francesca.Hegmann10@gmail.com", "Jacynthe", "Thompson", "$2a$11$Zw3kLIG1DRxbTTLSCk9uzuPSJVHtzQ2H9wdCqfL6yMsauCJcrWTG.", "925.950.0539 x7594", 0 },
                    { 3, "Juana.Halvorson@hotmail.com", "Alejandrin", "Jast", "$2a$11$FslkTUNgQODc8YEwkdg5wO7L5ZrGKRnGnT5pLDRcjvDX30ixrMJzK", "581.235.8087", 2 },
                    { 4, "Kiera.Walker45@hotmail.com", "Layla", "Miller", "$2a$11$dRXSkBWbx.JvUPWkdcxtR.MZoX05IWR1kUjrwa28CjQc1UGnBv2K.", "(586) 928-4691", 2 },
                    { 5, "Destany68@gmail.com", "Velva", "Jast", "$2a$11$9o/SlnWeaSf/dJnW.FHgceMyIYD18Eb4AI8UIomCxSngiZMWcARVW", "(504) 421-7449", 2 },
                    { 6, "Rosemary_Fahey35@yahoo.com", "Dorothea", "Bartell", "$2a$11$ni1GdrXtXK0aBdgCEPlBxuF8wQBt3tjQ9V9bTH/TxWTzxXzziiz3C", "555-846-6582", 0 },
                    { 7, "Eliezer.Considine@gmail.com", "Reid", "Sipes", "$2a$11$imGcz8czX2bOP1YBdX.G3O0iTS9YV8XcFdMzsI8j7KG.paF2cVQ9m", "1-714-400-0694 x4424", 1 },
                    { 8, "Flavio.Wehner@yahoo.com", "Marianna", "Little", "$2a$11$y9BF/NQWckFQ.q9yHRxAaetiNRq40m9zOlCdZ63izMfycpy9r/KcK", "(420) 381-3210 x08234", 1 },
                    { 9, "Elvis_Kilback41@gmail.com", "Francisco", "Rippin", "$2a$11$1d4BLraQzaDXgsBpn2.KYuaEDjCQJRhW4qIsBFqHSC0Vv6zBbxabm", "922-835-2155 x19657", 2 },
                    { 10, "Felicity_Kautzer@gmail.com", "Isobel", "Kassulke", "$2a$11$SKesf8BNJJLxEcaeVzPLieOKstJEYw0K9weWtnfDh6LbEbhsDOepC", "1-508-285-4397 x653", 2 },
                    { 11, "Robyn_Ledner33@yahoo.com", "Liza", "Wilderman", "$2a$11$WmlmAf1zO5uUPBGm8XV33.9lMBa32OhBRJiM/xFiCstbjesBm3cse", "876.828.6931 x3351", 0 },
                    { 12, "Katelyn.Ebert37@gmail.com", "Margarett", "Erdman", "$2a$11$nYwVboCOU5q18gChKRth2.Aoj1YyiQP8rQAF6s29sS6Qxs8DYvMxu", "1-246-737-4084 x42090", 1 },
                    { 13, "Alanna.Schaden32@gmail.com", "Gregory", "Nikolaus", "$2a$11$M0LwxdL1AEfB3reFGJDzlOnN1i/dMkgRIAguBfW1t3EI1T0jwcGJC", "(947) 245-6543 x785", 2 },
                    { 14, "Norris.OConnell@hotmail.com", "Rogelio", "Rohan", "$2a$11$tRJDxtUaoXN/iIU0.5eIgeLA23xbKPB6V2EX5qF0EBErIC7e2MHUO", "1-447-958-9153 x546", 1 },
                    { 15, "Katlynn_Considine@yahoo.com", "Jack", "Frami", "$2a$11$t5Yy/8kv3qu.O3dBcHWBne2LdNLie.o0nT/ywdCjbb7M79jR3gHmq", "585-443-1437", 2 },
                    { 16, "Blair.Cassin@yahoo.com", "Ottilie", "Schumm", "$2a$11$qtbjKZ58WaNzx5HInygimOxFgg70ay8zzTxWfa2jzNAUej1tkNQHm", "486-220-4238", 2 },
                    { 17, "Marquis.Schuppe22@yahoo.com", "Rebecca", "Friesen", "$2a$11$BG6q3hhQCPZ9IMdyI5kAheW1bKMRZ936GCwaHVWH5Zbb4iX46nuhy", "1-588-366-5331 x294", 2 },
                    { 18, "Rhea.McCullough@hotmail.com", "Karelle", "Thompson", "$2a$11$pepDWh/gQ9E9ybnVWbbwl.fgMxLRDeIdJ0sVf.wtttzZpGlBZO36u", "1-490-424-8233", 0 },
                    { 19, "Kiana.Feil@gmail.com", "Mercedes", "Ledner", "$2a$11$SuxIdIJnZ.MnLd0GiGY7TOrcGFzeafrEJWUj8Rn1fNkvN8q70mbh2", "556.296.5543", 0 },
                    { 20, "Zachery.Jacobi14@gmail.com", "Viola", "Franecki", "$2a$11$HSIt8ic.DqldPL6mpIRbI.BQkSYk.FSSV0vCs7Yy6vdyJcOk9DNfq", "260-228-1168 x0149", 0 },
                    { 21, "Max_Bruen93@yahoo.com", "Lonnie", "Gutkowski", "$2a$11$.dYyuBybL/9u8dfx.Fe83udPvgM30z4mNfzn/Ap3suP39NkmiD/B2", "892.340.0578", 2 },
                    { 22, "Hassan.Robel@gmail.com", "Kailey", "Littel", "$2a$11$/P9bzKZUUjfqJwP1GSruTu94w8SAK2JQMBQGs5a9qEbIzSkwLh1u6", "217-617-6776", 2 },
                    { 23, "Darryl43@hotmail.com", "Romaine", "Cassin", "$2a$11$MyeViuninOq60RxJGjBOS.u7uMbKqElUpYDjz8lowRRpca.mx5lB2", "410.577.8574 x6107", 0 },
                    { 24, "Mitchel.Cormier@gmail.com", "Ambrose", "Robel", "$2a$11$DPhaV0CC.xBrynvZc78WfuMo/Q96fxG8wN8ip5CkQQY./Wzu3/oTa", "1-844-707-1352", 2 },
                    { 25, "Heber_Wolf@gmail.com", "Coy", "Adams", "$2a$11$FQ5UvHMzgUkykCi2WZpXxOzCepYU3gXHRcgkNt2AODcf0PVUSFqvm", "(467) 615-1266 x5068", 1 },
                    { 26, "Darien76@gmail.com", "Darrick", "Dietrich", "$2a$11$wKKsIFPVXrSx5vXw4FisvOyCoNhogB9f2HJO1EUH0beYyTWHM2KCq", "1-924-543-0409", 0 }
                });

            migrationBuilder.InsertData(
                table: "Room",
                columns: new[] { "Id", "Capacity", "IsAvailable", "Name", "Price", "RoomTypeId" },
                values: new object[,]
                {
                    { 1, 6, true, "Room 211", 50.0, 1 },
                    { 2, 1, true, "Room 483", 766.0, 3 },
                    { 3, 10, true, "Room 180", 312.0, 2 },
                    { 4, 2, true, "Room 236", 489.0, 1 },
                    { 5, 9, true, "Room 296", 533.0, 1 },
                    { 6, 6, true, "Room 360", 738.0, 3 },
                    { 7, 7, false, "Room 446", 781.0, 2 },
                    { 8, 1, false, "Room 398", 586.0, 1 },
                    { 9, 6, true, "Room 322", 556.0, 3 },
                    { 10, 6, true, "Room 120", 273.0, 1 },
                    { 11, 5, false, "Room 483", 815.0, 1 },
                    { 12, 6, false, "Room 399", 787.0, 2 },
                    { 13, 8, false, "Room 333", 893.0, 1 },
                    { 14, 9, false, "Room 243", 68.0, 1 },
                    { 15, 8, true, "Room 199", 448.0, 1 },
                    { 16, 4, false, "Room 418", 265.0, 3 },
                    { 17, 6, false, "Room 138", 829.0, 2 },
                    { 18, 9, false, "Room 383", 130.0, 3 },
                    { 19, 5, false, "Room 179", 592.0, 3 },
                    { 20, 4, true, "Room 319", 284.0, 2 },
                    { 21, 2, true, "Room 125", 76.0, 1 },
                    { 22, 6, true, "Room 373", 341.0, 3 },
                    { 23, 1, true, "Room 436", 638.0, 3 },
                    { 24, 4, false, "Room 109", 741.0, 3 },
                    { 25, 4, true, "Room 277", 403.0, 3 },
                    { 26, 10, false, "Room 391", 194.0, 2 },
                    { 27, 6, false, "Room 121", 664.0, 1 },
                    { 28, 5, false, "Room 284", 50.0, 3 },
                    { 29, 10, false, "Room 369", 763.0, 2 },
                    { 30, 8, false, "Room 374", 979.0, 2 },
                    { 31, 1, false, "Room 424", 739.0, 1 },
                    { 32, 3, false, "Room 487", 684.0, 1 },
                    { 33, 10, false, "Room 500", 574.0, 3 },
                    { 34, 3, false, "Room 169", 609.0, 1 },
                    { 35, 7, false, "Room 308", 686.0, 1 },
                    { 36, 10, false, "Room 266", 713.0, 2 },
                    { 37, 8, false, "Room 179", 441.0, 3 },
                    { 38, 3, true, "Room 297", 616.0, 2 },
                    { 39, 8, true, "Room 178", 216.0, 1 },
                    { 40, 6, false, "Room 117", 544.0, 2 },
                    { 41, 8, false, "Room 236", 177.0, 2 },
                    { 42, 6, true, "Room 130", 486.0, 2 },
                    { 43, 1, false, "Room 102", 759.0, 1 },
                    { 44, 1, true, "Room 145", 253.0, 1 },
                    { 45, 6, true, "Room 126", 471.0, 3 },
                    { 46, 10, true, "Room 119", 968.0, 2 },
                    { 47, 6, true, "Room 123", 720.0, 1 },
                    { 48, 8, false, "Room 390", 535.0, 2 },
                    { 49, 9, false, "Room 444", 182.0, 3 },
                    { 50, 4, false, "Room 157", 332.0, 3 }
                });

            migrationBuilder.InsertData(
                table: "Reservation",
                columns: new[] { "Id", "CheckInDate", "CheckOutDate", "RoomId", "Status", "TotalPrice", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 11, 20, 21, 8, 10, 929, DateTimeKind.Local).AddTicks(1344), new DateTime(2024, 11, 22, 21, 8, 10, 929, DateTimeKind.Local).AddTicks(1344), 31, 1, 3116.0, 7 },
                    { 2, new DateTime(2024, 12, 12, 15, 42, 25, 689, DateTimeKind.Local).AddTicks(3281), new DateTime(2024, 12, 16, 15, 42, 25, 689, DateTimeKind.Local).AddTicks(3281), 11, 0, 2096.0, 6 },
                    { 3, new DateTime(2025, 1, 3, 3, 30, 25, 525, DateTimeKind.Local).AddTicks(764), new DateTime(2025, 1, 12, 3, 30, 25, 525, DateTimeKind.Local).AddTicks(764), 25, 0, 2095.0, 10 },
                    { 4, new DateTime(2024, 11, 22, 4, 41, 24, 112, DateTimeKind.Local).AddTicks(1780), new DateTime(2024, 11, 24, 4, 41, 24, 112, DateTimeKind.Local).AddTicks(1780), 8, 0, 3501.0, 10 },
                    { 5, new DateTime(2025, 1, 1, 2, 47, 10, 715, DateTimeKind.Local).AddTicks(6178), new DateTime(2025, 1, 3, 2, 47, 10, 715, DateTimeKind.Local).AddTicks(6178), 45, 0, 2573.0, 1 },
                    { 6, new DateTime(2025, 1, 4, 3, 24, 7, 932, DateTimeKind.Local).AddTicks(1922), new DateTime(2025, 1, 12, 3, 24, 7, 932, DateTimeKind.Local).AddTicks(1922), 33, 1, 741.0, 4 },
                    { 7, new DateTime(2024, 12, 9, 1, 35, 24, 587, DateTimeKind.Local).AddTicks(785), new DateTime(2024, 12, 18, 1, 35, 24, 587, DateTimeKind.Local).AddTicks(785), 21, 0, 2325.0, 8 },
                    { 8, new DateTime(2025, 1, 11, 13, 1, 3, 103, DateTimeKind.Local).AddTicks(6947), new DateTime(2025, 1, 13, 13, 1, 3, 103, DateTimeKind.Local).AddTicks(6947), 5, 0, 1961.0, 1 },
                    { 9, new DateTime(2024, 12, 3, 12, 23, 13, 895, DateTimeKind.Local).AddTicks(3790), new DateTime(2024, 12, 12, 12, 23, 13, 895, DateTimeKind.Local).AddTicks(3790), 21, 1, 4112.0, 7 },
                    { 10, new DateTime(2025, 1, 9, 9, 48, 46, 528, DateTimeKind.Local).AddTicks(8918), new DateTime(2025, 1, 11, 9, 48, 46, 528, DateTimeKind.Local).AddTicks(8918), 8, 2, 3057.0, 3 },
                    { 11, new DateTime(2025, 1, 3, 10, 13, 49, 110, DateTimeKind.Local).AddTicks(9840), new DateTime(2025, 1, 7, 10, 13, 49, 110, DateTimeKind.Local).AddTicks(9840), 18, 0, 4765.0, 1 },
                    { 12, new DateTime(2024, 12, 14, 5, 49, 3, 981, DateTimeKind.Local).AddTicks(6835), new DateTime(2024, 12, 22, 5, 49, 3, 981, DateTimeKind.Local).AddTicks(6835), 17, 2, 168.0, 8 },
                    { 13, new DateTime(2024, 11, 28, 18, 25, 48, 920, DateTimeKind.Local).AddTicks(4729), new DateTime(2024, 12, 5, 18, 25, 48, 920, DateTimeKind.Local).AddTicks(4729), 8, 1, 3387.0, 7 },
                    { 14, new DateTime(2024, 12, 4, 22, 52, 46, 972, DateTimeKind.Local).AddTicks(8859), new DateTime(2024, 12, 11, 22, 52, 46, 972, DateTimeKind.Local).AddTicks(8859), 21, 1, 2923.0, 3 },
                    { 15, new DateTime(2024, 12, 1, 10, 40, 52, 104, DateTimeKind.Local).AddTicks(3451), new DateTime(2024, 12, 4, 10, 40, 52, 104, DateTimeKind.Local).AddTicks(3451), 33, 2, 3363.0, 2 },
                    { 16, new DateTime(2024, 12, 15, 17, 8, 22, 880, DateTimeKind.Local).AddTicks(8433), new DateTime(2024, 12, 17, 17, 8, 22, 880, DateTimeKind.Local).AddTicks(8433), 4, 2, 3823.0, 5 },
                    { 17, new DateTime(2025, 1, 5, 12, 18, 32, 324, DateTimeKind.Local).AddTicks(4663), new DateTime(2025, 1, 6, 12, 18, 32, 324, DateTimeKind.Local).AddTicks(4663), 9, 1, 3195.0, 6 },
                    { 18, new DateTime(2024, 11, 23, 8, 45, 50, 710, DateTimeKind.Local).AddTicks(5785), new DateTime(2024, 12, 3, 8, 45, 50, 710, DateTimeKind.Local).AddTicks(5785), 24, 1, 4021.0, 5 },
                    { 19, new DateTime(2024, 12, 15, 17, 48, 9, 139, DateTimeKind.Local).AddTicks(4940), new DateTime(2024, 12, 20, 17, 48, 9, 139, DateTimeKind.Local).AddTicks(4940), 38, 0, 644.0, 3 },
                    { 20, new DateTime(2024, 11, 30, 10, 31, 34, 485, DateTimeKind.Local).AddTicks(1868), new DateTime(2024, 12, 10, 10, 31, 34, 485, DateTimeKind.Local).AddTicks(1868), 48, 2, 1337.0, 4 },
                    { 21, new DateTime(2024, 11, 25, 13, 10, 8, 916, DateTimeKind.Local).AddTicks(6965), new DateTime(2024, 12, 5, 13, 10, 8, 916, DateTimeKind.Local).AddTicks(6965), 32, 0, 4746.0, 3 },
                    { 22, new DateTime(2024, 12, 25, 14, 31, 33, 170, DateTimeKind.Local).AddTicks(8738), new DateTime(2024, 12, 30, 14, 31, 33, 170, DateTimeKind.Local).AddTicks(8738), 17, 1, 4236.0, 7 },
                    { 23, new DateTime(2024, 11, 26, 6, 46, 17, 84, DateTimeKind.Local).AddTicks(7266), new DateTime(2024, 12, 1, 6, 46, 17, 84, DateTimeKind.Local).AddTicks(7266), 23, 2, 1203.0, 4 },
                    { 24, new DateTime(2025, 1, 2, 3, 11, 57, 469, DateTimeKind.Local).AddTicks(4829), new DateTime(2025, 1, 8, 3, 11, 57, 469, DateTimeKind.Local).AddTicks(4829), 13, 2, 2096.0, 10 },
                    { 25, new DateTime(2024, 12, 29, 15, 2, 22, 416, DateTimeKind.Local).AddTicks(3550), new DateTime(2025, 1, 4, 15, 2, 22, 416, DateTimeKind.Local).AddTicks(3550), 49, 0, 4389.0, 7 },
                    { 26, new DateTime(2024, 12, 16, 20, 11, 49, 849, DateTimeKind.Local).AddTicks(7530), new DateTime(2024, 12, 20, 20, 11, 49, 849, DateTimeKind.Local).AddTicks(7530), 42, 1, 232.0, 4 },
                    { 27, new DateTime(2024, 12, 1, 16, 33, 41, 954, DateTimeKind.Local).AddTicks(732), new DateTime(2024, 12, 11, 16, 33, 41, 954, DateTimeKind.Local).AddTicks(732), 5, 1, 4263.0, 3 },
                    { 28, new DateTime(2024, 12, 8, 4, 35, 22, 781, DateTimeKind.Local).AddTicks(1171), new DateTime(2024, 12, 13, 4, 35, 22, 781, DateTimeKind.Local).AddTicks(1171), 44, 0, 125.0, 8 },
                    { 29, new DateTime(2024, 12, 30, 2, 21, 53, 209, DateTimeKind.Local).AddTicks(7512), new DateTime(2025, 1, 5, 2, 21, 53, 209, DateTimeKind.Local).AddTicks(7512), 2, 1, 3167.0, 2 },
                    { 30, new DateTime(2024, 11, 24, 1, 50, 32, 241, DateTimeKind.Local).AddTicks(6261), new DateTime(2024, 11, 30, 1, 50, 32, 241, DateTimeKind.Local).AddTicks(6261), 47, 0, 2737.0, 9 },
                    { 31, new DateTime(2024, 12, 29, 13, 21, 47, 809, DateTimeKind.Local).AddTicks(2498), new DateTime(2025, 1, 8, 13, 21, 47, 809, DateTimeKind.Local).AddTicks(2498), 6, 0, 2887.0, 8 },
                    { 32, new DateTime(2024, 12, 4, 21, 41, 54, 297, DateTimeKind.Local).AddTicks(3900), new DateTime(2024, 12, 10, 21, 41, 54, 297, DateTimeKind.Local).AddTicks(3900), 44, 2, 899.0, 2 },
                    { 33, new DateTime(2025, 1, 9, 22, 25, 24, 218, DateTimeKind.Local).AddTicks(4184), new DateTime(2025, 1, 12, 22, 25, 24, 218, DateTimeKind.Local).AddTicks(4184), 36, 1, 817.0, 10 },
                    { 34, new DateTime(2025, 1, 3, 1, 1, 11, 994, DateTimeKind.Local).AddTicks(2025), new DateTime(2025, 1, 5, 1, 1, 11, 994, DateTimeKind.Local).AddTicks(2025), 11, 0, 2512.0, 8 },
                    { 35, new DateTime(2025, 1, 5, 19, 8, 38, 628, DateTimeKind.Local).AddTicks(6906), new DateTime(2025, 1, 13, 19, 8, 38, 628, DateTimeKind.Local).AddTicks(6906), 46, 1, 4350.0, 9 },
                    { 36, new DateTime(2024, 12, 10, 1, 32, 9, 364, DateTimeKind.Local).AddTicks(3680), new DateTime(2024, 12, 14, 1, 32, 9, 364, DateTimeKind.Local).AddTicks(3680), 18, 0, 4768.0, 7 },
                    { 37, new DateTime(2024, 12, 13, 5, 43, 29, 423, DateTimeKind.Local).AddTicks(1402), new DateTime(2024, 12, 23, 5, 43, 29, 423, DateTimeKind.Local).AddTicks(1402), 1, 2, 568.0, 1 },
                    { 38, new DateTime(2024, 12, 28, 14, 15, 35, 173, DateTimeKind.Local).AddTicks(5228), new DateTime(2025, 1, 5, 14, 15, 35, 173, DateTimeKind.Local).AddTicks(5228), 37, 1, 1572.0, 4 },
                    { 39, new DateTime(2024, 12, 27, 6, 31, 13, 234, DateTimeKind.Local).AddTicks(5409), new DateTime(2024, 12, 29, 6, 31, 13, 234, DateTimeKind.Local).AddTicks(5409), 17, 2, 650.0, 8 },
                    { 40, new DateTime(2024, 12, 25, 21, 7, 55, 163, DateTimeKind.Local).AddTicks(1922), new DateTime(2024, 12, 29, 21, 7, 55, 163, DateTimeKind.Local).AddTicks(1922), 35, 2, 1883.0, 7 },
                    { 41, new DateTime(2024, 12, 22, 12, 25, 25, 694, DateTimeKind.Local).AddTicks(2190), new DateTime(2024, 12, 26, 12, 25, 25, 694, DateTimeKind.Local).AddTicks(2190), 8, 1, 977.0, 5 },
                    { 42, new DateTime(2024, 11, 24, 9, 8, 34, 522, DateTimeKind.Local).AddTicks(115), new DateTime(2024, 12, 4, 9, 8, 34, 522, DateTimeKind.Local).AddTicks(115), 44, 1, 2522.0, 3 },
                    { 43, new DateTime(2024, 12, 30, 20, 17, 2, 64, DateTimeKind.Local).AddTicks(3229), new DateTime(2025, 1, 3, 20, 17, 2, 64, DateTimeKind.Local).AddTicks(3229), 8, 0, 1767.0, 6 },
                    { 44, new DateTime(2024, 12, 22, 10, 23, 12, 16, DateTimeKind.Local).AddTicks(6373), new DateTime(2025, 1, 1, 10, 23, 12, 16, DateTimeKind.Local).AddTicks(6373), 21, 0, 2615.0, 3 },
                    { 45, new DateTime(2024, 11, 19, 6, 16, 3, 463, DateTimeKind.Local).AddTicks(9427), new DateTime(2024, 11, 24, 6, 16, 3, 463, DateTimeKind.Local).AddTicks(9427), 12, 1, 4127.0, 4 },
                    { 46, new DateTime(2025, 1, 4, 8, 47, 33, 140, DateTimeKind.Local).AddTicks(8980), new DateTime(2025, 1, 11, 8, 47, 33, 140, DateTimeKind.Local).AddTicks(8980), 42, 2, 1550.0, 10 },
                    { 47, new DateTime(2025, 1, 9, 10, 21, 59, 284, DateTimeKind.Local).AddTicks(3883), new DateTime(2025, 1, 14, 10, 21, 59, 284, DateTimeKind.Local).AddTicks(3883), 1, 1, 4273.0, 6 },
                    { 48, new DateTime(2024, 12, 3, 22, 26, 11, 591, DateTimeKind.Local).AddTicks(5493), new DateTime(2024, 12, 12, 22, 26, 11, 591, DateTimeKind.Local).AddTicks(5493), 37, 2, 1696.0, 1 },
                    { 49, new DateTime(2025, 1, 11, 17, 54, 40, 106, DateTimeKind.Local).AddTicks(6423), new DateTime(2025, 1, 21, 17, 54, 40, 106, DateTimeKind.Local).AddTicks(6423), 21, 0, 2131.0, 2 },
                    { 50, new DateTime(2024, 12, 24, 15, 48, 52, 225, DateTimeKind.Local).AddTicks(7348), new DateTime(2024, 12, 25, 15, 48, 52, 225, DateTimeKind.Local).AddTicks(7348), 50, 2, 4861.0, 4 },
                    { 51, new DateTime(2025, 1, 1, 21, 4, 57, 751, DateTimeKind.Local).AddTicks(4152), new DateTime(2025, 1, 6, 21, 4, 57, 751, DateTimeKind.Local).AddTicks(4152), 8, 2, 675.0, 2 },
                    { 52, new DateTime(2024, 12, 30, 5, 29, 11, 61, DateTimeKind.Local).AddTicks(2467), new DateTime(2025, 1, 5, 5, 29, 11, 61, DateTimeKind.Local).AddTicks(2467), 44, 1, 1123.0, 8 },
                    { 53, new DateTime(2025, 1, 16, 10, 14, 4, 645, DateTimeKind.Local).AddTicks(294), new DateTime(2025, 1, 17, 10, 14, 4, 645, DateTimeKind.Local).AddTicks(294), 18, 1, 3680.0, 1 },
                    { 54, new DateTime(2024, 11, 21, 15, 4, 18, 788, DateTimeKind.Local).AddTicks(5163), new DateTime(2024, 11, 30, 15, 4, 18, 788, DateTimeKind.Local).AddTicks(5163), 26, 1, 3608.0, 6 },
                    { 55, new DateTime(2024, 12, 3, 21, 50, 13, 829, DateTimeKind.Local).AddTicks(4140), new DateTime(2024, 12, 11, 21, 50, 13, 829, DateTimeKind.Local).AddTicks(4140), 42, 0, 320.0, 5 },
                    { 56, new DateTime(2024, 11, 28, 6, 35, 12, 234, DateTimeKind.Local).AddTicks(4687), new DateTime(2024, 12, 2, 6, 35, 12, 234, DateTimeKind.Local).AddTicks(4687), 9, 0, 2856.0, 8 },
                    { 57, new DateTime(2025, 1, 1, 15, 7, 40, 655, DateTimeKind.Local).AddTicks(875), new DateTime(2025, 1, 2, 15, 7, 40, 655, DateTimeKind.Local).AddTicks(875), 1, 2, 222.0, 9 },
                    { 58, new DateTime(2024, 12, 10, 4, 19, 24, 355, DateTimeKind.Local).AddTicks(9204), new DateTime(2024, 12, 18, 4, 19, 24, 355, DateTimeKind.Local).AddTicks(9204), 17, 2, 2581.0, 3 },
                    { 59, new DateTime(2025, 1, 5, 3, 13, 49, 232, DateTimeKind.Local).AddTicks(7899), new DateTime(2025, 1, 7, 3, 13, 49, 232, DateTimeKind.Local).AddTicks(7899), 35, 2, 113.0, 1 },
                    { 60, new DateTime(2024, 12, 27, 18, 12, 50, 772, DateTimeKind.Local).AddTicks(3013), new DateTime(2024, 12, 31, 18, 12, 50, 772, DateTimeKind.Local).AddTicks(3013), 49, 0, 2262.0, 6 },
                    { 61, new DateTime(2024, 12, 19, 7, 52, 2, 707, DateTimeKind.Local).AddTicks(574), new DateTime(2024, 12, 20, 7, 52, 2, 707, DateTimeKind.Local).AddTicks(574), 15, 1, 4992.0, 10 },
                    { 62, new DateTime(2025, 1, 7, 19, 47, 34, 161, DateTimeKind.Local).AddTicks(8914), new DateTime(2025, 1, 11, 19, 47, 34, 161, DateTimeKind.Local).AddTicks(8914), 13, 0, 4869.0, 6 },
                    { 63, new DateTime(2024, 12, 31, 21, 36, 21, 978, DateTimeKind.Local).AddTicks(7241), new DateTime(2025, 1, 8, 21, 36, 21, 978, DateTimeKind.Local).AddTicks(7241), 48, 0, 3139.0, 4 },
                    { 64, new DateTime(2025, 1, 17, 15, 2, 49, 452, DateTimeKind.Local).AddTicks(2055), new DateTime(2025, 1, 27, 15, 2, 49, 452, DateTimeKind.Local).AddTicks(2055), 9, 2, 1845.0, 9 },
                    { 65, new DateTime(2024, 12, 19, 21, 6, 13, 519, DateTimeKind.Local).AddTicks(3600), new DateTime(2024, 12, 29, 21, 6, 13, 519, DateTimeKind.Local).AddTicks(3600), 21, 1, 1198.0, 2 },
                    { 66, new DateTime(2025, 1, 11, 9, 58, 17, 6, DateTimeKind.Local).AddTicks(8556), new DateTime(2025, 1, 16, 9, 58, 17, 6, DateTimeKind.Local).AddTicks(8556), 23, 1, 991.0, 9 },
                    { 67, new DateTime(2024, 12, 18, 7, 20, 44, 826, DateTimeKind.Local).AddTicks(2260), new DateTime(2024, 12, 19, 7, 20, 44, 826, DateTimeKind.Local).AddTicks(2260), 16, 1, 2011.0, 7 },
                    { 68, new DateTime(2025, 1, 17, 2, 30, 38, 30, DateTimeKind.Local).AddTicks(6486), new DateTime(2025, 1, 22, 2, 30, 38, 30, DateTimeKind.Local).AddTicks(6486), 22, 2, 380.0, 4 },
                    { 69, new DateTime(2024, 12, 7, 12, 28, 6, 586, DateTimeKind.Local).AddTicks(4339), new DateTime(2024, 12, 14, 12, 28, 6, 586, DateTimeKind.Local).AddTicks(4339), 35, 1, 3251.0, 1 },
                    { 70, new DateTime(2024, 12, 2, 20, 29, 18, 270, DateTimeKind.Local).AddTicks(8430), new DateTime(2024, 12, 11, 20, 29, 18, 270, DateTimeKind.Local).AddTicks(8430), 36, 1, 4589.0, 1 },
                    { 71, new DateTime(2024, 12, 10, 19, 27, 9, 190, DateTimeKind.Local).AddTicks(4192), new DateTime(2024, 12, 20, 19, 27, 9, 190, DateTimeKind.Local).AddTicks(4192), 9, 0, 2031.0, 9 },
                    { 72, new DateTime(2024, 12, 27, 5, 12, 5, 409, DateTimeKind.Local).AddTicks(7613), new DateTime(2024, 12, 31, 5, 12, 5, 409, DateTimeKind.Local).AddTicks(7613), 10, 2, 1727.0, 4 },
                    { 73, new DateTime(2024, 12, 7, 22, 19, 43, 276, DateTimeKind.Local).AddTicks(5465), new DateTime(2024, 12, 12, 22, 19, 43, 276, DateTimeKind.Local).AddTicks(5465), 13, 0, 4057.0, 7 },
                    { 74, new DateTime(2024, 11, 27, 15, 19, 0, 457, DateTimeKind.Local).AddTicks(5887), new DateTime(2024, 11, 28, 15, 19, 0, 457, DateTimeKind.Local).AddTicks(5887), 41, 1, 1352.0, 8 },
                    { 75, new DateTime(2024, 11, 24, 13, 28, 17, 431, DateTimeKind.Local).AddTicks(1962), new DateTime(2024, 11, 30, 13, 28, 17, 431, DateTimeKind.Local).AddTicks(1962), 16, 0, 546.0, 5 },
                    { 76, new DateTime(2024, 12, 14, 7, 12, 59, 423, DateTimeKind.Local).AddTicks(3052), new DateTime(2024, 12, 22, 7, 12, 59, 423, DateTimeKind.Local).AddTicks(3052), 13, 2, 4721.0, 5 },
                    { 77, new DateTime(2024, 12, 29, 21, 21, 45, 337, DateTimeKind.Local).AddTicks(2957), new DateTime(2025, 1, 1, 21, 21, 45, 337, DateTimeKind.Local).AddTicks(2957), 22, 1, 4582.0, 1 },
                    { 78, new DateTime(2024, 11, 23, 9, 45, 48, 848, DateTimeKind.Local).AddTicks(5957), new DateTime(2024, 11, 24, 9, 45, 48, 848, DateTimeKind.Local).AddTicks(5957), 9, 2, 2027.0, 3 },
                    { 79, new DateTime(2024, 11, 23, 8, 18, 42, 664, DateTimeKind.Local).AddTicks(6944), new DateTime(2024, 11, 30, 8, 18, 42, 664, DateTimeKind.Local).AddTicks(6944), 21, 2, 1000.0, 9 },
                    { 80, new DateTime(2024, 12, 21, 7, 46, 6, 634, DateTimeKind.Local).AddTicks(7473), new DateTime(2024, 12, 22, 7, 46, 6, 634, DateTimeKind.Local).AddTicks(7473), 47, 2, 1294.0, 4 },
                    { 81, new DateTime(2024, 12, 22, 15, 22, 1, 119, DateTimeKind.Local).AddTicks(8092), new DateTime(2024, 12, 28, 15, 22, 1, 119, DateTimeKind.Local).AddTicks(8092), 47, 0, 3539.0, 9 },
                    { 82, new DateTime(2024, 12, 30, 7, 46, 38, 753, DateTimeKind.Local).AddTicks(60), new DateTime(2025, 1, 3, 7, 46, 38, 753, DateTimeKind.Local).AddTicks(60), 2, 1, 1548.0, 3 },
                    { 83, new DateTime(2024, 12, 14, 23, 46, 48, 656, DateTimeKind.Local).AddTicks(9681), new DateTime(2024, 12, 21, 23, 46, 48, 656, DateTimeKind.Local).AddTicks(9681), 26, 1, 4939.0, 8 },
                    { 84, new DateTime(2024, 11, 29, 18, 14, 59, 68, DateTimeKind.Local).AddTicks(8645), new DateTime(2024, 12, 6, 18, 14, 59, 68, DateTimeKind.Local).AddTicks(8645), 28, 0, 3663.0, 6 },
                    { 85, new DateTime(2024, 12, 27, 19, 32, 6, 67, DateTimeKind.Local).AddTicks(3673), new DateTime(2025, 1, 4, 19, 32, 6, 67, DateTimeKind.Local).AddTicks(3673), 30, 0, 1458.0, 8 },
                    { 86, new DateTime(2024, 11, 26, 20, 0, 18, 796, DateTimeKind.Local).AddTicks(50), new DateTime(2024, 11, 30, 20, 0, 18, 796, DateTimeKind.Local).AddTicks(50), 18, 0, 1945.0, 8 },
                    { 87, new DateTime(2024, 11, 26, 5, 9, 16, 249, DateTimeKind.Local).AddTicks(9057), new DateTime(2024, 12, 3, 5, 9, 16, 249, DateTimeKind.Local).AddTicks(9057), 16, 1, 3381.0, 3 },
                    { 88, new DateTime(2024, 12, 30, 16, 10, 7, 82, DateTimeKind.Local).AddTicks(7993), new DateTime(2025, 1, 5, 16, 10, 7, 82, DateTimeKind.Local).AddTicks(7993), 17, 0, 1396.0, 9 },
                    { 89, new DateTime(2024, 11, 20, 2, 52, 33, 643, DateTimeKind.Local).AddTicks(1940), new DateTime(2024, 11, 30, 2, 52, 33, 643, DateTimeKind.Local).AddTicks(1940), 50, 1, 599.0, 1 },
                    { 90, new DateTime(2024, 12, 29, 5, 14, 37, 964, DateTimeKind.Local).AddTicks(9731), new DateTime(2025, 1, 5, 5, 14, 37, 964, DateTimeKind.Local).AddTicks(9731), 38, 1, 936.0, 9 },
                    { 91, new DateTime(2024, 12, 12, 6, 33, 11, 726, DateTimeKind.Local).AddTicks(7918), new DateTime(2024, 12, 20, 6, 33, 11, 726, DateTimeKind.Local).AddTicks(7918), 35, 1, 208.0, 6 },
                    { 92, new DateTime(2025, 1, 2, 1, 16, 53, 282, DateTimeKind.Local).AddTicks(9313), new DateTime(2025, 1, 4, 1, 16, 53, 282, DateTimeKind.Local).AddTicks(9313), 48, 0, 1963.0, 9 },
                    { 93, new DateTime(2024, 12, 19, 20, 45, 13, 122, DateTimeKind.Local).AddTicks(9103), new DateTime(2024, 12, 24, 20, 45, 13, 122, DateTimeKind.Local).AddTicks(9103), 24, 0, 3302.0, 1 },
                    { 94, new DateTime(2024, 11, 27, 13, 14, 51, 634, DateTimeKind.Local).AddTicks(2696), new DateTime(2024, 12, 3, 13, 14, 51, 634, DateTimeKind.Local).AddTicks(2696), 23, 2, 1198.0, 6 },
                    { 95, new DateTime(2024, 11, 26, 6, 45, 12, 428, DateTimeKind.Local).AddTicks(2419), new DateTime(2024, 12, 6, 6, 45, 12, 428, DateTimeKind.Local).AddTicks(2419), 1, 0, 4224.0, 4 },
                    { 96, new DateTime(2024, 12, 9, 15, 18, 10, 818, DateTimeKind.Local).AddTicks(1030), new DateTime(2024, 12, 13, 15, 18, 10, 818, DateTimeKind.Local).AddTicks(1030), 30, 2, 4900.0, 8 },
                    { 97, new DateTime(2024, 12, 4, 11, 43, 23, 645, DateTimeKind.Local).AddTicks(3425), new DateTime(2024, 12, 14, 11, 43, 23, 645, DateTimeKind.Local).AddTicks(3425), 35, 2, 4655.0, 8 },
                    { 98, new DateTime(2025, 1, 13, 1, 1, 59, 30, DateTimeKind.Local).AddTicks(3124), new DateTime(2025, 1, 21, 1, 1, 59, 30, DateTimeKind.Local).AddTicks(3124), 5, 1, 4638.0, 2 },
                    { 99, new DateTime(2025, 1, 4, 13, 5, 3, 37, DateTimeKind.Local).AddTicks(962), new DateTime(2025, 1, 13, 13, 5, 3, 37, DateTimeKind.Local).AddTicks(962), 48, 1, 2335.0, 6 },
                    { 100, new DateTime(2025, 1, 9, 11, 17, 3, 390, DateTimeKind.Local).AddTicks(9412), new DateTime(2025, 1, 11, 11, 17, 3, 390, DateTimeKind.Local).AddTicks(9412), 49, 1, 3613.0, 7 }
                });

            migrationBuilder.InsertData(
                table: "Payment",
                columns: new[] { "Id", "Amount", "PaymentDate", "PaymentMethod", "ReservationId", "Status" },
                values: new object[,]
                {
                    { 1, 213.72, new DateTime(2024, 11, 29, 10, 31, 58, 470, DateTimeKind.Local).AddTicks(3515), 1, 60, 0 },
                    { 2, 525.38, new DateTime(2024, 12, 9, 18, 50, 59, 326, DateTimeKind.Local).AddTicks(5136), 1, 74, 1 },
                    { 3, 188.49000000000001, new DateTime(2024, 11, 22, 15, 6, 16, 745, DateTimeKind.Local).AddTicks(455), 0, 98, 0 },
                    { 4, 842.48000000000002, new DateTime(2024, 12, 10, 23, 57, 45, 795, DateTimeKind.Local).AddTicks(6319), 1, 100, 1 },
                    { 5, 131.96000000000001, new DateTime(2024, 11, 21, 3, 46, 7, 498, DateTimeKind.Local).AddTicks(4130), 0, 9, 0 },
                    { 6, 213.84, new DateTime(2024, 12, 13, 19, 11, 52, 594, DateTimeKind.Local).AddTicks(876), 0, 85, 0 },
                    { 7, 902.16999999999996, new DateTime(2024, 12, 2, 15, 39, 14, 208, DateTimeKind.Local).AddTicks(4136), 0, 66, 0 },
                    { 8, 793.45000000000005, new DateTime(2024, 12, 3, 2, 7, 9, 930, DateTimeKind.Local).AddTicks(9429), 1, 35, 0 },
                    { 9, 456.91000000000003, new DateTime(2024, 12, 11, 21, 16, 20, 541, DateTimeKind.Local).AddTicks(3148), 1, 31, 1 },
                    { 10, 253.38, new DateTime(2024, 11, 27, 8, 28, 38, 695, DateTimeKind.Local).AddTicks(5010), 1, 62, 0 },
                    { 11, 174.84, new DateTime(2024, 12, 16, 2, 5, 13, 527, DateTimeKind.Local).AddTicks(7451), 1, 98, 0 },
                    { 12, 226.77000000000001, new DateTime(2024, 11, 26, 23, 8, 20, 530, DateTimeKind.Local).AddTicks(2502), 1, 11, 0 },
                    { 13, 872.22000000000003, new DateTime(2024, 12, 3, 16, 23, 46, 737, DateTimeKind.Local).AddTicks(983), 0, 42, 1 },
                    { 14, 200.41999999999999, new DateTime(2024, 12, 8, 20, 11, 14, 667, DateTimeKind.Local).AddTicks(7523), 0, 72, 0 },
                    { 15, 92.530000000000001, new DateTime(2024, 12, 14, 3, 55, 57, 596, DateTimeKind.Local).AddTicks(1017), 0, 34, 1 },
                    { 16, 818.50999999999999, new DateTime(2024, 11, 22, 14, 20, 41, 343, DateTimeKind.Local).AddTicks(3152), 0, 27, 1 },
                    { 17, 309.99000000000001, new DateTime(2024, 12, 3, 12, 51, 40, 820, DateTimeKind.Local).AddTicks(4349), 1, 3, 1 },
                    { 18, 508.60000000000002, new DateTime(2024, 12, 13, 2, 4, 43, 784, DateTimeKind.Local).AddTicks(435), 1, 77, 1 },
                    { 19, 900.71000000000004, new DateTime(2024, 11, 23, 13, 3, 3, 841, DateTimeKind.Local).AddTicks(2254), 1, 52, 1 },
                    { 20, 471.19999999999999, new DateTime(2024, 11, 22, 23, 20, 53, 642, DateTimeKind.Local).AddTicks(2812), 1, 5, 0 },
                    { 21, 473.85000000000002, new DateTime(2024, 12, 5, 17, 25, 4, 791, DateTimeKind.Local).AddTicks(7641), 1, 23, 1 },
                    { 22, 56.520000000000003, new DateTime(2024, 11, 24, 9, 12, 3, 387, DateTimeKind.Local).AddTicks(9905), 1, 68, 0 },
                    { 23, 946.17999999999995, new DateTime(2024, 11, 20, 6, 40, 24, 770, DateTimeKind.Local).AddTicks(1635), 1, 44, 0 },
                    { 24, 246.97999999999999, new DateTime(2024, 12, 7, 18, 15, 5, 620, DateTimeKind.Local).AddTicks(6946), 0, 21, 0 },
                    { 25, 358.41000000000003, new DateTime(2024, 11, 22, 3, 26, 8, 372, DateTimeKind.Local).AddTicks(5792), 1, 17, 0 },
                    { 26, 419.94999999999999, new DateTime(2024, 12, 5, 15, 38, 3, 81, DateTimeKind.Local).AddTicks(4323), 0, 5, 1 },
                    { 27, 684.69000000000005, new DateTime(2024, 12, 4, 10, 52, 17, 92, DateTimeKind.Local).AddTicks(5126), 1, 25, 1 },
                    { 28, 511.18000000000001, new DateTime(2024, 12, 17, 15, 41, 21, 435, DateTimeKind.Local).AddTicks(4012), 1, 93, 1 },
                    { 29, 249.69999999999999, new DateTime(2024, 12, 8, 5, 56, 29, 213, DateTimeKind.Local).AddTicks(5421), 1, 87, 1 },
                    { 30, 931.48000000000002, new DateTime(2024, 11, 28, 15, 56, 28, 679, DateTimeKind.Local).AddTicks(5856), 0, 68, 0 },
                    { 31, 627.37, new DateTime(2024, 11, 27, 2, 4, 29, 653, DateTimeKind.Local).AddTicks(6403), 1, 14, 0 },
                    { 32, 623.05999999999995, new DateTime(2024, 12, 17, 3, 54, 8, 347, DateTimeKind.Local).AddTicks(860), 1, 18, 0 },
                    { 33, 649.51999999999998, new DateTime(2024, 12, 6, 5, 22, 34, 880, DateTimeKind.Local).AddTicks(9071), 1, 98, 1 },
                    { 34, 660.73000000000002, new DateTime(2024, 12, 9, 23, 48, 2, 361, DateTimeKind.Local).AddTicks(1867), 0, 53, 0 },
                    { 35, 952.69000000000005, new DateTime(2024, 12, 11, 10, 21, 7, 939, DateTimeKind.Local).AddTicks(417), 0, 12, 1 },
                    { 36, 237.72, new DateTime(2024, 12, 11, 10, 52, 48, 230, DateTimeKind.Local).AddTicks(8809), 0, 46, 0 },
                    { 37, 942.61000000000001, new DateTime(2024, 11, 21, 12, 25, 40, 669, DateTimeKind.Local).AddTicks(2188), 1, 47, 1 },
                    { 38, 734.61000000000001, new DateTime(2024, 12, 17, 21, 34, 27, 544, DateTimeKind.Local).AddTicks(1394), 0, 52, 0 },
                    { 39, 288.00999999999999, new DateTime(2024, 12, 7, 15, 36, 49, 957, DateTimeKind.Local).AddTicks(6668), 1, 37, 1 },
                    { 40, 535.45000000000005, new DateTime(2024, 11, 25, 2, 42, 5, 28, DateTimeKind.Local).AddTicks(8834), 0, 54, 0 },
                    { 41, 234.68000000000001, new DateTime(2024, 12, 6, 16, 26, 14, 554, DateTimeKind.Local).AddTicks(6847), 1, 4, 0 },
                    { 42, 541.49000000000001, new DateTime(2024, 11, 23, 16, 20, 53, 222, DateTimeKind.Local).AddTicks(1143), 1, 42, 0 },
                    { 43, 931.51999999999998, new DateTime(2024, 12, 7, 1, 51, 48, 394, DateTimeKind.Local).AddTicks(1180), 0, 82, 1 },
                    { 44, 486.42000000000002, new DateTime(2024, 11, 26, 21, 0, 9, 905, DateTimeKind.Local).AddTicks(9419), 1, 78, 0 },
                    { 45, 911.46000000000004, new DateTime(2024, 12, 15, 8, 54, 20, 21, DateTimeKind.Local).AddTicks(6137), 1, 37, 1 },
                    { 46, 268.32999999999998, new DateTime(2024, 11, 23, 14, 48, 59, 795, DateTimeKind.Local).AddTicks(6667), 0, 79, 0 },
                    { 47, 123.41, new DateTime(2024, 12, 17, 14, 18, 19, 431, DateTimeKind.Local).AddTicks(8848), 1, 51, 0 },
                    { 48, 464.56, new DateTime(2024, 12, 8, 15, 47, 4, 620, DateTimeKind.Local).AddTicks(7427), 1, 53, 1 },
                    { 49, 377.69999999999999, new DateTime(2024, 12, 11, 21, 34, 54, 183, DateTimeKind.Local).AddTicks(2929), 1, 19, 0 },
                    { 50, 836.35000000000002, new DateTime(2024, 12, 13, 8, 14, 46, 884, DateTimeKind.Local).AddTicks(9014), 1, 31, 0 },
                    { 51, 880.96000000000004, new DateTime(2024, 11, 23, 11, 22, 14, 72, DateTimeKind.Local).AddTicks(6097), 1, 41, 0 },
                    { 52, 602.90999999999997, new DateTime(2024, 12, 1, 12, 20, 49, 979, DateTimeKind.Local).AddTicks(7832), 1, 18, 0 },
                    { 53, 68.439999999999998, new DateTime(2024, 12, 10, 0, 37, 18, 749, DateTimeKind.Local).AddTicks(8088), 1, 100, 1 },
                    { 54, 438.44999999999999, new DateTime(2024, 12, 9, 9, 28, 54, 961, DateTimeKind.Local).AddTicks(2398), 0, 75, 0 },
                    { 55, 614.17999999999995, new DateTime(2024, 12, 16, 18, 1, 38, 895, DateTimeKind.Local).AddTicks(56), 1, 53, 0 },
                    { 56, 745.89999999999998, new DateTime(2024, 12, 2, 1, 45, 22, 772, DateTimeKind.Local).AddTicks(9805), 1, 19, 0 },
                    { 57, 483.44999999999999, new DateTime(2024, 12, 14, 19, 43, 38, 892, DateTimeKind.Local).AddTicks(4516), 0, 52, 1 },
                    { 58, 690.33000000000004, new DateTime(2024, 11, 23, 8, 46, 6, 930, DateTimeKind.Local).AddTicks(2094), 0, 5, 1 },
                    { 59, 509.22000000000003, new DateTime(2024, 11, 23, 11, 54, 40, 184, DateTimeKind.Local).AddTicks(3383), 1, 90, 1 },
                    { 60, 50.560000000000002, new DateTime(2024, 11, 20, 22, 8, 43, 553, DateTimeKind.Local).AddTicks(9774), 0, 93, 0 },
                    { 61, 369.69, new DateTime(2024, 11, 30, 16, 32, 24, 222, DateTimeKind.Local).AddTicks(2778), 1, 57, 1 },
                    { 62, 896.57000000000005, new DateTime(2024, 11, 20, 14, 30, 33, 55, DateTimeKind.Local).AddTicks(8758), 0, 79, 0 },
                    { 63, 234.94999999999999, new DateTime(2024, 12, 1, 18, 16, 27, 10, DateTimeKind.Local).AddTicks(6266), 1, 72, 0 },
                    { 64, 813.91999999999996, new DateTime(2024, 12, 9, 2, 27, 54, 143, DateTimeKind.Local).AddTicks(1947), 0, 91, 1 },
                    { 65, 499.39999999999998, new DateTime(2024, 12, 17, 8, 24, 15, 19, DateTimeKind.Local).AddTicks(6329), 0, 61, 0 },
                    { 66, 345.01999999999998, new DateTime(2024, 12, 13, 9, 23, 10, 753, DateTimeKind.Local).AddTicks(1482), 1, 89, 0 },
                    { 67, 65.950000000000003, new DateTime(2024, 11, 26, 20, 22, 58, 73, DateTimeKind.Local).AddTicks(7444), 0, 75, 1 },
                    { 68, 551.12, new DateTime(2024, 12, 16, 8, 41, 19, 674, DateTimeKind.Local).AddTicks(1941), 1, 47, 0 },
                    { 69, 989.19000000000005, new DateTime(2024, 11, 22, 20, 43, 33, 261, DateTimeKind.Local).AddTicks(8849), 0, 94, 1 },
                    { 70, 120.01000000000001, new DateTime(2024, 12, 11, 15, 51, 39, 518, DateTimeKind.Local).AddTicks(680), 0, 46, 0 },
                    { 71, 547.92999999999995, new DateTime(2024, 12, 2, 8, 48, 47, 98, DateTimeKind.Local).AddTicks(8848), 1, 40, 0 },
                    { 72, 193.56999999999999, new DateTime(2024, 12, 6, 23, 29, 30, 673, DateTimeKind.Local).AddTicks(6248), 1, 51, 0 },
                    { 73, 317.49000000000001, new DateTime(2024, 12, 17, 2, 40, 51, 576, DateTimeKind.Local).AddTicks(9936), 0, 85, 1 },
                    { 74, 268.55000000000001, new DateTime(2024, 12, 4, 16, 51, 18, 409, DateTimeKind.Local).AddTicks(6219), 1, 92, 1 },
                    { 75, 605.32000000000005, new DateTime(2024, 11, 27, 19, 37, 57, 411, DateTimeKind.Local).AddTicks(889), 1, 4, 0 },
                    { 76, 87.739999999999995, new DateTime(2024, 12, 2, 23, 18, 39, 131, DateTimeKind.Local).AddTicks(5642), 0, 58, 0 },
                    { 77, 272.26999999999998, new DateTime(2024, 11, 21, 18, 44, 12, 419, DateTimeKind.Local).AddTicks(3691), 0, 84, 1 },
                    { 78, 987.47000000000003, new DateTime(2024, 11, 19, 17, 57, 28, 599, DateTimeKind.Local).AddTicks(6577), 1, 28, 1 },
                    { 79, 728.97000000000003, new DateTime(2024, 12, 4, 8, 25, 39, 187, DateTimeKind.Local).AddTicks(2003), 1, 84, 0 },
                    { 80, 77.790000000000006, new DateTime(2024, 11, 25, 22, 41, 52, 845, DateTimeKind.Local).AddTicks(1066), 0, 49, 0 }
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
