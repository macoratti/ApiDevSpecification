using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data.Context;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options)
    { }
    public DbSet<Desenvolvedor> Desenvolvedores { get; set; }
    public DbSet<Endereco> Enderecos { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Desenvolvedor>()
              .Property(x => x.Nome).HasMaxLength(80);
        modelBuilder.Entity<Desenvolvedor>()
             .Property(x => x.Email).HasMaxLength(150);
        modelBuilder.Entity<Desenvolvedor>()
             .Property(x => x.RendaEstimada).HasPrecision(10, 2);

        modelBuilder.Entity<Endereco>()
             .Property(x => x.Cidade).HasMaxLength(50);
        modelBuilder.Entity<Endereco>()
               .Property(x => x.Localidade).HasMaxLength(200);
    }
}
