using System.Collections.Generic;

namespace ALevelSample.Data.Entities;

public class BreedEntity
{
    public int Id { get; set; }

    public string? UserId { get; set; }

    public PetEntity? User { get; set; }

    public List<LocationEntity> OrderItems { get; set; } = new List<LocationEntity>();
}