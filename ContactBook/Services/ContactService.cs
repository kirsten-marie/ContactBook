using ContactBook.Models;

namespace ContactBook.Services;

public class ContactService: IContactService
{
    public ContactService(){ }

    public IEnumerable<Contact> GetAll()    
    {
        throw new NotImplementedException();
    }


    public Contact? Get(int id) 
    {
        throw new NotImplementedException();
        //Contacts.FirstOrDefault(c => c.ContactId == id);
    }

    public void Add(Contact contact)
    {
        throw new NotImplementedException();
        // contact.ContactId = ++nextContactId;
        // contact.Address.AddressId = ++nextAddressId;
        // Contacts.Add(contact);
    }

    public void Delete(int id)
    {
        throw new NotImplementedException();
        // var contact = Get(id);
        // if (contact is null) return;
        // Contacts.Remove(contact);
    }

    public void Update(Contact contact)
    {
        throw new NotImplementedException();
        // var index = Contacts.FindIndex(c => c.ContactId == contact.ContactId);
        // if (index == -1) return;
        // Contacts[index] = contact;
    }
}