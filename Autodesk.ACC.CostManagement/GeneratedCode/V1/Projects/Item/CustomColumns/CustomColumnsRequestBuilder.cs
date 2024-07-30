// <auto-generated/>
using Autodesk.ACC.CostManagement.Models;
using Autodesk.ACC.CostManagement.V1.Projects.Item.CustomColumns.Item;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Autodesk.ACC.CostManagement.V1.Projects.Item.CustomColumns
{
    /// <summary>
    /// Builds and executes requests for operations under \v1\projects\{projectId}\custom-columns
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.16.0")]
    public partial class CustomColumnsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the Autodesk.ACC.CostManagement.v1.projects.item.customColumns.item collection</summary>
        /// <param name="position">The object ID of the item.</param>
        /// <returns>A <see cref="global::Autodesk.ACC.CostManagement.V1.Projects.Item.CustomColumns.Item.CustomColumnsItemRequestBuilder"/></returns>
        public global::Autodesk.ACC.CostManagement.V1.Projects.Item.CustomColumns.Item.CustomColumnsItemRequestBuilder this[Guid position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("id", position);
                return new global::Autodesk.ACC.CostManagement.V1.Projects.Item.CustomColumns.Item.CustomColumnsItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>Gets an item from the Autodesk.ACC.CostManagement.v1.projects.item.customColumns.item collection</summary>
        /// <param name="position">The object ID of the item.</param>
        /// <returns>A <see cref="global::Autodesk.ACC.CostManagement.V1.Projects.Item.CustomColumns.Item.CustomColumnsItemRequestBuilder"/></returns>
        [Obsolete("This indexer is deprecated and will be removed in the next major version. Use the one with the typed parameter instead.")]
        public global::Autodesk.ACC.CostManagement.V1.Projects.Item.CustomColumns.Item.CustomColumnsItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                if (!string.IsNullOrWhiteSpace(position)) urlTplParams.Add("id", position);
                return new global::Autodesk.ACC.CostManagement.V1.Projects.Item.CustomColumns.Item.CustomColumnsItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Autodesk.ACC.CostManagement.V1.Projects.Item.CustomColumns.CustomColumnsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CustomColumnsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/v1/projects/{projectId}/custom-columns{?associationType*,filter%5Bid%5D*,internalLimit*,limit*,offset*,q*,sort*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Autodesk.ACC.CostManagement.V1.Projects.Item.CustomColumns.CustomColumnsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CustomColumnsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/v1/projects/{projectId}/custom-columns{?associationType*,filter%5Bid%5D*,internalLimit*,limit*,offset*,q*,sort*}", rawUrl)
        {
        }
        /// <summary>
        /// Returns all the ``Custom Column Setting`` in a specific project.
        /// </summary>
        /// <returns>A List&lt;global::Autodesk.ACC.CostManagement.Models.CustomColumn&gt;</returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Autodesk.ACC.CostManagement.Models.DefinedError">When receiving a 400 status code</exception>
        /// <exception cref="global::Autodesk.ACC.CostManagement.Models.Error">When receiving a 401 status code</exception>
        /// <exception cref="global::Autodesk.ACC.CostManagement.Models.Error">When receiving a 403 status code</exception>
        /// <exception cref="global::Autodesk.ACC.CostManagement.Models.Error">When receiving a 404 status code</exception>
        /// <exception cref="global::Autodesk.ACC.CostManagement.Models.Error">When receiving a 500 status code</exception>
        /// <exception cref="global::Autodesk.ACC.CostManagement.Models.Error">When receiving a 503 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<List<global::Autodesk.ACC.CostManagement.Models.CustomColumn>?> GetAsync(Action<RequestConfiguration<global::Autodesk.ACC.CostManagement.V1.Projects.Item.CustomColumns.CustomColumnsRequestBuilder.CustomColumnsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<List<global::Autodesk.ACC.CostManagement.Models.CustomColumn>> GetAsync(Action<RequestConfiguration<global::Autodesk.ACC.CostManagement.V1.Projects.Item.CustomColumns.CustomColumnsRequestBuilder.CustomColumnsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "400", global::Autodesk.ACC.CostManagement.Models.DefinedError.CreateFromDiscriminatorValue },
                { "401", global::Autodesk.ACC.CostManagement.Models.Error.CreateFromDiscriminatorValue },
                { "403", global::Autodesk.ACC.CostManagement.Models.Error.CreateFromDiscriminatorValue },
                { "404", global::Autodesk.ACC.CostManagement.Models.Error.CreateFromDiscriminatorValue },
                { "500", global::Autodesk.ACC.CostManagement.Models.Error.CreateFromDiscriminatorValue },
                { "503", global::Autodesk.ACC.CostManagement.Models.Error.CreateFromDiscriminatorValue },
            };
            var collectionResult = await RequestAdapter.SendCollectionAsync<global::Autodesk.ACC.CostManagement.Models.CustomColumn>(requestInfo, global::Autodesk.ACC.CostManagement.Models.CustomColumn.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
            return collectionResult?.AsList();
        }
        /// <summary>
        /// Returns all the ``Custom Column Setting`` in a specific project.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Autodesk.ACC.CostManagement.V1.Projects.Item.CustomColumns.CustomColumnsRequestBuilder.CustomColumnsRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Autodesk.ACC.CostManagement.V1.Projects.Item.CustomColumns.CustomColumnsRequestBuilder.CustomColumnsRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::Autodesk.ACC.CostManagement.V1.Projects.Item.CustomColumns.CustomColumnsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Autodesk.ACC.CostManagement.V1.Projects.Item.CustomColumns.CustomColumnsRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Autodesk.ACC.CostManagement.V1.Projects.Item.CustomColumns.CustomColumnsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Returns all the ``Custom Column Setting`` in a specific project.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.16.0")]
        public partial class CustomColumnsRequestBuilderGetQueryParameters 
        {
            /// <summary>The type of custom column</summary>
            [Obsolete("This property is deprecated, use AssociationTypeAsGetAssociationTypeQueryParameterType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("associationType")]
            public string? AssociationType { get; set; }
#nullable restore
#else
            [QueryParameter("associationType")]
            public string AssociationType { get; set; }
#endif
            /// <summary>The type of custom column</summary>
            [QueryParameter("associationType")]
            public global::Autodesk.ACC.CostManagement.V1.Projects.Item.CustomColumns.GetAssociationTypeQueryParameterType? AssociationTypeAsGetAssociationTypeQueryParameterType { get; set; }
            /// <summary>The item&apos;s primary identifier. Separate multiple IDs with commas. For example, ``filter[id]=id1,id2``.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("filter%5Bid%5D")]
            public string[]? Filterid { get; set; }
#nullable restore
#else
            [QueryParameter("filter%5Bid%5D")]
            public string[] Filterid { get; set; }
#endif
            /// <summary>The maximum number of items to return, this is for internal use, and the default maximum internal limit is 5000.</summary>
            [QueryParameter("internalLimit")]
            public int? InternalLimit { get; set; }
            /// <summary>The maximum number of items to return, default maximum limit is 100.</summary>
            [QueryParameter("limit")]
            public int? Limit { get; set; }
            /// <summary>The number of items to skip before starting to collect the result set.</summary>
            [QueryParameter("offset")]
            public int? Offset { get; set; }
            /// <summary>The conditions to query against items, such as ``id=0`` or (``id&gt;2`` and ``id&lt;4``). This parameter is deprecated in favor of the ``filter[]`` based syntax.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("q")]
            public string? Q { get; set; }
#nullable restore
#else
            [QueryParameter("q")]
            public string Q { get; set; }
#endif
            /// <summary>The sort order for items. Each attribute can be sorted in either ``asc`` (default) or ``desc`` order. For example, ``sort=name, updatedAt desc`` or ``sort=name + updatedAt desc`` sorts the results first by name in ascending order, then by date updated in descending order.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("sort")]
            public string? Sort { get; set; }
#nullable restore
#else
            [QueryParameter("sort")]
            public string Sort { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.16.0")]
        public partial class CustomColumnsRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Autodesk.ACC.CostManagement.V1.Projects.Item.CustomColumns.CustomColumnsRequestBuilder.CustomColumnsRequestBuilderGetQueryParameters>
        {
        }
    }
}
