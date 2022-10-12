namespace Domain;

public class Box
{
    public int Id { get; set; }
    public int Name { get; set; }
    public string Description { get; set; } = null!;
    
    public int Length { get; set; }
    public int Width { get; set; }
    public BoxType BoxType { get; set; } = null!;

    public int Height
    {
        get;
        set;
    }

}

public class BoxType
{
    public int Id { get; set; }
    public string Description { get; set; } = null!;
}