using Hoton.Keycloak;
using Keycloak.AuthServices.Authorization;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
if (builder.Environment.IsDevelopment())
{
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen(options =>
    {
        options.AddSecurityDefinition(
            "Bearer",
            new OpenApiSecurityScheme()
            {
                Name = "Authorization",
                In = ParameterLocation.Header,
                Type = SecuritySchemeType.ApiKey,
                Scheme = "Bearer",
                BearerFormat = "JWT",
                Description = "JWT Authorization header using the Bearer scheme.",
            }
        );

        options.AddSecurityRequirement(
            new OpenApiSecurityRequirement
            {
                {
                    new OpenApiSecurityScheme
                    {
                        Reference = new OpenApiReference { Type = ReferenceType.SecurityScheme, Id = "Bearer" },
                    },
                    new string[] { }
                },
            }
        );
    });
}
builder.Services.AddManagers();
builder.Services.AddDistributedMemoryCache();
builder.Services.AddKeyCloakAdminClient();

builder.Services.AddKeyCloakAuth();
builder
    .Services.AddAuthorization(options =>
    {
        var defaultAuthorizationPolicyBuilder = new AuthorizationPolicyBuilder(JwtBearerDefaults.AuthenticationScheme);
        defaultAuthorizationPolicyBuilder = defaultAuthorizationPolicyBuilder.RequireAuthenticatedUser();
        options.DefaultPolicy = defaultAuthorizationPolicyBuilder.Build();
    })
    .AddKeycloakAuthorization();

// .AddAuthorizationBuilder()
// .AddPolicy("realm:roles:uma_authorization", policy => policy.RequireRealmRoles(["uma_authorization"]));

// builder
//     .Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
//     .AddJwtBearer(opts =>
//     {
//         // var sslRequired =
//         //     string.IsNullOrWhiteSpace(keycloakOptions.SslRequired)
//         //     || keycloakOptions.SslRequired.Equals("external", StringComparison.OrdinalIgnoreCase);

//         // opts.Authority = keycloakOptions.KeycloakUrlRealm;
//         // opts.Audience = keycloakOptions.Resource;
//         // opts.TokenValidationParameters = validationParameters;
//         // opts.RequireHttpsMetadata = sslRequired;
//         // opts.SaveToken = true;
//         // configureOptions?.Invoke(opts);
//     });


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// app.UseHttpsRedirection();
app.UseRouting();

app.UseCors(x => x.AllowAnyMethod().AllowAnyHeader().SetIsOriginAllowed(origin => true).AllowCredentials());

app.UseAuthorization();
app.UseAuthentication();

app.MapControllers().RequireAuthorization();

app.Run();
