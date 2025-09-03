using Microsoft.EntityFrameworkCore;
using MySVFarmAssistantAPI.Infrastructure.Models;

namespace MySVFarmAssistantAPI.Infrastructure.Persistence;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<WeatherForecastItemModel> WeatherForecastItems { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<WeatherForecastItemModel>(entity =>
        {
            entity.HasKey(e => e.Id);
        });
    }
}