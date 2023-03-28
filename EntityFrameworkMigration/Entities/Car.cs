namespace EntityFrameworkMigration.Entities;

public record Car
{
    public int Id { get; set; }
    public string Maker { get; set; }
    public string Model { get; set; }
    public int ProductionYear { get; set; }
}
