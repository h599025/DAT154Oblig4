using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CleaningSystem.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "customer",
                columns: table => new
                {
                    email = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    password = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customer", x => x.email);
                });

            migrationBuilder.CreateTable(
                name: "room",
                columns: table => new
                {
                    roomnr = table.Column<int>(type: "int", nullable: false),
                    beds = table.Column<int>(type: "int", nullable: false),
                    size = table.Column<int>(type: "int", nullable: false),
                    price = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_room", x => x.roomnr);
                });

            migrationBuilder.CreateTable(
                name: "booking",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    roomnr = table.Column<int>(type: "int", nullable: false),
                    checkindate = table.Column<DateTime>(type: "date", nullable: false),
                    checkoutdate = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_booking", x => x.Id);
                    table.ForeignKey(
                        name: "FK__booking__roomnr__2C3393D0",
                        column: x => x.roomnr,
                        principalTable: "room",
                        principalColumn: "roomnr");
                });

            migrationBuilder.CreateTable(
                name: "Service",
                columns: table => new
                {
                    roomnr = table.Column<int>(type: "int", nullable: false),
                    checkedin = table.Column<bool>(type: "bit", nullable: false),
                    cleaning = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    service = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    maintenance = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    status = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    note = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Service", x => x.roomnr);
                    table.ForeignKey(
                        name: "FK__Service__roomnr__2B3F6F97",
                        column: x => x.roomnr,
                        principalTable: "room",
                        principalColumn: "roomnr");
                });

            migrationBuilder.CreateIndex(
                name: "IX_booking_roomnr",
                table: "booking",
                column: "roomnr");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "booking");

            migrationBuilder.DropTable(
                name: "customer");

            migrationBuilder.DropTable(
                name: "Service");

            migrationBuilder.DropTable(
                name: "room");
        }
    }
}
