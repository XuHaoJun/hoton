namespace Hoton.Identity.Api.Contacts;

public class CreateUserReq
{
    public string Username { get; set; } = default!;
    public string Password { get; set; } = default!;
    public string Email { get; set; } = default!;
}

public class CreateUserResp
{
    public string Id { get; set; } = default!;
}