using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Serilog;
using Serilog.Events;
using StoreApp.Domain.Identity;
using StoreApp.Infrastructure;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ApplicationDbContext>(
	options => options.UseNpgsql(builder.Configuration.GetConnectionString("Default")));

builder.Services.AddSerilog(lc => lc
	.WriteTo.Console()
	.WriteTo.File(Path.Combine(Directory.GetCurrentDirectory(), "Logs/log-.log"), 
		LogEventLevel.Error, rollingInterval: RollingInterval.Day));

builder.Services.AddControllers();

builder.Services.AddAuthentication();
        
builder.Services.AddAuthorization();

builder.Services
	.AddIdentityCore<ApplicationUser>()
	.AddRoles<ApplicationRole>()
	.AddUserManager<UserManager<ApplicationUser>>()
	.AddRoleManager<RoleManager<ApplicationRole>>()
	.AddRoleStore<RoleStore<ApplicationRole, ApplicationDbContext, int>>()
	.AddUserStore<UserStore<ApplicationUser, ApplicationRole, ApplicationDbContext, int>>()
	.AddSignInManager()
	.AddDefaultTokenProviders();


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.UseAuthentication();
app.UseAuthorization();

app.UseHttpsRedirection();
app.MapControllers();

app.Run();