using Application.Interfaces;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure;

public class ProductRepository: IProductRepository
{
    private readonly ProductDBContext _productDbContext;
    public ProductRepository(ProductDBContext productDbContext)
    {
        _productDbContext = productDbContext;
    }
    public List<Box> GetAllBoxes()
    {
        return _productDbContext.BoxTable.ToList();
    }

    public Box CreateNewProduct(Box box)
    {
        _productDbContext.BoxTable.Add(box);
        _productDbContext.SaveChanges();
        return box; 
    }
    public Box DeleteProduct(Box box)
    {
        _productDbContext.BoxTable.Remove(box);
        _productDbContext.SaveChanges();
        return box; 
    }
    public Box EditProduct(Box box)
    {
        _productDbContext.BoxTable.Update(box);
        _productDbContext.SaveChanges();
        return box;
    }

    public void CreateDb()
    {
        _productDbContext.Database.EnsureDeleted();
        _productDbContext.Database.EnsureCreated();

    }

    public BoxType CreateBoxType(BoxType boxType)
    {
        _productDbContext.BoxTypeTable.Add(boxType);
        _productDbContext.SaveChanges();
        return boxType;

    }

    public List<BoxType> GetAllBoxTypes()
    {
        return _productDbContext.BoxTypeTable.ToList();
    }
}
