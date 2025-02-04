﻿// Copyright Finbuckle LLC, Andrew White, and Contributors.
// Refer to the solution LICENSE file for more inforation.

using Finbuckle.MultiTenant;

namespace PerTenantAuthenticationSample
{
    public class SampleTenantInfo : ITenantInfo
    {
        public string Id { get; set; }
        public string Identifier { get; set; }
        public string Name { get; set; }
        public string ConnectionString { get; set; }
        
        public string ChallengeScheme { get; set; }

        public string CookiePath { get; set; }
        public string CookieLoginPath { get; set; }
        public string CookieLogoutPath { get; set; }

        public string OpenIdConnectAuthority { get; set; }
        public string OpenIdConnectClientId { get; set; }
        public string OpenIdConnectClientSecret { get; set; }
    }
}