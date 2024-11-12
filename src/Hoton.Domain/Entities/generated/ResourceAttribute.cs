using System;
using System.Collections.Generic;

namespace Hoton.Domain.Entities.generated;

public partial class ResourceAttribute
{
    public string Id { get; set; }

    public string Name { get; set; }

    public string Value { get; set; }

    public string ResourceId { get; set; }

    public virtual ResourceServerResource Resource { get; set; }
}
