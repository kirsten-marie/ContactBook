namespace ContactBook.Services;

public interface IContactService
{
    IEnumerable<Contact> GetAllContacts();
    Contact? GetContactById(int id);
    Contact CreateContact(Contact contact);
    void SetNewAddress(int contactId, Address address);
    void UpdateAddress(int contactId, int addressId);
    void DeleteContactById(int id);
    void UpdateContact(Contact contact);
}