
using Microsoft.EntityFrameworkCore;

namespace HelloConsoleEF
{
  public class ProbaContext : DbContext
  {
    public DbSet<Skola> Skola { get; set; }

    public DbSet<Grad> Grad { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseSqlServer("Data Source=localhost;database=skole;User Id=sa;Password=MsSql@123;TrustServerCertificate=True;Encrypt=False;Connect Timeout=30");
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
        entity.HasOne(d => d.Grad)
          .WithMany(p => p.Skole);
      });
    }
  }
}
