using Microsoft.EntityFrameworkCore;
using Models;

namespace mUsic.Database;

public class MusicDbContext : DbContext
{
    public MusicDbContext()
    {
        
    }

    public MusicDbContext(DbContextOptions<MusicDbContext> options) : base(options)
    {
        
    }

    public DbSet<Collection> Collections { get; set; } = null!;
    public DbSet<Song> Songs { get; set; } = null!;
    public DbSet<Author> Authors { get; set; } = null!;
    public DbSet<Album> Albums { get; set; } = null!;
    public DbSet<Category> Categories { get; set; } = null!;
    public DbSet<SubCategory> SubCategories { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseNpgsql(
                "User ID=postgres;Password=postgres;Host=localhost;Port=5432;Database=musicservice;");
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Author>().HasAlternateKey(a => a.Name);
        modelBuilder.Entity<Category>().HasAlternateKey(c => c.Name);

    }
}