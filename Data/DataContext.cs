using System.Collections.Generic;
using System.Reflection.Emit;
using Microsoft.EntityFrameworkCore;
using ExamenII.Models;
using TestWebApi.Controllers;

namespace ExamenII.Data;


public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options) { }

    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<Tareas> Tareas { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Usuario>().ToTable("usuarios");

        modelBuilder.Entity<Usuario>().Property(u => u.Id).HasColumnName("Id");
        modelBuilder.Entity<Usuario>().Property(u => u.Nombre).HasColumnName("Nombre");
        modelBuilder.Entity<Usuario>().Property(u => u.Contrasena).HasColumnName("Contrasena");
        modelBuilder.Entity<Usuario>().Property(u => u.CreatedAt).HasColumnName("Created_at");

    }

}