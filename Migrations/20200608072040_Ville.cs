using Microsoft.EntityFrameworkCore.Migrations;

namespace MvcClients.Migrations
{
    public partial class Ville : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Ville",
                table: "Client",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ville",
                table: "Client");
        }
    }
}
