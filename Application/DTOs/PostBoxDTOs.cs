using Domain;

namespace Application.DTOs;

public class PostBoxDTO
{
    public string Name { get; set; } = null!;
    public string Description { get; set; } = null!;
    
    public int Length { get; set; }
    public int Width { get; set; }

    public string BoxImage { get; set; } = null!;
    public int Height { get; set; }
}