using Domain;

namespace Application.Interfaces;

public interface IProductRepository
{
    public List<Box> getAllBoxes();
    public Box CreateNewProduct(Box box);
}