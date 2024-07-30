// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System;
namespace Autodesk.ACC.CostManagement.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.16.0")]
    #pragma warning disable CS1591
    public partial class BillingPeriodBatchUpdate : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The created property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Autodesk.ACC.CostManagement.Models.BillingPeriodUpdateItem>? Created { get; set; }
#nullable restore
#else
        public List<global::Autodesk.ACC.CostManagement.Models.BillingPeriodUpdateItem> Created { get; set; }
#endif
        /// <summary>The deleted property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Autodesk.ACC.CostManagement.Models.BillingPeriodUpdateItem>? Deleted { get; set; }
#nullable restore
#else
        public List<global::Autodesk.ACC.CostManagement.Models.BillingPeriodUpdateItem> Deleted { get; set; }
#endif
        /// <summary>The endDate property</summary>
        public Date? EndDate { get; set; }
        /// <summary>The startDate property</summary>
        public Date? StartDate { get; set; }
        /// <summary>The updated property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Autodesk.ACC.CostManagement.Models.BillingPeriodUpdateItem>? Updated { get; set; }
#nullable restore
#else
        public List<global::Autodesk.ACC.CostManagement.Models.BillingPeriodUpdateItem> Updated { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Autodesk.ACC.CostManagement.Models.BillingPeriodBatchUpdate"/> and sets the default values.
        /// </summary>
        public BillingPeriodBatchUpdate()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Autodesk.ACC.CostManagement.Models.BillingPeriodBatchUpdate"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Autodesk.ACC.CostManagement.Models.BillingPeriodBatchUpdate CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Autodesk.ACC.CostManagement.Models.BillingPeriodBatchUpdate();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "created", n => { Created = n.GetCollectionOfObjectValues<global::Autodesk.ACC.CostManagement.Models.BillingPeriodUpdateItem>(global::Autodesk.ACC.CostManagement.Models.BillingPeriodUpdateItem.CreateFromDiscriminatorValue)?.AsList(); } },
                { "deleted", n => { Deleted = n.GetCollectionOfObjectValues<global::Autodesk.ACC.CostManagement.Models.BillingPeriodUpdateItem>(global::Autodesk.ACC.CostManagement.Models.BillingPeriodUpdateItem.CreateFromDiscriminatorValue)?.AsList(); } },
                { "endDate", n => { EndDate = n.GetDateValue(); } },
                { "startDate", n => { StartDate = n.GetDateValue(); } },
                { "updated", n => { Updated = n.GetCollectionOfObjectValues<global::Autodesk.ACC.CostManagement.Models.BillingPeriodUpdateItem>(global::Autodesk.ACC.CostManagement.Models.BillingPeriodUpdateItem.CreateFromDiscriminatorValue)?.AsList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<global::Autodesk.ACC.CostManagement.Models.BillingPeriodUpdateItem>("created", Created);
            writer.WriteCollectionOfObjectValues<global::Autodesk.ACC.CostManagement.Models.BillingPeriodUpdateItem>("deleted", Deleted);
            writer.WriteDateValue("endDate", EndDate);
            writer.WriteDateValue("startDate", StartDate);
            writer.WriteCollectionOfObjectValues<global::Autodesk.ACC.CostManagement.Models.BillingPeriodUpdateItem>("updated", Updated);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
