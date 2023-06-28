using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WebApplication_minmalAPI.Data;
using WebApplication_minmalAPI;
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<MinimalBlogBbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("MinimalBlogBbContext") ?? 
    throw new InvalidOperationException("Connection string 'MinimalBlogBbContext' not found.")));

// Add services to the container.
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

app.MapBlogEndpoints();


app.Run();


