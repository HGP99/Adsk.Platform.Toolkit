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
    public partial class PerformanceTrackingItem : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The unique identifier of the performance tracking item associated budget.</summary>
        public Guid? BudgetId { get; set; }
        /// <summary>The code of the performance tracking item associated budget.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Code { get; set; }
#nullable restore
#else
        public string Code { get; set; }
#endif
        /// <summary>The unique identifier of the performance tracking item associated container.</summary>
        public Guid? ContainerId { get; set; }
        /// <summary>The description of the performance tracking item associated budget.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>The unique identifier of the performance tracking item.</summary>
        public Guid? Id { get; set; }
        /// <summary>The IDs of the locations have been selected and parents of selected.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Guid?>? LocationPaths { get; set; }
#nullable restore
#else
        public List<Guid?> LocationPaths { get; set; }
#endif
        /// <summary>The IDs of the locations have been selected.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Guid?>? Locations { get; set; }
#nullable restore
#else
        public List<Guid?> Locations { get; set; }
#endif
        /// <summary>The name of the performance tracking item associated budget.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>Original amount of the budget, equals to ``quantity`` * ``unitPrice``</summary>
        public double? OriginalAmount { get; set; }
        /// <summary>The planned end date of the performance tracking item associated budget.</summary>
        public DateTimeOffset? PlannedEndDate { get; set; }
        /// <summary>The planned start date of the performance tracking item associated budget.</summary>
        public DateTimeOffset? PlannedStartDate { get; set; }
        /// <summary>The quantity of the performance tracking item associated budget.</summary>
        public double? Quantity { get; set; }
        /// <summary>The unit of the performance tracking item associated budget.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Unit { get; set; }
#nullable restore
#else
        public string Unit { get; set; }
#endif
        /// <summary>The unit price of the performance tracking item associated budget.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UnitPrice { get; set; }
#nullable restore
#else
        public string UnitPrice { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Autodesk.ACC.CostManagement.Models.PerformanceTrackingItem"/> and sets the default values.
        /// </summary>
        public PerformanceTrackingItem()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Autodesk.ACC.CostManagement.Models.PerformanceTrackingItem"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Autodesk.ACC.CostManagement.Models.PerformanceTrackingItem CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Autodesk.ACC.CostManagement.Models.PerformanceTrackingItem();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "budgetId", n => { BudgetId = n.GetGuidValue(); } },
                { "code", n => { Code = n.GetStringValue(); } },
                { "containerId", n => { ContainerId = n.GetGuidValue(); } },
                { "description", n => { Description = n.GetStringValue(); } },
                { "id", n => { Id = n.GetGuidValue(); } },
                { "locationPaths", n => { LocationPaths = n.GetCollectionOfPrimitiveValues<Guid?>()?.AsList(); } },
                { "locations", n => { Locations = n.GetCollectionOfPrimitiveValues<Guid?>()?.AsList(); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "originalAmount", n => { OriginalAmount = n.GetDoubleValue(); } },
                { "plannedEndDate", n => { PlannedEndDate = n.GetDateTimeOffsetValue(); } },
                { "plannedStartDate", n => { PlannedStartDate = n.GetDateTimeOffsetValue(); } },
                { "quantity", n => { Quantity = n.GetDoubleValue(); } },
                { "unit", n => { Unit = n.GetStringValue(); } },
                { "unitPrice", n => { UnitPrice = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteGuidValue("budgetId", BudgetId);
            writer.WriteStringValue("code", Code);
            writer.WriteGuidValue("containerId", ContainerId);
            writer.WriteStringValue("description", Description);
            writer.WriteGuidValue("id", Id);
            writer.WriteCollectionOfPrimitiveValues<Guid?>("locationPaths", LocationPaths);
            writer.WriteCollectionOfPrimitiveValues<Guid?>("locations", Locations);
            writer.WriteStringValue("name", Name);
            writer.WriteDoubleValue("originalAmount", OriginalAmount);
            writer.WriteDateTimeOffsetValue("plannedEndDate", PlannedEndDate);
            writer.WriteDateTimeOffsetValue("plannedStartDate", PlannedStartDate);
            writer.WriteDoubleValue("quantity", Quantity);
            writer.WriteStringValue("unit", Unit);
            writer.WriteStringValue("unitPrice", UnitPrice);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
