using MediatR;
using AccessoryService.Domain.Entities;

namespace AccessoryService.Application.Queries.Items.GetItemById;

public record GetItemByIdQuery(int Id) : IRequest<Item?>;
