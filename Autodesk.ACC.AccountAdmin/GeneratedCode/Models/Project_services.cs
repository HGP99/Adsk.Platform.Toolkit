// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Autodesk.ACC.AccountAdmin.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.16.0")]
    #pragma warning disable CS1591
    public partial class Project_services : IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The display name for the service.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; private set; }
#nullable restore
#else
        public string DisplayName { get; private set; }
#endif
        /// <summary>The language for the project.  Only valid on the `field` service.</summary>
        public global::Autodesk.ACC.AccountAdmin.Models.Project_services_language? Language { get; set; }
        /// <summary>Indicates if a service can be deactivated.</summary>
        public bool? Removable { get; private set; }
        /// <summary>The url of the icon related to this service.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ServiceIcon { get; private set; }
#nullable restore
#else
        public string ServiceIcon { get; private set; }
#endif
        /// <summary>The name of the service. Valid values are `projectAdministration`, `documentManagement`, `quantification`, `projectManagement`, `costManagement`, `designCollaboration`, `fieldManagement`, `assets`, `workshopxr`, `insight`, `modelCoordination`, `field`, `glue` and `plan`.</summary>
        public global::Autodesk.ACC.AccountAdmin.Models.Project_services_serviceName? ServiceName { get; set; }
        /// <summary>The status of the service in the project.  Valid values are `active`, `activating`, `available`,`inactive`, `deactivating`, `activationFailed` and `deactivationFailed`.</summary>
        public global::Autodesk.ACC.AccountAdmin.Models.Project_services_status? Status { get; private set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Autodesk.ACC.AccountAdmin.Models.Project_services"/> and sets the default values.
        /// </summary>
        public Project_services()
        {
            Language = global::Autodesk.ACC.AccountAdmin.Models.Project_services_language.En;
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Autodesk.ACC.AccountAdmin.Models.Project_services"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Autodesk.ACC.AccountAdmin.Models.Project_services CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Autodesk.ACC.AccountAdmin.Models.Project_services();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "language", n => { Language = n.GetEnumValue<global::Autodesk.ACC.AccountAdmin.Models.Project_services_language>(); } },
                { "removable", n => { Removable = n.GetBoolValue(); } },
                { "serviceIcon", n => { ServiceIcon = n.GetStringValue(); } },
                { "serviceName", n => { ServiceName = n.GetEnumValue<global::Autodesk.ACC.AccountAdmin.Models.Project_services_serviceName>(); } },
                { "status", n => { Status = n.GetEnumValue<global::Autodesk.ACC.AccountAdmin.Models.Project_services_status>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<global::Autodesk.ACC.AccountAdmin.Models.Project_services_language>("language", Language);
            writer.WriteEnumValue<global::Autodesk.ACC.AccountAdmin.Models.Project_services_serviceName>("serviceName", ServiceName);
        }
    }
}
