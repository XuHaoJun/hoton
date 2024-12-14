using Hoton.Identity.Api.Contacts;
using Keycloak.AuthServices.Sdk.Kiota.Admin;
using Keycloak.AuthServices.Sdk.Kiota.Admin.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Hoton.Identity.Api.Controllers;

[Route("api/realms/{realmName}/[controller]/[action]")]
public class UsersController : ControllerBase
{
    private readonly KeycloakAdminApiClient _keycloakAdminApiClient;

    public UsersController(KeycloakAdminApiClient keycloakAdminApiClient)
    {
        _keycloakAdminApiClient = keycloakAdminApiClient;
    }

    [AllowAnonymous]
    [HttpPost]
    [ActionName("")]
    public async Task<ActionResult<string>> CreateUserAsync([FromRoute] string realmName, [FromBody] CreateUserReq body)
    {
        // var authProvider = new BaseBearerTokenAuthenticationProvider()
        // var requestAdapter = new HttpClientRequestAdapter();
        // var kcClient = new KeycloakAdminApiClient(requestAdapter);
        // kcClient.Admin.Realms[realmName].Users.PostAsync();
        // new AnonymousAuthenticationProvider()
        try
        {
            var resp = await _keycloakAdminApiClient
                .Admin.Realms[realmName]
                .Users.PostAsync(
                    new UserRepresentation
                    {
                        Enabled = true,
                        Username = body.Username,
                        Email = body.Email,
                        EmailVerified = false,
                        Credentials =
                        [
                            new()
                            {
                                Type = "password",
                                Value = body.Password,
                                Temporary = false,
                            },
                        ],
                    }
                );
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
        return Ok("ok");
    }
}
