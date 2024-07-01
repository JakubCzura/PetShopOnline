using AccessoryService.Application.Interfaces.Repositories;
using AccessoryService.Domain.Entities;
using MediatR;

namespace AccessoryService.Application.Queries.Items.GetAll;

/// <summary>
/// Handler to get all items from database.
/// </summary>
/// <param name="itemRepository">Repository for <see cref="Item"/></param>
public class GetAllItemsQueryHandler(IItemRepository itemRepository)
    : IRequestHandler<GetAllItemsQuery, IEnumerable<Item>>
{
    /// <summary>
    /// Returns all items from database.
    /// </summary>
    /// <param name="request">Request for getting all items.</param>
    /// <param name="cancellationToken">Token to cancel asynchronous operations.</param>
    /// <returns>All items from database.</returns>
    public Task<IEnumerable<Item>> Handle(GetAllItemsQuery request,
                                          CancellationToken cancellationToken)
        => Task.FromResult(itemRepository.GetAll());
}