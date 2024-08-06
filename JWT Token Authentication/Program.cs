using JWT_Token_Authentication.Data;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);


ConfigurationManager configuration=builder.Configuration;
builder.Services.AddDbContext<ApplicationDbContext>(options=>

    options.UseSqlServer(configuration.GetConnectionString("ConnStr"))
);
// Add services to the container.

builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

app.Run();
