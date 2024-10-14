// <auto-generated/>
#pragma warning disable CS0618
using Autodesk.ACC.RFIs.Models;
using Autodesk.ACC.RFIs.V2.Containers.Item.Rfis.Item.Attachments.Item;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Autodesk.ACC.RFIs.V2.Containers.Item.Rfis.Item.Attachments
{
    /// <summary>
    /// Builds and executes requests for operations under \v2\containers\{containerId}\rfis\{rfiId}\attachments
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class AttachmentsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the Autodesk.ACC.RFIs.v2.containers.item.rfis.item.attachments.item collection</summary>
        /// <param name="position">The id of the attachment to find (uuid)</param>
        /// <returns>A <see cref="global::Autodesk.ACC.RFIs.V2.Containers.Item.Rfis.Item.Attachments.Item.WithAttachmentItemRequestBuilder"/></returns>
        public global::Autodesk.ACC.RFIs.V2.Containers.Item.Rfis.Item.Attachments.Item.WithAttachmentItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("attachmentId", position);
                return new global::Autodesk.ACC.RFIs.V2.Containers.Item.Rfis.Item.Attachments.Item.WithAttachmentItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Autodesk.ACC.RFIs.V2.Containers.Item.Rfis.Item.Attachments.AttachmentsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AttachmentsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/v2/containers/{containerId}/rfis/{rfiId}/attachments{?fields,filter%5BincludeDeleted%5D*,limit*,offset*,redirectToS3*,sort}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Autodesk.ACC.RFIs.V2.Containers.Item.Rfis.Item.Attachments.AttachmentsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AttachmentsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/v2/containers/{containerId}/rfis/{rfiId}/attachments{?fields,filter%5BincludeDeleted%5D*,limit*,offset*,redirectToS3*,sort}", rawUrl)
        {
        }
        /// <summary>
        /// Retrieves information about all the attachments in a project associated with a specific RFI... include:: ../../../../_snippets/forward-compatible.rst
        /// </summary>
        /// <returns>A <see cref="global::Autodesk.ACC.RFIs.Models.AttachmentList"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Autodesk.ACC.RFIs.Models.ErrorResponse">When receiving a 400 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Autodesk.ACC.RFIs.Models.AttachmentList?> GetAsync(Action<RequestConfiguration<global::Autodesk.ACC.RFIs.V2.Containers.Item.Rfis.Item.Attachments.AttachmentsRequestBuilder.AttachmentsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Autodesk.ACC.RFIs.Models.AttachmentList> GetAsync(Action<RequestConfiguration<global::Autodesk.ACC.RFIs.V2.Containers.Item.Rfis.Item.Attachments.AttachmentsRequestBuilder.AttachmentsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "400", global::Autodesk.ACC.RFIs.Models.ErrorResponse.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Autodesk.ACC.RFIs.Models.AttachmentList>(requestInfo, global::Autodesk.ACC.RFIs.Models.AttachmentList.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Adds an attachment to an RFI. You can attach any file that you uploaded to Document Management. Note that we do not currently support attaching local files to an RFI.For more details about adding attachments, see the `Upload Attachment tutorial` `BIM 360&lt;/en/docs/bim360/v1/reference/tutorials/attach-BIM-360-files-to-rfi/&gt;`_  `ACC&lt;/en/docs/acc/v1/reference/tutorials/attach-BIM-360-files-to-rfi/&gt;`_ ... include:: ../../../../_snippets/not-forward-compatible.rst
        /// </summary>
        /// <returns>A <see cref="global::Autodesk.ACC.RFIs.Models.Attachment"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Autodesk.ACC.RFIs.Models.ErrorResponse">When receiving a 400 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Autodesk.ACC.RFIs.Models.Attachment?> PostAsync(global::Autodesk.ACC.RFIs.Models.CreateAttachmentRequestBIMDefinition body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Autodesk.ACC.RFIs.Models.Attachment> PostAsync(global::Autodesk.ACC.RFIs.Models.CreateAttachmentRequestBIMDefinition body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "400", global::Autodesk.ACC.RFIs.Models.ErrorResponse.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Autodesk.ACC.RFIs.Models.Attachment>(requestInfo, global::Autodesk.ACC.RFIs.Models.Attachment.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Retrieves information about all the attachments in a project associated with a specific RFI... include:: ../../../../_snippets/forward-compatible.rst
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Autodesk.ACC.RFIs.V2.Containers.Item.Rfis.Item.Attachments.AttachmentsRequestBuilder.AttachmentsRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Autodesk.ACC.RFIs.V2.Containers.Item.Rfis.Item.Attachments.AttachmentsRequestBuilder.AttachmentsRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Adds an attachment to an RFI. You can attach any file that you uploaded to Document Management. Note that we do not currently support attaching local files to an RFI.For more details about adding attachments, see the `Upload Attachment tutorial` `BIM 360&lt;/en/docs/bim360/v1/reference/tutorials/attach-BIM-360-files-to-rfi/&gt;`_  `ACC&lt;/en/docs/acc/v1/reference/tutorials/attach-BIM-360-files-to-rfi/&gt;`_ ... include:: ../../../../_snippets/not-forward-compatible.rst
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(global::Autodesk.ACC.RFIs.Models.CreateAttachmentRequestBIMDefinition body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(global::Autodesk.ACC.RFIs.Models.CreateAttachmentRequestBIMDefinition body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Autodesk.ACC.RFIs.V2.Containers.Item.Rfis.Item.Attachments.AttachmentsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Autodesk.ACC.RFIs.V2.Containers.Item.Rfis.Item.Attachments.AttachmentsRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Autodesk.ACC.RFIs.V2.Containers.Item.Rfis.Item.Attachments.AttachmentsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Retrieves information about all the attachments in a project associated with a specific RFI... include:: ../../../../_snippets/forward-compatible.rst
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class AttachmentsRequestBuilderGetQueryParameters 
        {
            /// <summary>Specify which attributes you want to see in the response. Separate multiple values with commas. For example, ``fields = title,description``.</summary>
            [Obsolete("This property is deprecated, use FieldsAsGetFieldsQueryParameterType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("fields")]
            public string[]? Fields { get; set; }
#nullable restore
#else
            [QueryParameter("fields")]
            public string[] Fields { get; set; }
#endif
            /// <summary>Specify which attributes you want to see in the response. Separate multiple values with commas. For example, ``fields = title,description``.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("fields")]
            public global::Autodesk.ACC.RFIs.V2.Containers.Item.Rfis.Item.Attachments.GetFieldsQueryParameterType[]? FieldsAsGetFieldsQueryParameterType { get; set; }
#nullable restore
#else
            [QueryParameter("fields")]
            public global::Autodesk.ACC.RFIs.V2.Containers.Item.Rfis.Item.Attachments.GetFieldsQueryParameterType[] FieldsAsGetFieldsQueryParameterType { get; set; }
#endif
            /// <summary>Include deleted attachments in the response.</summary>
            [QueryParameter("filter%5BincludeDeleted%5D")]
            public bool? FilterincludeDeleted { get; set; }
            /// <summary>The number of RFIs to return in the response payload. Acceptable values: 1-200. Default value: 10. For example, to limit the response to two RFIs per page, use ``limit=2``</summary>
            [QueryParameter("limit")]
            public int? Limit { get; set; }
            /// <summary>Number of RFIs into the collection that the pagination starts on. For example, to begin the results from the fourth record, use ``offset=3``</summary>
            [QueryParameter("offset")]
            public int? Offset { get; set; }
            /// <summary>should redirect download to S3 bucket directly.</summary>
            [QueryParameter("redirectToS3")]
            public bool? RedirectToS3 { get; set; }
            /// <summary>Sort the attachments by specified attributes. For example, ``sort=createdAt``. Separate multiple values with commas.</summary>
            [Obsolete("This property is deprecated, use SortAsGetSortQueryParameterType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("sort")]
            public string[]? Sort { get; set; }
#nullable restore
#else
            [QueryParameter("sort")]
            public string[] Sort { get; set; }
#endif
            /// <summary>Sort the attachments by specified attributes. For example, ``sort=createdAt``. Separate multiple values with commas.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("sort")]
            public global::Autodesk.ACC.RFIs.V2.Containers.Item.Rfis.Item.Attachments.GetSortQueryParameterType[]? SortAsGetSortQueryParameterType { get; set; }
#nullable restore
#else
            [QueryParameter("sort")]
            public global::Autodesk.ACC.RFIs.V2.Containers.Item.Rfis.Item.Attachments.GetSortQueryParameterType[] SortAsGetSortQueryParameterType { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class AttachmentsRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Autodesk.ACC.RFIs.V2.Containers.Item.Rfis.Item.Attachments.AttachmentsRequestBuilder.AttachmentsRequestBuilderGetQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class AttachmentsRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
