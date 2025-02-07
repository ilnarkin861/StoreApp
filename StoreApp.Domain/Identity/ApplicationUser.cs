using Microsoft.AspNetCore.Identity;

namespace StoreApp.Domain.Identity;

public class ApplicationUser : IdentityUser<int>
{
	public required string FirstName { get; set; }
	public string? LastName { get; set; }
	public DateTime RegisteredAt { get; set; } = DateTime.UtcNow.AddHours(3);
}