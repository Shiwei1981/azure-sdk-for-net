// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure.Management.SiteRecovery.Models;

namespace Microsoft.Azure.Management.SiteRecovery
{
    /// <summary>
    /// Definition of Protection Container operations for the Site Recovery
    /// extension.
    /// </summary>
    public partial interface IProtectionContainerOperations
    {
        /// <summary>
        /// Discovers a protectable item.
        /// </summary>
        /// <param name='fabricName'>
        /// Fabric name.
        /// </param>
        /// <param name='protectionContainerName'>
        /// Protection container name.
        /// </param>
        /// <param name='input'>
        /// Discover Protectable Item Request.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Request header parameters.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response for long running operations.
        /// </returns>
        Task<LongRunningOperationResponse> BeginDiscoverProtectableItemAsync(string fabricName, string protectionContainerName, DiscoverProtectableItemRequest input, CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken);
        
        /// <summary>
        /// Discovers a protectable item.
        /// </summary>
        /// <param name='fabricName'>
        /// Fabric name.
        /// </param>
        /// <param name='protectionContainerName'>
        /// Protection container name.
        /// </param>
        /// <param name='input'>
        /// Discover Protectable Item Request.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Request header parameters.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response for long running operations.
        /// </returns>
        Task<LongRunningOperationResponse> DiscoverProtectableItemAsync(string fabricName, string protectionContainerName, DiscoverProtectableItemRequest input, CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken);
        
        /// <summary>
        /// Get the protected container by Id.
        /// </summary>
        /// <param name='fabricName'>
        /// Fabric Name.
        /// </param>
        /// <param name='protectionContainerName'>
        /// Protection Container Name.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Request header parameters.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response model for the Protection Container object.
        /// </returns>
        Task<ProtectionContainerResponse> GetAsync(string fabricName, string protectionContainerName, CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken);
        
        /// <summary>
        /// The Get Operation Status operation returns the status of the
        /// specified operation. After calling an asynchronous operation, you
        /// can call Get Operation Status to determine whether the operation
        /// has succeeded, failed, or is still in progress.
        /// </summary>
        /// <param name='operationStatusLink'>
        /// Location value returned by the Begin operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Service response for operation which change status of protection
        /// container.
        /// </returns>
        Task<DiscoverProtectableItemResponse> GetDiscoverProtectableItemStatusAsync(string operationStatusLink, CancellationToken cancellationToken);
        
        /// <summary>
        /// Get the list of all ProtectionContainers for the given server.
        /// </summary>
        /// <param name='fabricName'>
        /// Fabric Unique name.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Request header parameters.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response model for the list ProtectionContainers operation.
        /// </returns>
        Task<ProtectionContainerListResponse> ListAsync(string fabricName, CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken);
        
        /// <summary>
        /// Get the list of all ProtectionContainers for the given vault.
        /// </summary>
        /// <param name='customRequestHeaders'>
        /// Request header parameters.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response model for the list ProtectionContainers operation.
        /// </returns>
        Task<ProtectionContainerListResponse> ListAllAsync(CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken);
    }
}
