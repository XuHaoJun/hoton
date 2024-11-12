using System;
using System.Collections.Generic;

namespace Hoton.Domain.Entities.generated;

public partial class ClientNodeRegistration
{
    public string ClientId { get; set; }

    public int? Value { get; set; }

    public string Name { get; set; }

    public virtual Client Client { get; set; }
}
