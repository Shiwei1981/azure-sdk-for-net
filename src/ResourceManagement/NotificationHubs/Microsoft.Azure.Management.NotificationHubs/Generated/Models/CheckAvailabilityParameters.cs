
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
    /// Parameters supplied to the Check Name Availability for Namespace and
    /// NotificationHubs.
    /// </summary>
    public partial class CheckAvailabilityParameters
    {
        /// <summary>
        /// Initializes a new instance of the CheckAvailabilityParameters
        /// class.
        /// </summary>
        public CheckAvailabilityParameters() { }

        /// <summary>
        /// Initializes a new instance of the CheckAvailabilityParameters
        /// class.
        /// </summary>
        public CheckAvailabilityParameters(string name, string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), bool? isAvailiable = default(bool?))
        {
            Name = name;
            Location = location;
            Tags = tags;
            IsAvailiable = isAvailiable;
        }

        /// <summary>
        /// Gets or sets name
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets location.
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; set; }

        /// <summary>
        /// Gets or sets tags.
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; set; }

        /// <summary>
        /// Gets or sets true if the name is available and can be used to
        /// create new Namespace/NotificationHub. Otherwise false.
        /// </summary>
        [JsonProperty(PropertyName = "isAvailiable")]
        public bool? IsAvailiable { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
        }
    }
}
