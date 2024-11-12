using System;
using System.Collections.Generic;

namespace Hoton.Domain.Entities.generated;

public partial class UsernameLoginFailure
{
    public string RealmId { get; set; }

    public string Username { get; set; }

    public int? FailedLoginNotBefore { get; set; }

    public long? LastFailure { get; set; }

    public string LastIpFailure { get; set; }

    public int? NumFailures { get; set; }
}
