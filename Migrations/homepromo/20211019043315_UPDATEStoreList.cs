using Microsoft.EntityFrameworkCore.Migrations;

namespace dotnet_NewProject.Migrations.homepromo
{
    public partial class UPDATEStoreList : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "modelStoreList",
                columns: table => new
                {
                    Store = table.Column<string>(type: "TEXT", nullable: false),
                    StoreName = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_modelStoreList", x => x.Store);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "modelStoreList");
        }
    }
}
