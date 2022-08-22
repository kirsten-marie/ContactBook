namespace ContactBook.Controllers;

[ApiController]
[Route("[controller]")]
public class ContactPreferenceController : ControllerBase
{
    private readonly IContactPreferenceService _contactOptionsService;

    public ContactPreferenceController(IContactPreferenceService contactOptionsService) => _contactOptionsService = contactOptionsService;

    [HttpGet]
    public ActionResult<List<Frequency>> GetFrequencies() => 
        _contactOptionsService.GetFrequencyChoices().ToList();

    [HttpGet("{id}")]
    public ActionResult<Frequency> Get(int id)
    {
        var frequency = _contactOptionsService.GetFrequencyChoiceById(id);

        return frequency is null ? NotFound() : frequency;
    }

    [HttpPost]
    public IActionResult Create(Frequency frequency) 
    {
        _contactOptionsService.CreateFrequencyChoice(frequency);
        return CreatedAtAction(nameof(Create), new { id = frequency.FrequencyId}, frequency);
    }
    
    [HttpPut("{id}")]
    public IActionResult Update(int id, Frequency frequency) 
    {
        if (id != frequency.FrequencyId) return BadRequest();

        var existing = _contactOptionsService.GetFrequencyChoiceById(id);

        if (existing is null)
            return NotFound();

        _contactOptionsService.UpdateFrequencyChoice(frequency);

        return NoContent();
    }


    [HttpDelete("{id}")]
    public IActionResult Delete(int id) 
    {
        var existingContact = _contactOptionsService.GetFrequencyChoiceById(id);

        if (existingContact is null)
            return NotFound();

        _contactOptionsService.DeleteFrequencyById(id);

        return NoContent();
    }
}
