// Code generated by Microsoft (R) AutoRest Code Generator 0.12.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.WebSites
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;

    public static partial class TopLevelDomainsOperationsExtensions
    {
            /// <summary>
            /// Lists all top level domains supported for registration
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static TopLevelDomainCollection GetGetTopLevelDomains(this ITopLevelDomainsOperations operations)
            {
                return Task.Factory.StartNew(s => ((ITopLevelDomainsOperations)s).GetGetTopLevelDomainsAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all top level domains supported for registration
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<TopLevelDomainCollection> GetGetTopLevelDomainsAsync( this ITopLevelDomainsOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<TopLevelDomainCollection> result = await operations.GetGetTopLevelDomainsWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// Gets details of a top level domain
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='name'>
            /// Name of the top level domain
            /// </param>
            public static TopLevelDomain GetTopLevelDomain(this ITopLevelDomainsOperations operations, string name)
            {
                return Task.Factory.StartNew(s => ((ITopLevelDomainsOperations)s).GetTopLevelDomainAsync(name), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets details of a top level domain
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='name'>
            /// Name of the top level domain
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<TopLevelDomain> GetTopLevelDomainAsync( this ITopLevelDomainsOperations operations, string name, CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<TopLevelDomain> result = await operations.GetTopLevelDomainWithHttpMessagesAsync(name, null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// Lists legal agreements that user needs to accept before purchasing domain
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='name'>
            /// Name of the top level domain
            /// </param>
            /// <param name='agreementOption'>
            /// Domain agreement options
            /// </param>
            public static TldLegalAgreementCollection ListTopLevelDomainAgreements(this ITopLevelDomainsOperations operations, string name, TopLevelDomainAgreementOption agreementOption)
            {
                return Task.Factory.StartNew(s => ((ITopLevelDomainsOperations)s).ListTopLevelDomainAgreementsAsync(name, agreementOption), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists legal agreements that user needs to accept before purchasing domain
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='name'>
            /// Name of the top level domain
            /// </param>
            /// <param name='agreementOption'>
            /// Domain agreement options
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<TldLegalAgreementCollection> ListTopLevelDomainAgreementsAsync( this ITopLevelDomainsOperations operations, string name, TopLevelDomainAgreementOption agreementOption, CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<TldLegalAgreementCollection> result = await operations.ListTopLevelDomainAgreementsWithHttpMessagesAsync(name, agreementOption, null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

    }
}