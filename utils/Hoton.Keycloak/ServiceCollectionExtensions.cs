using System.IdentityModel.Tokens.Jwt;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using Keycloak.AuthServices.Sdk.Kiota;
using Microsoft.AspNetCore.Authorization;

namespace Hoton.Keycloak;

// https://github.com/NikiforovAll/keycloak-authorization-services-dotnet/discussions/123#discussioncomment-9881517
public static class KeycloakAuthExtension
{
    public static IServiceCollection AddKeyCloakAuth(this IServiceCollection services)
    {
        services
            .AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
            .AddJwtBearer(options =>
            {
                options.IncludeErrorDetails = true; // 預設值為 true，有時會特別關閉
                options.RequireHttpsMetadata = false;
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    NameClaimType = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier",
                    ValidateIssuer = false,
                    ValidateAudience = false,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = false,
                    ClockSkew = TimeSpan.Zero
                };
                options.Events = new JwtBearerEvents
                {
                    OnMessageReceived = async context =>
                    {
                        var httpClient = new HttpClient();
                        var tokenHandler = new JwtSecurityTokenHandler();
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
                                NameClaimType = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier",
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

    public static IServiceCollection AddKeyCloakAdminClient(this IServiceCollection services)
    {
        var tokenClientName = "keycloak_admin_api_token";
        services
            .AddClientCredentialsTokenManagement()
            .AddClient(
                tokenClientName,
                client =>
                {
                    client.ClientId = "admin-api";
                    client.ClientSecret = "uK1W33VTfYYNNVSEv02g12hAMJaHeY6y";
                    client.TokenEndpoint = "http://localhost:8080/realms/master/protocol/openid-connect/token";
                }
            );
        var keycloakOptions = new KeycloakAdminClientOptions
        {
            AuthServerUrl = "http://localhost:8080/",
            Realm = "master",
            Resource = "admin-api",
        };
        services.AddKeycloakAdminHttpClient(keycloakOptions).AddClientCredentialsTokenHandler(tokenClientName);
        return services;
    }
}

public class TenantRealm
{
    public string Issuer { get; set; }
}
