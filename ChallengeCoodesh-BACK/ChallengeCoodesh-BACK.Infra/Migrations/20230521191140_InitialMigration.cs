using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ChallengeCoodesh_BACK.Infra.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "fileUploader",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TypeTransaction = table.Column<int>(type: "INTEGER", nullable: false),
                    ProductDescription = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ValueProduct = table.Column<decimal>(type: "TEXT", nullable: false),
                    SellerName = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_fileUploader", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "fileUploader",
                columns: new[] { "Id", "CreatedDate", "ProductDescription", "SellerName", "TypeTransaction", "ValueProduct" },
                values: new object[] { 1, new DateTime(2023, 5, 21, 16, 11, 40, 606, DateTimeKind.Local).AddTicks(1509), "DESENVOLVEDOR FULL STACK", "ELIANA NOGUEIRA", 1, 155000m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "fileUploader");
        }
    }
}
