using AccessoryService.Application.Interfaces.Repositories;
using MediatR;
using AccessoryService.Domain.Entities;

namespace AccessoryService.Application.Queries.Items.GetItemById;

/// <summary>
/// Handler to get an item by its Id.
/// </summary>
/// <param name="itemRepository">Repository for <see cref="Item"/></param>
public class GetItemByIdQueryHandler(IItemRepository itemRepository) 
    : IRequestHandler<GetItemByIdQuery, Item?>
{
    /// <summary>
    /// Returns item by its Id.
    /// </summary>
    /// <param name="request">Request to get an item by its Id.</param>
    /// <param name="cancellationToken">Token to cancel asynchronous operations.</param>
    /// <returns>Item if found, otherwise null.</returns>
    public Task<Item?> Handle(GetItemByIdQuery request, 
                              CancellationToken cancellationToken)
        => Task.FromResult(itemRepository.GetById(request.Id)); 
}