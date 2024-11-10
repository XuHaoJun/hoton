using System.IdentityModel.Tokens.Jwt;
using Hoton.Keycloak.Dto;
using Keycloak.AuthServices.Authentication;
using Keycloak.AuthServices.Authorization;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;

namespace Hoton.Keycloak;

// https://github.com/NikiforovAll/keycloak-authorization-services-dotnet/discussions/123#discussioncomment-9881517
public static class KeycloakAuthExtension
{
    // TODO
    // fix it! OnMessageReceived no error and claims is validated: true, and OnAuthenticationFailed no error, why still response 401
    public static IServiceCollection AddKeyCloakAuth(this IServiceCollection services)
    {
        var httpClient = new HttpClient();
        var tokenHandler = new JwtSecurityTokenHandler();

        services
            .AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
            .AddJwtBearer(
                // options =>
                // {
                //     options.Resource = "security-admin-console";
                //     options.AuthServerUrl = "http://localhost:8080/";
                //     options.VerifyTokenAudience = false;
                // },
                options =>
            {
                options.RequireHttpsMetadata = false;
                options.Events = new JwtBearerEvents
                {
                    OnMessageReceived = async context =>
                    {
                        try
                        {
                            var tokenJwt = context.Request.Headers.Authorization.FirstOrDefault();

                            if (string.IsNullOrEmpty(tokenJwt))
                            {
                                context.HttpContext.Items["AuthError"] = "Invalid JWT token provided! Please check. ";
                                context.HttpContext.Items["AuthStatusCode"] = 401;
                                return;
                            }

                            var bearerToken = tokenJwt.Replace("Bearer ", "");
                            var tokenInfos = tokenHandler.ReadJwtToken(tokenJwt.Replace("Bearer ", ""));
                            // var tenantNumber = tokenInfos.Claims.FirstOrDefault(c => c.Type == "tenant")?.Value;
                            // var tenantRealm = authSettings.Realms.FirstOrDefault(realm =>
                            //     realm.Name == tenantNumber
                            // );
                            var tenantRealm = new TenantRealm
                            {
                                Issuer = tokenInfos.Claims.FirstOrDefault(c => c.Type == "iss")?.Value ?? "",
                            };
                            if (tenantRealm is null)
                            {
                                context.HttpContext.Items["AuthError"] =
                                    "This token don't belongs to valid tenant. Please check!";
                                context.HttpContext.Items["AuthStatusCode"] = 401;
                                context.NoResult();
                                return;
                            }

                            // var audience = tokenInfos.Claims.FirstOrDefault(c => c.Type == "aud")?.Value;
                            // if (string.IsNullOrEmpty(audience))
                            // {
                            //     context.HttpContext.Items["AuthError"] =
                            //         "Invalid scope provided! Please, check the scopes provided!";
                            //     context.HttpContext.Items["AuthStatusCode"] = 403;
                            //     context.NoResult();
                            //     return;
                            // }

                            var jwksUrl = $"{tenantRealm.Issuer}/protocol/openid-connect/certs";

                            var jwks = await httpClient.GetStringAsync(jwksUrl);
                            var jsonWebKeySet = new JsonWebKeySet(jwks);

                            var tokenValidationParameters = new TokenValidationParameters
                            {
                                ValidateIssuer = true,
                                ValidIssuer = tenantRealm.Issuer,
                                ValidateAudience = false,
                                ValidateLifetime = true,
                                ValidateIssuerSigningKey = true,
                                IssuerSigningKeys = jsonWebKeySet.Keys,
                            };

                            var claims = tokenHandler.ValidateToken(
                                bearerToken,
                                tokenValidationParameters,
                                out var validatedToken
                            );
                            context.Principal = claims;
                            context.Success();
                        }
                        catch (Exception e)
                        {
                            context.Response.StatusCode = 500;
                            context.Fail("The following error occurs during the authentication process: " + e.Message);
                        }
                    },
                    OnAuthenticationFailed = async context =>
                    {
                        var errorDescription = context.Exception.Message;
                        context.Response.StatusCode = 401;
                        context.Response.ContentType = "application/json";
                        await context.Response.WriteAsJsonAsync(errorDescription);
                    },
                    OnChallenge = async context =>
                    {
                        if (!context.Response.HasStarted)
                        {
                            var errorMessage =
                                context.HttpContext.Items["AuthError"] as string ?? "Authentication failed!";
                            var statusCode = context.HttpContext.Items["AuthStatusCode"] as int? ?? 401;
                            var responseMessage = new { Message = errorMessage };
                            context.Response.StatusCode = statusCode;
                            context.Response.ContentType = "application/json";
                            await context.Response.WriteAsJsonAsync(responseMessage);
                        }
                        context.HandleResponse();
                    }
                };
            });

        return services;
    }
}

public class TenantRealm
{
    public string Issuer { get; set; }
}
