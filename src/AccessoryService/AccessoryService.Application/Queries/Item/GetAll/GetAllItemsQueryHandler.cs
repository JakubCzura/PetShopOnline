using AccessoryService.Application.Interfaces.Repositories;
using MediatR;

namespace AccessoryService.Application.Queries.Item.GetAll;

public class GetAllItemsQueryHandler(IItemRepository itemRepository) : IRequestHandler<GetAllItemsQuery, IEnumerable<Domain.Entities.Item>>
{
    public Task<IEnumerable<Domain.Entities.Item>> Handle(GetAllItemsQuery request, CancellationToken cancellationToken)
        => Task.FromResult(itemRepository.GetAll());
}