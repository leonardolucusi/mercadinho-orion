using BuildingBlocks.ResponseUtility;
using Catalog.Api.Application.Dtos.Command;
using Catalog.Api.Application.Dtos.Common;
using FluentValidation;

namespace Catalog.Api.Application.Commands;

public class CommandHandler(
    IValidator<ItemCadastrarDto> itemCadastrarValidator,
    ValidationResult validationResult) : ICommandHandler
{
    public async Task<Response> AddItem(ItemCadastrarDto itemCadastrarDto, CancellationToken cancellationToken = default)
    {
        validationResult.ApplyFluentValidationResult(itemCadastrarValidator.Validate(itemCadastrarDto));
        if (validationResult.IsValid is false)
        {
            return new Response()
            {
                ValidationResult = validationResult
            };       
        }
        
        validationResult.Add(ValidationCode.Code.Ok, ValidationUtils.ValidOperation_Ok(), true);
        return new Response()
        {
            Content = itemCadastrarDto, // TODO: add auto or custom mapper
            ValidationResult = validationResult
        };
    }
}