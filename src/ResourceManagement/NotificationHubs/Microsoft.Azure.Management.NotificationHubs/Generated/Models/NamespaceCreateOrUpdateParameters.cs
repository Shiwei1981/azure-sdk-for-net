
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
    /// Parameters supplied to the CreateOrUpdate Namespace operation.
    /// </summary>
    public partial class NamespaceCreateOrUpdateParameters
    {
        /// <summary>
        /// Initializes a new instance of the
        /// NamespaceCreateOrUpdateParameters class.
        /// </summary>
        public NamespaceCreateOrUpdateParameters() { }

        /// <summary>
        /// Initializes a new instance of the
        /// NamespaceCreateOrUpdateParameters class.
        /// </summary>
        public NamespaceCreateOrUpdateParameters(string location, NamespaceProperties properties, IDictionary<string, string> tags = default(IDictionary<string, string>))
        {
            Location = location;
            Tags = tags;
            Properties = properties;
        }

        /// <summary>
        /// Gets or sets Namespace data center location.
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; set; }

        /// <summary>
        /// Gets or sets Namespace tags.
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; set; }

        /// <summary>
        /// Gets or sets properties of the Namespace.
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public NamespaceProperties Properties { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (Location == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Location");
            }
            if (Properties == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Properties");
            }
        }
    }
}
