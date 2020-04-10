using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AngularWebApi.Migrations
{
    public partial class migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    CId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CName = table.Column<string>(nullable: true),
                    CDob = table.Column<DateTime>(nullable: false),
                    CPin = table.Column<int>(maxLength: 4, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.CId);
                });

            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "CId", "CDob", "CName", "CPin" },
                values: new object[] { 1, new DateTime(2019, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Palak", 1001 });

            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "CId", "CDob", "CName", "CPin" },
                values: new object[] { 2, new DateTime(2019, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kareena", 1002 });

            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "CId", "CDob", "CName", "CPin" },
                values: new object[] { 3, new DateTime(2019, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pushp", 1003 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customer");
        }
    }
}
