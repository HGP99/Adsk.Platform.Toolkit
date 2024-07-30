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
    public partial class FormInstance : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The date and time when the markup formula was applied.</summary>
        public DateTimeOffset? AppliedAt { get; set; }
        /// <summary>The ID of the user who applied markups to this change order, a project user managed by BIM 360 Admin.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AppliedBy { get; set; }
#nullable restore
#else
        public string AppliedBy { get; set; }
#endif
        /// <summary>The amount approved by the owner.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Approved { get; private set; }
#nullable restore
#else
        public string Approved { get; private set; }
#endif
        /// <summary>The budget status of the PCO, RCO or OCO: Possible PCO statuses: [draft, open, submitted, accepted, approved, executed, rejected]. Possible RCO statuses: [draft, open, submitted, accepted, rejected]. Possible OCO statuses: [draft, open, submitted, approved, executed, rejected]. Empty for an RFQ or SCO. The status of the change order should not be updated directly, but set by an action working on the change order.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BudgetStatus { get; private set; }
#nullable restore
#else
        public string BudgetStatus { get; private set; }
#endif
        /// <summary>The ID of the person who lastly changed the change order, a project user managed by BIM 360 Admin.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ChangedBy { get; set; }
#nullable restore
#else
        public string ChangedBy { get; set; }
#endif
        /// <summary>The amount committed to the supplier.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Committed { get; private set; }
#nullable restore
#else
        public string Committed { get; private set; }
#endif
        /// <summary>The cost items in the change order</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Autodesk.ACC.CostManagement.Models.FormInstance_costItems>? CostItems { get; set; }
#nullable restore
#else
        public List<global::Autodesk.ACC.CostManagement.Models.FormInstance_costItems> CostItems { get; set; }
#endif
        /// <summary>The cost status of the PCO, RCO, or OCO: Possible PCO statuses: [draft, open, pricing, proposed, approved, executed, rejected]. Possible RFQ statuses: [draft, open, pricing, proposed, rejected]. Possible SCO statuses: [draft, open, sent, executed]. Empty for an RCO or OCO. The status of the change order should not be updated directly, but set by an action working on the change order.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CostStatus { get; private set; }
#nullable restore
#else
        public string CostStatus { get; private set; }
#endif
        /// <summary>The timestamp of the date and time the item was created, in the following format: YYYY-MM-DDThh:mm:ss.sz.</summary>
        public DateTimeOffset? CreatedAt { get; private set; }
        /// <summary>The ID of the change order’s creator, a project user managed by BIM 360 Admin.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CreatorId { get; set; }
#nullable restore
#else
        public string CreatorId { get; set; }
#endif
        /// <summary>The detail description of the Change Order.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>Rough estimate of this change order without a quotation.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Estimated { get; private set; }
#nullable restore
#else
        public string Estimated { get; private set; }
#endif
        /// <summary>The ID of the item in its original external system. You can use this ID to track the source of truth or to look up the data in an integrated system.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ExternalId { get; set; }
#nullable restore
#else
        public string ExternalId { get; set; }
#endif
        /// <summary>A description about the integration: success, failure or error message.</summary>
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
        /// <summary>Unique identifier of a change order, auto generated.</summary>
        public Guid? Id { get; private set; }
        /// <summary>Lock state used by ERP integration, default value is ``null``.</summary>
        public global::Autodesk.ACC.CostManagement.Models.FormInstance_integrationState? IntegrationState { get; set; }
        /// <summary>The date and time last locked this item.</summary>
        public DateTimeOffset? IntegrationStateChangedAt { get; set; }
        /// <summary>The user who last locked this item. This is the ID of a user managed by BIM 360 Admin.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? IntegrationStateChangedBy { get; set; }
#nullable restore
#else
        public string IntegrationStateChangedBy { get; set; }
#endif
        /// <summary>The date and time when the item was last updated.</summary>
        public DateTimeOffset? LastSyncTime { get; private set; }
        /// <summary>The ID of the markup formula applied to this change order.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MarkupFormulaId { get; set; }
#nullable restore
#else
        public string MarkupFormulaId { get; set; }
