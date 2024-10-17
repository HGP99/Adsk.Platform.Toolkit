// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Autodesk.ACC.Issues.Models
{
    /// <summary>
    /// The viewer state at the time the pushpin was created. Maximum length: 2,500,000 characters. You can get the viewer state object by calling ViewerState.getState(). To restore the viewer instance use ViewerState.restoreState(). See the `Viewer API documentation https://developer.autodesk.com/en/docs/viewer/v2/reference/javascript/viewerstate/`_ for more details.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class IssueDefinition_linkedDocuments_details_viewerState : IParsable
    {
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Autodesk.ACC.Issues.Models.IssueDefinition_linkedDocuments_details_viewerState"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Autodesk.ACC.Issues.Models.IssueDefinition_linkedDocuments_details_viewerState CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Autodesk.ACC.Issues.Models.IssueDefinition_linkedDocuments_details_viewerState();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
        }
    }
}
#pragma warning restore CS0618
