using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorApp1.Data.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DetaliiFactura",
                columns: table => new
                {
                    IdDetaliiFactura = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdLocatie = table.Column<int>(type: "int", nullable: false),
                    NumeProdus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cantitate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PretUnitar = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Valoare = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IdFactura = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetaliiFactura", x => new { x.IdDetaliiFactura, x.IdLocatie });
                });

            migrationBuilder.CreateTable(
                name: "Facturi",
                columns: table => new
                {
                    IdFactura = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdLocatie = table.Column<int>(type: "int", nullable: false),
                    NumarFactura = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataFactura = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NumeClient = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Facturi", x => new { x.IdFactura, x.IdLocatie });
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DetaliiFactura");

            migrationBuilder.DropTable(
                name: "Facturi");
        }
    }
}
