namespace ContactBook.Models;

public class Frequency
{
    public Frequency(){ }

    public int FrequencyId { get; set; }
    
    [Required]
    public string? Description { get; set; }
}