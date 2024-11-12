using System;
using System.Collections.Generic;

namespace Hoton.Domain.Entities.generated;

public partial class IdentityProviderMapper
{
    public string Id { get; set; }

    public string Name { get; set; }

    public string IdpAlias { get; set; }

    public string IdpMapperName { get; set; }

    public string RealmId { get; set; }

    public virtual ICollection<IdpMapperConfig> IdpMapperConfigs { get; set; } = new List<IdpMapperConfig>();

    public virtual Realm Realm { get; set; }
}
