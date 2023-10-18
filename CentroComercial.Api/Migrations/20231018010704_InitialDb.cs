using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CentroComercial.API.Migrations
{
    /// <inheritdoc />
    public partial class InitialDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ejemplos");

            migrationBuilder.CreateTable(
                name: "CentrosComerciales",
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
                    table.PrimaryKey("PK_CentrosComerciales", x => x.IdCentroComercial);
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

            migrationBuilder.CreateIndex(
                name: "IX_CentrosComerciales_IdCentroComercial",
                table: "CentrosComerciales",
                column: "IdCentroComercial",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tiendas_IdTienda",
                table: "Tiendas",
                column: "IdTienda",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CentrosComerciales");

            migrationBuilder.DropTable(
                name: "Tiendas");

            migrationBuilder.CreateTable(
                name: "Ejemplos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CellPhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Documento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ejemplos", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ejemplos_FirstName",
                table: "Ejemplos",
                column: "FirstName",
                unique: true);
        }
    }
}
