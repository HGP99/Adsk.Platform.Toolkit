// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Autodesk.ACC.AccountAdmin.Models
{
    /// <summary>
    /// Address information.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.16.0")]
    public partial class Address : IParsable
    {
        /// <summary>The street address line 1.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AddressLine1 { get; set; }
#nullable restore
#else
        public string AddressLine1 { get; set; }
#endif
        /// <summary>The street address line 2.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AddressLine2 { get; set; }
#nullable restore
#else
        public string AddressLine2 { get; set; }
#endif
        /// <summary>City.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? City { get; set; }
#nullable restore
#else
        public string City { get; set; }
#endif
        /// <summary>Only valid country names and ISO 3166-1 alpha-2 codes will be accepted.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Country { get; set; }
#nullable restore
#else
        public string Country { get; set; }
#endif
        /// <summary>Phone Number.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Phone { get; set; }
#nullable restore
#else
        public string Phone { get; set; }
#endif
        /// <summary>The zip or postal code in which this address is located.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PostalCode { get; set; }
#nullable restore
#else
        public string PostalCode { get; set; }
#endif
        /// <summary>The state or province location. Only valid state/province names and ISO 3166-1 alpha-2 codes will be accepted. The provided state or province must exist in the provided country.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UntypedNode? StateOrProvince { get; set; }
#nullable restore
#else
        public UntypedNode StateOrProvince { get; set; }
#endif
        /// <summary>The address type.</summary>
        public global::Autodesk.ACC.AccountAdmin.Models.Address_type? Type { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Autodesk.ACC.AccountAdmin.Models.Address"/> and sets the default values.
        /// </summary>
        public Address()
        {
            Country = "US";
            Type = global::Autodesk.ACC.AccountAdmin.Models.Address_type.Main;
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Autodesk.ACC.AccountAdmin.Models.Address"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Autodesk.ACC.AccountAdmin.Models.Address CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Autodesk.ACC.AccountAdmin.Models.Address();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "addressLine1", n => { AddressLine1 = n.GetStringValue(); } },
                { "addressLine2", n => { AddressLine2 = n.GetStringValue(); } },
                { "city", n => { City = n.GetStringValue(); } },
                { "country", n => { Country = n.GetStringValue(); } },
                { "phone", n => { Phone = n.GetStringValue(); } },
                { "postalCode", n => { PostalCode = n.GetStringValue(); } },
                { "stateOrProvince", n => { StateOrProvince = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
                { "type", n => { Type = n.GetEnumValue<global::Autodesk.ACC.AccountAdmin.Models.Address_type>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("addressLine1", AddressLine1);
            writer.WriteStringValue("addressLine2", AddressLine2);
            writer.WriteStringValue("city", City);
            writer.WriteStringValue("country", Country);
            writer.WriteStringValue("phone", Phone);
            writer.WriteStringValue("postalCode", PostalCode);
            writer.WriteObjectValue<UntypedNode>("stateOrProvince", StateOrProvince);
            writer.WriteEnumValue<global::Autodesk.ACC.AccountAdmin.Models.Address_type>("type", Type);
        }
    }
}
