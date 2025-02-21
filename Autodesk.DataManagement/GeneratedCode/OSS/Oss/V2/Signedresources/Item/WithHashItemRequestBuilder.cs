// <auto-generated/>
#pragma warning disable CS0618
using Autodesk.DataManagement.OSS.Models;
using Autodesk.DataManagement.OSS.Oss.V2.Signedresources.Item.Resumable;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Autodesk.DataManagement.OSS.Oss.V2.Signedresources.Item
{
    /// <summary>
    /// Builds and executes requests for operations under \oss\v2\signedresources\{hash}
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class WithHashItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The resumable property</summary>
        public global::Autodesk.DataManagement.OSS.Oss.V2.Signedresources.Item.Resumable.ResumableRequestBuilder Resumable
        {
            get => new global::Autodesk.DataManagement.OSS.Oss.V2.Signedresources.Item.Resumable.ResumableRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Autodesk.DataManagement.OSS.Oss.V2.Signedresources.Item.WithHashItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithHashItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/oss/v2/signedresources/{hash}{?region*,response%2Dcontent%2Ddisposition*,response%2Dcontent%2Dtype*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Autodesk.DataManagement.OSS.Oss.V2.Signedresources.Item.WithHashItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithHashItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/oss/v2/signedresources/{hash}{?region*,response%2Dcontent%2Ddisposition*,response%2Dcontent%2Dtype*}", rawUrl)
        {
        }
        /// <summary>
        /// Delete a signed URL. A successful call to this endpoint requires bucket owner access.
        /// </summary>
        /// <returns>A <see cref="Stream"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Stream?> DeleteAsync(Action<RequestConfiguration<global::Autodesk.DataManagement.OSS.Oss.V2.Signedresources.Item.WithHashItemRequestBuilder.WithHashItemRequestBuilderDeleteQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<Stream> DeleteAsync(Action<RequestConfiguration<global::Autodesk.DataManagement.OSS.Oss.V2.Signedresources.Item.WithHashItemRequestBuilder.WithHashItemRequestBuilderDeleteQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToDeleteRequestInformation(requestConfiguration);
            return await RequestAdapter.SendPrimitiveAsync<Stream>(requestInfo, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Download an object using a signed URL.
        /// </summary>
        /// <returns>A <see cref="Stream"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Stream?> GetAsync(Action<RequestConfiguration<global::Autodesk.DataManagement.OSS.Oss.V2.Signedresources.Item.WithHashItemRequestBuilder.WithHashItemRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<Stream> GetAsync(Action<RequestConfiguration<global::Autodesk.DataManagement.OSS.Oss.V2.Signedresources.Item.WithHashItemRequestBuilder.WithHashItemRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendPrimitiveAsync<Stream>(requestInfo, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Upload an object using a signed URL. If the signed resource is available and its expiration period is valid, you can overwrite the existing object via a signed URL upload using the &apos;access&apos; query parameter with value &apos;write&apos; or &apos;readwrite&apos;.
        /// </summary>
        /// <returns>A <see cref="global::Autodesk.DataManagement.OSS.Models.ObjectDetails"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Autodesk.DataManagement.OSS.Models.Reason">When receiving a 412 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Autodesk.DataManagement.OSS.Models.ObjectDetails?> PutAsync(global::Autodesk.DataManagement.OSS.Oss.V2.Signedresources.Item.WithHashPutRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Autodesk.DataManagement.OSS.Models.ObjectDetails> PutAsync(global::Autodesk.DataManagement.OSS.Oss.V2.Signedresources.Item.WithHashPutRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPutRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "412", global::Autodesk.DataManagement.OSS.Models.Reason.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Autodesk.DataManagement.OSS.Models.ObjectDetails>(requestInfo, global::Autodesk.DataManagement.OSS.Models.ObjectDetails.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Delete a signed URL. A successful call to this endpoint requires bucket owner access.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<global::Autodesk.DataManagement.OSS.Oss.V2.Signedresources.Item.WithHashItemRequestBuilder.WithHashItemRequestBuilderDeleteQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<global::Autodesk.DataManagement.OSS.Oss.V2.Signedresources.Item.WithHashItemRequestBuilder.WithHashItemRequestBuilderDeleteQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.DELETE, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            return requestInfo;
        }
        /// <summary>
        /// Download an object using a signed URL.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Autodesk.DataManagement.OSS.Oss.V2.Signedresources.Item.WithHashItemRequestBuilder.WithHashItemRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Autodesk.DataManagement.OSS.Oss.V2.Signedresources.Item.WithHashItemRequestBuilder.WithHashItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/octet-stream");
            return requestInfo;
        }
        /// <summary>
        /// Upload an object using a signed URL. If the signed resource is available and its expiration period is valid, you can overwrite the existing object via a signed URL upload using the &apos;access&apos; query parameter with value &apos;write&apos; or &apos;readwrite&apos;.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPutRequestInformation(global::Autodesk.DataManagement.OSS.Oss.V2.Signedresources.Item.WithHashPutRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPutRequestInformation(global::Autodesk.DataManagement.OSS.Oss.V2.Signedresources.Item.WithHashPutRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.PUT, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json, application/vnd.api+json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/x-www-form-urlencoded", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::Autodesk.DataManagement.OSS.Oss.V2.Signedresources.Item.WithHashItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Autodesk.DataManagement.OSS.Oss.V2.Signedresources.Item.WithHashItemRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Autodesk.DataManagement.OSS.Oss.V2.Signedresources.Item.WithHashItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Delete a signed URL. A successful call to this endpoint requires bucket owner access.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class WithHashItemRequestBuilderDeleteQueryParameters 
        {
            /// <summary>The region where the bucket residesAcceptable values: `US`, `EMEA`Default is `US`</summary>
            [Obsolete("This property is deprecated, use RegionAsDeleteRegionQueryParameterType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("region")]
            public string? Region { get; set; }
#nullable restore
#else
            [QueryParameter("region")]
            public string Region { get; set; }
#endif
            /// <summary>The region where the bucket residesAcceptable values: `US`, `EMEA`Default is `US`</summary>
            [QueryParameter("region")]
            public global::Autodesk.DataManagement.OSS.Oss.V2.Signedresources.Item.DeleteRegionQueryParameterType? RegionAsDeleteRegionQueryParameterType { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class WithHashItemRequestBuilderDeleteRequestConfiguration : RequestConfiguration<global::Autodesk.DataManagement.OSS.Oss.V2.Signedresources.Item.WithHashItemRequestBuilder.WithHashItemRequestBuilderDeleteQueryParameters>
        {
        }
        /// <summary>
        /// Download an object using a signed URL.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class WithHashItemRequestBuilderGetQueryParameters 
        {
            /// <summary>The region where the bucket residesAcceptable values: `US`, `EMEA`Default is `US`</summary>
            [Obsolete("This property is deprecated, use RegionAsGetRegionQueryParameterType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("region")]
            public string? Region { get; set; }
#nullable restore
#else
            [QueryParameter("region")]
            public string Region { get; set; }
#endif
            /// <summary>The region where the bucket residesAcceptable values: `US`, `EMEA`Default is `US`</summary>
            [QueryParameter("region")]
            public global::Autodesk.DataManagement.OSS.Oss.V2.Signedresources.Item.GetRegionQueryParameterType? RegionAsGetRegionQueryParameterType { get; set; }
            /// <summary>Value of the Content-Disposition HTTP header you expect to receive. If the parameter is not provided, the value associated with the object is used.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("response%2Dcontent%2Ddisposition")]
            public string? ResponseContentDisposition { get; set; }
#nullable restore
#else
            [QueryParameter("response%2Dcontent%2Ddisposition")]
            public string ResponseContentDisposition { get; set; }
#endif
            /// <summary>Value of the Content-Type HTTP header you expect to receive in the download response.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("response%2Dcontent%2Dtype")]
            public string? ResponseContentType { get; set; }
#nullable restore
#else
            [QueryParameter("response%2Dcontent%2Dtype")]
            public string ResponseContentType { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class WithHashItemRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Autodesk.DataManagement.OSS.Oss.V2.Signedresources.Item.WithHashItemRequestBuilder.WithHashItemRequestBuilderGetQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class WithHashItemRequestBuilderPutRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
