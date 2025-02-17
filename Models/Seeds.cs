namespace MVCSeedsLtd.Models;

public class Seeds
{
    public int Id { get; set; }  // Add this line
    public string Category { get; set; }
    public string SeedName { get; set; }
    public string Variaty { get; set; }
    public string Properties { get; set; }
    public string Description { get; set; }
    public int No_In_Stock { get; set; }
}
