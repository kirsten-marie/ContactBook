namespace ContactBook.Models;

public class Frequency
{
    public Frequency(string description)
    { 
        Description = description;
    }

    public int FrequencyId { get; set; }
    
    public string Description { get; set; }
}