namespace StoreApp.Domain.Store;

public class Filter : Entity
{
	public required Category Category { get; set; }
	public required PropertyGroup PropertyGroup { get; set; }
	public List<Property> Properties { get; set; }
}