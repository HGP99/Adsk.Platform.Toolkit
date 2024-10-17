// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System;
namespace Autodesk.ACC.Issues.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class IssueDefinition : IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The unique Autodesk ID of the member, company, or role of the current assignee for this issue. Note that if you select an assignee ID, you also need to select a type (``assignedToType``).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AssignedTo { get; set; }
#nullable restore
#else
        public string AssignedTo { get; set; }
#endif
        /// <summary>The type of the current assignee of this issue. Possible values: ``user``, ``company``, ``role``, ``null``. Note that if you select a type, you also need to select the assignee ID (``assignedTo``).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AssignedToType { get; set; }
#nullable restore
#else
        public string AssignedToType { get; set; }
#endif
        /// <summary>The attachmentCount property</summary>
        public int? AttachmentCount { get; private set; }
        /// <summary>The date and time the issue was closed, in ISO8601 format.</summary>
        public DateTimeOffset? ClosedAt { get; private set; }
        /// <summary>The unique identifier of the user who closed the issue.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ClosedBy { get; private set; }
#nullable restore
#else
        public string ClosedBy { get; private set; }
#endif
        /// <summary>The number of comments in this issue.</summary>
        public int? CommentCount { get; private set; }
        /// <summary>The containerId property</summary>
        public Guid? ContainerId { get; private set; }
        /// <summary>The date and time the issue was created, in ISO8601 format.</summary>
        public DateTimeOffset? CreatedAt { get; private set; }
        /// <summary>The unique identifier of the user who created the issue.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CreatedBy { get; private set; }
#nullable restore
#else
        public string CreatedBy { get; private set; }
#endif
        /// <summary>A list of custom attributes of the specific issue.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Autodesk.ACC.Issues.Models.CustomAttributeDefinition>? CustomAttributes { get; set; }
#nullable restore
#else
        public List<global::Autodesk.ACC.Issues.Models.CustomAttributeDefinition> CustomAttributes { get; set; }
#endif
        /// <summary>States whether the issue was deleted. Default value: ``false``.</summary>
        public bool? Deleted { get; set; }
        /// <summary>The description and purpose of the issue.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>The chronological user-friendly identifier of the issue.</summary>
        public int? DisplayId { get; private set; }
        /// <summary>The due date of the issue, in ISO8601 format.</summary>
        public Date? DueDate { get; set; }
        /// <summary>A GPS Coordinate which represents the geo location of the issue.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Autodesk.ACC.Issues.Models.IssueDefinition_gpsCoordinates? GpsCoordinates { get; set; }
#nullable restore
#else
        public global::Autodesk.ACC.Issues.Models.IssueDefinition_gpsCoordinates GpsCoordinates { get; set; }
#endif
        /// <summary>The unique identifier of the issue.</summary>
        public Guid? Id { get; set; }
        /// <summary>The unique identifier of the subtype of the issue.</summary>
        public Guid? IssueSubtypeId { get; set; }
        /// <summary>The issueTemplateId property</summary>
        public Guid? IssueTemplateId { get; set; }
        /// <summary>The unique identifier of the type of the issue.</summary>
        public Guid? IssueTypeId { get; private set; }
        /// <summary>Information about the files associated with issues (pushpins).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Autodesk.ACC.Issues.Models.IssueDefinition_linkedDocuments>? LinkedDocuments { get; set; }
#nullable restore
#else
        public List<global::Autodesk.ACC.Issues.Models.IssueDefinition_linkedDocuments> LinkedDocuments { get; set; }
#endif
        /// <summary>The links property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Autodesk.ACC.Issues.Models.IssueDefinition_links>? Links { get; set; }
#nullable restore
#else
        public List<global::Autodesk.ACC.Issues.Models.IssueDefinition_links> Links { get; set; }
#endif
        /// <summary>The location as plain text that relates to the issue.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LocationDetails { get; set; }
#nullable restore
#else
        public string LocationDetails { get; set; }
