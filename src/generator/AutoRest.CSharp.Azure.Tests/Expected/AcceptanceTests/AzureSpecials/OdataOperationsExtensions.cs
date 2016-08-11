// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Fixtures.Azure.AcceptanceTestsAzureSpecials
{
    using System.Threading.Tasks;
   using Microsoft.Rest.Azure;
   using Models;

    /// <summary>
    /// Extension methods for OdataOperations.
    /// </summary>
    public static partial class OdataOperationsExtensions
    {
            /// <summary>
            /// Specify filter parameter with value '$filter=id gt 5 and name eq
            /// 'foo'&amp;$orderby=id&amp;$top=10'
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            public static void GetWithFilter(this IOdataOperations operations, Microsoft.Rest.Azure.OData.ODataQuery<OdataFilter> odataQuery = default(Microsoft.Rest.Azure.OData.ODataQuery<OdataFilter>))
            {
                System.Threading.Tasks.Task.Factory.StartNew(s => ((IOdataOperations)s).GetWithFilterAsync(odataQuery), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None,  System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Specify filter parameter with value '$filter=id gt 5 and name eq
            /// 'foo'&amp;$orderby=id&amp;$top=10'
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task GetWithFilterAsync(this IOdataOperations operations, Microsoft.Rest.Azure.OData.ODataQuery<OdataFilter> odataQuery = default(Microsoft.Rest.Azure.OData.ODataQuery<OdataFilter>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                await operations.GetWithFilterWithHttpMessagesAsync(odataQuery, null, cancellationToken).ConfigureAwait(false);
            }

    }
}