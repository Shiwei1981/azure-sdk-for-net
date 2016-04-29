
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
    /// Description of a NotificationHub ApnsCredential.
    /// </summary>
    public partial class ApnsCredentialProperties
    {
        /// <summary>
        /// Initializes a new instance of the ApnsCredentialProperties class.
        /// </summary>
        public ApnsCredentialProperties() { }

        /// <summary>
        /// Initializes a new instance of the ApnsCredentialProperties class.
        /// </summary>
        public ApnsCredentialProperties(string apnsCertificate = default(string), string certificateKey = default(string), string endpoint = default(string), string thumbprint = default(string))
        {
            ApnsCertificate = apnsCertificate;
            CertificateKey = certificateKey;
            Endpoint = endpoint;
            Thumbprint = thumbprint;
        }

        /// <summary>
        /// Gets or sets the APNS certificate.
        /// </summary>
        [JsonProperty(PropertyName = "apnsCertificate")]
        public string ApnsCertificate { get; set; }

        /// <summary>
        /// Gets or sets the certificate key.
        /// </summary>
        [JsonProperty(PropertyName = "certificateKey")]
        public string CertificateKey { get; set; }

        /// <summary>
        /// Gets or sets the endpoint of this credential.
        /// </summary>
        [JsonProperty(PropertyName = "endpoint")]
        public string Endpoint { get; set; }

        /// <summary>
        /// Gets or sets the Apns certificate Thumbprint
        /// </summary>
        [JsonProperty(PropertyName = "thumbprint")]
        public string Thumbprint { get; set; }

    }
}
