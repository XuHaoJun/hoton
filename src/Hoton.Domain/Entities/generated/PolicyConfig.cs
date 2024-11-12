using System;
using System.Collections.Generic;

namespace Hoton.Domain.Entities.generated;

public partial class PolicyConfig
{
    public string PolicyId { get; set; }

    public string Name { get; set; }

    public string Value { get; set; }

    public virtual ResourceServerPolicy Policy { get; set; }
}
