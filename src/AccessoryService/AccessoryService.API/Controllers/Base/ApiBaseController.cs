using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AccessoryService.API.Controllers.Base;

/// <summary>
/// Base controller for API controllers.
/// </summary>
[ApiController]
[Authorize]
[Route("api/v{version:apiVersion}/[controller]")]
public class ApiBaseController : ControllerBase
{
}