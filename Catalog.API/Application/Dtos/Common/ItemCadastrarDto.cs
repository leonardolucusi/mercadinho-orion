using FluentValidation;

namespace Catalog.Api.Application.Dtos.Common;

public record ItemCadastrarDto()
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public string Category { get; set; }
    public string ImageFile { get; set; }
}

public class ItemValidator : AbstractValidator<ItemCadastrarDto>
{
    public ItemValidator()
    {
        RuleFor(x => x.Name).NotEmpty()
            .WithMessage("Nome nao pode ser vazio teste")
            .WithErrorCode("REQUIRED");  
    }
}