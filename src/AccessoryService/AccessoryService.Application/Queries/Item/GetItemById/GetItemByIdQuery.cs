using MediatR;

namespace AccessoryService.Application.Queries.Item.GetItemById;

public record GetItemByIdQuery(int Id) : IRequest<Domain.Entities.Item?>;
