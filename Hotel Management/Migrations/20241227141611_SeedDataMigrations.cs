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
                    { 1, "admin@hotel.com", "admin", "admin", "$2a$11$4N6/UQW7An8FyHRqZjtCveIgbpb8KjBHM1gYtLDdXdBkqevj8GU.K", "0600000000", 0 },
                    { 2, "Ron.Collins90@hotmail.com", "Ole", "Prohaska", "$2a$11$B05zbyCChKOsxx2LHohXpeYkiMaz6joNYITkrdxKVEE5StlVaUDXW", "1-458-448-2824 x95460", 2 },
                    { 3, "Helen.Effertz@gmail.com", "Ricardo", "Kling", "$2a$11$75vkbdduOBew7yqByMRIUOWX5jn6I09AiOeuOxpHCRi9hqv.X7HuG", "(814) 392-1954 x223", 0 },
                    { 4, "Modesto63@gmail.com", "Lafayette", "Gaylord", "$2a$11$KVCWu4VJG2lB8OuYBkpgr.1wYZ3z3.3JIrswr2tiY2g8KVc7jaOxm", "1-794-617-4703 x27634", 2 },
                    { 5, "Fanny7@yahoo.com", "Luigi", "Schultz", "$2a$11$n2XEiiDwVjcWeSzkO8G5heQ7UL.BheULcXloEtH25his8XBABb/1G", "1-731-714-4475 x17668", 1 },
                    { 6, "Edgar86@gmail.com", "Noe", "Lind", "$2a$11$.0Gzw.7vY4CmNVS3vVSsGeDkGsMft8JYi5wcOH7yEqQymVwhFuiRG", "761-764-3227 x0078", 0 },
                    { 7, "Jewell_Mosciski@hotmail.com", "Alfonso", "Terry", "$2a$11$v5LHHZX4fc7N14cyb3R6/uG5HnSscwvXc.gqoA307U04L6VdfdBs2", "304-276-6654 x92076", 1 },
                    { 8, "Armando_Rodriguez57@gmail.com", "Della", "Ledner", "$2a$11$.YdXloNYaYbRtpxkOVk9De/iv3FsFe1NY05sKRyUfnfsgiQlmA8/m", "(944) 363-8788 x6737", 2 },
                    { 9, "Kelvin_Schiller@hotmail.com", "Sophia", "Stokes", "$2a$11$eaX9U4.Pnfp81RADzuKq/.MKnr9WBXihLRhb9vtMiy7bqaJQ2rGQu", "1-356-601-3911 x04627", 2 },
                    { 10, "Tavares44@yahoo.com", "Maxie", "Tremblay", "$2a$11$r1VJ5ZtQlt6eQQ0G/QtytuQg9OZtMLGN7qEX9VKQBLG/6hnP6yFsq", "525.595.8121", 0 },
                    { 11, "Geo_Mitchell@yahoo.com", "Krystina", "Hartmann", "$2a$11$DUdwWMj5oA8x4asfl6CKDuM2AE4rRBK0.U0JPmMiw3n8ZQxAOKyxe", "1-500-987-3340", 2 },
                    { 12, "Betsy95@hotmail.com", "Armando", "Kling", "$2a$11$vATpz0MzMtFAWzv7R8dOSOkAmnBNeubk656hx.UE3l.4XVQ/5FXRS", "1-817-897-4785", 1 },
                    { 13, "Wendell.Buckridge@gmail.com", "Gabriel", "Mosciski", "$2a$11$Ybe.d/UrMna8P/XqYZddX.3f0A4tlPPzVy1dEBfSiUqn6b7RehZv.", "461-711-6584", 1 },
                    { 14, "Tiara.Goldner@hotmail.com", "Mac", "Jerde", "$2a$11$e8XqEnjJt98YTf0vJ692KOkJwYHckTpvFwTEsyEbP/ZWhwdgKs1by", "(881) 897-9111", 1 },
                    { 15, "Darrick.Morar51@hotmail.com", "Rachel", "Harvey", "$2a$11$XKFSLanImSIiHUHgr6Qlc.mBjx/tX3C9M0Y5aLkmN39cotVt4cXU6", "1-764-623-7272", 1 },
                    { 16, "Priscilla.Gulgowski@hotmail.com", "Velda", "Flatley", "$2a$11$meaw18ZuT49GmJIfFPCBwOrx3vE1b1xojioEOSOI0FzQRcGCxb44y", "855-498-5646 x53330", 1 },
                    { 17, "Leopold.Steuber41@yahoo.com", "Haley", "Fadel", "$2a$11$7y9QB81dTuzQH3bCyjMTtu12.RzhsDZiwHXph2OCxcqj0OE6Qj056", "(713) 743-3037 x739", 2 },
                    { 18, "Clark.Powlowski@hotmail.com", "Verner", "Bernier", "$2a$11$tV7HN6HvlqS5CKzJNBERxe.3psSUZeZfaFR5J/hYunTyDiWLx.ZC2", "1-758-932-5788", 1 },
                    { 19, "Jolie_Barrows@hotmail.com", "Sylvan", "Boehm", "$2a$11$x0y.mDgErZVkGWlJDcHd5u.YcOw7AsjjUvv78zo4JhEJ1iNWWRGQO", "(505) 579-9256 x995", 2 },
                    { 20, "Leonor_OConner27@yahoo.com", "Dedrick", "Heller", "$2a$11$KxFKVrqn/LrXsBizE5Iiz.43Qwf0vaTpnYuy5G8nFhLbImsvbxtxG", "(929) 959-8347 x777", 1 },
                    { 21, "Patsy.Koss64@yahoo.com", "Bernhard", "Stokes", "$2a$11$saQ60a2m.D.JGLjjot03buyUWhjWtfZjYTunIOTH.q4pNN4YCN49u", "1-830-349-5839 x54963", 2 },
                    { 22, "Sharon45@gmail.com", "Felton", "Prohaska", "$2a$11$w2Ns//e1vFhSXqZLsV9e..vjnDmnt/ZcWTzcj2sFhVsn.leilCXXG", "860-260-2832 x22823", 1 },
                    { 23, "Helena37@hotmail.com", "Zelma", "Kling", "$2a$11$vmFlnNE8sZ/JKbi3HQmqd.fCaHuJqt.BMc15ODUr7b8L5Wt11QS/i", "719.762.2205", 1 },
                    { 24, "Aidan_Larson87@gmail.com", "Braulio", "Pouros", "$2a$11$Zi3IpUSVzlLpINM05vCKluIMlHDEjmfiGH7xAtqhJlurZ02.jhUXK", "819-851-9391", 2 },
                    { 25, "Reynold_Hahn@yahoo.com", "Alfreda", "Swaniawski", "$2a$11$UhtQ12EoVHf3QaJmOvModeJBxiwfbXOUfruXDU/HFoUyGZmn5miRK", "729.451.4389", 2 },
                    { 26, "Darrell_Bogan@hotmail.com", "Leo", "Boehm", "$2a$11$G4IPOJ.FsLxoDOjb2TlvEO44siVvRVAQL.F5qWwR6x6/PDKXh/Oh.", "1-436-954-6784 x10270", 2 }
                });

            migrationBuilder.InsertData(
                table: "Room",
                columns: new[] { "Id", "Capacity", "IsAvailable", "Name", "Price", "RoomTypeId" },
                values: new object[,]
                {
                    { 1, 8, false, "Room 394", 468.0, 3 },
                    { 2, 10, false, "Room 142", 174.0, 2 },
                    { 3, 2, false, "Room 150", 596.0, 2 },
                    { 4, 2, false, "Room 440", 113.0, 1 },
                    { 5, 2, false, "Room 314", 134.0, 3 },
                    { 6, 10, false, "Room 178", 165.0, 1 },
                    { 7, 7, true, "Room 318", 440.0, 3 },
                    { 8, 5, false, "Room 332", 731.0, 2 },
                    { 9, 10, true, "Room 297", 383.0, 1 },
                    { 10, 5, false, "Room 492", 815.0, 3 },
                    { 11, 8, true, "Room 121", 342.0, 3 },
                    { 12, 6, true, "Room 180", 883.0, 2 },
                    { 13, 5, true, "Room 403", 417.0, 1 },
                    { 14, 4, false, "Room 332", 271.0, 2 },
                    { 15, 3, true, "Room 467", 822.0, 2 },
                    { 16, 6, false, "Room 250", 902.0, 3 },
                    { 17, 7, true, "Room 329", 871.0, 2 },
                    { 18, 7, true, "Room 274", 213.0, 2 },
                    { 19, 9, true, "Room 341", 150.0, 3 },
                    { 20, 2, false, "Room 372", 837.0, 3 },
                    { 21, 10, true, "Room 114", 721.0, 1 },
                    { 22, 7, true, "Room 381", 641.0, 1 },
                    { 23, 9, false, "Room 114", 771.0, 1 },
                    { 24, 7, false, "Room 128", 974.0, 3 },
                    { 25, 8, true, "Room 295", 476.0, 1 },
                    { 26, 5, false, "Room 150", 661.0, 1 },
                    { 27, 5, false, "Room 152", 995.0, 3 },
                    { 28, 8, true, "Room 487", 740.0, 1 },
                    { 29, 8, true, "Room 155", 855.0, 2 },
                    { 30, 4, true, "Room 500", 457.0, 2 },
                    { 31, 1, true, "Room 101", 96.0, 3 },
                    { 32, 1, true, "Room 452", 611.0, 1 },
                    { 33, 8, true, "Room 287", 651.0, 3 },
                    { 34, 9, false, "Room 138", 560.0, 2 },
                    { 35, 1, true, "Room 117", 854.0, 2 },
                    { 36, 8, false, "Room 147", 327.0, 1 },
                    { 37, 5, false, "Room 415", 328.0, 1 },
                    { 38, 9, false, "Room 270", 749.0, 1 },
                    { 39, 5, false, "Room 320", 377.0, 1 },
                    { 40, 1, false, "Room 154", 164.0, 2 },
                    { 41, 2, true, "Room 178", 665.0, 2 },
                    { 42, 2, true, "Room 400", 796.0, 2 },
                    { 43, 5, true, "Room 219", 898.0, 1 },
                    { 44, 2, true, "Room 349", 479.0, 2 },
                    { 45, 1, false, "Room 453", 429.0, 3 },
                    { 46, 3, true, "Room 126", 991.0, 2 },
                    { 47, 2, false, "Room 105", 921.0, 2 },
                    { 48, 2, true, "Room 225", 973.0, 2 },
                    { 49, 4, true, "Room 253", 364.0, 2 },
                    { 50, 7, true, "Room 152", 520.0, 3 }
                });

            migrationBuilder.InsertData(
                table: "Reservation",
                columns: new[] { "Id", "CheckInDate", "CheckOutDate", "RoomId", "Status", "TotalPrice", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 12, 6, 7, 0, 37, 112, DateTimeKind.Local).AddTicks(2344), new DateTime(2024, 12, 16, 7, 0, 37, 112, DateTimeKind.Local).AddTicks(2344), 26, 2, 2735.0, 4 },
                    { 2, new DateTime(2025, 1, 5, 22, 2, 4, 628, DateTimeKind.Local).AddTicks(8850), new DateTime(2025, 1, 14, 22, 2, 4, 628, DateTimeKind.Local).AddTicks(8850), 43, 2, 4965.0, 8 },
                    { 3, new DateTime(2025, 1, 21, 1, 26, 32, 585, DateTimeKind.Local).AddTicks(5633), new DateTime(2025, 1, 30, 1, 26, 32, 585, DateTimeKind.Local).AddTicks(5633), 11, 1, 3190.0, 8 },
                    { 4, new DateTime(2025, 1, 8, 20, 6, 40, 573, DateTimeKind.Local).AddTicks(969), new DateTime(2025, 1, 10, 20, 6, 40, 573, DateTimeKind.Local).AddTicks(969), 31, 0, 1035.0, 2 },
                    { 5, new DateTime(2024, 12, 4, 7, 21, 4, 2, DateTimeKind.Local).AddTicks(3794), new DateTime(2024, 12, 5, 7, 21, 4, 2, DateTimeKind.Local).AddTicks(3794), 4, 1, 3948.0, 2 },
                    { 6, new DateTime(2025, 1, 3, 22, 0, 0, 755, DateTimeKind.Local).AddTicks(3181), new DateTime(2025, 1, 12, 22, 0, 0, 755, DateTimeKind.Local).AddTicks(3181), 41, 1, 4506.0, 5 },
                    { 7, new DateTime(2024, 12, 11, 23, 36, 0, 248, DateTimeKind.Local).AddTicks(2327), new DateTime(2024, 12, 13, 23, 36, 0, 248, DateTimeKind.Local).AddTicks(2327), 33, 0, 265.0, 2 },
                    { 8, new DateTime(2024, 12, 25, 7, 34, 5, 637, DateTimeKind.Local).AddTicks(7709), new DateTime(2024, 12, 31, 7, 34, 5, 637, DateTimeKind.Local).AddTicks(7709), 12, 0, 4744.0, 7 },
                    { 9, new DateTime(2024, 12, 26, 4, 17, 45, 127, DateTimeKind.Local).AddTicks(716), new DateTime(2024, 12, 28, 4, 17, 45, 127, DateTimeKind.Local).AddTicks(716), 10, 2, 1680.0, 1 },
                    { 10, new DateTime(2025, 1, 15, 12, 57, 43, 497, DateTimeKind.Local).AddTicks(6994), new DateTime(2025, 1, 24, 12, 57, 43, 497, DateTimeKind.Local).AddTicks(6994), 30, 0, 1653.0, 2 },
                    { 11, new DateTime(2024, 12, 19, 15, 21, 5, 6, DateTimeKind.Local).AddTicks(7559), new DateTime(2024, 12, 22, 15, 21, 5, 6, DateTimeKind.Local).AddTicks(7559), 31, 1, 4688.0, 3 },
                    { 12, new DateTime(2024, 11, 28, 19, 6, 3, 48, DateTimeKind.Local).AddTicks(8947), new DateTime(2024, 12, 6, 19, 6, 3, 48, DateTimeKind.Local).AddTicks(8947), 45, 0, 679.0, 4 },
                    { 13, new DateTime(2025, 1, 13, 15, 40, 53, 701, DateTimeKind.Local).AddTicks(421), new DateTime(2025, 1, 17, 15, 40, 53, 701, DateTimeKind.Local).AddTicks(421), 48, 1, 2482.0, 3 },
                    { 14, new DateTime(2025, 1, 24, 2, 7, 16, 944, DateTimeKind.Local).AddTicks(6838), new DateTime(2025, 2, 1, 2, 7, 16, 944, DateTimeKind.Local).AddTicks(6838), 43, 2, 927.0, 1 },
                    { 15, new DateTime(2024, 12, 14, 15, 26, 51, 927, DateTimeKind.Local).AddTicks(1207), new DateTime(2024, 12, 18, 15, 26, 51, 927, DateTimeKind.Local).AddTicks(1207), 24, 1, 1154.0, 10 },
                    { 16, new DateTime(2025, 1, 24, 12, 41, 55, 350, DateTimeKind.Local).AddTicks(6680), new DateTime(2025, 1, 25, 12, 41, 55, 350, DateTimeKind.Local).AddTicks(6680), 3, 1, 1955.0, 2 },
                    { 17, new DateTime(2024, 12, 8, 4, 6, 27, 256, DateTimeKind.Local).AddTicks(7427), new DateTime(2024, 12, 10, 4, 6, 27, 256, DateTimeKind.Local).AddTicks(7427), 32, 0, 3060.0, 5 },
                    { 18, new DateTime(2024, 12, 7, 15, 43, 42, 512, DateTimeKind.Local).AddTicks(1334), new DateTime(2024, 12, 11, 15, 43, 42, 512, DateTimeKind.Local).AddTicks(1334), 44, 1, 2136.0, 10 },
                    { 19, new DateTime(2025, 1, 11, 15, 46, 16, 384, DateTimeKind.Local).AddTicks(610), new DateTime(2025, 1, 19, 15, 46, 16, 384, DateTimeKind.Local).AddTicks(610), 47, 1, 1743.0, 8 },
                    { 20, new DateTime(2024, 12, 12, 2, 17, 55, 255, DateTimeKind.Local).AddTicks(9115), new DateTime(2024, 12, 20, 2, 17, 55, 255, DateTimeKind.Local).AddTicks(9115), 49, 1, 2980.0, 8 },
                    { 21, new DateTime(2024, 11, 29, 0, 52, 9, 127, DateTimeKind.Local).AddTicks(9952), new DateTime(2024, 11, 30, 0, 52, 9, 127, DateTimeKind.Local).AddTicks(9952), 33, 0, 2917.0, 6 },
                    { 22, new DateTime(2025, 1, 8, 10, 56, 7, 922, DateTimeKind.Local).AddTicks(9141), new DateTime(2025, 1, 14, 10, 56, 7, 922, DateTimeKind.Local).AddTicks(9141), 27, 1, 1732.0, 3 },
                    { 23, new DateTime(2025, 1, 14, 8, 48, 9, 302, DateTimeKind.Local).AddTicks(9975), new DateTime(2025, 1, 21, 8, 48, 9, 302, DateTimeKind.Local).AddTicks(9975), 1, 0, 3829.0, 3 },
                    { 24, new DateTime(2024, 12, 12, 18, 18, 56, 139, DateTimeKind.Local).AddTicks(9745), new DateTime(2024, 12, 13, 18, 18, 56, 139, DateTimeKind.Local).AddTicks(9745), 29, 1, 3017.0, 1 },
                    { 25, new DateTime(2024, 12, 24, 11, 38, 57, 215, DateTimeKind.Local).AddTicks(1649), new DateTime(2024, 12, 28, 11, 38, 57, 215, DateTimeKind.Local).AddTicks(1649), 33, 2, 3873.0, 10 },
                    { 26, new DateTime(2025, 1, 12, 4, 36, 20, 12, DateTimeKind.Local).AddTicks(4662), new DateTime(2025, 1, 21, 4, 36, 20, 12, DateTimeKind.Local).AddTicks(4662), 12, 2, 937.0, 4 },
                    { 27, new DateTime(2025, 1, 16, 12, 53, 43, 617, DateTimeKind.Local).AddTicks(4325), new DateTime(2025, 1, 22, 12, 53, 43, 617, DateTimeKind.Local).AddTicks(4325), 36, 2, 969.0, 7 },
                    { 28, new DateTime(2025, 1, 7, 5, 56, 3, 785, DateTimeKind.Local).AddTicks(6148), new DateTime(2025, 1, 9, 5, 56, 3, 785, DateTimeKind.Local).AddTicks(6148), 16, 0, 4610.0, 7 },
                    { 29, new DateTime(2024, 12, 29, 3, 57, 49, 824, DateTimeKind.Local).AddTicks(2529), new DateTime(2025, 1, 2, 3, 57, 49, 824, DateTimeKind.Local).AddTicks(2529), 6, 2, 3873.0, 1 },
                    { 30, new DateTime(2024, 12, 4, 1, 57, 35, 461, DateTimeKind.Local).AddTicks(8307), new DateTime(2024, 12, 13, 1, 57, 35, 461, DateTimeKind.Local).AddTicks(8307), 41, 0, 4336.0, 4 },
                    { 31, new DateTime(2024, 12, 11, 23, 2, 30, 323, DateTimeKind.Local).AddTicks(6334), new DateTime(2024, 12, 20, 23, 2, 30, 323, DateTimeKind.Local).AddTicks(6334), 36, 1, 364.0, 9 },
                    { 32, new DateTime(2024, 12, 31, 7, 40, 40, 192, DateTimeKind.Local).AddTicks(2612), new DateTime(2025, 1, 4, 7, 40, 40, 192, DateTimeKind.Local).AddTicks(2612), 45, 0, 4701.0, 8 },
                    { 33, new DateTime(2025, 1, 6, 2, 30, 38, 538, DateTimeKind.Local).AddTicks(2643), new DateTime(2025, 1, 10, 2, 30, 38, 538, DateTimeKind.Local).AddTicks(2643), 26, 1, 1041.0, 6 },
                    { 34, new DateTime(2025, 1, 11, 20, 3, 48, 234, DateTimeKind.Local).AddTicks(1189), new DateTime(2025, 1, 19, 20, 3, 48, 234, DateTimeKind.Local).AddTicks(1189), 34, 0, 4316.0, 9 },
                    { 35, new DateTime(2024, 12, 26, 19, 17, 17, 282, DateTimeKind.Local).AddTicks(3787), new DateTime(2024, 12, 28, 19, 17, 17, 282, DateTimeKind.Local).AddTicks(3787), 4, 1, 4815.0, 2 },
                    { 36, new DateTime(2025, 1, 4, 17, 15, 12, 329, DateTimeKind.Local).AddTicks(8479), new DateTime(2025, 1, 8, 17, 15, 12, 329, DateTimeKind.Local).AddTicks(8479), 25, 1, 1648.0, 1 },
                    { 37, new DateTime(2024, 11, 29, 8, 24, 28, 940, DateTimeKind.Local).AddTicks(9523), new DateTime(2024, 12, 3, 8, 24, 28, 940, DateTimeKind.Local).AddTicks(9523), 44, 0, 4108.0, 5 },
                    { 38, new DateTime(2025, 1, 7, 23, 41, 0, 946, DateTimeKind.Local).AddTicks(7600), new DateTime(2025, 1, 14, 23, 41, 0, 946, DateTimeKind.Local).AddTicks(7600), 7, 0, 650.0, 1 },
                    { 39, new DateTime(2025, 1, 3, 17, 59, 38, 618, DateTimeKind.Local).AddTicks(3807), new DateTime(2025, 1, 4, 17, 59, 38, 618, DateTimeKind.Local).AddTicks(3807), 38, 1, 4739.0, 3 },
                    { 40, new DateTime(2024, 12, 14, 0, 44, 41, 231, DateTimeKind.Local).AddTicks(9633), new DateTime(2024, 12, 22, 0, 44, 41, 231, DateTimeKind.Local).AddTicks(9633), 25, 2, 1940.0, 7 },
                    { 41, new DateTime(2024, 12, 16, 21, 39, 14, 104, DateTimeKind.Local).AddTicks(7131), new DateTime(2024, 12, 20, 21, 39, 14, 104, DateTimeKind.Local).AddTicks(7131), 4, 0, 4274.0, 10 },
                    { 42, new DateTime(2025, 1, 11, 16, 55, 44, 435, DateTimeKind.Local).AddTicks(1232), new DateTime(2025, 1, 15, 16, 55, 44, 435, DateTimeKind.Local).AddTicks(1232), 11, 1, 848.0, 3 },
                    { 43, new DateTime(2025, 1, 9, 18, 38, 35, 849, DateTimeKind.Local).AddTicks(1517), new DateTime(2025, 1, 14, 18, 38, 35, 849, DateTimeKind.Local).AddTicks(1517), 18, 1, 715.0, 4 },
                    { 44, new DateTime(2024, 12, 13, 12, 11, 30, 626, DateTimeKind.Local).AddTicks(1941), new DateTime(2024, 12, 19, 12, 11, 30, 626, DateTimeKind.Local).AddTicks(1941), 6, 0, 2894.0, 2 },
                    { 45, new DateTime(2024, 12, 8, 5, 7, 55, 524, DateTimeKind.Local).AddTicks(5822), new DateTime(2024, 12, 12, 5, 7, 55, 524, DateTimeKind.Local).AddTicks(5822), 5, 0, 2640.0, 3 },
                    { 46, new DateTime(2025, 1, 15, 18, 21, 3, 958, DateTimeKind.Local).AddTicks(5570), new DateTime(2025, 1, 22, 18, 21, 3, 958, DateTimeKind.Local).AddTicks(5570), 30, 1, 3636.0, 3 },
                    { 47, new DateTime(2024, 12, 13, 23, 44, 43, 433, DateTimeKind.Local).AddTicks(6984), new DateTime(2024, 12, 23, 23, 44, 43, 433, DateTimeKind.Local).AddTicks(6984), 18, 2, 1849.0, 8 },
                    { 48, new DateTime(2025, 1, 2, 15, 2, 15, 696, DateTimeKind.Local).AddTicks(1155), new DateTime(2025, 1, 11, 15, 2, 15, 696, DateTimeKind.Local).AddTicks(1155), 9, 2, 2024.0, 4 },
                    { 49, new DateTime(2025, 1, 23, 2, 5, 2, 115, DateTimeKind.Local).AddTicks(2204), new DateTime(2025, 1, 31, 2, 5, 2, 115, DateTimeKind.Local).AddTicks(2204), 42, 1, 1883.0, 1 },
                    { 50, new DateTime(2024, 12, 16, 13, 43, 33, 472, DateTimeKind.Local).AddTicks(460), new DateTime(2024, 12, 23, 13, 43, 33, 472, DateTimeKind.Local).AddTicks(460), 20, 1, 2957.0, 2 },
                    { 51, new DateTime(2025, 1, 17, 22, 26, 15, 18, DateTimeKind.Local).AddTicks(6755), new DateTime(2025, 1, 24, 22, 26, 15, 18, DateTimeKind.Local).AddTicks(6755), 23, 2, 2023.0, 1 },
                    { 52, new DateTime(2025, 1, 9, 21, 50, 25, 633, DateTimeKind.Local).AddTicks(9987), new DateTime(2025, 1, 16, 21, 50, 25, 633, DateTimeKind.Local).AddTicks(9987), 1, 0, 1093.0, 10 },
                    { 53, new DateTime(2024, 12, 2, 5, 9, 50, 112, DateTimeKind.Local).AddTicks(8206), new DateTime(2024, 12, 11, 5, 9, 50, 112, DateTimeKind.Local).AddTicks(8206), 28, 0, 4700.0, 1 },
                    { 54, new DateTime(2025, 1, 11, 18, 50, 21, 678, DateTimeKind.Local).AddTicks(2665), new DateTime(2025, 1, 13, 18, 50, 21, 678, DateTimeKind.Local).AddTicks(2665), 42, 1, 4280.0, 4 },
                    { 55, new DateTime(2025, 1, 18, 9, 36, 10, 792, DateTimeKind.Local).AddTicks(4272), new DateTime(2025, 1, 23, 9, 36, 10, 792, DateTimeKind.Local).AddTicks(4272), 30, 0, 2265.0, 6 },
                    { 56, new DateTime(2025, 1, 22, 11, 58, 13, 862, DateTimeKind.Local).AddTicks(6261), new DateTime(2025, 1, 27, 11, 58, 13, 862, DateTimeKind.Local).AddTicks(6261), 19, 0, 4082.0, 7 },
                    { 57, new DateTime(2024, 12, 23, 4, 7, 54, 537, DateTimeKind.Local).AddTicks(134), new DateTime(2025, 1, 1, 4, 7, 54, 537, DateTimeKind.Local).AddTicks(134), 27, 1, 1740.0, 6 },
                    { 58, new DateTime(2024, 12, 9, 11, 26, 11, 937, DateTimeKind.Local).AddTicks(9922), new DateTime(2024, 12, 16, 11, 26, 11, 937, DateTimeKind.Local).AddTicks(9922), 39, 0, 3611.0, 5 },
                    { 59, new DateTime(2025, 1, 10, 22, 21, 49, 843, DateTimeKind.Local).AddTicks(8609), new DateTime(2025, 1, 18, 22, 21, 49, 843, DateTimeKind.Local).AddTicks(8609), 49, 0, 4443.0, 8 },
                    { 60, new DateTime(2024, 12, 23, 14, 51, 44, 900, DateTimeKind.Local).AddTicks(6190), new DateTime(2024, 12, 24, 14, 51, 44, 900, DateTimeKind.Local).AddTicks(6190), 42, 2, 2954.0, 3 },
                    { 61, new DateTime(2025, 1, 26, 1, 40, 14, 19, DateTimeKind.Local).AddTicks(2265), new DateTime(2025, 1, 30, 1, 40, 14, 19, DateTimeKind.Local).AddTicks(2265), 10, 1, 687.0, 9 },
                    { 62, new DateTime(2025, 1, 10, 1, 7, 43, 875, DateTimeKind.Local).AddTicks(2630), new DateTime(2025, 1, 15, 1, 7, 43, 875, DateTimeKind.Local).AddTicks(2630), 28, 0, 1460.0, 1 },
                    { 63, new DateTime(2024, 12, 13, 1, 20, 23, 15, DateTimeKind.Local).AddTicks(5088), new DateTime(2024, 12, 14, 1, 20, 23, 15, DateTimeKind.Local).AddTicks(5088), 22, 2, 832.0, 10 },
                    { 64, new DateTime(2025, 1, 21, 9, 31, 46, 241, DateTimeKind.Local).AddTicks(1525), new DateTime(2025, 1, 30, 9, 31, 46, 241, DateTimeKind.Local).AddTicks(1525), 23, 2, 3959.0, 6 },
                    { 65, new DateTime(2024, 12, 26, 9, 50, 34, 422, DateTimeKind.Local).AddTicks(1464), new DateTime(2025, 1, 3, 9, 50, 34, 422, DateTimeKind.Local).AddTicks(1464), 2, 0, 1346.0, 1 },
                    { 66, new DateTime(2024, 12, 4, 22, 42, 53, 943, DateTimeKind.Local).AddTicks(4303), new DateTime(2024, 12, 5, 22, 42, 53, 943, DateTimeKind.Local).AddTicks(4303), 21, 2, 636.0, 3 },
                    { 67, new DateTime(2025, 1, 8, 2, 45, 46, 777, DateTimeKind.Local).AddTicks(8194), new DateTime(2025, 1, 9, 2, 45, 46, 777, DateTimeKind.Local).AddTicks(8194), 47, 2, 4831.0, 2 },
                    { 68, new DateTime(2024, 12, 16, 6, 4, 43, 313, DateTimeKind.Local).AddTicks(2234), new DateTime(2024, 12, 17, 6, 4, 43, 313, DateTimeKind.Local).AddTicks(2234), 45, 1, 1019.0, 3 },
                    { 69, new DateTime(2024, 12, 27, 10, 16, 26, 846, DateTimeKind.Local).AddTicks(4196), new DateTime(2024, 12, 30, 10, 16, 26, 846, DateTimeKind.Local).AddTicks(4196), 34, 1, 4327.0, 9 },
                    { 70, new DateTime(2024, 12, 29, 17, 8, 45, 561, DateTimeKind.Local).AddTicks(230), new DateTime(2024, 12, 30, 17, 8, 45, 561, DateTimeKind.Local).AddTicks(230), 24, 1, 1693.0, 9 },
                    { 71, new DateTime(2024, 12, 16, 13, 38, 38, 728, DateTimeKind.Local).AddTicks(6970), new DateTime(2024, 12, 22, 13, 38, 38, 728, DateTimeKind.Local).AddTicks(6970), 48, 2, 169.0, 5 },
                    { 72, new DateTime(2024, 12, 20, 0, 43, 13, 844, DateTimeKind.Local).AddTicks(4907), new DateTime(2024, 12, 23, 0, 43, 13, 844, DateTimeKind.Local).AddTicks(4907), 18, 2, 1353.0, 7 },
                    { 73, new DateTime(2025, 1, 1, 0, 41, 8, 145, DateTimeKind.Local).AddTicks(8700), new DateTime(2025, 1, 3, 0, 41, 8, 145, DateTimeKind.Local).AddTicks(8700), 24, 2, 4495.0, 9 },
                    { 74, new DateTime(2024, 12, 30, 21, 27, 51, 724, DateTimeKind.Local).AddTicks(1721), new DateTime(2024, 12, 31, 21, 27, 51, 724, DateTimeKind.Local).AddTicks(1721), 15, 2, 653.0, 1 },
                    { 75, new DateTime(2024, 12, 25, 0, 42, 10, 933, DateTimeKind.Local).AddTicks(3392), new DateTime(2024, 12, 31, 0, 42, 10, 933, DateTimeKind.Local).AddTicks(3392), 30, 0, 130.0, 1 },
                    { 76, new DateTime(2024, 12, 28, 1, 47, 57, 901, DateTimeKind.Local).AddTicks(9205), new DateTime(2025, 1, 6, 1, 47, 57, 901, DateTimeKind.Local).AddTicks(9205), 31, 1, 3250.0, 1 },
                    { 77, new DateTime(2024, 12, 28, 21, 8, 32, 174, DateTimeKind.Local).AddTicks(5684), new DateTime(2025, 1, 5, 21, 8, 32, 174, DateTimeKind.Local).AddTicks(5684), 25, 2, 2268.0, 2 },
                    { 78, new DateTime(2024, 12, 15, 17, 11, 16, 112, DateTimeKind.Local).AddTicks(1424), new DateTime(2024, 12, 24, 17, 11, 16, 112, DateTimeKind.Local).AddTicks(1424), 41, 1, 1370.0, 10 },
                    { 79, new DateTime(2025, 1, 10, 3, 18, 34, 894, DateTimeKind.Local).AddTicks(7873), new DateTime(2025, 1, 16, 3, 18, 34, 894, DateTimeKind.Local).AddTicks(7873), 4, 0, 324.0, 9 },
                    { 80, new DateTime(2025, 1, 12, 1, 27, 22, 190, DateTimeKind.Local).AddTicks(1408), new DateTime(2025, 1, 19, 1, 27, 22, 190, DateTimeKind.Local).AddTicks(1408), 17, 0, 3796.0, 4 },
                    { 81, new DateTime(2024, 12, 13, 8, 0, 31, 850, DateTimeKind.Local).AddTicks(3058), new DateTime(2024, 12, 17, 8, 0, 31, 850, DateTimeKind.Local).AddTicks(3058), 21, 1, 3689.0, 9 },
                    { 82, new DateTime(2025, 1, 17, 16, 7, 24, 644, DateTimeKind.Local).AddTicks(3487), new DateTime(2025, 1, 18, 16, 7, 24, 644, DateTimeKind.Local).AddTicks(3487), 41, 1, 4594.0, 4 },
                    { 83, new DateTime(2024, 12, 1, 9, 18, 18, 518, DateTimeKind.Local).AddTicks(6688), new DateTime(2024, 12, 10, 9, 18, 18, 518, DateTimeKind.Local).AddTicks(6688), 47, 1, 3140.0, 6 },
                    { 84, new DateTime(2024, 11, 29, 7, 9, 46, 299, DateTimeKind.Local).AddTicks(704), new DateTime(2024, 11, 30, 7, 9, 46, 299, DateTimeKind.Local).AddTicks(704), 2, 0, 1946.0, 10 },
                    { 85, new DateTime(2024, 12, 18, 9, 24, 22, 410, DateTimeKind.Local).AddTicks(557), new DateTime(2024, 12, 24, 9, 24, 22, 410, DateTimeKind.Local).AddTicks(557), 21, 1, 613.0, 6 },
                    { 86, new DateTime(2024, 12, 3, 7, 0, 28, 217, DateTimeKind.Local).AddTicks(2758), new DateTime(2024, 12, 4, 7, 0, 28, 217, DateTimeKind.Local).AddTicks(2758), 5, 0, 2099.0, 8 },
                    { 87, new DateTime(2024, 12, 16, 20, 10, 52, 97, DateTimeKind.Local).AddTicks(7704), new DateTime(2024, 12, 26, 20, 10, 52, 97, DateTimeKind.Local).AddTicks(7704), 50, 2, 908.0, 4 },
                    { 88, new DateTime(2025, 1, 15, 17, 56, 28, 952, DateTimeKind.Local).AddTicks(8003), new DateTime(2025, 1, 22, 17, 56, 28, 952, DateTimeKind.Local).AddTicks(8003), 14, 1, 2160.0, 2 },
                    { 89, new DateTime(2024, 12, 25, 11, 16, 56, 792, DateTimeKind.Local).AddTicks(2492), new DateTime(2024, 12, 26, 11, 16, 56, 792, DateTimeKind.Local).AddTicks(2492), 5, 2, 1392.0, 8 },
                    { 90, new DateTime(2024, 12, 24, 19, 38, 47, 267, DateTimeKind.Local).AddTicks(1543), new DateTime(2024, 12, 28, 19, 38, 47, 267, DateTimeKind.Local).AddTicks(1543), 6, 1, 2622.0, 5 },
                    { 91, new DateTime(2024, 12, 9, 6, 59, 30, 215, DateTimeKind.Local).AddTicks(4392), new DateTime(2024, 12, 18, 6, 59, 30, 215, DateTimeKind.Local).AddTicks(4392), 1, 0, 683.0, 3 },
                    { 92, new DateTime(2024, 12, 4, 4, 9, 9, 201, DateTimeKind.Local).AddTicks(3443), new DateTime(2024, 12, 5, 4, 9, 9, 201, DateTimeKind.Local).AddTicks(3443), 26, 0, 1480.0, 4 },
                    { 93, new DateTime(2024, 12, 2, 22, 14, 45, 331, DateTimeKind.Local).AddTicks(935), new DateTime(2024, 12, 5, 22, 14, 45, 331, DateTimeKind.Local).AddTicks(935), 23, 0, 1479.0, 4 },
                    { 94, new DateTime(2025, 1, 5, 20, 20, 24, 882, DateTimeKind.Local).AddTicks(9045), new DateTime(2025, 1, 7, 20, 20, 24, 882, DateTimeKind.Local).AddTicks(9045), 36, 0, 3983.0, 5 },
                    { 95, new DateTime(2024, 12, 2, 6, 38, 53, 774, DateTimeKind.Local).AddTicks(6651), new DateTime(2024, 12, 6, 6, 38, 53, 774, DateTimeKind.Local).AddTicks(6651), 46, 2, 3550.0, 10 },
                    { 96, new DateTime(2024, 11, 30, 20, 54, 31, 437, DateTimeKind.Local).AddTicks(2486), new DateTime(2024, 12, 1, 20, 54, 31, 437, DateTimeKind.Local).AddTicks(2486), 29, 2, 2663.0, 9 },
                    { 97, new DateTime(2025, 1, 3, 7, 39, 20, 51, DateTimeKind.Local).AddTicks(7430), new DateTime(2025, 1, 11, 7, 39, 20, 51, DateTimeKind.Local).AddTicks(7430), 33, 2, 4783.0, 2 },
                    { 98, new DateTime(2024, 12, 26, 6, 32, 23, 87, DateTimeKind.Local).AddTicks(2399), new DateTime(2025, 1, 4, 6, 32, 23, 87, DateTimeKind.Local).AddTicks(2399), 10, 1, 3867.0, 3 },
                    { 99, new DateTime(2024, 12, 28, 10, 58, 40, 214, DateTimeKind.Local).AddTicks(7889), new DateTime(2025, 1, 1, 10, 58, 40, 214, DateTimeKind.Local).AddTicks(7889), 45, 1, 1469.0, 9 },
                    { 100, new DateTime(2025, 1, 5, 13, 54, 28, 151, DateTimeKind.Local).AddTicks(7176), new DateTime(2025, 1, 9, 13, 54, 28, 151, DateTimeKind.Local).AddTicks(7176), 34, 2, 1028.0, 5 }
                });

            migrationBuilder.InsertData(
                table: "Payment",
                columns: new[] { "Id", "Amount", "PaymentDate", "PaymentMethod", "ReservationId", "Status" },
                values: new object[,]
                {
                    { 1, 509.56999999999999, new DateTime(2024, 12, 24, 5, 9, 27, 250, DateTimeKind.Local).AddTicks(2098), 1, 65, 0 },
                    { 2, 318.38999999999999, new DateTime(2024, 12, 26, 21, 5, 55, 82, DateTimeKind.Local).AddTicks(1721), 1, 51, 1 },
                    { 3, 149.90000000000001, new DateTime(2024, 12, 7, 20, 29, 50, 474, DateTimeKind.Local).AddTicks(6295), 1, 12, 0 },
                    { 4, 362.19, new DateTime(2024, 12, 5, 7, 56, 55, 313, DateTimeKind.Local).AddTicks(7851), 0, 11, 0 },
                    { 5, 539.00999999999999, new DateTime(2024, 12, 8, 2, 22, 35, 493, DateTimeKind.Local).AddTicks(7185), 1, 1, 0 },
                    { 6, 609.35000000000002, new DateTime(2024, 12, 15, 17, 21, 6, 236, DateTimeKind.Local).AddTicks(5633), 1, 27, 1 },
                    { 7, 943.41999999999996, new DateTime(2024, 11, 28, 17, 32, 57, 853, DateTimeKind.Local).AddTicks(8664), 0, 76, 1 },
                    { 8, 289.06, new DateTime(2024, 12, 8, 15, 57, 53, 277, DateTimeKind.Local).AddTicks(1278), 0, 49, 1 },
                    { 9, 153.12, new DateTime(2024, 12, 8, 18, 41, 44, 32, DateTimeKind.Local).AddTicks(5096), 1, 54, 0 },
                    { 10, 845.63999999999999, new DateTime(2024, 12, 26, 12, 47, 57, 418, DateTimeKind.Local).AddTicks(9769), 1, 66, 0 },
                    { 11, 710.45000000000005, new DateTime(2024, 12, 18, 13, 56, 25, 151, DateTimeKind.Local).AddTicks(5897), 1, 39, 1 },
                    { 12, 541.12, new DateTime(2024, 12, 25, 14, 4, 36, 0, DateTimeKind.Local).AddTicks(3566), 1, 93, 0 },
                    { 13, 75.689999999999998, new DateTime(2024, 12, 15, 4, 9, 58, 929, DateTimeKind.Local).AddTicks(2998), 0, 65, 0 },
                    { 14, 906.15999999999997, new DateTime(2024, 12, 13, 18, 15, 20, 265, DateTimeKind.Local).AddTicks(4215), 0, 44, 1 },
                    { 15, 658.74000000000001, new DateTime(2024, 12, 10, 10, 14, 28, 973, DateTimeKind.Local).AddTicks(8360), 0, 2, 0 },
                    { 16, 853.41999999999996, new DateTime(2024, 12, 7, 16, 37, 59, 391, DateTimeKind.Local).AddTicks(316), 1, 22, 1 },
                    { 17, 710.34000000000003, new DateTime(2024, 12, 10, 13, 11, 2, 348, DateTimeKind.Local).AddTicks(7141), 0, 92, 0 },
                    { 18, 912.03999999999996, new DateTime(2024, 12, 12, 20, 13, 12, 385, DateTimeKind.Local).AddTicks(444), 1, 61, 0 },
                    { 19, 368.31999999999999, new DateTime(2024, 12, 1, 7, 28, 59, 523, DateTimeKind.Local).AddTicks(7406), 0, 3, 1 },
                    { 20, 934.69000000000005, new DateTime(2024, 12, 8, 17, 35, 11, 830, DateTimeKind.Local).AddTicks(7544), 1, 66, 1 },
                    { 21, 227.09, new DateTime(2024, 12, 11, 11, 3, 57, 162, DateTimeKind.Local).AddTicks(808), 0, 50, 1 },
                    { 22, 155.66, new DateTime(2024, 12, 20, 3, 55, 17, 964, DateTimeKind.Local).AddTicks(4530), 1, 24, 1 },
                    { 23, 699.19000000000005, new DateTime(2024, 12, 4, 8, 1, 42, 387, DateTimeKind.Local).AddTicks(3592), 1, 8, 1 },
                    { 24, 814.89999999999998, new DateTime(2024, 12, 1, 12, 40, 6, 731, DateTimeKind.Local).AddTicks(2044), 1, 62, 1 },
                    { 25, 175.94999999999999, new DateTime(2024, 12, 15, 14, 11, 43, 830, DateTimeKind.Local).AddTicks(6282), 0, 54, 1 },
                    { 26, 516.13, new DateTime(2024, 12, 11, 1, 3, 50, 190, DateTimeKind.Local).AddTicks(5912), 1, 90, 1 },
                    { 27, 84.900000000000006, new DateTime(2024, 12, 27, 9, 38, 49, 102, DateTimeKind.Local).AddTicks(7089), 0, 61, 0 },
                    { 28, 686.66999999999996, new DateTime(2024, 12, 8, 14, 59, 18, 558, DateTimeKind.Local).AddTicks(8814), 1, 18, 0 },
                    { 29, 805.23000000000002, new DateTime(2024, 12, 15, 11, 25, 46, 676, DateTimeKind.Local).AddTicks(5251), 0, 14, 1 },
                    { 30, 870.46000000000004, new DateTime(2024, 12, 10, 10, 16, 30, 629, DateTimeKind.Local).AddTicks(2140), 1, 42, 1 },
                    { 31, 174.84, new DateTime(2024, 12, 16, 22, 10, 55, 880, DateTimeKind.Local).AddTicks(4838), 1, 90, 1 },
                    { 32, 854.0, new DateTime(2024, 11, 29, 12, 11, 30, 528, DateTimeKind.Local).AddTicks(5049), 1, 81, 1 },
                    { 33, 644.82000000000005, new DateTime(2024, 12, 22, 12, 0, 8, 778, DateTimeKind.Local).AddTicks(4297), 0, 43, 1 },
                    { 34, 882.37, new DateTime(2024, 12, 11, 11, 54, 57, 346, DateTimeKind.Local).AddTicks(2003), 0, 23, 1 },
                    { 35, 743.25999999999999, new DateTime(2024, 12, 4, 21, 43, 40, 125, DateTimeKind.Local).AddTicks(179), 1, 80, 0 },
                    { 36, 731.23000000000002, new DateTime(2024, 12, 3, 13, 42, 1, 97, DateTimeKind.Local).AddTicks(6660), 0, 3, 0 },
                    { 37, 720.65999999999997, new DateTime(2024, 12, 14, 12, 47, 28, 271, DateTimeKind.Local).AddTicks(5761), 1, 15, 0 },
                    { 38, 994.70000000000005, new DateTime(2024, 12, 14, 22, 38, 37, 173, DateTimeKind.Local).AddTicks(5715), 1, 64, 1 },
                    { 39, 261.66000000000003, new DateTime(2024, 12, 12, 21, 4, 45, 408, DateTimeKind.Local).AddTicks(4310), 1, 93, 1 },
                    { 40, 885.91999999999996, new DateTime(2024, 12, 3, 11, 25, 54, 950, DateTimeKind.Local).AddTicks(7175), 0, 96, 0 },
                    { 41, 864.53999999999996, new DateTime(2024, 12, 23, 18, 36, 58, 726, DateTimeKind.Local).AddTicks(2719), 0, 34, 1 },
                    { 42, 839.55999999999995, new DateTime(2024, 12, 21, 20, 38, 2, 195, DateTimeKind.Local).AddTicks(568), 0, 50, 1 },
                    { 43, 293.76999999999998, new DateTime(2024, 12, 12, 6, 33, 37, 386, DateTimeKind.Local).AddTicks(324), 1, 41, 0 },
                    { 44, 943.50999999999999, new DateTime(2024, 12, 11, 4, 52, 14, 395, DateTimeKind.Local).AddTicks(9330), 1, 12, 1 },
                    { 45, 654.87, new DateTime(2024, 12, 15, 3, 56, 12, 352, DateTimeKind.Local).AddTicks(9391), 0, 99, 1 },
                    { 46, 465.68000000000001, new DateTime(2024, 12, 9, 22, 42, 45, 21, DateTimeKind.Local).AddTicks(4161), 0, 51, 0 },
                    { 47, 631.36000000000001, new DateTime(2024, 12, 5, 20, 15, 1, 994, DateTimeKind.Local).AddTicks(4431), 1, 8, 0 },
                    { 48, 110.41, new DateTime(2024, 12, 2, 8, 47, 31, 67, DateTimeKind.Local).AddTicks(1308), 1, 21, 1 },
                    { 49, 579.88, new DateTime(2024, 12, 18, 12, 13, 44, 854, DateTimeKind.Local).AddTicks(2703), 0, 83, 0 },
                    { 50, 376.76999999999998, new DateTime(2024, 11, 28, 23, 20, 30, 318, DateTimeKind.Local).AddTicks(6886), 0, 96, 0 },
                    { 51, 769.35000000000002, new DateTime(2024, 12, 23, 6, 13, 43, 320, DateTimeKind.Local).AddTicks(8168), 1, 84, 0 },
                    { 52, 946.13, new DateTime(2024, 12, 10, 14, 19, 19, 445, DateTimeKind.Local).AddTicks(6576), 1, 4, 0 },
                    { 53, 596.76999999999998, new DateTime(2024, 12, 18, 9, 22, 40, 277, DateTimeKind.Local).AddTicks(7660), 1, 55, 0 },
                    { 54, 427.56, new DateTime(2024, 12, 7, 22, 38, 13, 577, DateTimeKind.Local).AddTicks(9887), 1, 22, 1 },
                    { 55, 691.72000000000003, new DateTime(2024, 12, 21, 15, 25, 2, 965, DateTimeKind.Local).AddTicks(3225), 0, 9, 0 },
                    { 56, 128.97999999999999, new DateTime(2024, 12, 22, 23, 5, 57, 921, DateTimeKind.Local).AddTicks(2762), 1, 29, 1 },
                    { 57, 141.09, new DateTime(2024, 12, 22, 3, 56, 10, 597, DateTimeKind.Local).AddTicks(8164), 1, 71, 1 },
                    { 58, 718.80999999999995, new DateTime(2024, 12, 14, 10, 51, 18, 81, DateTimeKind.Local).AddTicks(860), 1, 15, 1 },
                    { 59, 984.47000000000003, new DateTime(2024, 12, 20, 10, 28, 31, 815, DateTimeKind.Local).AddTicks(7121), 0, 18, 0 },
                    { 60, 97.239999999999995, new DateTime(2024, 12, 23, 9, 5, 58, 582, DateTimeKind.Local).AddTicks(9537), 0, 38, 0 },
                    { 61, 558.72000000000003, new DateTime(2024, 12, 4, 8, 3, 33, 322, DateTimeKind.Local).AddTicks(2601), 1, 83, 0 },
                    { 62, 777.39999999999998, new DateTime(2024, 11, 29, 3, 26, 9, 490, DateTimeKind.Local).AddTicks(2566), 0, 10, 1 },
                    { 63, 833.45000000000005, new DateTime(2024, 12, 19, 8, 2, 34, 660, DateTimeKind.Local).AddTicks(3054), 0, 58, 1 },
                    { 64, 393.50999999999999, new DateTime(2024, 12, 12, 12, 13, 13, 957, DateTimeKind.Local).AddTicks(9003), 1, 8, 1 },
                    { 65, 578.46000000000004, new DateTime(2024, 12, 26, 20, 14, 13, 963, DateTimeKind.Local).AddTicks(2708), 0, 29, 1 },
                    { 66, 291.82999999999998, new DateTime(2024, 12, 4, 5, 26, 55, 419, DateTimeKind.Local).AddTicks(9118), 1, 87, 1 },
                    { 67, 641.00999999999999, new DateTime(2024, 12, 2, 5, 18, 23, 272, DateTimeKind.Local).AddTicks(490), 1, 86, 1 },
                    { 68, 770.02999999999997, new DateTime(2024, 12, 23, 4, 11, 30, 558, DateTimeKind.Local).AddTicks(9379), 0, 35, 1 },
                    { 69, 381.48000000000002, new DateTime(2024, 12, 27, 4, 26, 34, 714, DateTimeKind.Local).AddTicks(5453), 0, 62, 1 },
                    { 70, 265.63, new DateTime(2024, 11, 30, 6, 22, 43, 326, DateTimeKind.Local).AddTicks(6539), 1, 16, 1 },
                    { 71, 433.36000000000001, new DateTime(2024, 12, 12, 21, 51, 47, 433, DateTimeKind.Local).AddTicks(109), 0, 37, 1 },
                    { 72, 347.12, new DateTime(2024, 12, 26, 15, 42, 22, 432, DateTimeKind.Local).AddTicks(7529), 1, 15, 1 },
                    { 73, 514.46000000000004, new DateTime(2024, 12, 2, 16, 56, 51, 743, DateTimeKind.Local).AddTicks(4867), 1, 73, 1 },
                    { 74, 129.34, new DateTime(2024, 12, 2, 2, 59, 36, 165, DateTimeKind.Local).AddTicks(8530), 0, 56, 1 },
                    { 75, 74.150000000000006, new DateTime(2024, 12, 9, 17, 46, 51, 201, DateTimeKind.Local).AddTicks(8656), 1, 96, 1 },
                    { 76, 644.75, new DateTime(2024, 12, 23, 7, 48, 23, 555, DateTimeKind.Local).AddTicks(1048), 0, 51, 0 },
                    { 77, 318.19, new DateTime(2024, 12, 15, 6, 22, 42, 758, DateTimeKind.Local).AddTicks(2791), 0, 83, 0 },
                    { 78, 701.97000000000003, new DateTime(2024, 12, 26, 15, 20, 20, 828, DateTimeKind.Local).AddTicks(4615), 1, 92, 0 },
                    { 79, 221.00999999999999, new DateTime(2024, 12, 18, 13, 23, 16, 210, DateTimeKind.Local).AddTicks(2225), 0, 54, 0 },
                    { 80, 762.5, new DateTime(2024, 12, 10, 5, 52, 23, 843, DateTimeKind.Local).AddTicks(1185), 0, 70, 0 }
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
