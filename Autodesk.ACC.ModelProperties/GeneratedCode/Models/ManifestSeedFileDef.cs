// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Autodesk.ACC.ModelProperties.Models
{
    /// <summary>
    /// manifest seed file definition
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class ManifestSeedFileDef : IParsable
    {
        /// <summary>databases</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Autodesk.ACC.ModelProperties.Models.ManifestDatabaseFilesMappingDef>? Databases { get; set; }
#nullable restore
#else
        public List<global::Autodesk.ACC.ModelProperties.Models.ManifestDatabaseFilesMappingDef> Databases { get; set; }
#endif
        /// <summary>lineage ID</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LineageId { get; set; }
#nullable restore
#else
        public string LineageId { get; set; }
#endif
        /// <summary>lineage URN</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LineageUrn { get; set; }
#nullable restore
#else
        public string LineageUrn { get; set; }
#endif
        /// <summary>file version URN</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? VersionUrn { get; set; }
#nullable restore
#else
        public string VersionUrn { get; set; }
#endif
        /// <summary>views</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Autodesk.ACC.ModelProperties.Models.ManifestViewDef>? Views { get; set; }
#nullable restore
#else
        public List<global::Autodesk.ACC.ModelProperties.Models.ManifestViewDef> Views { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Autodesk.ACC.ModelProperties.Models.ManifestSeedFileDef"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Autodesk.ACC.ModelProperties.Models.ManifestSeedFileDef CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Autodesk.ACC.ModelProperties.Models.ManifestSeedFileDef();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "databases", n => { Databases = n.GetCollectionOfObjectValues<global::Autodesk.ACC.ModelProperties.Models.ManifestDatabaseFilesMappingDef>(global::Autodesk.ACC.ModelProperties.Models.ManifestDatabaseFilesMappingDef.CreateFromDiscriminatorValue)?.AsList(); } },
                { "lineageId", n => { LineageId = n.GetStringValue(); } },
                { "lineageUrn", n => { LineageUrn = n.GetStringValue(); } },
                { "versionUrn", n => { VersionUrn = n.GetStringValue(); } },
                { "views", n => { Views = n.GetCollectionOfObjectValues<global::Autodesk.ACC.ModelProperties.Models.ManifestViewDef>(global::Autodesk.ACC.ModelProperties.Models.ManifestViewDef.CreateFromDiscriminatorValue)?.AsList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<global::Autodesk.ACC.ModelProperties.Models.ManifestDatabaseFilesMappingDef>("databases", Databases);
            writer.WriteStringValue("lineageId", LineageId);
            writer.WriteStringValue("lineageUrn", LineageUrn);
            writer.WriteStringValue("versionUrn", VersionUrn);
            writer.WriteCollectionOfObjectValues<global::Autodesk.ACC.ModelProperties.Models.ManifestViewDef>("views", Views);
        }
    }
}
#pragma warning restore CS0618
