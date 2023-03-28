using EntityFrameworkMigration;

var db = new CarsDbContext();


// Query
var allCars = db.Cars.ToList();
foreach (var car in allCars)
{
    Console.WriteLine(car);
}