using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RegistrationAPI.Data;
using RegistrationAPI.Models;

namespace RegistrationAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class RegistrationsController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public RegistrationsController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpPost]
    public async Task<IActionResult> CreateRegistration(Registration registration)
    {
        _context.Registrations.Add(registration);
        await _context.SaveChangesAsync();

        return Ok(registration);
    }

    [HttpGet]
    public async Task<IActionResult> GetRegistrations()
    {
        var registrations = await _context.Registrations.ToListAsync();

        return Ok(registrations);
    }
    [HttpGet("{id}")]
    public async Task<IActionResult> GetRegistration(int id)
    {
        var registration = await _context.Registrations.FindAsync(id);

        if (registration == null)
        {
            return NotFound();
        }

        return Ok(registration);
    }
    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateRegistration(int id, Registration registration)
    {
        if (id != registration.Id)
        {
            return BadRequest();
        }

        var existingRegistration = await _context.Registrations.FindAsync(id);

        if (existingRegistration == null)
        {
            return NotFound();
        }

        existingRegistration.FullName = registration.FullName;
        existingRegistration.Address = registration.Address;
        existingRegistration.Gender = registration.Gender;
        existingRegistration.Cricket = registration.Cricket;
        existingRegistration.Cooking = registration.Cooking;
        existingRegistration.Swimming = registration.Swimming;
        existingRegistration.Country = registration.Country;
        existingRegistration.Email = registration.Email;

        await _context.SaveChangesAsync();

        return Ok(existingRegistration);
    }
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteRegistration(int id)
    {
        var registration = await _context.Registrations.FindAsync(id);

        if (registration == null)
        {
            return NotFound();
        }

        _context.Registrations.Remove(registration);

        await _context.SaveChangesAsync();

        return Ok("Registration deleted successfully.");
    }
}
