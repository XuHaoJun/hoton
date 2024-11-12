using System;
using System.Collections.Generic;

namespace Hoton.Domain.Entities.generated;

public partial class IdentityProvider
{
    public string InternalId { get; set; }

    public bool Enabled { get; set; }

    public string ProviderAlias { get; set; }

    public string ProviderId { get; set; }

    public bool StoreToken { get; set; }

    public bool AuthenticateByDefault { get; set; }

    public string RealmId { get; set; }

    public bool AddTokenRole { get; set; }

    public bool TrustEmail { get; set; }

    public string FirstBrokerLoginFlowId { get; set; }

    public string PostBrokerLoginFlowId { get; set; }

    public string ProviderDisplayName { get; set; }

    public bool LinkOnly { get; set; }

    public string OrganizationId { get; set; }

    public bool? HideOnLogin { get; set; }

    public virtual ICollection<IdentityProviderConfig> IdentityProviderConfigs { get; set; } = new List<IdentityProviderConfig>();

    public virtual Realm Realm { get; set; }
}
