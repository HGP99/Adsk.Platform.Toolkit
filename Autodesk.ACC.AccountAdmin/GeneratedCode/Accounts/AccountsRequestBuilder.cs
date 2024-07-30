// <auto-generated/>
using Autodesk.ACC.AccountAdmin.Accounts.Item;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace Autodesk.ACC.AccountAdmin.Accounts
{
    /// <summary>
    /// Builds and executes requests for operations under \accounts
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.16.0")]
    public partial class AccountsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the Autodesk.ACC.AccountAdmin.accounts.item collection</summary>
        /// <param name="position">The account id.</param>
        /// <returns>A <see cref="global::Autodesk.ACC.AccountAdmin.Accounts.Item.WithAccountItemRequestBuilder"/></returns>
        public global::Autodesk.ACC.AccountAdmin.Accounts.Item.WithAccountItemRequestBuilder this[Guid position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("accountId", position);
                return new global::Autodesk.ACC.AccountAdmin.Accounts.Item.WithAccountItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>Gets an item from the Autodesk.ACC.AccountAdmin.accounts.item collection</summary>
        /// <param name="position">The account id.</param>
        /// <returns>A <see cref="global::Autodesk.ACC.AccountAdmin.Accounts.Item.WithAccountItemRequestBuilder"/></returns>
        [Obsolete("This indexer is deprecated and will be removed in the next major version. Use the one with the typed parameter instead.")]
        public global::Autodesk.ACC.AccountAdmin.Accounts.Item.WithAccountItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                if (!string.IsNullOrWhiteSpace(position)) urlTplParams.Add("accountId", position);
                return new global::Autodesk.ACC.AccountAdmin.Accounts.Item.WithAccountItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Autodesk.ACC.AccountAdmin.Accounts.AccountsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AccountsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/accounts", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Autodesk.ACC.AccountAdmin.Accounts.AccountsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AccountsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/accounts", rawUrl)
        {
        }
    }
}
