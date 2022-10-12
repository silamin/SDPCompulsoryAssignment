using Application.DTOs;

namespace Domain.Interfaces;

public interface IProductService
{
    public List<Box> GetAllBoxes();

    public Box CreateNewBox(PostBoxDTO dto);
    void CreateDb();
    BoxType CreateNewBoxType(BoxType boxType);
    List<BoxType> GetAllBoxTypes();
}