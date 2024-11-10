using System.IdentityModel.Tokens.Jwt;

namespace Hoton.Identity.Api.Services;

public class AuthService(IHttpContextAccessor httpContextAccessor, JwtSecurityTokenHandler jwtSecurityTokenHandler)
{
    private readonly IHttpContextAccessor _httpContextAccessor = httpContextAccessor;
    private readonly JwtSecurityTokenHandler _tokenHandler = jwtSecurityTokenHandler;

    // TODO
    // parse realm from iss?
    public int GetRealm()
    {
        throw new NotImplementedException();
        // string jwtToken = GetToken();
        // var tokenInfos = _tokenHandler.ReadJwtToken(jwtToken);
        // var tenantClaim = tokenInfos.Claims.FirstOrDefault(c => c.Type == "tenant")?.Value!;
        // return int.Parse(tenantClaim);
    }

    public Guid GetUser()
    {
        string jwtToken = GetToken();
        var tokenInfos = _tokenHandler.ReadJwtToken(jwtToken);
        var userClaim = tokenInfos.Claims.FirstOrDefault(c => c.Type == "sub")?.Value!;
        return Guid.Parse(userClaim);
    }

    private string GetToken()
    {
        var authorizationHeader = _httpContextAccessor.HttpContext!.Request.Headers.Authorization.FirstOrDefault();
        return authorizationHeader!.Replace("Bearer ", string.Empty);
    }
}
