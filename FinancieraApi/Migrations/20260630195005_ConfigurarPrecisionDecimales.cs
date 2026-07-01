using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinancieraApi.Migrations
{
    /// <inheritdoc />
    public partial class ConfigurarPrecisionDecimales : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TasaIntereses",
                table: "Prestamos");

            migrationBuilder.RenameColumn(
                name: "FechaSolicitus",
                table: "Prestamos",
                newName: "FechaSolicitud");

            migrationBuilder.AddColumn<decimal>(
                name: "TasaInteres",
                table: "Prestamos",
                type: "decimal(5,2)",
                precision: 5,
                scale: 2,
                nullable: false,
                defaultValue: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TasaInteres",
                table: "Prestamos");

            migrationBuilder.RenameColumn(
                name: "FechaSolicitud",
                table: "Prestamos",
                newName: "FechaSolicitus");

            migrationBuilder.AddColumn<decimal>(
                name: "TasaIntereses",
                table: "Prestamos",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
