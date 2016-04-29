
namespace Microsoft.Azure.Management.NotificationHubs
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// NotificationHubsOperations operations.
    /// </summary>
    public partial interface INotificationHubsOperations
    {
        /// <summary>
        /// Checks the availability of the given notificationHub in a
        /// namespace.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='namespaceName'>
        /// The namespace name.
        /// </param>
        /// <param name='parameters'>
        /// The notificationHub name.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<CheckAvailabilityResource>> CheckAvailabilityWithHttpMessagesAsync(string resourceGroupName, string namespaceName, CheckAvailabilityParameters parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Creates/Update a NotificationHub in a namespace.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='namespaceName'>
        /// The namespace name.
        /// </param>
        /// <param name='notificationHubName'>
        /// The notification hub name.
        /// </param>
        /// <param name='parameters'>
        /// Parameters supplied to the create/update a NotificationHub
        /// Resource.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<NotificationHubResource>> CreateOrUpdateWithHttpMessagesAsync(string resourceGroupName, string namespaceName, string notificationHubName, NotificationHubCreateOrUpdateParameters parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes a notification hub associated with a namespace.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='namespaceName'>
        /// The namespace name.
        /// </param>
        /// <param name='notificationHubName'>
        /// The notification hub name.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse> DeleteWithHttpMessagesAsync(string resourceGroupName, string namespaceName, string notificationHubName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Lists the notification hubs associated with a namespace.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='namespaceName'>
        /// The namespace name.
        /// </param>
        /// <param name='notificationHubName'>
        /// The notification hub name.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<NotificationHubResource>> GetWithHttpMessagesAsync(string resourceGroupName, string namespaceName, string notificationHubName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Creates/Updates an authorization rule for a NotificationHub
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='namespaceName'>
        /// The namespace name.
        /// </param>
        /// <param name='notificationHubName'>
        /// The notification hub name.
        /// </param>
        /// <param name='authorizationRuleName'>
        /// Authorization Rule Name.
        /// </param>
        /// <param name='parameters'>
        /// The shared access authorization rule.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<SharedAccessAuthorizationRuleResource>> CreateOrUpdateAuthorizationRuleWithHttpMessagesAsync(string resourceGroupName, string namespaceName, string notificationHubName, string authorizationRuleName, SharedAccessAuthorizationRuleCreateOrUpdateParameters parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes a notificationHub authorization rule
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='namespaceName'>
        /// The namespace name.
        /// </param>
        /// <param name='notificationHubName'>
        /// The notification hub name.
        /// </param>
        /// <param name='authorizationRuleName'>
        /// Authorization Rule Name.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse> DeleteAuthorizationRuleWithHttpMessagesAsync(string resourceGroupName, string namespaceName, string notificationHubName, string authorizationRuleName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets an authorization rule for a NotificationHub by name.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='namespaceName'>
        /// The namespace name
        /// </param>
        /// <param name='notificationHubName'>
        /// The notification hub name.
        /// </param>
        /// <param name='authorizationRuleName'>
        /// authorization rule name.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<SharedAccessAuthorizationRuleResource>> GetAuthorizationRuleWithHttpMessagesAsync(string resourceGroupName, string namespaceName, string notificationHubName, string authorizationRuleName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Lists the notification hubs associated with a namespace.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='namespaceName'>
        /// The namespace name.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IPage<NotificationHubResource>>> ListWithHttpMessagesAsync(string resourceGroupName, string namespaceName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the authorization rules for a NotificationHub.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='namespaceName'>
        /// The namespace name
        /// </param>
        /// <param name='notificationHubName'>
        /// The notification hub name.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IPage<SharedAccessAuthorizationRuleResource>>> ListAuthorizationRulesWithHttpMessagesAsync(string resourceGroupName, string namespaceName, string notificationHubName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the Primary and Secondary ConnectionStrings to the
        /// NotificationHub
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='namespaceName'>
        /// The namespace name.
        /// </param>
        /// <param name='notificationHubName'>
        /// The notification hub name.
        /// </param>
        /// <param name='authorizationRuleName'>
        /// The connection string of the NotificationHub for the specified
        /// authorizationRule.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<ResourceListKeys>> ListKeysWithHttpMessagesAsync(string resourceGroupName, string namespaceName, string notificationHubName, string authorizationRuleName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Lists the PNS Credentials associated with a notification hub .
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='namespaceName'>
        /// The namespace name.
        /// </param>
        /// <param name='notificationHubName'>
        /// The notification hub name.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<NotificationHubResource>> GetPnsCredentialsWithHttpMessagesAsync(string resourceGroupName, string namespaceName, string notificationHubName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Lists the notification hubs associated with a namespace.
        /// </summary>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IPage<NotificationHubResource>>> ListNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the authorization rules for a NotificationHub.
        /// </summary>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IPage<SharedAccessAuthorizationRuleResource>>> ListAuthorizationRulesNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
