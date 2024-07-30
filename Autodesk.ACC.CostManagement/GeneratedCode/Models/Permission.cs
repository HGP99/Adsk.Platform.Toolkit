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
    public partial class Permission : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The timestamp of the date and time the item was created, in the following format: YYYY-MM-DDThh:mm:ss.sz.</summary>
        public DateTimeOffset? CreatedAt { get; private set; }
        /// <summary>The unique idenfitifier of a permission setting.</summary>
        public Guid? Id { get; private set; }
        /// <summary>The permission level to access a module. Possible values: ``noAccess``, ``viewAll``, ``collaborate``, ``fullControl``.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PermissionLevel { get; set; }
#nullable restore
#else
        public string PermissionLevel { get; set; }
#endif
        /// <summary>The module the permission to control. Possible values: ``MainContract``, ``Budget``, ``Contract``, ``BudgetPayment``, ``CostPayment``, ``ActualCost``, ``CostItem``,``PCO``, ``RFQ``, ``RCO``, ``OCO``, ``SCO``.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ResourceType { get; set; }
#nullable restore
#else
        public string ResourceType { get; set; }
#endif
        /// <summary>User&apos;s autodeskID or role and company&apos;s autodesk group ID.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SubjectId { get; set; }
#nullable restore
#else
        public string SubjectId { get; set; }
#endif
        /// <summary>The type of the subject to controll the permission. Possible values: ``User``, ``Role``, ``Company``.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SubjectType { get; set; }
#nullable restore
#else
        public string SubjectType { get; set; }
#endif
        /// <summary>The timestamp of the date and time the item was updated, in the following format: YYYY-MM-DDThh:mm:ss.sz.</summary>
        public DateTimeOffset? UpdatedAt { get; private set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Autodesk.ACC.CostManagement.Models.Permission"/> and sets the default values.
        /// </summary>
        public Permission()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Autodesk.ACC.CostManagement.Models.Permission"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Autodesk.ACC.CostManagement.Models.Permission CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Autodesk.ACC.CostManagement.Models.Permission();
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
                { "id", n => { Id = n.GetGuidValue(); } },
                { "permissionLevel", n => { PermissionLevel = n.GetStringValue(); } },
                { "resourceType", n => { ResourceType = n.GetStringValue(); } },
                { "subjectId", n => { SubjectId = n.GetStringValue(); } },
                { "subjectType", n => { SubjectType = n.GetStringValue(); } },
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
            writer.WriteStringValue("permissionLevel", PermissionLevel);
            writer.WriteStringValue("resourceType", ResourceType);
            writer.WriteStringValue("subjectId", SubjectId);
            writer.WriteStringValue("subjectType", SubjectType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
