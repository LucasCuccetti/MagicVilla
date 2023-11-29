﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MagicVillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class AlimentarTablaVilla : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "Amenidad", "Detalle", "FechaActualizacion", "FechaCreacion", "ImagenUrl", "MetrosCuadrados", "Nombre", "Ocupantes", "Tarifa" },
                values: new object[,]
                {
                    { 1, "", "Detalle de la Villa...", new DateTime(2023, 11, 21, 20, 41, 52, 467, DateTimeKind.Local).AddTicks(8754), new DateTime(2023, 11, 21, 20, 41, 52, 467, DateTimeKind.Local).AddTicks(8742), "", 50, "Villa Real", 5, 200.0 },
                    { 2, "", "Detalle de la Villa2...", new DateTime(2023, 11, 21, 20, 41, 52, 467, DateTimeKind.Local).AddTicks(8758), new DateTime(2023, 11, 21, 20, 41, 52, 467, DateTimeKind.Local).AddTicks(8757), "", 77, "Villa Real2", 7, 500.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
