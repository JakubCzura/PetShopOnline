using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace UserService.API.Controllers.Base;

[ApiController]
[Authorize]
[Route("api/v{version:apiVersion}/[controller]")]
public class ApiBaseController : ControllerBase
{
}
