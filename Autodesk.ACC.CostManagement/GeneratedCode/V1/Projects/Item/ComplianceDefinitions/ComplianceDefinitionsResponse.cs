// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Autodesk.ACC.CostManagement.V1.Projects.Item.ComplianceDefinitions
{
    [Obsolete("This class is obsolete. Use ComplianceDefinitionsGetResponse instead.")]
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.16.0")]
    #pragma warning disable CS1591
    public partial class ComplianceDefinitionsResponse : global::Autodesk.ACC.CostManagement.V1.Projects.Item.ComplianceDefinitions.ComplianceDefinitionsGetResponse, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Autodesk.ACC.CostManagement.V1.Projects.Item.ComplianceDefinitions.ComplianceDefinitionsResponse"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Autodesk.ACC.CostManagement.V1.Projects.Item.ComplianceDefinitions.ComplianceDefinitionsResponse CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Autodesk.ACC.CostManagement.V1.Projects.Item.ComplianceDefinitions.ComplianceDefinitionsResponse();
        }
    }
}
