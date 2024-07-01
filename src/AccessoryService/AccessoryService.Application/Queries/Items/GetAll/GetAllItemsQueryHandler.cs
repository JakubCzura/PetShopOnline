using AccessoryService.Application.Interfaces.Repositories;
using MediatR;
using AccessoryService.Domain.Entities;

namespace AccessoryService.Application.Queries.Items.GetAll;

public class GetAllItemsQueryHandler(IItemRepository itemRepository) : IRequestHandler<GetAllItemsQuery, IEnumerable<Item>>
{
    public Task<IEnumerable<Item>> Handle(GetAllItemsQuery request, CancellationToken cancellationToken)
        => Task.FromResult(itemRepository.GetAll());
}