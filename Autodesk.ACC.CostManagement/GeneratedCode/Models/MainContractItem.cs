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
    public partial class MainContractItem : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The amount of this mainContractItem.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Amount { get; private set; }
#nullable restore
#else
        public string Amount { get; private set; }
#endif
        /// <summary>ID of the budget linked to the MainContractItem.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BudgetId { get; set; }
#nullable restore
#else
        public string BudgetId { get; set; }
#endif
        /// <summary>The code of the mainContractItem.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Code { get; set; }
#nullable restore
#else
        public string Code { get; set; }
#endif
        /// <summary>The ID of the cost container for the project. Each project is assigned a container that stores all of the cost data for the project.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ContainerId { get; set; }
#nullable restore
#else
        public string ContainerId { get; set; }
#endif
        /// <summary>The date and time when the mainContractItem was created.</summary>
        public DateTimeOffset? CreatedAt { get; private set; }
        /// <summary>The description of the mainContractItem.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>Unique identifier of a MainContractItem.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id { get; private set; }
#nullable restore
#else
        public string Id { get; private set; }
#endif
        /// <summary>Indicate whether mainContractItem is private or not.</summary>
        public bool? IsPrivate { get; set; }
        /// <summary>The ID of the mainContract, used only when creating MainContractItem.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MainContractId { get; set; }
#nullable restore
#else
        public string MainContractId { get; set; }
#endif
        /// <summary>The name of the mainContractItem.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The ID of the parent MainContractItem, used only when creating MainContractItem.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ParentId { get; set; }
#nullable restore
#else
        public string ParentId { get; set; }
#endif
        /// <summary>The quantity of this mainContractItem.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Quantity { get; set; }
#nullable restore
#else
        public string Quantity { get; set; }
#endif
        /// <summary>The unit of the mainContractItem.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Unit { get; set; }
#nullable restore
#else
        public string Unit { get; set; }
#endif
        /// <summary>The unit price of this mainContractItem.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UnitPrice { get; set; }
#nullable restore
#else
        public string UnitPrice { get; set; }
#endif
        /// <summary>The date and time when the mainContractItem was updated.</summary>
        public DateTimeOffset? UpdatedAt { get; private set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Autodesk.ACC.CostManagement.Models.MainContractItem"/> and sets the default values.
        /// </summary>
        public MainContractItem()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Autodesk.ACC.CostManagement.Models.MainContractItem"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Autodesk.ACC.CostManagement.Models.MainContractItem CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Autodesk.ACC.CostManagement.Models.MainContractItem();
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
                { "code", n => { Code = n.GetStringValue(); } },
                { "containerId", n => { ContainerId = n.GetStringValue(); } },
                { "createdAt", n => { CreatedAt = n.GetDateTimeOffsetValue(); } },
                { "description", n => { Description = n.GetStringValue(); } },
                { "id", n => { Id = n.GetStringValue(); } },
                { "isPrivate", n => { IsPrivate = n.GetBoolValue(); } },
                { "mainContractId", n => { MainContractId = n.GetStringValue(); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "parentId", n => { ParentId = n.GetStringValue(); } },
                { "quantity", n => { Quantity = n.GetStringValue(); } },
                { "unit", n => { Unit = n.GetStringValue(); } },
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
            writer.WriteStringValue("budgetId", BudgetId);
            writer.WriteStringValue("code", Code);
            writer.WriteStringValue("containerId", ContainerId);
            writer.WriteStringValue("description", Description);
            writer.WriteBoolValue("isPrivate", IsPrivate);
            writer.WriteStringValue("mainContractId", MainContractId);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("parentId", ParentId);
            writer.WriteStringValue("quantity", Quantity);
            writer.WriteStringValue("unit", Unit);
            writer.WriteStringValue("unitPrice", UnitPrice);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
