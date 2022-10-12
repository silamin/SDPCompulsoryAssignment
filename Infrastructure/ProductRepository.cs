using Application.Interfaces;
using Domain;

namespace Infrastructure;

public class ProductRepository: IProductRepository
{
    public List<Box> getAllBoxes()
    {
        return new List<Box>() { new Box() { Id = 1, Name = "bob", Price = 1 } };
    }

    public Box CreateNewProduct(Box box)
    {
        return box; 
    }
}
