using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace dotnet_NewProject.Migrations.homepromo
{
    public partial class _202110181857 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "Content",
                table: "modelHomePromo",
                type: "BLOB",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Content",
                table: "modelHomePromo");
        }
    }
}
