// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Autodesk.ACC.CostManagement.V1.Projects
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.16.0")]
    #pragma warning disable CS1591
    public partial class ProjectsPostRequestBody : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The acm_namespace property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AcmNamespace { get; set; }
#nullable restore
#else
        public string AcmNamespace { get; set; }
#endif
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The context_identifier property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Autodesk.ACC.CostManagement.V1.Projects.ProjectsPostRequestBody_context_identifier? ContextIdentifier { get; set; }
#nullable restore
#else
        public global::Autodesk.ACC.CostManagement.V1.Projects.ProjectsPostRequestBody_context_identifier ContextIdentifier { get; set; }
#endif
        /// <summary>The context_type property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ContextType { get; set; }
#nullable restore
#else
        public string ContextType { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Autodesk.ACC.CostManagement.V1.Projects.ProjectsPostRequestBody"/> and sets the default values.
        /// </summary>
        public ProjectsPostRequestBody()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Autodesk.ACC.CostManagement.V1.Projects.ProjectsPostRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Autodesk.ACC.CostManagement.V1.Projects.ProjectsPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Autodesk.ACC.CostManagement.V1.Projects.ProjectsPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "acm_namespace", n => { AcmNamespace = n.GetStringValue(); } },
                { "context_identifier", n => { ContextIdentifier = n.GetObjectValue<global::Autodesk.ACC.CostManagement.V1.Projects.ProjectsPostRequestBody_context_identifier>(global::Autodesk.ACC.CostManagement.V1.Projects.ProjectsPostRequestBody_context_identifier.CreateFromDiscriminatorValue); } },
                { "context_type", n => { ContextType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("acm_namespace", AcmNamespace);
            writer.WriteObjectValue<global::Autodesk.ACC.CostManagement.V1.Projects.ProjectsPostRequestBody_context_identifier>("context_identifier", ContextIdentifier);
            writer.WriteStringValue("context_type", ContextType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