#endif
        /// <summary>The name of the Change Order</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The note to the change order. Draftjs formatted rich text (https://draftjs.org/)</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Note { get; set; }
#nullable restore
#else
        public string Note { get; set; }
#endif
        /// <summary>System-generated sequential number.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Number { get; set; }
#nullable restore
#else
        public string Number { get; set; }
#endif
        /// <summary>The ID of the change order’s owner, a project user managed by BIM 360 Admin.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OwnerId { get; set; }
#nullable restore
#else
        public string OwnerId { get; set; }
#endif
        /// <summary>The custom attributes of the change order</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Autodesk.ACC.CostManagement.Models.PropertyResponse>? Properties { get; set; }
#nullable restore
#else
        public List<global::Autodesk.ACC.CostManagement.Models.PropertyResponse> Properties { get; set; }
#endif
        /// <summary>The quoted cost of the change order.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Proposed { get; private set; }
#nullable restore
#else
        public string Proposed { get; private set; }
#endif
        /// <summary>The scope of the change order. Possible values are ``out``, ``in``, ``tbd`` , ``budgetOnly``and ``contingency``.</summary>
        public global::Autodesk.ACC.CostManagement.Models.FormInstance_scope? Scope { get; set; }
        /// <summary>The scope of work of the change order. Draftjs formatted rich text (https://draftjs.org/)</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ScopeOfWork { get; set; }
#nullable restore
#else
        public string ScopeOfWork { get; set; }
#endif
        /// <summary>The ID of the source of the RFQ, ususally the PCO ID</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SourceId { get; private set; }
#nullable restore
#else
        public string SourceId { get; private set; }
#endif
        /// <summary>The amount sent to the owner for approval.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Submitted { get; private set; }
#nullable restore
#else
        public string Submitted { get; private set; }
#endif
        /// <summary>The type of the change order. It is customizable by the project admin.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Type { get; set; }
#nullable restore
#else
        public string Type { get; set; }
#endif
        /// <summary>The timestamp of the date and time the item was updated, in the following format: YYYY-MM-DDThh:mm:ss.sz.</summary>
        public DateTimeOffset? UpdatedAt { get; private set; }
        /// <summary>The variables when apply markup formula</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Autodesk.ACC.CostManagement.Models.FormInstance_variableMarkupFormulaItems>? VariableMarkupFormulaItems { get; set; }
