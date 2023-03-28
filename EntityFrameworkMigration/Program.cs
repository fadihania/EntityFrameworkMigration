using EntityFrameworkMigration;
using EntityFrameworkMigration.Entities;

var db = new CarsDbContext();

// Insert
db.Cars.Add(new Car
{
    Maker = "VW",
    Model = "Polo",
    ProductionYear = 2022
});
await db.SaveChangesAsync();


// Query
var allCars = db.Cars.ToList();
foreach (var car in allCars)
{
    Console.WriteLine(car);
}