namespace RegistrationAPI.Models;

public class Registration
{
    public int Id { get; set; }

    public string FullName { get; set; } = string.Empty;

    public string Address { get; set; } = string.Empty;

    public string? Gender { get; set; }

    public bool Cricket { get; set; }

    public bool Cooking { get; set; }

    public bool Swimming { get; set; }

    public string Country { get; set; } = string.Empty;

    public string Email { get; set; } = string.Empty;

    public string? PhotoFileName { get; set; }

    public DateTime CreatedAt { get; set; }
}