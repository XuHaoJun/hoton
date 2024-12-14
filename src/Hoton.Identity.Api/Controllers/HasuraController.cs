using Hoton.Identity.Api.Contacts;
using Microsoft.AspNetCore.Mvc;

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
            var realmId = User.Claims.Where(c => c.Type == "realm_id").Select(c => c.Value).ToList().FirstOrDefault();
            var resp = new HasuraValidateResponse()
            {
                RealmId = realmId ?? "",
                UserId = User.Identity.Name,
                Role = "user",
                DefaultRole = "user",
                AllowedRoles = ["user", "guest"],
            };
            return Ok(resp);
        }
    }
}
