using API_Farm.Data;
using DotNetEnv;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

Env.Load();

var host = Environment.GetEnvironmentVariable("DB_HOST");
var nombreBaseDatos = Environment.GetEnvironmentVariable("DB_DATABASE_NAME");
var nombreUsuario = Environment.GetEnvironmentVariable("DB_USERNAME");
var puertoBaseDatos = Environment.GetEnvironmentVariable("DB_PORT");
var contraseñaBaseDatos = Environment.GetEnvironmentVariable("DB_PASSWORD");

var connectionString = $"server={host};port={puertoBaseDatos};database={nombreBaseDatos};uid={nombreUsuario};password={contraseñaBaseDatos}";
Console.WriteLine(connectionString);


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<ApplicationDbContext>(options =>
options.UseMySql(connectionString, ServerVersion.Parse("8.0.20-my-sql")));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
