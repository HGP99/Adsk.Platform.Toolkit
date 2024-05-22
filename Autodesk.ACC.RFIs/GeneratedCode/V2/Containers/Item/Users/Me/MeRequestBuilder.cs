// <auto-generated/>
using Autodesk.ACC.RFIs.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Autodesk.ACC.RFIs.V2.Containers.Item.Users.Me {
    /// <summary>
    /// Builds and executes requests for operations under \v2\containers\{containerId}\users\me
    /// </summary>
    public class MeRequestBuilder : BaseRequestBuilder 
    {
        /// <summary>
        /// Instantiates a new <see cref="MeRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public MeRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/v2/containers/{containerId}/users/me", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="MeRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public MeRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/v2/containers/{containerId}/users/me", rawUrl)
        {
        }
        /// <summary>
        /// Retrieves information about an end user, including the type of workflow roles assigned to the user, whether the user is permitted to create RFIs, which states the user can create the RFIs in, and the attributes that are required when creating the RFIs in the different states.**We strongly recommend calling this endpoint before creating RFIs, in order to verify the most up-to-date permissions and actions.**Users who have been assigned either creator (``projectSC``) or manager (``projectGC``) workflow roles can create RFIs. All users in the project are automatically assigned the creator workflow role. To assign creator or manager workflow roles to project members, open the Project Admin module, select the Services tab, and select the Project Management section.Note that only users who are members of a project can potentially create and edit RFIs for the project. To check which users are members of a project, call `GET projects/users` `BIM 360&lt;/en/docs/bim360/v1/reference/http/admin-v1-projects-projectId-users-GET&gt;`_ `ACC&lt;/en/docs/acc/v1/reference/http/admin-v1-projects-projectId-users-GET&gt;`_. If a user is not a project member, the endpoint will return an error.If the ``createRfi`` object appears in the response in the ``permittedActions`` object, it indicates that the user can create RFIs.Currently, you can only assign workflow roles (creator, manager, reviewer) in the UI. To assign workflow roles, open the Project Admin module, select the Services tab, and select the Project Management section.The following table describes the Project Admin module workflow role names and the corresponding RFIs API names:=======================================================  ==========================Project Admin Module Workflow Role Name                  RFIs API Workflow Role Name=======================================================  ==========================Creator                                                  Subcontractor (projectSC)Manager                                                  General Contractor (projectGC)Reviewer 1 (EMEA workflow)                               Construction Manager (projectCM)Reviewer (US workflow) / Reviewer 2 (EMEA workflow)      Architect (projectArch)=======================================================  ==========================For information about RFI workflow role permissions, see the `RFIs help documentation` `BIM360&lt;https://help.autodesk.com/view/BIM360D/ENU/?guid=GUID-E0BD1D73-B070-4DB0-9294-BF9CD0A7B6F3&gt;`_ `ACC&lt;https://help.autodesk.com/view/BUILD/ENU/?guid=RFI_Permissions&gt;`_.Currently, you can only select an RFI workflow type for an RFI in the UI. To assign an RFI workflow to an RFI, see the `RFIs help documentation` `BIM360&lt;https://help.autodesk.com/view/BIM360D/ENU/?guid=GUID-787338BF-1189-4170-8629-7FA240F4BED4&gt;`_ `ACC&lt;https://help.autodesk.com/view/BUILD/ENU/?guid=RFI_Workflow_Setup&gt;`_The following table describes the Project Admin module names and the corresponding RFIs API names:=======================================  ===========================Project Admin Module Workflow Type Name  RFIs API Workflow Type Name=======================================  ===========================Default Workflow                         USWorkflow with Additional Reviewer        EMEA=======================================  ===========================Note that you can use either type of workflow in the US and in EMEA... include:: ../../../../_snippets/forward-compatible.rst
        /// </summary>
        /// <returns>A <see cref="UsersMeResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="ErrorResponse">When receiving a 400 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<UsersMeResponse?> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<UsersMeResponse> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                {"400", ErrorResponse.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<UsersMeResponse>(requestInfo, UsersMeResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Retrieves information about an end user, including the type of workflow roles assigned to the user, whether the user is permitted to create RFIs, which states the user can create the RFIs in, and the attributes that are required when creating the RFIs in the different states.**We strongly recommend calling this endpoint before creating RFIs, in order to verify the most up-to-date permissions and actions.**Users who have been assigned either creator (``projectSC``) or manager (``projectGC``) workflow roles can create RFIs. All users in the project are automatically assigned the creator workflow role. To assign creator or manager workflow roles to project members, open the Project Admin module, select the Services tab, and select the Project Management section.Note that only users who are members of a project can potentially create and edit RFIs for the project. To check which users are members of a project, call `GET projects/users` `BIM 360&lt;/en/docs/bim360/v1/reference/http/admin-v1-projects-projectId-users-GET&gt;`_ `ACC&lt;/en/docs/acc/v1/reference/http/admin-v1-projects-projectId-users-GET&gt;`_. If a user is not a project member, the endpoint will return an error.If the ``createRfi`` object appears in the response in the ``permittedActions`` object, it indicates that the user can create RFIs.Currently, you can only assign workflow roles (creator, manager, reviewer) in the UI. To assign workflow roles, open the Project Admin module, select the Services tab, and select the Project Management section.The following table describes the Project Admin module workflow role names and the corresponding RFIs API names:=======================================================  ==========================Project Admin Module Workflow Role Name                  RFIs API Workflow Role Name=======================================================  ==========================Creator                                                  Subcontractor (projectSC)Manager                                                  General Contractor (projectGC)Reviewer 1 (EMEA workflow)                               Construction Manager (projectCM)Reviewer (US workflow) / Reviewer 2 (EMEA workflow)      Architect (projectArch)=======================================================  ==========================For information about RFI workflow role permissions, see the `RFIs help documentation` `BIM360&lt;https://help.autodesk.com/view/BIM360D/ENU/?guid=GUID-E0BD1D73-B070-4DB0-9294-BF9CD0A7B6F3&gt;`_ `ACC&lt;https://help.autodesk.com/view/BUILD/ENU/?guid=RFI_Permissions&gt;`_.Currently, you can only select an RFI workflow type for an RFI in the UI. To assign an RFI workflow to an RFI, see the `RFIs help documentation` `BIM360&lt;https://help.autodesk.com/view/BIM360D/ENU/?guid=GUID-787338BF-1189-4170-8629-7FA240F4BED4&gt;`_ `ACC&lt;https://help.autodesk.com/view/BUILD/ENU/?guid=RFI_Workflow_Setup&gt;`_The following table describes the Project Admin module names and the corresponding RFIs API names:=======================================  ===========================Project Admin Module Workflow Type Name  RFIs API Workflow Type Name=======================================  ===========================Default Workflow                         USWorkflow with Additional Reviewer        EMEA=======================================  ===========================Note that you can use either type of workflow in the US and in EMEA... include:: ../../../../_snippets/forward-compatible.rst
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="MeRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public MeRequestBuilder WithUrl(string rawUrl)
        {
            return new MeRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class MeRequestBuilderGetRequestConfiguration : RequestConfiguration<DefaultQueryParameters> 
        {
        }
    }
}
