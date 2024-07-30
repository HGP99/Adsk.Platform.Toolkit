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
    public partial class ExpenseCreate : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>ID of the contract to which the expense belongs. Expense items will be created based on contract schedule of values.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ContractId { get; set; }
#nullable restore
#else
        public string ContractId { get; set; }
#endif
        /// <summary>The detail description of the expense.</summary>
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
        /// <summary>Unique identifier of the expense.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id { get; set; }
#nullable restore
#else
        public string Id { get; set; }
#endif
        /// <summary>Lock state used by ERP integration, default value is ``null``.</summary>
        public global::Autodesk.ACC.CostManagement.Models.ExpenseCreate_integrationState? IntegrationState { get; set; }
        /// <summary>The date and time when the expense is issued.</summary>
        public DateTimeOffset? IssuedAt { get; set; }
        /// <summary>The name of the expense.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The note of the expense. Draftjs formatted rich text (https://draftjs.org/)</summary>
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
        /// <summary>The payment due date of the expense.</summary>
        public DateTimeOffset? PaymentDue { get; set; }
        /// <summary>The check/cheque number or electronic transfer number.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PaymentReference { get; set; }
#nullable restore
#else
        public string PaymentReference { get; set; }
#endif
        /// <summary>The Populated by ERP no default, could be something like Check/Cheque/Electronic Transfer.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PaymentType { get; set; }
#nullable restore
#else
        public string PaymentType { get; set; }
#endif
        /// <summary>The user who purchased items in the expense. This is the ID of a user managed by BIM 360 Admin.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PurchasedBy { get; set; }
#nullable restore
#else
        public string PurchasedBy { get; set; }
#endif
        /// <summary>The date and time when the expense is received.</summary>
        public DateTimeOffset? ReceivedAt { get; set; }
        /// <summary>The reference number of the expense.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ReferenceNumber { get; set; }
#nullable restore
#else
        public string ReferenceNumber { get; set; }
#endif
        /// <summary>The expense type of the expense. Possible values: ``full``, ``partial``.</summary>
        public global::Autodesk.ACC.CostManagement.Models.ExpenseCreate_scope? Scope { get; set; }
        /// <summary>The status of the expense. Possible values: ``draft``, ``pending``, ``revise``, ``rejected``, ``approved``, ``paid``.</summary>
        public global::Autodesk.ACC.CostManagement.Models.ExpenseCreate_status? Status { get; set; }
        /// <summary>The supplier for the expense. This is the ID of a company managed by BIM 360 Admin.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SupplierId { get; set; }
#nullable restore
#else
        public string SupplierId { get; set; }
#endif
        /// <summary>The supplier name for the expense. User can create a new supplier or select from BIM 360 Admin.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SupplierName { get; set; }
#nullable restore
#else
        public string SupplierName { get; set; }
#endif
        /// <summary>The term of the expense. It is customizable by the project admin.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Term { get; set; }
#nullable restore
#else
        public string Term { get; set; }
#endif
        /// <summary>The type of the expense. It is customizable by the project admin.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Type { get; set; }
#nullable restore
#else
        public string Type { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Autodesk.ACC.CostManagement.Models.ExpenseCreate"/> and sets the default values.
        /// </summary>
        public ExpenseCreate()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Autodesk.ACC.CostManagement.Models.ExpenseCreate"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Autodesk.ACC.CostManagement.Models.ExpenseCreate CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Autodesk.ACC.CostManagement.Models.ExpenseCreate();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "contractId", n => { ContractId = n.GetStringValue(); } },
                { "description", n => { Description = n.GetStringValue(); } },
                { "externalId", n => { ExternalId = n.GetStringValue(); } },
                { "externalMessage", n => { ExternalMessage = n.GetStringValue(); } },
                { "externalSystem", n => { ExternalSystem = n.GetStringValue(); } },
                { "id", n => { Id = n.GetStringValue(); } },
                { "integrationState", n => { IntegrationState = n.GetEnumValue<global::Autodesk.ACC.CostManagement.Models.ExpenseCreate_integrationState>(); } },
                { "issuedAt", n => { IssuedAt = n.GetDateTimeOffsetValue(); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "note", n => { Note = n.GetStringValue(); } },
                { "number", n => { Number = n.GetStringValue(); } },
                { "paymentDue", n => { PaymentDue = n.GetDateTimeOffsetValue(); } },
                { "paymentReference", n => { PaymentReference = n.GetStringValue(); } },
                { "paymentType", n => { PaymentType = n.GetStringValue(); } },
                { "purchasedBy", n => { PurchasedBy = n.GetStringValue(); } },
                { "receivedAt", n => { ReceivedAt = n.GetDateTimeOffsetValue(); } },
                { "referenceNumber", n => { ReferenceNumber = n.GetStringValue(); } },
                { "scope", n => { Scope = n.GetEnumValue<global::Autodesk.ACC.CostManagement.Models.ExpenseCreate_scope>(); } },
                { "status", n => { Status = n.GetEnumValue<global::Autodesk.ACC.CostManagement.Models.ExpenseCreate_status>(); } },
                { "supplierId", n => { SupplierId = n.GetStringValue(); } },
                { "supplierName", n => { SupplierName = n.GetStringValue(); } },
                { "term", n => { Term = n.GetStringValue(); } },
                { "type", n => { Type = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("contractId", ContractId);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("externalId", ExternalId);
            writer.WriteStringValue("externalMessage", ExternalMessage);
            writer.WriteStringValue("externalSystem", ExternalSystem);
            writer.WriteStringValue("id", Id);
            writer.WriteEnumValue<global::Autodesk.ACC.CostManagement.Models.ExpenseCreate_integrationState>("integrationState", IntegrationState);
            writer.WriteDateTimeOffsetValue("issuedAt", IssuedAt);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("note", Note);
            writer.WriteStringValue("number", Number);
            writer.WriteDateTimeOffsetValue("paymentDue", PaymentDue);
            writer.WriteStringValue("paymentReference", PaymentReference);
            writer.WriteStringValue("paymentType", PaymentType);
            writer.WriteStringValue("purchasedBy", PurchasedBy);
            writer.WriteDateTimeOffsetValue("receivedAt", ReceivedAt);
            writer.WriteStringValue("referenceNumber", ReferenceNumber);
            writer.WriteEnumValue<global::Autodesk.ACC.CostManagement.Models.ExpenseCreate_scope>("scope", Scope);
            writer.WriteEnumValue<global::Autodesk.ACC.CostManagement.Models.ExpenseCreate_status>("status", Status);
            writer.WriteStringValue("supplierId", SupplierId);
            writer.WriteStringValue("supplierName", SupplierName);
            writer.WriteStringValue("term", Term);
            writer.WriteStringValue("type", Type);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
