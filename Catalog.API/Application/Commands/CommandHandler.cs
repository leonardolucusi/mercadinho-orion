using BuildingBlocks.ResponseUtility;
using Catalog.Api.Application.Dtos.Command;
using Catalog.API.Domain.Entities;
using Catalog.Api.Infrastructure.Repositories.Interfaces;
using Catalog.Api.Infrastructure.UOW;
using FluentValidation;

namespace Catalog.Api.Application.Commands;

public class CommandHandler(
    IRepository<Item> repository,
    IUnitOfWork unitOfWork,
    IValidator<ItemRegisterDto> itemCadastrarValidator,
    ValidationResult validationResult) : ICommandHandler
{
    public async Task<Response> AddItem(ItemRegisterDto itemRegisterDto, CancellationToken cancellationToken = default)
    {
        validationResult.ApplyFluentValidationResult(itemCadastrarValidator.Validate(itemRegisterDto));
        if (validationResult.Validity is false)
        {
            return new Response()
            {
                ValidationResult = validationResult
            };       
        }
        
        unitOfWork.BeginTransaction(cancellationToken);
        
        //repository.
        
        unitOfWork.CommitTransaction(cancellationToken);
        
        validationResult.Add(ValidationCode.Code.Ok, ValidationUtils.ValidOperation_Ok(), true);
        return new Response()
        {
            Content = itemRegisterDto, // TODO: add auto or custom mapper
            ValidationResult = validationResult
        };
    }
}