// <auto-generated/>
using Autodesk.ACC.CostManagement.Models;
using Autodesk.ACC.CostManagement.V1.Projects.Item.Contracts.Item.ScheduleOfValues.Item;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Autodesk.ACC.CostManagement.V1.Projects.Item.Contracts.Item.ScheduleOfValues
{
    /// <summary>
    /// Builds and executes requests for operations under \v1\projects\{projectId}\contracts\{contractId}\schedule-of-values
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.16.0")]
    public partial class ScheduleOfValuesRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the Autodesk.ACC.CostManagement.v1.projects.item.contracts.item.scheduleOfValues.item collection</summary>
        /// <param name="position">ID of the schedule of value. Multi IDs could be separated by comma.</param>
        /// <returns>A <see cref="global::Autodesk.ACC.CostManagement.V1.Projects.Item.Contracts.Item.ScheduleOfValues.Item.ScheduleOfValuesItemRequestBuilder"/></returns>
        [Obsolete("")]
        public global::Autodesk.ACC.CostManagement.V1.Projects.Item.Contracts.Item.ScheduleOfValues.Item.ScheduleOfValuesItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("id", position);
                return new global::Autodesk.ACC.CostManagement.V1.Projects.Item.Contracts.Item.ScheduleOfValues.Item.ScheduleOfValuesItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Autodesk.ACC.CostManagement.V1.Projects.Item.Contracts.Item.ScheduleOfValues.ScheduleOfValuesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ScheduleOfValuesRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/v1/projects/{projectId}/contracts/{contractId}/schedule-of-values{?internalLimit*,limit*,offset*,sort*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Autodesk.ACC.CostManagement.V1.Projects.Item.Contracts.Item.ScheduleOfValues.ScheduleOfValuesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ScheduleOfValuesRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/v1/projects/{projectId}/contracts/{contractId}/schedule-of-values{?internalLimit*,limit*,offset*,sort*}", rawUrl)
        {
        }
        /// <summary>
        /// Retrieves all the schedule of values in the contract.
        /// </summary>
        /// <returns>A List&lt;global::Autodesk.ACC.CostManagement.Models.SOV&gt;</returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Autodesk.ACC.CostManagement.Models.DefinedError">When receiving a 400 status code</exception>
        /// <exception cref="global::Autodesk.ACC.CostManagement.Models.Error">When receiving a 401 status code</exception>
        /// <exception cref="global::Autodesk.ACC.CostManagement.Models.Error">When receiving a 403 status code</exception>
        /// <exception cref="global::Autodesk.ACC.CostManagement.Models.Error">When receiving a 404 status code</exception>
        /// <exception cref="global::Autodesk.ACC.CostManagement.Models.Error">When receiving a 500 status code</exception>
        /// <exception cref="global::Autodesk.ACC.CostManagement.Models.Error">When receiving a 503 status code</exception>
        [Obsolete("")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<List<global::Autodesk.ACC.CostManagement.Models.SOV>?> GetAsync(Action<RequestConfiguration<global::Autodesk.ACC.CostManagement.V1.Projects.Item.Contracts.Item.ScheduleOfValues.ScheduleOfValuesRequestBuilder.ScheduleOfValuesRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<List<global::Autodesk.ACC.CostManagement.Models.SOV>> GetAsync(Action<RequestConfiguration<global::Autodesk.ACC.CostManagement.V1.Projects.Item.Contracts.Item.ScheduleOfValues.ScheduleOfValuesRequestBuilder.ScheduleOfValuesRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
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
            var collectionResult = await RequestAdapter.SendCollectionAsync<global::Autodesk.ACC.CostManagement.Models.SOV>(requestInfo, global::Autodesk.ACC.CostManagement.Models.SOV.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
            return collectionResult?.AsList();
        }
        /// <summary>
        /// Creates a schedule of value in the contract for a parent schedule of value.
        /// </summary>
        /// <returns>A <see cref="global::Autodesk.ACC.CostManagement.Models.SOV"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Autodesk.ACC.CostManagement.Models.DefinedError">When receiving a 400 status code</exception>
        /// <exception cref="global::Autodesk.ACC.CostManagement.Models.Error">When receiving a 401 status code</exception>
        /// <exception cref="global::Autodesk.ACC.CostManagement.Models.Error">When receiving a 403 status code</exception>
        /// <exception cref="global::Autodesk.ACC.CostManagement.Models.Error">When receiving a 404 status code</exception>
        /// <exception cref="global::Autodesk.ACC.CostManagement.Models.Error">When receiving a 500 status code</exception>
        /// <exception cref="global::Autodesk.ACC.CostManagement.Models.Error">When receiving a 503 status code</exception>
        [Obsolete("")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Autodesk.ACC.CostManagement.Models.SOV?> PostAsync(global::Autodesk.ACC.CostManagement.Models.SOVCreate body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Autodesk.ACC.CostManagement.Models.SOV> PostAsync(global::Autodesk.ACC.CostManagement.Models.SOVCreate body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "400", global::Autodesk.ACC.CostManagement.Models.DefinedError.CreateFromDiscriminatorValue },
                { "401", global::Autodesk.ACC.CostManagement.Models.Error.CreateFromDiscriminatorValue },
                { "403", global::Autodesk.ACC.CostManagement.Models.Error.CreateFromDiscriminatorValue },
                { "404", global::Autodesk.ACC.CostManagement.Models.Error.CreateFromDiscriminatorValue },
                { "500", global::Autodesk.ACC.CostManagement.Models.Error.CreateFromDiscriminatorValue },
                { "503", global::Autodesk.ACC.CostManagement.Models.Error.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Autodesk.ACC.CostManagement.Models.SOV>(requestInfo, global::Autodesk.ACC.CostManagement.Models.SOV.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Retrieves all the schedule of values in the contract.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        [Obsolete("")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Autodesk.ACC.CostManagement.V1.Projects.Item.Contracts.Item.ScheduleOfValues.ScheduleOfValuesRequestBuilder.ScheduleOfValuesRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Autodesk.ACC.CostManagement.V1.Projects.Item.Contracts.Item.ScheduleOfValues.ScheduleOfValuesRequestBuilder.ScheduleOfValuesRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Creates a schedule of value in the contract for a parent schedule of value.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        [Obsolete("")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(global::Autodesk.ACC.CostManagement.Models.SOVCreate body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(global::Autodesk.ACC.CostManagement.Models.SOVCreate body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Autodesk.ACC.CostManagement.V1.Projects.Item.Contracts.Item.ScheduleOfValues.ScheduleOfValuesRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        [Obsolete("")]
        public global::Autodesk.ACC.CostManagement.V1.Projects.Item.Contracts.Item.ScheduleOfValues.ScheduleOfValuesRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Autodesk.ACC.CostManagement.V1.Projects.Item.Contracts.Item.ScheduleOfValues.ScheduleOfValuesRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Retrieves all the schedule of values in the contract.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.16.0")]
        public partial class ScheduleOfValuesRequestBuilderGetQueryParameters 
        {
            /// <summary>The maximum number of items to return, this is for internal use, and the default maximum internal limit is 5000.</summary>
            [QueryParameter("internalLimit")]
            public int? InternalLimit { get; set; }
            /// <summary>The maximum number of items to return, default maximum limit is 100.</summary>
            [QueryParameter("limit")]
            public int? Limit { get; set; }
            /// <summary>The number of items to skip before starting to collect the result set.</summary>
            [QueryParameter("offset")]
            public int? Offset { get; set; }
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
        public partial class ScheduleOfValuesRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Autodesk.ACC.CostManagement.V1.Projects.Item.Contracts.Item.ScheduleOfValues.ScheduleOfValuesRequestBuilder.ScheduleOfValuesRequestBuilderGetQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.16.0")]
        public partial class ScheduleOfValuesRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
