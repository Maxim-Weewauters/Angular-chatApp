using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AngularChatApp.Migrations
{
    public partial class modelchangeback : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserId);
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "UserId", "Password", "name", "username" },
                values: new object[] { new Guid("995c1479-155b-426f-813f-e69e56774974"), "wachtwoord", "maxim", "maximeke" });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "UserId", "Password", "name", "username" },
                values: new object[] { new Guid("b16e2cf4-6c84-4643-bda0-d8976b8d989d"), "wachtwoord2", "vincent", "achterlijken" });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "UserId", "Password", "name", "username" },
                values: new object[] { new Guid("fab45b78-bdc9-4f61-9c6b-4ae73dde7ceb"), "wimpie2000", "Wim", "Wimpie" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
