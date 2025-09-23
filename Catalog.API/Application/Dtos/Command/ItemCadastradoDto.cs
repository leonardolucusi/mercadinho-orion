namespace Catalog.Api.Application.Dtos.Command;

public record ItemCadastradoDto
{
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public string Category { get; set; }
    public string ImageFile { get; set; }
}