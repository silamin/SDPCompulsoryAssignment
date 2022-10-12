using Microsoft.EntityFrameworkCore;

namespace Infrastructure;

public class BoxRepository
{
    private BoxDbContext _boxDbContext;

    public BoxRepository(BoxDbContext boxDbContext)
    {
        _boxDbContext = boxDbContext;
    }
}