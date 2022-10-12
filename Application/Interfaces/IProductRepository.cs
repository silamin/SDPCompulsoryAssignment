using Domain;

namespace Application.Interfaces;

public interface IProductRepository
{
    public List<Box> GetAllBoxes();
    public Box DeleteProduct(Box box);
    public Box EditProduct(Box box);
    public Box CreateNewProduct(Box box);
    public void CreateDb();
    BoxType CreateBoxType(BoxType boxType);
}