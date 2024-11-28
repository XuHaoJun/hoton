using System.Text.Json.Serialization;

namespace Hoton.Identity.Api.Contacts;

public class HasuraValidateResponse
{
    [JsonPropertyName("x-hasura-realm-id")]
    public required string RealmId { get; set; }
    [JsonPropertyName("x-hasura-user-id")]
    public required string UserId { get; set; }
    [JsonPropertyName("x-hasura-role")]
    public required string Role { get; set; }
    [JsonPropertyName("x-hasura-default-role")]
    public required string DefaultRole { get; set; }
    [JsonPropertyName("x-hasura-allowed-roles")]
    public required string[] AllowedRoles { get; set; }
}
