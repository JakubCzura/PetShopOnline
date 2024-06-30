using AccessoryService.Application.Interfaces.Repositories;
using MediatR;

namespace AccessoryService.Application.Queries.Item.GetItemById;

public class GetItemByIdQueryHandler(IItemRepository itemRepository) : IRequestHandler<GetItemByIdQuery, Domain.Entities.Item?>
{
    public Task<Domain.Entities.Item?> Handle(GetItemByIdQuery request, CancellationToken cancellationToken)
        => Task.FromResult(itemRepository.GetById(request.Id)); 
}