using Microsoft.EntityFrameworkCore.Migrations;

namespace dotnet_NewProject.Migrations.homepromo
{
    public partial class Update181020211518 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ValueType",
                table: "modelHomePromo",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ValueType",
                table: "modelHomePromo");
        }
    }
}
