namespace ContactBook.Controllers;

[ApiController]
[Route("[controller]")]
public class AddressController : ControllerBase
{
    private readonly IAddressService _addressService;

    public AddressController(IAddressService addressService) => _addressService = addressService;

    [HttpGet]
    public ActionResult<List<Address>> GetAllAddresses() => 
        _addressService.GetAddresses().ToList();

    [HttpGet]
    public ActionResult<List<State>> GetAllStates() => 
        _addressService.GetStates().ToList();

    [HttpPost]
    public IActionResult Create(Address address)
    {
       _addressService.CreateAddress(address);
       return CreatedAtAction(nameof(Create), new { id = address.AddressId}, address);
    }


}