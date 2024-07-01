using MediatR;
using AccessoryService.Domain.Entities;

namespace AccessoryService.Application.Queries.Items.GetItemById;

/// <summary>
/// Request to get an item by its Id.
/// </summary>
/// <param name="Id">Item's Id.</param>
public record GetItemByIdQuery(int Id) : IRequest<Item?>;
