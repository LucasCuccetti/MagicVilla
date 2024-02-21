using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicVillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class ControlarNullables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_numeroVillas_Villas_VillaId",
                table: "numeroVillas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_numeroVillas",
                table: "numeroVillas");

            migrationBuilder.RenameTable(
                name: "numeroVillas",
                newName: "NumeroVillas");

            migrationBuilder.RenameIndex(
                name: "IX_numeroVillas_VillaId",
                table: "NumeroVillas",
                newName: "IX_NumeroVillas_VillaId");

            migrationBuilder.AlterColumn<string>(
                name: "ImagenUrl",
                table: "Villas",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Detalle",
                table: "Villas",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Amenidad",
                table: "Villas",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "DetalleEspecial",
                table: "NumeroVillas",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NumeroVillas",
                table: "NumeroVillas",
                column: "VillaNo");

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FechaActualizacion", "FechaCreacion" },
                values: new object[] { new DateTime(2024, 2, 16, 15, 10, 59, 901, DateTimeKind.Local).AddTicks(9042), new DateTime(2024, 2, 16, 15, 10, 59, 901, DateTimeKind.Local).AddTicks(9010) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FechaActualizacion", "FechaCreacion" },
                values: new object[] { new DateTime(2024, 2, 16, 15, 10, 59, 901, DateTimeKind.Local).AddTicks(9045), new DateTime(2024, 2, 16, 15, 10, 59, 901, DateTimeKind.Local).AddTicks(9044) });

            migrationBuilder.AddForeignKey(
                name: "FK_NumeroVillas_Villas_VillaId",
                table: "NumeroVillas",
                column: "VillaId",
                principalTable: "Villas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NumeroVillas_Villas_VillaId",
                table: "NumeroVillas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_NumeroVillas",
                table: "NumeroVillas");

            migrationBuilder.RenameTable(
                name: "NumeroVillas",
                newName: "numeroVillas");

            migrationBuilder.RenameIndex(
                name: "IX_NumeroVillas_VillaId",
                table: "numeroVillas",
                newName: "IX_numeroVillas_VillaId");

            migrationBuilder.AlterColumn<string>(
                name: "ImagenUrl",
                table: "Villas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Detalle",
                table: "Villas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Amenidad",
                table: "Villas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DetalleEspecial",
                table: "numeroVillas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_numeroVillas",
                table: "numeroVillas",
                column: "VillaNo");

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

            migrationBuilder.AddForeignKey(
                name: "FK_numeroVillas_Villas_VillaId",
                table: "numeroVillas",
                column: "VillaId",
                principalTable: "Villas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
