using System;
using System.Collections.Generic;

namespace Hoton.Domain.Entities.generated;

public partial class ResourceUri
{
    public string ResourceId { get; set; }

    public string Value { get; set; }

    public virtual ResourceServerResource Resource { get; set; }
}
