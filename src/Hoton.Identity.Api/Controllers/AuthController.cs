using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Hoton.Identity.Api.Controllers;

[Route("api/[controller]/[action]")]
public class AuthController : ControllerBase
{
    [AllowAnonymous]
    [HttpPost]
    public async Task<ActionResult<string>> TokenAsync([FromBody] string request)
    {
        return await Task.FromResult(Ok("todo"));
    }

    [Authorize("ec-profile")]
    [HttpGet]
    public async Task<ActionResult<string>> ProfileAsync()
    {
        return await Task.FromResult(Ok("todo"));
    }
}
