// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.EventGrid
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ExtensionTopicsOperations.
    /// </summary>
    public static partial class ExtensionTopicsOperationsExtensions
    {
            /// <summary>
            /// Get properties of an extension topic.
            /// </summary>
            /// <remarks>
            /// Get the properties of an extension topic.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// The identifier of the resource to which extension topic is queried. The
            /// scope can be a subscription, or a resource group, or a top level resource
            /// belonging to a resource provider namespace. For example, use
            /// '/subscriptions/{subscriptionId}/' for a subscription,
            /// '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}' for a
            /// resource group, and
            /// '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}'
            /// for Azure resource.
            /// </param>
            public static ExtensionTopic Get(this IExtensionTopicsOperations operations, string scope)
            {
                return operations.GetAsync(scope).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get properties of an extension topic.
            /// </summary>
            /// <remarks>
            /// Get the properties of an extension topic.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// The identifier of the resource to which extension topic is queried. The
            /// scope can be a subscription, or a resource group, or a top level resource
            /// belonging to a resource provider namespace. For example, use
            /// '/subscriptions/{subscriptionId}/' for a subscription,
            /// '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}' for a
            /// resource group, and
            /// '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}'
            /// for Azure resource.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ExtensionTopic> GetAsync(this IExtensionTopicsOperations operations, string scope, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(scope, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
