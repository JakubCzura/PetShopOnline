using AccessoryService.Domain.Entities;
using MediatR;

namespace AccessoryService.Application.Queries.Items.GetAll;

/// <summary>
/// Query for getting all items from database.
/// </summary>
public record GetAllItemsQuery() : IRequest<IEnumerable<Item>>;