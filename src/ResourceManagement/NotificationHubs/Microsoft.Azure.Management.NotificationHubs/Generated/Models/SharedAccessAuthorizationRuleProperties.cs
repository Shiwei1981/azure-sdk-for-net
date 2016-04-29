
namespace Microsoft.Azure.Management.NotificationHubs.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// SharedAccessAuthorizationRule properties.
    /// </summary>
    public partial class SharedAccessAuthorizationRuleProperties
    {
        /// <summary>
        /// Initializes a new instance of the
        /// SharedAccessAuthorizationRuleProperties class.
        /// </summary>
        public SharedAccessAuthorizationRuleProperties() { }

        /// <summary>
        /// Initializes a new instance of the
        /// SharedAccessAuthorizationRuleProperties class.
        /// </summary>
        public SharedAccessAuthorizationRuleProperties(string primaryKey = default(string), string secondaryKey = default(string), string keyName = default(string), string claimType = default(string), string claimValue = default(string), IList<AccessRights?> rights = default(IList<AccessRights?>), DateTime? createdTime = default(DateTime?), DateTime? modifiedTime = default(DateTime?), int? revision = default(int?))
        {
            PrimaryKey = primaryKey;
            SecondaryKey = secondaryKey;
            KeyName = keyName;
            ClaimType = claimType;
            ClaimValue = claimValue;
            Rights = rights;
            CreatedTime = createdTime;
            ModifiedTime = modifiedTime;
            Revision = revision;
        }

        /// <summary>
        /// The primary key that was used.
        /// </summary>
        [JsonProperty(PropertyName = "primaryKey")]
        public string PrimaryKey { get; set; }

        /// <summary>
        /// The secondary key that was used.
        /// </summary>
        [JsonProperty(PropertyName = "secondaryKey")]
        public string SecondaryKey { get; set; }

        /// <summary>
        /// The name of the key that was used.
        /// </summary>
        [JsonProperty(PropertyName = "keyName")]
        public string KeyName { get; set; }

        /// <summary>
        /// The type of the claim.
        /// </summary>
        [JsonProperty(PropertyName = "claimType")]
        public string ClaimType { get; set; }

        /// <summary>
        /// The value of the claim.
        /// </summary>
        [JsonProperty(PropertyName = "claimValue")]
        public string ClaimValue { get; set; }

        /// <summary>
        /// The rights associated with the rule.
        /// </summary>
        [JsonProperty(PropertyName = "rights")]
        public IList<AccessRights?> Rights { get; set; }

        /// <summary>
        /// The time at which the authorization rule was created.
        /// </summary>
        [JsonProperty(PropertyName = "createdTime")]
        public DateTime? CreatedTime { get; set; }

        /// <summary>
        /// The most recent time the rule was updated.
        /// </summary>
        [JsonProperty(PropertyName = "modifiedTime")]
        public DateTime? ModifiedTime { get; set; }

        /// <summary>
        /// The revision number for the rule.
        /// </summary>
        [JsonProperty(PropertyName = "revision")]
        public int? Revision { get; set; }

    }
}
