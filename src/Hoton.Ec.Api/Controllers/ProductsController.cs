using Hoton.Domain.Entities.generated;
using Hoton.Domain.Managers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Hoton.Ec.Api.Controllers;

[Route("api/realms/{realmId}/[controller]/[action]")]
public class ProductsController
{
    private readonly ProductManager _productManager;

    public ProductsController(ProductManager productManager)
    {
        _productManager = productManager;
    }

    [AllowAnonymous]
    [HttpPost]
    public async Task<ActionResult<string>> GetSearchFiltersAsync([FromRoute] string realmId, [FromBody] string body)
    {
        var foo = await _productManager.ProcessDynamicQuery(body);
        return await Task.FromResult("Hello World");
    }
}
