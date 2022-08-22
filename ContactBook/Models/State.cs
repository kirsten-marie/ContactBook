namespace ContactBook.Models;

public class State
{
    public State(string abbreviation, string name)
    {
        StateAbbreviation = abbreviation;
        Name = name;
    }

    [Key]
    [MaxLength(2)]
    public string StateAbbreviation {get; set;}

    [Required]
    public string Name {get; set;}
}