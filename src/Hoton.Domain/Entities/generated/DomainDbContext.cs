using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Hoton.Domain.Entities.generated;

public partial class DomainDbContext : DbContext
{
    public DomainDbContext()
    {
    }

    public DomainDbContext(DbContextOptions<DomainDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AdminEventEntity> AdminEventEntities { get; set; }

    public virtual DbSet<AuthenticationExecution> AuthenticationExecutions { get; set; }

    public virtual DbSet<AuthenticationFlow> AuthenticationFlows { get; set; }

    public virtual DbSet<AuthenticatorConfig> AuthenticatorConfigs { get; set; }

    public virtual DbSet<AuthenticatorConfigEntry> AuthenticatorConfigEntries { get; set; }

    public virtual DbSet<BrokerLink> BrokerLinks { get; set; }

    public virtual DbSet<Cart> Carts { get; set; }

    public virtual DbSet<CartItem> CartItems { get; set; }

    public virtual DbSet<Client> Clients { get; set; }

    public virtual DbSet<ClientAttribute> ClientAttributes { get; set; }

    public virtual DbSet<ClientAuthFlowBinding> ClientAuthFlowBindings { get; set; }

    public virtual DbSet<ClientInitialAccess> ClientInitialAccesses { get; set; }

    public virtual DbSet<ClientNodeRegistration> ClientNodeRegistrations { get; set; }

    public virtual DbSet<ClientScope> ClientScopes { get; set; }

    public virtual DbSet<ClientScopeAttribute> ClientScopeAttributes { get; set; }

    public virtual DbSet<ClientScopeClient> ClientScopeClients { get; set; }

    public virtual DbSet<ClientScopeRoleMapping> ClientScopeRoleMappings { get; set; }

    public virtual DbSet<Component> Components { get; set; }

    public virtual DbSet<ComponentConfig> ComponentConfigs { get; set; }

    public virtual DbSet<Credential> Credentials { get; set; }

    public virtual DbSet<Databasechangelog> Databasechangelogs { get; set; }

    public virtual DbSet<Databasechangeloglock> Databasechangeloglocks { get; set; }

    public virtual DbSet<DefaultClientScope> DefaultClientScopes { get; set; }

    public virtual DbSet<EventEntity> EventEntities { get; set; }

    public virtual DbSet<FedUserAttribute> FedUserAttributes { get; set; }

    public virtual DbSet<FedUserConsent> FedUserConsents { get; set; }

    public virtual DbSet<FedUserConsentClScope> FedUserConsentClScopes { get; set; }

    public virtual DbSet<FedUserCredential> FedUserCredentials { get; set; }

    public virtual DbSet<FedUserGroupMembership> FedUserGroupMemberships { get; set; }

    public virtual DbSet<FedUserRequiredAction> FedUserRequiredActions { get; set; }

    public virtual DbSet<FedUserRoleMapping> FedUserRoleMappings { get; set; }

    public virtual DbSet<FederatedIdentity> FederatedIdentities { get; set; }

    public virtual DbSet<FederatedUser> FederatedUsers { get; set; }

    public virtual DbSet<GroupAttribute> GroupAttributes { get; set; }

    public virtual DbSet<GroupRoleMapping> GroupRoleMappings { get; set; }

    public virtual DbSet<IdentityProvider> IdentityProviders { get; set; }

    public virtual DbSet<IdentityProviderConfig> IdentityProviderConfigs { get; set; }

    public virtual DbSet<IdentityProviderMapper> IdentityProviderMappers { get; set; }

    public virtual DbSet<IdpMapperConfig> IdpMapperConfigs { get; set; }

    public virtual DbSet<KeycloakGroup> KeycloakGroups { get; set; }

    public virtual DbSet<KeycloakRole> KeycloakRoles { get; set; }

    public virtual DbSet<MigrationModel> MigrationModels { get; set; }

    public virtual DbSet<OfflineClientSession> OfflineClientSessions { get; set; }

    public virtual DbSet<OfflineUserSession> OfflineUserSessions { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<OrderInvoice> OrderInvoices { get; set; }

    public virtual DbSet<OrderInvoiceItem> OrderInvoiceItems { get; set; }

    public virtual DbSet<OrderInvoiceStatusHistory> OrderInvoiceStatusHistories { get; set; }

    public virtual DbSet<OrderItem> OrderItems { get; set; }

    public virtual DbSet<OrderItemCargoMap> OrderItemCargoMaps { get; set; }

    public virtual DbSet<OrderPayment> OrderPayments { get; set; }

    public virtual DbSet<OrderShipment> OrderShipments { get; set; }

    public virtual DbSet<OrderShipmentCargo> OrderShipmentCargos { get; set; }

    public virtual DbSet<OrderStatusHistory> OrderStatusHistories { get; set; }

    public virtual DbSet<Org> Orgs { get; set; }

    public virtual DbSet<OrgDomain> OrgDomains { get; set; }

    public virtual DbSet<PolicyConfig> PolicyConfigs { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<ProductCategory> ProductCategories { get; set; }

    public virtual DbSet<ProductShipmentConfig> ProductShipmentConfigs { get; set; }

    public virtual DbSet<ProductSku> ProductSkus { get; set; }

    public virtual DbSet<ProtocolMapper> ProtocolMappers { get; set; }

    public virtual DbSet<ProtocolMapperConfig> ProtocolMapperConfigs { get; set; }

    public virtual DbSet<Realm> Realms { get; set; }

    public virtual DbSet<RealmAttribute> RealmAttributes { get; set; }

    public virtual DbSet<RealmDefaultGroup> RealmDefaultGroups { get; set; }

    public virtual DbSet<RealmEnabledEventType> RealmEnabledEventTypes { get; set; }

    public virtual DbSet<RealmEventsListener> RealmEventsListeners { get; set; }

    public virtual DbSet<RealmLocalization> RealmLocalizations { get; set; }

    public virtual DbSet<RealmOrderShipmentConfig> RealmOrderShipmentConfigs { get; set; }

    public virtual DbSet<RealmRequiredCredential> RealmRequiredCredentials { get; set; }

    public virtual DbSet<RealmSmtpConfig> RealmSmtpConfigs { get; set; }

    public virtual DbSet<RealmSupportedLocale> RealmSupportedLocales { get; set; }

    public virtual DbSet<RedirectUri> RedirectUris { get; set; }

    public virtual DbSet<RequiredActionConfig> RequiredActionConfigs { get; set; }

    public virtual DbSet<RequiredActionProvider> RequiredActionProviders { get; set; }

    public virtual DbSet<ResourceAttribute> ResourceAttributes { get; set; }

    public virtual DbSet<ResourceServer> ResourceServers { get; set; }

    public virtual DbSet<ResourceServerPermTicket> ResourceServerPermTickets { get; set; }

    public virtual DbSet<ResourceServerPolicy> ResourceServerPolicies { get; set; }

    public virtual DbSet<ResourceServerResource> ResourceServerResources { get; set; }

    public virtual DbSet<ResourceServerScope> ResourceServerScopes { get; set; }

    public virtual DbSet<ResourceUri> ResourceUris { get; set; }

    public virtual DbSet<RevokedToken> RevokedTokens { get; set; }

    public virtual DbSet<RoleAttribute> RoleAttributes { get; set; }

    public virtual DbSet<ScopeMapping> ScopeMappings { get; set; }

    public virtual DbSet<SnapshotProduct> SnapshotProducts { get; set; }

    public virtual DbSet<SnapshotProductSku> SnapshotProductSkus { get; set; }

    public virtual DbSet<UserAttribute> UserAttributes { get; set; }

    public virtual DbSet<UserConsent> UserConsents { get; set; }

    public virtual DbSet<UserConsentClientScope> UserConsentClientScopes { get; set; }

    public virtual DbSet<UserEntity> UserEntities { get; set; }

    public virtual DbSet<UserFederationConfig> UserFederationConfigs { get; set; }

    public virtual DbSet<UserFederationMapper> UserFederationMappers { get; set; }

    public virtual DbSet<UserFederationMapperConfig> UserFederationMapperConfigs { get; set; }

    public virtual DbSet<UserFederationProvider> UserFederationProviders { get; set; }

    public virtual DbSet<UserGroupMembership> UserGroupMemberships { get; set; }

    public virtual DbSet<UserRequiredAction> UserRequiredActions { get; set; }

    public virtual DbSet<UserRoleMapping> UserRoleMappings { get; set; }

    public virtual DbSet<UsernameLoginFailure> UsernameLoginFailures { get; set; }

    public virtual DbSet<WebOrigin> WebOrigins { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .HasPostgresExtension("ltree")
            .HasPostgresExtension("uuid-ossp");

        modelBuilder.Entity<AdminEventEntity>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("constraint_admin_event_entity");

            entity.ToTable("admin_event_entity", "auth");

            entity.HasIndex(e => new { e.RealmId, e.AdminEventTime }, "idx_admin_event_time");

            entity.Property(e => e.Id)
                .HasMaxLength(36)
                .HasColumnName("id");
            entity.Property(e => e.AdminEventTime).HasColumnName("admin_event_time");
            entity.Property(e => e.AuthClientId)
                .HasMaxLength(255)
                .HasColumnName("auth_client_id");
            entity.Property(e => e.AuthRealmId)
                .HasMaxLength(255)
                .HasColumnName("auth_realm_id");
            entity.Property(e => e.AuthUserId)
                .HasMaxLength(255)
                .HasColumnName("auth_user_id");
            entity.Property(e => e.Error)
                .HasMaxLength(255)
                .HasColumnName("error");
            entity.Property(e => e.IpAddress)
                .HasMaxLength(255)
                .HasColumnName("ip_address");
            entity.Property(e => e.OperationType)
                .HasMaxLength(255)
                .HasColumnName("operation_type");
            entity.Property(e => e.RealmId)
                .HasMaxLength(255)
                .HasColumnName("realm_id");
            entity.Property(e => e.Representation).HasColumnName("representation");
            entity.Property(e => e.ResourcePath)
                .HasMaxLength(2550)
                .HasColumnName("resource_path");
            entity.Property(e => e.ResourceType)
                .HasMaxLength(64)
                .HasColumnName("resource_type");
        });

        modelBuilder.Entity<AuthenticationExecution>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("constraint_auth_exec_pk");

            entity.ToTable("authentication_execution", "auth");

            entity.HasIndex(e => e.FlowId, "idx_auth_exec_flow");

            entity.HasIndex(e => new { e.RealmId, e.FlowId }, "idx_auth_exec_realm_flow");

            entity.Property(e => e.Id)
                .HasMaxLength(36)
                .HasColumnName("id");
            entity.Property(e => e.Alias)
                .HasMaxLength(255)
                .HasColumnName("alias");
            entity.Property(e => e.AuthConfig)
                .HasMaxLength(36)
                .HasColumnName("auth_config");
            entity.Property(e => e.AuthFlowId)
                .HasMaxLength(36)
                .HasColumnName("auth_flow_id");
            entity.Property(e => e.Authenticator)
                .HasMaxLength(36)
                .HasColumnName("authenticator");
            entity.Property(e => e.AuthenticatorFlow)
                .HasDefaultValue(false)
                .HasColumnName("authenticator_flow");
            entity.Property(e => e.FlowId)
                .HasMaxLength(36)
                .HasColumnName("flow_id");
            entity.Property(e => e.Priority).HasColumnName("priority");
            entity.Property(e => e.RealmId)
                .HasMaxLength(36)
                .HasColumnName("realm_id");
            entity.Property(e => e.Requirement).HasColumnName("requirement");

            entity.HasOne(d => d.Flow).WithMany(p => p.AuthenticationExecutions)
                .HasForeignKey(d => d.FlowId)
                .HasConstraintName("fk_auth_exec_flow");

            entity.HasOne(d => d.Realm).WithMany(p => p.AuthenticationExecutions)
                .HasForeignKey(d => d.RealmId)
                .HasConstraintName("fk_auth_exec_realm");
        });

        modelBuilder.Entity<AuthenticationFlow>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("constraint_auth_flow_pk");

            entity.ToTable("authentication_flow", "auth");

            entity.HasIndex(e => e.RealmId, "idx_auth_flow_realm");

            entity.Property(e => e.Id)
                .HasMaxLength(36)
                .HasColumnName("id");
            entity.Property(e => e.Alias)
                .HasMaxLength(255)
                .HasColumnName("alias");
            entity.Property(e => e.BuiltIn)
                .HasDefaultValue(false)
                .HasColumnName("built_in");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .HasColumnName("description");
            entity.Property(e => e.ProviderId)
                .IsRequired()
                .HasMaxLength(36)
                .HasDefaultValueSql("'basic-flow'::character varying")
                .HasColumnName("provider_id");
            entity.Property(e => e.RealmId)
                .HasMaxLength(36)
                .HasColumnName("realm_id");
            entity.Property(e => e.TopLevel)
                .HasDefaultValue(false)
                .HasColumnName("top_level");

