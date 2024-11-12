using System;
using System.Collections.Generic;

namespace Hoton.Domain.Entities.generated;

public partial class ComponentConfig
{
    public string Id { get; set; }

    public string ComponentId { get; set; }

    public string Name { get; set; }

    public string Value { get; set; }

    public virtual Component Component { get; set; }
}
