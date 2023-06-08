using System.Collections.Generic;

namespace ALevelSample.Data.Entities;

public class CategoryEntity
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public double Price { get; set; }

    public List<LocationEntity> OrderItems { get; set; } = new List<LocationEntity>();
}