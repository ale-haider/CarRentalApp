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

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<TypesOfCar> TypesOfCars { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<UserRole> UserRoles { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
<connectionStrings>
  <add name="CarRentalEntities" 
       connectionString="metadata=res://*/...;provider=System.Data.SqlClient;provider connection string=&quot;data source=YOUR_SERVER_NAME;initial catalog=CarRentalDb;integrated security=True;MultipleActiveResultSets=True;&quot;" 
       providerName="System.Data.EntityClient" />
</connectionStrings>

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

        modelBuilder.Entity<Role>(entity =>
        {
            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.Shorname)
                .HasMaxLength(50)
                .HasColumnName("shorname");
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

        modelBuilder.Entity<User>(entity =>
        {
            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Password)
                .HasMaxLength(100)
                .HasColumnName("password");
            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .HasColumnName("username");
        });

        modelBuilder.Entity<UserRole>(entity =>
        {
            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Roleid).HasColumnName("roleid");
            entity.Property(e => e.Userid).HasColumnName("userid");

            entity.HasOne(d => d.Role).WithMany(p => p.UserRoles)
                .HasForeignKey(d => d.Roleid)
                .HasConstraintName("FK_UserRoles_Roles");

            entity.HasOne(d => d.User).WithMany(p => p.UserRoles)
                .HasForeignKey(d => d.Userid)
                .HasConstraintName("FK_UserRoles_Users");
        });

        OnModelCreatingPartial(modelBuilder);
    } 
     
    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
