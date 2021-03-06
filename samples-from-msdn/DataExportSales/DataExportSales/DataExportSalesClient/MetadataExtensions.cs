// Code generated by Microsoft (R) AutoRest Code Generator 0.9.7.0
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using DataExportSales;
using Microsoft.Rest;

namespace DataExportSales
{
    public static partial class MetadataExtensions
    {
        /// <param name='operations'>
        /// Reference to the DataExportSales.IMetadata.
        /// </param>
        /// <param name='organizationUrl'>
        /// Required. The organization url
        /// </param>
        /// <param name='organizationId'>
        /// Required. The organization ID
        /// </param>
        /// <param name='isAuthorized'>
        /// Required. The isAuthorized parameter
        /// </param>
        public static object AcceptOrgPrivacyTerms(this IMetadata operations, string organizationUrl, string organizationId, bool isAuthorized)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IMetadata)s).AcceptOrgPrivacyTermsAsync(organizationUrl, organizationId, isAuthorized);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <param name='operations'>
        /// Reference to the DataExportSales.IMetadata.
        /// </param>
        /// <param name='organizationUrl'>
        /// Required. The organization url
        /// </param>
        /// <param name='organizationId'>
        /// Required. The organization ID
        /// </param>
        /// <param name='isAuthorized'>
        /// Required. The isAuthorized parameter
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public static async Task<object> AcceptOrgPrivacyTermsAsync(this IMetadata operations, string organizationUrl, string organizationId, bool isAuthorized, CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Microsoft.Rest.HttpOperationResponse<object> result = await operations.AcceptOrgPrivacyTermsWithOperationResponseAsync(organizationUrl, organizationId, isAuthorized, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }
        
        /// <param name='operations'>
        /// Reference to the DataExportSales.IMetadata.
        /// </param>
        /// <param name='organizationUrl'>
        /// Required. Organization URL
        /// </param>
        /// <param name='organizationId'>
        /// Required. Organization Id
        /// </param>
        public static object GetConnectorDetails(this IMetadata operations, string organizationUrl, string organizationId)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IMetadata)s).GetConnectorDetailsAsync(organizationUrl, organizationId);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <param name='operations'>
        /// Reference to the DataExportSales.IMetadata.
        /// </param>
        /// <param name='organizationUrl'>
        /// Required. Organization URL
        /// </param>
        /// <param name='organizationId'>
        /// Required. Organization Id
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public static async Task<object> GetConnectorDetailsAsync(this IMetadata operations, string organizationUrl, string organizationId, CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Microsoft.Rest.HttpOperationResponse<object> result = await operations.GetConnectorDetailsWithOperationResponseAsync(organizationUrl, organizationId, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }
        
        /// <param name='operations'>
        /// Reference to the DataExportSales.IMetadata.
        /// </param>
        /// <param name='organizationUrl'>
        /// Required. Organization URL
        /// </param>
        public static object GetEntities(this IMetadata operations, string organizationUrl)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IMetadata)s).GetEntitiesAsync(organizationUrl);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <param name='operations'>
        /// Reference to the DataExportSales.IMetadata.
        /// </param>
        /// <param name='organizationUrl'>
        /// Required. Organization URL
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public static async Task<object> GetEntitiesAsync(this IMetadata operations, string organizationUrl, CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Microsoft.Rest.HttpOperationResponse<object> result = await operations.GetEntitiesWithOperationResponseAsync(organizationUrl, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }
        
        /// <param name='operations'>
        /// Reference to the DataExportSales.IMetadata.
        /// </param>
        public static object GetOrganizations(this IMetadata operations)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IMetadata)s).GetOrganizationsAsync();
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <param name='operations'>
        /// Reference to the DataExportSales.IMetadata.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public static async Task<object> GetOrganizationsAsync(this IMetadata operations, CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Microsoft.Rest.HttpOperationResponse<object> result = await operations.GetOrganizationsWithOperationResponseAsync(cancellationToken).ConfigureAwait(false);
            return result.Body;
        }
        
        /// <param name='operations'>
        /// Reference to the DataExportSales.IMetadata.
        /// </param>
        /// <param name='organizationUrl'>
        /// Required. Organization URL
        /// </param>
        public static object GetOrgDetails(this IMetadata operations, string organizationUrl)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IMetadata)s).GetOrgDetailsAsync(organizationUrl);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <param name='operations'>
        /// Reference to the DataExportSales.IMetadata.
        /// </param>
        /// <param name='organizationUrl'>
        /// Required. Organization URL
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public static async Task<object> GetOrgDetailsAsync(this IMetadata operations, string organizationUrl, CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Microsoft.Rest.HttpOperationResponse<object> result = await operations.GetOrgDetailsWithOperationResponseAsync(organizationUrl, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }
        
        /// <param name='operations'>
        /// Reference to the DataExportSales.IMetadata.
        /// </param>
        /// <param name='organizationUrl'>
        /// Required. Organization URL
        /// </param>
        public static object GetRelationships(this IMetadata operations, string organizationUrl)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IMetadata)s).GetRelationshipsAsync(organizationUrl);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <param name='operations'>
        /// Reference to the DataExportSales.IMetadata.
        /// </param>
        /// <param name='organizationUrl'>
        /// Required. Organization URL
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public static async Task<object> GetRelationshipsAsync(this IMetadata operations, string organizationUrl, CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Microsoft.Rest.HttpOperationResponse<object> result = await operations.GetRelationshipsWithOperationResponseAsync(organizationUrl, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }
        
        /// <param name='operations'>
        /// Reference to the DataExportSales.IMetadata.
        /// </param>
        /// <param name='organizationId'>
        /// Required. The organization ID
        /// </param>
        public static object HasOrgAcceptedPrivacyTerms(this IMetadata operations, string organizationId)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IMetadata)s).HasOrgAcceptedPrivacyTermsAsync(organizationId);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <param name='operations'>
        /// Reference to the DataExportSales.IMetadata.
        /// </param>
        /// <param name='organizationId'>
        /// Required. The organization ID
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public static async Task<object> HasOrgAcceptedPrivacyTermsAsync(this IMetadata operations, string organizationId, CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Microsoft.Rest.HttpOperationResponse<object> result = await operations.HasOrgAcceptedPrivacyTermsWithOperationResponseAsync(organizationId, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }
    }
}
