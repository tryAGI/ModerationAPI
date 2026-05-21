
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// 
    /// </summary>
    public enum NewModerateModerateResponsePolicieEntityMatcherOutputMatcheSignalsBrandImpersonationMethod
    {
        /// <summary>
        /// 
        /// </summary>
        RegisteredDomainToken,
        /// <summary>
        /// 
        /// </summary>
        SubdomainToken,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class NewModerateModerateResponsePolicieEntityMatcherOutputMatcheSignalsBrandImpersonationMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NewModerateModerateResponsePolicieEntityMatcherOutputMatcheSignalsBrandImpersonationMethod value)
        {
            return value switch
            {
                NewModerateModerateResponsePolicieEntityMatcherOutputMatcheSignalsBrandImpersonationMethod.RegisteredDomainToken => "registered_domain_token",
                NewModerateModerateResponsePolicieEntityMatcherOutputMatcheSignalsBrandImpersonationMethod.SubdomainToken => "subdomain_token",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NewModerateModerateResponsePolicieEntityMatcherOutputMatcheSignalsBrandImpersonationMethod? ToEnum(string value)
        {
            return value switch
            {
                "registered_domain_token" => NewModerateModerateResponsePolicieEntityMatcherOutputMatcheSignalsBrandImpersonationMethod.RegisteredDomainToken,
                "subdomain_token" => NewModerateModerateResponsePolicieEntityMatcherOutputMatcheSignalsBrandImpersonationMethod.SubdomainToken,
                _ => null,
            };
        }
    }
}