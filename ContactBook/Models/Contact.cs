namespace ContactBook.Models;

public class Contact
{
    public long ContactId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public Address Address { get; set; }
    public string EmailAddress { get; set; }
    public string PhoneNumber { get; set; }
    public ContactFrequency ContactFrequency { get; set; }
}