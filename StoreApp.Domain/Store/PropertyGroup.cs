namespace StoreApp.Domain.Store;

public class PropertyGroup : Entity
{
	public required string Name { get; set; }
	public List<Property> Properties { get; set; }
	public DateTime CreatedAt { get; set; } = DateTime.Now;
}