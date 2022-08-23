namespace ContactBook.Services;

public class AddressService : IAddressService
{
    private readonly AppDbContext _context;

    public AddressService(AppDbContext context) => _context = context;

    public IEnumerable<State> GetStates() => _context.States.AsNoTracking().ToArray();

    public IEnumerable<Address> GetAddresses() => _context.Addresses
            .Include(a => a.State)
            .AsNoTracking()
            .ToList();


    public Address? GetAddressById(int id) => _context.Addresses
            .Include(a => a.State)
            .AsNoTracking()
            .SingleOrDefault(c => c.AddressId == id);

            
    public Address CreateAddress(Address newAddress){
        _context.Addresses.Add(newAddress);
        _context.SaveChanges();

        return newAddress;
    }

    public void UpdateAddress(Address address)
    {
        var addressToUpdate = _context.Addresses.Find(address.AddressId);

        if (addressToUpdate is null) return;

        addressToUpdate = address;
        _context.SaveChanges();
    }

    public void DeleteAddressById(int id)
    {
        var address = _context.Addresses.Find(id);

        if (address is null) return;

        _context.Addresses.Remove(address);
        _context.SaveChanges();
    }
}