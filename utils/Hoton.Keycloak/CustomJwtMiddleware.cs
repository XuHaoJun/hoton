// using System.IdentityModel.Tokens.Jwt;
// using Microsoft.AspNetCore.Http;
// using Microsoft.IdentityModel.Tokens;

// public class CustomJwtMiddleware
// {
//     private readonly RequestDelegate _next;

//     public CustomJwtMiddleware(RequestDelegate next)
//     {
//         _next = next;
//     }

//     public async Task Invoke(HttpContext context)
//     {
//         var token = context.Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").Last();
        
//         if (token != null)
//         {
//             var validationParameters = GetValidationParameters(context); // Method to determine parameters based on context
//             var tokenHandler = new JwtSecurityTokenHandler();

//             try
//             {
//                 tokenHandler.ValidateToken(token, validationParameters, out SecurityToken validatedToken);
//                 // Attach user to context if needed
//             }
//             catch (SecurityTokenException)
//             {
//                 // Handle token validation failure
//                 context.Response.StatusCode = 401; // Unauthorized
//                 return;
//             }
//         }

//         await _next(context); // Call the next middleware
//     }

//     private TokenValidationParameters GetValidationParameters(HttpContext context)
//     {
//         // Logic to determine validation parameters based on request context
//         return new TokenValidationParameters
//         {
//             ValidateIssuerSigningKey = true,
//             IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("your_signing_key")),
//             ValidateIssuer = true,
//             ValidIssuer = "your_issuer",
//             ValidateAudience = true,
//             ValidAudience = "your_audience",
//             ValidateLifetime = true,
//             ClockSkew = TimeSpan.Zero // Optional: set clock skew for expiration checks
//         };
//     }
// }