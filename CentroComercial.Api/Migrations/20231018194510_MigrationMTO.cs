using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CentroComercial.API.Migrations
{
    /// <inheritdoc />
    public partial class MigrationMTO : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Calendario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaActual = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Calendario", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Centrocomerciales",
                columns: table => new
                {
                    IdCentroComercial = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombreCentroComercial = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    capacidadMaxima = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    horarioApertura = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    horarioCierre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tiendas = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    eventos = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Centrocomerciales", x => x.IdCentroComercial);
                });

            migrationBuilder.CreateTable(
                name: "Notificaciones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SentDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notificaciones", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tiendas",
                columns: table => new
                {
                    IdTienda = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombreTienda = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    categoria = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    horarioApertura = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    horarioCierre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tiendas", x => x.IdTienda);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Calendario");

            migrationBuilder.DropTable(
                name: "Centrocomerciales");

            migrationBuilder.DropTable(
                name: "Notificaciones");

            migrationBuilder.DropTable(
                name: "Tiendas");
        }
    }
}
