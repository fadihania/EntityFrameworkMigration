using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkMigration;

public class CarsDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=cars.db");
    }
}
