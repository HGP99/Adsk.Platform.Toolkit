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
    public partial class CalendarConfiguration : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The timestamp of the date and time the item was created, in the following format: YYYY-MM-DDThh:mm:ss.sz.</summary>
        public DateTimeOffset? CreatedAt { get; private set; }
        /// <summary>The user who created the confgiuration.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CreatorId { get; set; }
#nullable restore
#else
        public string CreatorId { get; set; }
#endif
        /// <summary>Unique identifier of calendar configuration item.</summary>
        public Guid? Id { get; private set; }
        /// <summary>The scope of confgiuration</summary>
        public global::Autodesk.ACC.CostManagement.Models.CalendarConfiguration_scope? Scope { get; set; }
        /// <summary>The source of item</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Source { get; set; }
#nullable restore
#else
        public string Source { get; set; }
#endif
        /// <summary>The type of the item with which the item is associated. Possible values: ``Budget``, ``Contract``, ``FormInstance``, ``CostItem``, ``Payment``, ``MainContract``, ``BudgetPayment``.</summary>
        public global::Autodesk.ACC.CostManagement.Models.CalendarConfiguration_sourceType? SourceType { get; set; }
        /// <summary>The timestamp of the date and time the item was updated, in the following format: YYYY-MM-DDThh:mm:ss.sz.</summary>
        public DateTimeOffset? UpdatedAt { get; private set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Autodesk.ACC.CostManagement.Models.CalendarConfiguration"/> and sets the default values.
        /// </summary>
        public CalendarConfiguration()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Autodesk.ACC.CostManagement.Models.CalendarConfiguration"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Autodesk.ACC.CostManagement.Models.CalendarConfiguration CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Autodesk.ACC.CostManagement.Models.CalendarConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "createdAt", n => { CreatedAt = n.GetDateTimeOffsetValue(); } },
                { "creatorId", n => { CreatorId = n.GetStringValue(); } },
                { "id", n => { Id = n.GetGuidValue(); } },
                { "scope", n => { Scope = n.GetEnumValue<global::Autodesk.ACC.CostManagement.Models.CalendarConfiguration_scope>(); } },
                { "source", n => { Source = n.GetStringValue(); } },
                { "sourceType", n => { SourceType = n.GetEnumValue<global::Autodesk.ACC.CostManagement.Models.CalendarConfiguration_sourceType>(); } },
                { "updatedAt", n => { UpdatedAt = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("creatorId", CreatorId);
            writer.WriteEnumValue<global::Autodesk.ACC.CostManagement.Models.CalendarConfiguration_scope>("scope", Scope);
            writer.WriteStringValue("source", Source);
            writer.WriteEnumValue<global::Autodesk.ACC.CostManagement.Models.CalendarConfiguration_sourceType>("sourceType", SourceType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