#endif
        /// <summary>The unique LBS (Location Breakdown Structure) identifier that relates to the issue.</summary>
        public Guid? LocationId { get; set; }
        /// <summary>The officialResponse property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Autodesk.ACC.Issues.Models.IssueDefinition_officialResponse? OfficialResponse { get; set; }
#nullable restore
#else
        public global::Autodesk.ACC.Issues.Models.IssueDefinition_officialResponse OfficialResponse { get; set; }
#endif
        /// <summary>The date and time the issue was opened, in ISO8601 format.</summary>
        public DateTimeOffset? OpenedAt { get; private set; }
        /// <summary>The unique identifier of the user who opened the issue.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OpenedBy { get; private set; }
#nullable restore
#else
        public string OpenedBy { get; private set; }
#endif
        /// <summary>The ownerId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OwnerId { get; set; }
#nullable restore
#else
        public string OwnerId { get; set; }
#endif
        /// <summary>The list of actions permitted for the user for this issue in its current state.Note that if a user with *Create for my company* permissions attempts to assign a user from a another company to the issue, it will return an error.Possible Values: ``assign_all`` (can assign another user from another company to the issue), ``assign_same_company`` (can only assign another user from the same company to the issue), ``clear_assignee``, ``delete``, ``add_comment``, ``add_attachment``, ``remove_attachment``.The following values are not relevant: ``add_attachment``, ``remove_attachment``.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Autodesk.ACC.Issues.Models.IssueDefinition_permittedActions? PermittedActions { get; set; }
#nullable restore
#else
        public global::Autodesk.ACC.Issues.Models.IssueDefinition_permittedActions PermittedActions { get; set; }
#endif
        /// <summary>A list of attributes the current user can manipulate in the current context. ``issueTypeId``, ``linkedDocument``, ``links``, ``ownerId``, ``officialResponse``, ``rootCauseId``, ``snapshotUrn`` are not applicable.Possible Values: ``title``, ``description``, ``issueTypeId``, ``issueSubtypeId``, ``status``, ``assignedTo``, ``assignedToType``, ``dueDate``, ``locationId``, ``locationDetails``, ``linkedDocuments``, ``links``, ``ownerId``, ``rootCauseId``, ``officialResponse``, ``customAttributes``, ``snapshotUrn``, ``startDate``, ``published``, ``deleted``, ``watchers``.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Autodesk.ACC.Issues.Models.IssueDefinition_permittedAttributes?>? PermittedAttributes { get; private set; }
#nullable restore
#else
        public List<global::Autodesk.ACC.Issues.Models.IssueDefinition_permittedAttributes?> PermittedAttributes { get; private set; }
#endif
        /// <summary>A list of statuses accessible to the current user, this is based on the current status of the issue and the user permissions.Possible Values: ``open``, ``pending``, ``in_review``, ``closed``.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Autodesk.ACC.Issues.Models.IssueDefinition_permittedStatuses?>? PermittedStatuses { get; private set; }
#nullable restore
#else
        public List<global::Autodesk.ACC.Issues.Models.IssueDefinition_permittedStatuses?> PermittedStatuses { get; private set; }
#endif
        /// <summary>States whether the issue is published. Default value: ``false`` (e.g. unpublished).</summary>
        public bool? Published { get; set; }
        /// <summary>The unique identifier of the type of root cause for the issue.</summary>
        public Guid? RootCauseId { get; set; }
        /// <summary>To download a snapshot, see the following `OSS Signed URL Download &lt;/en/docs/data/v2/reference/http/buckets-:bucketKey-objects-:objectName-signeds3download-GET/&gt;`_ reference.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SnapshotUrn { get; set; }
#nullable restore
#else
        public string SnapshotUrn { get; set; }
#endif
        /// <summary>The start date of the issue, in ISO8601 format.</summary>
        public Date? StartDate { get; set; }
        /// <summary>The current status of the issue.Possible values: ``draft``, ``open``, ``pending``, ``in_progress``, ``completed``, ``in_review``,  ``not_approved``, ``in_dispute``,  ``closed``.</summary>
        public global::Autodesk.ACC.Issues.Models.IssueDefinition_status? Status { get; set; }
        /// <summary>The title of the issue.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Title { get; set; }
