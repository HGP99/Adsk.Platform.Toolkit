// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Autodesk.ACC.RFIs.Models {
    /// <summary>
    /// The list of statuses the user is permitted to transition an RFI to, without the wfType distinction (us + emea).
    /// </summary>
    public class Rfi_permittedActions_updateRfi_allPermittedStatuses : IAdditionalDataHolder, IParsable 
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The wfEU property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<PermittedRfiStatus>? WfEU { get; set; }
#nullable restore
#else
        public List<PermittedRfiStatus> WfEU { get; set; }
#endif
        /// <summary>The wfUS property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<PermittedRfiStatus>? WfUS { get; set; }
#nullable restore
#else
        public List<PermittedRfiStatus> WfUS { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="Rfi_permittedActions_updateRfi_allPermittedStatuses"/> and sets the default values.
        /// </summary>
        public Rfi_permittedActions_updateRfi_allPermittedStatuses()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Rfi_permittedActions_updateRfi_allPermittedStatuses"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Rfi_permittedActions_updateRfi_allPermittedStatuses CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Rfi_permittedActions_updateRfi_allPermittedStatuses();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"wfEU", n => { WfEU = n.GetCollectionOfObjectValues<PermittedRfiStatus>(PermittedRfiStatus.CreateFromDiscriminatorValue)?.ToList(); } },
                {"wfUS", n => { WfUS = n.GetCollectionOfObjectValues<PermittedRfiStatus>(PermittedRfiStatus.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<PermittedRfiStatus>("wfEU", WfEU);
            writer.WriteCollectionOfObjectValues<PermittedRfiStatus>("wfUS", WfUS);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
