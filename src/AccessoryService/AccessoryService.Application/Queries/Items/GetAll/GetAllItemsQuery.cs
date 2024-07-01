using MediatR;
using AccessoryService.Domain.Entities;

namespace AccessoryService.Application.Queries.Items.GetAll;

public record GetAllItemsQuery() : IRequest<IEnumerable<Item>>;