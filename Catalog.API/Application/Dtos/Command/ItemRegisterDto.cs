using BuildingBlocks.ResponseUtility;
using FluentValidation;

namespace Catalog.Api.Application.Dtos.Command;

public record ItemRegisterDto()
{
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public string Category { get; set; }
    public string ImageFile { get; set; }
}

public class ItemValidator : AbstractValidator<ItemRegisterDto>
{
    public ItemValidator()
    {
        RuleFor(x => x.Name).NotEmpty()
            .WithMessage("Name can't be empty")
            .WithErrorCode(nameof(ValidationCode.Code.Required));  
    }
}