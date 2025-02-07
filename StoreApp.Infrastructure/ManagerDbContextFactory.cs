using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace StoreApp.Infrastructure;

public class ManagerDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
{
	public ApplicationDbContext CreateDbContext(string[] args)
	{
		var configuration = BuildConfiguration();
		var builder = new DbContextOptionsBuilder<ApplicationDbContext>()
			.UseNpgsql(configuration.GetConnectionString("Default"));
		return new ApplicationDbContext(builder.Options);
	}
	private static IConfigurationRoot BuildConfiguration()
	{
		var builder = new ConfigurationBuilder()
			.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../StoreApp.Api/"))
			.AddJsonFile("appsettings.json", optional: false);
		return builder.Build();
	}
}