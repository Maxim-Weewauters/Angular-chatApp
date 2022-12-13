using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AngularChatApp.Migrations
{
    public partial class updateandinput : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    MessageId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.MessageId);
                    table.ForeignKey(
                        name: "FK_Messages_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "CreatedDate", "Name", "Password", "UpdatedDate", "Username" },
                values: new object[,]
                {
                    { new Guid("12ef0cfa-82ea-4990-81b3-d894695b4a98"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "maxim", "wachtwoord", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "maximeke" },
                    { new Guid("29351069-3359-4077-8aa2-5cf028da3dd3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wim", "wimpie2000", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wimpie" },
                    { new Guid("84e8cfa0-97df-45d6-b140-bd583d537932"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "maxim", "wachtwoord", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "maximeke" },
                    { new Guid("abc111a2-ffa2-4cb8-a8a7-ce995fe1c9f1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "vincent", "wachtwoord2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "achterlijken" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Messages_UserId",
                table: "Messages",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Messages");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
