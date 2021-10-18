using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace dotnet_NewProject.Migrations.homepromo
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "modelHomePromo",
                columns: table => new
                {
                    ID = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    PromoType = table.Column<string>(type: "TEXT", nullable: true),
                    DurationStartDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DurationEndDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Store = table.Column<string>(type: "TEXT", nullable: true),
                    StoreName = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_modelHomePromo", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "modelHomePromo");
        }
    }
}
