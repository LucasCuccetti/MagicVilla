using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicVillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class AgregarNumeroVillaTabla : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "numeroVillas",
                columns: table => new
                {
                    VillaNo = table.Column<int>(type: "int", nullable: false),
                    VillaId = table.Column<int>(type: "int", nullable: false),
                    DetalleEspecial = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaActualizacion = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_numeroVillas", x => x.VillaNo);
                    table.ForeignKey(
                        name: "FK_numeroVillas_Villas_VillaId",
                        column: x => x.VillaId,
                        principalTable: "Villas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FechaActualizacion", "FechaCreacion" },
                values: new object[] { new DateTime(2024, 2, 14, 10, 32, 33, 747, DateTimeKind.Local).AddTicks(6419), new DateTime(2024, 2, 14, 10, 32, 33, 747, DateTimeKind.Local).AddTicks(6386) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FechaActualizacion", "FechaCreacion" },
                values: new object[] { new DateTime(2024, 2, 14, 10, 32, 33, 747, DateTimeKind.Local).AddTicks(6423), new DateTime(2024, 2, 14, 10, 32, 33, 747, DateTimeKind.Local).AddTicks(6422) });

            migrationBuilder.CreateIndex(
                name: "IX_numeroVillas_VillaId",
                table: "numeroVillas",
                column: "VillaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "numeroVillas");

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FechaActualizacion", "FechaCreacion" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 41, 52, 467, DateTimeKind.Local).AddTicks(8754), new DateTime(2023, 11, 21, 20, 41, 52, 467, DateTimeKind.Local).AddTicks(8742) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FechaActualizacion", "FechaCreacion" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 41, 52, 467, DateTimeKind.Local).AddTicks(8758), new DateTime(2023, 11, 21, 20, 41, 52, 467, DateTimeKind.Local).AddTicks(8757) });
        }
    }
}