            entity.HasOne(d => d.Realm).WithMany(p => p.AuthenticationFlows)
                .HasForeignKey(d => d.RealmId)
                .HasConstraintName("fk_auth_flow_realm");
        });

        modelBuilder.Entity<AuthenticatorConfig>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("constraint_auth_pk");

            entity.ToTable("authenticator_config", "auth");

            entity.HasIndex(e => e.RealmId, "idx_auth_config_realm");

            entity.Property(e => e.Id)
                .HasMaxLength(36)
                .HasColumnName("id");
            entity.Property(e => e.Alias)
                .HasMaxLength(255)
                .HasColumnName("alias");
            entity.Property(e => e.RealmId)
                .HasMaxLength(36)
                .HasColumnName("realm_id");

            entity.HasOne(d => d.Realm).WithMany(p => p.AuthenticatorConfigs)
                .HasForeignKey(d => d.RealmId)
                .HasConstraintName("fk_auth_realm");
        });

        modelBuilder.Entity<AuthenticatorConfigEntry>(entity =>
        {
            entity.HasKey(e => new { e.AuthenticatorId, e.Name }).HasName("constraint_auth_cfg_pk");

            entity.ToTable("authenticator_config_entry", "auth");

            entity.Property(e => e.AuthenticatorId)
                .HasMaxLength(36)
                .HasColumnName("authenticator_id");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Value).HasColumnName("value");
        });

        modelBuilder.Entity<BrokerLink>(entity =>
        {
            entity.HasKey(e => new { e.IdentityProvider, e.UserId }).HasName("constr_broker_link_pk");

            entity.ToTable("broker_link", "auth");

            entity.Property(e => e.IdentityProvider)
                .HasMaxLength(255)
                .HasColumnName("identity_provider");
            entity.Property(e => e.UserId)
                .HasMaxLength(255)
                .HasColumnName("user_id");
            entity.Property(e => e.BrokerUserId)
                .HasMaxLength(255)
                .HasColumnName("broker_user_id");
            entity.Property(e => e.BrokerUsername)
                .HasMaxLength(255)
                .HasColumnName("broker_username");
            entity.Property(e => e.RealmId)
                .IsRequired()
                .HasMaxLength(36)
                .HasColumnName("realm_id");
            entity.Property(e => e.StorageProviderId)
                .HasMaxLength(255)
                .HasColumnName("storage_provider_id");
            entity.Property(e => e.Token).HasColumnName("token");
        });

        modelBuilder.Entity<Cart>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("cart_pkey");

            entity.ToTable("cart", "cart");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("uuid_generate_v4()")
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("created_at");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("updated_at");
            entity.Property(e => e.UserId)
                .IsRequired()
                .HasMaxLength(36)
                .HasColumnName("user_id");

            entity.HasOne(d => d.User).WithMany(p => p.Carts)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("cart_user_id_fkey");
        });

        modelBuilder.Entity<CartItem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("cart_item_pkey");

            entity.ToTable("cart_item", "cart");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("uuid_generate_v4()")
                .HasColumnName("id");
            entity.Property(e => e.CartId).HasColumnName("cart_id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("created_at");
            entity.Property(e => e.Price)
                .HasPrecision(10, 2)
                .HasColumnName("price");
            entity.Property(e => e.ProductSkuId).HasColumnName("product_sku_id");
            entity.Property(e => e.Quantity)
                .HasDefaultValue(1)
                .HasColumnName("quantity");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("updated_at");

            entity.HasOne(d => d.Cart).WithMany(p => p.CartItems)
                .HasForeignKey(d => d.CartId)
                .HasConstraintName("cart_item_cart_id_fkey");

            entity.HasOne(d => d.ProductSku).WithMany(p => p.CartItems)
                .HasForeignKey(d => d.ProductSkuId)
                .HasConstraintName("cart_item_product_sku_id_fkey");
        });

        modelBuilder.Entity<Client>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("constraint_7");

            entity.ToTable("client", "auth");

            entity.HasIndex(e => e.ClientId, "idx_client_id");

            entity.HasIndex(e => new { e.RealmId, e.ClientId }, "uk_b71cjlbenv945rb6gcon438at").IsUnique();

            entity.Property(e => e.Id)
                .HasMaxLength(36)
                .HasColumnName("id");
            entity.Property(e => e.AlwaysDisplayInConsole)
                .HasDefaultValue(false)
                .HasColumnName("always_display_in_console");
            entity.Property(e => e.BaseUrl)
                .HasMaxLength(255)
                .HasColumnName("base_url");
            entity.Property(e => e.BearerOnly)
                .HasDefaultValue(false)
                .HasColumnName("bearer_only");
            entity.Property(e => e.ClientAuthenticatorType)
                .HasMaxLength(255)
                .HasColumnName("client_authenticator_type");
            entity.Property(e => e.ClientId)
                .HasMaxLength(255)
                .HasColumnName("client_id");
            entity.Property(e => e.ConsentRequired)
                .HasDefaultValue(false)
                .HasColumnName("consent_required");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .HasColumnName("description");
            entity.Property(e => e.DirectAccessGrantsEnabled)
                .HasDefaultValue(false)
                .HasColumnName("direct_access_grants_enabled");
            entity.Property(e => e.Enabled)
                .HasDefaultValue(false)
                .HasColumnName("enabled");
            entity.Property(e => e.FrontchannelLogout)
                .HasDefaultValue(false)
                .HasColumnName("frontchannel_logout");
            entity.Property(e => e.FullScopeAllowed)
                .HasDefaultValue(false)
                .HasColumnName("full_scope_allowed");
            entity.Property(e => e.ImplicitFlowEnabled)
                .HasDefaultValue(false)
                .HasColumnName("implicit_flow_enabled");
            entity.Property(e => e.ManagementUrl)
                .HasMaxLength(255)
                .HasColumnName("management_url");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.NodeReregTimeout)
                .HasDefaultValue(0)
                .HasColumnName("node_rereg_timeout");
            entity.Property(e => e.NotBefore).HasColumnName("not_before");
            entity.Property(e => e.Protocol)
                .HasMaxLength(255)
                .HasColumnName("protocol");
            entity.Property(e => e.PublicClient)
                .HasDefaultValue(false)
                .HasColumnName("public_client");
            entity.Property(e => e.RealmId)
                .HasMaxLength(36)
                .HasColumnName("realm_id");
            entity.Property(e => e.RegistrationToken)
                .HasMaxLength(255)
                .HasColumnName("registration_token");
            entity.Property(e => e.RootUrl)
                .HasMaxLength(255)
                .HasColumnName("root_url");
            entity.Property(e => e.Secret)
                .HasMaxLength(255)
                .HasColumnName("secret");
            entity.Property(e => e.ServiceAccountsEnabled)
                .HasDefaultValue(false)
                .HasColumnName("service_accounts_enabled");
            entity.Property(e => e.StandardFlowEnabled)
                .HasDefaultValue(true)
                .HasColumnName("standard_flow_enabled");
            entity.Property(e => e.SurrogateAuthRequired)
                .HasDefaultValue(false)
                .HasColumnName("surrogate_auth_required");
        });

        modelBuilder.Entity<ClientAttribute>(entity =>
        {
            entity.HasKey(e => new { e.ClientId, e.Name }).HasName("constraint_3c");

            entity.ToTable("client_attributes", "auth");

            entity.Property(e => e.ClientId)
                .HasMaxLength(36)
                .HasColumnName("client_id");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Value).HasColumnName("value");

            entity.HasOne(d => d.Client).WithMany(p => p.ClientAttributes)
                .HasForeignKey(d => d.ClientId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk3c47c64beacca966");
        });

        modelBuilder.Entity<ClientAuthFlowBinding>(entity =>
        {
            entity.HasKey(e => new { e.ClientId, e.BindingName }).HasName("c_cli_flow_bind");

            entity.ToTable("client_auth_flow_bindings", "auth");

            entity.Property(e => e.ClientId)
                .HasMaxLength(36)
                .HasColumnName("client_id");
            entity.Property(e => e.BindingName)
                .HasMaxLength(255)
                .HasColumnName("binding_name");
            entity.Property(e => e.FlowId)
                .HasMaxLength(36)
                .HasColumnName("flow_id");
        });

        modelBuilder.Entity<ClientInitialAccess>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("cnstr_client_init_acc_pk");

            entity.ToTable("client_initial_access", "auth");

            entity.HasIndex(e => e.RealmId, "idx_client_init_acc_realm");

            entity.Property(e => e.Id)
                .HasMaxLength(36)
                .HasColumnName("id");
            entity.Property(e => e.Count).HasColumnName("count");
            entity.Property(e => e.Expiration).HasColumnName("expiration");
            entity.Property(e => e.RealmId)
                .IsRequired()
                .HasMaxLength(36)
                .HasColumnName("realm_id");
            entity.Property(e => e.RemainingCount).HasColumnName("remaining_count");
            entity.Property(e => e.Timestamp).HasColumnName("timestamp");

            entity.HasOne(d => d.Realm).WithMany(p => p.ClientInitialAccesses)
                .HasForeignKey(d => d.RealmId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_client_init_acc_realm");
        });

        modelBuilder.Entity<ClientNodeRegistration>(entity =>
        {
            entity.HasKey(e => new { e.ClientId, e.Name }).HasName("constraint_84");

            entity.ToTable("client_node_registrations", "auth");

            entity.Property(e => e.ClientId)
                .HasMaxLength(36)
                .HasColumnName("client_id");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Value).HasColumnName("value");

            entity.HasOne(d => d.Client).WithMany(p => p.ClientNodeRegistrations)
                .HasForeignKey(d => d.ClientId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk4129723ba992f594");
        });

        modelBuilder.Entity<ClientScope>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_cli_template");

            entity.ToTable("client_scope", "auth");

            entity.HasIndex(e => e.RealmId, "idx_realm_clscope");

            entity.HasIndex(e => new { e.RealmId, e.Name }, "uk_cli_scope").IsUnique();

            entity.Property(e => e.Id)
                .HasMaxLength(36)
                .HasColumnName("id");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .HasColumnName("description");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Protocol)
                .HasMaxLength(255)
                .HasColumnName("protocol");
            entity.Property(e => e.RealmId)
                .HasMaxLength(36)
                .HasColumnName("realm_id");
        });

        modelBuilder.Entity<ClientScopeAttribute>(entity =>
        {
            entity.HasKey(e => new { e.ScopeId, e.Name }).HasName("pk_cl_tmpl_attr");

            entity.ToTable("client_scope_attributes", "auth");

            entity.HasIndex(e => e.ScopeId, "idx_clscope_attrs");

            entity.Property(e => e.ScopeId)
                .HasMaxLength(36)
                .HasColumnName("scope_id");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Value)
                .HasMaxLength(2048)
                .HasColumnName("value");

            entity.HasOne(d => d.Scope).WithMany(p => p.ClientScopeAttributes)
                .HasForeignKey(d => d.ScopeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_cl_scope_attr_scope");
        });

        modelBuilder.Entity<ClientScopeClient>(entity =>
        {
            entity.HasKey(e => new { e.ClientId, e.ScopeId }).HasName("c_cli_scope_bind");

            entity.ToTable("client_scope_client", "auth");

            entity.HasIndex(e => e.ScopeId, "idx_cl_clscope");

            entity.HasIndex(e => e.ClientId, "idx_clscope_cl");

            entity.Property(e => e.ClientId)
                .HasMaxLength(255)
                .HasColumnName("client_id");
            entity.Property(e => e.ScopeId)
                .HasMaxLength(255)
                .HasColumnName("scope_id");
            entity.Property(e => e.DefaultScope)
                .HasDefaultValue(false)
                .HasColumnName("default_scope");
        });

        modelBuilder.Entity<ClientScopeRoleMapping>(entity =>
        {
            entity.HasKey(e => new { e.ScopeId, e.RoleId }).HasName("pk_template_scope");

            entity.ToTable("client_scope_role_mapping", "auth");

            entity.HasIndex(e => e.ScopeId, "idx_clscope_role");

            entity.HasIndex(e => e.RoleId, "idx_role_clscope");

            entity.Property(e => e.ScopeId)
                .HasMaxLength(36)
                .HasColumnName("scope_id");
            entity.Property(e => e.RoleId)
                .HasMaxLength(36)
                .HasColumnName("role_id");

            entity.HasOne(d => d.Scope).WithMany(p => p.ClientScopeRoleMappings)
                .HasForeignKey(d => d.ScopeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_cl_scope_rm_scope");
        });

        modelBuilder.Entity<Component>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("constr_component_pk");

            entity.ToTable("component", "auth");

            entity.HasIndex(e => e.ProviderType, "idx_component_provider_type");

            entity.HasIndex(e => e.RealmId, "idx_component_realm");

            entity.Property(e => e.Id)
                .HasMaxLength(36)
                .HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.ParentId)
                .HasMaxLength(36)
                .HasColumnName("parent_id");
            entity.Property(e => e.ProviderId)
                .HasMaxLength(36)
                .HasColumnName("provider_id");
            entity.Property(e => e.ProviderType)
                .HasMaxLength(255)
                .HasColumnName("provider_type");
            entity.Property(e => e.RealmId)
                .HasMaxLength(36)
                .HasColumnName("realm_id");
            entity.Property(e => e.SubType)
                .HasMaxLength(255)
                .HasColumnName("sub_type");

            entity.HasOne(d => d.Realm).WithMany(p => p.Components)
                .HasForeignKey(d => d.RealmId)
                .HasConstraintName("fk_component_realm");
        });

        modelBuilder.Entity<ComponentConfig>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("constr_component_config_pk");

            entity.ToTable("component_config", "auth");

            entity.HasIndex(e => e.ComponentId, "idx_compo_config_compo");

            entity.Property(e => e.Id)
                .HasMaxLength(36)
                .HasColumnName("id");
            entity.Property(e => e.ComponentId)
                .IsRequired()
                .HasMaxLength(36)
                .HasColumnName("component_id");
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Value).HasColumnName("value");

            entity.HasOne(d => d.Component).WithMany(p => p.ComponentConfigs)
                .HasForeignKey(d => d.ComponentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_component_config");
        });

        modelBuilder.Entity<Credential>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("constraint_f");

            entity.ToTable("credential", "auth");

            entity.HasIndex(e => e.UserId, "idx_user_credential");

            entity.Property(e => e.Id)
                .HasMaxLength(36)
                .HasColumnName("id");
            entity.Property(e => e.CreatedDate).HasColumnName("created_date");
            entity.Property(e => e.CredentialData).HasColumnName("credential_data");
            entity.Property(e => e.Priority).HasColumnName("priority");
            entity.Property(e => e.Salt).HasColumnName("salt");
            entity.Property(e => e.SecretData).HasColumnName("secret_data");
            entity.Property(e => e.Type)
                .HasMaxLength(255)
                .HasColumnName("type");
            entity.Property(e => e.UserId)
                .HasMaxLength(36)
                .HasColumnName("user_id");
            entity.Property(e => e.UserLabel)
                .HasMaxLength(255)
                .HasColumnName("user_label");

            entity.HasOne(d => d.User).WithMany(p => p.Credentials)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("fk_pfyr0glasqyl0dei3kl69r6v0");
        });

        modelBuilder.Entity<Databasechangelog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("databasechangelog", "auth");

            entity.Property(e => e.Author)
                .IsRequired()
                .HasMaxLength(255)
                .HasColumnName("author");
            entity.Property(e => e.Comments)
                .HasMaxLength(255)
                .HasColumnName("comments");
            entity.Property(e => e.Contexts)
                .HasMaxLength(255)
                .HasColumnName("contexts");
            entity.Property(e => e.Dateexecuted)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("dateexecuted");
            entity.Property(e => e.DeploymentId)
                .HasMaxLength(10)
                .HasColumnName("deployment_id");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .HasColumnName("description");
            entity.Property(e => e.Exectype)
                .IsRequired()
                .HasMaxLength(10)
                .HasColumnName("exectype");
            entity.Property(e => e.Filename)
                .IsRequired()
                .HasMaxLength(255)
                .HasColumnName("filename");
            entity.Property(e => e.Id)
                .IsRequired()
                .HasMaxLength(255)
                .HasColumnName("id");
            entity.Property(e => e.Labels)
                .HasMaxLength(255)
                .HasColumnName("labels");
            entity.Property(e => e.Liquibase)
                .HasMaxLength(20)
                .HasColumnName("liquibase");
            entity.Property(e => e.Md5sum)
                .HasMaxLength(35)
                .HasColumnName("md5sum");
            entity.Property(e => e.Orderexecuted).HasColumnName("orderexecuted");
            entity.Property(e => e.Tag)
                .HasMaxLength(255)
                .HasColumnName("tag");
        });

        modelBuilder.Entity<Databasechangeloglock>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("databasechangeloglock_pkey");

            entity.ToTable("databasechangeloglock", "auth");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Locked).HasColumnName("locked");
            entity.Property(e => e.Lockedby)
                .HasMaxLength(255)
                .HasColumnName("lockedby");
            entity.Property(e => e.Lockgranted)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("lockgranted");
        });

        modelBuilder.Entity<DefaultClientScope>(entity =>
        {
            entity.HasKey(e => new { e.RealmId, e.ScopeId }).HasName("r_def_cli_scope_bind");

            entity.ToTable("default_client_scope", "auth");

            entity.HasIndex(e => e.RealmId, "idx_defcls_realm");

            entity.HasIndex(e => e.ScopeId, "idx_defcls_scope");

            entity.Property(e => e.RealmId)
                .HasMaxLength(36)
                .HasColumnName("realm_id");
            entity.Property(e => e.ScopeId)
                .HasMaxLength(36)
                .HasColumnName("scope_id");
            entity.Property(e => e.DefaultScope)
                .HasDefaultValue(false)
                .HasColumnName("default_scope");

            entity.HasOne(d => d.Realm).WithMany(p => p.DefaultClientScopes)
                .HasForeignKey(d => d.RealmId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_r_def_cli_scope_realm");
        });

        modelBuilder.Entity<EventEntity>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("constraint_4");

            entity.ToTable("event_entity", "auth");

            entity.HasIndex(e => new { e.RealmId, e.EventTime }, "idx_event_time");

            entity.Property(e => e.Id)
                .HasMaxLength(36)
                .HasColumnName("id");
            entity.Property(e => e.ClientId)
                .HasMaxLength(255)
                .HasColumnName("client_id");
            entity.Property(e => e.DetailsJson)
                .HasMaxLength(2550)
                .HasColumnName("details_json");
            entity.Property(e => e.DetailsJsonLongValue).HasColumnName("details_json_long_value");
            entity.Property(e => e.Error)
                .HasMaxLength(255)
                .HasColumnName("error");
            entity.Property(e => e.EventTime).HasColumnName("event_time");
            entity.Property(e => e.IpAddress)
                .HasMaxLength(255)
                .HasColumnName("ip_address");
            entity.Property(e => e.RealmId)
                .HasMaxLength(255)
                .HasColumnName("realm_id");
            entity.Property(e => e.SessionId)
                .HasMaxLength(255)
                .HasColumnName("session_id");
            entity.Property(e => e.Type)
                .HasMaxLength(255)
                .HasColumnName("type");
            entity.Property(e => e.UserId)
                .HasMaxLength(255)
                .HasColumnName("user_id");
        });

        modelBuilder.Entity<FedUserAttribute>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("constr_fed_user_attr_pk");

            entity.ToTable("fed_user_attribute", "auth");

            entity.HasIndex(e => new { e.LongValueHash, e.Name }, "fed_user_attr_long_values");

            entity.HasIndex(e => new { e.LongValueHashLowerCase, e.Name }, "fed_user_attr_long_values_lower_case");

            entity.HasIndex(e => new { e.UserId, e.RealmId, e.Name }, "idx_fu_attribute");

            entity.Property(e => e.Id)
                .HasMaxLength(36)
                .HasColumnName("id");
            entity.Property(e => e.LongValue).HasColumnName("long_value");
            entity.Property(e => e.LongValueHash).HasColumnName("long_value_hash");
            entity.Property(e => e.LongValueHashLowerCase).HasColumnName("long_value_hash_lower_case");
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.RealmId)
                .IsRequired()
                .HasMaxLength(36)
                .HasColumnName("realm_id");
            entity.Property(e => e.StorageProviderId)
                .HasMaxLength(36)
                .HasColumnName("storage_provider_id");
            entity.Property(e => e.UserId)
                .IsRequired()
                .HasMaxLength(255)
                .HasColumnName("user_id");
            entity.Property(e => e.Value)
                .HasMaxLength(2024)
                .HasColumnName("value");
        });

        modelBuilder.Entity<FedUserConsent>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("constr_fed_user_consent_pk");

            entity.ToTable("fed_user_consent", "auth");

            entity.HasIndex(e => new { e.UserId, e.ClientStorageProvider, e.ExternalClientId }, "idx_fu_cnsnt_ext");

            entity.HasIndex(e => new { e.UserId, e.ClientId }, "idx_fu_consent");

            entity.HasIndex(e => new { e.RealmId, e.UserId }, "idx_fu_consent_ru");

            entity.Property(e => e.Id)
                .HasMaxLength(36)
                .HasColumnName("id");
            entity.Property(e => e.ClientId)
                .HasMaxLength(255)
                .HasColumnName("client_id");
            entity.Property(e => e.ClientStorageProvider)
                .HasMaxLength(36)
                .HasColumnName("client_storage_provider");
            entity.Property(e => e.CreatedDate).HasColumnName("created_date");
            entity.Property(e => e.ExternalClientId)
                .HasMaxLength(255)
                .HasColumnName("external_client_id");
            entity.Property(e => e.LastUpdatedDate).HasColumnName("last_updated_date");
            entity.Property(e => e.RealmId)
                .IsRequired()
                .HasMaxLength(36)
                .HasColumnName("realm_id");
            entity.Property(e => e.StorageProviderId)
                .HasMaxLength(36)
                .HasColumnName("storage_provider_id");
            entity.Property(e => e.UserId)
                .IsRequired()
                .HasMaxLength(255)
                .HasColumnName("user_id");
        });

        modelBuilder.Entity<FedUserConsentClScope>(entity =>
        {
            entity.HasKey(e => new { e.UserConsentId, e.ScopeId }).HasName("constraint_fgrntcsnt_clsc_pm");

            entity.ToTable("fed_user_consent_cl_scope", "auth");

            entity.Property(e => e.UserConsentId)
                .HasMaxLength(36)
                .HasColumnName("user_consent_id");
            entity.Property(e => e.ScopeId)
                .HasMaxLength(36)
                .HasColumnName("scope_id");
        });

        modelBuilder.Entity<FedUserCredential>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("constr_fed_user_cred_pk");

            entity.ToTable("fed_user_credential", "auth");

            entity.HasIndex(e => new { e.UserId, e.Type }, "idx_fu_credential");

            entity.HasIndex(e => new { e.RealmId, e.UserId }, "idx_fu_credential_ru");

            entity.Property(e => e.Id)
                .HasMaxLength(36)
                .HasColumnName("id");
            entity.Property(e => e.CreatedDate).HasColumnName("created_date");
            entity.Property(e => e.CredentialData).HasColumnName("credential_data");
            entity.Property(e => e.Priority).HasColumnName("priority");
            entity.Property(e => e.RealmId)
                .IsRequired()
                .HasMaxLength(36)
                .HasColumnName("realm_id");
            entity.Property(e => e.Salt).HasColumnName("salt");
            entity.Property(e => e.SecretData).HasColumnName("secret_data");
            entity.Property(e => e.StorageProviderId)
                .HasMaxLength(36)
                .HasColumnName("storage_provider_id");
            entity.Property(e => e.Type)
                .HasMaxLength(255)
                .HasColumnName("type");
            entity.Property(e => e.UserId)
                .IsRequired()
                .HasMaxLength(255)
                .HasColumnName("user_id");
            entity.Property(e => e.UserLabel)
                .HasMaxLength(255)
                .HasColumnName("user_label");
        });

        modelBuilder.Entity<FedUserGroupMembership>(entity =>
        {
            entity.HasKey(e => new { e.GroupId, e.UserId }).HasName("constr_fed_user_group");

            entity.ToTable("fed_user_group_membership", "auth");

            entity.HasIndex(e => new { e.UserId, e.GroupId }, "idx_fu_group_membership");

            entity.HasIndex(e => new { e.RealmId, e.UserId }, "idx_fu_group_membership_ru");

            entity.Property(e => e.GroupId)
                .HasMaxLength(36)
                .HasColumnName("group_id");
            entity.Property(e => e.UserId)
                .HasMaxLength(255)
                .HasColumnName("user_id");
            entity.Property(e => e.RealmId)
                .IsRequired()
                .HasMaxLength(36)
                .HasColumnName("realm_id");
            entity.Property(e => e.StorageProviderId)
                .HasMaxLength(36)
                .HasColumnName("storage_provider_id");
        });

        modelBuilder.Entity<FedUserRequiredAction>(entity =>
        {
            entity.HasKey(e => new { e.RequiredAction, e.UserId }).HasName("constr_fed_required_action");

            entity.ToTable("fed_user_required_action", "auth");

            entity.HasIndex(e => new { e.UserId, e.RequiredAction }, "idx_fu_required_action");

            entity.HasIndex(e => new { e.RealmId, e.UserId }, "idx_fu_required_action_ru");

            entity.Property(e => e.RequiredAction)
                .HasMaxLength(255)
                .HasDefaultValueSql("' '::character varying")
                .HasColumnName("required_action");
            entity.Property(e => e.UserId)
                .HasMaxLength(255)
                .HasColumnName("user_id");
            entity.Property(e => e.RealmId)
                .IsRequired()
                .HasMaxLength(36)
                .HasColumnName("realm_id");
            entity.Property(e => e.StorageProviderId)
                .HasMaxLength(36)
                .HasColumnName("storage_provider_id");
        });

        modelBuilder.Entity<FedUserRoleMapping>(entity =>
        {
            entity.HasKey(e => new { e.RoleId, e.UserId }).HasName("constr_fed_user_role");

            entity.ToTable("fed_user_role_mapping", "auth");

            entity.HasIndex(e => new { e.UserId, e.RoleId }, "idx_fu_role_mapping");

            entity.HasIndex(e => new { e.RealmId, e.UserId }, "idx_fu_role_mapping_ru");

            entity.Property(e => e.RoleId)
                .HasMaxLength(36)
                .HasColumnName("role_id");
            entity.Property(e => e.UserId)
                .HasMaxLength(255)
                .HasColumnName("user_id");
            entity.Property(e => e.RealmId)
                .IsRequired()
                .HasMaxLength(36)
                .HasColumnName("realm_id");
            entity.Property(e => e.StorageProviderId)
                .HasMaxLength(36)
                .HasColumnName("storage_provider_id");
        });

        modelBuilder.Entity<FederatedIdentity>(entity =>
        {
            entity.HasKey(e => new { e.IdentityProvider, e.UserId }).HasName("constraint_40");

            entity.ToTable("federated_identity", "auth");

            entity.HasIndex(e => e.FederatedUserId, "idx_fedidentity_feduser");

            entity.HasIndex(e => e.UserId, "idx_fedidentity_user");

            entity.Property(e => e.IdentityProvider)
                .HasMaxLength(255)
                .HasColumnName("identity_provider");
            entity.Property(e => e.UserId)
                .HasMaxLength(36)
                .HasColumnName("user_id");
            entity.Property(e => e.FederatedUserId)
                .HasMaxLength(255)
                .HasColumnName("federated_user_id");
            entity.Property(e => e.FederatedUsername)
                .HasMaxLength(255)
                .HasColumnName("federated_username");
            entity.Property(e => e.RealmId)
                .HasMaxLength(36)
                .HasColumnName("realm_id");
            entity.Property(e => e.Token).HasColumnName("token");

            entity.HasOne(d => d.User).WithMany(p => p.FederatedIdentities)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk404288b92ef007a6");
        });

        modelBuilder.Entity<FederatedUser>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("constr_federated_user");

            entity.ToTable("federated_user", "auth");

            entity.Property(e => e.Id)
                .HasMaxLength(255)
                .HasColumnName("id");
            entity.Property(e => e.RealmId)
                .IsRequired()
                .HasMaxLength(36)
                .HasColumnName("realm_id");
            entity.Property(e => e.StorageProviderId)
                .HasMaxLength(255)
                .HasColumnName("storage_provider_id");
        });

        modelBuilder.Entity<GroupAttribute>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("constraint_group_attribute_pk");

            entity.ToTable("group_attribute", "auth");

            entity.HasIndex(e => e.GroupId, "idx_group_attr_group");

            entity.Property(e => e.Id)
                .HasMaxLength(36)
                .HasDefaultValueSql("'sybase-needs-something-here'::character varying")
                .HasColumnName("id");
            entity.Property(e => e.GroupId)
                .IsRequired()
                .HasMaxLength(36)
                .HasColumnName("group_id");
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Value)
                .HasMaxLength(255)
                .HasColumnName("value");

            entity.HasOne(d => d.Group).WithMany(p => p.GroupAttributes)
                .HasForeignKey(d => d.GroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_group_attribute_group");
        });

        modelBuilder.Entity<GroupRoleMapping>(entity =>
        {
            entity.HasKey(e => new { e.RoleId, e.GroupId }).HasName("constraint_group_role");

            entity.ToTable("group_role_mapping", "auth");

            entity.HasIndex(e => e.GroupId, "idx_group_role_mapp_group");

            entity.Property(e => e.RoleId)
                .HasMaxLength(36)
                .HasColumnName("role_id");
            entity.Property(e => e.GroupId)
                .HasMaxLength(36)
                .HasColumnName("group_id");

            entity.HasOne(d => d.Group).WithMany(p => p.GroupRoleMappings)
                .HasForeignKey(d => d.GroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_group_role_group");
        });

        modelBuilder.Entity<IdentityProvider>(entity =>
        {
            entity.HasKey(e => e.InternalId).HasName("constraint_2b");

            entity.ToTable("identity_provider", "auth");

            entity.HasIndex(e => e.RealmId, "idx_ident_prov_realm");

            entity.HasIndex(e => new { e.RealmId, e.Enabled, e.LinkOnly, e.HideOnLogin, e.OrganizationId }, "idx_idp_for_login");

            entity.HasIndex(e => new { e.RealmId, e.OrganizationId }, "idx_idp_realm_org");

            entity.HasIndex(e => new { e.ProviderAlias, e.RealmId }, "uk_2daelwnibji49avxsrtuf6xj33").IsUnique();

            entity.Property(e => e.InternalId)
                .HasMaxLength(36)
                .HasColumnName("internal_id");
            entity.Property(e => e.AddTokenRole)
                .HasDefaultValue(true)
                .HasColumnName("add_token_role");
            entity.Property(e => e.AuthenticateByDefault)
                .HasDefaultValue(false)
                .HasColumnName("authenticate_by_default");
            entity.Property(e => e.Enabled)
                .HasDefaultValue(false)
                .HasColumnName("enabled");
            entity.Property(e => e.FirstBrokerLoginFlowId)
                .HasMaxLength(36)
                .HasColumnName("first_broker_login_flow_id");
            entity.Property(e => e.HideOnLogin)
                .HasDefaultValue(false)
                .HasColumnName("hide_on_login");
            entity.Property(e => e.LinkOnly)
                .HasDefaultValue(false)
                .HasColumnName("link_only");
            entity.Property(e => e.OrganizationId)
                .HasMaxLength(255)
                .HasColumnName("organization_id");
            entity.Property(e => e.PostBrokerLoginFlowId)
                .HasMaxLength(36)
                .HasColumnName("post_broker_login_flow_id");
            entity.Property(e => e.ProviderAlias)
                .HasMaxLength(255)
                .HasColumnName("provider_alias");
            entity.Property(e => e.ProviderDisplayName)
                .HasMaxLength(255)
                .HasColumnName("provider_display_name");
            entity.Property(e => e.ProviderId)
                .HasMaxLength(255)
                .HasColumnName("provider_id");
            entity.Property(e => e.RealmId)
                .HasMaxLength(36)
                .HasColumnName("realm_id");
            entity.Property(e => e.StoreToken)
                .HasDefaultValue(false)
                .HasColumnName("store_token");
            entity.Property(e => e.TrustEmail)
                .HasDefaultValue(false)
                .HasColumnName("trust_email");

            entity.HasOne(d => d.Realm).WithMany(p => p.IdentityProviders)
                .HasForeignKey(d => d.RealmId)
                .HasConstraintName("fk2b4ebc52ae5c3b34");
        });

        modelBuilder.Entity<IdentityProviderConfig>(entity =>
        {
            entity.HasKey(e => new { e.IdentityProviderId, e.Name }).HasName("constraint_d");

            entity.ToTable("identity_provider_config", "auth");

            entity.Property(e => e.IdentityProviderId)
                .HasMaxLength(36)
                .HasColumnName("identity_provider_id");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Value).HasColumnName("value");

            entity.HasOne(d => d.IdentityProvider).WithMany(p => p.IdentityProviderConfigs)
                .HasForeignKey(d => d.IdentityProviderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fkdc4897cf864c4e43");
        });

        modelBuilder.Entity<IdentityProviderMapper>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("constraint_idpm");

            entity.ToTable("identity_provider_mapper", "auth");

            entity.HasIndex(e => e.RealmId, "idx_id_prov_mapp_realm");

            entity.Property(e => e.Id)
                .HasMaxLength(36)
                .HasColumnName("id");
            entity.Property(e => e.IdpAlias)
                .IsRequired()
                .HasMaxLength(255)
                .HasColumnName("idp_alias");
            entity.Property(e => e.IdpMapperName)
                .IsRequired()
                .HasMaxLength(255)
                .HasColumnName("idp_mapper_name");
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.RealmId)
                .IsRequired()
                .HasMaxLength(36)
                .HasColumnName("realm_id");

            entity.HasOne(d => d.Realm).WithMany(p => p.IdentityProviderMappers)
                .HasForeignKey(d => d.RealmId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_idpm_realm");
        });

        modelBuilder.Entity<IdpMapperConfig>(entity =>
        {
            entity.HasKey(e => new { e.IdpMapperId, e.Name }).HasName("constraint_idpmconfig");

            entity.ToTable("idp_mapper_config", "auth");

            entity.Property(e => e.IdpMapperId)
                .HasMaxLength(36)
                .HasColumnName("idp_mapper_id");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Value).HasColumnName("value");

            entity.HasOne(d => d.IdpMapper).WithMany(p => p.IdpMapperConfigs)
                .HasForeignKey(d => d.IdpMapperId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_idpmconfig");
        });

        modelBuilder.Entity<KeycloakGroup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("constraint_group");

            entity.ToTable("keycloak_group", "auth");

            entity.HasIndex(e => new { e.RealmId, e.ParentGroup, e.Name }, "sibling_names").IsUnique();

            entity.Property(e => e.Id)
                .HasMaxLength(36)
                .HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.ParentGroup)
                .IsRequired()
                .HasMaxLength(36)
                .HasColumnName("parent_group");
            entity.Property(e => e.RealmId)
                .HasMaxLength(36)
                .HasColumnName("realm_id");
            entity.Property(e => e.Type)
                .HasDefaultValue(0)
                .HasColumnName("type");
        });

        modelBuilder.Entity<KeycloakRole>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("constraint_a");

            entity.ToTable("keycloak_role", "auth");

            entity.HasIndex(e => new { e.Name, e.ClientRealmConstraint }, "UK_J3RWUVD56ONTGSUHOGM184WW2-2").IsUnique();

            entity.HasIndex(e => e.Client, "idx_keycloak_role_client");

            entity.HasIndex(e => e.Realm, "idx_keycloak_role_realm");

            entity.Property(e => e.Id)
                .HasMaxLength(36)
                .HasColumnName("id");
            entity.Property(e => e.Client)
                .HasMaxLength(36)
                .HasColumnName("client");
            entity.Property(e => e.ClientRealmConstraint)
                .HasMaxLength(255)
                .HasColumnName("client_realm_constraint");
            entity.Property(e => e.ClientRole)
                .HasDefaultValue(false)
                .HasColumnName("client_role");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .HasColumnName("description");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Realm)
                .HasMaxLength(36)
                .HasColumnName("realm");
            entity.Property(e => e.RealmId)
                .HasMaxLength(255)
                .HasColumnName("realm_id");

            entity.HasOne(d => d.RealmNavigation).WithMany(p => p.KeycloakRoles)
                .HasForeignKey(d => d.Realm)
                .HasConstraintName("fk_6vyqfe4cn4wlq8r6kt5vdsj5c");

            entity.HasMany(d => d.ChildRoles).WithMany(p => p.Composites)
                .UsingEntity<Dictionary<string, object>>(
                    "CompositeRole",
                    r => r.HasOne<KeycloakRole>().WithMany()
                        .HasForeignKey("ChildRole")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("fk_gr7thllb9lu8q4vqa4524jjy8"),
                    l => l.HasOne<KeycloakRole>().WithMany()
                        .HasForeignKey("Composite")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("fk_a63wvekftu8jo1pnj81e7mce2"),
                    j =>
                    {
                        j.HasKey("Composite", "ChildRole").HasName("constraint_composite_role");
                        j.ToTable("composite_role", "auth");
                        j.HasIndex(new[] { "Composite" }, "idx_composite");
                        j.HasIndex(new[] { "ChildRole" }, "idx_composite_child");
                        j.IndexerProperty<string>("Composite")
                            .HasMaxLength(36)
                            .HasColumnName("composite");
                        j.IndexerProperty<string>("ChildRole")
                            .HasMaxLength(36)
                            .HasColumnName("child_role");
                    });

            entity.HasMany(d => d.Composites).WithMany(p => p.ChildRoles)
                .UsingEntity<Dictionary<string, object>>(
                    "CompositeRole",
                    r => r.HasOne<KeycloakRole>().WithMany()
                        .HasForeignKey("Composite")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("fk_a63wvekftu8jo1pnj81e7mce2"),
                    l => l.HasOne<KeycloakRole>().WithMany()
                        .HasForeignKey("ChildRole")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("fk_gr7thllb9lu8q4vqa4524jjy8"),
                    j =>
                    {
                        j.HasKey("Composite", "ChildRole").HasName("constraint_composite_role");
                        j.ToTable("composite_role", "auth");
                        j.HasIndex(new[] { "Composite" }, "idx_composite");
                        j.HasIndex(new[] { "ChildRole" }, "idx_composite_child");
                        j.IndexerProperty<string>("Composite")
                            .HasMaxLength(36)
                            .HasColumnName("composite");
                        j.IndexerProperty<string>("ChildRole")
                            .HasMaxLength(36)
                            .HasColumnName("child_role");
                    });
        });

        modelBuilder.Entity<MigrationModel>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("constraint_migmod");

            entity.ToTable("migration_model", "auth");

            entity.HasIndex(e => e.UpdateTime, "idx_update_time");

            entity.Property(e => e.Id)
                .HasMaxLength(36)
                .HasColumnName("id");
            entity.Property(e => e.UpdateTime)
                .HasDefaultValue(0L)
                .HasColumnName("update_time");
            entity.Property(e => e.Version)
                .HasMaxLength(36)
                .HasColumnName("version");
        });

        modelBuilder.Entity<OfflineClientSession>(entity =>
        {
            entity.HasKey(e => new { e.UserSessionId, e.ClientId, e.ClientStorageProvider, e.ExternalClientId, e.OfflineFlag }).HasName("constraint_offl_cl_ses_pk3");

            entity.ToTable("offline_client_session", "auth");

            entity.Property(e => e.UserSessionId)
                .HasMaxLength(36)
                .HasColumnName("user_session_id");
            entity.Property(e => e.ClientId)
                .HasMaxLength(255)
                .HasColumnName("client_id");
            entity.Property(e => e.ClientStorageProvider)
                .HasMaxLength(36)
                .HasDefaultValueSql("'local'::character varying")
                .HasColumnName("client_storage_provider");
            entity.Property(e => e.ExternalClientId)
                .HasMaxLength(255)
                .HasDefaultValueSql("'local'::character varying")
                .HasColumnName("external_client_id");
            entity.Property(e => e.OfflineFlag)
                .HasMaxLength(4)
                .HasColumnName("offline_flag");
            entity.Property(e => e.Data).HasColumnName("data");
            entity.Property(e => e.Timestamp).HasColumnName("timestamp");
            entity.Property(e => e.Version)
                .HasDefaultValue(0)
                .HasColumnName("version");
        });

        modelBuilder.Entity<OfflineUserSession>(entity =>
        {
            entity.HasKey(e => new { e.UserSessionId, e.OfflineFlag }).HasName("constraint_offl_us_ses_pk2");

            entity.ToTable("offline_user_session", "auth");

            entity.HasIndex(e => new { e.BrokerSessionId, e.RealmId }, "idx_offline_uss_by_broker_session_id");

            entity.HasIndex(e => new { e.RealmId, e.OfflineFlag, e.LastSessionRefresh }, "idx_offline_uss_by_last_session_refresh");

            entity.HasIndex(e => new { e.UserId, e.RealmId, e.OfflineFlag }, "idx_offline_uss_by_user");

            entity.Property(e => e.UserSessionId)
                .HasMaxLength(36)
                .HasColumnName("user_session_id");
            entity.Property(e => e.OfflineFlag)
                .HasMaxLength(4)
                .HasColumnName("offline_flag");
            entity.Property(e => e.BrokerSessionId)
                .HasMaxLength(1024)
                .HasColumnName("broker_session_id");
            entity.Property(e => e.CreatedOn).HasColumnName("created_on");
            entity.Property(e => e.Data).HasColumnName("data");
            entity.Property(e => e.LastSessionRefresh)
                .HasDefaultValue(0)
                .HasColumnName("last_session_refresh");
            entity.Property(e => e.RealmId)
                .IsRequired()
                .HasMaxLength(36)
                .HasColumnName("realm_id");
            entity.Property(e => e.UserId)
                .IsRequired()
                .HasMaxLength(255)
                .HasColumnName("user_id");
            entity.Property(e => e.Version)
                .HasDefaultValue(0)
                .HasColumnName("version");
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("order_pkey");

            entity.ToTable("order", "order");

            entity.HasIndex(e => e.TransactionNo, "order_transaction_no_key").IsUnique();

            entity.Property(e => e.Id)
                .HasDefaultValueSql("uuid_generate_v4()")
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("created_at");
            entity.Property(e => e.CustomerName)
                .IsRequired()
                .HasMaxLength(255)
                .HasColumnName("customer_name");
            entity.Property(e => e.RealmId)
                .IsRequired()
                .HasMaxLength(36)
                .HasColumnName("realm_id");
            entity.Property(e => e.ShipmentFee)
                .HasPrecision(10, 2)
                .HasColumnName("shipment_fee");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .HasDefaultValueSql("'pending'::character varying")
                .HasColumnName("status");
            entity.Property(e => e.TotalAmount)
                .HasPrecision(10, 2)
                .HasColumnName("total_amount");
            entity.Property(e => e.TransactionNo)
                .IsRequired()
                .HasMaxLength(20)
                .HasColumnName("transaction_no");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("updated_at");
            entity.Property(e => e.UserId)
                .IsRequired()
                .HasMaxLength(36)
                .HasColumnName("user_id");

            entity.HasOne(d => d.Realm).WithMany(p => p.Orders)
                .HasForeignKey(d => d.RealmId)
                .HasConstraintName("order_realm_id_fkey");

            entity.HasOne(d => d.User).WithMany(p => p.Orders)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("order_user_id_fkey");
        });

        modelBuilder.Entity<OrderInvoice>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("order_invoice_pkey");

            entity.ToTable("order_invoice", "order");

            entity.HasIndex(e => e.InvoiceNumber, "order_invoice_invoice_number_key").IsUnique();

            entity.Property(e => e.Id)
                .HasDefaultValueSql("uuid_generate_v4()")
                .HasColumnName("id");
            entity.Property(e => e.Amount)
                .HasPrecision(10, 2)
                .HasColumnName("amount");
            entity.Property(e => e.CarrierNo)
                .HasMaxLength(255)
                .HasColumnName("carrier_no");
            entity.Property(e => e.CompanyName)
                .HasMaxLength(255)
                .HasColumnName("company_name");
            entity.Property(e => e.CompanyNo)
                .HasMaxLength(255)
                .HasColumnName("company_no");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("created_at");
            entity.Property(e => e.InvoiceNumber)
                .IsRequired()
                .HasMaxLength(255)
                .HasColumnName("invoice_number");
            entity.Property(e => e.InvoiceType)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("invoice_type");
            entity.Property(e => e.IssueDate)
                .HasDefaultValueSql("now()")
                .HasColumnName("issue_date");
            entity.Property(e => e.OrderId).HasColumnName("order_id");
            entity.Property(e => e.RealmId)
                .IsRequired()
                .HasMaxLength(36)
                .HasColumnName("realm_id");
            entity.Property(e => e.ServiceProvider)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("service_provider");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .HasDefaultValueSql("'issued'::character varying")
                .HasColumnName("status");
            entity.Property(e => e.Tax)
                .HasPrecision(10, 2)
                .HasColumnName("tax");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("updated_at");
            entity.Property(e => e.VoidDate).HasColumnName("void_date");

            entity.HasOne(d => d.Order).WithMany(p => p.OrderInvoices)
                .HasForeignKey(d => d.OrderId)
                .HasConstraintName("order_invoice_order_id_fkey");

            entity.HasOne(d => d.Realm).WithMany(p => p.OrderInvoices)
                .HasForeignKey(d => d.RealmId)
                .HasConstraintName("order_invoice_realm_id_fkey");
        });

        modelBuilder.Entity<OrderInvoiceItem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("order_invoice_item_pkey");

            entity.ToTable("order_invoice_item", "order");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("uuid_generate_v4()")
                .HasColumnName("id");
            entity.Property(e => e.Amount)
                .HasPrecision(10, 2)
                .HasComputedColumnSql("((quantity)::numeric * unit_price)", true)
                .HasColumnName("amount");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("created_at");
            entity.Property(e => e.OrderInvoiceId).HasColumnName("order_invoice_id");
            entity.Property(e => e.ProductName)
                .IsRequired()
                .HasMaxLength(255)
                .HasColumnName("product_name");
            entity.Property(e => e.Quantity)
                .HasDefaultValue(1)
                .HasColumnName("quantity");
            entity.Property(e => e.Remark).HasColumnName("remark");
            entity.Property(e => e.TaxType)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("tax_type");
            entity.Property(e => e.UnitPrice)
                .HasPrecision(10, 2)
                .HasColumnName("unit_price");
            entity.Property(e => e.UnitWord)
                .HasMaxLength(255)
                .HasColumnName("unit_word");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("updated_at");

            entity.HasOne(d => d.OrderInvoice).WithMany(p => p.OrderInvoiceItems)
                .HasForeignKey(d => d.OrderInvoiceId)
                .HasConstraintName("order_invoice_item_order_invoice_id_fkey");
        });

        modelBuilder.Entity<OrderInvoiceStatusHistory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("order_invoice_status_history_pkey");

            entity.ToTable("order_invoice_status_history", "order");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("uuid_generate_v4()")
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("created_at");
            entity.Property(e => e.FromStatus)
                .HasMaxLength(50)
                .HasColumnName("from_status");
            entity.Property(e => e.OrderInvoiceId).HasColumnName("order_invoice_id");
            entity.Property(e => e.Reason)
                .HasMaxLength(50)
                .HasColumnName("reason");
            entity.Property(e => e.ReasonData)
                .HasColumnType("jsonb")
                .HasColumnName("reason_data");
            entity.Property(e => e.ToStatus)
                .HasMaxLength(50)
                .HasDefaultValueSql("'issued'::character varying")
                .HasColumnName("to_status");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("updated_at");

            entity.HasOne(d => d.OrderInvoice).WithMany(p => p.OrderInvoiceStatusHistories)
                .HasForeignKey(d => d.OrderInvoiceId)
                .HasConstraintName("order_invoice_status_history_order_invoice_id_fkey");
        });

        modelBuilder.Entity<OrderItem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("order_item_pkey");

            entity.ToTable("order_item", "order");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("uuid_generate_v4()")
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("created_at");
            entity.Property(e => e.OrderId).HasColumnName("order_id");
            entity.Property(e => e.Price)
                .HasPrecision(10, 2)
                .HasColumnName("price");
            entity.Property(e => e.ProductSkuId).HasColumnName("product_sku_id");
            entity.Property(e => e.Quantity)
                .HasDefaultValue(1)
                .HasColumnName("quantity");
            entity.Property(e => e.SnapshotVersion)
                .HasDefaultValueSql("now()")
                .HasColumnName("snapshot_version");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("updated_at");

            entity.HasOne(d => d.Order).WithMany(p => p.OrderItems)
                .HasForeignKey(d => d.OrderId)
                .HasConstraintName("order_item_order_id_fkey");

            entity.HasOne(d => d.ProductSku).WithMany(p => p.OrderItems)
                .HasForeignKey(d => d.ProductSkuId)
                .HasConstraintName("order_item_product_sku_id_fkey");
        });

        modelBuilder.Entity<OrderItemCargoMap>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("order_item_cargo_map", "order");

            entity.Property(e => e.OrderItemId).HasColumnName("order_item_id");
            entity.Property(e => e.OrderShipmentCargoId).HasColumnName("order_shipment_cargo_id");
            entity.Property(e => e.Quantity)
                .HasDefaultValue(1)
                .HasColumnName("quantity");

            entity.HasOne(d => d.OrderItem).WithMany()
                .HasForeignKey(d => d.OrderItemId)
                .HasConstraintName("order_item_cargo_map_order_item_id_fkey");

            entity.HasOne(d => d.OrderShipmentCargo).WithMany()
                .HasForeignKey(d => d.OrderShipmentCargoId)
                .HasConstraintName("order_item_cargo_map_order_shipment_cargo_id_fkey");
        });

        modelBuilder.Entity<OrderPayment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("order_payment_pkey");

            entity.ToTable("order_payment", "order");

            entity.HasIndex(e => e.PaymentNumber, "order_payment_payment_number_key").IsUnique();

            entity.Property(e => e.Id)
                .HasDefaultValueSql("uuid_generate_v4()")
                .HasColumnName("id");
            entity.Property(e => e.Amount)
                .HasPrecision(10, 2)
                .HasColumnName("amount");
            entity.Property(e => e.AtmPayNo)
                .HasMaxLength(255)
                .HasColumnName("atm_pay_no");
            entity.Property(e => e.CheckMacValue)
                .HasMaxLength(255)
                .HasColumnName("check_mac_value");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("created_at");
            entity.Property(e => e.MerchantId)
                .IsRequired()
                .HasMaxLength(255)
                .HasColumnName("merchant_id");
            entity.Property(e => e.OrderId).HasColumnName("order_id");
            entity.Property(e => e.OrderResultUrl)
                .IsRequired()
                .HasMaxLength(255)
                .HasColumnName("order_result_url");
            entity.Property(e => e.PaymentMethod)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("payment_method");
            entity.Property(e => e.PaymentNumber)
                .IsRequired()
                .HasMaxLength(255)
                .HasColumnName("payment_number");
            entity.Property(e => e.RealmId)
                .IsRequired()
                .HasMaxLength(36)
                .HasColumnName("realm_id");
            entity.Property(e => e.ReturnUrl)
                .IsRequired()
                .HasMaxLength(255)
                .HasColumnName("return_url");
            entity.Property(e => e.ServiceProvider)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("service_provider");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .HasDefaultValueSql("'pending'::character varying")
                .HasColumnName("status");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("updated_at");

            entity.HasOne(d => d.Order).WithMany(p => p.OrderPayments)
                .HasForeignKey(d => d.OrderId)
                .HasConstraintName("order_payment_order_id_fkey");

            entity.HasOne(d => d.Realm).WithMany(p => p.OrderPayments)
                .HasForeignKey(d => d.RealmId)
                .HasConstraintName("order_payment_realm_id_fkey");
        });

        modelBuilder.Entity<OrderShipment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("order_shipment_pkey");

            entity.ToTable("order_shipment", "order");

            entity.HasIndex(e => e.TrackingNumber, "order_shipment_tracking_number_key").IsUnique();

            entity.Property(e => e.Id)
                .HasDefaultValueSql("uuid_generate_v4()")
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("created_at");
            entity.Property(e => e.OrderId).HasColumnName("order_id");
            entity.Property(e => e.RealmId)
                .IsRequired()
                .HasMaxLength(36)
                .HasColumnName("realm_id");
            entity.Property(e => e.ReceiverAddress)
                .HasMaxLength(255)
                .HasColumnName("receiver_address");
            entity.Property(e => e.ReceiverName)
                .HasMaxLength(100)
                .HasColumnName("receiver_name");
            entity.Property(e => e.ReceiverPhone)
                .HasMaxLength(100)
                .HasColumnName("receiver_phone");
            entity.Property(e => e.SenderName)
                .HasMaxLength(100)
                .HasColumnName("sender_name");
            entity.Property(e => e.SenderPhone)
                .HasMaxLength(100)
                .HasColumnName("sender_phone");
            entity.Property(e => e.ServiceProvider)
                .HasMaxLength(50)
                .HasColumnName("service_provider");
            entity.Property(e => e.ServiceType)
                .HasMaxLength(50)
                .HasColumnName("service_type");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .HasDefaultValueSql("'pending'::character varying")
                .HasColumnName("status");
            entity.Property(e => e.TemperatureZone)
                .HasMaxLength(50)
                .HasColumnName("temperature_zone");
            entity.Property(e => e.TrackingNumber)
                .IsRequired()
                .HasMaxLength(255)
                .HasColumnName("tracking_number");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("updated_at");

            entity.HasOne(d => d.Order).WithMany(p => p.OrderShipments)
                .HasForeignKey(d => d.OrderId)
                .HasConstraintName("order_shipment_order_id_fkey");

            entity.HasOne(d => d.Realm).WithMany(p => p.OrderShipments)
                .HasForeignKey(d => d.RealmId)
                .HasConstraintName("order_shipment_realm_id_fkey");
        });

        modelBuilder.Entity<OrderShipmentCargo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("order_shipment_cargo_pkey");

            entity.ToTable("order_shipment_cargo", "order");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("uuid_generate_v4()")
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("created_at");
            entity.Property(e => e.Height)
                .HasPrecision(10, 2)
                .HasColumnName("height");
            entity.Property(e => e.Length)
                .HasPrecision(10, 2)
                .HasColumnName("length");
            entity.Property(e => e.OrderShipmentId).HasColumnName("order_shipment_id");
            entity.Property(e => e.TrackingNumber)
                .HasMaxLength(255)
                .HasColumnName("tracking_number");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("updated_at");
            entity.Property(e => e.Volume)
                .HasPrecision(10, 2)
                .HasComputedColumnSql("((length * width) * height)", true)
                .HasColumnName("volume");
            entity.Property(e => e.Weight)
                .HasPrecision(10, 2)
                .HasColumnName("weight");
            entity.Property(e => e.Width)
                .HasPrecision(10, 2)
                .HasColumnName("width");

            entity.HasOne(d => d.OrderShipment).WithMany(p => p.OrderShipmentCargos)
                .HasForeignKey(d => d.OrderShipmentId)
                .HasConstraintName("order_shipment_cargo_order_shipment_id_fkey");
        });

        modelBuilder.Entity<OrderStatusHistory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("order_status_history_pkey");

            entity.ToTable("order_status_history", "order");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("uuid_generate_v4()")
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("created_at");
            entity.Property(e => e.CreaterId)
                .IsRequired()
                .HasMaxLength(36)
                .HasColumnName("creater_id");
            entity.Property(e => e.FromStatus)
                .HasMaxLength(50)
                .HasColumnName("from_status");
            entity.Property(e => e.OrderId).HasColumnName("order_id");
            entity.Property(e => e.Reason)
                .HasMaxLength(50)
                .HasColumnName("reason");
            entity.Property(e => e.ReasonData)
                .HasColumnType("jsonb")
                .HasColumnName("reason_data");
            entity.Property(e => e.ToStatus)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("to_status");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("updated_at");

            entity.HasOne(d => d.Order).WithMany(p => p.OrderStatusHistories)
                .HasForeignKey(d => d.OrderId)
                .HasConstraintName("order_status_history_order_id_fkey");
        });

        modelBuilder.Entity<Org>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ORG_pkey");

            entity.ToTable("org", "auth");

            entity.HasIndex(e => new { e.RealmId, e.Alias }, "uk_org_alias").IsUnique();

            entity.HasIndex(e => e.GroupId, "uk_org_group").IsUnique();

            entity.HasIndex(e => new { e.RealmId, e.Name }, "uk_org_name").IsUnique();

            entity.Property(e => e.Id)
                .HasMaxLength(255)
                .HasColumnName("id");
            entity.Property(e => e.Alias)
                .IsRequired()
                .HasMaxLength(255)
                .HasColumnName("alias");
            entity.Property(e => e.Description)
                .HasMaxLength(4000)
                .HasColumnName("description");
            entity.Property(e => e.Enabled).HasColumnName("enabled");
            entity.Property(e => e.GroupId)
                .IsRequired()
                .HasMaxLength(255)
                .HasColumnName("group_id");
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.RealmId)
                .IsRequired()
                .HasMaxLength(255)
                .HasColumnName("realm_id");
            entity.Property(e => e.RedirectUrl)
                .HasMaxLength(2048)
                .HasColumnName("redirect_url");
        });

        modelBuilder.Entity<OrgDomain>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Name }).HasName("ORG_DOMAIN_pkey");

            entity.ToTable("org_domain", "auth");

            entity.HasIndex(e => e.OrgId, "idx_org_domain_org_id");

            entity.Property(e => e.Id)
                .HasMaxLength(36)
                .HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.OrgId)
                .IsRequired()
                .HasMaxLength(255)
                .HasColumnName("org_id");
            entity.Property(e => e.Verified).HasColumnName("verified");
        });

        modelBuilder.Entity<PolicyConfig>(entity =>
        {
            entity.HasKey(e => new { e.PolicyId, e.Name }).HasName("constraint_dpc");

            entity.ToTable("policy_config", "auth");

            entity.Property(e => e.PolicyId)
                .HasMaxLength(36)
                .HasColumnName("policy_id");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Value).HasColumnName("value");

            entity.HasOne(d => d.Policy).WithMany(p => p.PolicyConfigs)
                .HasForeignKey(d => d.PolicyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fkdc34197cf864c4e43");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("product_pkey");

            entity.ToTable("product", "product");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("uuid_generate_v4()")
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("created_at");
            entity.Property(e => e.Description)
                .HasMaxLength(1024)
                .HasColumnName("description");
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Price)
                .HasPrecision(10, 2)
                .HasColumnName("price");
            entity.Property(e => e.RealmId)
                .IsRequired()
                .HasMaxLength(36)
                .HasColumnName("realm_id");
            entity.Property(e => e.SnapshotVersion)
                .HasDefaultValueSql("now()")
                .HasColumnName("snapshot_version");
            entity.Property(e => e.Tags)
                .HasColumnType("jsonb")
                .HasColumnName("tags");
            entity.Property(e => e.TemperatureZones)
                .HasColumnType("jsonb")
                .HasColumnName("temperature_zones");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("updated_at");

            entity.HasOne(d => d.Realm).WithMany(p => p.Products)
                .HasForeignKey(d => d.RealmId)
                .HasConstraintName("product_realm_id_fkey");
        });

        modelBuilder.Entity<ProductCategory>(entity =>
        {
            entity.HasKey(e => new { e.ProductId, e.Category }).HasName("product_category_pkey");

            entity.ToTable("product_category", "product");

            entity.Property(e => e.ProductId).HasColumnName("product_id");
            entity.Property(e => e.Category).HasColumnName("category");
            entity.Property(e => e.Enabled)
                .HasDefaultValue(true)
                .HasColumnName("enabled");

            entity.HasOne(d => d.Product).WithMany(p => p.ProductCategories)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("product_category_product_id_fkey");
        });

        modelBuilder.Entity<ProductShipmentConfig>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("product_shipment_config_pkey");

            entity.ToTable("product_shipment_config", "product");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("uuid_generate_v4()")
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("created_at");
            entity.Property(e => e.ProductId).HasColumnName("product_id");
            entity.Property(e => e.RealmOrderShipmentConfigId).HasColumnName("realm_order_shipment_config_id");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("updated_at");

            entity.HasOne(d => d.Product).WithMany(p => p.ProductShipmentConfigs)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("product_shipment_config_product_id_fkey");

            entity.HasOne(d => d.RealmOrderShipmentConfig).WithMany(p => p.ProductShipmentConfigs)
                .HasForeignKey(d => d.RealmOrderShipmentConfigId)
                .HasConstraintName("product_shipment_config_realm_order_shipment_config_id_fkey");
        });

        modelBuilder.Entity<ProductSku>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("product_sku_pkey");

            entity.ToTable("product_sku", "product");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("uuid_generate_v4()")
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("created_at");
            entity.Property(e => e.ProductId).HasColumnName("product_id");
            entity.Property(e => e.SafetyStock)
                .HasDefaultValue(0)
                .HasColumnName("safety_stock");
            entity.Property(e => e.SnapshotVersion)
                .HasDefaultValueSql("now()")
                .HasColumnName("snapshot_version");
            entity.Property(e => e.Spec)
                .IsRequired()
                .HasColumnType("jsonb")
                .HasColumnName("spec");
            entity.Property(e => e.StockQuantity)
                .HasDefaultValue(0)
                .HasColumnName("stock_quantity");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("updated_at");

            entity.HasOne(d => d.Product).WithMany(p => p.ProductSkus)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("product_sku_product_id_fkey");
        });

        modelBuilder.Entity<ProtocolMapper>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("constraint_pcm");

            entity.ToTable("protocol_mapper", "auth");

            entity.HasIndex(e => e.ClientScopeId, "idx_clscope_protmap");

            entity.HasIndex(e => e.ClientId, "idx_protocol_mapper_client");

            entity.Property(e => e.Id)
                .HasMaxLength(36)
                .HasColumnName("id");
            entity.Property(e => e.ClientId)
                .HasMaxLength(36)
                .HasColumnName("client_id");
            entity.Property(e => e.ClientScopeId)
                .HasMaxLength(36)
                .HasColumnName("client_scope_id");
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Protocol)
                .IsRequired()
                .HasMaxLength(255)
                .HasColumnName("protocol");
            entity.Property(e => e.ProtocolMapperName)
                .IsRequired()
                .HasMaxLength(255)
                .HasColumnName("protocol_mapper_name");

            entity.HasOne(d => d.Client).WithMany(p => p.ProtocolMappers)
                .HasForeignKey(d => d.ClientId)
                .HasConstraintName("fk_pcm_realm");

            entity.HasOne(d => d.ClientScope).WithMany(p => p.ProtocolMappers)
                .HasForeignKey(d => d.ClientScopeId)
                .HasConstraintName("fk_cli_scope_mapper");
        });

        modelBuilder.Entity<ProtocolMapperConfig>(entity =>
        {
            entity.HasKey(e => new { e.ProtocolMapperId, e.Name }).HasName("constraint_pmconfig");

            entity.ToTable("protocol_mapper_config", "auth");

            entity.Property(e => e.ProtocolMapperId)
                .HasMaxLength(36)
                .HasColumnName("protocol_mapper_id");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Value).HasColumnName("value");

            entity.HasOne(d => d.ProtocolMapper).WithMany(p => p.ProtocolMapperConfigs)
                .HasForeignKey(d => d.ProtocolMapperId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_pmconfig");
        });

        modelBuilder.Entity<Realm>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("constraint_4a");

            entity.ToTable("realm", "auth");

            entity.HasIndex(e => e.MasterAdminClient, "idx_realm_master_adm_cli");

            entity.HasIndex(e => e.Name, "uk_orvsdmla56612eaefiq6wl5oi").IsUnique();

            entity.Property(e => e.Id)
                .HasMaxLength(36)
                .HasColumnName("id");
            entity.Property(e => e.AccessCodeLifespan).HasColumnName("access_code_lifespan");
            entity.Property(e => e.AccessTokenLifeImplicit)
                .HasDefaultValue(0)
                .HasColumnName("access_token_life_implicit");
            entity.Property(e => e.AccessTokenLifespan).HasColumnName("access_token_lifespan");
            entity.Property(e => e.AccountTheme)
                .HasMaxLength(255)
                .HasColumnName("account_theme");
            entity.Property(e => e.AdminEventsDetailsEnabled)
                .HasDefaultValue(false)
                .HasColumnName("admin_events_details_enabled");
            entity.Property(e => e.AdminEventsEnabled)
                .HasDefaultValue(false)
                .HasColumnName("admin_events_enabled");
            entity.Property(e => e.AdminTheme)
                .HasMaxLength(255)
                .HasColumnName("admin_theme");
            entity.Property(e => e.AllowUserManagedAccess)
                .HasDefaultValue(false)
                .HasColumnName("allow_user_managed_access");
            entity.Property(e => e.BrowserFlow)
                .HasMaxLength(36)
                .HasColumnName("browser_flow");
            entity.Property(e => e.ClientAuthFlow)
                .HasMaxLength(36)
                .HasColumnName("client_auth_flow");
            entity.Property(e => e.DefaultLocale)
                .HasMaxLength(255)
                .HasColumnName("default_locale");
            entity.Property(e => e.DefaultRole)
                .HasMaxLength(255)
                .HasColumnName("default_role");
            entity.Property(e => e.DirectGrantFlow)
                .HasMaxLength(36)
                .HasColumnName("direct_grant_flow");
            entity.Property(e => e.DockerAuthFlow)
                .HasMaxLength(36)
                .HasColumnName("docker_auth_flow");
            entity.Property(e => e.DuplicateEmailsAllowed)
                .HasDefaultValue(false)
                .HasColumnName("duplicate_emails_allowed");
            entity.Property(e => e.EditUsernameAllowed)
                .HasDefaultValue(false)
                .HasColumnName("edit_username_allowed");
            entity.Property(e => e.EmailTheme)
                .HasMaxLength(255)
                .HasColumnName("email_theme");
            entity.Property(e => e.Enabled)
                .HasDefaultValue(false)
                .HasColumnName("enabled");
            entity.Property(e => e.EventsEnabled)
                .HasDefaultValue(false)
                .HasColumnName("events_enabled");
            entity.Property(e => e.EventsExpiration).HasColumnName("events_expiration");
            entity.Property(e => e.InternationalizationEnabled)
                .HasDefaultValue(false)
                .HasColumnName("internationalization_enabled");
            entity.Property(e => e.LoginLifespan).HasColumnName("login_lifespan");
            entity.Property(e => e.LoginTheme)
                .HasMaxLength(255)
                .HasColumnName("login_theme");
            entity.Property(e => e.LoginWithEmailAllowed)
                .HasDefaultValue(true)
                .HasColumnName("login_with_email_allowed");
            entity.Property(e => e.MasterAdminClient)
                .HasMaxLength(36)
                .HasColumnName("master_admin_client");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.NotBefore).HasColumnName("not_before");
            entity.Property(e => e.OfflineSessionIdleTimeout)
                .HasDefaultValue(0)
                .HasColumnName("offline_session_idle_timeout");
            entity.Property(e => e.OtpPolicyAlg)
                .HasMaxLength(36)
                .HasDefaultValueSql("'HmacSHA1'::character varying")
                .HasColumnName("otp_policy_alg");
            entity.Property(e => e.OtpPolicyCounter)
                .HasDefaultValue(0)
                .HasColumnName("otp_policy_counter");
            entity.Property(e => e.OtpPolicyDigits)
                .HasDefaultValue(6)
                .HasColumnName("otp_policy_digits");
            entity.Property(e => e.OtpPolicyPeriod)
                .HasDefaultValue(30)
                .HasColumnName("otp_policy_period");
            entity.Property(e => e.OtpPolicyType)
                .HasMaxLength(36)
                .HasDefaultValueSql("'totp'::character varying")
                .HasColumnName("otp_policy_type");
            entity.Property(e => e.OtpPolicyWindow)
                .HasDefaultValue(1)
                .HasColumnName("otp_policy_window");
            entity.Property(e => e.PasswordPolicy)
                .HasMaxLength(2550)
                .HasColumnName("password_policy");
            entity.Property(e => e.RefreshTokenMaxReuse)
                .HasDefaultValue(0)
                .HasColumnName("refresh_token_max_reuse");
            entity.Property(e => e.RegEmailAsUsername)
                .HasDefaultValue(false)
                .HasColumnName("reg_email_as_username");
            entity.Property(e => e.RegistrationAllowed)
                .HasDefaultValue(false)
                .HasColumnName("registration_allowed");
            entity.Property(e => e.RegistrationFlow)
                .HasMaxLength(36)
                .HasColumnName("registration_flow");
            entity.Property(e => e.RememberMe)
                .HasDefaultValue(false)
                .HasColumnName("remember_me");
            entity.Property(e => e.ResetCredentialsFlow)
                .HasMaxLength(36)
                .HasColumnName("reset_credentials_flow");
            entity.Property(e => e.ResetPasswordAllowed)
                .HasDefaultValue(false)
                .HasColumnName("reset_password_allowed");
            entity.Property(e => e.RevokeRefreshToken)
                .HasDefaultValue(false)
                .HasColumnName("revoke_refresh_token");
            entity.Property(e => e.Social)
                .HasDefaultValue(false)
                .HasColumnName("social");
            entity.Property(e => e.SslRequired)
                .HasMaxLength(255)
                .HasColumnName("ssl_required");
            entity.Property(e => e.SsoIdleTimeout).HasColumnName("sso_idle_timeout");
            entity.Property(e => e.SsoIdleTimeoutRememberMe)
                .HasDefaultValue(0)
                .HasColumnName("sso_idle_timeout_remember_me");
            entity.Property(e => e.SsoMaxLifespan).HasColumnName("sso_max_lifespan");
            entity.Property(e => e.SsoMaxLifespanRememberMe)
                .HasDefaultValue(0)
                .HasColumnName("sso_max_lifespan_remember_me");
            entity.Property(e => e.UpdateProfileOnSocLogin)
                .HasDefaultValue(false)
                .HasColumnName("update_profile_on_soc_login");
            entity.Property(e => e.UserActionLifespan).HasColumnName("user_action_lifespan");
            entity.Property(e => e.VerifyEmail)
                .HasDefaultValue(false)
                .HasColumnName("verify_email");
        });

        modelBuilder.Entity<RealmAttribute>(entity =>
        {
            entity.HasKey(e => new { e.Name, e.RealmId }).HasName("constraint_9");

            entity.ToTable("realm_attribute", "auth");

            entity.HasIndex(e => e.RealmId, "idx_realm_attr_realm");

            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.RealmId)
                .HasMaxLength(36)
                .HasColumnName("realm_id");
            entity.Property(e => e.Value).HasColumnName("value");

            entity.HasOne(d => d.Realm).WithMany(p => p.RealmAttributes)
                .HasForeignKey(d => d.RealmId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_8shxd6l3e9atqukacxgpffptw");
        });

        modelBuilder.Entity<RealmDefaultGroup>(entity =>
        {
            entity.HasKey(e => new { e.RealmId, e.GroupId }).HasName("constr_realm_default_groups");

            entity.ToTable("realm_default_groups", "auth");

            entity.HasIndex(e => e.GroupId, "con_group_id_def_groups").IsUnique();

            entity.HasIndex(e => e.RealmId, "idx_realm_def_grp_realm");

            entity.Property(e => e.RealmId)
                .HasMaxLength(36)
                .HasColumnName("realm_id");
            entity.Property(e => e.GroupId)
                .HasMaxLength(36)
                .HasColumnName("group_id");

            entity.HasOne(d => d.Realm).WithMany(p => p.RealmDefaultGroups)
                .HasForeignKey(d => d.RealmId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_def_groups_realm");
        });

        modelBuilder.Entity<RealmEnabledEventType>(entity =>
        {
            entity.HasKey(e => new { e.RealmId, e.Value }).HasName("constr_realm_enabl_event_types");

            entity.ToTable("realm_enabled_event_types", "auth");

            entity.HasIndex(e => e.RealmId, "idx_realm_evt_types_realm");

            entity.Property(e => e.RealmId)
                .HasMaxLength(36)
                .HasColumnName("realm_id");
            entity.Property(e => e.Value)
                .HasMaxLength(255)
                .HasColumnName("value");

            entity.HasOne(d => d.Realm).WithMany(p => p.RealmEnabledEventTypes)
                .HasForeignKey(d => d.RealmId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_h846o4h0w8epx5nwedrf5y69j");
        });

        modelBuilder.Entity<RealmEventsListener>(entity =>
        {
            entity.HasKey(e => new { e.RealmId, e.Value }).HasName("constr_realm_events_listeners");

            entity.ToTable("realm_events_listeners", "auth");

            entity.HasIndex(e => e.RealmId, "idx_realm_evt_list_realm");

            entity.Property(e => e.RealmId)
                .HasMaxLength(36)
                .HasColumnName("realm_id");
            entity.Property(e => e.Value)
                .HasMaxLength(255)
                .HasColumnName("value");

            entity.HasOne(d => d.Realm).WithMany(p => p.RealmEventsListeners)
                .HasForeignKey(d => d.RealmId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_h846o4h0w8epx5nxev9f5y69j");
        });

        modelBuilder.Entity<RealmLocalization>(entity =>
        {
            entity.HasKey(e => new { e.RealmId, e.Locale }).HasName("realm_localizations_pkey");

            entity.ToTable("realm_localizations", "auth");

            entity.Property(e => e.RealmId)
                .HasMaxLength(255)
                .HasColumnName("realm_id");
            entity.Property(e => e.Locale)
                .HasMaxLength(255)
                .HasColumnName("locale");
            entity.Property(e => e.Texts)
                .IsRequired()
                .HasColumnName("texts");
        });

        modelBuilder.Entity<RealmOrderShipmentConfig>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("realm_order_shipment_config_pkey");

            entity.ToTable("realm_order_shipment_config", "order");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("uuid_generate_v4()")
                .HasColumnName("id");
            entity.Property(e => e.Country)
                .HasMaxLength(50)
                .HasColumnName("country");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("created_at");
            entity.Property(e => e.DisplayName)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("display_name");
            entity.Property(e => e.MinOrderAmount)
                .HasPrecision(10, 2)
                .HasColumnName("min_order_amount");
            entity.Property(e => e.PayConditions)
                .HasMaxLength(50)
                .HasColumnName("pay_conditions");
            entity.Property(e => e.RealmId)
                .IsRequired()
                .HasMaxLength(36)
                .HasColumnName("realm_id");
            entity.Property(e => e.ShipmentFee)
                .HasPrecision(10, 2)
                .HasColumnName("shipment_fee");
            entity.Property(e => e.ShipmentServiceProvider)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("shipment_service_provider");
            entity.Property(e => e.TemperatureZone)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("temperature_zone");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("updated_at");

            entity.HasOne(d => d.Realm).WithMany(p => p.RealmOrderShipmentConfigs)
                .HasForeignKey(d => d.RealmId)
                .HasConstraintName("realm_order_shipment_config_realm_id_fkey");
        });

        modelBuilder.Entity<RealmRequiredCredential>(entity =>
        {
            entity.HasKey(e => new { e.RealmId, e.Type }).HasName("constraint_92");

            entity.ToTable("realm_required_credential", "auth");

            entity.Property(e => e.RealmId)
                .HasMaxLength(36)
                .HasColumnName("realm_id");
            entity.Property(e => e.Type)
                .HasMaxLength(255)
                .HasColumnName("type");
            entity.Property(e => e.FormLabel)
                .HasMaxLength(255)
                .HasColumnName("form_label");
            entity.Property(e => e.Input)
                .HasDefaultValue(false)
                .HasColumnName("input");
            entity.Property(e => e.Secret)
                .HasDefaultValue(false)
                .HasColumnName("secret");

            entity.HasOne(d => d.Realm).WithMany(p => p.RealmRequiredCredentials)
                .HasForeignKey(d => d.RealmId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_5hg65lybevavkqfki3kponh9v");
        });

        modelBuilder.Entity<RealmSmtpConfig>(entity =>
        {
            entity.HasKey(e => new { e.RealmId, e.Name }).HasName("constraint_e");

            entity.ToTable("realm_smtp_config", "auth");

            entity.Property(e => e.RealmId)
                .HasMaxLength(36)
                .HasColumnName("realm_id");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Value)
                .HasMaxLength(255)
                .HasColumnName("value");

            entity.HasOne(d => d.Realm).WithMany(p => p.RealmSmtpConfigs)
                .HasForeignKey(d => d.RealmId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_70ej8xdxgxd0b9hh6180irr0o");
        });

        modelBuilder.Entity<RealmSupportedLocale>(entity =>
        {
            entity.HasKey(e => new { e.RealmId, e.Value }).HasName("constr_realm_supported_locales");

            entity.ToTable("realm_supported_locales", "auth");

            entity.HasIndex(e => e.RealmId, "idx_realm_supp_local_realm");

            entity.Property(e => e.RealmId)
                .HasMaxLength(36)
                .HasColumnName("realm_id");
            entity.Property(e => e.Value)
                .HasMaxLength(255)
                .HasColumnName("value");

            entity.HasOne(d => d.Realm).WithMany(p => p.RealmSupportedLocales)
                .HasForeignKey(d => d.RealmId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_supported_locales_realm");
        });

        modelBuilder.Entity<RedirectUri>(entity =>
        {
            entity.HasKey(e => new { e.ClientId, e.Value }).HasName("constraint_redirect_uris");

            entity.ToTable("redirect_uris", "auth");

            entity.HasIndex(e => e.ClientId, "idx_redir_uri_client");

            entity.Property(e => e.ClientId)
                .HasMaxLength(36)
                .HasColumnName("client_id");
            entity.Property(e => e.Value)
                .HasMaxLength(255)
                .HasColumnName("value");

            entity.HasOne(d => d.Client).WithMany(p => p.RedirectUris)
                .HasForeignKey(d => d.ClientId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_1burs8pb4ouj97h5wuppahv9f");
        });

        modelBuilder.Entity<RequiredActionConfig>(entity =>
        {
            entity.HasKey(e => new { e.RequiredActionId, e.Name }).HasName("constraint_req_act_cfg_pk");

            entity.ToTable("required_action_config", "auth");

            entity.Property(e => e.RequiredActionId)
                .HasMaxLength(36)
                .HasColumnName("required_action_id");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Value).HasColumnName("value");
        });

        modelBuilder.Entity<RequiredActionProvider>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("constraint_req_act_prv_pk");

            entity.ToTable("required_action_provider", "auth");

            entity.HasIndex(e => e.RealmId, "idx_req_act_prov_realm");

            entity.Property(e => e.Id)
                .HasMaxLength(36)
                .HasColumnName("id");
            entity.Property(e => e.Alias)
                .HasMaxLength(255)
                .HasColumnName("alias");
            entity.Property(e => e.DefaultAction)
                .HasDefaultValue(false)
                .HasColumnName("default_action");
            entity.Property(e => e.Enabled)
                .HasDefaultValue(false)
                .HasColumnName("enabled");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Priority).HasColumnName("priority");
            entity.Property(e => e.ProviderId)
                .HasMaxLength(255)
                .HasColumnName("provider_id");
            entity.Property(e => e.RealmId)
                .HasMaxLength(36)
                .HasColumnName("realm_id");

            entity.HasOne(d => d.Realm).WithMany(p => p.RequiredActionProviders)
                .HasForeignKey(d => d.RealmId)
                .HasConstraintName("fk_req_act_realm");
        });

        modelBuilder.Entity<ResourceAttribute>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("res_attr_pk");

            entity.ToTable("resource_attribute", "auth");

            entity.Property(e => e.Id)
                .HasMaxLength(36)
                .HasDefaultValueSql("'sybase-needs-something-here'::character varying")
                .HasColumnName("id");
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.ResourceId)
                .IsRequired()
                .HasMaxLength(36)
                .HasColumnName("resource_id");
            entity.Property(e => e.Value)
                .HasMaxLength(255)
                .HasColumnName("value");

            entity.HasOne(d => d.Resource).WithMany(p => p.ResourceAttributes)
                .HasForeignKey(d => d.ResourceId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_5hrm2vlf9ql5fu022kqepovbr");
        });

        modelBuilder.Entity<ResourceServer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_resource_server");

            entity.ToTable("resource_server", "auth");

            entity.Property(e => e.Id)
                .HasMaxLength(36)
                .HasColumnName("id");
            entity.Property(e => e.AllowRsRemoteMgmt)
                .HasDefaultValue(false)
                .HasColumnName("allow_rs_remote_mgmt");
            entity.Property(e => e.DecisionStrategy)
                .HasDefaultValue((short)1)
                .HasColumnName("decision_strategy");
            entity.Property(e => e.PolicyEnforceMode).HasColumnName("policy_enforce_mode");
        });

        modelBuilder.Entity<ResourceServerPermTicket>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("constraint_fapmt");

            entity.ToTable("resource_server_perm_ticket", "auth");

            entity.HasIndex(e => e.Owner, "idx_perm_ticket_owner");

            entity.HasIndex(e => e.Requester, "idx_perm_ticket_requester");

            entity.HasIndex(e => new { e.Owner, e.Requester, e.ResourceServerId, e.ResourceId, e.ScopeId }, "uk_frsr6t700s9v50bu18ws5pmt").IsUnique();

            entity.Property(e => e.Id)
                .HasMaxLength(36)
                .HasColumnName("id");
            entity.Property(e => e.CreatedTimestamp).HasColumnName("created_timestamp");
            entity.Property(e => e.GrantedTimestamp).HasColumnName("granted_timestamp");
            entity.Property(e => e.Owner)
                .IsRequired()
                .HasMaxLength(255)
                .HasColumnName("owner");
            entity.Property(e => e.PolicyId)
                .HasMaxLength(36)
                .HasColumnName("policy_id");
            entity.Property(e => e.Requester)
                .IsRequired()
                .HasMaxLength(255)
                .HasColumnName("requester");
            entity.Property(e => e.ResourceId)
                .IsRequired()
                .HasMaxLength(36)
                .HasColumnName("resource_id");
            entity.Property(e => e.ResourceServerId)
                .IsRequired()
                .HasMaxLength(36)
                .HasColumnName("resource_server_id");
            entity.Property(e => e.ScopeId)
                .HasMaxLength(36)
                .HasColumnName("scope_id");

            entity.HasOne(d => d.Policy).WithMany(p => p.ResourceServerPermTickets)
                .HasForeignKey(d => d.PolicyId)
                .HasConstraintName("fk_frsrpo2128cx4wnkog82ssrfy");

            entity.HasOne(d => d.Resource).WithMany(p => p.ResourceServerPermTickets)
                .HasForeignKey(d => d.ResourceId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_frsrho213xcx4wnkog83sspmt");

            entity.HasOne(d => d.ResourceServer).WithMany(p => p.ResourceServerPermTickets)
                .HasForeignKey(d => d.ResourceServerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_frsrho213xcx4wnkog82sspmt");

            entity.HasOne(d => d.Scope).WithMany(p => p.ResourceServerPermTickets)
                .HasForeignKey(d => d.ScopeId)
                .HasConstraintName("fk_frsrho213xcx4wnkog84sspmt");
        });

        modelBuilder.Entity<ResourceServerPolicy>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("constraint_farsrp");

            entity.ToTable("resource_server_policy", "auth");

            entity.HasIndex(e => e.ResourceServerId, "idx_res_serv_pol_res_serv");

            entity.HasIndex(e => new { e.Name, e.ResourceServerId }, "uk_frsrpt700s9v50bu18ws5ha6").IsUnique();

            entity.Property(e => e.Id)
                .HasMaxLength(36)
                .HasColumnName("id");
            entity.Property(e => e.DecisionStrategy).HasColumnName("decision_strategy");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .HasColumnName("description");
            entity.Property(e => e.Logic).HasColumnName("logic");
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Owner)
                .HasMaxLength(255)
                .HasColumnName("owner");
            entity.Property(e => e.ResourceServerId)
                .IsRequired()
                .HasMaxLength(36)
                .HasColumnName("resource_server_id");
            entity.Property(e => e.Type)
                .IsRequired()
                .HasMaxLength(255)
                .HasColumnName("type");

            entity.HasOne(d => d.ResourceServer).WithMany(p => p.ResourceServerPolicies)
                .HasForeignKey(d => d.ResourceServerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_frsrpo213xcx4wnkog82ssrfy");

            entity.HasMany(d => d.AssociatedPolicies).WithMany(p => p.Policies)
                .UsingEntity<Dictionary<string, object>>(
                    "AssociatedPolicy",
                    r => r.HasOne<ResourceServerPolicy>().WithMany()
                        .HasForeignKey("AssociatedPolicyId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("fk_frsr5s213xcx4wnkog82ssrfy"),
                    l => l.HasOne<ResourceServerPolicy>().WithMany()
                        .HasForeignKey("PolicyId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("fk_frsrpas14xcx4wnkog82ssrfy"),
                    j =>
                    {
                        j.HasKey("PolicyId", "AssociatedPolicyId").HasName("constraint_farsrpap");
                        j.ToTable("associated_policy", "auth");
                        j.HasIndex(new[] { "AssociatedPolicyId" }, "idx_assoc_pol_assoc_pol_id");
                        j.IndexerProperty<string>("PolicyId")
                            .HasMaxLength(36)
                            .HasColumnName("policy_id");
                        j.IndexerProperty<string>("AssociatedPolicyId")
                            .HasMaxLength(36)
                            .HasColumnName("associated_policy_id");
                    });

            entity.HasMany(d => d.Policies).WithMany(p => p.AssociatedPolicies)
                .UsingEntity<Dictionary<string, object>>(
                    "AssociatedPolicy",
                    r => r.HasOne<ResourceServerPolicy>().WithMany()
                        .HasForeignKey("PolicyId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("fk_frsrpas14xcx4wnkog82ssrfy"),
                    l => l.HasOne<ResourceServerPolicy>().WithMany()
                        .HasForeignKey("AssociatedPolicyId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("fk_frsr5s213xcx4wnkog82ssrfy"),
                    j =>
                    {
                        j.HasKey("PolicyId", "AssociatedPolicyId").HasName("constraint_farsrpap");
                        j.ToTable("associated_policy", "auth");
                        j.HasIndex(new[] { "AssociatedPolicyId" }, "idx_assoc_pol_assoc_pol_id");
                        j.IndexerProperty<string>("PolicyId")
                            .HasMaxLength(36)
                            .HasColumnName("policy_id");
                        j.IndexerProperty<string>("AssociatedPolicyId")
                            .HasMaxLength(36)
                            .HasColumnName("associated_policy_id");
                    });
        });

        modelBuilder.Entity<ResourceServerResource>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("constraint_farsr");

            entity.ToTable("resource_server_resource", "auth");

            entity.HasIndex(e => e.ResourceServerId, "idx_res_srv_res_res_srv");

            entity.HasIndex(e => new { e.Name, e.Owner, e.ResourceServerId }, "uk_frsr6t700s9v50bu18ws5ha6").IsUnique();

            entity.Property(e => e.Id)
                .HasMaxLength(36)
                .HasColumnName("id");
            entity.Property(e => e.DisplayName)
                .HasMaxLength(255)
                .HasColumnName("display_name");
            entity.Property(e => e.IconUri)
                .HasMaxLength(255)
                .HasColumnName("icon_uri");
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Owner)
                .IsRequired()
                .HasMaxLength(255)
                .HasColumnName("owner");
            entity.Property(e => e.OwnerManagedAccess)
                .HasDefaultValue(false)
                .HasColumnName("owner_managed_access");
            entity.Property(e => e.ResourceServerId)
                .IsRequired()
                .HasMaxLength(36)
                .HasColumnName("resource_server_id");
            entity.Property(e => e.Type)
                .HasMaxLength(255)
                .HasColumnName("type");

            entity.HasOne(d => d.ResourceServer).WithMany(p => p.ResourceServerResources)
                .HasForeignKey(d => d.ResourceServerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_frsrho213xcx4wnkog82ssrfy");

            entity.HasMany(d => d.Policies).WithMany(p => p.Resources)
                .UsingEntity<Dictionary<string, object>>(
                    "ResourcePolicy",
                    r => r.HasOne<ResourceServerPolicy>().WithMany()
                        .HasForeignKey("PolicyId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("fk_frsrpp213xcx4wnkog82ssrfy"),
                    l => l.HasOne<ResourceServerResource>().WithMany()
                        .HasForeignKey("ResourceId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("fk_frsrpos53xcx4wnkog82ssrfy"),
                    j =>
                    {
                        j.HasKey("ResourceId", "PolicyId").HasName("constraint_farsrpp");
                        j.ToTable("resource_policy", "auth");
                        j.HasIndex(new[] { "PolicyId" }, "idx_res_policy_policy");
                        j.IndexerProperty<string>("ResourceId")
                            .HasMaxLength(36)
                            .HasColumnName("resource_id");
                        j.IndexerProperty<string>("PolicyId")
                            .HasMaxLength(36)
                            .HasColumnName("policy_id");
                    });

            entity.HasMany(d => d.Scopes).WithMany(p => p.Resources)
                .UsingEntity<Dictionary<string, object>>(
                    "ResourceScope",
                    r => r.HasOne<ResourceServerScope>().WithMany()
                        .HasForeignKey("ScopeId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("fk_frsrps213xcx4wnkog82ssrfy"),
                    l => l.HasOne<ResourceServerResource>().WithMany()
                        .HasForeignKey("ResourceId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("fk_frsrpos13xcx4wnkog82ssrfy"),
                    j =>
                    {
                        j.HasKey("ResourceId", "ScopeId").HasName("constraint_farsrsp");
                        j.ToTable("resource_scope", "auth");
                        j.HasIndex(new[] { "ScopeId" }, "idx_res_scope_scope");
                        j.IndexerProperty<string>("ResourceId")
                            .HasMaxLength(36)
                            .HasColumnName("resource_id");
                        j.IndexerProperty<string>("ScopeId")
                            .HasMaxLength(36)
                            .HasColumnName("scope_id");
                    });
        });

        modelBuilder.Entity<ResourceServerScope>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("constraint_farsrs");

            entity.ToTable("resource_server_scope", "auth");

            entity.HasIndex(e => e.ResourceServerId, "idx_res_srv_scope_res_srv");

            entity.HasIndex(e => new { e.Name, e.ResourceServerId }, "uk_frsrst700s9v50bu18ws5ha6").IsUnique();

            entity.Property(e => e.Id)
                .HasMaxLength(36)
                .HasColumnName("id");
            entity.Property(e => e.DisplayName)
                .HasMaxLength(255)
                .HasColumnName("display_name");
            entity.Property(e => e.IconUri)
                .HasMaxLength(255)
                .HasColumnName("icon_uri");
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.ResourceServerId)
                .IsRequired()
                .HasMaxLength(36)
                .HasColumnName("resource_server_id");

            entity.HasOne(d => d.ResourceServer).WithMany(p => p.ResourceServerScopes)
                .HasForeignKey(d => d.ResourceServerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_frsrso213xcx4wnkog82ssrfy");

            entity.HasMany(d => d.Policies).WithMany(p => p.Scopes)
                .UsingEntity<Dictionary<string, object>>(
                    "ScopePolicy",
                    r => r.HasOne<ResourceServerPolicy>().WithMany()
                        .HasForeignKey("PolicyId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("fk_frsrasp13xcx4wnkog82ssrfy"),
                    l => l.HasOne<ResourceServerScope>().WithMany()
                        .HasForeignKey("ScopeId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("fk_frsrpass3xcx4wnkog82ssrfy"),
                    j =>
                    {
                        j.HasKey("ScopeId", "PolicyId").HasName("constraint_farsrsps");
                        j.ToTable("scope_policy", "auth");
                        j.HasIndex(new[] { "PolicyId" }, "idx_scope_policy_policy");
                        j.IndexerProperty<string>("ScopeId")
                            .HasMaxLength(36)
                            .HasColumnName("scope_id");
                        j.IndexerProperty<string>("PolicyId")
                            .HasMaxLength(36)
                            .HasColumnName("policy_id");
                    });
        });

        modelBuilder.Entity<ResourceUri>(entity =>
        {
            entity.HasKey(e => new { e.ResourceId, e.Value }).HasName("constraint_resour_uris_pk");

            entity.ToTable("resource_uris", "auth");

            entity.Property(e => e.ResourceId)
                .HasMaxLength(36)
                .HasColumnName("resource_id");
            entity.Property(e => e.Value)
                .HasMaxLength(255)
                .HasColumnName("value");

            entity.HasOne(d => d.Resource).WithMany(p => p.ResourceUris)
                .HasForeignKey(d => d.ResourceId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_resource_server_uris");
        });

        modelBuilder.Entity<RevokedToken>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("constraint_rt");

            entity.ToTable("revoked_token", "auth");

            entity.HasIndex(e => e.Expire, "idx_rev_token_on_expire");

            entity.Property(e => e.Id)
                .HasMaxLength(255)
                .HasColumnName("id");
            entity.Property(e => e.Expire).HasColumnName("expire");
        });

        modelBuilder.Entity<RoleAttribute>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("constraint_role_attribute_pk");

            entity.ToTable("role_attribute", "auth");

            entity.HasIndex(e => e.RoleId, "idx_role_attribute");

            entity.Property(e => e.Id)
                .HasMaxLength(36)
                .HasColumnName("id");
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.RoleId)
                .IsRequired()
                .HasMaxLength(36)
                .HasColumnName("role_id");
            entity.Property(e => e.Value)
                .HasMaxLength(255)
                .HasColumnName("value");

            entity.HasOne(d => d.Role).WithMany(p => p.RoleAttributes)
                .HasForeignKey(d => d.RoleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_role_attribute_id");
        });

        modelBuilder.Entity<ScopeMapping>(entity =>
        {
            entity.HasKey(e => new { e.ClientId, e.RoleId }).HasName("constraint_81");

            entity.ToTable("scope_mapping", "auth");

            entity.HasIndex(e => e.RoleId, "idx_scope_mapping_role");

            entity.Property(e => e.ClientId)
                .HasMaxLength(36)
                .HasColumnName("client_id");
            entity.Property(e => e.RoleId)
                .HasMaxLength(36)
                .HasColumnName("role_id");

            entity.HasOne(d => d.Client).WithMany(p => p.ScopeMappings)
                .HasForeignKey(d => d.ClientId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_ouse064plmlr732lxjcn1q5f1");
        });

        modelBuilder.Entity<SnapshotProduct>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.SnapshotVersion }).HasName("snapshot_product_pkey");

            entity.ToTable("snapshot_product", "order");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.SnapshotVersion)
                .HasDefaultValueSql("now()")
                .HasColumnName("snapshot_version");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("created_at");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Price)
                .HasPrecision(10, 2)
                .HasColumnName("price");
            entity.Property(e => e.RealmId)
                .IsRequired()
                .HasMaxLength(36)
                .HasColumnName("realm_id");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("updated_at");

            entity.HasOne(d => d.Realm).WithMany(p => p.SnapshotProducts)
                .HasForeignKey(d => d.RealmId)
                .HasConstraintName("snapshot_product_realm_id_fkey");
        });

        modelBuilder.Entity<SnapshotProductSku>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.SnapshotVersion }).HasName("snapshot_product_sku_pkey");

            entity.ToTable("snapshot_product_sku", "order");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.SnapshotVersion)
                .HasDefaultValueSql("now()")
                .HasColumnName("snapshot_version");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("created_at");
            entity.Property(e => e.ProductId).HasColumnName("product_id");
            entity.Property(e => e.SafetyStock)
                .HasDefaultValue(0)
                .HasColumnName("safety_stock");
            entity.Property(e => e.Spec)
                .IsRequired()
                .HasColumnType("jsonb")
                .HasColumnName("spec");
            entity.Property(e => e.StockQuantity)
                .HasDefaultValue(0)
                .HasColumnName("stock_quantity");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<UserAttribute>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("constraint_user_attribute_pk");

            entity.ToTable("user_attribute", "auth");

            entity.HasIndex(e => e.UserId, "idx_user_attribute");

            entity.HasIndex(e => new { e.Name, e.Value }, "idx_user_attribute_name");

            entity.HasIndex(e => new { e.LongValueHash, e.Name }, "user_attr_long_values");

            entity.HasIndex(e => new { e.LongValueHashLowerCase, e.Name }, "user_attr_long_values_lower_case");

            entity.Property(e => e.Id)
                .HasMaxLength(36)
                .HasDefaultValueSql("'sybase-needs-something-here'::character varying")
                .HasColumnName("id");
            entity.Property(e => e.LongValue).HasColumnName("long_value");
            entity.Property(e => e.LongValueHash).HasColumnName("long_value_hash");
            entity.Property(e => e.LongValueHashLowerCase).HasColumnName("long_value_hash_lower_case");
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.UserId)
                .IsRequired()
                .HasMaxLength(36)
                .HasColumnName("user_id");
            entity.Property(e => e.Value)
                .HasMaxLength(255)
                .HasColumnName("value");

            entity.HasOne(d => d.User).WithMany(p => p.UserAttributes)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_5hrm2vlf9ql5fu043kqepovbr");
        });

        modelBuilder.Entity<UserConsent>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("constraint_grntcsnt_pm");

            entity.ToTable("user_consent", "auth");

            entity.HasIndex(e => e.UserId, "idx_user_consent");

            entity.HasIndex(e => new { e.ClientStorageProvider, e.ExternalClientId, e.UserId }, "uk_external_consent").IsUnique();

            entity.HasIndex(e => new { e.ClientId, e.UserId }, "uk_local_consent").IsUnique();

            entity.Property(e => e.Id)
                .HasMaxLength(36)
                .HasColumnName("id");
            entity.Property(e => e.ClientId)
                .HasMaxLength(255)
                .HasColumnName("client_id");
            entity.Property(e => e.ClientStorageProvider)
                .HasMaxLength(36)
                .HasColumnName("client_storage_provider");
            entity.Property(e => e.CreatedDate).HasColumnName("created_date");
            entity.Property(e => e.ExternalClientId)
                .HasMaxLength(255)
                .HasColumnName("external_client_id");
            entity.Property(e => e.LastUpdatedDate).HasColumnName("last_updated_date");
            entity.Property(e => e.UserId)
                .IsRequired()
                .HasMaxLength(36)
                .HasColumnName("user_id");

            entity.HasOne(d => d.User).WithMany(p => p.UserConsents)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_grntcsnt_user");
        });

        modelBuilder.Entity<UserConsentClientScope>(entity =>
        {
            entity.HasKey(e => new { e.UserConsentId, e.ScopeId }).HasName("constraint_grntcsnt_clsc_pm");

            entity.ToTable("user_consent_client_scope", "auth");

            entity.HasIndex(e => e.UserConsentId, "idx_usconsent_clscope");

            entity.HasIndex(e => e.ScopeId, "idx_usconsent_scope_id");

            entity.Property(e => e.UserConsentId)
                .HasMaxLength(36)
                .HasColumnName("user_consent_id");
            entity.Property(e => e.ScopeId)
                .HasMaxLength(36)
                .HasColumnName("scope_id");

            entity.HasOne(d => d.UserConsent).WithMany(p => p.UserConsentClientScopes)
                .HasForeignKey(d => d.UserConsentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_grntcsnt_clsc_usc");
        });

        modelBuilder.Entity<UserEntity>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("constraint_fb");

            entity.ToTable("user_entity", "auth");

            entity.HasIndex(e => e.Email, "idx_user_email");

            entity.HasIndex(e => new { e.RealmId, e.ServiceAccountClientLink }, "idx_user_service_account");

            entity.HasIndex(e => new { e.RealmId, e.EmailConstraint }, "uk_dykn684sl8up1crfei6eckhd7").IsUnique();

            entity.HasIndex(e => new { e.RealmId, e.Username }, "uk_ru8tt6t700s9v50bu18ws5ha6").IsUnique();

            entity.Property(e => e.Id)
                .HasMaxLength(36)
                .HasColumnName("id");
            entity.Property(e => e.CreatedTimestamp).HasColumnName("created_timestamp");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .HasColumnName("email");
            entity.Property(e => e.EmailConstraint)
                .HasMaxLength(255)
                .HasColumnName("email_constraint");
            entity.Property(e => e.EmailVerified)
                .HasDefaultValue(false)
                .HasColumnName("email_verified");
            entity.Property(e => e.Enabled)
                .HasDefaultValue(false)
                .HasColumnName("enabled");
            entity.Property(e => e.FederationLink)
                .HasMaxLength(255)
                .HasColumnName("federation_link");
            entity.Property(e => e.FirstName)
                .HasMaxLength(255)
                .HasColumnName("first_name");
            entity.Property(e => e.LastName)
                .HasMaxLength(255)
                .HasColumnName("last_name");
            entity.Property(e => e.NotBefore)
                .HasDefaultValue(0)
                .HasColumnName("not_before");
            entity.Property(e => e.RealmId)
                .HasMaxLength(255)
                .HasColumnName("realm_id");
            entity.Property(e => e.ServiceAccountClientLink)
                .HasMaxLength(255)
                .HasColumnName("service_account_client_link");
            entity.Property(e => e.Username)
                .HasMaxLength(255)
                .HasColumnName("username");
        });

        modelBuilder.Entity<UserFederationConfig>(entity =>
        {
            entity.HasKey(e => new { e.UserFederationProviderId, e.Name }).HasName("constraint_f9");

            entity.ToTable("user_federation_config", "auth");

            entity.Property(e => e.UserFederationProviderId)
                .HasMaxLength(36)
                .HasColumnName("user_federation_provider_id");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Value)
                .HasMaxLength(255)
                .HasColumnName("value");

            entity.HasOne(d => d.UserFederationProvider).WithMany(p => p.UserFederationConfigs)
                .HasForeignKey(d => d.UserFederationProviderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_t13hpu1j94r2ebpekr39x5eu5");
        });

        modelBuilder.Entity<UserFederationMapper>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("constraint_fedmapperpm");

            entity.ToTable("user_federation_mapper", "auth");

            entity.HasIndex(e => e.FederationProviderId, "idx_usr_fed_map_fed_prv");

            entity.HasIndex(e => e.RealmId, "idx_usr_fed_map_realm");

            entity.Property(e => e.Id)
                .HasMaxLength(36)
                .HasColumnName("id");
            entity.Property(e => e.FederationMapperType)
                .IsRequired()
                .HasMaxLength(255)
                .HasColumnName("federation_mapper_type");
            entity.Property(e => e.FederationProviderId)
                .IsRequired()
                .HasMaxLength(36)
                .HasColumnName("federation_provider_id");
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.RealmId)
                .IsRequired()
                .HasMaxLength(36)
                .HasColumnName("realm_id");

            entity.HasOne(d => d.FederationProvider).WithMany(p => p.UserFederationMappers)
                .HasForeignKey(d => d.FederationProviderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_fedmapperpm_fedprv");

            entity.HasOne(d => d.Realm).WithMany(p => p.UserFederationMappers)
                .HasForeignKey(d => d.RealmId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_fedmapperpm_realm");
        });

        modelBuilder.Entity<UserFederationMapperConfig>(entity =>
        {
            entity.HasKey(e => new { e.UserFederationMapperId, e.Name }).HasName("constraint_fedmapper_cfg_pm");

            entity.ToTable("user_federation_mapper_config", "auth");

            entity.Property(e => e.UserFederationMapperId)
                .HasMaxLength(36)
                .HasColumnName("user_federation_mapper_id");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Value)
                .HasMaxLength(255)
                .HasColumnName("value");

            entity.HasOne(d => d.UserFederationMapper).WithMany(p => p.UserFederationMapperConfigs)
                .HasForeignKey(d => d.UserFederationMapperId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_fedmapper_cfg");
        });

        modelBuilder.Entity<UserFederationProvider>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("constraint_5c");

            entity.ToTable("user_federation_provider", "auth");

            entity.HasIndex(e => e.RealmId, "idx_usr_fed_prv_realm");

            entity.Property(e => e.Id)
                .HasMaxLength(36)
                .HasColumnName("id");
            entity.Property(e => e.ChangedSyncPeriod).HasColumnName("changed_sync_period");
            entity.Property(e => e.DisplayName)
                .HasMaxLength(255)
                .HasColumnName("display_name");
            entity.Property(e => e.FullSyncPeriod).HasColumnName("full_sync_period");
            entity.Property(e => e.LastSync).HasColumnName("last_sync");
            entity.Property(e => e.Priority).HasColumnName("priority");
            entity.Property(e => e.ProviderName)
                .HasMaxLength(255)
                .HasColumnName("provider_name");
            entity.Property(e => e.RealmId)
                .HasMaxLength(36)
                .HasColumnName("realm_id");

            entity.HasOne(d => d.Realm).WithMany(p => p.UserFederationProviders)
                .HasForeignKey(d => d.RealmId)
                .HasConstraintName("fk_1fj32f6ptolw2qy60cd8n01e8");
        });

        modelBuilder.Entity<UserGroupMembership>(entity =>
        {
            entity.HasKey(e => new { e.GroupId, e.UserId }).HasName("constraint_user_group");

            entity.ToTable("user_group_membership", "auth");

            entity.HasIndex(e => e.UserId, "idx_user_group_mapping");

            entity.Property(e => e.GroupId)
                .HasMaxLength(36)
                .HasColumnName("group_id");
            entity.Property(e => e.UserId)
                .HasMaxLength(36)
                .HasColumnName("user_id");
            entity.Property(e => e.MembershipType)
                .IsRequired()
                .HasMaxLength(255)
                .HasColumnName("membership_type");

            entity.HasOne(d => d.User).WithMany(p => p.UserGroupMemberships)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_user_group_user");
        });

        modelBuilder.Entity<UserRequiredAction>(entity =>
        {
            entity.HasKey(e => new { e.RequiredAction, e.UserId }).HasName("constraint_required_action");

            entity.ToTable("user_required_action", "auth");

            entity.HasIndex(e => e.UserId, "idx_user_reqactions");

            entity.Property(e => e.RequiredAction)
                .HasMaxLength(255)
                .HasDefaultValueSql("' '::character varying")
                .HasColumnName("required_action");
            entity.Property(e => e.UserId)
                .HasMaxLength(36)
                .HasColumnName("user_id");

            entity.HasOne(d => d.User).WithMany(p => p.UserRequiredActions)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_6qj3w1jw9cvafhe19bwsiuvmd");
        });

        modelBuilder.Entity<UserRoleMapping>(entity =>
        {
            entity.HasKey(e => new { e.RoleId, e.UserId }).HasName("constraint_c");

            entity.ToTable("user_role_mapping", "auth");

            entity.HasIndex(e => e.UserId, "idx_user_role_mapping");

            entity.Property(e => e.RoleId)
                .HasMaxLength(255)
                .HasColumnName("role_id");
            entity.Property(e => e.UserId)
                .HasMaxLength(36)
                .HasColumnName("user_id");

            entity.HasOne(d => d.User).WithMany(p => p.UserRoleMappings)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_c4fqv34p1mbylloxang7b1q3l");
        });

        modelBuilder.Entity<UsernameLoginFailure>(entity =>
        {
            entity.HasKey(e => new { e.RealmId, e.Username }).HasName("CONSTRAINT_17-2");

            entity.ToTable("username_login_failure", "auth");

            entity.Property(e => e.RealmId)
                .HasMaxLength(36)
                .HasColumnName("realm_id");
            entity.Property(e => e.Username)
                .HasMaxLength(255)
                .HasColumnName("username");
            entity.Property(e => e.FailedLoginNotBefore).HasColumnName("failed_login_not_before");
            entity.Property(e => e.LastFailure).HasColumnName("last_failure");
            entity.Property(e => e.LastIpFailure)
                .HasMaxLength(255)
                .HasColumnName("last_ip_failure");
            entity.Property(e => e.NumFailures).HasColumnName("num_failures");
        });

        modelBuilder.Entity<WebOrigin>(entity =>
        {
            entity.HasKey(e => new { e.ClientId, e.Value }).HasName("constraint_web_origins");

            entity.ToTable("web_origins", "auth");

            entity.HasIndex(e => e.ClientId, "idx_web_orig_client");

            entity.Property(e => e.ClientId)
                .HasMaxLength(36)
                .HasColumnName("client_id");
            entity.Property(e => e.Value)
                .HasMaxLength(255)
                .HasColumnName("value");

            entity.HasOne(d => d.Client).WithMany(p => p.WebOrigins)
                .HasForeignKey(d => d.ClientId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_lojpho213xcx4wnkog82ssrfy");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
