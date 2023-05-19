using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorSyncfusion.Server.Migrations
{
    /// <inheritdoc />
    public partial class Department : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "School",
                table: "Employees");

            migrationBuilder.AddColumn<int>(
                name: "DepartmentId",
                table: "Employees",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Department",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Latitude = table.Column<double>(type: "float", nullable: true),
                    Longtitude = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Department",
                columns: new[] { "Id", "Latitude", "Longtitude", "Name" },
                values: new object[,]
                {
                    { 1, null, null, "AspIT Nordjylland" },
                    { 2, null, null, "AspIT Østjylland" },
                    { 3, null, null, "AspIT Trekanten" },
                    { 4, null, null, "AspIN" }
                });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateHired", "DepartmentId" },
                values: new object[] { new DateTime(2023, 5, 19, 15, 28, 45, 374, DateTimeKind.Local).AddTicks(6336), 1 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateHired", "DepartmentId" },
                values: new object[] { new DateTime(2023, 5, 19, 15, 28, 45, 374, DateTimeKind.Local).AddTicks(6383), 1 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateHired", "DepartmentId" },
                values: new object[] { new DateTime(2023, 5, 19, 15, 28, 45, 374, DateTimeKind.Local).AddTicks(6386), 4 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateHired", "DepartmentId" },
                values: new object[] { new DateTime(2023, 5, 19, 15, 28, 45, 374, DateTimeKind.Local).AddTicks(6388), 4 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateHired", "DepartmentId" },
                values: new object[] { new DateTime(2023, 5, 19, 15, 28, 45, 374, DateTimeKind.Local).AddTicks(6391), 1 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateHired", "DepartmentId" },
                values: new object[] { new DateTime(2023, 5, 19, 15, 28, 45, 374, DateTimeKind.Local).AddTicks(6394), 1 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateHired", "DepartmentId" },
                values: new object[] { new DateTime(2023, 5, 19, 15, 28, 45, 374, DateTimeKind.Local).AddTicks(6396), 1 });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 5, 19, 15, 28, 45, 374, DateTimeKind.Local).AddTicks(6526));

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 5, 19, 15, 28, 45, 374, DateTimeKind.Local).AddTicks(6530));

            migrationBuilder.CreateIndex(
                name: "IX_Employees_DepartmentId",
                table: "Employees",
                column: "DepartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Department_DepartmentId",
                table: "Employees",
                column: "DepartmentId",
                principalTable: "Department",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Department_DepartmentId",
                table: "Employees");

            migrationBuilder.DropTable(
                name: "Department");

            migrationBuilder.DropIndex(
                name: "IX_Employees_DepartmentId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "DepartmentId",
                table: "Employees");

            migrationBuilder.AddColumn<string>(
                name: "School",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateHired", "School" },
                values: new object[] { new DateTime(2023, 5, 19, 13, 25, 54, 871, DateTimeKind.Local).AddTicks(2436), "AspIT Trekanten" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateHired", "School" },
                values: new object[] { new DateTime(2023, 5, 19, 13, 25, 54, 871, DateTimeKind.Local).AddTicks(2484), "AspIT Trekanten" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateHired", "School" },
                values: new object[] { new DateTime(2023, 5, 19, 13, 25, 54, 871, DateTimeKind.Local).AddTicks(2487), "AspIN" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateHired", "School" },
                values: new object[] { new DateTime(2023, 5, 19, 13, 25, 54, 871, DateTimeKind.Local).AddTicks(2490), "AspIN" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateHired", "School" },
                values: new object[] { new DateTime(2023, 5, 19, 13, 25, 54, 871, DateTimeKind.Local).AddTicks(2492), "AspIT Trekanten" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateHired", "School" },
                values: new object[] { new DateTime(2023, 5, 19, 13, 25, 54, 871, DateTimeKind.Local).AddTicks(2531), "AspIT Trekanten" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateHired", "School" },
                values: new object[] { new DateTime(2023, 5, 19, 13, 25, 54, 871, DateTimeKind.Local).AddTicks(2534), "AspIT Trekanten" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 5, 19, 13, 25, 54, 871, DateTimeKind.Local).AddTicks(2667));

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 5, 19, 13, 25, 54, 871, DateTimeKind.Local).AddTicks(2671));
        }
    }
}
