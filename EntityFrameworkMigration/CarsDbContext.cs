using EntityFrameworkMigration.Entities;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkMigration;

public class CarsDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=cars.db");
    }

    public DbSet<Car> Cars { get; set; }
}

// Apply migration:
// 1) Install EF tools:
//      dotnet tool install --global dotnet-ef
// 2) Create new Migration:
//      dotnet ef migrations add CarsTable
// 3) Update migration to DB:
//      dotnet ef database update