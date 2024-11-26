using System.Text.Json.Serialization;

namespace Hoton.Identity.Api.Contacts;

public class HasuraValidateResponse
{
    [JsonPropertyName("x-hasura-user-Id")]
    public required string UserId { get; set; }
    [JsonPropertyName("x-hasura-default-role")]
    public required string DefaultRole { get; set; }
    [JsonPropertyName("x-hasura-allowed-roles")]
    public required string[] AllowedRoles { get; set; }
}
