using FluentValidation;
using FluentValidation.AspNetCore;
using JWT_Token_Authentication.Data;
using JWT_Token_Authentication.DataDemo;
using JWT_Token_Authentication.Model;
using JWT_Token_Authentication.Models;
using JWT_Token_Authentication.RepositoryDemo;
using JWT_Token_Authentication.Validations;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.Text;
var builder = WebApplication.CreateBuilder(args);

//Adding applicationdbcontext 
ConfigurationManager configuration=builder.Configuration;
builder.Services.AddDbContext<ApplicationDbContext>(options=>

    options.UseSqlServer(configuration.GetConnectionString("ConnStr"))
);

//Adding Identity user Service
builder.Services.AddIdentity<IdentityUser, IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>()
    .AddDefaultTokenProviders();

//Adding Authentication

builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(options =>
   {
       options.SaveToken = true;
       options.RequireHttpsMetadata = false;
	   options.TokenValidationParameters = new TokenValidationParameters()
       {
           ValidateIssuer = true,
           ValidateAudience = true,
           ValidAudience = configuration["JWT:ValidAudience"],
           ValidIssuer = configuration["JWT:ValidIssuer"],
           #pragma warning disable CS8604 // Possible null reference argument.
		   IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["JWT:Secret"]))
           #pragma warning restore CS8604 // Possible null reference argument.
	   };
   });

// Add services to the container.

builder.Services.AddFluentValidationAutoValidation();
builder.Services.AddFluentValidationClientsideAdapters();
builder.Services.AddScoped<IValidator<RegisterModel>, RegisterValidator>();
builder.Services.AddScoped<IValidator<LoginModel>, LoginValidator>();

builder.Services.AddDbContext<ProductDbContext>(options =>
{
    options.UseInMemoryDatabase("ProductDB");
});
builder.Services.AddScoped<IProduct, ProductServices>();

builder.Services.AddControllers();

var app = builder.Build();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
