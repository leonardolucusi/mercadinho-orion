using Catalog.Api.Domain.Common;

namespace Catalog.API.Domain.Entities;

public class Item : IEntity
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public string Category { get; set; }
    public string ImageFile { get; set; }
}