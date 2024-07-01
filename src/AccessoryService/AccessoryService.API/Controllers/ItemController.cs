using AccessoryService.API.Controllers.Base;
using AccessoryService.API.ExtensionMethods;
using AccessoryService.Application.Queries.Items.GetAll;
using AccessoryService.Application.Queries.Items.GetItemById;
using AccessoryService.Domain.Entities;
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
    /// <summary>
    /// Returns an item by its id.
    /// </summary>
    /// <paoam name="id">Item's id.</param>
    /// <returns>Item if found, otherwise null.<returns>
    [Authorize("User")]
    [HttpGet("{id:int}")]
    [ProducesResponseType(200, Type = typeof(Item))]
    public IActionResult GetItem([FromRoute] int id) => Ok(mediator.Send(new GetItemByIdQuery(id)));

    /// <summary>
    /// Returns all items.
    /// </summary>
    /// <returns>All items.</returns>
    [Authorize("User")]
    [HttpGet("all")]
    [ProducesResponseType(200, Type = typeof(IEnumerable<Item>))]
    public IActionResult GetAllItems() => Ok(mediator.Send(new GetAllItemsQuery()));
}