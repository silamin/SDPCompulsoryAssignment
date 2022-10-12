using Microsoft.EntityFrameworkCore;

namespace Infrastructure;

public class ProductDBContext : DbContext
{
    public ProductDBContext(DbContextOptions<ProductDBContext> opts) : base(opts)
    {
        
    }
}