
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// 
    /// </summary>
    public enum NewModerateModerateRequestPoliciePiiMaskingEntitiesId
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
    public static class NewModerateModerateRequestPoliciePiiMaskingEntitiesIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NewModerateModerateRequestPoliciePiiMaskingEntitiesId value)
        {
            return value switch
            {
                NewModerateModerateRequestPoliciePiiMaskingEntitiesId.Address => "address",
                NewModerateModerateRequestPoliciePiiMaskingEntitiesId.CreditCard => "credit_card",
                NewModerateModerateRequestPoliciePiiMaskingEntitiesId.Email => "email",
                NewModerateModerateRequestPoliciePiiMaskingEntitiesId.IpAddress => "ip_address",
                NewModerateModerateRequestPoliciePiiMaskingEntitiesId.Name => "name",
                NewModerateModerateRequestPoliciePiiMaskingEntitiesId.Phone => "phone",
                NewModerateModerateRequestPoliciePiiMaskingEntitiesId.SensitiveOther => "sensitive_other",
                NewModerateModerateRequestPoliciePiiMaskingEntitiesId.Url => "url",
                NewModerateModerateRequestPoliciePiiMaskingEntitiesId.Username => "username",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NewModerateModerateRequestPoliciePiiMaskingEntitiesId? ToEnum(string value)
        {
            return value switch
            {
                "address" => NewModerateModerateRequestPoliciePiiMaskingEntitiesId.Address,
                "credit_card" => NewModerateModerateRequestPoliciePiiMaskingEntitiesId.CreditCard,
                "email" => NewModerateModerateRequestPoliciePiiMaskingEntitiesId.Email,
                "ip_address" => NewModerateModerateRequestPoliciePiiMaskingEntitiesId.IpAddress,
                "name" => NewModerateModerateRequestPoliciePiiMaskingEntitiesId.Name,
                "phone" => NewModerateModerateRequestPoliciePiiMaskingEntitiesId.Phone,
                "sensitive_other" => NewModerateModerateRequestPoliciePiiMaskingEntitiesId.SensitiveOther,
                "url" => NewModerateModerateRequestPoliciePiiMaskingEntitiesId.Url,
                "username" => NewModerateModerateRequestPoliciePiiMaskingEntitiesId.Username,
                _ => null,
            };
        }
    }
}