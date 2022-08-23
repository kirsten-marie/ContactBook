namespace ContactBook.Services;

public class ContactPreferenceService : IContactPreferenceService
{
    private readonly AppDbContext _context;

    public ContactPreferenceService(AppDbContext context) => _context = context;

    public IEnumerable<Frequency> GetFrequencyChoices() => 
        _context.FrequencyChoices.AsNoTracking().ToList();

    public Frequency? GetFrequencyChoiceById(int id) => 
        _context.FrequencyChoices
                .AsNoTracking()
                .SingleOrDefault(c => c.FrequencyId == id);

    public Frequency CreateFrequencyChoice(Frequency newFrequency)
    {
        _context.FrequencyChoices.Add(newFrequency);
        _context.SaveChanges();

        return newFrequency;
    }

    public void UpdateFrequencyChoice(Frequency frequency)
    {
        var update = _context.FrequencyChoices.Find(frequency.FrequencyId);

        if (update is null) return;

        update = frequency;
        _context.SaveChanges();
    }

    public void DeleteFrequencyById(int id)
    {
        var frequency = _context.FrequencyChoices.Find(id);

        if (frequency is null) return;

        _context.FrequencyChoices.Remove(frequency);
        _context.SaveChanges();
    }
}