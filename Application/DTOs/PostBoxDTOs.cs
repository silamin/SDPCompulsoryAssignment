namespace Application.DTOs;

public class PostBoxDTO
{
    public int Name { get; set; }
    public string Description { get; set; } = null!;
    
    public int Length { get; set; }
    public int Width { get; set; }
    
    public String BoxType { get; set; } = null!;
}