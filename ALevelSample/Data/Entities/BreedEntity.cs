using System.Collections.Generic;

namespace ALevelSample.Data.Entities;

public class BreedEntity
{
    public int Id { get; set; }

    public string? BreedName { get; set; }

    public int CategoryId { get; set; }
}