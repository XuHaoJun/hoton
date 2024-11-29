using Microsoft.AspNetCore.Mvc;

namespace Hoton.Ec.Api.Controllers;

[Route("api/realms/{realmName}/[controller]/[action]")]
public class ProductsController
{
  // [HttpPost("")]
  // public async Task<ActionResult<string>> CreateProductAsync(
  //   [FromRoute] string realmName,
  //   [FromBody] string body
  // ) {
  //   return await Task.FromResult("Hello World");
  // }
}