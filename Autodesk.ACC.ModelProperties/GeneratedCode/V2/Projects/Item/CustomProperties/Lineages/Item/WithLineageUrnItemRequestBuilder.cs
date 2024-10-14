// <auto-generated/>
#pragma warning disable CS0618
using Autodesk.ACC.ModelProperties.V2.Projects.Item.CustomProperties.Lineages.Item.Values;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace Autodesk.ACC.ModelProperties.V2.Projects.Item.CustomProperties.Lineages.Item
{
    /// <summary>
    /// Builds and executes requests for operations under \v2\projects\{projectId}\custom-properties\lineages\{lineageUrn}
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class WithLineageUrnItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The values property</summary>
        public global::Autodesk.ACC.ModelProperties.V2.Projects.Item.CustomProperties.Lineages.Item.Values.ValuesRequestBuilder Values
        {
            get => new global::Autodesk.ACC.ModelProperties.V2.Projects.Item.CustomProperties.Lineages.Item.Values.ValuesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Autodesk.ACC.ModelProperties.V2.Projects.Item.CustomProperties.Lineages.Item.WithLineageUrnItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithLineageUrnItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/v2/projects/{projectId}/custom-properties/lineages/{lineageUrn}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Autodesk.ACC.ModelProperties.V2.Projects.Item.CustomProperties.Lineages.Item.WithLineageUrnItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithLineageUrnItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/v2/projects/{projectId}/custom-properties/lineages/{lineageUrn}", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
