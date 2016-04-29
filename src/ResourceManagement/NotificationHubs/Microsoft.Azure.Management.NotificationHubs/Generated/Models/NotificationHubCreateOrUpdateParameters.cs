
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
    /// Parameters supplied to the CreateOrUpdate NotificationHub operation.
    /// </summary>
    public partial class NotificationHubCreateOrUpdateParameters
    {
        /// <summary>
        /// Initializes a new instance of the
        /// NotificationHubCreateOrUpdateParameters class.
        /// </summary>
        public NotificationHubCreateOrUpdateParameters() { }

        /// <summary>
        /// Initializes a new instance of the
        /// NotificationHubCreateOrUpdateParameters class.
        /// </summary>
        public NotificationHubCreateOrUpdateParameters(string location, NotificationHubProperties properties, IDictionary<string, string> tags = default(IDictionary<string, string>))
        {
            Location = location;
            Tags = tags;
            Properties = properties;
        }

        /// <summary>
        /// Gets or sets NotificationHub data center location.
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; set; }

        /// <summary>
        /// Gets or sets NotificationHub tags.
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; set; }

        /// <summary>
        /// Gets or sets properties of the NotificationHub.
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public NotificationHubProperties Properties { get; set; }

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
