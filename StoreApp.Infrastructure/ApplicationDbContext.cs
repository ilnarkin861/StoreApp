using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using StoreApp.Domain.Identity;
using StoreApp.Domain.Store;

namespace StoreApp.Infrastructure;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
	: IdentityDbContext<ApplicationUser, ApplicationRole, int>(options)
{
	public DbSet<Category> Categories { get; set; }
	public DbSet<Product> Products { get; set; }
	public DbSet<ProductImage> ProductImages { get; set; }
	public DbSet<Brand> Brands { get; set; }
	public DbSet<PropertyGroup> PropertyGroups { get; set; }
	public DbSet<Property> Properties { get; set; }
	public DbSet<Filter> Filters { get; set; }
	public DbSet<Review> Reviews { get; set; }
	
	
	
	protected override void OnModelCreating(ModelBuilder builder)
	{
		base.OnModelCreating(builder);
		
		builder.Entity<ApplicationUser>().ToTable("Users");
		builder.Entity<ApplicationRole>().ToTable("Roles");
		builder.Entity<IdentityUserRole<int>>().ToTable("UserRoles");
		builder.Entity<IdentityUserClaim<int>>().ToTable("UserClaims");
		builder.Entity<IdentityRoleClaim<int>>().ToTable("RoleClaims");
		builder.Entity<IdentityUserLogin<int>>().ToTable("UserLogins");
		builder.Entity<IdentityUserToken<int>>().ToTable("UserTokens");

		builder.Entity<Category>().ToTable("Categories");
		builder.Entity<Product>().ToTable("Products");
		builder.Entity<ProductImage>().ToTable("ProductImages");
		builder.Entity<Brand>().ToTable("Brands");
		builder.Entity<PropertyGroup>().ToTable("PropertyGroups");
		builder.Entity<Property>().ToTable("Properties");
		builder.Entity<Filter>().ToTable("Filters");
		builder.Entity<Review>().ToTable("Reviews");
	}
}


