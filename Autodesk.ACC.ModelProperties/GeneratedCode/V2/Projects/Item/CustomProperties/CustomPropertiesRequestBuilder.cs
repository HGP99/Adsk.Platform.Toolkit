// <auto-generated/>
#pragma warning disable CS0618
using Autodesk.ACC.ModelProperties.V2.Projects.Item.CustomProperties.Lineages;
using Autodesk.ACC.ModelProperties.V2.Projects.Item.CustomProperties.Parameters;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace Autodesk.ACC.ModelProperties.V2.Projects.Item.CustomProperties
{
    /// <summary>
    /// Builds and executes requests for operations under \v2\projects\{projectId}\custom-properties
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class CustomPropertiesRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The lineages property</summary>
        public global::Autodesk.ACC.ModelProperties.V2.Projects.Item.CustomProperties.Lineages.LineagesRequestBuilder Lineages
        {
            get => new global::Autodesk.ACC.ModelProperties.V2.Projects.Item.CustomProperties.Lineages.LineagesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The parameters property</summary>
        public global::Autodesk.ACC.ModelProperties.V2.Projects.Item.CustomProperties.Parameters.ParametersRequestBuilder Parameters
        {
            get => new global::Autodesk.ACC.ModelProperties.V2.Projects.Item.CustomProperties.Parameters.ParametersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Autodesk.ACC.ModelProperties.V2.Projects.Item.CustomProperties.CustomPropertiesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CustomPropertiesRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/v2/projects/{projectId}/custom-properties", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Autodesk.ACC.ModelProperties.V2.Projects.Item.CustomProperties.CustomPropertiesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CustomPropertiesRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/v2/projects/{projectId}/custom-properties", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
