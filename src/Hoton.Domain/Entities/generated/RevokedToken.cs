using System;
using System.Collections.Generic;

namespace Hoton.Domain.Entities.generated;

public partial class RevokedToken
{
    public string Id { get; set; }

    public long Expire { get; set; }
}
