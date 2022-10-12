namespace Domain;

public class Box
{
    public int Id { get; set; }
    public int Name { get; set; }
    public string Description { get; set; }
    
    public int Length { get; set; }
    public int Width { get; set; }

    public int Height
    {
        get;
        set;
    }

    
}