namespace ContactBook.Data;

public class ContactBookContext : DbContext
{
    public ContactBookContext(DbContextOptions<ContactBookContext> options) : base(options)
    { }

    public DbSet<Contact> Contacts => Set<Contact>();
    public DbSet<Address> Addresses => Set<Address>();
}