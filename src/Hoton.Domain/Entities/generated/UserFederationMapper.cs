using System;
using System.Collections.Generic;

namespace Hoton.Domain.Entities.generated;

public partial class UserFederationMapper
{
    public string Id { get; set; }

    public string Name { get; set; }

    public string FederationProviderId { get; set; }

    public string FederationMapperType { get; set; }

    public string RealmId { get; set; }

    public virtual UserFederationProvider FederationProvider { get; set; }

    public virtual Realm Realm { get; set; }

    public virtual ICollection<UserFederationMapperConfig> UserFederationMapperConfigs { get; set; } = new List<UserFederationMapperConfig>();
}
