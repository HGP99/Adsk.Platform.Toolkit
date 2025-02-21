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
    /// The list object.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class IssueAttributeDefinitionDefinition_metadata_list : IParsable
    {
        /// <summary>The options object.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Autodesk.ACC.Issues.Models.IssueAttributeDefinitionListOptionDefinition>? Options { get; set; }
#nullable restore
#else
        public List<global::Autodesk.ACC.Issues.Models.IssueAttributeDefinitionListOptionDefinition> Options { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Autodesk.ACC.Issues.Models.IssueAttributeDefinitionDefinition_metadata_list"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Autodesk.ACC.Issues.Models.IssueAttributeDefinitionDefinition_metadata_list CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Autodesk.ACC.Issues.Models.IssueAttributeDefinitionDefinition_metadata_list();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "options", n => { Options = n.GetCollectionOfObjectValues<global::Autodesk.ACC.Issues.Models.IssueAttributeDefinitionListOptionDefinition>(global::Autodesk.ACC.Issues.Models.IssueAttributeDefinitionListOptionDefinition.CreateFromDiscriminatorValue)?.AsList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<global::Autodesk.ACC.Issues.Models.IssueAttributeDefinitionListOptionDefinition>("options", Options);
        }
    }
}
#pragma warning restore CS0618
