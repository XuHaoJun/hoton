using System;
using System.Collections.Generic;

namespace Hoton.Domain.Entities.generated;

public partial class Component
{
    public string Id { get; set; }

    public string Name { get; set; }

    public string ParentId { get; set; }

    public string ProviderId { get; set; }

    public string ProviderType { get; set; }

    public string RealmId { get; set; }

    public string SubType { get; set; }

    public virtual ICollection<ComponentConfig> ComponentConfigs { get; set; } = new List<ComponentConfig>();

    public virtual Realm Realm { get; set; }
}
