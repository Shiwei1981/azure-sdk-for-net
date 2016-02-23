// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.15.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DataLake.Store.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Data Lake Store file or directory Access Control List information.
    /// </summary>
    public partial class AclStatusResult
    {
        /// <summary>
        /// Initializes a new instance of the AclStatusResult class.
        /// </summary>
        public AclStatusResult() { }

        /// <summary>
        /// Initializes a new instance of the AclStatusResult class.
        /// </summary>
        public AclStatusResult(AclStatus aclStatus = default(AclStatus))
        {
            AclStatus = aclStatus;
        }

        /// <summary>
        /// Gets or sets the AclStatus object for a given file or directory.
        /// </summary>
        [JsonProperty(PropertyName = "AclStatus")]
        public AclStatus AclStatus { get; set; }

    }
}
