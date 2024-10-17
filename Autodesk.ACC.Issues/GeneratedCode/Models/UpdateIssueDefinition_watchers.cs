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
    /// The Autodesk ID of the member you want to assign as a watcher for the issue.We do not currently provide endpoints to programmatically find the member IDs that you are permitted to assign as watchers for the issue. We recommend using the Data Connector API to extract the permitted IDs. See the `Retrieve Available Members &lt;/en/docs/acc/v1/tutorials/issues/retrieve-available-members-roles-companies&gt;`_ tutorial for more details.Note that if a user with Manage Issues permissions attempts to assign an issue watcher to an invalid Autodesk ID the call will still complete successfully.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class UpdateIssueDefinition_watchers : IParsable
    {
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Autodesk.ACC.Issues.Models.UpdateIssueDefinition_watchers"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Autodesk.ACC.Issues.Models.UpdateIssueDefinition_watchers CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Autodesk.ACC.Issues.Models.UpdateIssueDefinition_watchers();
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
