using Hoton.HttpUtils.Extensions;
using Hoton.Identity.Api.Contacts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

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
            Content = FormUrlEncodedExtensions.ToFormUrlEncoded(req, useJsonPropertyName: true),
        };
        var response = await _httpClient.SendAsync(kcReq);
        if (response.StatusCode != System.Net.HttpStatusCode.OK)
        {
            var error = await response.Content.ReadAsStringAsync();
            return BadRequest(error);
        }
        var tokenResponse = await response.Content.ReadFromJsonAsync<TokenResponse>();
        return Ok(tokenResponse);
    }
}
