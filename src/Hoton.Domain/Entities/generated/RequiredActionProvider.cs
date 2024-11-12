using System;
using System.Collections.Generic;

namespace Hoton.Domain.Entities.generated;

public partial class RequiredActionProvider
{
    public string Id { get; set; }

    public string Alias { get; set; }

    public string Name { get; set; }

    public string RealmId { get; set; }

    public bool Enabled { get; set; }

    public bool DefaultAction { get; set; }

    public string ProviderId { get; set; }

    public int? Priority { get; set; }

    public virtual Realm Realm { get; set; }
}
