using MediatR;

namespace AccessoryService.Application.Queries.Item.GetAll;

public record GetAllItemsQuery() : IRequest<IEnumerable<Domain.Entities.Item>>;