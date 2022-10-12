using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AngularChatApp.Migrations
{
    public partial class modelchangebackback : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Password", "name", "username" },
                values: new object[] { new Guid("1cf0cdb3-959b-4e0f-b433-43926e108735"), "wimpie2000", "Wim", "Wimpie" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Password", "name", "username" },
                values: new object[] { new Guid("691a8091-74da-4379-90ed-c15f6d1ca05e"), "wachtwoord", "maxim", "maximeke" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Password", "name", "username" },
                values: new object[] { new Guid("ff5dcf60-c352-4556-b6fc-858fad0a680e"), "wachtwoord2", "vincent", "achterlijken" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
