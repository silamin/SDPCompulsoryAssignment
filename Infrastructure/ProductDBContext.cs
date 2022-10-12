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
        modelBuilder.Entity<Box>()
            .Property(p => p.Id)
            .ValueGeneratedOnAdd();
        modelBuilder.Entity<BoxType>()
            .Property(t => t.Id)
            .ValueGeneratedOnAdd();

        modelBuilder.Entity<Box>()
            .HasOne(box => box.BoxType);
    }

    public DbSet<Box> BoxTable { get; set; }
    public DbSet<Box> BoxTypeTable { get; set; }

}