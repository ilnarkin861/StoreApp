using StoreApp.Domain.Identity;

namespace StoreApp.Domain.Store;

public class Review : Entity
{
	public required string Text { get; set; }
	public int Rating { get; set; }
	public required ApplicationUser User { get; set; }
	public required Product Product { get; set; }
	
}