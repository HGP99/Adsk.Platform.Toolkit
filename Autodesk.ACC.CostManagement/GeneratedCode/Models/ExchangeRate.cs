// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System;
namespace Autodesk.ACC.CostManagement.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class ExchangeRate : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The timestamp of the date and time the item was created, in the following format: YYYY-MM-DDThh:mm:ss.sz.</summary>
        public DateTimeOffset? CreatedAt { get; private set; }
        /// <summary>The user who created this exchange rate setting. This is the ID of a user managed by BIM 360 Admin.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CreatorId { get; private set; }
#nullable restore
#else
        public string CreatorId { get; private set; }
#endif
        /// <summary>Valid end date for this exchange rate setting.</summary>
        public Date? EndDate { get; set; }
        /// <summary>Exchange rate based on base currency. For example, 1 base currency = 0.7455 foreign currency.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ExchangeRateProp { get; set; }
#nullable restore
#else
        public string ExchangeRateProp { get; set; }
#endif
        /// <summary>Base currency name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? From { get; set; }
#nullable restore
#else
        public string From { get; set; }
#endif
        /// <summary>Unique identifier of exchange rate setting.</summary>
        public Guid? Id { get; set; }
        /// <summary>Valid start date for this exchange rate setting.</summary>
        public Date? StartDate { get; set; }
        /// <summary>Foreign currency name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? To { get; set; }
#nullable restore
#else
        public string To { get; set; }
#endif
        /// <summary>The timestamp of the date and time the item was updated, in the following format: YYYY-MM-DDThh:mm:ss.sz.</summary>
        public DateTimeOffset? UpdatedAt { get; private set; }
        /// <summary>The user who last update this exchange rate setting. This is the ID of a user managed by BIM 360 Admin.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UpdatedBy { get; private set; }
#nullable restore
#else
        public string UpdatedBy { get; private set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Autodesk.ACC.CostManagement.Models.ExchangeRate"/> and sets the default values.
        /// </summary>
        public ExchangeRate()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Autodesk.ACC.CostManagement.Models.ExchangeRate"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Autodesk.ACC.CostManagement.Models.ExchangeRate CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Autodesk.ACC.CostManagement.Models.ExchangeRate();
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
                { "endDate", n => { EndDate = n.GetDateValue(); } },
                { "exchangeRate", n => { ExchangeRateProp = n.GetStringValue(); } },
                { "from", n => { From = n.GetStringValue(); } },
                { "id", n => { Id = n.GetGuidValue(); } },
                { "startDate", n => { StartDate = n.GetDateValue(); } },
                { "to", n => { To = n.GetStringValue(); } },
                { "updatedAt", n => { UpdatedAt = n.GetDateTimeOffsetValue(); } },
                { "updatedBy", n => { UpdatedBy = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDateValue("endDate", EndDate);
            writer.WriteStringValue("exchangeRate", ExchangeRateProp);
            writer.WriteStringValue("from", From);
            writer.WriteGuidValue("id", Id);
            writer.WriteDateValue("startDate", StartDate);
            writer.WriteStringValue("to", To);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
