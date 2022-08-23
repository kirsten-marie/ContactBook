namespace ContactBook.Services;

public interface IAddressService
{
    IEnumerable<State> GetStates();
    IEnumerable<Address> GetAddresses();
    Address? GetAddressById(int id);
    Address CreateAddress(Address newAddress);
    void UpdateAddress(Address address);
    void DeleteAddressById(int id);
}