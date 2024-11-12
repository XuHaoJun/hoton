using System;
using System.Collections.Generic;

namespace Hoton.Domain.Entities.generated;

public partial class UserEntity
{
    public string Id { get; set; }

    public string Email { get; set; }

    public string EmailConstraint { get; set; }

    public bool EmailVerified { get; set; }

    public bool Enabled { get; set; }

    public string FederationLink { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string RealmId { get; set; }

    public string Username { get; set; }

    public long? CreatedTimestamp { get; set; }

    public string ServiceAccountClientLink { get; set; }

    public int NotBefore { get; set; }

    public virtual ICollection<Credential> Credentials { get; set; } = new List<Credential>();

    public virtual ICollection<FederatedIdentity> FederatedIdentities { get; set; } = new List<FederatedIdentity>();

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();

    public virtual ICollection<UserAttribute> UserAttributes { get; set; } = new List<UserAttribute>();

    public virtual ICollection<UserConsent> UserConsents { get; set; } = new List<UserConsent>();

    public virtual ICollection<UserGroupMembership> UserGroupMemberships { get; set; } = new List<UserGroupMembership>();

    public virtual ICollection<UserRequiredAction> UserRequiredActions { get; set; } = new List<UserRequiredAction>();

    public virtual ICollection<UserRoleMapping> UserRoleMappings { get; set; } = new List<UserRoleMapping>();
}
