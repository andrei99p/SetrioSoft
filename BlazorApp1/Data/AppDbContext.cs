using BlazorApp.Data.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace BlazorApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Factura> Facturi { get; set; }
        public DbSet<DetaliiFactura> DetaliiFactura { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Factura>()
                .HasKey(f => new { f.IdFactura, f.IdLocatie });
            modelBuilder.Entity<Factura>()
                .Property(f=>f.IdFactura)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<DetaliiFactura>()
                .HasKey(d => new { d.IdDetaliiFactura, d.IdLocatie });
            modelBuilder.Entity<DetaliiFactura>()
                .Property(d => d.IdDetaliiFactura)
                .ValueGeneratedOnAdd();
        }
    }
}
