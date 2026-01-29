using Microsoft.EntityFrameworkCore;
using server.Models;

var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;
var config = builder.Configuration;

services.AddEndpointsApiExplorer();
services.AddSwaggerGen();

services.AddDbContext<AntDbContext>(options => options.UseNpgsql(config.GetConnectionString("AntDbConnection")));

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    //121981http://localhost:5006/swagger/index.html
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapGet("/", () => "Hello World!");

app.Run();
