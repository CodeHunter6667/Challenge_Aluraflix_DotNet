using System;
using Aluraflix.Models;
using Microsoft.EntityFrameworkCore;

namespace Aluraflix.Context;

public class AppDbContext : DbContext
{
	public AppDbContext(DbContextOptions options) : base(options)
	{
	}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Videos>().HasOne(video => video.Categoria)
                                    .WithMany(categoria => categoria.Videos)
                                    .HasForeignKey(video => video.CategoriaId);
    }

    public DbSet<Videos> Videos { get; set; }
	public DbSet<Categorias> Categorias { get; set; }
}

