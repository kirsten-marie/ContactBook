namespace ContactBook.Services;

public class ContactService: IContactService
{
    private readonly ContactBookContext _context;

    public ContactService(ContactBookContext context) => _context = context;

    public IEnumerable<Contact> GetAllContacts() => _context.Contacts
                .Include(c => c.Address)
                .Include(c => c.ContactFrequency)
                .AsNoTracking()
                .ToList();

    public Contact? GetContactById(int id) => _context.Contacts
                .Include(c => c.Address)
                .Include(c => c.ContactFrequency)
                .AsNoTracking()
                .SingleOrDefault(c => c.ContactId == id);

    public Contact CreateContact(Contact newContact)
    {
        _context.Contacts.Add(newContact);
        _context.SaveChanges();

        return newContact;
    }

    public void UpdateAddress(int contactId, int addressId)
    {
        var contact = _context.Contacts.Find(contactId);
        var address = _context.Addresses.Find(addressId);

        if (contact is null || address is null)
        {
            throw new InvalidOperationException("Contact or Address does not exist");   
        }

        contact.Address = address;
        _context.SaveChanges();
    }

    public void DeleteContactById(int contactId)
    {
        var contact = _context.Contacts.Find(contactId);

        if (contact is null) return;

        _context.Contacts.Remove(contact);
        _context.SaveChanges();
    }

    public void UpdateContact(Contact contact)
    {
        var contactToUpdate = _context.Contacts.Find(contact.ContactId);

        if (contactToUpdate is null) return;

        contactToUpdate = contact;
        _context.SaveChanges();
    }
}