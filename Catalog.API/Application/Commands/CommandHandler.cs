using BuildingBlocks.ResponseUtility;
using Catalog.Api.Application.Dtos.Command;
using Catalog.Api.Application.Dtos.Common;
using Catalog.API.Domain.Entities;
using Catalog.Api.Infrastructure.Repositories.Interfaces;
using Catalog.Api.Infrastructure.UOW;
using FluentValidation;

namespace Catalog.Api.Application.Commands;

public class CommandHandler(
    IRepository<Item> repository,
    IUnitOfWork unitOfWork,
    IValidator<ItemCadastrarDto> itemCadastrarValidator,
    ValidationResult validationResult) : ICommandHandler
{
    public async Task<Response> AddItem(ItemCadastrarDto itemCadastrarDto, CancellationToken cancellationToken = default)
    {
        validationResult.ApplyFluentValidationResult(itemCadastrarValidator.Validate(itemCadastrarDto));
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
            Content = itemCadastrarDto, // TODO: add auto or custom mapper
            ValidationResult = validationResult
        };
    }
}