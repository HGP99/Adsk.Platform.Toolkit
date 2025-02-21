// <auto-generated/>
#pragma warning disable CS0618
using Autodesk.ACC.ModelProperties.Models;
using Autodesk.ACC.ModelProperties.V2.Projects.Item.Indexes.Item.Queries.Item;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Autodesk.ACC.ModelProperties.V2.Projects.Item.Indexes.Item.Queries
{
    /// <summary>
    /// Builds and executes requests for operations under \v2\projects\{projectId}\indexes\{indexId}\queries
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class QueriesRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the Autodesk.ACC.ModelProperties.v2.projects.item.indexes.item.queries.item collection</summary>
        /// <param name="position">The query ID.</param>
        /// <returns>A <see cref="global::Autodesk.ACC.ModelProperties.V2.Projects.Item.Indexes.Item.Queries.Item.WithQueryItemRequestBuilder"/></returns>
        public global::Autodesk.ACC.ModelProperties.V2.Projects.Item.Indexes.Item.Queries.Item.WithQueryItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("queryId", position);
                return new global::Autodesk.ACC.ModelProperties.V2.Projects.Item.Indexes.Item.Queries.Item.WithQueryItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Autodesk.ACC.ModelProperties.V2.Projects.Item.Indexes.Item.Queries.QueriesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public QueriesRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/v2/projects/{projectId}/indexes/{indexId}/queries", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Autodesk.ACC.ModelProperties.V2.Projects.Item.Indexes.Item.Queries.QueriesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public QueriesRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/v2/projects/{projectId}/indexes/{indexId}/queries", rawUrl)
        {
        }
        /// <summary>
        /// Applies the given query on the given properties index.
        /// </summary>
        /// <returns>A <see cref="global::Autodesk.ACC.ModelProperties.Models.IndexJobStatus"/></returns>
        /// <param name="body">Specifies an optional query for the index.</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Autodesk.ACC.ModelProperties.Models.ResourceError">When receiving a 401 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Autodesk.ACC.ModelProperties.Models.IndexJobStatus?> PostAsync(global::Autodesk.ACC.ModelProperties.Models.IndexQueryRequest body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Autodesk.ACC.ModelProperties.Models.IndexJobStatus> PostAsync(global::Autodesk.ACC.ModelProperties.Models.IndexQueryRequest body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "401", global::Autodesk.ACC.ModelProperties.Models.ResourceError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Autodesk.ACC.ModelProperties.Models.IndexJobStatus>(requestInfo, global::Autodesk.ACC.ModelProperties.Models.IndexJobStatus.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Applies the given query on the given properties index.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">Specifies an optional query for the index.</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(global::Autodesk.ACC.ModelProperties.Models.IndexQueryRequest body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(global::Autodesk.ACC.ModelProperties.Models.IndexQueryRequest body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.POST, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::Autodesk.ACC.ModelProperties.V2.Projects.Item.Indexes.Item.Queries.QueriesRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Autodesk.ACC.ModelProperties.V2.Projects.Item.Indexes.Item.Queries.QueriesRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Autodesk.ACC.ModelProperties.V2.Projects.Item.Indexes.Item.Queries.QueriesRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class QueriesRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
