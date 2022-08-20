using ContactBook.Models;
using ContactBook.Services;
using Microsoft.AspNetCore.Mvc;

namespace ContactBook.Controllers;

[ApiController]
[Route("[controller]")]
public class ContactController : ControllerBase
{
    public ContactController(){ }

    [HttpGet]
    public ActionResult<List<Contact>> GetAll() => ContactService.GetAll();

    [HttpGet("{id}")]
    public ActionResult<Contact> Get(int id)
    {
        var contact = ContactService.Get(id);

        return contact is null ? NotFound() : contact;
    }

    [HttpPost]
    public IActionResult Create(Contact contact)
    {
       ContactService.Add(contact);
       return CreatedAtAction(nameof(Create), new { id = contact.Id}, contact);
    }

    [HttpPut("{id}")]
    public IActionResult Update(int id, Contact contact) 
    {
        if (id != contact.Id) return BadRequest();

        var existingContact = ContactService.Get(id);

        if (existingContact is null)
            return NotFound();

        ContactService.Update(contact);

        return NoContent();
    }


    [HttpDelete("{id}")]
    public IActionResult Delete(int id) 
    {
        var existingContact = ContactService.Get(id);

        if (existingContact is null)
            return NotFound();

        ContactService.Delete(id);

        return NoContent();
    }
}
