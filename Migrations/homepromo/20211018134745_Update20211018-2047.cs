using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace dotnet_NewProject.Migrations.homepromo
{
    public partial class Update202110182047 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Content",
                table: "modelHomePromo");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "Content",
                table: "modelHomePromo",
                type: "BLOB",
                nullable: true);
        }
    }
}
