using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BolsaTrabajoSMA.Server.Migrations
{
    /// <inheritdoc />
    public partial class tipo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "escolaridadess",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nivel = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_escolaridadess", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "habilidades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Habililidad = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_habilidades", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "modalidades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tipo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_modalidades", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "nombrePuestos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombrePuest = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_nombrePuestos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "responsabilidades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Respon = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_responsabilidades", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tipoContrataciones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tipo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tipoContrataciones", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "escolaridadess");

            migrationBuilder.DropTable(
                name: "habilidades");

            migrationBuilder.DropTable(
                name: "modalidades");

            migrationBuilder.DropTable(
                name: "nombrePuestos");

            migrationBuilder.DropTable(
                name: "responsabilidades");

            migrationBuilder.DropTable(
                name: "tipoContrataciones");
        }
    }
}
