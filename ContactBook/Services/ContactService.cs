using ContactBook.Models;

namespace ContactBook.Services;

public static class ContactService
{
    static List<Contact> Contacts {get; set;}
    static int nextContactId = 2;
    static int nextAddressId = 2;

    static ContactService()
    {
        Contacts = new List<Contact>{
            new Contact{
                Id = 1,
                FirstName = "Kirsten",
                LastName = "McCain",
                Address =  new Address
                {
                    Id = 1,
                    Street = "1137 Gilbert Station Ln",
                    City = "Knoxville",
                    State = "TN",
                    ZipCode = "37932"
                },
                EmailAddress = "kirstenmccain@outlook.com",
                PhoneNumber = "8653877802",
                ContactFrequencyId = 1
            },
            new Contact{
                Id = 2,
                FirstName = "Minnie",
                LastName = "Mouse",
                Address = new Address
                {
                    Id = 2,
                    Street = "123 Dev Test St",
                    City = "Knoxville",
                    State = "TN",
                    ZipCode = "37932"
                },
                EmailAddress = "minniemouse@fake.com",
                PhoneNumber = "8654445555",
                ContactFrequencyId = 2
            }
        }; 
    }

    public static List<Contact> GetAll() => Contacts;

    public static Contact? Get(int id) => Contacts.FirstOrDefault(c => c.Id == id);

    public static void Add(Contact contact)
    {
        //Todo: check if the contact exists?
        contact.Id = ++nextContactId;
        contact.Address.Id = ++nextAddressId;
        Contacts.Add(contact);
    }

    public static void Delete(int id)
    {
        var contact = Get(id);

        if (contact is null) return;

        Contacts.Remove(contact);
    }

    public static void Update(Contact contact)
    {
        var index = Contacts.FindIndex(c => c.Id == contact.Id);
        if (index == -1) return;

        Contacts[index] = contact;
    }

}