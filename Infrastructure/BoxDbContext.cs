using Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure;

public class BoxDbContext : DbContext
{
    public BoxDbContext(DbContextOptions<BoxDbContext> opts) : base(opts)
    {
    }

    /*protected override void onModelCreating(ModelBuilder modelBuilder)
    {
       to be implemented 
    }*/
    public DbSet<Box> BoxTable { get; set; }
}