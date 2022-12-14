namespace ContactBook.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
    { }

    public DbSet<Contact> Contacts => Set<Contact>();
    public DbSet<Address> Addresses => Set<Address>();
    public DbSet<Frequency> FrequencyChoices => Set<Frequency>();
    public DbSet<State> States => Set<State>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<State>().HasKey(key => key.Abbreviation);
    }
}