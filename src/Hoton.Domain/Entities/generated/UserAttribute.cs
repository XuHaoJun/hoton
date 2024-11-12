using System;
using System.Collections.Generic;

namespace Hoton.Domain.Entities.generated;

public partial class UserAttribute
{
    public string Name { get; set; }

    public string Value { get; set; }

    public string UserId { get; set; }

    public string Id { get; set; }

    public byte[] LongValueHash { get; set; }

    public byte[] LongValueHashLowerCase { get; set; }

    public string LongValue { get; set; }

    public virtual UserEntity User { get; set; }
}
