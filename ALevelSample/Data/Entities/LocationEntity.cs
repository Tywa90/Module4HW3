namespace ALevelSample.Data.Entities;

public class LocationEntity
{
    public int Id { get; set; }

    public int Count { get; set; }

    public int OrderId { get; set; }

    public BreedEntity? Order { get; set; }

    public int ProductId { get; set; }

    public CategoryEntity? Product { get; set; }
}