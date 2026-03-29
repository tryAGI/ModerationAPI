
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// 
    /// </summary>
    public enum NewModerateModerateRequestPolicieUrlMaskingEntitiesId
    {
        /// <summary>
        /// 
        /// </summary>
        Address,
        /// <summary>
        /// 
        /// </summary>
        CreditCard,
        /// <summary>
        /// 
        /// </summary>
        Email,
        /// <summary>
        /// 
        /// </summary>
        IpAddress,
        /// <summary>
        /// 
        /// </summary>
        Name,
        /// <summary>
        /// 
        /// </summary>
        Phone,
        /// <summary>
        /// 
        /// </summary>
        SensitiveOther,
        /// <summary>
        /// 
        /// </summary>
        Url,
        /// <summary>
        /// 
        /// </summary>
        Username,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class NewModerateModerateRequestPolicieUrlMaskingEntitiesIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NewModerateModerateRequestPolicieUrlMaskingEntitiesId value)
        {
            return value switch
            {
                NewModerateModerateRequestPolicieUrlMaskingEntitiesId.Address => "address",
                NewModerateModerateRequestPolicieUrlMaskingEntitiesId.CreditCard => "credit_card",
                NewModerateModerateRequestPolicieUrlMaskingEntitiesId.Email => "email",
                NewModerateModerateRequestPolicieUrlMaskingEntitiesId.IpAddress => "ip_address",
                NewModerateModerateRequestPolicieUrlMaskingEntitiesId.Name => "name",
                NewModerateModerateRequestPolicieUrlMaskingEntitiesId.Phone => "phone",
                NewModerateModerateRequestPolicieUrlMaskingEntitiesId.SensitiveOther => "sensitive_other",
                NewModerateModerateRequestPolicieUrlMaskingEntitiesId.Url => "url",
                NewModerateModerateRequestPolicieUrlMaskingEntitiesId.Username => "username",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NewModerateModerateRequestPolicieUrlMaskingEntitiesId? ToEnum(string value)
        {
            return value switch
            {
                "address" => NewModerateModerateRequestPolicieUrlMaskingEntitiesId.Address,
                "credit_card" => NewModerateModerateRequestPolicieUrlMaskingEntitiesId.CreditCard,
                "email" => NewModerateModerateRequestPolicieUrlMaskingEntitiesId.Email,
                "ip_address" => NewModerateModerateRequestPolicieUrlMaskingEntitiesId.IpAddress,
                "name" => NewModerateModerateRequestPolicieUrlMaskingEntitiesId.Name,
                "phone" => NewModerateModerateRequestPolicieUrlMaskingEntitiesId.Phone,
                "sensitive_other" => NewModerateModerateRequestPolicieUrlMaskingEntitiesId.SensitiveOther,
                "url" => NewModerateModerateRequestPolicieUrlMaskingEntitiesId.Url,
                "username" => NewModerateModerateRequestPolicieUrlMaskingEntitiesId.Username,
                _ => null,
            };
        }
    }
}