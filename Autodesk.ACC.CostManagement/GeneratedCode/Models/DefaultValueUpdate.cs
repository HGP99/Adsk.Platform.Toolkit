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
    public partial class DefaultValueUpdate : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The value of the default value definition.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Autodesk.ACC.CostManagement.Models.DefaultValueUpdate_value? Value { get; set; }
#nullable restore
#else
        public global::Autodesk.ACC.CostManagement.Models.DefaultValueUpdate_value Value { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Autodesk.ACC.CostManagement.Models.DefaultValueUpdate"/> and sets the default values.
        /// </summary>
        public DefaultValueUpdate()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Autodesk.ACC.CostManagement.Models.DefaultValueUpdate"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Autodesk.ACC.CostManagement.Models.DefaultValueUpdate CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Autodesk.ACC.CostManagement.Models.DefaultValueUpdate();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "value", n => { Value = n.GetObjectValue<global::Autodesk.ACC.CostManagement.Models.DefaultValueUpdate_value>(global::Autodesk.ACC.CostManagement.Models.DefaultValueUpdate_value.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::Autodesk.ACC.CostManagement.Models.DefaultValueUpdate_value>("value", Value);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
