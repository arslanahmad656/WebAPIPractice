using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CompanyEmployees.Migrations
{
    public partial class InitialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "CompanyId", "Address", "Country", "Name" },
                values: new object[] { new Guid("021037b0-877f-11ee-b9d1-0242ac120002"), "583 Wall Dr. Gwyn Oak, MD 21207", "USA", "IT_Solutions Ltd" });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "CompanyId", "Address", "Country", "Name" },
                values: new object[] { new Guid("02103f94-877f-11ee-b9d1-0242ac120002"), "312 Forest Avenue, BF 923", "USA", "Admin_Solutions Ltd" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "Age", "CompanyId", "Name", "Position" },
                values: new object[] { new Guid("756e30ab-0355-4a82-b2bf-899db1d60174"), 30, new Guid("02103f94-877f-11ee-b9d1-0242ac120002"), "Jana McLeaf", "Software Developer" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "Age", "CompanyId", "Name", "Position" },
                values: new object[] { new Guid("ac770f98-648e-4bf0-aaa2-ba8c0a7d262e"), 30, new Guid("021037b0-877f-11ee-b9d1-0242ac120002"), "Jana McLeaf", "Software Developer" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "Age", "CompanyId", "Name", "Position" },
                values: new object[] { new Guid("ce74a83e-c248-4389-9491-18a41c4cca1d"), 26, new Guid("021037b0-877f-11ee-b9d1-0242ac120002"), "Sam Raiden", "Software Developer" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("756e30ab-0355-4a82-b2bf-899db1d60174"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("ac770f98-648e-4bf0-aaa2-ba8c0a7d262e"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("ce74a83e-c248-4389-9491-18a41c4cca1d"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: new Guid("021037b0-877f-11ee-b9d1-0242ac120002"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: new Guid("02103f94-877f-11ee-b9d1-0242ac120002"));
        }
    }
}
