namespace StoreApp.Domain.Store;

public class Category : Entity
{
	public required string Name { get; set; }
	public string? Description { get; set; }
	public string? Image { get; set; }
	public List<Product> Products { get; set; }
	public List<Brand> Brands { get; set; }
	public DateTime CreatedAt { get; set; } = DateTime.Now;
}