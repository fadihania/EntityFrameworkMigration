using EntityFrameworkMigration;
using EntityFrameworkMigration.Entities;

var db = new CarsDbContext();

// Insert
//db.Cars.Add(new Car
//{
//    Maker = "VW",
//    Model = "Polo",
//    ProductionYear = 2022
//});
//await db.SaveChangesAsync();

db.Cars.AddRange(new Car[]
{
    new Car { Maker = "Fiat", Model = "Punto", ProductionYear = 2021 },
    new Car { Maker = "KIA", Model = "Sorento", ProductionYear = 2018 },
    new Car { Maker = "Mercedes", Model = "S-Class", ProductionYear = 2023 },
});
await db.SaveChangesAsync();


// Query
var allCars = db.Cars.ToList();
foreach (var car in allCars)
{
    Console.WriteLine(car);
}