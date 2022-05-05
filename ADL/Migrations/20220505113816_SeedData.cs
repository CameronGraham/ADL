using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ADL.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Requests",
                columns: new[] { "Id", "Address", "AppointmentDate", "AppointmentTime", "Comments", "ContactNumber", "EmailAddress", "FirstName", "JobCategory", "LastName", "Postcode", "Town", "VehicleRegistation" },
                values: new object[] { 1, "123 Test Way", new DateTime(2022, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "11:00 - 13:00", "The bus is broken", "12345678910", "joe.bloggs@email.com", "Joe", "breakdown", "Bloggs", "postcode", "TownName", "1234567" });

            migrationBuilder.InsertData(
                table: "Requests",
                columns: new[] { "Id", "Address", "AppointmentDate", "AppointmentTime", "Comments", "ContactNumber", "EmailAddress", "FirstName", "JobCategory", "LastName", "Postcode", "Town", "VehicleRegistation" },
                values: new object[] { 2, "124 Test Way", new DateTime(2022, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "09:00 - 11:00", "Engine making noise", "12345678910", "janedoe@email.com", "Jane", "warranty", "Doe", "postcode", "TownName", "1234567" });

            migrationBuilder.InsertData(
                table: "Requests",
                columns: new[] { "Id", "Address", "AppointmentDate", "AppointmentTime", "Comments", "ContactNumber", "EmailAddress", "FirstName", "JobCategory", "LastName", "Postcode", "Town", "VehicleRegistation" },
                values: new object[] { 3, "125 Test Way", new DateTime(2022, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "09:00 - 11:00", "The bus is broken", "12345678910", "joe.bloggs@email.com", "Joe", "breakdown", "Bloggs", "postcode", "TownName", "1234567" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Requests",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Requests",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Requests",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
