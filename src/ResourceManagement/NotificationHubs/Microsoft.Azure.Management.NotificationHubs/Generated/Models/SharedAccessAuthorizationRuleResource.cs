
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
    /// Description of a Namespace AuthorizationRules.
    /// </summary>
    public partial class SharedAccessAuthorizationRuleResource
    {
        /// <summary>
        /// Initializes a new instance of the
        /// SharedAccessAuthorizationRuleResource class.
        /// </summary>
        public SharedAccessAuthorizationRuleResource() { }

        /// <summary>
        /// Initializes a new instance of the
        /// SharedAccessAuthorizationRuleResource class.
        /// </summary>
        public SharedAccessAuthorizationRuleResource(string id = default(string), string location = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), SharedAccessAuthorizationRuleProperties properties = default(SharedAccessAuthorizationRuleProperties))
        {
            Id = id;
            Location = location;
            Name = name;
            Type = type;
            Tags = tags;
            Properties = properties;
        }

        /// <summary>
        /// Gets or sets the id of the created Namespace AuthorizationRules.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets datacenter location of the Namespace
        /// AuthorizationRules.
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; set; }

        /// <summary>
        /// Gets or sets name of the Namespace AuthorizationRules.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets resource type of the Namespace AuthorizationRules.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets tags of the Namespace AuthorizationRules.
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; set; }

        /// <summary>
        /// Gets or sets properties of the Namespace.
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public SharedAccessAuthorizationRuleProperties Properties { get; set; }

    }
}
