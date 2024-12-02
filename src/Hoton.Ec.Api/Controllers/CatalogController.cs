
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Hoton.Ec.Api.Controllers;

[Route("api/realms/{realmId}/[controller]/[action]")]
public class CatalogController
{
    [AllowAnonymous]
    [HttpPost]
    public async Task<ActionResult<string>> GetSearchFiltersAsync([FromRoute] string realmId, [FromBody] string body)
    {
        return await Task.FromResult("Hello World");
    }
}
