using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hotel_Management.Migrations
{
    
    public partial class SeedDataMigration : Migration
    {
        
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Amount", "PaymentDate", "PaymentMethod", "ReservationId" },
                values: new object[] { 560.86000000000001, new DateTime(2024, 12, 4, 20, 6, 6, 320, DateTimeKind.Local).AddTicks(4328), 0, 98 });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Amount", "PaymentDate", "PaymentMethod", "ReservationId" },
                values: new object[] { 797.04999999999995, new DateTime(2024, 12, 15, 18, 56, 8, 905, DateTimeKind.Local).AddTicks(2211), 0, 93 });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Amount", "PaymentDate", "PaymentMethod", "ReservationId", "Status" },
                values: new object[] { 838.89999999999998, new DateTime(2024, 12, 17, 8, 42, 47, 249, DateTimeKind.Local).AddTicks(1013), 0, 49, 1 });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Amount", "PaymentDate", "ReservationId", "Status" },
                values: new object[] { 593.63, new DateTime(2024, 12, 25, 20, 52, 25, 968, DateTimeKind.Local).AddTicks(2349), 67, 1 });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Amount", "PaymentDate", "ReservationId" },
                values: new object[] { 561.98000000000002, new DateTime(2024, 12, 13, 14, 27, 5, 516, DateTimeKind.Local).AddTicks(806), 65 });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Amount", "PaymentDate", "ReservationId" },
                values: new object[] { 496.14999999999998, new DateTime(2024, 12, 20, 22, 33, 51, 947, DateTimeKind.Local).AddTicks(5181), 83 });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Amount", "PaymentDate", "PaymentMethod", "ReservationId", "Status" },
                values: new object[] { 503.22000000000003, new DateTime(2024, 12, 31, 1, 11, 9, 12, DateTimeKind.Local).AddTicks(3184), 1, 91, 0 });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Amount", "PaymentDate", "PaymentMethod", "ReservationId", "Status" },
                values: new object[] { 595.25999999999999, new DateTime(2024, 12, 30, 17, 16, 35, 332, DateTimeKind.Local).AddTicks(5028), 1, 75, 0 });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Amount", "PaymentDate", "ReservationId", "Status" },
                values: new object[] { 367.13999999999999, new DateTime(2024, 12, 15, 23, 13, 30, 699, DateTimeKind.Local).AddTicks(1608), 22, 1 });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Amount", "PaymentDate", "ReservationId" },
                values: new object[] { 587.53999999999996, new DateTime(2024, 12, 28, 1, 34, 37, 206, DateTimeKind.Local).AddTicks(410), 33 });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Amount", "PaymentDate", "PaymentMethod", "ReservationId" },
                values: new object[] { 79.349999999999994, new DateTime(2024, 12, 24, 19, 17, 56, 683, DateTimeKind.Local).AddTicks(7435), 0, 87 });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Amount", "PaymentDate", "PaymentMethod", "ReservationId" },
                values: new object[] { 696.40999999999997, new DateTime(2024, 12, 22, 8, 28, 14, 33, DateTimeKind.Local).AddTicks(9610), 0, 89 });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Amount", "PaymentDate", "PaymentMethod", "ReservationId" },
                values: new object[] { 517.99000000000001, new DateTime(2025, 1, 3, 16, 56, 33, 797, DateTimeKind.Local).AddTicks(9788), 1, 31 });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Amount", "PaymentDate", "PaymentMethod", "ReservationId", "Status" },
                values: new object[] { 860.40999999999997, new DateTime(2024, 12, 8, 18, 4, 6, 197, DateTimeKind.Local).AddTicks(3106), 1, 45, 0 });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Amount", "PaymentDate", "PaymentMethod", "ReservationId" },
                values: new object[] { 59.409999999999997, new DateTime(2024, 12, 5, 14, 47, 11, 842, DateTimeKind.Local).AddTicks(7803), 1, 71 });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Amount", "PaymentDate", "PaymentMethod", "ReservationId" },
                values: new object[] { 319.37, new DateTime(2025, 1, 2, 7, 22, 6, 211, DateTimeKind.Local).AddTicks(2276), 0, 6 });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Amount", "PaymentDate", "ReservationId" },
                values: new object[] { 568.50999999999999, new DateTime(2024, 12, 24, 8, 56, 31, 574, DateTimeKind.Local).AddTicks(4018), 20 });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Amount", "PaymentDate", "ReservationId" },
                values: new object[] { 897.47000000000003, new DateTime(2024, 12, 8, 7, 33, 37, 157, DateTimeKind.Local).AddTicks(7864), 95 });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Amount", "PaymentDate", "ReservationId", "Status" },
                values: new object[] { 159.15000000000001, new DateTime(2024, 12, 7, 11, 34, 8, 538, DateTimeKind.Local).AddTicks(7664), 56, 0 });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Amount", "PaymentDate", "ReservationId" },
                values: new object[] { 797.14999999999998, new DateTime(2024, 12, 23, 0, 13, 57, 595, DateTimeKind.Local).AddTicks(3697), 45 });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Amount", "PaymentDate", "ReservationId", "Status" },
                values: new object[] { 692.63, new DateTime(2024, 12, 11, 19, 23, 7, 507, DateTimeKind.Local).AddTicks(329), 39, 0 });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Amount", "PaymentDate", "PaymentMethod", "ReservationId" },
                values: new object[] { 366.72000000000003, new DateTime(2024, 12, 23, 22, 8, 4, 968, DateTimeKind.Local).AddTicks(4433), 0, 61 });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Amount", "PaymentDate", "PaymentMethod", "ReservationId" },
                values: new object[] { 311.37, new DateTime(2024, 12, 8, 2, 0, 6, 295, DateTimeKind.Local).AddTicks(2290), 0, 61 });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Amount", "PaymentDate", "ReservationId" },
                values: new object[] { 582.07000000000005, new DateTime(2024, 12, 4, 21, 6, 34, 974, DateTimeKind.Local).AddTicks(8663), 67 });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Amount", "PaymentDate", "PaymentMethod", "ReservationId", "Status" },
                values: new object[] { 424.79000000000002, new DateTime(2024, 12, 28, 0, 33, 7, 290, DateTimeKind.Local).AddTicks(8410), 1, 73, 0 });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Amount", "PaymentDate", "PaymentMethod", "ReservationId" },
                values: new object[] { 910.98000000000002, new DateTime(2024, 12, 19, 20, 47, 22, 113, DateTimeKind.Local).AddTicks(212), 0, 38 });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Amount", "PaymentDate", "Status" },
                values: new object[] { 134.56, new DateTime(2024, 12, 10, 14, 27, 32, 122, DateTimeKind.Local).AddTicks(8838), 1 });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Amount", "PaymentDate", "PaymentMethod", "ReservationId" },
                values: new object[] { 842.75999999999999, new DateTime(2024, 12, 20, 23, 46, 31, 11, DateTimeKind.Local).AddTicks(7542), 0, 79 });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Amount", "PaymentDate", "ReservationId", "Status" },
                values: new object[] { 612.09000000000003, new DateTime(2024, 12, 15, 6, 34, 36, 737, DateTimeKind.Local).AddTicks(5330), 3, 0 });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Amount", "PaymentDate", "ReservationId", "Status" },
                values: new object[] { 762.01999999999998, new DateTime(2024, 12, 20, 8, 28, 2, 385, DateTimeKind.Local).AddTicks(8804), 53, 0 });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Amount", "PaymentDate", "ReservationId", "Status" },
                values: new object[] { 284.45999999999998, new DateTime(2024, 12, 22, 1, 44, 34, 644, DateTimeKind.Local).AddTicks(162), 19, 0 });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Amount", "PaymentDate", "ReservationId", "Status" },
                values: new object[] { 725.19000000000005, new DateTime(2024, 12, 5, 3, 34, 45, 848, DateTimeKind.Local).AddTicks(9557), 10, 0 });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Amount", "PaymentDate", "PaymentMethod", "ReservationId", "Status" },
                values: new object[] { 990.38, new DateTime(2024, 12, 26, 9, 19, 32, 348, DateTimeKind.Local).AddTicks(4029), 1, 11, 0 });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Amount", "PaymentDate", "PaymentMethod", "ReservationId" },
                values: new object[] { 404.24000000000001, new DateTime(2024, 12, 19, 11, 19, 8, 821, DateTimeKind.Local).AddTicks(5375), 1, 54 });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Amount", "PaymentDate", "ReservationId" },
                values: new object[] { 273.44, new DateTime(2024, 12, 6, 3, 8, 36, 65, DateTimeKind.Local).AddTicks(2167), 62 });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Amount", "PaymentDate", "ReservationId" },
                values: new object[] { 295.89999999999998, new DateTime(2024, 12, 7, 0, 0, 52, 947, DateTimeKind.Local).AddTicks(5224), 80 });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Amount", "PaymentDate", "ReservationId", "Status" },
                values: new object[] { 786.25999999999999, new DateTime(2024, 12, 28, 9, 24, 27, 632, DateTimeKind.Local).AddTicks(4220), 22, 1 });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Amount", "PaymentDate", "ReservationId" },
                values: new object[] { 945.94000000000005, new DateTime(2024, 12, 7, 2, 46, 27, 482, DateTimeKind.Local).AddTicks(8904), 95 });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Amount", "PaymentDate", "PaymentMethod", "ReservationId", "Status" },
                values: new object[] { 462.47000000000003, new DateTime(2024, 12, 16, 15, 58, 15, 999, DateTimeKind.Local).AddTicks(296), 0, 44, 0 });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Amount", "PaymentDate", "ReservationId", "Status" },
                values: new object[] { 97.439999999999998, new DateTime(2024, 12, 21, 8, 50, 25, 68, DateTimeKind.Local).AddTicks(9642), 68, 1 });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Amount", "PaymentDate", "ReservationId" },
                values: new object[] { 199.72999999999999, new DateTime(2024, 12, 17, 18, 34, 35, 999, DateTimeKind.Local).AddTicks(7457), 26 });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Amount", "PaymentDate", "PaymentMethod", "ReservationId", "Status" },
                values: new object[] { 212.33000000000001, new DateTime(2024, 12, 22, 4, 16, 2, 608, DateTimeKind.Local).AddTicks(1089), 1, 29, 0 });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Amount", "PaymentDate", "ReservationId", "Status" },
                values: new object[] { 920.03999999999996, new DateTime(2024, 12, 24, 5, 52, 54, 425, DateTimeKind.Local).AddTicks(9406), 30, 1 });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Amount", "PaymentDate", "ReservationId", "Status" },
                values: new object[] { 305.69999999999999, new DateTime(2024, 12, 8, 11, 37, 46, 505, DateTimeKind.Local).AddTicks(6850), 79, 0 });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Amount", "PaymentDate", "ReservationId" },
                values: new object[] { 629.38, new DateTime(2025, 1, 1, 5, 38, 57, 241, DateTimeKind.Local).AddTicks(6227), 13 });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Amount", "PaymentDate", "PaymentMethod", "ReservationId" },
                values: new object[] { 382.24000000000001, new DateTime(2024, 12, 6, 22, 28, 8, 607, DateTimeKind.Local).AddTicks(6537), 1, 20 });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Amount", "PaymentDate", "PaymentMethod", "ReservationId" },
                values: new object[] { 147.96000000000001, new DateTime(2024, 12, 24, 0, 36, 25, 992, DateTimeKind.Local).AddTicks(388), 0, 5 });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Amount", "PaymentDate", "PaymentMethod", "ReservationId" },
                values: new object[] { 67.849999999999994, new DateTime(2024, 12, 8, 0, 1, 45, 142, DateTimeKind.Local).AddTicks(1652), 0, 51 });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Amount", "PaymentDate", "ReservationId" },
                values: new object[] { 563.01999999999998, new DateTime(2024, 12, 31, 8, 20, 28, 161, DateTimeKind.Local).AddTicks(1116), 30 });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Amount", "PaymentDate", "PaymentMethod", "ReservationId", "Status" },
                values: new object[] { 613.59000000000003, new DateTime(2024, 12, 9, 11, 5, 13, 970, DateTimeKind.Local).AddTicks(5435), 1, 22, 1 });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Amount", "PaymentDate", "PaymentMethod", "ReservationId" },
                values: new object[] { 708.54999999999995, new DateTime(2024, 12, 22, 2, 52, 53, 140, DateTimeKind.Local).AddTicks(2079), 0, 85 });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Amount", "PaymentDate", "PaymentMethod", "ReservationId", "Status" },
                values: new object[] { 462.22000000000003, new DateTime(2024, 12, 14, 13, 39, 19, 641, DateTimeKind.Local).AddTicks(9756), 0, 16, 1 });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Amount", "PaymentDate", "ReservationId", "Status" },
                values: new object[] { 941.32000000000005, new DateTime(2024, 12, 7, 12, 46, 27, 887, DateTimeKind.Local).AddTicks(2911), 45, 1 });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Amount", "PaymentDate", "ReservationId", "Status" },
                values: new object[] { 413.0, new DateTime(2024, 12, 20, 17, 57, 38, 945, DateTimeKind.Local).AddTicks(4409), 40, 0 });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Amount", "PaymentDate", "PaymentMethod", "ReservationId" },
                values: new object[] { 466.0, new DateTime(2024, 12, 16, 18, 45, 10, 358, DateTimeKind.Local).AddTicks(4960), 1, 98 });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Amount", "PaymentDate", "ReservationId" },
                values: new object[] { 90.969999999999999, new DateTime(2024, 12, 18, 13, 7, 42, 395, DateTimeKind.Local).AddTicks(8302), 49 });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Amount", "PaymentDate", "PaymentMethod", "Status" },
                values: new object[] { 113.68000000000001, new DateTime(2024, 12, 9, 12, 20, 26, 771, DateTimeKind.Local).AddTicks(4644), 0, 0 });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Amount", "PaymentDate", "PaymentMethod", "ReservationId", "Status" },
                values: new object[] { 377.48000000000002, new DateTime(2024, 12, 6, 1, 11, 41, 254, DateTimeKind.Local).AddTicks(2619), 0, 32, 0 });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Amount", "PaymentDate", "ReservationId", "Status" },
                values: new object[] { 126.5, new DateTime(2024, 12, 22, 5, 42, 24, 817, DateTimeKind.Local).AddTicks(9798), 6, 1 });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Amount", "PaymentDate", "ReservationId" },
                values: new object[] { 129.13999999999999, new DateTime(2024, 12, 23, 8, 1, 39, 997, DateTimeKind.Local).AddTicks(9253), 7 });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Amount", "PaymentDate", "PaymentMethod", "ReservationId", "Status" },
                values: new object[] { 251.24000000000001, new DateTime(2024, 12, 26, 3, 24, 26, 621, DateTimeKind.Local).AddTicks(7561), 0, 24, 1 });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Amount", "PaymentDate", "ReservationId", "Status" },
                values: new object[] { 208.44, new DateTime(2024, 12, 18, 1, 25, 16, 770, DateTimeKind.Local).AddTicks(6), 50, 0 });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Amount", "PaymentDate", "PaymentMethod", "ReservationId", "Status" },
                values: new object[] { 84.560000000000002, new DateTime(2024, 12, 8, 10, 57, 36, 551, DateTimeKind.Local).AddTicks(746), 1, 12, 0 });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Amount", "PaymentDate", "PaymentMethod", "ReservationId", "Status" },
                values: new object[] { 891.95000000000005, new DateTime(2024, 12, 11, 1, 57, 9, 323, DateTimeKind.Local).AddTicks(9998), 0, 6, 0 });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Amount", "PaymentDate", "ReservationId" },
                values: new object[] { 294.86000000000001, new DateTime(2024, 12, 7, 14, 5, 36, 522, DateTimeKind.Local).AddTicks(3305), 62 });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Amount", "PaymentDate", "PaymentMethod", "ReservationId" },
                values: new object[] { 733.82000000000005, new DateTime(2025, 1, 2, 15, 7, 38, 649, DateTimeKind.Local).AddTicks(6931), 0, 24 });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Amount", "PaymentDate", "PaymentMethod", "ReservationId" },
                values: new object[] { 194.56999999999999, new DateTime(2024, 12, 26, 23, 4, 47, 605, DateTimeKind.Local).AddTicks(4488), 0, 36 });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Amount", "PaymentDate", "ReservationId" },
                values: new object[] { 202.16999999999999, new DateTime(2024, 12, 20, 17, 31, 14, 849, DateTimeKind.Local).AddTicks(747), 31 });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Amount", "PaymentDate", "ReservationId" },
                values: new object[] { 198.56, new DateTime(2024, 12, 5, 22, 49, 59, 25, DateTimeKind.Local).AddTicks(7136), 15 });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Amount", "PaymentDate", "PaymentMethod", "ReservationId" },
                values: new object[] { 201.72999999999999, new DateTime(2024, 12, 7, 9, 12, 5, 454, DateTimeKind.Local).AddTicks(6348), 0, 55 });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Amount", "PaymentDate", "ReservationId" },
                values: new object[] { 541.13, new DateTime(2024, 12, 5, 8, 31, 21, 346, DateTimeKind.Local).AddTicks(5290), 27 });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Amount", "PaymentDate", "ReservationId", "Status" },
                values: new object[] { 130.24000000000001, new DateTime(2024, 12, 18, 12, 16, 53, 612, DateTimeKind.Local).AddTicks(9777), 34, 0 });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Amount", "PaymentDate", "ReservationId", "Status" },
                values: new object[] { 533.38, new DateTime(2024, 12, 29, 16, 12, 32, 550, DateTimeKind.Local).AddTicks(5233), 3, 0 });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Amount", "PaymentDate", "ReservationId" },
                values: new object[] { 248.78, new DateTime(2024, 12, 8, 19, 17, 47, 285, DateTimeKind.Local).AddTicks(2702), 59 });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Amount", "PaymentDate", "ReservationId" },
                values: new object[] { 672.01999999999998, new DateTime(2024, 12, 14, 13, 59, 21, 25, DateTimeKind.Local).AddTicks(5543), 50 });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Amount", "PaymentDate", "ReservationId" },
                values: new object[] { 947.38, new DateTime(2024, 12, 19, 21, 36, 38, 308, DateTimeKind.Local).AddTicks(3707), 1 });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Amount", "PaymentDate", "ReservationId", "Status" },
                values: new object[] { 591.0, new DateTime(2024, 12, 9, 9, 14, 7, 448, DateTimeKind.Local).AddTicks(65), 61, 1 });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Amount", "PaymentDate", "ReservationId", "Status" },
                values: new object[] { 341.16000000000003, new DateTime(2024, 12, 15, 13, 13, 40, 355, DateTimeKind.Local).AddTicks(1428), 56, 1 });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Amount", "PaymentDate", "PaymentMethod", "ReservationId", "Status" },
                values: new object[] { 644.94000000000005, new DateTime(2024, 12, 5, 20, 53, 3, 954, DateTimeKind.Local).AddTicks(7398), 1, 69, 1 });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Amount", "PaymentDate", "ReservationId" },
                values: new object[] { 722.44000000000005, new DateTime(2024, 12, 18, 0, 20, 45, 20, DateTimeKind.Local).AddTicks(7971), 89 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "Status", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2025, 1, 25, 22, 39, 9, 631, DateTimeKind.Local).AddTicks(6077), new DateTime(2025, 2, 2, 22, 39, 9, 631, DateTimeKind.Local).AddTicks(6077), 19, 0, 2575.0, 8 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "Status", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2024, 12, 8, 14, 26, 51, 731, DateTimeKind.Local).AddTicks(300), new DateTime(2024, 12, 15, 14, 26, 51, 731, DateTimeKind.Local).AddTicks(300), 28, 1, 3671.0, 5 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2025, 1, 25, 2, 16, 31, 724, DateTimeKind.Local).AddTicks(9919), new DateTime(2025, 1, 28, 2, 16, 31, 724, DateTimeKind.Local).AddTicks(9919), 20, 2411.0, 6 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2025, 1, 19, 20, 49, 45, 571, DateTimeKind.Local).AddTicks(1767), new DateTime(2025, 1, 22, 20, 49, 45, 571, DateTimeKind.Local).AddTicks(1767), 14, 4111.0, 9 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "Status", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2025, 1, 7, 0, 43, 16, 161, DateTimeKind.Local).AddTicks(499), new DateTime(2025, 1, 12, 0, 43, 16, 161, DateTimeKind.Local).AddTicks(499), 30, 0, 4921.0, 9 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2024, 12, 29, 13, 57, 8, 513, DateTimeKind.Local).AddTicks(3244), new DateTime(2024, 12, 30, 13, 57, 8, 513, DateTimeKind.Local).AddTicks(3244), 20, 3172.0, 2 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2025, 2, 1, 2, 12, 32, 31, DateTimeKind.Local).AddTicks(7360), new DateTime(2025, 2, 7, 2, 12, 32, 31, DateTimeKind.Local).AddTicks(7360), 43, 354.0, 4 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "Status", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2024, 12, 13, 4, 40, 41, 65, DateTimeKind.Local).AddTicks(6274), new DateTime(2024, 12, 16, 4, 40, 41, 65, DateTimeKind.Local).AddTicks(6274), 48, 2, 3387.0, 5 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2024, 12, 16, 12, 0, 13, 336, DateTimeKind.Local).AddTicks(8226), new DateTime(2024, 12, 25, 12, 0, 13, 336, DateTimeKind.Local).AddTicks(8226), 41, 2888.0, 3 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2024, 12, 27, 18, 14, 16, 470, DateTimeKind.Local).AddTicks(837), new DateTime(2025, 1, 6, 18, 14, 16, 470, DateTimeKind.Local).AddTicks(837), 11, 1702.0, 1 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "Status", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2025, 1, 22, 13, 19, 44, 291, DateTimeKind.Local).AddTicks(9742), new DateTime(2025, 1, 31, 13, 19, 44, 291, DateTimeKind.Local).AddTicks(9742), 48, 0, 4378.0, 2 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "Status", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2024, 12, 21, 6, 22, 57, 667, DateTimeKind.Local).AddTicks(1575), new DateTime(2024, 12, 23, 6, 22, 57, 667, DateTimeKind.Local).AddTicks(1575), 46, 2, 185.0, 2 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "Status", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2025, 1, 13, 13, 47, 28, 259, DateTimeKind.Local).AddTicks(6658), new DateTime(2025, 1, 21, 13, 47, 28, 259, DateTimeKind.Local).AddTicks(6658), 25, 0, 151.0, 1 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2024, 12, 18, 4, 7, 40, 589, DateTimeKind.Local).AddTicks(6169), new DateTime(2024, 12, 21, 4, 7, 40, 589, DateTimeKind.Local).AddTicks(6169), 36, 1821.0, 8 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "Status", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2025, 1, 29, 12, 22, 5, 652, DateTimeKind.Local).AddTicks(1630), new DateTime(2025, 2, 7, 12, 22, 5, 652, DateTimeKind.Local).AddTicks(1630), 3, 2, 2161.0, 1 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "Status", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2025, 1, 6, 7, 25, 42, 556, DateTimeKind.Local).AddTicks(6929), new DateTime(2025, 1, 11, 7, 25, 42, 556, DateTimeKind.Local).AddTicks(6929), 25, 0, 2964.0, 9 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2024, 12, 11, 16, 11, 54, 108, DateTimeKind.Local).AddTicks(268), new DateTime(2024, 12, 15, 16, 11, 54, 108, DateTimeKind.Local).AddTicks(268), 6, 4715.0, 6 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "Status", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2025, 2, 1, 1, 55, 30, 976, DateTimeKind.Local).AddTicks(6082), new DateTime(2025, 2, 2, 1, 55, 30, 976, DateTimeKind.Local).AddTicks(6082), 21, 2, 4741.0, 1 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "Status", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2025, 1, 28, 3, 32, 40, 633, DateTimeKind.Local).AddTicks(7843), new DateTime(2025, 2, 7, 3, 32, 40, 633, DateTimeKind.Local).AddTicks(7843), 14, 0, 3921.0, 10 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "Status", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2025, 1, 15, 20, 4, 33, 179, DateTimeKind.Local).AddTicks(3775), new DateTime(2025, 1, 23, 20, 4, 33, 179, DateTimeKind.Local).AddTicks(3775), 5, 0, 3811.0, 5 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "Status", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2024, 12, 6, 10, 41, 14, 16, DateTimeKind.Local).AddTicks(6062), new DateTime(2024, 12, 9, 10, 41, 14, 16, DateTimeKind.Local).AddTicks(6062), 12, 2, 4785.0, 8 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2024, 12, 20, 8, 58, 35, 842, DateTimeKind.Local).AddTicks(1595), new DateTime(2024, 12, 23, 8, 58, 35, 842, DateTimeKind.Local).AddTicks(1595), 46, 4224.0, 7 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "Status", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2025, 1, 24, 14, 4, 9, 752, DateTimeKind.Local).AddTicks(2169), new DateTime(2025, 1, 27, 14, 4, 9, 752, DateTimeKind.Local).AddTicks(2169), 2, 1, 3171.0, 1 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "Status", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2025, 1, 15, 16, 1, 53, 49, DateTimeKind.Local).AddTicks(5306), new DateTime(2025, 1, 21, 16, 1, 53, 49, DateTimeKind.Local).AddTicks(5306), 15, 2, 4557.0, 10 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "Status", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2024, 12, 13, 3, 33, 44, 74, DateTimeKind.Local).AddTicks(8247), new DateTime(2024, 12, 17, 3, 33, 44, 74, DateTimeKind.Local).AddTicks(8247), 40, 0, 1631.0, 2 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2025, 1, 3, 1, 55, 44, 353, DateTimeKind.Local).AddTicks(1784), new DateTime(2025, 1, 10, 1, 55, 44, 353, DateTimeKind.Local).AddTicks(1784), 11, 210.0, 7 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "Status", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2024, 12, 12, 3, 37, 28, 674, DateTimeKind.Local).AddTicks(4582), new DateTime(2024, 12, 16, 3, 37, 28, 674, DateTimeKind.Local).AddTicks(4582), 18, 1, 1210.0, 5 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2025, 1, 1, 5, 4, 13, 308, DateTimeKind.Local).AddTicks(5561), new DateTime(2025, 1, 5, 5, 4, 13, 308, DateTimeKind.Local).AddTicks(5561), 17, 2506.0, 2 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "Status", "TotalPrice" },
                values: new object[] { new DateTime(2025, 1, 17, 20, 14, 11, 38, DateTimeKind.Local).AddTicks(7027), new DateTime(2025, 1, 19, 20, 14, 11, 38, DateTimeKind.Local).AddTicks(7027), 47, 1, 705.0 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "Status", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2025, 1, 10, 13, 40, 43, 780, DateTimeKind.Local).AddTicks(9366), new DateTime(2025, 1, 15, 13, 40, 43, 780, DateTimeKind.Local).AddTicks(9366), 47, 1, 3058.0, 6 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "Status", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2025, 2, 2, 9, 22, 25, 339, DateTimeKind.Local).AddTicks(5560), new DateTime(2025, 2, 12, 9, 22, 25, 339, DateTimeKind.Local).AddTicks(5560), 7, 2, 4362.0, 4 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "Status", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2024, 12, 7, 16, 26, 42, 692, DateTimeKind.Local).AddTicks(7145), new DateTime(2024, 12, 8, 16, 26, 42, 692, DateTimeKind.Local).AddTicks(7145), 5, 1, 3676.0, 1 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2025, 1, 3, 21, 42, 12, 712, DateTimeKind.Local).AddTicks(6653), new DateTime(2025, 1, 4, 21, 42, 12, 712, DateTimeKind.Local).AddTicks(6653), 40, 4970.0, 3 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2025, 1, 11, 20, 28, 8, 236, DateTimeKind.Local).AddTicks(4148), new DateTime(2025, 1, 15, 20, 28, 8, 236, DateTimeKind.Local).AddTicks(4148), 3, 1265.0, 3 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "Status", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2025, 1, 24, 19, 59, 16, 239, DateTimeKind.Local).AddTicks(7190), new DateTime(2025, 2, 2, 19, 59, 16, 239, DateTimeKind.Local).AddTicks(7190), 32, 0, 2870.0, 9 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "Status", "TotalPrice" },
                values: new object[] { new DateTime(2025, 1, 6, 6, 23, 38, 933, DateTimeKind.Local).AddTicks(8450), new DateTime(2025, 1, 11, 6, 23, 38, 933, DateTimeKind.Local).AddTicks(8450), 37, 2, 2471.0 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "TotalPrice" },
                values: new object[] { new DateTime(2024, 12, 4, 23, 34, 21, 516, DateTimeKind.Local).AddTicks(5827), new DateTime(2024, 12, 6, 23, 34, 21, 516, DateTimeKind.Local).AddTicks(5827), 5, 1756.0 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "Status", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2025, 1, 3, 4, 28, 35, 516, DateTimeKind.Local).AddTicks(4048), new DateTime(2025, 1, 5, 4, 28, 35, 516, DateTimeKind.Local).AddTicks(4048), 42, 2, 2713.0, 8 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "Status", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2024, 12, 27, 19, 47, 36, 938, DateTimeKind.Local).AddTicks(6371), new DateTime(2025, 1, 1, 19, 47, 36, 938, DateTimeKind.Local).AddTicks(6371), 49, 0, 1882.0, 6 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "Status", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2024, 12, 30, 12, 46, 55, 664, DateTimeKind.Local).AddTicks(716), new DateTime(2025, 1, 9, 12, 46, 55, 664, DateTimeKind.Local).AddTicks(716), 16, 0, 3524.0, 9 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CheckInDate", "CheckOutDate", "Status", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2024, 12, 15, 17, 44, 45, 910, DateTimeKind.Local).AddTicks(487), new DateTime(2024, 12, 24, 17, 44, 45, 910, DateTimeKind.Local).AddTicks(487), 2, 4434.0, 6 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "Status", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2024, 12, 12, 2, 45, 17, 441, DateTimeKind.Local).AddTicks(9444), new DateTime(2024, 12, 21, 2, 45, 17, 441, DateTimeKind.Local).AddTicks(9444), 41, 2, 4002.0, 4 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2025, 1, 21, 3, 57, 29, 446, DateTimeKind.Local).AddTicks(8395), new DateTime(2025, 1, 25, 3, 57, 29, 446, DateTimeKind.Local).AddTicks(8395), 8, 3827.0, 10 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "Status", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2025, 1, 28, 4, 36, 0, 200, DateTimeKind.Local).AddTicks(8942), new DateTime(2025, 2, 2, 4, 36, 0, 200, DateTimeKind.Local).AddTicks(8942), 3, 1, 3466.0, 3 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2024, 12, 5, 4, 19, 2, 982, DateTimeKind.Local).AddTicks(7818), new DateTime(2024, 12, 9, 4, 19, 2, 982, DateTimeKind.Local).AddTicks(7818), 11, 155.0, 7 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2024, 12, 15, 22, 4, 42, 792, DateTimeKind.Local).AddTicks(6443), new DateTime(2024, 12, 20, 22, 4, 42, 792, DateTimeKind.Local).AddTicks(6443), 26, 3380.0, 5 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2024, 12, 12, 14, 29, 57, 987, DateTimeKind.Local).AddTicks(4628), new DateTime(2024, 12, 19, 14, 29, 57, 987, DateTimeKind.Local).AddTicks(4628), 28, 1041.0, 3 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2025, 1, 3, 4, 30, 59, 273, DateTimeKind.Local).AddTicks(4880), new DateTime(2025, 1, 13, 4, 30, 59, 273, DateTimeKind.Local).AddTicks(4880), 35, 4243.0, 5 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2024, 12, 7, 4, 6, 6, 360, DateTimeKind.Local).AddTicks(2497), new DateTime(2024, 12, 13, 4, 6, 6, 360, DateTimeKind.Local).AddTicks(2497), 16, 215.0, 5 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "Status", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2024, 12, 10, 23, 21, 9, 826, DateTimeKind.Local).AddTicks(2274), new DateTime(2024, 12, 12, 23, 21, 9, 826, DateTimeKind.Local).AddTicks(2274), 16, 2, 1937.0, 8 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "Status", "TotalPrice" },
                values: new object[] { new DateTime(2025, 1, 26, 20, 29, 40, 100, DateTimeKind.Local).AddTicks(1945), new DateTime(2025, 1, 29, 20, 29, 40, 100, DateTimeKind.Local).AddTicks(1945), 28, 0, 3991.0 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2025, 1, 5, 20, 44, 41, 284, DateTimeKind.Local).AddTicks(9150), new DateTime(2025, 1, 10, 20, 44, 41, 284, DateTimeKind.Local).AddTicks(9150), 13, 1827.0, 2 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "Status", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2024, 12, 7, 2, 58, 36, 188, DateTimeKind.Local).AddTicks(504), new DateTime(2024, 12, 12, 2, 58, 36, 188, DateTimeKind.Local).AddTicks(504), 16, 2, 952.0, 3 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "Status", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2025, 1, 3, 3, 13, 26, 685, DateTimeKind.Local).AddTicks(759), new DateTime(2025, 1, 13, 3, 13, 26, 685, DateTimeKind.Local).AddTicks(759), 17, 0, 2794.0, 10 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "Status", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2025, 1, 18, 0, 38, 15, 704, DateTimeKind.Local).AddTicks(2029), new DateTime(2025, 1, 22, 0, 38, 15, 704, DateTimeKind.Local).AddTicks(2029), 14, 1, 1873.0, 7 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "Status", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2024, 12, 27, 22, 0, 54, 335, DateTimeKind.Local).AddTicks(5747), new DateTime(2025, 1, 1, 22, 0, 54, 335, DateTimeKind.Local).AddTicks(5747), 50, 2, 720.0, 8 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "Status", "TotalPrice" },
                values: new object[] { new DateTime(2024, 12, 12, 19, 6, 39, 320, DateTimeKind.Local).AddTicks(6943), new DateTime(2024, 12, 22, 19, 6, 39, 320, DateTimeKind.Local).AddTicks(6943), 31, 0, 3633.0 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "Status", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2024, 12, 7, 0, 16, 20, 963, DateTimeKind.Local).AddTicks(4817), new DateTime(2024, 12, 11, 0, 16, 20, 963, DateTimeKind.Local).AddTicks(4817), 32, 1, 812.0, 4 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2025, 1, 10, 20, 26, 50, 491, DateTimeKind.Local).AddTicks(9035), new DateTime(2025, 1, 20, 20, 26, 50, 491, DateTimeKind.Local).AddTicks(9035), 12, 1717.0, 4 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2024, 12, 16, 23, 14, 51, 548, DateTimeKind.Local).AddTicks(8131), new DateTime(2024, 12, 21, 23, 14, 51, 548, DateTimeKind.Local).AddTicks(8131), 7, 2614.0, 2 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "Status", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2024, 12, 22, 3, 30, 54, 899, DateTimeKind.Local).AddTicks(899), new DateTime(2024, 12, 30, 3, 30, 54, 899, DateTimeKind.Local).AddTicks(899), 5, 0, 3445.0, 3 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "TotalPrice" },
                values: new object[] { new DateTime(2024, 12, 31, 22, 31, 25, 467, DateTimeKind.Local).AddTicks(2891), new DateTime(2025, 1, 2, 22, 31, 25, 467, DateTimeKind.Local).AddTicks(2891), 37, 3379.0 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2025, 1, 30, 11, 49, 21, 20, DateTimeKind.Local).AddTicks(2488), new DateTime(2025, 2, 7, 11, 49, 21, 20, DateTimeKind.Local).AddTicks(2488), 27, 2049.0, 1 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "Status", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2024, 12, 30, 23, 25, 49, 86, DateTimeKind.Local).AddTicks(7329), new DateTime(2025, 1, 7, 23, 25, 49, 86, DateTimeKind.Local).AddTicks(7329), 50, 1, 3537.0, 8 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "Status", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2025, 1, 23, 7, 21, 40, 80, DateTimeKind.Local).AddTicks(8033), new DateTime(2025, 2, 1, 7, 21, 40, 80, DateTimeKind.Local).AddTicks(8033), 17, 1, 924.0, 6 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "Status", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2024, 12, 14, 7, 37, 58, 454, DateTimeKind.Local).AddTicks(6918), new DateTime(2024, 12, 19, 7, 37, 58, 454, DateTimeKind.Local).AddTicks(6918), 8, 1, 4502.0, 7 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "Status", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2024, 12, 28, 6, 3, 47, 136, DateTimeKind.Local).AddTicks(8788), new DateTime(2024, 12, 29, 6, 3, 47, 136, DateTimeKind.Local).AddTicks(8788), 6, 0, 4968.0, 9 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "Status", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2024, 12, 18, 21, 28, 37, 6, DateTimeKind.Local).AddTicks(6431), new DateTime(2024, 12, 21, 21, 28, 37, 6, DateTimeKind.Local).AddTicks(6431), 13, 0, 1097.0, 8 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "Status", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2024, 12, 13, 23, 48, 24, 43, DateTimeKind.Local).AddTicks(13), new DateTime(2024, 12, 21, 23, 48, 24, 43, DateTimeKind.Local).AddTicks(13), 40, 2, 2200.0, 4 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2024, 12, 17, 10, 6, 1, 235, DateTimeKind.Local).AddTicks(6647), new DateTime(2024, 12, 21, 10, 6, 1, 235, DateTimeKind.Local).AddTicks(6647), 20, 1262.0, 6 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "Status", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2025, 1, 18, 8, 29, 5, 355, DateTimeKind.Local).AddTicks(3708), new DateTime(2025, 1, 22, 8, 29, 5, 355, DateTimeKind.Local).AddTicks(3708), 25, 1, 549.0, 1 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "Status", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2025, 1, 17, 14, 22, 50, 368, DateTimeKind.Local).AddTicks(507), new DateTime(2025, 1, 26, 14, 22, 50, 368, DateTimeKind.Local).AddTicks(507), 20, 1, 3061.0, 1 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "Status", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2025, 1, 26, 22, 21, 24, 77, DateTimeKind.Local).AddTicks(5169), new DateTime(2025, 2, 3, 22, 21, 24, 77, DateTimeKind.Local).AddTicks(5169), 42, 0, 4959.0, 4 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "Status", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2025, 1, 2, 23, 18, 47, 771, DateTimeKind.Local).AddTicks(6576), new DateTime(2025, 1, 5, 23, 18, 47, 771, DateTimeKind.Local).AddTicks(6576), 36, 1, 3684.0, 2 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CheckInDate", "CheckOutDate", "Status", "TotalPrice" },
                values: new object[] { new DateTime(2025, 2, 2, 8, 31, 16, 771, DateTimeKind.Local).AddTicks(2037), new DateTime(2025, 2, 5, 8, 31, 16, 771, DateTimeKind.Local).AddTicks(2037), 2, 1881.0 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2024, 12, 15, 9, 22, 0, 354, DateTimeKind.Local).AddTicks(1891), new DateTime(2024, 12, 19, 9, 22, 0, 354, DateTimeKind.Local).AddTicks(1891), 46, 366.0, 2 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2025, 1, 21, 11, 30, 28, 915, DateTimeKind.Local).AddTicks(2320), new DateTime(2025, 1, 25, 11, 30, 28, 915, DateTimeKind.Local).AddTicks(2320), 50, 1964.0, 9 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2024, 12, 24, 4, 49, 21, 533, DateTimeKind.Local).AddTicks(3121), new DateTime(2024, 12, 30, 4, 49, 21, 533, DateTimeKind.Local).AddTicks(3121), 19, 4836.0, 7 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2025, 1, 9, 22, 57, 51, 58, DateTimeKind.Local).AddTicks(6761), new DateTime(2025, 1, 19, 22, 57, 51, 58, DateTimeKind.Local).AddTicks(6761), 14, 843.0, 1 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "Status", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2025, 1, 3, 2, 21, 32, 679, DateTimeKind.Local).AddTicks(1522), new DateTime(2025, 1, 7, 2, 21, 32, 679, DateTimeKind.Local).AddTicks(1522), 23, 2, 349.0, 6 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "TotalPrice" },
                values: new object[] { new DateTime(2024, 12, 22, 22, 37, 55, 717, DateTimeKind.Local).AddTicks(2684), new DateTime(2024, 12, 29, 22, 37, 55, 717, DateTimeKind.Local).AddTicks(2684), 4, 3865.0 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "Status", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2025, 1, 1, 0, 42, 12, 187, DateTimeKind.Local).AddTicks(3478), new DateTime(2025, 1, 6, 0, 42, 12, 187, DateTimeKind.Local).AddTicks(3478), 5, 2, 104.0, 2 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2025, 1, 13, 15, 46, 10, 686, DateTimeKind.Local).AddTicks(1007), new DateTime(2025, 1, 18, 15, 46, 10, 686, DateTimeKind.Local).AddTicks(1007), 13, 1952.0, 9 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "Status", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2024, 12, 31, 12, 29, 22, 358, DateTimeKind.Local).AddTicks(6937), new DateTime(2025, 1, 3, 12, 29, 22, 358, DateTimeKind.Local).AddTicks(6937), 34, 1, 3145.0, 2 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "Status", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2024, 12, 31, 13, 28, 31, 239, DateTimeKind.Local).AddTicks(101), new DateTime(2025, 1, 7, 13, 28, 31, 239, DateTimeKind.Local).AddTicks(101), 31, 2, 1545.0, 5 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2025, 2, 2, 4, 4, 6, 3, DateTimeKind.Local).AddTicks(5784), new DateTime(2025, 2, 11, 4, 4, 6, 3, DateTimeKind.Local).AddTicks(5784), 1, 354.0, 10 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "Status", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2025, 1, 9, 0, 30, 15, 291, DateTimeKind.Local).AddTicks(9921), new DateTime(2025, 1, 10, 0, 30, 15, 291, DateTimeKind.Local).AddTicks(9921), 2, 0, 1781.0, 2 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "Status", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2024, 12, 28, 1, 32, 22, 378, DateTimeKind.Local).AddTicks(3213), new DateTime(2024, 12, 29, 1, 32, 22, 378, DateTimeKind.Local).AddTicks(3213), 32, 0, 287.0, 9 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "Status", "TotalPrice" },
                values: new object[] { new DateTime(2024, 12, 30, 8, 20, 46, 896, DateTimeKind.Local).AddTicks(612), new DateTime(2025, 1, 7, 8, 20, 46, 896, DateTimeKind.Local).AddTicks(612), 49, 0, 1463.0 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2025, 1, 27, 19, 49, 19, 118, DateTimeKind.Local).AddTicks(6795), new DateTime(2025, 1, 30, 19, 49, 19, 118, DateTimeKind.Local).AddTicks(6795), 27, 3201.0, 10 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2025, 2, 1, 11, 36, 11, 773, DateTimeKind.Local).AddTicks(7146), new DateTime(2025, 2, 5, 11, 36, 11, 773, DateTimeKind.Local).AddTicks(7146), 28, 4829.0, 2 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "Status", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2024, 12, 16, 2, 15, 19, 838, DateTimeKind.Local).AddTicks(799), new DateTime(2024, 12, 23, 2, 15, 19, 838, DateTimeKind.Local).AddTicks(799), 18, 2, 3182.0, 2 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "Status", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2025, 1, 18, 19, 28, 16, 624, DateTimeKind.Local).AddTicks(5014), new DateTime(2025, 1, 21, 19, 28, 16, 624, DateTimeKind.Local).AddTicks(5014), 36, 1, 1474.0, 1 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2025, 1, 17, 23, 6, 48, 64, DateTimeKind.Local).AddTicks(5479), new DateTime(2025, 1, 22, 23, 6, 48, 64, DateTimeKind.Local).AddTicks(5479), 5, 4608.0, 2 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2025, 1, 14, 7, 24, 42, 975, DateTimeKind.Local).AddTicks(8647), new DateTime(2025, 1, 15, 7, 24, 42, 975, DateTimeKind.Local).AddTicks(8647), 44, 1657.0, 6 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "Status", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2024, 12, 21, 7, 54, 14, 226, DateTimeKind.Local).AddTicks(7400), new DateTime(2024, 12, 26, 7, 54, 14, 226, DateTimeKind.Local).AddTicks(7400), 26, 0, 1883.0, 6 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "Status", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2024, 12, 23, 4, 19, 0, 224, DateTimeKind.Local).AddTicks(5993), new DateTime(2024, 12, 27, 4, 19, 0, 224, DateTimeKind.Local).AddTicks(5993), 22, 0, 413.0, 10 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2025, 1, 17, 9, 13, 40, 201, DateTimeKind.Local).AddTicks(3337), new DateTime(2025, 1, 21, 9, 13, 40, 201, DateTimeKind.Local).AddTicks(3337), 40, 4518.0, 9 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "Status", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2024, 12, 8, 22, 14, 12, 64, DateTimeKind.Local).AddTicks(6874), new DateTime(2024, 12, 9, 22, 14, 12, 64, DateTimeKind.Local).AddTicks(6874), 4, 0, 517.0, 5 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2025, 1, 4, 18, 51, 55, 984, DateTimeKind.Local).AddTicks(9491), new DateTime(2025, 1, 7, 18, 51, 55, 984, DateTimeKind.Local).AddTicks(9491), 44, 1790.0, 4 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Capacity", "Name", "Price" },
                values: new object[] { 2, "Room 368", 113.0 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Capacity", "IsAvailable", "Name", "Price" },
                values: new object[] { 3, true, "Room 340", 724.0 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Capacity", "IsAvailable", "Name", "Price", "RoomTypeId" },
                values: new object[] { 3, true, "Room 400", 379.0, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Capacity", "Name", "Price" },
                values: new object[] { 3, "Room 109", 701.0 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Capacity", "Name", "Price", "RoomTypeId" },
                values: new object[] { 5, "Room 180", 990.0, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Capacity", "Name", "Price" },
                values: new object[] { 6, "Room 422", 130.0 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "IsAvailable", "Name", "Price", "RoomTypeId" },
                values: new object[] { false, "Room 459", 775.0, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Capacity", "Name", "Price", "RoomTypeId" },
                values: new object[] { 10, "Room 113", 872.0, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "IsAvailable", "Name", "Price" },
                values: new object[] { false, "Room 472", 113.0 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Capacity", "Name", "Price" },
                values: new object[] { 7, "Room 101", 132.0 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Capacity", "IsAvailable", "Name", "Price", "RoomTypeId" },
                values: new object[] { 2, false, "Room 286", 417.0, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Capacity", "Name", "Price", "RoomTypeId" },
                values: new object[] { 1, "Room 120", 980.0, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Capacity", "Name", "Price" },
                values: new object[] { 2, "Room 423", 692.0 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Capacity", "Name", "Price", "RoomTypeId" },
                values: new object[] { 3, "Room 404", 486.0, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Capacity", "Name", "Price", "RoomTypeId" },
                values: new object[] { 4, "Room 158", 151.0, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Capacity", "IsAvailable", "Name", "Price", "RoomTypeId" },
                values: new object[] { 4, true, "Room 458", 734.0, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Capacity", "IsAvailable", "Name", "Price", "RoomTypeId" },
                values: new object[] { 2, false, "Room 254", 503.0, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "IsAvailable", "Name", "Price", "RoomTypeId" },
                values: new object[] { false, "Room 466", 214.0, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Capacity", "Name", "Price", "RoomTypeId" },
                values: new object[] { 7, "Room 198", 363.0, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Capacity", "IsAvailable", "Name", "Price", "RoomTypeId" },
                values: new object[] { 4, true, "Room 180", 986.0, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "IsAvailable", "Name", "Price", "RoomTypeId" },
                values: new object[] { false, "Room 216", 880.0, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Capacity", "Name", "Price" },
                values: new object[] { 4, "Room 306", 93.0 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Capacity", "IsAvailable", "Name", "Price" },
                values: new object[] { 6, true, "Room 279", 709.0 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Capacity", "Name", "Price" },
                values: new object[] { 10, "Room 146", 186.0 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Capacity", "Name", "Price" },
                values: new object[] { 2, "Room 310", 302.0 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Capacity", "Name", "Price" },
                values: new object[] { 4, "Room 296", 988.0 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Capacity", "IsAvailable", "Name", "Price" },
                values: new object[] { 2, true, "Room 424", 384.0 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Capacity", "Name", "Price" },
                values: new object[] { 10, "Room 336", 716.0 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Capacity", "Name", "Price", "RoomTypeId" },
                values: new object[] { 6, "Room 104", 846.0, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Capacity", "Name", "Price", "RoomTypeId" },
                values: new object[] { 8, "Room 196", 98.0, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Capacity", "IsAvailable", "Name", "Price", "RoomTypeId" },
                values: new object[] { 10, false, "Room 169", 62.0, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Capacity", "IsAvailable", "Name", "Price", "RoomTypeId" },
                values: new object[] { 3, false, "Room 348", 340.0, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Capacity", "IsAvailable", "Name", "Price" },
                values: new object[] { 9, false, "Room 412", 136.0 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Capacity", "Name", "Price", "RoomTypeId" },
                values: new object[] { 3, "Room 118", 882.0, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Capacity", "Name", "Price", "RoomTypeId" },
                values: new object[] { 5, "Room 487", 329.0, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Capacity", "IsAvailable", "Name", "Price" },
                values: new object[] { 5, true, "Room 414", 868.0 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Capacity", "Name", "Price", "RoomTypeId" },
                values: new object[] { 9, "Room 442", 625.0, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Capacity", "IsAvailable", "Name", "Price", "RoomTypeId" },
                values: new object[] { 1, true, "Room 135", 765.0, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Capacity", "Name", "Price", "RoomTypeId" },
                values: new object[] { 6, "Room 428", 857.0, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Capacity", "IsAvailable", "Name", "Price", "RoomTypeId" },
                values: new object[] { 7, true, "Room 180", 655.0, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Name", "Price", "RoomTypeId" },
                values: new object[] { "Room 331", 590.0, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Capacity", "Name", "Price", "RoomTypeId" },
                values: new object[] { 6, "Room 486", 451.0, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Capacity", "IsAvailable", "Name", "Price", "RoomTypeId" },
                values: new object[] { 10, false, "Room 224", 480.0, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Capacity", "IsAvailable", "Name", "Price", "RoomTypeId" },
                values: new object[] { 4, false, "Room 163", 132.0, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Capacity", "IsAvailable", "Name", "Price", "RoomTypeId" },
                values: new object[] { 8, true, "Room 256", 703.0, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Capacity", "IsAvailable", "Name", "Price", "RoomTypeId" },
                values: new object[] { 10, false, "Room 371", 228.0, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Capacity", "Name", "Price", "RoomTypeId" },
                values: new object[] { 4, "Room 496", 568.0, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Capacity", "Name", "Price" },
                values: new object[] { 3, "Room 398", 305.0 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Room 278", 258.0 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Capacity", "IsAvailable", "Name", "Price", "RoomTypeId" },
                values: new object[] { 2, false, "Room 436", 66.0, 1 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "$2a$11$PA/okAoy08yPb26yiLeH1OQ8b7J8hDwiJ6VlwYkofKRp/b9rybZ9i");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Email", "FirstName", "LastName", "Password", "PhoneNumber", "Role" },
                values: new object[] { "Joy29@yahoo.com", "Pat", "Streich", "$2a$11$zAlxKA2taD49A.j2sUAE1.0/JTlaN6m7DJKTIQ3qr.5A2iFxJ/cIC", "634-738-6549 x10634", 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Email", "FirstName", "LastName", "Password", "PhoneNumber", "Role" },
                values: new object[] { "Kory8@gmail.com", "Americo", "Langworth", "$2a$11$7y/huFslc0arA0gDvl87FOn4KwGp2RKH/55.Z9lZkjcOWmrQankiS", "1-870-222-7598", 2 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Email", "FirstName", "LastName", "Password", "PhoneNumber", "Role" },
                values: new object[] { "Rod.Goyette@hotmail.com", "Antoinette", "Kerluke", "$2a$11$p5RUmmFQKCFFe4ciyYDh5uZhRxGPMFsR4xNzXkDRHBsS8nPdO6oDi", "856.312.0103", 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Email", "FirstName", "LastName", "Password", "PhoneNumber", "Role" },
                values: new object[] { "Lucie.Monahan33@gmail.com", "Xander", "Schamberger", "$2a$11$EvI76Hl1QG9sSLxFoD.f2Ocixq9rrjuJupeHr.W7UHkEFqPqKLhom", "438-531-5668", 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Email", "FirstName", "LastName", "Password", "PhoneNumber", "Role" },
                values: new object[] { "Rolando37@yahoo.com", "Pat", "Jaskolski", "$2a$11$bmZSrnu/40TTTPPvvoNOKeJ7Ujp3ed45dbq75t0UFlRhpa9bKRxZa", "(292) 730-0767 x702", 2 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Email", "FirstName", "LastName", "Password", "PhoneNumber" },
                values: new object[] { "Efren67@gmail.com", "Eudora", "VonRueden", "$2a$11$rknatDLmSWeDTu.h0.lC6.acYJt0D1.S8HPGaBQK1uY2nSK0kHBfa", "911.507.2219 x9332" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Email", "FirstName", "LastName", "Password", "PhoneNumber", "Role" },
                values: new object[] { "Alysson.Hettinger@yahoo.com", "Geo", "Lockman", "$2a$11$BtX8a7rV85EQ0cAXWnDAnub3ezEWHnU2fIcBbSLARmaREK5dV7IkC", "598.242.0342 x702", 1 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Email", "FirstName", "LastName", "Password", "PhoneNumber", "Role" },
                values: new object[] { "Jaydon84@hotmail.com", "Abbey", "Lueilwitz", "$2a$11$y7ZT4/tOjAyl8XYcIFYljOJj7lEJcTxzTAt.A5lU/AzMOaR52hMg6", "438-525-2571 x2489", 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Email", "FirstName", "LastName", "Password", "PhoneNumber", "Role" },
                values: new object[] { "Loyal_Lehner18@hotmail.com", "Joanny", "Auer", "$2a$11$PEsOf/8Huii.5BW059p0beHV62/Jmb1.FIYYsSVLCISKVlDOwAdca", "377-428-8700 x31963", 2 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Email", "FirstName", "LastName", "Password", "PhoneNumber", "Role" },
                values: new object[] { "Norene_Kunze56@gmail.com", "Alessandro", "Terry", "$2a$11$2u3zVms2qspLQ69e1GSc.eJtKihJeL3koGnOSQjvM4o//UYnVdjS6", "(716) 488-5202", 1 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Email", "FirstName", "LastName", "Password", "PhoneNumber" },
                values: new object[] { "Abbigail76@hotmail.com", "Alayna", "Smith", "$2a$11$QxAZ/7yP0qFMOsYiKvcd7u.fl7IrODB2jBwvwK6R9u9RRNZwMlxgC", "(236) 500-5995" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Email", "FirstName", "LastName", "Password", "PhoneNumber", "Role" },
                values: new object[] { "Dejuan_Leffler72@gmail.com", "Beverly", "Abbott", "$2a$11$7805iBIvzSMuqHXv6j8IKu0NHZg2dTS1/CDNoyfYdOLCWpNZbYHmC", "830-621-6293", 2 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Email", "FirstName", "LastName", "Password", "PhoneNumber", "Role" },
                values: new object[] { "Harold_Wolf@yahoo.com", "Emelie", "Fritsch", "$2a$11$ij2uK5UyjYf0/ME5RglQ6us2.FRCcLYLKh.VULLSWgqwGwMYegJXu", "(510) 260-1845 x566", 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Email", "FirstName", "LastName", "Password", "PhoneNumber" },
                values: new object[] { "Salvatore.Bogan91@yahoo.com", "Rod", "Monahan", "$2a$11$rWTjbOfdOcVy.jjXUat.veXmosN//DOnhMAXV7yhmGwLrDcghlFBS", "919-836-6811" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Email", "FirstName", "LastName", "Password", "PhoneNumber", "Role" },
                values: new object[] { "Berta95@yahoo.com", "Ricardo", "Crist", "$2a$11$wCrRZzvGe1UBaCQSdXCCHe7sx7mLbkZbK34WjtDx0VwalpS3mdqD2", "981.933.9218 x49096", 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Email", "FirstName", "LastName", "Password", "PhoneNumber", "Role" },
                values: new object[] { "Jon6@gmail.com", "Jarrell", "Lesch", "$2a$11$TSbqwDYEX/63DLwbK8ou9.Ryd92XPhcKJH6gP4x2GNTp.CNkTfHO.", "873-788-5481", 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Email", "FirstName", "LastName", "Password", "PhoneNumber", "Role" },
                values: new object[] { "Eloise29@hotmail.com", "Myrtis", "Kessler", "$2a$11$U9DPj.dlcel.h531ZmkTWeA.csNENcWJoyeFKNof88cbe5sxJAjyG", "738.461.2103 x274", 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Email", "FirstName", "LastName", "Password", "PhoneNumber" },
                values: new object[] { "Gerda.Hayes88@hotmail.com", "Albin", "Kris", "$2a$11$Vl08MRLX.EjXy2VnoBdrHuBdArCmPltZsae4KEXIID6HmuEA3.f.G", "614-660-1766 x797" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Email", "FirstName", "LastName", "Password", "PhoneNumber", "Role" },
                values: new object[] { "Jerry0@yahoo.com", "Marcel", "Kreiger", "$2a$11$JHM/wHEOed0P8A4t.NzR7OZhDpqu.b9MnoHmpbCpk2AFZeEB3oUyK", "1-793-386-0427 x8549", 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Email", "FirstName", "LastName", "Password", "PhoneNumber", "Role" },
                values: new object[] { "Adolfo.Moore22@gmail.com", "Rudolph", "McLaughlin", "$2a$11$gMpoqdFXUV/Bg4N6z0tYNeVRvQKvBfsO4jLFKeVqK04n.YeUJCRmy", "730.616.4743", 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Email", "FirstName", "LastName", "Password", "PhoneNumber", "Role" },
                values: new object[] { "Berniece_Cummerata43@gmail.com", "Joshuah", "Hagenes", "$2a$11$ejUIueH96e176jHMsXg7yeZ2RQ0FVfNHqcTmz8MmUAAVEKXZcnAf2", "889.533.0216 x09580", 2 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Email", "FirstName", "LastName", "Password", "PhoneNumber", "Role" },
                values: new object[] { "Ryder.Okuneva@gmail.com", "Hortense", "McCullough", "$2a$11$t8IrAhCNOQK8aRSFdwRvKOp17A8aR9izlrUi0KUqiT588obEJ7k3C", "930-696-5390", 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Email", "FirstName", "LastName", "Password", "PhoneNumber" },
                values: new object[] { "Sherman_Johnson@gmail.com", "Cleo", "Dicki", "$2a$11$OyFt5.0.MFx/F1V9ipz37.V8Jo4x9hM2IxanaqOLT04PxWPvE.Kb6", "640-682-1419 x1659" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Email", "FirstName", "LastName", "Password", "PhoneNumber", "Role" },
                values: new object[] { "Wilma_Herman@gmail.com", "Cierra", "Heller", "$2a$11$EH9yT5yZh7/J3qxzwUu0luWcAmk40CL5.8WooxN/2uKENz23NBgDm", "329.288.1884 x8809", 1 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Email", "FirstName", "LastName", "Password", "PhoneNumber" },
                values: new object[] { "Anastacio48@gmail.com", "Gracie", "Erdman", "$2a$11$M3dHWP0sf0jaT/5Kt7fzte/nnZObaYM1Nejqbo27ZYeg9xr2DTOPu", "909-846-7259" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Amount", "PaymentDate", "PaymentMethod", "ReservationId" },
                values: new object[] { 509.56999999999999, new DateTime(2024, 12, 24, 5, 9, 27, 250, DateTimeKind.Local).AddTicks(2098), 1, 65 });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Amount", "PaymentDate", "PaymentMethod", "ReservationId" },
                values: new object[] { 318.38999999999999, new DateTime(2024, 12, 26, 21, 5, 55, 82, DateTimeKind.Local).AddTicks(1721), 1, 51 });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Amount", "PaymentDate", "PaymentMethod", "ReservationId", "Status" },
                values: new object[] { 149.90000000000001, new DateTime(2024, 12, 7, 20, 29, 50, 474, DateTimeKind.Local).AddTicks(6295), 1, 12, 0 });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Amount", "PaymentDate", "ReservationId", "Status" },
                values: new object[] { 362.19, new DateTime(2024, 12, 5, 7, 56, 55, 313, DateTimeKind.Local).AddTicks(7851), 11, 0 });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Amount", "PaymentDate", "ReservationId" },
                values: new object[] { 539.00999999999999, new DateTime(2024, 12, 8, 2, 22, 35, 493, DateTimeKind.Local).AddTicks(7185), 1 });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Amount", "PaymentDate", "ReservationId" },
                values: new object[] { 609.35000000000002, new DateTime(2024, 12, 15, 17, 21, 6, 236, DateTimeKind.Local).AddTicks(5633), 27 });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Amount", "PaymentDate", "PaymentMethod", "ReservationId", "Status" },
                values: new object[] { 943.41999999999996, new DateTime(2024, 11, 28, 17, 32, 57, 853, DateTimeKind.Local).AddTicks(8664), 0, 76, 1 });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Amount", "PaymentDate", "PaymentMethod", "ReservationId", "Status" },
                values: new object[] { 289.06, new DateTime(2024, 12, 8, 15, 57, 53, 277, DateTimeKind.Local).AddTicks(1278), 0, 49, 1 });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Amount", "PaymentDate", "ReservationId", "Status" },
                values: new object[] { 153.12, new DateTime(2024, 12, 8, 18, 41, 44, 32, DateTimeKind.Local).AddTicks(5096), 54, 0 });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Amount", "PaymentDate", "ReservationId" },
                values: new object[] { 845.63999999999999, new DateTime(2024, 12, 26, 12, 47, 57, 418, DateTimeKind.Local).AddTicks(9769), 66 });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Amount", "PaymentDate", "PaymentMethod", "ReservationId" },
                values: new object[] { 710.45000000000005, new DateTime(2024, 12, 18, 13, 56, 25, 151, DateTimeKind.Local).AddTicks(5897), 1, 39 });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Amount", "PaymentDate", "PaymentMethod", "ReservationId" },
                values: new object[] { 541.12, new DateTime(2024, 12, 25, 14, 4, 36, 0, DateTimeKind.Local).AddTicks(3566), 1, 93 });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Amount", "PaymentDate", "PaymentMethod", "ReservationId" },
                values: new object[] { 75.689999999999998, new DateTime(2024, 12, 15, 4, 9, 58, 929, DateTimeKind.Local).AddTicks(2998), 0, 65 });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Amount", "PaymentDate", "PaymentMethod", "ReservationId", "Status" },
                values: new object[] { 906.15999999999997, new DateTime(2024, 12, 13, 18, 15, 20, 265, DateTimeKind.Local).AddTicks(4215), 0, 44, 1 });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Amount", "PaymentDate", "PaymentMethod", "ReservationId" },
                values: new object[] { 658.74000000000001, new DateTime(2024, 12, 10, 10, 14, 28, 973, DateTimeKind.Local).AddTicks(8360), 0, 2 });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Amount", "PaymentDate", "PaymentMethod", "ReservationId" },
                values: new object[] { 853.41999999999996, new DateTime(2024, 12, 7, 16, 37, 59, 391, DateTimeKind.Local).AddTicks(316), 1, 22 });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Amount", "PaymentDate", "ReservationId" },
                values: new object[] { 710.34000000000003, new DateTime(2024, 12, 10, 13, 11, 2, 348, DateTimeKind.Local).AddTicks(7141), 92 });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Amount", "PaymentDate", "ReservationId" },
                values: new object[] { 912.03999999999996, new DateTime(2024, 12, 12, 20, 13, 12, 385, DateTimeKind.Local).AddTicks(444), 61 });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Amount", "PaymentDate", "ReservationId", "Status" },
                values: new object[] { 368.31999999999999, new DateTime(2024, 12, 1, 7, 28, 59, 523, DateTimeKind.Local).AddTicks(7406), 3, 1 });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Amount", "PaymentDate", "ReservationId" },
                values: new object[] { 934.69000000000005, new DateTime(2024, 12, 8, 17, 35, 11, 830, DateTimeKind.Local).AddTicks(7544), 66 });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Amount", "PaymentDate", "ReservationId", "Status" },
                values: new object[] { 227.09, new DateTime(2024, 12, 11, 11, 3, 57, 162, DateTimeKind.Local).AddTicks(808), 50, 1 });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Amount", "PaymentDate", "PaymentMethod", "ReservationId" },
                values: new object[] { 155.66, new DateTime(2024, 12, 20, 3, 55, 17, 964, DateTimeKind.Local).AddTicks(4530), 1, 24 });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Amount", "PaymentDate", "PaymentMethod", "ReservationId" },
                values: new object[] { 699.19000000000005, new DateTime(2024, 12, 4, 8, 1, 42, 387, DateTimeKind.Local).AddTicks(3592), 1, 8 });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Amount", "PaymentDate", "ReservationId" },
                values: new object[] { 814.89999999999998, new DateTime(2024, 12, 1, 12, 40, 6, 731, DateTimeKind.Local).AddTicks(2044), 62 });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Amount", "PaymentDate", "PaymentMethod", "ReservationId", "Status" },
                values: new object[] { 175.94999999999999, new DateTime(2024, 12, 15, 14, 11, 43, 830, DateTimeKind.Local).AddTicks(6282), 0, 54, 1 });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Amount", "PaymentDate", "PaymentMethod", "ReservationId" },
                values: new object[] { 516.13, new DateTime(2024, 12, 11, 1, 3, 50, 190, DateTimeKind.Local).AddTicks(5912), 1, 90 });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Amount", "PaymentDate", "Status" },
                values: new object[] { 84.900000000000006, new DateTime(2024, 12, 27, 9, 38, 49, 102, DateTimeKind.Local).AddTicks(7089), 0 });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Amount", "PaymentDate", "PaymentMethod", "ReservationId" },
                values: new object[] { 686.66999999999996, new DateTime(2024, 12, 8, 14, 59, 18, 558, DateTimeKind.Local).AddTicks(8814), 1, 18 });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Amount", "PaymentDate", "ReservationId", "Status" },
                values: new object[] { 805.23000000000002, new DateTime(2024, 12, 15, 11, 25, 46, 676, DateTimeKind.Local).AddTicks(5251), 14, 1 });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Amount", "PaymentDate", "ReservationId", "Status" },
                values: new object[] { 870.46000000000004, new DateTime(2024, 12, 10, 10, 16, 30, 629, DateTimeKind.Local).AddTicks(2140), 42, 1 });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Amount", "PaymentDate", "ReservationId", "Status" },
                values: new object[] { 174.84, new DateTime(2024, 12, 16, 22, 10, 55, 880, DateTimeKind.Local).AddTicks(4838), 90, 1 });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Amount", "PaymentDate", "ReservationId", "Status" },
                values: new object[] { 854.0, new DateTime(2024, 11, 29, 12, 11, 30, 528, DateTimeKind.Local).AddTicks(5049), 81, 1 });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Amount", "PaymentDate", "PaymentMethod", "ReservationId", "Status" },
                values: new object[] { 644.82000000000005, new DateTime(2024, 12, 22, 12, 0, 8, 778, DateTimeKind.Local).AddTicks(4297), 0, 43, 1 });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Amount", "PaymentDate", "PaymentMethod", "ReservationId" },
                values: new object[] { 882.37, new DateTime(2024, 12, 11, 11, 54, 57, 346, DateTimeKind.Local).AddTicks(2003), 0, 23 });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Amount", "PaymentDate", "ReservationId" },
                values: new object[] { 743.25999999999999, new DateTime(2024, 12, 4, 21, 43, 40, 125, DateTimeKind.Local).AddTicks(179), 80 });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Amount", "PaymentDate", "ReservationId" },
                values: new object[] { 731.23000000000002, new DateTime(2024, 12, 3, 13, 42, 1, 97, DateTimeKind.Local).AddTicks(6660), 3 });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Amount", "PaymentDate", "ReservationId", "Status" },
                values: new object[] { 720.65999999999997, new DateTime(2024, 12, 14, 12, 47, 28, 271, DateTimeKind.Local).AddTicks(5761), 15, 0 });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Amount", "PaymentDate", "ReservationId" },
                values: new object[] { 994.70000000000005, new DateTime(2024, 12, 14, 22, 38, 37, 173, DateTimeKind.Local).AddTicks(5715), 64 });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Amount", "PaymentDate", "PaymentMethod", "ReservationId", "Status" },
                values: new object[] { 261.66000000000003, new DateTime(2024, 12, 12, 21, 4, 45, 408, DateTimeKind.Local).AddTicks(4310), 1, 93, 1 });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Amount", "PaymentDate", "ReservationId", "Status" },
                values: new object[] { 885.91999999999996, new DateTime(2024, 12, 3, 11, 25, 54, 950, DateTimeKind.Local).AddTicks(7175), 96, 0 });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Amount", "PaymentDate", "ReservationId" },
                values: new object[] { 864.53999999999996, new DateTime(2024, 12, 23, 18, 36, 58, 726, DateTimeKind.Local).AddTicks(2719), 34 });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Amount", "PaymentDate", "PaymentMethod", "ReservationId", "Status" },
                values: new object[] { 839.55999999999995, new DateTime(2024, 12, 21, 20, 38, 2, 195, DateTimeKind.Local).AddTicks(568), 0, 50, 1 });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Amount", "PaymentDate", "ReservationId", "Status" },
                values: new object[] { 293.76999999999998, new DateTime(2024, 12, 12, 6, 33, 37, 386, DateTimeKind.Local).AddTicks(324), 41, 0 });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Amount", "PaymentDate", "ReservationId", "Status" },
                values: new object[] { 943.50999999999999, new DateTime(2024, 12, 11, 4, 52, 14, 395, DateTimeKind.Local).AddTicks(9330), 12, 1 });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Amount", "PaymentDate", "ReservationId" },
                values: new object[] { 654.87, new DateTime(2024, 12, 15, 3, 56, 12, 352, DateTimeKind.Local).AddTicks(9391), 99 });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Amount", "PaymentDate", "PaymentMethod", "ReservationId" },
                values: new object[] { 465.68000000000001, new DateTime(2024, 12, 9, 22, 42, 45, 21, DateTimeKind.Local).AddTicks(4161), 0, 51 });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Amount", "PaymentDate", "PaymentMethod", "ReservationId" },
                values: new object[] { 631.36000000000001, new DateTime(2024, 12, 5, 20, 15, 1, 994, DateTimeKind.Local).AddTicks(4431), 1, 8 });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Amount", "PaymentDate", "PaymentMethod", "ReservationId" },
                values: new object[] { 110.41, new DateTime(2024, 12, 2, 8, 47, 31, 67, DateTimeKind.Local).AddTicks(1308), 1, 21 });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Amount", "PaymentDate", "ReservationId" },
                values: new object[] { 579.88, new DateTime(2024, 12, 18, 12, 13, 44, 854, DateTimeKind.Local).AddTicks(2703), 83 });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Amount", "PaymentDate", "PaymentMethod", "ReservationId", "Status" },
                values: new object[] { 376.76999999999998, new DateTime(2024, 11, 28, 23, 20, 30, 318, DateTimeKind.Local).AddTicks(6886), 0, 96, 0 });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Amount", "PaymentDate", "PaymentMethod", "ReservationId" },
                values: new object[] { 769.35000000000002, new DateTime(2024, 12, 23, 6, 13, 43, 320, DateTimeKind.Local).AddTicks(8168), 1, 84 });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Amount", "PaymentDate", "PaymentMethod", "ReservationId", "Status" },
                values: new object[] { 946.13, new DateTime(2024, 12, 10, 14, 19, 19, 445, DateTimeKind.Local).AddTicks(6576), 1, 4, 0 });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Amount", "PaymentDate", "ReservationId", "Status" },
                values: new object[] { 596.76999999999998, new DateTime(2024, 12, 18, 9, 22, 40, 277, DateTimeKind.Local).AddTicks(7660), 55, 0 });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Amount", "PaymentDate", "ReservationId", "Status" },
                values: new object[] { 427.56, new DateTime(2024, 12, 7, 22, 38, 13, 577, DateTimeKind.Local).AddTicks(9887), 22, 1 });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Amount", "PaymentDate", "PaymentMethod", "ReservationId" },
                values: new object[] { 691.72000000000003, new DateTime(2024, 12, 21, 15, 25, 2, 965, DateTimeKind.Local).AddTicks(3225), 0, 9 });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Amount", "PaymentDate", "ReservationId" },
                values: new object[] { 128.97999999999999, new DateTime(2024, 12, 22, 23, 5, 57, 921, DateTimeKind.Local).AddTicks(2762), 29 });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Amount", "PaymentDate", "PaymentMethod", "Status" },
                values: new object[] { 141.09, new DateTime(2024, 12, 22, 3, 56, 10, 597, DateTimeKind.Local).AddTicks(8164), 1, 1 });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Amount", "PaymentDate", "PaymentMethod", "ReservationId", "Status" },
                values: new object[] { 718.80999999999995, new DateTime(2024, 12, 14, 10, 51, 18, 81, DateTimeKind.Local).AddTicks(860), 1, 15, 1 });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Amount", "PaymentDate", "ReservationId", "Status" },
                values: new object[] { 984.47000000000003, new DateTime(2024, 12, 20, 10, 28, 31, 815, DateTimeKind.Local).AddTicks(7121), 18, 0 });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Amount", "PaymentDate", "ReservationId" },
                values: new object[] { 97.239999999999995, new DateTime(2024, 12, 23, 9, 5, 58, 582, DateTimeKind.Local).AddTicks(9537), 38 });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Amount", "PaymentDate", "PaymentMethod", "ReservationId", "Status" },
                values: new object[] { 558.72000000000003, new DateTime(2024, 12, 4, 8, 3, 33, 322, DateTimeKind.Local).AddTicks(2601), 1, 83, 0 });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Amount", "PaymentDate", "ReservationId", "Status" },
                values: new object[] { 777.39999999999998, new DateTime(2024, 11, 29, 3, 26, 9, 490, DateTimeKind.Local).AddTicks(2566), 10, 1 });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Amount", "PaymentDate", "PaymentMethod", "ReservationId", "Status" },
                values: new object[] { 833.45000000000005, new DateTime(2024, 12, 19, 8, 2, 34, 660, DateTimeKind.Local).AddTicks(3054), 0, 58, 1 });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Amount", "PaymentDate", "PaymentMethod", "ReservationId", "Status" },
                values: new object[] { 393.50999999999999, new DateTime(2024, 12, 12, 12, 13, 13, 957, DateTimeKind.Local).AddTicks(9003), 1, 8, 1 });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Amount", "PaymentDate", "ReservationId" },
                values: new object[] { 578.46000000000004, new DateTime(2024, 12, 26, 20, 14, 13, 963, DateTimeKind.Local).AddTicks(2708), 29 });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Amount", "PaymentDate", "PaymentMethod", "ReservationId" },
                values: new object[] { 291.82999999999998, new DateTime(2024, 12, 4, 5, 26, 55, 419, DateTimeKind.Local).AddTicks(9118), 1, 87 });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Amount", "PaymentDate", "PaymentMethod", "ReservationId" },
                values: new object[] { 641.00999999999999, new DateTime(2024, 12, 2, 5, 18, 23, 272, DateTimeKind.Local).AddTicks(490), 1, 86 });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Amount", "PaymentDate", "ReservationId" },
                values: new object[] { 770.02999999999997, new DateTime(2024, 12, 23, 4, 11, 30, 558, DateTimeKind.Local).AddTicks(9379), 35 });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Amount", "PaymentDate", "ReservationId" },
                values: new object[] { 381.48000000000002, new DateTime(2024, 12, 27, 4, 26, 34, 714, DateTimeKind.Local).AddTicks(5453), 62 });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Amount", "PaymentDate", "PaymentMethod", "ReservationId" },
                values: new object[] { 265.63, new DateTime(2024, 11, 30, 6, 22, 43, 326, DateTimeKind.Local).AddTicks(6539), 1, 16 });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Amount", "PaymentDate", "ReservationId" },
                values: new object[] { 433.36000000000001, new DateTime(2024, 12, 12, 21, 51, 47, 433, DateTimeKind.Local).AddTicks(109), 37 });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Amount", "PaymentDate", "ReservationId", "Status" },
                values: new object[] { 347.12, new DateTime(2024, 12, 26, 15, 42, 22, 432, DateTimeKind.Local).AddTicks(7529), 15, 1 });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Amount", "PaymentDate", "ReservationId", "Status" },
                values: new object[] { 514.46000000000004, new DateTime(2024, 12, 2, 16, 56, 51, 743, DateTimeKind.Local).AddTicks(4867), 73, 1 });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Amount", "PaymentDate", "ReservationId" },
                values: new object[] { 129.34, new DateTime(2024, 12, 2, 2, 59, 36, 165, DateTimeKind.Local).AddTicks(8530), 56 });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Amount", "PaymentDate", "ReservationId" },
                values: new object[] { 74.150000000000006, new DateTime(2024, 12, 9, 17, 46, 51, 201, DateTimeKind.Local).AddTicks(8656), 96 });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Amount", "PaymentDate", "ReservationId" },
                values: new object[] { 644.75, new DateTime(2024, 12, 23, 7, 48, 23, 555, DateTimeKind.Local).AddTicks(1048), 51 });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Amount", "PaymentDate", "ReservationId", "Status" },
                values: new object[] { 318.19, new DateTime(2024, 12, 15, 6, 22, 42, 758, DateTimeKind.Local).AddTicks(2791), 83, 0 });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Amount", "PaymentDate", "ReservationId", "Status" },
                values: new object[] { 701.97000000000003, new DateTime(2024, 12, 26, 15, 20, 20, 828, DateTimeKind.Local).AddTicks(4615), 92, 0 });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Amount", "PaymentDate", "PaymentMethod", "ReservationId", "Status" },
                values: new object[] { 221.00999999999999, new DateTime(2024, 12, 18, 13, 23, 16, 210, DateTimeKind.Local).AddTicks(2225), 0, 54, 0 });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Amount", "PaymentDate", "ReservationId" },
                values: new object[] { 762.5, new DateTime(2024, 12, 10, 5, 52, 23, 843, DateTimeKind.Local).AddTicks(1185), 70 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "Status", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2024, 12, 6, 7, 0, 37, 112, DateTimeKind.Local).AddTicks(2344), new DateTime(2024, 12, 16, 7, 0, 37, 112, DateTimeKind.Local).AddTicks(2344), 26, 2, 2735.0, 4 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "Status", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2025, 1, 5, 22, 2, 4, 628, DateTimeKind.Local).AddTicks(8850), new DateTime(2025, 1, 14, 22, 2, 4, 628, DateTimeKind.Local).AddTicks(8850), 43, 2, 4965.0, 8 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2025, 1, 21, 1, 26, 32, 585, DateTimeKind.Local).AddTicks(5633), new DateTime(2025, 1, 30, 1, 26, 32, 585, DateTimeKind.Local).AddTicks(5633), 11, 3190.0, 8 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2025, 1, 8, 20, 6, 40, 573, DateTimeKind.Local).AddTicks(969), new DateTime(2025, 1, 10, 20, 6, 40, 573, DateTimeKind.Local).AddTicks(969), 31, 1035.0, 2 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "Status", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2024, 12, 4, 7, 21, 4, 2, DateTimeKind.Local).AddTicks(3794), new DateTime(2024, 12, 5, 7, 21, 4, 2, DateTimeKind.Local).AddTicks(3794), 4, 1, 3948.0, 2 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2025, 1, 3, 22, 0, 0, 755, DateTimeKind.Local).AddTicks(3181), new DateTime(2025, 1, 12, 22, 0, 0, 755, DateTimeKind.Local).AddTicks(3181), 41, 4506.0, 5 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2024, 12, 11, 23, 36, 0, 248, DateTimeKind.Local).AddTicks(2327), new DateTime(2024, 12, 13, 23, 36, 0, 248, DateTimeKind.Local).AddTicks(2327), 33, 265.0, 2 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "Status", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2024, 12, 25, 7, 34, 5, 637, DateTimeKind.Local).AddTicks(7709), new DateTime(2024, 12, 31, 7, 34, 5, 637, DateTimeKind.Local).AddTicks(7709), 12, 0, 4744.0, 7 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2024, 12, 26, 4, 17, 45, 127, DateTimeKind.Local).AddTicks(716), new DateTime(2024, 12, 28, 4, 17, 45, 127, DateTimeKind.Local).AddTicks(716), 10, 1680.0, 1 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2025, 1, 15, 12, 57, 43, 497, DateTimeKind.Local).AddTicks(6994), new DateTime(2025, 1, 24, 12, 57, 43, 497, DateTimeKind.Local).AddTicks(6994), 30, 1653.0, 2 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "Status", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2024, 12, 19, 15, 21, 5, 6, DateTimeKind.Local).AddTicks(7559), new DateTime(2024, 12, 22, 15, 21, 5, 6, DateTimeKind.Local).AddTicks(7559), 31, 1, 4688.0, 3 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "Status", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2024, 11, 28, 19, 6, 3, 48, DateTimeKind.Local).AddTicks(8947), new DateTime(2024, 12, 6, 19, 6, 3, 48, DateTimeKind.Local).AddTicks(8947), 45, 0, 679.0, 4 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "Status", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2025, 1, 13, 15, 40, 53, 701, DateTimeKind.Local).AddTicks(421), new DateTime(2025, 1, 17, 15, 40, 53, 701, DateTimeKind.Local).AddTicks(421), 48, 1, 2482.0, 3 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2025, 1, 24, 2, 7, 16, 944, DateTimeKind.Local).AddTicks(6838), new DateTime(2025, 2, 1, 2, 7, 16, 944, DateTimeKind.Local).AddTicks(6838), 43, 927.0, 1 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "Status", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2024, 12, 14, 15, 26, 51, 927, DateTimeKind.Local).AddTicks(1207), new DateTime(2024, 12, 18, 15, 26, 51, 927, DateTimeKind.Local).AddTicks(1207), 24, 1, 1154.0, 10 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "Status", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2025, 1, 24, 12, 41, 55, 350, DateTimeKind.Local).AddTicks(6680), new DateTime(2025, 1, 25, 12, 41, 55, 350, DateTimeKind.Local).AddTicks(6680), 3, 1, 1955.0, 2 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2024, 12, 8, 4, 6, 27, 256, DateTimeKind.Local).AddTicks(7427), new DateTime(2024, 12, 10, 4, 6, 27, 256, DateTimeKind.Local).AddTicks(7427), 32, 3060.0, 5 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "Status", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2024, 12, 7, 15, 43, 42, 512, DateTimeKind.Local).AddTicks(1334), new DateTime(2024, 12, 11, 15, 43, 42, 512, DateTimeKind.Local).AddTicks(1334), 44, 1, 2136.0, 10 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "Status", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2025, 1, 11, 15, 46, 16, 384, DateTimeKind.Local).AddTicks(610), new DateTime(2025, 1, 19, 15, 46, 16, 384, DateTimeKind.Local).AddTicks(610), 47, 1, 1743.0, 8 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "Status", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2024, 12, 12, 2, 17, 55, 255, DateTimeKind.Local).AddTicks(9115), new DateTime(2024, 12, 20, 2, 17, 55, 255, DateTimeKind.Local).AddTicks(9115), 49, 1, 2980.0, 8 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "Status", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2024, 11, 29, 0, 52, 9, 127, DateTimeKind.Local).AddTicks(9952), new DateTime(2024, 11, 30, 0, 52, 9, 127, DateTimeKind.Local).AddTicks(9952), 33, 0, 2917.0, 6 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2025, 1, 8, 10, 56, 7, 922, DateTimeKind.Local).AddTicks(9141), new DateTime(2025, 1, 14, 10, 56, 7, 922, DateTimeKind.Local).AddTicks(9141), 27, 1732.0, 3 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "Status", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2025, 1, 14, 8, 48, 9, 302, DateTimeKind.Local).AddTicks(9975), new DateTime(2025, 1, 21, 8, 48, 9, 302, DateTimeKind.Local).AddTicks(9975), 1, 0, 3829.0, 3 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "Status", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2024, 12, 12, 18, 18, 56, 139, DateTimeKind.Local).AddTicks(9745), new DateTime(2024, 12, 13, 18, 18, 56, 139, DateTimeKind.Local).AddTicks(9745), 29, 1, 3017.0, 1 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "Status", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2024, 12, 24, 11, 38, 57, 215, DateTimeKind.Local).AddTicks(1649), new DateTime(2024, 12, 28, 11, 38, 57, 215, DateTimeKind.Local).AddTicks(1649), 33, 2, 3873.0, 10 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2025, 1, 12, 4, 36, 20, 12, DateTimeKind.Local).AddTicks(4662), new DateTime(2025, 1, 21, 4, 36, 20, 12, DateTimeKind.Local).AddTicks(4662), 12, 937.0, 4 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "Status", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2025, 1, 16, 12, 53, 43, 617, DateTimeKind.Local).AddTicks(4325), new DateTime(2025, 1, 22, 12, 53, 43, 617, DateTimeKind.Local).AddTicks(4325), 36, 2, 969.0, 7 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2025, 1, 7, 5, 56, 3, 785, DateTimeKind.Local).AddTicks(6148), new DateTime(2025, 1, 9, 5, 56, 3, 785, DateTimeKind.Local).AddTicks(6148), 16, 4610.0, 7 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "Status", "TotalPrice" },
                values: new object[] { new DateTime(2024, 12, 29, 3, 57, 49, 824, DateTimeKind.Local).AddTicks(2529), new DateTime(2025, 1, 2, 3, 57, 49, 824, DateTimeKind.Local).AddTicks(2529), 6, 2, 3873.0 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "Status", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2024, 12, 4, 1, 57, 35, 461, DateTimeKind.Local).AddTicks(8307), new DateTime(2024, 12, 13, 1, 57, 35, 461, DateTimeKind.Local).AddTicks(8307), 41, 0, 4336.0, 4 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "Status", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2024, 12, 11, 23, 2, 30, 323, DateTimeKind.Local).AddTicks(6334), new DateTime(2024, 12, 20, 23, 2, 30, 323, DateTimeKind.Local).AddTicks(6334), 36, 1, 364.0, 9 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "Status", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2024, 12, 31, 7, 40, 40, 192, DateTimeKind.Local).AddTicks(2612), new DateTime(2025, 1, 4, 7, 40, 40, 192, DateTimeKind.Local).AddTicks(2612), 45, 0, 4701.0, 8 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2025, 1, 6, 2, 30, 38, 538, DateTimeKind.Local).AddTicks(2643), new DateTime(2025, 1, 10, 2, 30, 38, 538, DateTimeKind.Local).AddTicks(2643), 26, 1041.0, 6 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2025, 1, 11, 20, 3, 48, 234, DateTimeKind.Local).AddTicks(1189), new DateTime(2025, 1, 19, 20, 3, 48, 234, DateTimeKind.Local).AddTicks(1189), 34, 4316.0, 9 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "Status", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2024, 12, 26, 19, 17, 17, 282, DateTimeKind.Local).AddTicks(3787), new DateTime(2024, 12, 28, 19, 17, 17, 282, DateTimeKind.Local).AddTicks(3787), 4, 1, 4815.0, 2 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "Status", "TotalPrice" },
                values: new object[] { new DateTime(2025, 1, 4, 17, 15, 12, 329, DateTimeKind.Local).AddTicks(8479), new DateTime(2025, 1, 8, 17, 15, 12, 329, DateTimeKind.Local).AddTicks(8479), 25, 1, 1648.0 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "TotalPrice" },
                values: new object[] { new DateTime(2024, 11, 29, 8, 24, 28, 940, DateTimeKind.Local).AddTicks(9523), new DateTime(2024, 12, 3, 8, 24, 28, 940, DateTimeKind.Local).AddTicks(9523), 44, 4108.0 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "Status", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2025, 1, 7, 23, 41, 0, 946, DateTimeKind.Local).AddTicks(7600), new DateTime(2025, 1, 14, 23, 41, 0, 946, DateTimeKind.Local).AddTicks(7600), 7, 0, 650.0, 1 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "Status", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2025, 1, 3, 17, 59, 38, 618, DateTimeKind.Local).AddTicks(3807), new DateTime(2025, 1, 4, 17, 59, 38, 618, DateTimeKind.Local).AddTicks(3807), 38, 1, 4739.0, 3 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "Status", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2024, 12, 14, 0, 44, 41, 231, DateTimeKind.Local).AddTicks(9633), new DateTime(2024, 12, 22, 0, 44, 41, 231, DateTimeKind.Local).AddTicks(9633), 25, 2, 1940.0, 7 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CheckInDate", "CheckOutDate", "Status", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2024, 12, 16, 21, 39, 14, 104, DateTimeKind.Local).AddTicks(7131), new DateTime(2024, 12, 20, 21, 39, 14, 104, DateTimeKind.Local).AddTicks(7131), 0, 4274.0, 10 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "Status", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2025, 1, 11, 16, 55, 44, 435, DateTimeKind.Local).AddTicks(1232), new DateTime(2025, 1, 15, 16, 55, 44, 435, DateTimeKind.Local).AddTicks(1232), 11, 1, 848.0, 3 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2025, 1, 9, 18, 38, 35, 849, DateTimeKind.Local).AddTicks(1517), new DateTime(2025, 1, 14, 18, 38, 35, 849, DateTimeKind.Local).AddTicks(1517), 18, 715.0, 4 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "Status", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2024, 12, 13, 12, 11, 30, 626, DateTimeKind.Local).AddTicks(1941), new DateTime(2024, 12, 19, 12, 11, 30, 626, DateTimeKind.Local).AddTicks(1941), 6, 0, 2894.0, 2 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2024, 12, 8, 5, 7, 55, 524, DateTimeKind.Local).AddTicks(5822), new DateTime(2024, 12, 12, 5, 7, 55, 524, DateTimeKind.Local).AddTicks(5822), 5, 2640.0, 3 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2025, 1, 15, 18, 21, 3, 958, DateTimeKind.Local).AddTicks(5570), new DateTime(2025, 1, 22, 18, 21, 3, 958, DateTimeKind.Local).AddTicks(5570), 30, 3636.0, 3 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2024, 12, 13, 23, 44, 43, 433, DateTimeKind.Local).AddTicks(6984), new DateTime(2024, 12, 23, 23, 44, 43, 433, DateTimeKind.Local).AddTicks(6984), 18, 1849.0, 8 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2025, 1, 2, 15, 2, 15, 696, DateTimeKind.Local).AddTicks(1155), new DateTime(2025, 1, 11, 15, 2, 15, 696, DateTimeKind.Local).AddTicks(1155), 9, 2024.0, 4 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2025, 1, 23, 2, 5, 2, 115, DateTimeKind.Local).AddTicks(2204), new DateTime(2025, 1, 31, 2, 5, 2, 115, DateTimeKind.Local).AddTicks(2204), 42, 1883.0, 1 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "Status", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2024, 12, 16, 13, 43, 33, 472, DateTimeKind.Local).AddTicks(460), new DateTime(2024, 12, 23, 13, 43, 33, 472, DateTimeKind.Local).AddTicks(460), 20, 1, 2957.0, 2 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "Status", "TotalPrice" },
                values: new object[] { new DateTime(2025, 1, 17, 22, 26, 15, 18, DateTimeKind.Local).AddTicks(6755), new DateTime(2025, 1, 24, 22, 26, 15, 18, DateTimeKind.Local).AddTicks(6755), 23, 2, 2023.0 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2025, 1, 9, 21, 50, 25, 633, DateTimeKind.Local).AddTicks(9987), new DateTime(2025, 1, 16, 21, 50, 25, 633, DateTimeKind.Local).AddTicks(9987), 1, 1093.0, 10 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "Status", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2024, 12, 2, 5, 9, 50, 112, DateTimeKind.Local).AddTicks(8206), new DateTime(2024, 12, 11, 5, 9, 50, 112, DateTimeKind.Local).AddTicks(8206), 28, 0, 4700.0, 1 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "Status", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2025, 1, 11, 18, 50, 21, 678, DateTimeKind.Local).AddTicks(2665), new DateTime(2025, 1, 13, 18, 50, 21, 678, DateTimeKind.Local).AddTicks(2665), 42, 1, 4280.0, 4 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "Status", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2025, 1, 18, 9, 36, 10, 792, DateTimeKind.Local).AddTicks(4272), new DateTime(2025, 1, 23, 9, 36, 10, 792, DateTimeKind.Local).AddTicks(4272), 30, 0, 2265.0, 6 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "Status", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2025, 1, 22, 11, 58, 13, 862, DateTimeKind.Local).AddTicks(6261), new DateTime(2025, 1, 27, 11, 58, 13, 862, DateTimeKind.Local).AddTicks(6261), 19, 0, 4082.0, 7 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "Status", "TotalPrice" },
                values: new object[] { new DateTime(2024, 12, 23, 4, 7, 54, 537, DateTimeKind.Local).AddTicks(134), new DateTime(2025, 1, 1, 4, 7, 54, 537, DateTimeKind.Local).AddTicks(134), 27, 1, 1740.0 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "Status", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2024, 12, 9, 11, 26, 11, 937, DateTimeKind.Local).AddTicks(9922), new DateTime(2024, 12, 16, 11, 26, 11, 937, DateTimeKind.Local).AddTicks(9922), 39, 0, 3611.0, 5 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2025, 1, 10, 22, 21, 49, 843, DateTimeKind.Local).AddTicks(8609), new DateTime(2025, 1, 18, 22, 21, 49, 843, DateTimeKind.Local).AddTicks(8609), 49, 4443.0, 8 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2024, 12, 23, 14, 51, 44, 900, DateTimeKind.Local).AddTicks(6190), new DateTime(2024, 12, 24, 14, 51, 44, 900, DateTimeKind.Local).AddTicks(6190), 42, 2954.0, 3 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "Status", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2025, 1, 26, 1, 40, 14, 19, DateTimeKind.Local).AddTicks(2265), new DateTime(2025, 1, 30, 1, 40, 14, 19, DateTimeKind.Local).AddTicks(2265), 10, 1, 687.0, 9 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "TotalPrice" },
                values: new object[] { new DateTime(2025, 1, 10, 1, 7, 43, 875, DateTimeKind.Local).AddTicks(2630), new DateTime(2025, 1, 15, 1, 7, 43, 875, DateTimeKind.Local).AddTicks(2630), 28, 1460.0 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2024, 12, 13, 1, 20, 23, 15, DateTimeKind.Local).AddTicks(5088), new DateTime(2024, 12, 14, 1, 20, 23, 15, DateTimeKind.Local).AddTicks(5088), 22, 832.0, 10 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "Status", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2025, 1, 21, 9, 31, 46, 241, DateTimeKind.Local).AddTicks(1525), new DateTime(2025, 1, 30, 9, 31, 46, 241, DateTimeKind.Local).AddTicks(1525), 23, 2, 3959.0, 6 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "Status", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2024, 12, 26, 9, 50, 34, 422, DateTimeKind.Local).AddTicks(1464), new DateTime(2025, 1, 3, 9, 50, 34, 422, DateTimeKind.Local).AddTicks(1464), 2, 0, 1346.0, 1 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "Status", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2024, 12, 4, 22, 42, 53, 943, DateTimeKind.Local).AddTicks(4303), new DateTime(2024, 12, 5, 22, 42, 53, 943, DateTimeKind.Local).AddTicks(4303), 21, 2, 636.0, 3 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "Status", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2025, 1, 8, 2, 45, 46, 777, DateTimeKind.Local).AddTicks(8194), new DateTime(2025, 1, 9, 2, 45, 46, 777, DateTimeKind.Local).AddTicks(8194), 47, 2, 4831.0, 2 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "Status", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2024, 12, 16, 6, 4, 43, 313, DateTimeKind.Local).AddTicks(2234), new DateTime(2024, 12, 17, 6, 4, 43, 313, DateTimeKind.Local).AddTicks(2234), 45, 1, 1019.0, 3 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "Status", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2024, 12, 27, 10, 16, 26, 846, DateTimeKind.Local).AddTicks(4196), new DateTime(2024, 12, 30, 10, 16, 26, 846, DateTimeKind.Local).AddTicks(4196), 34, 1, 4327.0, 9 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2024, 12, 29, 17, 8, 45, 561, DateTimeKind.Local).AddTicks(230), new DateTime(2024, 12, 30, 17, 8, 45, 561, DateTimeKind.Local).AddTicks(230), 24, 1693.0, 9 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "Status", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2024, 12, 16, 13, 38, 38, 728, DateTimeKind.Local).AddTicks(6970), new DateTime(2024, 12, 22, 13, 38, 38, 728, DateTimeKind.Local).AddTicks(6970), 48, 2, 169.0, 5 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "Status", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2024, 12, 20, 0, 43, 13, 844, DateTimeKind.Local).AddTicks(4907), new DateTime(2024, 12, 23, 0, 43, 13, 844, DateTimeKind.Local).AddTicks(4907), 18, 2, 1353.0, 7 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "Status", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2025, 1, 1, 0, 41, 8, 145, DateTimeKind.Local).AddTicks(8700), new DateTime(2025, 1, 3, 0, 41, 8, 145, DateTimeKind.Local).AddTicks(8700), 24, 2, 4495.0, 9 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "Status", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2024, 12, 30, 21, 27, 51, 724, DateTimeKind.Local).AddTicks(1721), new DateTime(2024, 12, 31, 21, 27, 51, 724, DateTimeKind.Local).AddTicks(1721), 15, 2, 653.0, 1 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CheckInDate", "CheckOutDate", "Status", "TotalPrice" },
                values: new object[] { new DateTime(2024, 12, 25, 0, 42, 10, 933, DateTimeKind.Local).AddTicks(3392), new DateTime(2024, 12, 31, 0, 42, 10, 933, DateTimeKind.Local).AddTicks(3392), 0, 130.0 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2024, 12, 28, 1, 47, 57, 901, DateTimeKind.Local).AddTicks(9205), new DateTime(2025, 1, 6, 1, 47, 57, 901, DateTimeKind.Local).AddTicks(9205), 31, 3250.0, 1 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2024, 12, 28, 21, 8, 32, 174, DateTimeKind.Local).AddTicks(5684), new DateTime(2025, 1, 5, 21, 8, 32, 174, DateTimeKind.Local).AddTicks(5684), 25, 2268.0, 2 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2024, 12, 15, 17, 11, 16, 112, DateTimeKind.Local).AddTicks(1424), new DateTime(2024, 12, 24, 17, 11, 16, 112, DateTimeKind.Local).AddTicks(1424), 41, 1370.0, 10 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2025, 1, 10, 3, 18, 34, 894, DateTimeKind.Local).AddTicks(7873), new DateTime(2025, 1, 16, 3, 18, 34, 894, DateTimeKind.Local).AddTicks(7873), 4, 324.0, 9 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "Status", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2025, 1, 12, 1, 27, 22, 190, DateTimeKind.Local).AddTicks(1408), new DateTime(2025, 1, 19, 1, 27, 22, 190, DateTimeKind.Local).AddTicks(1408), 17, 0, 3796.0, 4 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "TotalPrice" },
                values: new object[] { new DateTime(2024, 12, 13, 8, 0, 31, 850, DateTimeKind.Local).AddTicks(3058), new DateTime(2024, 12, 17, 8, 0, 31, 850, DateTimeKind.Local).AddTicks(3058), 21, 3689.0 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "Status", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2025, 1, 17, 16, 7, 24, 644, DateTimeKind.Local).AddTicks(3487), new DateTime(2025, 1, 18, 16, 7, 24, 644, DateTimeKind.Local).AddTicks(3487), 41, 1, 4594.0, 4 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2024, 12, 1, 9, 18, 18, 518, DateTimeKind.Local).AddTicks(6688), new DateTime(2024, 12, 10, 9, 18, 18, 518, DateTimeKind.Local).AddTicks(6688), 47, 3140.0, 6 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "Status", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2024, 11, 29, 7, 9, 46, 299, DateTimeKind.Local).AddTicks(704), new DateTime(2024, 11, 30, 7, 9, 46, 299, DateTimeKind.Local).AddTicks(704), 2, 0, 1946.0, 10 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "Status", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2024, 12, 18, 9, 24, 22, 410, DateTimeKind.Local).AddTicks(557), new DateTime(2024, 12, 24, 9, 24, 22, 410, DateTimeKind.Local).AddTicks(557), 21, 1, 613.0, 6 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2024, 12, 3, 7, 0, 28, 217, DateTimeKind.Local).AddTicks(2758), new DateTime(2024, 12, 4, 7, 0, 28, 217, DateTimeKind.Local).AddTicks(2758), 5, 2099.0, 8 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "Status", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2024, 12, 16, 20, 10, 52, 97, DateTimeKind.Local).AddTicks(7704), new DateTime(2024, 12, 26, 20, 10, 52, 97, DateTimeKind.Local).AddTicks(7704), 50, 2, 908.0, 4 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "Status", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2025, 1, 15, 17, 56, 28, 952, DateTimeKind.Local).AddTicks(8003), new DateTime(2025, 1, 22, 17, 56, 28, 952, DateTimeKind.Local).AddTicks(8003), 14, 1, 2160.0, 2 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "Status", "TotalPrice" },
                values: new object[] { new DateTime(2024, 12, 25, 11, 16, 56, 792, DateTimeKind.Local).AddTicks(2492), new DateTime(2024, 12, 26, 11, 16, 56, 792, DateTimeKind.Local).AddTicks(2492), 5, 2, 1392.0 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2024, 12, 24, 19, 38, 47, 267, DateTimeKind.Local).AddTicks(1543), new DateTime(2024, 12, 28, 19, 38, 47, 267, DateTimeKind.Local).AddTicks(1543), 6, 2622.0, 5 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2024, 12, 9, 6, 59, 30, 215, DateTimeKind.Local).AddTicks(4392), new DateTime(2024, 12, 18, 6, 59, 30, 215, DateTimeKind.Local).AddTicks(4392), 1, 683.0, 3 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "Status", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2024, 12, 4, 4, 9, 9, 201, DateTimeKind.Local).AddTicks(3443), new DateTime(2024, 12, 5, 4, 9, 9, 201, DateTimeKind.Local).AddTicks(3443), 26, 0, 1480.0, 4 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "Status", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2024, 12, 2, 22, 14, 45, 331, DateTimeKind.Local).AddTicks(935), new DateTime(2024, 12, 5, 22, 14, 45, 331, DateTimeKind.Local).AddTicks(935), 23, 0, 1479.0, 4 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2025, 1, 5, 20, 20, 24, 882, DateTimeKind.Local).AddTicks(9045), new DateTime(2025, 1, 7, 20, 20, 24, 882, DateTimeKind.Local).AddTicks(9045), 36, 3983.0, 5 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2024, 12, 2, 6, 38, 53, 774, DateTimeKind.Local).AddTicks(6651), new DateTime(2024, 12, 6, 6, 38, 53, 774, DateTimeKind.Local).AddTicks(6651), 46, 3550.0, 10 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "Status", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2024, 11, 30, 20, 54, 31, 437, DateTimeKind.Local).AddTicks(2486), new DateTime(2024, 12, 1, 20, 54, 31, 437, DateTimeKind.Local).AddTicks(2486), 29, 2, 2663.0, 9 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "Status", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2025, 1, 3, 7, 39, 20, 51, DateTimeKind.Local).AddTicks(7430), new DateTime(2025, 1, 11, 7, 39, 20, 51, DateTimeKind.Local).AddTicks(7430), 33, 2, 4783.0, 2 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2024, 12, 26, 6, 32, 23, 87, DateTimeKind.Local).AddTicks(2399), new DateTime(2025, 1, 4, 6, 32, 23, 87, DateTimeKind.Local).AddTicks(2399), 10, 3867.0, 3 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "Status", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2024, 12, 28, 10, 58, 40, 214, DateTimeKind.Local).AddTicks(7889), new DateTime(2025, 1, 1, 10, 58, 40, 214, DateTimeKind.Local).AddTicks(7889), 45, 1, 1469.0, 9 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CheckInDate", "CheckOutDate", "RoomId", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2025, 1, 5, 13, 54, 28, 151, DateTimeKind.Local).AddTicks(7176), new DateTime(2025, 1, 9, 13, 54, 28, 151, DateTimeKind.Local).AddTicks(7176), 34, 1028.0, 5 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Capacity", "Name", "Price" },
                values: new object[] { 8, "Room 394", 468.0 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Capacity", "IsAvailable", "Name", "Price" },
                values: new object[] { 10, false, "Room 142", 174.0 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Capacity", "IsAvailable", "Name", "Price", "RoomTypeId" },
                values: new object[] { 2, false, "Room 150", 596.0, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Capacity", "Name", "Price" },
                values: new object[] { 2, "Room 440", 113.0 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Capacity", "Name", "Price", "RoomTypeId" },
                values: new object[] { 2, "Room 314", 134.0, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Capacity", "Name", "Price" },
                values: new object[] { 10, "Room 178", 165.0 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "IsAvailable", "Name", "Price", "RoomTypeId" },
                values: new object[] { true, "Room 318", 440.0, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Capacity", "Name", "Price", "RoomTypeId" },
                values: new object[] { 5, "Room 332", 731.0, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "IsAvailable", "Name", "Price" },
                values: new object[] { true, "Room 297", 383.0 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Capacity", "Name", "Price" },
                values: new object[] { 5, "Room 492", 815.0 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Capacity", "IsAvailable", "Name", "Price", "RoomTypeId" },
                values: new object[] { 8, true, "Room 121", 342.0, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Capacity", "Name", "Price", "RoomTypeId" },
                values: new object[] { 6, "Room 180", 883.0, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Capacity", "Name", "Price" },
                values: new object[] { 5, "Room 403", 417.0 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Capacity", "Name", "Price", "RoomTypeId" },
                values: new object[] { 4, "Room 332", 271.0, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Capacity", "Name", "Price", "RoomTypeId" },
                values: new object[] { 3, "Room 467", 822.0, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Capacity", "IsAvailable", "Name", "Price", "RoomTypeId" },
                values: new object[] { 6, false, "Room 250", 902.0, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Capacity", "IsAvailable", "Name", "Price", "RoomTypeId" },
                values: new object[] { 7, true, "Room 329", 871.0, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "IsAvailable", "Name", "Price", "RoomTypeId" },
                values: new object[] { true, "Room 274", 213.0, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Capacity", "Name", "Price", "RoomTypeId" },
                values: new object[] { 9, "Room 341", 150.0, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Capacity", "IsAvailable", "Name", "Price", "RoomTypeId" },
                values: new object[] { 2, false, "Room 372", 837.0, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "IsAvailable", "Name", "Price", "RoomTypeId" },
                values: new object[] { true, "Room 114", 721.0, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Capacity", "Name", "Price" },
                values: new object[] { 7, "Room 381", 641.0 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Capacity", "IsAvailable", "Name", "Price" },
                values: new object[] { 9, false, "Room 114", 771.0 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Capacity", "Name", "Price" },
                values: new object[] { 7, "Room 128", 974.0 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Capacity", "Name", "Price" },
                values: new object[] { 8, "Room 295", 476.0 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Capacity", "Name", "Price" },
                values: new object[] { 5, "Room 150", 661.0 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Capacity", "IsAvailable", "Name", "Price" },
                values: new object[] { 5, false, "Room 152", 995.0 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Capacity", "Name", "Price" },
                values: new object[] { 8, "Room 487", 740.0 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Capacity", "Name", "Price", "RoomTypeId" },
                values: new object[] { 8, "Room 155", 855.0, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Capacity", "Name", "Price", "RoomTypeId" },
                values: new object[] { 4, "Room 500", 457.0, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Capacity", "IsAvailable", "Name", "Price", "RoomTypeId" },
                values: new object[] { 1, true, "Room 101", 96.0, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Capacity", "IsAvailable", "Name", "Price", "RoomTypeId" },
                values: new object[] { 1, true, "Room 452", 611.0, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Capacity", "IsAvailable", "Name", "Price" },
                values: new object[] { 8, true, "Room 287", 651.0 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Capacity", "Name", "Price", "RoomTypeId" },
                values: new object[] { 9, "Room 138", 560.0, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Capacity", "Name", "Price", "RoomTypeId" },
                values: new object[] { 1, "Room 117", 854.0, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Capacity", "IsAvailable", "Name", "Price" },
                values: new object[] { 8, false, "Room 147", 327.0 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Capacity", "Name", "Price", "RoomTypeId" },
                values: new object[] { 5, "Room 415", 328.0, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Capacity", "IsAvailable", "Name", "Price", "RoomTypeId" },
                values: new object[] { 9, false, "Room 270", 749.0, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Capacity", "Name", "Price", "RoomTypeId" },
                values: new object[] { 5, "Room 320", 377.0, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Capacity", "IsAvailable", "Name", "Price", "RoomTypeId" },
                values: new object[] { 1, false, "Room 154", 164.0, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Name", "Price", "RoomTypeId" },
                values: new object[] { "Room 178", 665.0, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Capacity", "Name", "Price", "RoomTypeId" },
                values: new object[] { 2, "Room 400", 796.0, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Capacity", "IsAvailable", "Name", "Price", "RoomTypeId" },
                values: new object[] { 5, true, "Room 219", 898.0, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Capacity", "IsAvailable", "Name", "Price", "RoomTypeId" },
                values: new object[] { 2, true, "Room 349", 479.0, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Capacity", "IsAvailable", "Name", "Price", "RoomTypeId" },
                values: new object[] { 1, false, "Room 453", 429.0, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Capacity", "IsAvailable", "Name", "Price", "RoomTypeId" },
                values: new object[] { 3, true, "Room 126", 991.0, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Capacity", "Name", "Price", "RoomTypeId" },
                values: new object[] { 2, "Room 105", 921.0, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Capacity", "Name", "Price" },
                values: new object[] { 2, "Room 225", 973.0 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Room 253", 364.0 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Capacity", "IsAvailable", "Name", "Price", "RoomTypeId" },
                values: new object[] { 7, true, "Room 152", 520.0, 3 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "$2a$11$4N6/UQW7An8FyHRqZjtCveIgbpb8KjBHM1gYtLDdXdBkqevj8GU.K");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Email", "FirstName", "LastName", "Password", "PhoneNumber", "Role" },
                values: new object[] { "Ron.Collins90@hotmail.com", "Ole", "Prohaska", "$2a$11$B05zbyCChKOsxx2LHohXpeYkiMaz6joNYITkrdxKVEE5StlVaUDXW", "1-458-448-2824 x95460", 2 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Email", "FirstName", "LastName", "Password", "PhoneNumber", "Role" },
                values: new object[] { "Helen.Effertz@gmail.com", "Ricardo", "Kling", "$2a$11$75vkbdduOBew7yqByMRIUOWX5jn6I09AiOeuOxpHCRi9hqv.X7HuG", "(814) 392-1954 x223", 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Email", "FirstName", "LastName", "Password", "PhoneNumber", "Role" },
                values: new object[] { "Modesto63@gmail.com", "Lafayette", "Gaylord", "$2a$11$KVCWu4VJG2lB8OuYBkpgr.1wYZ3z3.3JIrswr2tiY2g8KVc7jaOxm", "1-794-617-4703 x27634", 2 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Email", "FirstName", "LastName", "Password", "PhoneNumber", "Role" },
                values: new object[] { "Fanny7@yahoo.com", "Luigi", "Schultz", "$2a$11$n2XEiiDwVjcWeSzkO8G5heQ7UL.BheULcXloEtH25his8XBABb/1G", "1-731-714-4475 x17668", 1 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Email", "FirstName", "LastName", "Password", "PhoneNumber", "Role" },
                values: new object[] { "Edgar86@gmail.com", "Noe", "Lind", "$2a$11$.0Gzw.7vY4CmNVS3vVSsGeDkGsMft8JYi5wcOH7yEqQymVwhFuiRG", "761-764-3227 x0078", 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Email", "FirstName", "LastName", "Password", "PhoneNumber" },
                values: new object[] { "Jewell_Mosciski@hotmail.com", "Alfonso", "Terry", "$2a$11$v5LHHZX4fc7N14cyb3R6/uG5HnSscwvXc.gqoA307U04L6VdfdBs2", "304-276-6654 x92076" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Email", "FirstName", "LastName", "Password", "PhoneNumber", "Role" },
                values: new object[] { "Armando_Rodriguez57@gmail.com", "Della", "Ledner", "$2a$11$.YdXloNYaYbRtpxkOVk9De/iv3FsFe1NY05sKRyUfnfsgiQlmA8/m", "(944) 363-8788 x6737", 2 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Email", "FirstName", "LastName", "Password", "PhoneNumber", "Role" },
                values: new object[] { "Kelvin_Schiller@hotmail.com", "Sophia", "Stokes", "$2a$11$eaX9U4.Pnfp81RADzuKq/.MKnr9WBXihLRhb9vtMiy7bqaJQ2rGQu", "1-356-601-3911 x04627", 2 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Email", "FirstName", "LastName", "Password", "PhoneNumber", "Role" },
                values: new object[] { "Tavares44@yahoo.com", "Maxie", "Tremblay", "$2a$11$r1VJ5ZtQlt6eQQ0G/QtytuQg9OZtMLGN7qEX9VKQBLG/6hnP6yFsq", "525.595.8121", 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Email", "FirstName", "LastName", "Password", "PhoneNumber", "Role" },
                values: new object[] { "Geo_Mitchell@yahoo.com", "Krystina", "Hartmann", "$2a$11$DUdwWMj5oA8x4asfl6CKDuM2AE4rRBK0.U0JPmMiw3n8ZQxAOKyxe", "1-500-987-3340", 2 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Email", "FirstName", "LastName", "Password", "PhoneNumber" },
                values: new object[] { "Betsy95@hotmail.com", "Armando", "Kling", "$2a$11$vATpz0MzMtFAWzv7R8dOSOkAmnBNeubk656hx.UE3l.4XVQ/5FXRS", "1-817-897-4785" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Email", "FirstName", "LastName", "Password", "PhoneNumber", "Role" },
                values: new object[] { "Wendell.Buckridge@gmail.com", "Gabriel", "Mosciski", "$2a$11$Ybe.d/UrMna8P/XqYZddX.3f0A4tlPPzVy1dEBfSiUqn6b7RehZv.", "461-711-6584", 1 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Email", "FirstName", "LastName", "Password", "PhoneNumber", "Role" },
                values: new object[] { "Tiara.Goldner@hotmail.com", "Mac", "Jerde", "$2a$11$e8XqEnjJt98YTf0vJ692KOkJwYHckTpvFwTEsyEbP/ZWhwdgKs1by", "(881) 897-9111", 1 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Email", "FirstName", "LastName", "Password", "PhoneNumber" },
                values: new object[] { "Darrick.Morar51@hotmail.com", "Rachel", "Harvey", "$2a$11$XKFSLanImSIiHUHgr6Qlc.mBjx/tX3C9M0Y5aLkmN39cotVt4cXU6", "1-764-623-7272" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Email", "FirstName", "LastName", "Password", "PhoneNumber", "Role" },
                values: new object[] { "Priscilla.Gulgowski@hotmail.com", "Velda", "Flatley", "$2a$11$meaw18ZuT49GmJIfFPCBwOrx3vE1b1xojioEOSOI0FzQRcGCxb44y", "855-498-5646 x53330", 1 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Email", "FirstName", "LastName", "Password", "PhoneNumber", "Role" },
                values: new object[] { "Leopold.Steuber41@yahoo.com", "Haley", "Fadel", "$2a$11$7y9QB81dTuzQH3bCyjMTtu12.RzhsDZiwHXph2OCxcqj0OE6Qj056", "(713) 743-3037 x739", 2 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Email", "FirstName", "LastName", "Password", "PhoneNumber", "Role" },
                values: new object[] { "Clark.Powlowski@hotmail.com", "Verner", "Bernier", "$2a$11$tV7HN6HvlqS5CKzJNBERxe.3psSUZeZfaFR5J/hYunTyDiWLx.ZC2", "1-758-932-5788", 1 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Email", "FirstName", "LastName", "Password", "PhoneNumber" },
                values: new object[] { "Jolie_Barrows@hotmail.com", "Sylvan", "Boehm", "$2a$11$x0y.mDgErZVkGWlJDcHd5u.YcOw7AsjjUvv78zo4JhEJ1iNWWRGQO", "(505) 579-9256 x995" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Email", "FirstName", "LastName", "Password", "PhoneNumber", "Role" },
                values: new object[] { "Leonor_OConner27@yahoo.com", "Dedrick", "Heller", "$2a$11$KxFKVrqn/LrXsBizE5Iiz.43Qwf0vaTpnYuy5G8nFhLbImsvbxtxG", "(929) 959-8347 x777", 1 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Email", "FirstName", "LastName", "Password", "PhoneNumber", "Role" },
                values: new object[] { "Patsy.Koss64@yahoo.com", "Bernhard", "Stokes", "$2a$11$saQ60a2m.D.JGLjjot03buyUWhjWtfZjYTunIOTH.q4pNN4YCN49u", "1-830-349-5839 x54963", 2 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Email", "FirstName", "LastName", "Password", "PhoneNumber", "Role" },
                values: new object[] { "Sharon45@gmail.com", "Felton", "Prohaska", "$2a$11$w2Ns//e1vFhSXqZLsV9e..vjnDmnt/ZcWTzcj2sFhVsn.leilCXXG", "860-260-2832 x22823", 1 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Email", "FirstName", "LastName", "Password", "PhoneNumber", "Role" },
                values: new object[] { "Helena37@hotmail.com", "Zelma", "Kling", "$2a$11$vmFlnNE8sZ/JKbi3HQmqd.fCaHuJqt.BMc15ODUr7b8L5Wt11QS/i", "719.762.2205", 1 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Email", "FirstName", "LastName", "Password", "PhoneNumber" },
                values: new object[] { "Aidan_Larson87@gmail.com", "Braulio", "Pouros", "$2a$11$Zi3IpUSVzlLpINM05vCKluIMlHDEjmfiGH7xAtqhJlurZ02.jhUXK", "819-851-9391" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Email", "FirstName", "LastName", "Password", "PhoneNumber", "Role" },
                values: new object[] { "Reynold_Hahn@yahoo.com", "Alfreda", "Swaniawski", "$2a$11$UhtQ12EoVHf3QaJmOvModeJBxiwfbXOUfruXDU/HFoUyGZmn5miRK", "729.451.4389", 2 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Email", "FirstName", "LastName", "Password", "PhoneNumber" },
                values: new object[] { "Darrell_Bogan@hotmail.com", "Leo", "Boehm", "$2a$11$G4IPOJ.FsLxoDOjb2TlvEO44siVvRVAQL.F5qWwR6x6/PDKXh/Oh.", "1-436-954-6784 x10270" });
        }
    }
}
