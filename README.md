# Entity Framework Core Migration

Sample application on how to use Entity Framework migrations to create and update database schema. It uses console app and SQLite for simplicity

**Check commits for steps and how to apply different concepts**

- **Database access**
  + MySQL, SQL Server, PostgreSQL, SQLite
- **ORM (Object Relational Mapping)**
  + Entity Framework Core
  + Dapper

## Migration:
- **What??**
  + Create, update and track database changes
  + No SQL required

- **How??**
  + **SQLite:**
    + Nuget packages: `Microsoft.EntityFrameworkCore.Sqlite`
    Other databases: [Other databases packages](https://learn.microsoft.com/en-us/ef/core/what-is-new/nuget-packages#database-providers)
  + **Create DbContext class**
    + Configure connection string (vary based on database)
  + **Create Model (Entity):**
    + Data class
    + Declare required fields as properties
    + Use Data Annotations (attributes) to configure
  + **Create Table:**
    + Add `DbSet` property with table name
  + **Migrations:**
    + Install EF tools *(first-time only)*: `dotnet tool install --global dotnet-ef`
    + Nuget packages: `Microsoft.EntityFrameworkCore.Design`
    + `dotnet ef migrations add`: add new migration based on updates to models
    + `dotnet ef migrations remove`: remove last migration
    + `dotnet ef database update`: update database to latest migration
    + `dotnet ef database drop`: drops database