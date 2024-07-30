// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Autodesk.ACC.AccountAdmin.Models
{
    /// <summary>
    /// Account user writable fields.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.16.0")]
    public partial class AccountUserWritableFields : IParsable
    {
        /// <summary>The accessLevels property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Autodesk.ACC.AccountAdmin.Models.AccountUserAccessLevels? AccessLevels { get; set; }
#nullable restore
#else
        public global::Autodesk.ACC.AccountAdmin.Models.AccountUserAccessLevels AccessLevels { get; set; }
#endif
        /// <summary>When adding the user to a project this is the id of the company they will be representing by default in that project.  The company can still be changed on a project by project basis</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UntypedNode? DefaultCompanyId { get; set; }
#nullable restore
#else
        public UntypedNode DefaultCompanyId { get; set; }
#endif
        /// <summary>When adding the user to a project this is the id of the role within the project they will be in by default.  The role can still be changed on a project by project basis</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UntypedNode? DefaultRoleId { get; set; }
#nullable restore
#else
        public UntypedNode DefaultRoleId { get; set; }
#endif
        /// <summary>The email of the user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Email { get; set; }
#nullable restore
#else
        public string Email { get; set; }
#endif
        /// <summary>The user&apos;s first name.  This data will sync from the user&apos;s Autodesk profile.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FirstName { get; set; }
#nullable restore
#else
        public string FirstName { get; set; }
#endif
        /// <summary>The user&apos;s last name.  This data will sync from the user&apos;s Autodesk profile.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LastName { get; set; }
#nullable restore
#else
        public string LastName { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Autodesk.ACC.AccountAdmin.Models.AccountUserWritableFields"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Autodesk.ACC.AccountAdmin.Models.AccountUserWritableFields CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Autodesk.ACC.AccountAdmin.Models.AccountUserWritableFields();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "accessLevels", n => { AccessLevels = n.GetObjectValue<global::Autodesk.ACC.AccountAdmin.Models.AccountUserAccessLevels>(global::Autodesk.ACC.AccountAdmin.Models.AccountUserAccessLevels.CreateFromDiscriminatorValue); } },
                { "defaultCompanyId", n => { DefaultCompanyId = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
                { "defaultRoleId", n => { DefaultRoleId = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
                { "email", n => { Email = n.GetStringValue(); } },
                { "firstName", n => { FirstName = n.GetStringValue(); } },
                { "lastName", n => { LastName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::Autodesk.ACC.AccountAdmin.Models.AccountUserAccessLevels>("accessLevels", AccessLevels);
            writer.WriteObjectValue<UntypedNode>("defaultCompanyId", DefaultCompanyId);
            writer.WriteObjectValue<UntypedNode>("defaultRoleId", DefaultRoleId);
            writer.WriteStringValue("email", Email);
            writer.WriteStringValue("firstName", FirstName);
            writer.WriteStringValue("lastName", LastName);
        }
    }
}
