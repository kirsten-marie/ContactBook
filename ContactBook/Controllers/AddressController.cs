namespace ContactBook.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AddressController : ControllerBase
{
    private readonly IAddressService _addressService;

    public AddressController(IAddressService addressService) => _addressService = addressService;

    [HttpGet]
    [ActionName("GetAllAddresses")]
    public ActionResult<List<Address>> GetAllAddresses() =>
        _addressService.GetAddresses().ToList();

    [HttpGet("states")]
    [ActionName("GetAllStates")]
    public ActionResult<List<State>> GetAllStates() =>
        _addressService.GetStates().ToList();

    [HttpPost]
    public IActionResult Create(Address address)
    {
        _addressService.CreateAddress(address);
        return CreatedAtAction(nameof(Create), new { id = address.AddressId }, address);
    }
}