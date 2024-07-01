using AccessoryService.API.Controllers.Base;
using AccessoryService.API.ExtensionMethods;
using AccessoryService.Application.Queries.Items.GetAll;
using AccessoryService.Application.Queries.Items.GetItemById;
using Asp.Versioning;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AccessoryService.API.Controllers;

/// <summary>
/// Controller for item operations.
/// </summary>
[ApiVersion(ApiVersioningInfo.Version_1_0)]
public class ItemController(IMediator mediator) : ApiBaseController
{
    [Authorize("User")]
    [HttpGet("{id:int}")]
    public IActionResult GetItem([FromRoute] int id) => Ok(mediator.Send(new GetItemByIdQuery(id)));

    [Authorize("User")]
    [HttpGet("all")]
    public IActionResult GetAllItems() => Ok(mediator.Send(new GetAllItemsQuery()));
}