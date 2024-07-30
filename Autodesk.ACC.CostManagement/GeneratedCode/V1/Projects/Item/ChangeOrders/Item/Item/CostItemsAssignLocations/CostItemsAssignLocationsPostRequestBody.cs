// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Autodesk.ACC.CostManagement.V1.Projects.Item.ChangeOrders.Item.Item.CostItemsAssignLocations
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.16.0")]
    #pragma warning disable CS1591
    public partial class CostItemsAssignLocationsPostRequestBody : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
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
        /// <summary>
        /// Instantiates a new <see cref="global::Autodesk.ACC.CostManagement.V1.Projects.Item.ChangeOrders.Item.Item.CostItemsAssignLocations.CostItemsAssignLocationsPostRequestBody"/> and sets the default values.
        /// </summary>
        public CostItemsAssignLocationsPostRequestBody()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Autodesk.ACC.CostManagement.V1.Projects.Item.ChangeOrders.Item.Item.CostItemsAssignLocations.CostItemsAssignLocationsPostRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Autodesk.ACC.CostManagement.V1.Projects.Item.ChangeOrders.Item.Item.CostItemsAssignLocations.CostItemsAssignLocationsPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Autodesk.ACC.CostManagement.V1.Projects.Item.ChangeOrders.Item.Item.CostItemsAssignLocations.CostItemsAssignLocationsPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "locationPaths", n => { LocationPaths = n.GetCollectionOfPrimitiveValues<Guid?>()?.AsList(); } },
                { "locations", n => { Locations = n.GetCollectionOfPrimitiveValues<Guid?>()?.AsList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<Guid?>("locationPaths", LocationPaths);
            writer.WriteCollectionOfPrimitiveValues<Guid?>("locations", Locations);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
