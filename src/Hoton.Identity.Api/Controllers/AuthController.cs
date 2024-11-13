using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

using Hoton.Identity.Api.Contacts;
using Hoton.HttpUtils.Extensions;

namespace Hoton.Identity.Api.Controllers;

[Route("api/realms/{realmName}/[controller]/[action]")]
public class AuthController : ControllerBase
{
    private readonly HttpClient _httpClient;

    public AuthController()
    {
        _httpClient = new HttpClient();
    }

    // TODO
    // validate realmName should not be master
    [AllowAnonymous]
    [HttpPost]
    public async Task<ActionResult<TokenResponse>> TokenAsync(
        [FromRoute] string realmName,
        [FromBody] TokenRequestModel req
    )
    {
        var kcReq = new HttpRequestMessage(
            HttpMethod.Post,
            $"http://localhost:8080/realms/{realmName}/protocol/openid-connect/token"
        )
        {
            Content = FormUrlEncodedExtensions.ToFormUrlEncoded(req, useJsonPropertyName: true)
        };
        var response = await _httpClient.SendAsync(kcReq);
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
