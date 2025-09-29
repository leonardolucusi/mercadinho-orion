using AutoMapper;
using Catalog.Api.Application.Dtos.Command;
using Catalog.API.Domain.Entities;

namespace Catalog.Api.Application.AutoMapper;

public class CatalogProfile : Profile
{
    public CatalogProfile()
    {
        CreateMap<ItemRegisterDto, Item>();
        CreateMap<Item, ItemRegisteredDto>();
    }
}