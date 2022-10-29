namespace Domain;

public class Box
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; } = null!;
    
    public int Length { get; set; }
    public int Width { get; set; }
    
    public int Weight { get; set; }
    
    public int Height
    {
        get;
        set;
    }

    public string BoxImage { get; set; } = null!;
    public string CreationDate { get; set; }
}

public class BoxType
{
    public int Id { get; set; }
    public string? Description { get; set; }
    public ICollection<Box> Boxes { get; set; } = null!;
}