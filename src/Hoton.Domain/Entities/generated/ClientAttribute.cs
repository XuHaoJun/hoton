using System;
using System.Collections.Generic;

namespace Hoton.Domain.Entities.generated;

public partial class ClientAttribute
{
    public string ClientId { get; set; }

    public string Name { get; set; }

    public string Value { get; set; }

    public virtual Client Client { get; set; }
}
