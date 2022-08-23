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

    public Frequency ContactFrequency { get; set; }

    public Address? Address { get; set; }
}
