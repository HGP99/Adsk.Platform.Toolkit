// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Autodesk.ACC.Issues.Models
{
    /// <summary>
    /// The metadata object; only relevant for ``list`` custom attributes.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class IssueAttributeDefinitionDefinition_metadata : IParsable
    {
        /// <summary>The list object.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Autodesk.ACC.Issues.Models.IssueAttributeDefinitionDefinition_metadata_list? List { get; set; }
#nullable restore
#else
        public global::Autodesk.ACC.Issues.Models.IssueAttributeDefinitionDefinition_metadata_list List { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Autodesk.ACC.Issues.Models.IssueAttributeDefinitionDefinition_metadata"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Autodesk.ACC.Issues.Models.IssueAttributeDefinitionDefinition_metadata CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Autodesk.ACC.Issues.Models.IssueAttributeDefinitionDefinition_metadata();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "list", n => { List = n.GetObjectValue<global::Autodesk.ACC.Issues.Models.IssueAttributeDefinitionDefinition_metadata_list>(global::Autodesk.ACC.Issues.Models.IssueAttributeDefinitionDefinition_metadata_list.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::Autodesk.ACC.Issues.Models.IssueAttributeDefinitionDefinition_metadata_list>("list", List);
        }
    }
}
#pragma warning restore CS0618
