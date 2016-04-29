
namespace Microsoft.Azure.Management.NotificationHubs
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// Extension methods for NotificationHubsOperations.
    /// </summary>
    public static partial class NotificationHubsOperationsExtensions
    {
            /// <summary>
            /// Checks the availability of the given notificationHub in a namespace.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name.
            /// </param>
            /// <param name='parameters'>
            /// The notificationHub name.
            /// </param>
            public static CheckAvailabilityResource CheckAvailability(this INotificationHubsOperations operations, string resourceGroupName, string namespaceName, CheckAvailabilityParameters parameters)
            {
                return Task.Factory.StartNew(s => ((INotificationHubsOperations)s).CheckAvailabilityAsync(resourceGroupName, namespaceName, parameters), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Checks the availability of the given notificationHub in a namespace.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name.
            /// </param>
            /// <param name='parameters'>
            /// The notificationHub name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<CheckAvailabilityResource> CheckAvailabilityAsync(this INotificationHubsOperations operations, string resourceGroupName, string namespaceName, CheckAvailabilityParameters parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CheckAvailabilityWithHttpMessagesAsync(resourceGroupName, namespaceName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates/Update a NotificationHub in a namespace.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
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
            /// Parameters supplied to the create/update a NotificationHub Resource.
            /// </param>
            public static NotificationHubResource CreateOrUpdate(this INotificationHubsOperations operations, string resourceGroupName, string namespaceName, string notificationHubName, NotificationHubCreateOrUpdateParameters parameters)
            {
                return Task.Factory.StartNew(s => ((INotificationHubsOperations)s).CreateOrUpdateAsync(resourceGroupName, namespaceName, notificationHubName, parameters), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates/Update a NotificationHub in a namespace.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
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
            /// Parameters supplied to the create/update a NotificationHub Resource.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<NotificationHubResource> CreateOrUpdateAsync(this INotificationHubsOperations operations, string resourceGroupName, string namespaceName, string notificationHubName, NotificationHubCreateOrUpdateParameters parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, namespaceName, notificationHubName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a notification hub associated with a namespace.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name.
            /// </param>
            /// <param name='notificationHubName'>
            /// The notification hub name.
            /// </param>
            public static void Delete(this INotificationHubsOperations operations, string resourceGroupName, string namespaceName, string notificationHubName)
            {
                Task.Factory.StartNew(s => ((INotificationHubsOperations)s).DeleteAsync(resourceGroupName, namespaceName, notificationHubName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a notification hub associated with a namespace.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name.
            /// </param>
            /// <param name='notificationHubName'>
            /// The notification hub name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this INotificationHubsOperations operations, string resourceGroupName, string namespaceName, string notificationHubName, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.DeleteWithHttpMessagesAsync(resourceGroupName, namespaceName, notificationHubName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Lists the notification hubs associated with a namespace.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name.
            /// </param>
            /// <param name='notificationHubName'>
            /// The notification hub name.
            /// </param>
            public static NotificationHubResource Get(this INotificationHubsOperations operations, string resourceGroupName, string namespaceName, string notificationHubName)
            {
                return Task.Factory.StartNew(s => ((INotificationHubsOperations)s).GetAsync(resourceGroupName, namespaceName, notificationHubName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the notification hubs associated with a namespace.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name.
            /// </param>
            /// <param name='notificationHubName'>
            /// The notification hub name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<NotificationHubResource> GetAsync(this INotificationHubsOperations operations, string resourceGroupName, string namespaceName, string notificationHubName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, namespaceName, notificationHubName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates/Updates an authorization rule for a NotificationHub
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
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
            public static SharedAccessAuthorizationRuleResource CreateOrUpdateAuthorizationRule(this INotificationHubsOperations operations, string resourceGroupName, string namespaceName, string notificationHubName, string authorizationRuleName, SharedAccessAuthorizationRuleCreateOrUpdateParameters parameters)
            {
                return Task.Factory.StartNew(s => ((INotificationHubsOperations)s).CreateOrUpdateAuthorizationRuleAsync(resourceGroupName, namespaceName, notificationHubName, authorizationRuleName, parameters), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates/Updates an authorization rule for a NotificationHub
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
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
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SharedAccessAuthorizationRuleResource> CreateOrUpdateAuthorizationRuleAsync(this INotificationHubsOperations operations, string resourceGroupName, string namespaceName, string notificationHubName, string authorizationRuleName, SharedAccessAuthorizationRuleCreateOrUpdateParameters parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateAuthorizationRuleWithHttpMessagesAsync(resourceGroupName, namespaceName, notificationHubName, authorizationRuleName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a notificationHub authorization rule
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
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
            public static void DeleteAuthorizationRule(this INotificationHubsOperations operations, string resourceGroupName, string namespaceName, string notificationHubName, string authorizationRuleName)
            {
                Task.Factory.StartNew(s => ((INotificationHubsOperations)s).DeleteAuthorizationRuleAsync(resourceGroupName, namespaceName, notificationHubName, authorizationRuleName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a notificationHub authorization rule
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
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
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAuthorizationRuleAsync(this INotificationHubsOperations operations, string resourceGroupName, string namespaceName, string notificationHubName, string authorizationRuleName, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.DeleteAuthorizationRuleWithHttpMessagesAsync(resourceGroupName, namespaceName, notificationHubName, authorizationRuleName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Gets an authorization rule for a NotificationHub by name.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
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
            public static SharedAccessAuthorizationRuleResource GetAuthorizationRule(this INotificationHubsOperations operations, string resourceGroupName, string namespaceName, string notificationHubName, string authorizationRuleName)
            {
                return Task.Factory.StartNew(s => ((INotificationHubsOperations)s).GetAuthorizationRuleAsync(resourceGroupName, namespaceName, notificationHubName, authorizationRuleName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets an authorization rule for a NotificationHub by name.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
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
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SharedAccessAuthorizationRuleResource> GetAuthorizationRuleAsync(this INotificationHubsOperations operations, string resourceGroupName, string namespaceName, string notificationHubName, string authorizationRuleName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetAuthorizationRuleWithHttpMessagesAsync(resourceGroupName, namespaceName, notificationHubName, authorizationRuleName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists the notification hubs associated with a namespace.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name.
            /// </param>
            public static IPage<NotificationHubResource> List(this INotificationHubsOperations operations, string resourceGroupName, string namespaceName)
            {
                return Task.Factory.StartNew(s => ((INotificationHubsOperations)s).ListAsync(resourceGroupName, namespaceName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the notification hubs associated with a namespace.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<NotificationHubResource>> ListAsync(this INotificationHubsOperations operations, string resourceGroupName, string namespaceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, namespaceName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the authorization rules for a NotificationHub.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name
            /// </param>
            /// <param name='notificationHubName'>
            /// The notification hub name.
            /// </param>
            public static IPage<SharedAccessAuthorizationRuleResource> ListAuthorizationRules(this INotificationHubsOperations operations, string resourceGroupName, string namespaceName, string notificationHubName)
            {
                return Task.Factory.StartNew(s => ((INotificationHubsOperations)s).ListAuthorizationRulesAsync(resourceGroupName, namespaceName, notificationHubName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the authorization rules for a NotificationHub.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name
            /// </param>
            /// <param name='notificationHubName'>
            /// The notification hub name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<SharedAccessAuthorizationRuleResource>> ListAuthorizationRulesAsync(this INotificationHubsOperations operations, string resourceGroupName, string namespaceName, string notificationHubName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListAuthorizationRulesWithHttpMessagesAsync(resourceGroupName, namespaceName, notificationHubName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the Primary and Secondary ConnectionStrings to the NotificationHub
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
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
            public static ResourceListKeys ListKeys(this INotificationHubsOperations operations, string resourceGroupName, string namespaceName, string notificationHubName, string authorizationRuleName)
            {
                return Task.Factory.StartNew(s => ((INotificationHubsOperations)s).ListKeysAsync(resourceGroupName, namespaceName, notificationHubName, authorizationRuleName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the Primary and Secondary ConnectionStrings to the NotificationHub
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
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
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ResourceListKeys> ListKeysAsync(this INotificationHubsOperations operations, string resourceGroupName, string namespaceName, string notificationHubName, string authorizationRuleName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListKeysWithHttpMessagesAsync(resourceGroupName, namespaceName, notificationHubName, authorizationRuleName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists the PNS Credentials associated with a notification hub .
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name.
            /// </param>
            /// <param name='notificationHubName'>
            /// The notification hub name.
            /// </param>
            public static NotificationHubResource GetPnsCredentials(this INotificationHubsOperations operations, string resourceGroupName, string namespaceName, string notificationHubName)
            {
                return Task.Factory.StartNew(s => ((INotificationHubsOperations)s).GetPnsCredentialsAsync(resourceGroupName, namespaceName, notificationHubName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the PNS Credentials associated with a notification hub .
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name.
            /// </param>
            /// <param name='notificationHubName'>
            /// The notification hub name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<NotificationHubResource> GetPnsCredentialsAsync(this INotificationHubsOperations operations, string resourceGroupName, string namespaceName, string notificationHubName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetPnsCredentialsWithHttpMessagesAsync(resourceGroupName, namespaceName, notificationHubName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists the notification hubs associated with a namespace.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<NotificationHubResource> ListNext(this INotificationHubsOperations operations, string nextPageLink)
            {
                return Task.Factory.StartNew(s => ((INotificationHubsOperations)s).ListNextAsync(nextPageLink), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the notification hubs associated with a namespace.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<NotificationHubResource>> ListNextAsync(this INotificationHubsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the authorization rules for a NotificationHub.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<SharedAccessAuthorizationRuleResource> ListAuthorizationRulesNext(this INotificationHubsOperations operations, string nextPageLink)
            {
                return Task.Factory.StartNew(s => ((INotificationHubsOperations)s).ListAuthorizationRulesNextAsync(nextPageLink), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the authorization rules for a NotificationHub.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<SharedAccessAuthorizationRuleResource>> ListAuthorizationRulesNextAsync(this INotificationHubsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListAuthorizationRulesNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
