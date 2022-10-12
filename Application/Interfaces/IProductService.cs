using Application.DTOs;

namespace Domain.Interfaces;

public interface IProductService
{
    public List<Box> GetAllBoxes();

    public Box createNewBox(PostBoxDTO dto);
}