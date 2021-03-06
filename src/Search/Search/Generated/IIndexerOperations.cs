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
using Microsoft.Azure;
using Microsoft.Azure.Search.Models;

namespace Microsoft.Azure.Search
{
    /// <summary>
    /// Operations for managing indexers.  (see
    /// https://msdn.microsoft.com/library/azure/dn946891.aspx for more
    /// information)
    /// </summary>
    public partial interface IIndexerOperations
    {
        /// <summary>
        /// Creates a new Azure Search indexer.  (see
        /// https://msdn.microsoft.com/library/azure/dn946899.aspx for more
        /// information)
        /// </summary>
        /// <param name='indexer'>
        /// The definition of the indexer to create.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Response from a Create, Update, or Get Indexer request. If
        /// successful, it includes the full definition of the indexer that
        /// was created, updated, or retrieved.
        /// </returns>
        Task<IndexerDefinitionResponse> CreateAsync(Indexer indexer, CancellationToken cancellationToken);
        
        /// <summary>
        /// Creates a new Azure Search indexer or updates an indexer if it
        /// already exists.  (see
        /// https://msdn.microsoft.com/library/azure/dn946899.aspx for more
        /// information)
        /// </summary>
        /// <param name='indexer'>
        /// The definition of the indexer to create or update.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Response from a Create, Update, or Get Indexer request. If
        /// successful, it includes the full definition of the indexer that
        /// was created, updated, or retrieved.
        /// </returns>
        Task<IndexerDefinitionResponse> CreateOrUpdateAsync(Indexer indexer, CancellationToken cancellationToken);
        
        /// <summary>
        /// Deletes an Azure Search indexer.  (see
        /// https://msdn.microsoft.com/library/azure/dn946898.aspx for more
        /// information)
        /// </summary>
        /// <param name='indexerName'>
        /// The name of the indexer to delete.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<AzureOperationResponse> DeleteAsync(string indexerName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Retrieves an indexer definition from Azure Search.  (see
        /// https://msdn.microsoft.com/library/azure/dn946874.aspx for more
        /// information)
        /// </summary>
        /// <param name='indexerName'>
        /// The name of the indexer to retrieve.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Response from a Create, Update, or Get Indexer request. If
        /// successful, it includes the full definition of the indexer that
        /// was created, updated, or retrieved.
        /// </returns>
        Task<IndexerDefinitionResponse> GetAsync(string indexerName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Returns the current status and execution history of an indexer.
        /// (see https://msdn.microsoft.com/library/azure/dn946884.aspx for
        /// more information)
        /// </summary>
        /// <param name='indexerName'>
        /// The name of the indexer for which to retrieve status.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Current status and execution history of an indexer.
        /// </returns>
        Task<IndexerGetStatusResponse> GetStatusAsync(string indexerName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Lists all datasources available for an Azure Search service.  (see
        /// https://msdn.microsoft.com/library/azure/dn946883.aspx for more
        /// information)
        /// </summary>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Response from a List Indexers request. If successful, it includes
        /// the full definitions of all indexers.
        /// </returns>
        Task<IndexerListResponse> ListAsync(CancellationToken cancellationToken);
        
        /// <summary>
        /// Resets the change tracking state associated with an Azure Search
        /// indexer.  (see
        /// https://msdn.microsoft.com/library/azure/dn946897.aspx for more
        /// information)
        /// </summary>
        /// <param name='indexerName'>
        /// The name of the indexer to reset.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<AzureOperationResponse> ResetAsync(string indexerName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Runs an Azure Search indexer on-demand.  (see
        /// https://msdn.microsoft.com/library/azure/dn946885.aspx for more
        /// information)
        /// </summary>
        /// <param name='indexerName'>
        /// The name of the indexer to run.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<AzureOperationResponse> RunAsync(string indexerName, CancellationToken cancellationToken);
    }
}
