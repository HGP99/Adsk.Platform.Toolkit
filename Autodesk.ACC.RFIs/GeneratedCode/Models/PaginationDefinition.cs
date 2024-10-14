// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Autodesk.ACC.RFIs.Models
{
    /// <summary>
    /// The pagination object.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class PaginationDefinition : IParsable
    {
        /// <summary>The number of items per page.</summary>
        public int? Limit { get; set; }
        /// <summary>The page number that the results begin from.</summary>
        public int? Offset { get; set; }
        /// <summary>The number of items in the response.</summary>
        public int? TotalResults { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Autodesk.ACC.RFIs.Models.PaginationDefinition"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Autodesk.ACC.RFIs.Models.PaginationDefinition CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Autodesk.ACC.RFIs.Models.PaginationDefinition();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "limit", n => { Limit = n.GetIntValue(); } },
                { "offset", n => { Offset = n.GetIntValue(); } },
                { "totalResults", n => { TotalResults = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("limit", Limit);
            writer.WriteIntValue("offset", Offset);
            writer.WriteIntValue("totalResults", TotalResults);
        }
    }
}
#pragma warning restore CS0618
