using System;
using System.Collections.Generic;

namespace Hoton.Domain.Entities.generated;

public partial class Realm
{
    public string Id { get; set; }

    public int? AccessCodeLifespan { get; set; }

    public int? UserActionLifespan { get; set; }

    public int? AccessTokenLifespan { get; set; }

    public string AccountTheme { get; set; }

    public string AdminTheme { get; set; }

    public string EmailTheme { get; set; }

    public bool Enabled { get; set; }

    public bool EventsEnabled { get; set; }

    public long? EventsExpiration { get; set; }

    public string LoginTheme { get; set; }

    public string Name { get; set; }

    public int? NotBefore { get; set; }

    public string PasswordPolicy { get; set; }

    public bool RegistrationAllowed { get; set; }

    public bool RememberMe { get; set; }

    public bool ResetPasswordAllowed { get; set; }

    public bool Social { get; set; }

    public string SslRequired { get; set; }

    public int? SsoIdleTimeout { get; set; }

    public int? SsoMaxLifespan { get; set; }

    public bool UpdateProfileOnSocLogin { get; set; }

    public bool VerifyEmail { get; set; }

    public string MasterAdminClient { get; set; }

    public int? LoginLifespan { get; set; }

    public bool InternationalizationEnabled { get; set; }

    public string DefaultLocale { get; set; }

    public bool RegEmailAsUsername { get; set; }

    public bool AdminEventsEnabled { get; set; }

    public bool AdminEventsDetailsEnabled { get; set; }

    public bool EditUsernameAllowed { get; set; }

    public int? OtpPolicyCounter { get; set; }

    public int? OtpPolicyWindow { get; set; }

    public int? OtpPolicyPeriod { get; set; }

    public int? OtpPolicyDigits { get; set; }

    public string OtpPolicyAlg { get; set; }

    public string OtpPolicyType { get; set; }

    public string BrowserFlow { get; set; }

    public string RegistrationFlow { get; set; }

    public string DirectGrantFlow { get; set; }

    public string ResetCredentialsFlow { get; set; }

    public string ClientAuthFlow { get; set; }

    public int? OfflineSessionIdleTimeout { get; set; }

    public bool RevokeRefreshToken { get; set; }

    public int? AccessTokenLifeImplicit { get; set; }

    public bool LoginWithEmailAllowed { get; set; }

    public bool DuplicateEmailsAllowed { get; set; }

    public string DockerAuthFlow { get; set; }

    public int? RefreshTokenMaxReuse { get; set; }

    public bool AllowUserManagedAccess { get; set; }

    public int SsoMaxLifespanRememberMe { get; set; }

    public int SsoIdleTimeoutRememberMe { get; set; }

    public string DefaultRole { get; set; }

    public virtual ICollection<AuthenticationExecution> AuthenticationExecutions { get; set; } = new List<AuthenticationExecution>();

    public virtual ICollection<AuthenticationFlow> AuthenticationFlows { get; set; } = new List<AuthenticationFlow>();

    public virtual ICollection<AuthenticatorConfig> AuthenticatorConfigs { get; set; } = new List<AuthenticatorConfig>();

    public virtual ICollection<ClientInitialAccess> ClientInitialAccesses { get; set; } = new List<ClientInitialAccess>();

    public virtual ICollection<Component> Components { get; set; } = new List<Component>();

    public virtual ICollection<DefaultClientScope> DefaultClientScopes { get; set; } = new List<DefaultClientScope>();

    public virtual ICollection<IdentityProviderMapper> IdentityProviderMappers { get; set; } = new List<IdentityProviderMapper>();

    public virtual ICollection<IdentityProvider> IdentityProviders { get; set; } = new List<IdentityProvider>();

    public virtual ICollection<KeycloakRole> KeycloakRoles { get; set; } = new List<KeycloakRole>();

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();

    public virtual ICollection<RealmAttribute> RealmAttributes { get; set; } = new List<RealmAttribute>();

    public virtual ICollection<RealmDefaultGroup> RealmDefaultGroups { get; set; } = new List<RealmDefaultGroup>();

    public virtual ICollection<RealmEnabledEventType> RealmEnabledEventTypes { get; set; } = new List<RealmEnabledEventType>();

    public virtual ICollection<RealmEventsListener> RealmEventsListeners { get; set; } = new List<RealmEventsListener>();

    public virtual ICollection<RealmRequiredCredential> RealmRequiredCredentials { get; set; } = new List<RealmRequiredCredential>();

    public virtual ICollection<RealmSmtpConfig> RealmSmtpConfigs { get; set; } = new List<RealmSmtpConfig>();

    public virtual ICollection<RealmSupportedLocale> RealmSupportedLocales { get; set; } = new List<RealmSupportedLocale>();

    public virtual ICollection<RequiredActionProvider> RequiredActionProviders { get; set; } = new List<RequiredActionProvider>();

    public virtual ICollection<UserFederationMapper> UserFederationMappers { get; set; } = new List<UserFederationMapper>();

    public virtual ICollection<UserFederationProvider> UserFederationProviders { get; set; } = new List<UserFederationProvider>();
}
