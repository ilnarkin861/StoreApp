namespace StoreApp.Domain.Store;

public class Product : Entity
{
	public required string Name { get; set; }
	public string? BriefDescription { get; set; }
	public string? Description { get; set; }
	public string? MainImage { get; set; }
	public double Price { get; set; }
	public required Category Category { get; set; }
	public required Brand Brand { get; set; }
	public List<Property> Properties { get; set; }
	public List<ProductImage> ProductImages { get; set; }
	public DateTime CreatedAt { get; set; } = DateTime.Now;
}