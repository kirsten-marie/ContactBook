namespace ContactBook.Models;

public class ContactFrequency
{
    public int ContactFrequencyId { get; set; }
    
    [Required]
    public string? Description { get; set; }
}