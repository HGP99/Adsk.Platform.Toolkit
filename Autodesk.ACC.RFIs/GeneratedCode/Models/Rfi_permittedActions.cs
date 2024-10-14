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
    /// The list of actions that are permitted for the user.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class Rfi_permittedActions : IParsable
    {
        /// <summary>``true`` if the user can create an attachment for the RFI.``false`` if the user cannot create an attachment for the RFI.</summary>
        public bool? CreateAttachment { get; set; }
        /// <summary>``true`` if the user can create a comment for the RFI.``false`` if the user cannot create a comment for the RFI.</summary>
        public bool? CreateComment { get; set; }
        /// <summary>``true`` if the user can add a document reference to the RFI.``false`` if the user cannot add a document reference to the RFI.</summary>
        public bool? CreateDocumentReference { get; set; }
        /// <summary>``true`` if the user can link a PCO to the RFI.``false`` if the user cannot link a PCO to the RFI.</summary>
        public bool? LinkPCO { get; set; }
        /// <summary>``true`` if the user can remove a document reference from the RFI.``false`` if the user cannot remove a document reference from the RFI.</summary>
        public bool? RemoveDocumentReference { get; set; }
        /// <summary>BIM360:``true`` if the user can hide the pushpin RFI.``false`` if the user cannot hide the pushpin RFI.ACC: Not relevant.</summary>
        public bool? TogglePushpinVisibility { get; set; }
        /// <summary>The list of attributes and statuses available  for the user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Autodesk.ACC.RFIs.Models.Rfi_permittedActions_updateRfi? UpdateRfi { get; set; }
#nullable restore
#else
        public global::Autodesk.ACC.RFIs.Models.Rfi_permittedActions_updateRfi UpdateRfi { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Autodesk.ACC.RFIs.Models.Rfi_permittedActions"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Autodesk.ACC.RFIs.Models.Rfi_permittedActions CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Autodesk.ACC.RFIs.Models.Rfi_permittedActions();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "createAttachment", n => { CreateAttachment = n.GetBoolValue(); } },
                { "createComment", n => { CreateComment = n.GetBoolValue(); } },
                { "createDocumentReference", n => { CreateDocumentReference = n.GetBoolValue(); } },
                { "linkPCO", n => { LinkPCO = n.GetBoolValue(); } },
                { "removeDocumentReference", n => { RemoveDocumentReference = n.GetBoolValue(); } },
                { "togglePushpinVisibility", n => { TogglePushpinVisibility = n.GetBoolValue(); } },
                { "updateRfi", n => { UpdateRfi = n.GetObjectValue<global::Autodesk.ACC.RFIs.Models.Rfi_permittedActions_updateRfi>(global::Autodesk.ACC.RFIs.Models.Rfi_permittedActions_updateRfi.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("createAttachment", CreateAttachment);
            writer.WriteBoolValue("createComment", CreateComment);
            writer.WriteBoolValue("createDocumentReference", CreateDocumentReference);
            writer.WriteBoolValue("linkPCO", LinkPCO);
            writer.WriteBoolValue("removeDocumentReference", RemoveDocumentReference);
            writer.WriteBoolValue("togglePushpinVisibility", TogglePushpinVisibility);
            writer.WriteObjectValue<global::Autodesk.ACC.RFIs.Models.Rfi_permittedActions_updateRfi>("updateRfi", UpdateRfi);
        }
    }
}
#pragma warning restore CS0618
