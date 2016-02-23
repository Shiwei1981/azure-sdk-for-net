// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.15.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DataLake.Analytics.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// A Data Lake Analytics catalog entity identifier object.
    /// </summary>
    public partial class EntityId
    {
        /// <summary>
        /// Initializes a new instance of the EntityId class.
        /// </summary>
        public EntityId() { }

        /// <summary>
        /// Initializes a new instance of the EntityId class.
        /// </summary>
        public EntityId(DdlName name = default(DdlName), string version = default(string))
        {
            Name = name;
            Version = version;
        }

        /// <summary>
        /// Gets or sets the name of the external table associated with this
        /// database, schema and table.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public DdlName Name { get; set; }

        /// <summary>
        /// Gets or sets the version of the external data source.
        /// </summary>
        [JsonProperty(PropertyName = "version")]
        public string Version { get; set; }

    }
}
