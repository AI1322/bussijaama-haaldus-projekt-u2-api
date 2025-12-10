using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace bussijaamahaaldusprojektu2api.Migrations
{
    /// <inheritdoc />
    public partial class Seed30Routes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredAt", "SecurityStamp" },
                values: new object[] { "57ad57d1-ff50-4501-8cce-8c1c70730a75", "AQAAAAIAAYagAAAAEAYkdX+yZyJDi1IVLJCnvp/0mDcslvJjX7X+L0PqhN76A82fH5qCnK8CyNCDf3d1jg==", new DateTime(2025, 12, 10, 21, 0, 0, 708, DateTimeKind.Utc).AddTicks(5790), "c5ef0099-9916-4f80-9597-8db044ac6187" });

            migrationBuilder.UpdateData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ArrivalTime", "DepartureTime", "Number", "Price" },
                values: new object[] { new DateTime(2025, 12, 8, 20, 15, 0, 0, DateTimeKind.Local), new DateTime(2025, 12, 8, 18, 0, 0, 0, DateTimeKind.Local), "BUS-2515", 13.16m });

            migrationBuilder.UpdateData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ArrivalTime", "DepartureTime", "Number", "Price" },
                values: new object[] { new DateTime(2025, 12, 11, 21, 31, 0, 0, DateTimeKind.Local), new DateTime(2025, 12, 11, 19, 0, 0, 0, DateTimeKind.Local), "BUS-7850", 10.71m });

            migrationBuilder.UpdateData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ArrivalTime", "Company", "DepartureTime", "DestinationCity", "DestinationStation", "Number", "Price" },
                values: new object[] { new DateTime(2025, 12, 9, 16, 30, 0, 0, DateTimeKind.Local), "NordBus", new DateTime(2025, 12, 9, 14, 0, 0, 0, DateTimeKind.Local), "Tartu", "Tartu Bus Station", "BUS-4428", 11.74m });

            migrationBuilder.UpdateData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ArrivalTime", "Company", "DepartureTime", "DestinationCity", "DestinationStation", "Number", "Price" },
                values: new object[] { new DateTime(2025, 12, 11, 2, 11, 0, 0, DateTimeKind.Local), "NordBus", new DateTime(2025, 12, 11, 0, 0, 0, 0, DateTimeKind.Local), "Tartu", "Tartu Bus Station", "BUS-6194", 15.20m });

            migrationBuilder.UpdateData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ArrivalTime", "Company", "DepartureTime", "DestinationCity", "DestinationStation", "Number", "Price" },
                values: new object[] { new DateTime(2025, 12, 9, 9, 13, 0, 0, DateTimeKind.Local), "Baltic Shuttle", new DateTime(2025, 12, 9, 7, 0, 0, 0, DateTimeKind.Local), "Tartu", "Tartu Bus Station", "BUS-8344", 14.44m });

            migrationBuilder.UpdateData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ArrivalTime", "Company", "DepartureCity", "DepartureStation", "DepartureTime", "DestinationCity", "DestinationStation", "Number", "Price" },
                values: new object[] { new DateTime(2025, 12, 11, 16, 36, 0, 0, DateTimeKind.Local), "Baltic Shuttle", "Tallinn", "Tallinn Bus Station", new DateTime(2025, 12, 11, 15, 0, 0, 0, DateTimeKind.Local), "Pärnu", "Pärnu Bus Station", "BUS-7232", 13.35m });

            migrationBuilder.UpdateData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ArrivalTime", "Company", "DepartureCity", "DepartureStation", "DepartureTime", "DestinationCity", "DestinationStation", "Number", "Price" },
                values: new object[] { new DateTime(2025, 12, 9, 3, 31, 0, 0, DateTimeKind.Local), "FlixBus", "Tallinn", "Tallinn Bus Station", new DateTime(2025, 12, 9, 2, 0, 0, 0, DateTimeKind.Local), "Pärnu", "Pärnu Bus Station", "BUS-6247", 9.16m });

            migrationBuilder.UpdateData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ArrivalTime", "Company", "DepartureTime", "DestinationStation", "Number", "Price" },
                values: new object[] { new DateTime(2025, 12, 8, 8, 51, 0, 0, DateTimeKind.Local), "NordBus", new DateTime(2025, 12, 8, 7, 0, 0, 0, DateTimeKind.Local), "Pärnu Bus Station", "BUS-7734", 12.64m });

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "Id", "ArrivalTime", "Company", "DepartureCity", "DepartureStation", "DepartureTime", "DestinationCity", "DestinationStation", "Number", "Price" },
                values: new object[,]
                {
                    { 9, new DateTime(2025, 12, 8, 6, 22, 0, 0, DateTimeKind.Local), "Lux Express", "Tallinn", "Tallinn Bus Station", new DateTime(2025, 12, 8, 4, 0, 0, 0, DateTimeKind.Local), "Narva", "Narva Bus Station", "BUS-6637", 13.47m },
                    { 10, new DateTime(2025, 12, 9, 12, 51, 0, 0, DateTimeKind.Local), "Lux Express", "Tallinn", "Tallinn Bus Station", new DateTime(2025, 12, 9, 10, 0, 0, 0, DateTimeKind.Local), "Narva", "Narva Bus Station", "BUS-6832", 10.03m },
                    { 11, new DateTime(2025, 12, 8, 14, 44, 0, 0, DateTimeKind.Local), "Baltic Shuttle", "Tallinn", "Tallinn Bus Station", new DateTime(2025, 12, 8, 12, 0, 0, 0, DateTimeKind.Local), "Narva", "Narva Bus Station", "BUS-1457", 11.61m },
                    { 12, new DateTime(2025, 12, 11, 7, 8, 0, 0, DateTimeKind.Local), "NordBus", "Tallinn", "Tallinn Bus Station", new DateTime(2025, 12, 11, 5, 0, 0, 0, DateTimeKind.Local), "Viljandi", "Viljandi Bus Station", "BUS-4286", 10.09m },
                    { 13, new DateTime(2025, 12, 8, 14, 29, 0, 0, DateTimeKind.Local), "Lux Express", "Tallinn", "Tallinn Bus Station", new DateTime(2025, 12, 8, 12, 0, 0, 0, DateTimeKind.Local), "Viljandi", "Viljandi Bus Station", "BUS-5176", 10.49m },
                    { 14, new DateTime(2025, 12, 12, 9, 18, 0, 0, DateTimeKind.Local), "Lux Express", "Tallinn", "Tallinn Bus Station", new DateTime(2025, 12, 12, 7, 0, 0, 0, DateTimeKind.Local), "Viljandi", "Viljandi Bus Station", "BUS-5495", 13.59m },
                    { 15, new DateTime(2025, 12, 12, 16, 0, 0, 0, DateTimeKind.Local), "Ecolines", "Tallinn", "Tallinn Bus Station", new DateTime(2025, 12, 12, 14, 0, 0, 0, DateTimeKind.Local), "Viljandi", "Viljandi Bus Station", "BUS-1573", 10.02m },
                    { 16, new DateTime(2025, 12, 8, 19, 37, 0, 0, DateTimeKind.Local), "NordBus", "Tallinn", "Tallinn Bus Station", new DateTime(2025, 12, 8, 17, 0, 0, 0, DateTimeKind.Local), "Viljandi", "Viljandi Bus Station", "BUS-5150", 16.51m },
                    { 17, new DateTime(2025, 12, 8, 8, 25, 0, 0, DateTimeKind.Local), "Ecolines", "Tartu", "Tartu Bus Station", new DateTime(2025, 12, 8, 6, 0, 0, 0, DateTimeKind.Local), "Tallinn", "Tallinn Bus Station", "BUS-4932", 10.49m },
                    { 18, new DateTime(2025, 12, 10, 22, 26, 0, 0, DateTimeKind.Local), "Baltic Shuttle", "Tartu", "Tartu Bus Station", new DateTime(2025, 12, 10, 20, 0, 0, 0, DateTimeKind.Local), "Tallinn", "Tallinn Bus Station", "BUS-9164", 11.58m },
                    { 19, new DateTime(2025, 12, 12, 1, 10, 0, 0, DateTimeKind.Local), "NordBus", "Tartu", "Tartu Bus Station", new DateTime(2025, 12, 11, 23, 0, 0, 0, DateTimeKind.Local), "Tallinn", "Tallinn Bus Station", "BUS-9618", 15.68m },
                    { 20, new DateTime(2025, 12, 12, 1, 16, 0, 0, DateTimeKind.Local), "NordBus", "Tartu", "Tartu Bus Station", new DateTime(2025, 12, 11, 23, 0, 0, 0, DateTimeKind.Local), "Tallinn", "Tallinn Bus Station", "BUS-5068", 10.22m },
                    { 21, new DateTime(2025, 12, 8, 19, 35, 0, 0, DateTimeKind.Local), "Baltic Shuttle", "Pärnu", "Pärnu Bus Station", new DateTime(2025, 12, 8, 18, 0, 0, 0, DateTimeKind.Local), "Tallinn", "Tallinn Bus Station", "BUS-6324", 8.51m },
                    { 22, new DateTime(2025, 12, 13, 5, 1, 0, 0, DateTimeKind.Local), "NordBus", "Pärnu", "Pärnu Bus Station", new DateTime(2025, 12, 13, 3, 0, 0, 0, DateTimeKind.Local), "Tallinn", "Tallinn Bus Station", "BUS-7433", 11.71m },
                    { 23, new DateTime(2025, 12, 11, 3, 10, 0, 0, DateTimeKind.Local), "NordBus", "Pärnu", "Pärnu Bus Station", new DateTime(2025, 12, 11, 1, 0, 0, 0, DateTimeKind.Local), "Tallinn", "Tallinn Bus Station", "BUS-1217", 11.56m },
                    { 24, new DateTime(2025, 12, 13, 3, 31, 0, 0, DateTimeKind.Local), "Lux Express", "Pärnu", "Pärnu Bus Station", new DateTime(2025, 12, 13, 2, 0, 0, 0, DateTimeKind.Local), "Tallinn", "Tallinn Bus Station", "BUS-3388", 8.54m },
                    { 25, new DateTime(2025, 12, 9, 16, 54, 0, 0, DateTimeKind.Local), "FlixBus", "Pärnu", "Pärnu Bus Station", new DateTime(2025, 12, 9, 15, 0, 0, 0, DateTimeKind.Local), "Tallinn", "Tallinn Bus Station", "BUS-1843", 9.95m },
                    { 26, new DateTime(2025, 12, 8, 16, 53, 0, 0, DateTimeKind.Local), "FlixBus", "Riga", "Riga Central Station", new DateTime(2025, 12, 8, 13, 0, 0, 0, DateTimeKind.Local), "Tallinn", "Tallinn Bus Station", "BUS-7759", 17.27m },
                    { 27, new DateTime(2025, 12, 8, 8, 41, 0, 0, DateTimeKind.Local), "NordBus", "Riga", "Riga Central Station", new DateTime(2025, 12, 8, 5, 0, 0, 0, DateTimeKind.Local), "Tallinn", "Tallinn Bus Station", "BUS-9062", 20.89m },
                    { 28, new DateTime(2025, 12, 13, 3, 14, 0, 0, DateTimeKind.Local), "Ecolines", "Riga", "Riga Central Station", new DateTime(2025, 12, 12, 23, 0, 0, 0, DateTimeKind.Local), "Tallinn", "Tallinn Bus Station", "BUS-5907", 16.95m },
                    { 29, new DateTime(2025, 12, 9, 3, 52, 0, 0, DateTimeKind.Local), "NordBus", "Tallinn", "Tallinn Bus Station", new DateTime(2025, 12, 9, 0, 0, 0, 0, DateTimeKind.Local), "Riga", "Riga Central Station", "BUS-1266", 16.28m },
                    { 30, new DateTime(2025, 12, 13, 0, 20, 0, 0, DateTimeKind.Local), "FlixBus", "Tallinn", "Tallinn Bus Station", new DateTime(2025, 12, 12, 20, 0, 0, 0, DateTimeKind.Local), "Riga", "Riga Central Station", "BUS-2216", 20.47m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredAt", "SecurityStamp" },
                values: new object[] { "46c86a67-615b-4ebc-9cc5-7398c5165667", "AQAAAAIAAYagAAAAECpSQip9fO9EdUwXck6tj5Aqkmg3ZtsRBXcs+KZuxah+n7sCUUUuz93hdOQznMXLFg==", new DateTime(2025, 12, 10, 8, 57, 35, 626, DateTimeKind.Utc).AddTicks(1529), "6b076daa-e55b-4262-b654-d4add206411e" });

            migrationBuilder.UpdateData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ArrivalTime", "DepartureTime", "Number", "Price" },
                values: new object[] { new DateTime(2025, 3, 10, 10, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 10, 8, 0, 0, 0, DateTimeKind.Unspecified), "BUS-1024", 12.50m });

            migrationBuilder.UpdateData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ArrivalTime", "DepartureTime", "Number", "Price" },
                values: new object[] { new DateTime(2025, 3, 10, 16, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 10, 14, 15, 0, 0, DateTimeKind.Unspecified), "BUS-1024", 12.50m });

            migrationBuilder.UpdateData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ArrivalTime", "Company", "DepartureTime", "DestinationCity", "DestinationStation", "Number", "Price" },
                values: new object[] { new DateTime(2025, 3, 11, 12, 0, 0, 0, DateTimeKind.Unspecified), "Baltic Express", new DateTime(2025, 3, 11, 7, 45, 0, 0, DateTimeKind.Unspecified), "Riga", "Riga Central Station", "BUS-2031", 25.00m });

            migrationBuilder.UpdateData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ArrivalTime", "Company", "DepartureTime", "DestinationCity", "DestinationStation", "Number", "Price" },
                values: new object[] { new DateTime(2025, 3, 11, 19, 45, 0, 0, DateTimeKind.Unspecified), "Baltic Express", new DateTime(2025, 3, 11, 15, 30, 0, 0, DateTimeKind.Unspecified), "Riga", "Riga Central Station", "BUS-2031", 25.00m });

            migrationBuilder.UpdateData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ArrivalTime", "Company", "DepartureTime", "DestinationCity", "DestinationStation", "Number", "Price" },
                values: new object[] { new DateTime(2025, 3, 12, 14, 0, 0, 0, DateTimeKind.Unspecified), "EuroRoad", new DateTime(2025, 3, 12, 6, 0, 0, 0, DateTimeKind.Unspecified), "Vilnius", "Vilnius Bus Terminal", "BUS-3310", 35.50m });

            migrationBuilder.UpdateData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ArrivalTime", "Company", "DepartureCity", "DepartureStation", "DepartureTime", "DestinationCity", "DestinationStation", "Number", "Price" },
                values: new object[] { new DateTime(2025, 3, 10, 13, 30, 0, 0, DateTimeKind.Unspecified), "Lux Express", "Tartu", "Tartu Bus Station", new DateTime(2025, 3, 10, 11, 0, 0, 0, DateTimeKind.Unspecified), "Tallinn", "Tallinn Bus Station", "BUS-445", 12.50m });

            migrationBuilder.UpdateData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ArrivalTime", "Company", "DepartureCity", "DepartureStation", "DepartureTime", "DestinationCity", "DestinationStation", "Number", "Price" },
                values: new object[] { new DateTime(2025, 3, 11, 17, 15, 0, 0, DateTimeKind.Unspecified), "Simple Express", "Riga", "Riga Central Station", new DateTime(2025, 3, 11, 13, 0, 0, 0, DateTimeKind.Unspecified), "Tallinn", "Tallinn Bus Station", "BUS-778", 22.00m });

            migrationBuilder.UpdateData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ArrivalTime", "Company", "DepartureTime", "DestinationStation", "Number", "Price" },
                values: new object[] { new DateTime(2025, 3, 13, 11, 20, 0, 0, DateTimeKind.Unspecified), "Lux Express", new DateTime(2025, 3, 13, 9, 30, 0, 0, DateTimeKind.Unspecified), "Pärnu Bus Terminal", "BUS-990", 9.90m });
        }
    }
}
