// <auto-generated/>
#pragma warning disable CS0618
using Autodesk.ACC.ModelProperties.Models;
using Autodesk.ACC.ModelProperties.V2.Projects.Item.Diffs.Item.Fields;
using Autodesk.ACC.ModelProperties.V2.Projects.Item.Diffs.Item.Manifest;
using Autodesk.ACC.ModelProperties.V2.Projects.Item.Diffs.Item.Properties;
using Autodesk.ACC.ModelProperties.V2.Projects.Item.Diffs.Item.Queries;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Autodesk.ACC.ModelProperties.V2.Projects.Item.Diffs.Item
{
    /// <summary>
    /// Builds and executes requests for operations under \v2\projects\{projectId}\diffs\{diffId}
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class WithDiffItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The fields property</summary>
        public global::Autodesk.ACC.ModelProperties.V2.Projects.Item.Diffs.Item.Fields.FieldsRequestBuilder Fields
        {
            get => new global::Autodesk.ACC.ModelProperties.V2.Projects.Item.Diffs.Item.Fields.FieldsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The manifest property</summary>
        public global::Autodesk.ACC.ModelProperties.V2.Projects.Item.Diffs.Item.Manifest.ManifestRequestBuilder Manifest
        {
            get => new global::Autodesk.ACC.ModelProperties.V2.Projects.Item.Diffs.Item.Manifest.ManifestRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The properties property</summary>
        public global::Autodesk.ACC.ModelProperties.V2.Projects.Item.Diffs.Item.Properties.PropertiesRequestBuilder Properties
        {
            get => new global::Autodesk.ACC.ModelProperties.V2.Projects.Item.Diffs.Item.Properties.PropertiesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The queries property</summary>
        public global::Autodesk.ACC.ModelProperties.V2.Projects.Item.Diffs.Item.Queries.QueriesRequestBuilder Queries
        {
            get => new global::Autodesk.ACC.ModelProperties.V2.Projects.Item.Diffs.Item.Queries.QueriesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Autodesk.ACC.ModelProperties.V2.Projects.Item.Diffs.Item.WithDiffItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithDiffItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/v2/projects/{projectId}/diffs/{diffId}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Autodesk.ACC.ModelProperties.V2.Projects.Item.Diffs.Item.WithDiffItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithDiffItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/v2/projects/{projectId}/diffs/{diffId}", rawUrl)
        {
        }
        /// <summary>
        /// Retrieve the diff status for the given diff ID.Depending on the state different properties might be present or missing.E.g., if the diff job is not finished yet, the manifest, fields, andproperties links might be missing, but the retryAt property will be present.Or if the processing failed for some reason, the errors property will containsome information.Once the final result of the diff job has been determined (either finished or failed),the status is assumed to be immutable and the response will set a long expiration HTTP headerfor efficient client side caching.
        /// </summary>
        /// <returns>A <see cref="global::Autodesk.ACC.ModelProperties.Models.DiffJobStatus"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Autodesk.ACC.ModelProperties.Models.ResourceError">When receiving a 401 status code</exception>
        /// <exception cref="global::Autodesk.ACC.ModelProperties.Models.ResourceError">When receiving a 404 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Autodesk.ACC.ModelProperties.Models.DiffJobStatus?> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Autodesk.ACC.ModelProperties.Models.DiffJobStatus> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "401", global::Autodesk.ACC.ModelProperties.Models.ResourceError.CreateFromDiscriminatorValue },
                { "404", global::Autodesk.ACC.ModelProperties.Models.ResourceError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Autodesk.ACC.ModelProperties.Models.DiffJobStatus>(requestInfo, global::Autodesk.ACC.ModelProperties.Models.DiffJobStatus.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Retrieve the diff status for the given diff ID.Depending on the state different properties might be present or missing.E.g., if the diff job is not finished yet, the manifest, fields, andproperties links might be missing, but the retryAt property will be present.Or if the processing failed for some reason, the errors property will containsome information.Once the final result of the diff job has been determined (either finished or failed),the status is assumed to be immutable and the response will set a long expiration HTTP headerfor efficient client side caching.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Autodesk.ACC.ModelProperties.V2.Projects.Item.Diffs.Item.WithDiffItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Autodesk.ACC.ModelProperties.V2.Projects.Item.Diffs.Item.WithDiffItemRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Autodesk.ACC.ModelProperties.V2.Projects.Item.Diffs.Item.WithDiffItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class WithDiffItemRequestBuilderGetRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
