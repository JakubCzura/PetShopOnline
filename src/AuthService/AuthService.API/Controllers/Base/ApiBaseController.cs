using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AuthService.API.Controllers.Base;

[ApiController]
[Authorize]
[Route("api/v{version:apiVersion}/[controller]")]
public class ApiBaseController : ControllerBase
{
}
