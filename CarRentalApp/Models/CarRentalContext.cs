using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CarRentalApp.Models;

public partial class CarRentalContext : DbContext
{
    public CarRentalContext()
    {
    }

    public CarRentalContext(DbContextOptions<CarRentalContext> options)
        : base(options)
    {
    }

    public virtual DbSet<CarRentalRecord> CarRentalRecords { get; set; }

    public virtual DbSet<TypesOfCar> TypesOfCars { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-NNMSVH6\\SQLEXPRESS;Database=CarRental;Integrated Security=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CarRentalRecord>(entity =>
        {
            entity.ToTable("CarRentalRecord");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Cost).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.CustomerName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DateRented).HasColumnType("datetime");
            entity.Property(e => e.DateReturned).HasColumnType("datetime");

            entity.HasOne(d => d.TypeOfCarNavigation).WithMany(p => p.CarRentalRecords)
                .HasForeignKey(d => d.TypeOfCar)
                .HasConstraintName("FK_CarRentalRecord_TypesOfCars");
        });

        modelBuilder.Entity<TypesOfCar>(entity =>
        {
            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.LicensePlateNumber).HasMaxLength(50);
            entity.Property(e => e.Make).HasMaxLength(50);
            entity.Property(e => e.Model).HasMaxLength(50);
            entity.Property(e => e.Vin)
                .HasMaxLength(50)
                .HasColumnName("VIN");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
