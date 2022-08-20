using ContactBook.Models;
using ContactBook.Services;
using Microsoft.AspNetCore.Mvc;

namespace ContactBook.Controllers;

[ApiController]
[Route("[controller]")]
public class ContactController : ControllerBase
{
    private readonly IContactService _contactService;

    public ContactController(IContactService contactService)
    {
        _contactService = contactService;
    }

    [HttpGet]
    public ActionResult<List<Contact>> GetAll() => _contactService.GetAll().ToList();

    [HttpGet("{id}")]
    public ActionResult<Contact> Get(int id)
    {
        var contact = _contactService.Get(id);

        return contact is null ? NotFound() : contact;
    }

    [HttpPost]
    public IActionResult Create(Contact contact)
    {
       _contactService.Add(contact);
       return CreatedAtAction(nameof(Create), new { id = contact.ContactId}, contact);
    }

    [HttpPut("{id}")]
    public IActionResult Update(int id, Contact contact) 
    {
        if (id != contact.ContactId) return BadRequest();

        var existingContact = _contactService.Get(id);

        if (existingContact is null)
            return NotFound();

        _contactService.Update(contact);

        return NoContent();
    }


    [HttpDelete("{id}")]
    public IActionResult Delete(int id) 
    {
        var existingContact = _contactService.Get(id);

        if (existingContact is null)
            return NotFound();

        _contactService.Delete(id);

        return NoContent();
    }
}
