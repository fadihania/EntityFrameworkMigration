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

//db.Cars.AddRange(new Car[]
//{
//    new Car { Maker = "Fiat", Model = "Punto", ProductionYear = 2021 },
//    new Car { Maker = "KIA", Model = "Sorento", ProductionYear = 2018 },
//    new Car { Maker = "Mercedes", Model = "S-Class", ProductionYear = 2023 },
//});
//await db.SaveChangesAsync();


// Update
//var carToUpdate = db.Cars.FirstOrDefault(c => c.Id == 3);
//carToUpdate.ProductionYear = 2017;
//await db.SaveChangesAsync();


// Delete
//var carToDelete = db.Cars.FirstOrDefault(c => c.Id == 3);
//db.Cars.Remove(carToDelete);
//await db.SaveChangesAsync();


// Query
//var allCars = db.Cars.ToList();
var carsAfter2020 = db.Cars
    .Where(c => c.ProductionYear > 2020)
    .ToList();
foreach (var car in carsAfter2020)
{
    Console.WriteLine(car);
}