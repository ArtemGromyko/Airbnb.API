using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Airbnb.DAL.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    HasInternet = table.Column<bool>(type: "bit", nullable: false),
                    Price = table.Column<decimal>(type: "money", nullable: false),
                    OwnerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rooms_Users_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StartDate = table.Column<DateTime>(type: "date", nullable: false),
                    EndDate = table.Column<DateTime>(type: "date", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoomId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reservations_Rooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Rooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reservations_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { new Guid("85d2dad8-5ad5-4ad7-ab42-2a883cf0846a"), "tom@email.com", "Tom" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { new Guid("bf62c2cd-aa17-47ea-b575-f8d769966fb9"), "bob@email.com", "Bob" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Address", "HasInternet", "OwnerId", "Price" },
                values: new object[] { new Guid("601ec7d3-b5c9-43c8-8adb-63fdc67bb1bd"), "10014, Perry Street, New York", true, new Guid("bf62c2cd-aa17-47ea-b575-f8d769966fb9"), 100m });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Address", "HasInternet", "OwnerId", "Price" },
                values: new object[] { new Guid("75518431-3035-4a5d-8f91-d8a6e8f8af47"), "10019, West 53rd Street, New York", true, new Guid("bf62c2cd-aa17-47ea-b575-f8d769966fb9"), 80m });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "Id", "EndDate", "RoomId", "StartDate", "UserId" },
                values: new object[] { new Guid("f6736344-8a7e-43f4-9a1a-facf460b5f3f"), new DateTime(2022, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("75518431-3035-4a5d-8f91-d8a6e8f8af47"), new DateTime(2022, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("85d2dad8-5ad5-4ad7-ab42-2a883cf0846a") });

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_RoomId",
                table: "Reservations",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_UserId",
                table: "Reservations",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_OwnerId",
                table: "Rooms",
                column: "OwnerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reservations");

            migrationBuilder.DropTable(
                name: "Rooms");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
