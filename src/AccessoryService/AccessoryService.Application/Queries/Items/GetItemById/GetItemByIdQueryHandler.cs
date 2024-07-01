using AccessoryService.Application.Interfaces.Repositories;
using MediatR;
using AccessoryService.Domain.Entities;

namespace AccessoryService.Application.Queries.Items.GetItemById;

public class GetItemByIdQueryHandler(IItemRepository itemRepository) : IRequestHandler<GetItemByIdQuery, Item?>
{
    public Task<Item?> Handle(GetItemByIdQuery request, CancellationToken cancellationToken)
        => Task.FromResult(itemRepository.GetById(request.Id)); 
}