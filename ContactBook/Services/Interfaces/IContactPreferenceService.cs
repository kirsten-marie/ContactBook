namespace ContactBook.Services;

public interface IContactPreferenceService
{
    IEnumerable<Frequency> GetFrequencyChoices();
    Frequency? GetFrequencyChoiceById(int id);
    Frequency CreateFrequencyChoice(Frequency frequency);
    void UpdateFrequencyChoice(Frequency frequency);
    void DeleteFrequencyById(int id);
}