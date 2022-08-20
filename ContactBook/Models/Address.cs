namespace ContactBook.Models;

public class Address
{
    public long AddressId { get; set; }

    [Required]
    [MaxLength(100)]
    public string? Street { get; set; }

    [Required]
    [MaxLength(50)]
    public string? City { get; set; }

    [Required]
    public string? State { get; set; }

    [Required]
    public string? ZipCode { get; set; }
}