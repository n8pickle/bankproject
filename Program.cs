using Domain;
using Database;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Services;


var builder = WebApplication.CreateBuilder(args);

// Builder Services
var connectionString = builder.Configuration["DbConnectionString"];

builder.Services.AddControllers();

builder.Services.AddEntityFrameworkMySql()
	.AddDbContext<MyDbContext>(options => options.UseMySql(connectionString, new MySqlServerVersion(new Version(10, 4, 13))));

builder.Services.AddIdentity<ApplicationUser, IdentityRole>().AddEntityFrameworkStores<MyDbContext>().AddDefaultTokenProviders();

builder.Services.AddCors(options =>
	{
		options.AddPolicy("CorsPolicy",
			builder =>
			{
			    builder
				    .AllowAnyMethod()
				    .AllowAnyHeader()
				    .SetIsOriginAllowed(__ => true)
				    .AllowCredentials();
			});
		});

builder.Services.AddTransient<IAuthenticationService, AuthenticationService>();

builder.Services.AddMvc(options => options.EnableEndpointRouting = false);

// App builder

var app = builder.Build();

app.UseRouting();

app.UseAuthentication();

app.UseCors("CorsPolicy");

app.UseMvc();

app.Run();
