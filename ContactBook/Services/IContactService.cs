namespace ContactBook.Services;

public interface IContactService
{
    IEnumerable<Contact> GetAll();
    Contact? Get(int id);
    Contact CreateContact(Contact contact);

    void UpdateAddress(int contactId, int addressId);

    void DeleteContact(int id);
    void Update(Contact contact);
}