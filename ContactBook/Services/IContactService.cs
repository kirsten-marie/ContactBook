using ContactBook.Models;
namespace ContactBook.Services;

public interface IContactService
{
    IEnumerable<Contact> GetAll();
    Contact? Get(int id);
    void Add(Contact contact);
    void Delete(int id);
    void Update(Contact contact);
}