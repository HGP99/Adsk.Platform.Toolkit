// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Autodesk.ACC.AccountAdmin.Accounts.Item.Users
{
    [Obsolete("This class is obsolete. Use UsersGetResponse instead.")]
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.16.0")]
    #pragma warning disable CS1591
    public partial class UsersResponse : global::Autodesk.ACC.AccountAdmin.Accounts.Item.Users.UsersGetResponse, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Autodesk.ACC.AccountAdmin.Accounts.Item.Users.UsersResponse"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Autodesk.ACC.AccountAdmin.Accounts.Item.Users.UsersResponse CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Autodesk.ACC.AccountAdmin.Accounts.Item.Users.UsersResponse();
        }
    }
}
