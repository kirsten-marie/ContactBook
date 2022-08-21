namespace ContactBook.Models;

public class ContactFrequency
{
    public ContactFrequency(){ }

    public ContactFrequency(string description) => Description = description;

    public int ContactFrequencyId { get; set; }
    
    [Required]
    public string? Description { get; set; }
}