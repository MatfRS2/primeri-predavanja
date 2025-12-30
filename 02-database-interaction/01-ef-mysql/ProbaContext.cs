using Microsoft.EntityFrameworkCore;
using MySql.EntityFrameworkCore.Extensions;

namespace HelloConsoleEF
{
  public class ProbaContext : DbContext
  {
    public DbSet<Skola> Skola { get; set; }

    public DbSet<Grad> Grad { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseMySQL("server=localhost;port=3306;database=skole;user=root;password=MySQL123");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      base.OnModelCreating(modelBuilder);

      modelBuilder.Entity<Grad>(entity =>
      {
        entity.HasKey(e => e.Id);
        entity.Property(e => e.Naziv).IsRequired();
      });

      modelBuilder.Entity<Skola>(entity =>
      {
        entity.HasKey(e => e.Id);
        entity.Property(e => e.Naziv).IsRequired();

        entity.HasOne(s => s.Grad)
          .WithMany(g => g.Skole);
      });
    }
  }
}