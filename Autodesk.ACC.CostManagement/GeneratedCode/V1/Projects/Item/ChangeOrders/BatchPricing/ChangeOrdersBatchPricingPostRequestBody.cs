// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System;
namespace Autodesk.ACC.CostManagement.V1.Projects.Item.ChangeOrders.BatchPricing
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.16.0")]
    #pragma warning disable CS1591
    public partial class ChangeOrdersBatchPricingPostRequestBody : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The attachmentIds property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? AttachmentIds { get; set; }
#nullable restore
#else
        public List<string> AttachmentIds { get; set; }
#endif
        /// <summary>The contractIds property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? ContractIds { get; set; }
#nullable restore
#else
        public List<string> ContractIds { get; set; }
#endif
        /// <summary>The dueDate property</summary>
        public Date? DueDate { get; set; }
        /// <summary>the email message</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? EmailMessage { get; set; }
#nullable restore
#else
        public string EmailMessage { get; set; }
#endif
        /// <summary>source of the pco id</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SourceId { get; set; }
#nullable restore
#else
        public string SourceId { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Autodesk.ACC.CostManagement.V1.Projects.Item.ChangeOrders.BatchPricing.ChangeOrdersBatchPricingPostRequestBody"/> and sets the default values.
        /// </summary>
        public ChangeOrdersBatchPricingPostRequestBody()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Autodesk.ACC.CostManagement.V1.Projects.Item.ChangeOrders.BatchPricing.ChangeOrdersBatchPricingPostRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Autodesk.ACC.CostManagement.V1.Projects.Item.ChangeOrders.BatchPricing.ChangeOrdersBatchPricingPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Autodesk.ACC.CostManagement.V1.Projects.Item.ChangeOrders.BatchPricing.ChangeOrdersBatchPricingPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "attachmentIds", n => { AttachmentIds = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "contractIds", n => { ContractIds = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "dueDate", n => { DueDate = n.GetDateValue(); } },
                { "emailMessage", n => { EmailMessage = n.GetStringValue(); } },
                { "sourceId", n => { SourceId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<string>("attachmentIds", AttachmentIds);
            writer.WriteCollectionOfPrimitiveValues<string>("contractIds", ContractIds);
            writer.WriteDateValue("dueDate", DueDate);
            writer.WriteStringValue("emailMessage", EmailMessage);
            writer.WriteStringValue("sourceId", SourceId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
