using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MvcClients.Migrations
{
    public partial class clientid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Client",
                columns: table => new
                {
                    ClientId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Civilite = table.Column<string>(nullable: true),
                    Nom = table.Column<string>(nullable: false),
                    Prenom = table.Column<string>(nullable: false),
                    DateNaissance = table.Column<DateTime>(nullable: false),
                    CodePostale = table.Column<int>(nullable: false),
                    Adresse = table.Column<string>(nullable: true),
                    Pays = table.Column<string>(nullable: false),
                    Mail = table.Column<string>(nullable: true),
                    Telephone = table.Column<string>(nullable: false),
                    Ville = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.ClientId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Client");
        }
    }
}
