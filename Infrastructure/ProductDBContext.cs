using Domain;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure;

public class ProductDBContext : DbContext
{
    public ProductDBContext(DbContextOptions<ProductDBContext> opts) : base(opts)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<BoxType>()
            .HasMany(b => b.Boxes);
        modelBuilder.Entity<BoxType>()
            .Property(t => t.Id)
            .ValueGeneratedOnAdd();
        
    }

    public DbSet<Box> BoxTable { get; set; }
    public DbSet<BoxType> BoxTypeTable { get; set; }

}