namespace ContactBook.Models;

public class Contact
{
    public long ContactId { get; set; }

    [Required]
    [MaxLength(20)]
    public string? FirstName { get; set; }

    [Required]
    [MaxLength(20)]
    public string? LastName { get; set; }

    [Required]
    public string? EmailAddress { get; set; }

    public string? PhoneNumber { get; set; }
    
    [Required]
    public ContactFrequency? ContactFrequency { get; set; }

    [Required]
    public Address? Address { get; set; }
}