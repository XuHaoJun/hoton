using Hoton.Tokenizer.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Hoton.Ec.Admin.Api.Controllers;

[Route("api/realms/{realmName}/[controller]/[action]")]
public class ProductsController
{
    private readonly ITokenizerService _tokenizerService;

    public ProductsController(ITokenizerService tokenizerService)
    {
        _tokenizerService = tokenizerService;
    }

    [HttpPost()]
    [ActionName("")]
    public async Task<ActionResult<string>> CreateProductAsync([FromRoute] string realmName, [FromBody] string body)
    {
        return await Task.FromResult("Hello World");
    }

    [AllowAnonymous]
    [HttpGet("/tokenizer")]
    public async Task<ActionResult<List<string>>> GetTokens([FromQuery] string text)
    {
        return await Task.FromResult(_tokenizerService.TokenizeForSearch(text).ToList());
    }
}