#nullable restore
#else
        public List<global::Autodesk.ACC.CostManagement.Models.FormInstance_variableMarkupFormulaItems> VariableMarkupFormulaItems { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Autodesk.ACC.CostManagement.Models.FormInstance"/> and sets the default values.
        /// </summary>
        public FormInstance()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Autodesk.ACC.CostManagement.Models.FormInstance"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Autodesk.ACC.CostManagement.Models.FormInstance CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Autodesk.ACC.CostManagement.Models.FormInstance();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "appliedAt", n => { AppliedAt = n.GetDateTimeOffsetValue(); } },
                { "appliedBy", n => { AppliedBy = n.GetStringValue(); } },
                { "approved", n => { Approved = n.GetStringValue(); } },
                { "budgetStatus", n => { BudgetStatus = n.GetStringValue(); } },
                { "changedBy", n => { ChangedBy = n.GetStringValue(); } },
                { "committed", n => { Committed = n.GetStringValue(); } },
                { "costItems", n => { CostItems = n.GetCollectionOfObjectValues<global::Autodesk.ACC.CostManagement.Models.FormInstance_costItems>(global::Autodesk.ACC.CostManagement.Models.FormInstance_costItems.CreateFromDiscriminatorValue)?.AsList(); } },
                { "costStatus", n => { CostStatus = n.GetStringValue(); } },
                { "createdAt", n => { CreatedAt = n.GetDateTimeOffsetValue(); } },
                { "creatorId", n => { CreatorId = n.GetStringValue(); } },
                { "description", n => { Description = n.GetStringValue(); } },
                { "estimated", n => { Estimated = n.GetStringValue(); } },
                { "externalId", n => { ExternalId = n.GetStringValue(); } },
                { "externalMessage", n => { ExternalMessage = n.GetStringValue(); } },
                { "externalSystem", n => { ExternalSystem = n.GetStringValue(); } },
                { "id", n => { Id = n.GetGuidValue(); } },
                { "integrationState", n => { IntegrationState = n.GetEnumValue<global::Autodesk.ACC.CostManagement.Models.FormInstance_integrationState>(); } },
                { "integrationStateChangedAt", n => { IntegrationStateChangedAt = n.GetDateTimeOffsetValue(); } },
                { "integrationStateChangedBy", n => { IntegrationStateChangedBy = n.GetStringValue(); } },
                { "lastSyncTime", n => { LastSyncTime = n.GetDateTimeOffsetValue(); } },
                { "markupFormulaId", n => { MarkupFormulaId = n.GetStringValue(); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "note", n => { Note = n.GetStringValue(); } },
                { "number", n => { Number = n.GetStringValue(); } },
                { "ownerId", n => { OwnerId = n.GetStringValue(); } },
                { "properties", n => { Properties = n.GetCollectionOfObjectValues<global::Autodesk.ACC.CostManagement.Models.PropertyResponse>(global::Autodesk.ACC.CostManagement.Models.PropertyResponse.CreateFromDiscriminatorValue)?.AsList(); } },
                { "proposed", n => { Proposed = n.GetStringValue(); } },
                { "scope", n => { Scope = n.GetEnumValue<global::Autodesk.ACC.CostManagement.Models.FormInstance_scope>(); } },
                { "scopeOfWork", n => { ScopeOfWork = n.GetStringValue(); } },
                { "sourceId", n => { SourceId = n.GetStringValue(); } },
                { "submitted", n => { Submitted = n.GetStringValue(); } },
                { "type", n => { Type = n.GetStringValue(); } },
                { "updatedAt", n => { UpdatedAt = n.GetDateTimeOffsetValue(); } },
                { "variableMarkupFormulaItems", n => { VariableMarkupFormulaItems = n.GetCollectionOfObjectValues<global::Autodesk.ACC.CostManagement.Models.FormInstance_variableMarkupFormulaItems>(global::Autodesk.ACC.CostManagement.Models.FormInstance_variableMarkupFormulaItems.CreateFromDiscriminatorValue)?.AsList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDateTimeOffsetValue("appliedAt", AppliedAt);
            writer.WriteStringValue("appliedBy", AppliedBy);
            writer.WriteStringValue("changedBy", ChangedBy);
            writer.WriteCollectionOfObjectValues<global::Autodesk.ACC.CostManagement.Models.FormInstance_costItems>("costItems", CostItems);
            writer.WriteStringValue("creatorId", CreatorId);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("externalId", ExternalId);
            writer.WriteStringValue("externalMessage", ExternalMessage);
            writer.WriteStringValue("externalSystem", ExternalSystem);
            writer.WriteEnumValue<global::Autodesk.ACC.CostManagement.Models.FormInstance_integrationState>("integrationState", IntegrationState);
            writer.WriteDateTimeOffsetValue("integrationStateChangedAt", IntegrationStateChangedAt);
            writer.WriteStringValue("integrationStateChangedBy", IntegrationStateChangedBy);
            writer.WriteStringValue("markupFormulaId", MarkupFormulaId);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("note", Note);
            writer.WriteStringValue("number", Number);
            writer.WriteStringValue("ownerId", OwnerId);
            writer.WriteCollectionOfObjectValues<global::Autodesk.ACC.CostManagement.Models.PropertyResponse>("properties", Properties);
            writer.WriteEnumValue<global::Autodesk.ACC.CostManagement.Models.FormInstance_scope>("scope", Scope);
            writer.WriteStringValue("scopeOfWork", ScopeOfWork);
            writer.WriteStringValue("type", Type);
            writer.WriteCollectionOfObjectValues<global::Autodesk.ACC.CostManagement.Models.FormInstance_variableMarkupFormulaItems>("variableMarkupFormulaItems", VariableMarkupFormulaItems);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