#nullable restore
#else
        public string Title { get; set; }
#endif
        /// <summary>The date and time the issue was updated, in ISO8601 format.</summary>
        public DateTimeOffset? UpdatedAt { get; private set; }
        /// <summary>The unique identifier of the user who updated the issue.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UpdatedBy { get; private set; }
#nullable restore
#else
        public string UpdatedBy { get; private set; }
#endif
        /// <summary>The list of watchers for the issue. To find the name of the watcher, call `GET users &lt;/en/docs/acc/v1/reference/http/users-GET&gt;`_.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Watchers { get; set; }
#nullable restore
#else
        public List<string> Watchers { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Autodesk.ACC.Issues.Models.IssueDefinition"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Autodesk.ACC.Issues.Models.IssueDefinition CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Autodesk.ACC.Issues.Models.IssueDefinition();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "assignedTo", n => { AssignedTo = n.GetStringValue(); } },
                { "assignedToType", n => { AssignedToType = n.GetStringValue(); } },
                { "attachmentCount", n => { AttachmentCount = n.GetIntValue(); } },
                { "closedAt", n => { ClosedAt = n.GetDateTimeOffsetValue(); } },
                { "closedBy", n => { ClosedBy = n.GetStringValue(); } },
                { "commentCount", n => { CommentCount = n.GetIntValue(); } },
                { "containerId", n => { ContainerId = n.GetGuidValue(); } },
                { "createdAt", n => { CreatedAt = n.GetDateTimeOffsetValue(); } },
                { "createdBy", n => { CreatedBy = n.GetStringValue(); } },
                { "customAttributes", n => { CustomAttributes = n.GetCollectionOfObjectValues<global::Autodesk.ACC.Issues.Models.CustomAttributeDefinition>(global::Autodesk.ACC.Issues.Models.CustomAttributeDefinition.CreateFromDiscriminatorValue)?.AsList(); } },
                { "deleted", n => { Deleted = n.GetBoolValue(); } },
                { "description", n => { Description = n.GetStringValue(); } },
                { "displayId", n => { DisplayId = n.GetIntValue(); } },
                { "dueDate", n => { DueDate = n.GetDateValue(); } },
                { "gpsCoordinates", n => { GpsCoordinates = n.GetObjectValue<global::Autodesk.ACC.Issues.Models.IssueDefinition_gpsCoordinates>(global::Autodesk.ACC.Issues.Models.IssueDefinition_gpsCoordinates.CreateFromDiscriminatorValue); } },
                { "id", n => { Id = n.GetGuidValue(); } },
                { "issueSubtypeId", n => { IssueSubtypeId = n.GetGuidValue(); } },
                { "issueTemplateId", n => { IssueTemplateId = n.GetGuidValue(); } },
                { "issueTypeId", n => { IssueTypeId = n.GetGuidValue(); } },
                { "linkedDocuments", n => { LinkedDocuments = n.GetCollectionOfObjectValues<global::Autodesk.ACC.Issues.Models.IssueDefinition_linkedDocuments>(global::Autodesk.ACC.Issues.Models.IssueDefinition_linkedDocuments.CreateFromDiscriminatorValue)?.AsList(); } },
                { "links", n => { Links = n.GetCollectionOfObjectValues<global::Autodesk.ACC.Issues.Models.IssueDefinition_links>(global::Autodesk.ACC.Issues.Models.IssueDefinition_links.CreateFromDiscriminatorValue)?.AsList(); } },
                { "locationDetails", n => { LocationDetails = n.GetStringValue(); } },
                { "locationId", n => { LocationId = n.GetGuidValue(); } },
                { "officialResponse", n => { OfficialResponse = n.GetObjectValue<global::Autodesk.ACC.Issues.Models.IssueDefinition_officialResponse>(global::Autodesk.ACC.Issues.Models.IssueDefinition_officialResponse.CreateFromDiscriminatorValue); } },
                { "openedAt", n => { OpenedAt = n.GetDateTimeOffsetValue(); } },
                { "openedBy", n => { OpenedBy = n.GetStringValue(); } },
                { "ownerId", n => { OwnerId = n.GetStringValue(); } },
                { "permittedActions", n => { PermittedActions = n.GetObjectValue<global::Autodesk.ACC.Issues.Models.IssueDefinition_permittedActions>(global::Autodesk.ACC.Issues.Models.IssueDefinition_permittedActions.CreateFromDiscriminatorValue); } },
                { "permittedAttributes", n => { PermittedAttributes = n.GetCollectionOfEnumValues<global::Autodesk.ACC.Issues.Models.IssueDefinition_permittedAttributes>()?.AsList(); } },
                { "permittedStatuses", n => { PermittedStatuses = n.GetCollectionOfEnumValues<global::Autodesk.ACC.Issues.Models.IssueDefinition_permittedStatuses>()?.AsList(); } },
                { "published", n => { Published = n.GetBoolValue(); } },
                { "rootCauseId", n => { RootCauseId = n.GetGuidValue(); } },
                { "snapshotUrn", n => { SnapshotUrn = n.GetStringValue(); } },
                { "startDate", n => { StartDate = n.GetDateValue(); } },
                { "status", n => { Status = n.GetEnumValue<global::Autodesk.ACC.Issues.Models.IssueDefinition_status>(); } },
                { "title", n => { Title = n.GetStringValue(); } },
                { "updatedAt", n => { UpdatedAt = n.GetDateTimeOffsetValue(); } },
                { "updatedBy", n => { UpdatedBy = n.GetStringValue(); } },
                { "watchers", n => { Watchers = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("assignedTo", AssignedTo);
            writer.WriteStringValue("assignedToType", AssignedToType);
            writer.WriteCollectionOfObjectValues<global::Autodesk.ACC.Issues.Models.CustomAttributeDefinition>("customAttributes", CustomAttributes);
            writer.WriteBoolValue("deleted", Deleted);
            writer.WriteStringValue("description", Description);
            writer.WriteDateValue("dueDate", DueDate);
            writer.WriteObjectValue<global::Autodesk.ACC.Issues.Models.IssueDefinition_gpsCoordinates>("gpsCoordinates", GpsCoordinates);
            writer.WriteGuidValue("id", Id);
            writer.WriteGuidValue("issueSubtypeId", IssueSubtypeId);
            writer.WriteGuidValue("issueTemplateId", IssueTemplateId);
            writer.WriteCollectionOfObjectValues<global::Autodesk.ACC.Issues.Models.IssueDefinition_linkedDocuments>("linkedDocuments", LinkedDocuments);
            writer.WriteCollectionOfObjectValues<global::Autodesk.ACC.Issues.Models.IssueDefinition_links>("links", Links);
            writer.WriteStringValue("locationDetails", LocationDetails);
            writer.WriteGuidValue("locationId", LocationId);
            writer.WriteObjectValue<global::Autodesk.ACC.Issues.Models.IssueDefinition_officialResponse>("officialResponse", OfficialResponse);
            writer.WriteStringValue("ownerId", OwnerId);
            writer.WriteObjectValue<global::Autodesk.ACC.Issues.Models.IssueDefinition_permittedActions>("permittedActions", PermittedActions);
            writer.WriteBoolValue("published", Published);
            writer.WriteGuidValue("rootCauseId", RootCauseId);
            writer.WriteStringValue("snapshotUrn", SnapshotUrn);
            writer.WriteDateValue("startDate", StartDate);
            writer.WriteEnumValue<global::Autodesk.ACC.Issues.Models.IssueDefinition_status>("status", Status);
            writer.WriteStringValue("title", Title);
            writer.WriteCollectionOfPrimitiveValues<string>("watchers", Watchers);
        }
    }
}
#pragma warning restore CS0618
