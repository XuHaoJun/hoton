using System;
using System.Collections.Generic;

namespace Hoton.Domain.Entities.generated;

public partial class UserFederationProvider
{
    public string Id { get; set; }

    public int? ChangedSyncPeriod { get; set; }

    public string DisplayName { get; set; }

    public int? FullSyncPeriod { get; set; }

    public int? LastSync { get; set; }

    public int? Priority { get; set; }

    public string ProviderName { get; set; }

    public string RealmId { get; set; }

    public virtual Realm Realm { get; set; }

    public virtual ICollection<UserFederationConfig> UserFederationConfigs { get; set; } = new List<UserFederationConfig>();

    public virtual ICollection<UserFederationMapper> UserFederationMappers { get; set; } = new List<UserFederationMapper>();
}
