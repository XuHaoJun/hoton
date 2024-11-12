using System;
using System.Collections.Generic;

namespace Hoton.Domain.Entities.generated;

public partial class Client
{
    public string Id { get; set; }

    public bool Enabled { get; set; }

    public bool FullScopeAllowed { get; set; }

    public string ClientId { get; set; }

    public int? NotBefore { get; set; }

    public bool PublicClient { get; set; }

    public string Secret { get; set; }

    public string BaseUrl { get; set; }

    public bool BearerOnly { get; set; }

    public string ManagementUrl { get; set; }

    public bool SurrogateAuthRequired { get; set; }

    public string RealmId { get; set; }

    public string Protocol { get; set; }

    public int? NodeReregTimeout { get; set; }

    public bool FrontchannelLogout { get; set; }

    public bool ConsentRequired { get; set; }

    public string Name { get; set; }

    public bool ServiceAccountsEnabled { get; set; }

    public string ClientAuthenticatorType { get; set; }

    public string RootUrl { get; set; }

    public string Description { get; set; }

    public string RegistrationToken { get; set; }

    public bool StandardFlowEnabled { get; set; }

    public bool ImplicitFlowEnabled { get; set; }

    public bool DirectAccessGrantsEnabled { get; set; }

    public bool AlwaysDisplayInConsole { get; set; }

    public virtual ICollection<ClientAttribute> ClientAttributes { get; set; } = new List<ClientAttribute>();

    public virtual ICollection<ClientNodeRegistration> ClientNodeRegistrations { get; set; } = new List<ClientNodeRegistration>();

    public virtual ICollection<ProtocolMapper> ProtocolMappers { get; set; } = new List<ProtocolMapper>();

    public virtual ICollection<RedirectUri> RedirectUris { get; set; } = new List<RedirectUri>();

    public virtual ICollection<ScopeMapping> ScopeMappings { get; set; } = new List<ScopeMapping>();

    public virtual ICollection<WebOrigin> WebOrigins { get; set; } = new List<WebOrigin>();
}
