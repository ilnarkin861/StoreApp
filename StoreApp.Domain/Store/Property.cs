namespace StoreApp.Domain.Store;

public class Property : Entity
{
	public required string Value { get; set; }
	public required PropertyGroup PropertyGroup { get; set; }
	public List<Product> Products { get; set; }
	public List<Filter> Filters { get; set; }
	public DateTime CreatedAt { get; set; } = DateTime.Now;
}