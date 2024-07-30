// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Autodesk.ACC.CostManagement.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.16.0")]
    #pragma warning disable CS1591
    public partial class FormInstanceCreate : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Detailed description of the change order.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>The ID of the item in its original external system. You can use this ID to track the source of truth or to look up the data in an integrated system.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ExternalId { get; set; }
#nullable restore
#else
        public string ExternalId { get; set; }
#endif
        /// <summary>A message that explains the sync status of the ERP integration with the BIM 360 Cost module.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ExternalMessage { get; set; }
#nullable restore
#else
        public string ExternalMessage { get; set; }
#endif
        /// <summary>The name of the external system. You can use this name to track the source of truth or to search in an integrated system.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ExternalSystem { get; set; }
#nullable restore
#else
        public string ExternalSystem { get; set; }
#endif
        /// <summary>Lock state used by ERP integration, default value is ``null``.</summary>
        public global::Autodesk.ACC.CostManagement.Models.FormInstanceCreate_integrationState? IntegrationState { get; set; }
        /// <summary>Name of the change order</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>Additional notes to the change order. This is a Draftjs formatted rich text (https://draftjs.org/).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Note { get; set; }
#nullable restore
#else
        public string Note { get; set; }
#endif
        /// <summary>The scope of the change order. Possible values are ``out``, ``in``, ``tbd`` , ``budgetOnly``and ``contingency``.</summary>
        public global::Autodesk.ACC.CostManagement.Models.FormInstanceCreate_scope? Scope { get; set; }
        /// <summary>Scope of work of the change order. This is a Draftjs formatted rich text (https://draftjs.org/).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ScopeOfWork { get; set; }
#nullable restore
#else
        public string ScopeOfWork { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Autodesk.ACC.CostManagement.Models.FormInstanceCreate"/> and sets the default values.
        /// </summary>
        public FormInstanceCreate()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Autodesk.ACC.CostManagement.Models.FormInstanceCreate"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Autodesk.ACC.CostManagement.Models.FormInstanceCreate CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Autodesk.ACC.CostManagement.Models.FormInstanceCreate();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "description", n => { Description = n.GetStringValue(); } },
                { "externalId", n => { ExternalId = n.GetStringValue(); } },
                { "externalMessage", n => { ExternalMessage = n.GetStringValue(); } },
                { "externalSystem", n => { ExternalSystem = n.GetStringValue(); } },
                { "integrationState", n => { IntegrationState = n.GetEnumValue<global::Autodesk.ACC.CostManagement.Models.FormInstanceCreate_integrationState>(); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "note", n => { Note = n.GetStringValue(); } },
                { "scope", n => { Scope = n.GetEnumValue<global::Autodesk.ACC.CostManagement.Models.FormInstanceCreate_scope>(); } },
                { "scopeOfWork", n => { ScopeOfWork = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("externalId", ExternalId);
            writer.WriteStringValue("externalMessage", ExternalMessage);
            writer.WriteStringValue("externalSystem", ExternalSystem);
            writer.WriteEnumValue<global::Autodesk.ACC.CostManagement.Models.FormInstanceCreate_integrationState>("integrationState", IntegrationState);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("note", Note);
            writer.WriteEnumValue<global::Autodesk.ACC.CostManagement.Models.FormInstanceCreate_scope>("scope", Scope);
            writer.WriteStringValue("scopeOfWork", ScopeOfWork);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
