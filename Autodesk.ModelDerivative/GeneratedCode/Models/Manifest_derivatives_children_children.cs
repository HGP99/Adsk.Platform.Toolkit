// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Autodesk.ModelDerivative.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class Manifest_derivatives_children_children : IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The camera property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Autodesk.ModelDerivative.Models.Manifest_derivatives_children_children_camera>? Camera { get; set; }
#nullable restore
#else
        public List<global::Autodesk.ModelDerivative.Models.Manifest_derivatives_children_children_camera> Camera { get; set; }
#endif
        /// <summary>The guid property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Guid { get; set; }
#nullable restore
#else
        public string Guid { get; set; }
#endif
        /// <summary>The name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The progress property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Progress { get; set; }
#nullable restore
#else
        public string Progress { get; set; }
#endif
        /// <summary>The role property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Role { get; set; }
#nullable restore
#else
        public string Role { get; set; }
#endif
        /// <summary>The status property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Status { get; set; }
#nullable restore
#else
        public string Status { get; set; }
#endif
        /// <summary>The type property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Type { get; set; }
#nullable restore
#else
        public string Type { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Autodesk.ModelDerivative.Models.Manifest_derivatives_children_children"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Autodesk.ModelDerivative.Models.Manifest_derivatives_children_children CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Autodesk.ModelDerivative.Models.Manifest_derivatives_children_children();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "camera", n => { Camera = n.GetCollectionOfObjectValues<global::Autodesk.ModelDerivative.Models.Manifest_derivatives_children_children_camera>(global::Autodesk.ModelDerivative.Models.Manifest_derivatives_children_children_camera.CreateFromDiscriminatorValue)?.AsList(); } },
                { "guid", n => { Guid = n.GetStringValue(); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "progress", n => { Progress = n.GetStringValue(); } },
                { "role", n => { Role = n.GetStringValue(); } },
                { "status", n => { Status = n.GetStringValue(); } },
                { "type", n => { Type = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<global::Autodesk.ModelDerivative.Models.Manifest_derivatives_children_children_camera>("camera", Camera);
            writer.WriteStringValue("guid", Guid);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("progress", Progress);
            writer.WriteStringValue("role", Role);
            writer.WriteStringValue("status", Status);
            writer.WriteStringValue("type", Type);
        }
    }
}
#pragma warning restore CS0618
