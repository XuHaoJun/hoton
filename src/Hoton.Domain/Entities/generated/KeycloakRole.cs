using System;
using System.Collections.Generic;

namespace Hoton.Domain.Entities.generated;

public partial class KeycloakRole
{
    public string Id { get; set; }

    public string ClientRealmConstraint { get; set; }

    public bool ClientRole { get; set; }

    public string Description { get; set; }

    public string Name { get; set; }

    public string RealmId { get; set; }

    public string Client { get; set; }

    public string Realm { get; set; }

    public virtual Realm RealmNavigation { get; set; }

    public virtual ICollection<RoleAttribute> RoleAttributes { get; set; } = new List<RoleAttribute>();

    public virtual ICollection<KeycloakRole> ChildRoles { get; set; } = new List<KeycloakRole>();

    public virtual ICollection<KeycloakRole> Composites { get; set; } = new List<KeycloakRole>();
}
