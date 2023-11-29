﻿using Microsoft.EntityFrameworkCore;

namespace MagicVilla_API.Modelos.Dto
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base(options)
        {

        }

        public DbSet<Villa> Villas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Villa>().HasData(
                new Villa()
                {
                    Id=1,
                    Nombre="Villa Real",
                    Detalle="Detalle de la Villa...",
                    ImagenUrl="",
                    Ocupantes=5,
                    MetrosCuadrados=50,
                    Tarifa=200,
                    Amenidad="",
                    FechaCreacion= DateTime.Now,
                    FechaActualizacion=DateTime.Now
                },
                new Villa()
                {
                    Id = 2,
                    Nombre = "Villa Real2",
                    Detalle = "Detalle de la Villa2...",
                    ImagenUrl = "",
                    Ocupantes = 7,
                    MetrosCuadrados = 77,
                    Tarifa = 500,
                    Amenidad = "",
                    FechaCreacion = DateTime.Now,
                    FechaActualizacion = DateTime.Now
                });
        }
    }
}
