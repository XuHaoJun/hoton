using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Hoton.Identity.Api.Contacts;

public class TokenRequestModel
{
    [JsonPropertyName("grant_type")]
    [Required]
    public string? GrantType { get; set; }

    [JsonPropertyName("code")]
    public string? Code { get; set; }

    [JsonPropertyName("redirect_uri")]
    public string? RedirectUri { get; set; }

    [JsonPropertyName("client_id")]
    public string? ClientId { get; set; }

    [JsonPropertyName("client_secret")]
    public string? ClientSecret { get; set; }

    [JsonPropertyName("code_verifier")]
    public string? CodeVerifier { get; set; }

    [JsonPropertyName("username")]
    public string? Username { get; set; }

    [JsonPropertyName("password")]
    public string? Password { get; set; }

    [JsonPropertyName("refresh_token")]
    public string? RefreshToken { get; set; }

    [JsonPropertyName("captchaToken")]
    public string? CaptchaToken { get; set; }
}

// public class TokenRequest
// {
//     [JsonPropertyName("grant_type")]
//     public string? GrantType { get; set; }

//     [JsonPropertyName("code")]
//     public string? Code { get; set; }

//     [JsonPropertyName("redirect_uri")]
//     public string? RedirectUri { get; set; }

//     [JsonPropertyName("client_id")]
//     public string? ClientId { get; set; }

//     [JsonPropertyName("client_secret")]
//     public string? ClientSecret { get; set; }

//     [JsonPropertyName("code_verifier")]
//     public string? CodeVerifier { get; set; }

//     [JsonPropertyName("username")]
//     public string? Username { get; set; }

//     [JsonPropertyName("password")]
//     public string? Password { get; set; }

//     [JsonPropertyName("refresh_token")]
//     public string? RefreshToken { get; set; }
// }
