using Microsoft.AspNetCore.DataProtection;
using Microsoft.EntityFrameworkCore;
using TestAPI.Models;
using TestAPI.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Cross Origin Resource Sharing
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: "AllowAll",
        policy =>
        {
            policy.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
        });
});

builder.Services.AddSingleton<DbService, DbService>();

builder.Services.AddControllers();
builder.Services.AddDbContext<ItemDbContext>();
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

app.UseCors("AllowAll");
app.UseAuthorization();

app.MapControllers();

app.Run();