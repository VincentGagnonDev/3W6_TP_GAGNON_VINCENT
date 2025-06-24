using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JuliePro.Migrations
{
    /// <inheritdoc />
    public partial class CustomerObjectif : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StartWeight = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerId);
                });

            migrationBuilder.CreateTable(
                name: "Objectives",
                columns: table => new
                {
                    ObjectiveId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LostWeightKg = table.Column<double>(type: "float", nullable: false),
                    DistanceKm = table.Column<double>(type: "float", nullable: false),
                    AchievedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Objectives", x => x.ObjectiveId);
                    table.ForeignKey(
                        name: "FK_Objectives_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "BirthDate", "Email", "FirstName", "LastName", "StartWeight" },
                values: new object[,]
                {
                    { 1, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "alice@juliepro.ca", "Alice", "Smith", 150.0 },
                    { 2, new DateTime(1985, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "bob@juliepro.ca", "Bob", "Brown", 180.0 },
                    { 3, new DateTime(1992, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "carol@juliepro.ca", "Carol", "Johnson", 140.0 },
                    { 4, new DateTime(1988, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "david@juliepro.ca", "David", "Davis", 200.0 }
                });

            migrationBuilder.InsertData(
                table: "Objectives",
                columns: new[] { "ObjectiveId", "AchievedDate", "CustomerId", "DistanceKm", "LostWeightKg", "Name" },
                values: new object[,]
                {
                    { 1, null, 1, 0.0, 5.0, "Perte 5kg" },
                    { 2, new DateTime(2025, 3, 23, 21, 14, 30, 619, DateTimeKind.Local).AddTicks(5981), 1, 5.0, 0.0, "Course 5km" },
                    { 3, new DateTime(2025, 4, 23, 21, 14, 30, 621, DateTimeKind.Local).AddTicks(6930), 1, 0.0, 3.0, "Perte 3kg" },
                    { 4, new DateTime(2025, 5, 23, 21, 14, 30, 621, DateTimeKind.Local).AddTicks(6941), 1, 10.0, 0.0, "Course 10km" },
                    { 5, null, 2, 0.0, 7.0, "Perte 7kg" },
                    { 6, null, 2, 8.0, 0.0, "Course 8km" },
                    { 7, new DateTime(2025, 2, 23, 21, 14, 30, 621, DateTimeKind.Local).AddTicks(6946), 3, 6.0, 0.0, "Course 6km" },
                    { 8, new DateTime(2025, 3, 23, 21, 14, 30, 621, DateTimeKind.Local).AddTicks(6948), 3, 0.0, 4.0, "Perte 4kg" },
                    { 9, null, 4, 12.0, 0.0, "Course 12km" },
                    { 10, new DateTime(2025, 4, 23, 21, 14, 30, 621, DateTimeKind.Local).AddTicks(6950), 4, 0.0, 6.0, "Perte 6kg" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Objectives_CustomerId",
                table: "Objectives",
                column: "CustomerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Objectives");

            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
