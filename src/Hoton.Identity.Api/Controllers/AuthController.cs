using System.Text;
using Hoton.Identity.Api.Contacts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Hoton.Identity.Api.Controllers;

[Route("api/[controller]/realms/{realmName}/[action]")]
public class AuthController : ControllerBase
{
    private readonly HttpClient _httpClient;

    public AuthController()
    {
        _httpClient = new HttpClient();
    }

    [AllowAnonymous]
    [HttpPost]
    public async Task<ActionResult<TokenResponse>> TokenAsync(
        [FromBody] TokenRequestModel req,
        [FromRoute] string realmName
    )
    {
        var request = new HttpRequestMessage(
            HttpMethod.Post,
            $"http://localhost:8080/realms/{realmName}/protocol/openid-connect/token"
        )
        {
            Content = FormUrlEncodedExtensions.ToFormUrlEncoded(req, useJsonPropertyName: true)
        };

        var response = await _httpClient.SendAsync(request);
        response.EnsureSuccessStatusCode();

        var tokenResponse = await response.Content.ReadFromJsonAsync<TokenResponse>();
        return Ok(tokenResponse);
    }

    [HttpGet]
    public async Task<ActionResult<string>> ProfileAsync([FromRoute] string realmName)
    {
        return await Task.FromResult(Ok("todo"));
    }
}
