using Domain;

namespace Application.DTOs;

public class PostBoxDTO
{
    public string Name { get; set; }
    public string Description { get; set; } = null!;
    
    public int Length { get; set; }
    public int Width { get; set; }

    public int BoxTypeId { get; set; }
}