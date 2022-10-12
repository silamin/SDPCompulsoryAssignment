using Application.Interfaces;
using Domain;

namespace Infrastructure;

public class ProductRepository: IProductRepository
{
    private readonly ProductDBContext _productDbContext;
    public ProductRepository(ProductDBContext productDbContext)
    {
        _productDbContext = productDbContext;
    }
    public List<Box> getAllBoxes()
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
        //to be implemented
        return null;
    }
}
