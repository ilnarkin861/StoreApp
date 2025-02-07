namespace StoreApp.Domain.Store;

public class Brand : Entity
{
	public required string Name { get; set; }
	public List<Product> Products { get; set; }
	public List<Category> Categories { get; set; }
	public string? Logo { get; set; }
	public DateTime CreatedAt { get; set; } = DateTime.Now;
}