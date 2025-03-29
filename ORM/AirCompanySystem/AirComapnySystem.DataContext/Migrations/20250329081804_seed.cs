using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AirCompanySystem.DataContext.Migrations
{
    /// <inheritdoc />
    public partial class seed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Airplanes",
                columns: new[] { "Id", "CreatedAt", "CrewId", "DeletedAt", "SeatsCount", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTimeOffset(new DateTime(2025, 3, 29, 8, 18, 4, 251, DateTimeKind.Unspecified).AddTicks(6575), new TimeSpan(0, 0, 0, 0, 0)), null, null, 180, null },
                    { 2, new DateTimeOffset(new DateTime(2025, 3, 29, 8, 18, 4, 251, DateTimeKind.Unspecified).AddTicks(6585), new TimeSpan(0, 0, 0, 0, 0)), null, null, 220, null },
                    { 3, new DateTimeOffset(new DateTime(2025, 3, 29, 8, 18, 4, 251, DateTimeKind.Unspecified).AddTicks(6587), new TimeSpan(0, 0, 0, 0, 0)), null, null, 150, null }
                });

            migrationBuilder.InsertData(
                table: "Continents",
                columns: new[] { "Id", "ContinentName", "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, "Europe", new DateTimeOffset(new DateTime(2025, 3, 29, 8, 18, 4, 251, DateTimeKind.Unspecified).AddTicks(1613), new TimeSpan(0, 0, 0, 0, 0)), null, null },
                    { 2, "Asia", new DateTimeOffset(new DateTime(2025, 3, 29, 8, 18, 4, 251, DateTimeKind.Unspecified).AddTicks(1898), new TimeSpan(0, 0, 0, 0, 0)), null, null }
                });

            migrationBuilder.InsertData(
                table: "FlightStatuses",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Status", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTimeOffset(new DateTime(2025, 3, 29, 8, 18, 4, 251, DateTimeKind.Unspecified).AddTicks(7071), new TimeSpan(0, 0, 0, 0, 0)), null, "Scheduled", null },
                    { 2, new DateTimeOffset(new DateTime(2025, 3, 29, 8, 18, 4, 251, DateTimeKind.Unspecified).AddTicks(7078), new TimeSpan(0, 0, 0, 0, 0)), null, "Boarding", null },
                    { 3, new DateTimeOffset(new DateTime(2025, 3, 29, 8, 18, 4, 251, DateTimeKind.Unspecified).AddTicks(7080), new TimeSpan(0, 0, 0, 0, 0)), null, "In Flight", null },
                    { 4, new DateTimeOffset(new DateTime(2025, 3, 29, 8, 18, 4, 251, DateTimeKind.Unspecified).AddTicks(7081), new TimeSpan(0, 0, 0, 0, 0)), null, "Landed", null },
                    { 5, new DateTimeOffset(new DateTime(2025, 3, 29, 8, 18, 4, 251, DateTimeKind.Unspecified).AddTicks(7082), new TimeSpan(0, 0, 0, 0, 0)), null, "Delayed", null },
                    { 6, new DateTimeOffset(new DateTime(2025, 3, 29, 8, 18, 4, 251, DateTimeKind.Unspecified).AddTicks(7085), new TimeSpan(0, 0, 0, 0, 0)), null, "Cancelled", null }
                });

            migrationBuilder.InsertData(
                table: "Passengers",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "FlightId", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTimeOffset(new DateTime(2025, 3, 29, 8, 18, 4, 252, DateTimeKind.Unspecified).AddTicks(149), new TimeSpan(0, 0, 0, 0, 0)), null, null, "Alex Brown", null },
                    { 2, new DateTimeOffset(new DateTime(2025, 3, 29, 8, 18, 4, 252, DateTimeKind.Unspecified).AddTicks(157), new TimeSpan(0, 0, 0, 0, 0)), null, null, "Emma Wilson", null },
                    { 3, new DateTimeOffset(new DateTime(2025, 3, 29, 8, 18, 4, 252, DateTimeKind.Unspecified).AddTicks(159), new TimeSpan(0, 0, 0, 0, 0)), null, null, "Michael Chen", null }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "RoleName", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTimeOffset(new DateTime(2025, 3, 29, 8, 18, 4, 251, DateTimeKind.Unspecified).AddTicks(5509), new TimeSpan(0, 0, 0, 0, 0)), null, "Pilot", null },
                    { 2, new DateTimeOffset(new DateTime(2025, 3, 29, 8, 18, 4, 251, DateTimeKind.Unspecified).AddTicks(5521), new TimeSpan(0, 0, 0, 0, 0)), null, "Co-Pilot", null },
                    { 3, new DateTimeOffset(new DateTime(2025, 3, 29, 8, 18, 4, 251, DateTimeKind.Unspecified).AddTicks(5523), new TimeSpan(0, 0, 0, 0, 0)), null, "Flight Attendant", null },
                    { 4, new DateTimeOffset(new DateTime(2025, 3, 29, 8, 18, 4, 251, DateTimeKind.Unspecified).AddTicks(5538), new TimeSpan(0, 0, 0, 0, 0)), null, "Engineer", null }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "CountryName", "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, 1, "Bulgaria", new DateTimeOffset(new DateTime(2025, 3, 29, 8, 18, 4, 251, DateTimeKind.Unspecified).AddTicks(2714), new TimeSpan(0, 0, 0, 0, 0)), null, null },
                    { 2, 1, "France", new DateTimeOffset(new DateTime(2025, 3, 29, 8, 18, 4, 251, DateTimeKind.Unspecified).AddTicks(2929), new TimeSpan(0, 0, 0, 0, 0)), null, null },
                    { 3, 1, "Spain", new DateTimeOffset(new DateTime(2025, 3, 29, 8, 18, 4, 251, DateTimeKind.Unspecified).AddTicks(2932), new TimeSpan(0, 0, 0, 0, 0)), null, null },
                    { 4, 1, "Italy", new DateTimeOffset(new DateTime(2025, 3, 29, 8, 18, 4, 251, DateTimeKind.Unspecified).AddTicks(2933), new TimeSpan(0, 0, 0, 0, 0)), null, null },
                    { 5, 1, "Romania", new DateTimeOffset(new DateTime(2025, 3, 29, 8, 18, 4, 251, DateTimeKind.Unspecified).AddTicks(2935), new TimeSpan(0, 0, 0, 0, 0)), null, null },
                    { 6, 2, "Japan", new DateTimeOffset(new DateTime(2025, 3, 29, 8, 18, 4, 251, DateTimeKind.Unspecified).AddTicks(2939), new TimeSpan(0, 0, 0, 0, 0)), null, null },
                    { 7, 2, "China", new DateTimeOffset(new DateTime(2025, 3, 29, 8, 18, 4, 251, DateTimeKind.Unspecified).AddTicks(2940), new TimeSpan(0, 0, 0, 0, 0)), null, null },
                    { 8, 2, "India", new DateTimeOffset(new DateTime(2025, 3, 29, 8, 18, 4, 251, DateTimeKind.Unspecified).AddTicks(2942), new TimeSpan(0, 0, 0, 0, 0)), null, null }
                });

            migrationBuilder.InsertData(
                table: "Crews",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "FlightId", "Name", "RoleId", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTimeOffset(new DateTime(2025, 3, 29, 8, 18, 4, 251, DateTimeKind.Unspecified).AddTicks(6122), new TimeSpan(0, 0, 0, 0, 0)), null, null, "John Smith", 1, null },
                    { 2, new DateTimeOffset(new DateTime(2025, 3, 29, 8, 18, 4, 251, DateTimeKind.Unspecified).AddTicks(6132), new TimeSpan(0, 0, 0, 0, 0)), null, null, "Maria Garcia", 2, null },
                    { 3, new DateTimeOffset(new DateTime(2025, 3, 29, 8, 18, 4, 251, DateTimeKind.Unspecified).AddTicks(6134), new TimeSpan(0, 0, 0, 0, 0)), null, null, "James Wilson", 3, null },
                    { 4, new DateTimeOffset(new DateTime(2025, 3, 29, 8, 18, 4, 251, DateTimeKind.Unspecified).AddTicks(6135), new TimeSpan(0, 0, 0, 0, 0)), null, null, "Sarah Johnson", 3, null }
                });

            migrationBuilder.InsertData(
                table: "Flights",
                columns: new[] { "Id", "AirplaneId", "AirportId", "CreatedAt", "DeletedAt", "FlightDate", "FlightDuration", "PassengerCount", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, 1, null, new DateTimeOffset(new DateTime(2025, 3, 29, 8, 18, 4, 251, DateTimeKind.Unspecified).AddTicks(8740), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTimeOffset(new DateTime(2025, 3, 30, 8, 18, 4, 251, DateTimeKind.Unspecified).AddTicks(7729), new TimeSpan(0, 0, 0, 0, 0)), 120, 150, null },
                    { 2, 2, null, new DateTimeOffset(new DateTime(2025, 3, 29, 8, 18, 4, 251, DateTimeKind.Unspecified).AddTicks(8904), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTimeOffset(new DateTime(2025, 3, 31, 8, 18, 4, 251, DateTimeKind.Unspecified).AddTicks(8893), new TimeSpan(0, 0, 0, 0, 0)), 180, 200, null }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "CountryId", "CreatedAt", "DeletedAt", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, 1, new DateTimeOffset(new DateTime(2025, 3, 29, 8, 18, 4, 251, DateTimeKind.Unspecified).AddTicks(3898), new TimeSpan(0, 0, 0, 0, 0)), null, "Sofia", null },
                    { 2, 2, new DateTimeOffset(new DateTime(2025, 3, 29, 8, 18, 4, 251, DateTimeKind.Unspecified).AddTicks(3912), new TimeSpan(0, 0, 0, 0, 0)), null, "Paris", null },
                    { 3, 3, new DateTimeOffset(new DateTime(2025, 3, 29, 8, 18, 4, 251, DateTimeKind.Unspecified).AddTicks(3914), new TimeSpan(0, 0, 0, 0, 0)), null, "Madrid", null },
                    { 4, 4, new DateTimeOffset(new DateTime(2025, 3, 29, 8, 18, 4, 251, DateTimeKind.Unspecified).AddTicks(3915), new TimeSpan(0, 0, 0, 0, 0)), null, "Rome", null },
                    { 5, 5, new DateTimeOffset(new DateTime(2025, 3, 29, 8, 18, 4, 251, DateTimeKind.Unspecified).AddTicks(3917), new TimeSpan(0, 0, 0, 0, 0)), null, "Bucharest", null },
                    { 6, 6, new DateTimeOffset(new DateTime(2025, 3, 29, 8, 18, 4, 251, DateTimeKind.Unspecified).AddTicks(3920), new TimeSpan(0, 0, 0, 0, 0)), null, "Tokyo", null },
                    { 7, 7, new DateTimeOffset(new DateTime(2025, 3, 29, 8, 18, 4, 251, DateTimeKind.Unspecified).AddTicks(3922), new TimeSpan(0, 0, 0, 0, 0)), null, "Beijing", null },
                    { 8, 8, new DateTimeOffset(new DateTime(2025, 3, 29, 8, 18, 4, 251, DateTimeKind.Unspecified).AddTicks(3923), new TimeSpan(0, 0, 0, 0, 0)), null, "New Delhi", null }
                });

            migrationBuilder.InsertData(
                table: "FlightStatusChanges",
                columns: new[] { "Id", "ChangeAt", "CreatedAt", "DeletedAt", "FlightId", "FlightStatusId", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 3, 29, 8, 18, 4, 251, DateTimeKind.Utc).AddTicks(9370), new DateTimeOffset(new DateTime(2025, 3, 29, 8, 18, 4, 251, DateTimeKind.Unspecified).AddTicks(9614), new TimeSpan(0, 0, 0, 0, 0)), null, 1, 1, null },
                    { 2, new DateTime(2025, 3, 29, 8, 18, 4, 251, DateTimeKind.Utc).AddTicks(9627), new DateTimeOffset(new DateTime(2025, 3, 29, 8, 18, 4, 251, DateTimeKind.Unspecified).AddTicks(9627), new TimeSpan(0, 0, 0, 0, 0)), null, 2, 1, null }
                });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "FlightId", "PassengerId", "SeatNumber", "TicketPrice", "Type", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTimeOffset(new DateTime(2025, 3, 29, 8, 18, 4, 252, DateTimeKind.Unspecified).AddTicks(1029), new TimeSpan(0, 0, 0, 0, 0)), null, 1, null, 15, 299.99m, "Economy", null },
                    { 2, new DateTimeOffset(new DateTime(2025, 3, 29, 8, 18, 4, 252, DateTimeKind.Unspecified).AddTicks(1044), new TimeSpan(0, 0, 0, 0, 0)), null, 1, null, 3, 499.99m, "Business", null }
                });

            migrationBuilder.InsertData(
                table: "Airports",
                columns: new[] { "Id", "AirplaneId", "AirportName", "CityId", "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, null, "Sofia International Airport", 1, new DateTimeOffset(new DateTime(2025, 3, 29, 8, 18, 4, 251, DateTimeKind.Unspecified).AddTicks(4813), new TimeSpan(0, 0, 0, 0, 0)), null, null },
                    { 2, null, "Charles de Gaulle Airport", 2, new DateTimeOffset(new DateTime(2025, 3, 29, 8, 18, 4, 251, DateTimeKind.Unspecified).AddTicks(4825), new TimeSpan(0, 0, 0, 0, 0)), null, null },
                    { 3, null, "Adolfo Suárez Madrid–Barajas Airport", 3, new DateTimeOffset(new DateTime(2025, 3, 29, 8, 18, 4, 251, DateTimeKind.Unspecified).AddTicks(4827), new TimeSpan(0, 0, 0, 0, 0)), null, null },
                    { 4, null, "Leonardo da Vinci International Airport", 4, new DateTimeOffset(new DateTime(2025, 3, 29, 8, 18, 4, 251, DateTimeKind.Unspecified).AddTicks(4828), new TimeSpan(0, 0, 0, 0, 0)), null, null },
                    { 5, null, "Henri Coandă International Airport", 5, new DateTimeOffset(new DateTime(2025, 3, 29, 8, 18, 4, 251, DateTimeKind.Unspecified).AddTicks(4830), new TimeSpan(0, 0, 0, 0, 0)), null, null },
                    { 6, null, "Haneda Airport", 6, new DateTimeOffset(new DateTime(2025, 3, 29, 8, 18, 4, 251, DateTimeKind.Unspecified).AddTicks(4897), new TimeSpan(0, 0, 0, 0, 0)), null, null },
                    { 7, null, "Beijing Capital International Airport", 7, new DateTimeOffset(new DateTime(2025, 3, 29, 8, 18, 4, 251, DateTimeKind.Unspecified).AddTicks(4899), new TimeSpan(0, 0, 0, 0, 0)), null, null },
                    { 8, null, "Indira Gandhi International Airport", 8, new DateTimeOffset(new DateTime(2025, 3, 29, 8, 18, 4, 251, DateTimeKind.Unspecified).AddTicks(4900), new TimeSpan(0, 0, 0, 0, 0)), null, null }
                });

            migrationBuilder.InsertData(
                table: "Payrolls",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "PassengerId", "TicketId", "Total", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTimeOffset(new DateTime(2025, 3, 29, 8, 18, 4, 252, DateTimeKind.Unspecified).AddTicks(1670), new TimeSpan(0, 0, 0, 0, 0)), null, 1, 1, 299.99000000000001, null },
                    { 2, new DateTimeOffset(new DateTime(2025, 3, 29, 8, 18, 4, 252, DateTimeKind.Unspecified).AddTicks(1681), new TimeSpan(0, 0, 0, 0, 0)), null, 2, 2, 499.99000000000001, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Airplanes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Crews",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Crews",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Crews",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Crews",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "FlightStatusChanges",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "FlightStatusChanges",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "FlightStatuses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "FlightStatuses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "FlightStatuses",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "FlightStatuses",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "FlightStatuses",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Payrolls",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Payrolls",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "FlightStatuses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Airplanes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Airplanes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
