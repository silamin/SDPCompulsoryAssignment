namespace Domain;

public class Box
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; } = null!;
    
    public int Length { get; set; }
    public int Width { get; set; }
    
    public BoxType? BoxType { get; set; }
    public int BoxTypeId { get; set; }

    public int Height
    {
        get;
        set;
    }



}

public class BoxType
{
    public int Id { get; set; }
    public string? Description { get; set; }

    
    
}