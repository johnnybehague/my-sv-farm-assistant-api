using Microsoft.EntityFrameworkCore;
using MySVFarmAssistantAPI.Application.WeatherForecast.Factories;
using MySVFarmAssistantAPI.Application.WeatherForecast.Queries.GetAllWeatherForecast;
using MySVFarmAssistantAPI.Domain.Common.Interfaces;
using MySVFarmAssistantAPI.Domain.WeatherForecast.Interfaces;
using MySVFarmAssistantAPI.Infrastructure.Persistence;
using MySVFarmAssistantAPI.Infrastructure.WeatherForecast.Repositories;
using System;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<AppDbContext>(options =>
        options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddControllers();

// Ajout de MediatR
builder.Services.AddMediatR(cfg =>
    cfg.RegisterServicesFromAssemblies(
        typeof(GetAllWeatherForecastQueryHandler).Assembly
    ));


// UnitOfWork
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

// Factories
builder.Services.AddScoped<IWeatherForecastFactory, WeatherForecastFactory>();

// Repositories
builder.Services.AddScoped<IWeatherForecastRepository, WeatherForecastRepository>();

// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
