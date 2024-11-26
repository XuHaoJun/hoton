using Microsoft.AspNetCore.Mvc;

using Hoton.Identity.Api.Contacts;

namespace Hoton.Identity.Api.Controllers;

[Route("api/hasura/[action]")]
public class HasuraController : ControllerBase
{
    public HasuraController() { }

    [HttpGet]
    public ActionResult<HasuraValidateResponse> ValidateRequest()
    {
        if (User?.Identity?.Name == null)
        {
            return BadRequest();
        }
        else
        {
            // TODO
            // get roles from keycloak
            //   "realm_access": {
            //     "roles": [
            //       "offline_access",
            //       "default-roles-hoton",
            //       "uma_authorization"
            //     ]
            //   },
            //   "resource_access": {
            //     "account": {
            //       "roles": [
            //         "manage-account",
            //         "manage-account-links",
            //         "view-profile"
            //       ]
            //     }
            //   },
            var resp = new HasuraValidateResponse()
            {
                UserId = User.Identity.Name,
                DefaultRole = "user",
                AllowedRoles = ["user"]
            };
            return Ok(resp);
        }
    }
}
