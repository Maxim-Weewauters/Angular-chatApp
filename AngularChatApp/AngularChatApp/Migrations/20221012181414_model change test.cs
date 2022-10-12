using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AngularChatApp.Migrations
{
    public partial class modelchangetest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usertest",
                columns: table => new
                {
                    UsertestId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usertest", x => x.UsertestId);
                });

            migrationBuilder.InsertData(
                table: "Usertest",
                columns: new[] { "UsertestId", "Password", "name", "username" },
                values: new object[] { new Guid("12a7f862-4b56-4ad0-a22a-5bf82d3a9b42"), "wachtwoord2", "vincent", "achterlijken" });

            migrationBuilder.InsertData(
                table: "Usertest",
                columns: new[] { "UsertestId", "Password", "name", "username" },
                values: new object[] { new Guid("5b1cca4e-17a2-4c14-8cb1-4dd2d7158c92"), "test", "test", "testt" });

            migrationBuilder.InsertData(
                table: "Usertest",
                columns: new[] { "UsertestId", "Password", "name", "username" },
                values: new object[] { new Guid("ab41fe7f-9c08-4e2f-8f4d-9efeb47431b8"), "wachtwoord", "maxim", "maximeke" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Usertest");
        }
    }
}
