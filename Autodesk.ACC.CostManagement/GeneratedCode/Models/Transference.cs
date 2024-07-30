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
    public partial class Transference : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The amount of the budget transfer.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Amount { get; set; }
#nullable restore
#else
        public string Amount { get; set; }
#endif
        /// <summary>The ID of the budget that the transfer is from.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BudgetId { get; set; }
#nullable restore
#else
        public string BudgetId { get; set; }
#endif
        /// <summary>The ID of the contract that the transfer is from.</summary>
        public Guid? ContractId { get; set; }
        /// <summary>The timestamp of the date and time the item was created, in the following format: YYYY-MM-DDThh:mm:ss.sz.</summary>
        public DateTimeOffset? CreatedAt { get; private set; }
        /// <summary>The Autodesk ID of the user who creates the budget transfer.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CreatorId { get; private set; }
#nullable restore
#else
        public string CreatorId { get; private set; }
#endif
        /// <summary>Unique identifier of a budget transfer.</summary>
        public Guid? Id { get; private set; }
        /// <summary>The input quantity of the budget transfer is from.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? InputQuantity { get; set; }
#nullable restore
#else
        public string InputQuantity { get; set; }
#endif
        /// <summary>Lock state used by ERP integration, default value is ``null``.</summary>
        public global::Autodesk.ACC.CostManagement.Models.Transference_integrationState? IntegrationState { get; set; }
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
        /// <summary>The note of the budget transfer.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Note { get; set; }
#nullable restore
#else
        public string Note { get; set; }
#endif
        /// <summary>The quantity of the budget transfer is from.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Quantity { get; set; }
#nullable restore
#else
        public string Quantity { get; set; }
#endif
        /// <summary>The ID of the budget that the transfer is to.</summary>
        public Guid? RelatingBudgetId { get; set; }
        /// <summary>The ID of the contract that the transfer is to.</summary>
        public Guid? RelatingContractId { get; set; }
        /// <summary>The input quantity of the budget transfer is to.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RelatingInputQuantity { get; set; }
#nullable restore
#else
        public string RelatingInputQuantity { get; set; }
#endif
        /// <summary>The quantity of the budget transfer is to.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RelatingQuantity { get; set; }
#nullable restore
#else
        public string RelatingQuantity { get; set; }
#endif
        /// <summary>The unit price of the budget transfer is to.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RelatingUnitPrice { get; set; }
#nullable restore
#else
        public string RelatingUnitPrice { get; set; }
#endif
        /// <summary>The ID of the two related transfers.</summary>
        public Guid? TransactionId { get; private set; }
        /// <summary>The unit price of the the budget transfer is from.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UnitPrice { get; set; }
#nullable restore
#else
        public string UnitPrice { get; set; }
#endif
        /// <summary>The timestamp of the date and time the item was updated, in the following format: YYYY-MM-DDThh:mm:ss.sz.</summary>
        public DateTimeOffset? UpdatedAt { get; private set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Autodesk.ACC.CostManagement.Models.Transference"/> and sets the default values.
        /// </summary>
        public Transference()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Autodesk.ACC.CostManagement.Models.Transference"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Autodesk.ACC.CostManagement.Models.Transference CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Autodesk.ACC.CostManagement.Models.Transference();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "amount", n => { Amount = n.GetStringValue(); } },
                { "budgetId", n => { BudgetId = n.GetStringValue(); } },
                { "contractId", n => { ContractId = n.GetGuidValue(); } },
                { "createdAt", n => { CreatedAt = n.GetDateTimeOffsetValue(); } },
                { "creatorId", n => { CreatorId = n.GetStringValue(); } },
                { "id", n => { Id = n.GetGuidValue(); } },
                { "inputQuantity", n => { InputQuantity = n.GetStringValue(); } },
                { "integrationState", n => { IntegrationState = n.GetEnumValue<global::Autodesk.ACC.CostManagement.Models.Transference_integrationState>(); } },
                { "integrationStateChangedAt", n => { IntegrationStateChangedAt = n.GetDateTimeOffsetValue(); } },
                { "integrationStateChangedBy", n => { IntegrationStateChangedBy = n.GetStringValue(); } },
                { "note", n => { Note = n.GetStringValue(); } },
                { "quantity", n => { Quantity = n.GetStringValue(); } },
                { "relatingBudgetId", n => { RelatingBudgetId = n.GetGuidValue(); } },
                { "relatingContractId", n => { RelatingContractId = n.GetGuidValue(); } },
                { "relatingInputQuantity", n => { RelatingInputQuantity = n.GetStringValue(); } },
                { "relatingQuantity", n => { RelatingQuantity = n.GetStringValue(); } },
                { "relatingUnitPrice", n => { RelatingUnitPrice = n.GetStringValue(); } },
                { "transactionId", n => { TransactionId = n.GetGuidValue(); } },
                { "unitPrice", n => { UnitPrice = n.GetStringValue(); } },
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
            writer.WriteStringValue("amount", Amount);
            writer.WriteStringValue("budgetId", BudgetId);
            writer.WriteGuidValue("contractId", ContractId);
            writer.WriteStringValue("inputQuantity", InputQuantity);
            writer.WriteEnumValue<global::Autodesk.ACC.CostManagement.Models.Transference_integrationState>("integrationState", IntegrationState);
            writer.WriteDateTimeOffsetValue("integrationStateChangedAt", IntegrationStateChangedAt);
            writer.WriteStringValue("integrationStateChangedBy", IntegrationStateChangedBy);
            writer.WriteStringValue("note", Note);
            writer.WriteStringValue("quantity", Quantity);
            writer.WriteGuidValue("relatingBudgetId", RelatingBudgetId);
            writer.WriteGuidValue("relatingContractId", RelatingContractId);
            writer.WriteStringValue("relatingInputQuantity", RelatingInputQuantity);
            writer.WriteStringValue("relatingQuantity", RelatingQuantity);
            writer.WriteStringValue("relatingUnitPrice", RelatingUnitPrice);
            writer.WriteStringValue("unitPrice", UnitPrice);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
