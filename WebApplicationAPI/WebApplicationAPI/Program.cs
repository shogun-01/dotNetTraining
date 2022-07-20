using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql;
using WebApplicationAPI.Models;

var builder = WebApplication.CreateBuilder(args);
var connectionString = "server=localhost;port=3306;user=root;password=RockyouAdmin;database=Students";
var serverVersion = new MySqlServerVersion(new Version(8, 0, 27));

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddDbContext<StudentsContext>(options =>
{
    // options. (builder.Configuration.GetConnectionString("Mysql"));
    object value = options.UseMySql(connectionString, serverVersion);
});


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
