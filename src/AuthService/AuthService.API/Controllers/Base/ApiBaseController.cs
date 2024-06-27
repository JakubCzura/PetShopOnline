using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AuthService.API.Controllers.Base;

[ApiController]
[Authorize]
[Route("api/[controller]")]
public class ApiBaseController : ControllerBase
{
}
