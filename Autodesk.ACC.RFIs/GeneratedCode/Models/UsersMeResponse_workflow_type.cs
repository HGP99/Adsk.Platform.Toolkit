// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Autodesk.ACC.RFIs.Models
{
    /// <summary>The type of RFI workflow for the project. Possible values: ``US``, ``EU``.``US`` corresponds to the RFI workflow with one reviewer.``EU`` corresponds to the RFI workflow with two reviewers.Note that currently you cannot use the RFIs API to select an RFI workflow. For information about selecting an RFI workflow for a project, see the `RFIs help documentation` `BIM360&lt;https://help.autodesk.com/view/BIM360D/ENU/?guid=GUID-787338BF-1189-4170-8629-7FA240F4BED4&gt;`_ `ACC&lt;https://help.autodesk.com/view/BUILD/ENU/?guid=RFI_Workflow_Setup&gt;`_.</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public enum UsersMeResponse_workflow_type
    {
        [EnumMember(Value = "US")]
        #pragma warning disable CS1591
        US,
        #pragma warning restore CS1591
        [EnumMember(Value = "EU")]
        #pragma warning disable CS1591
        EU,
        #pragma warning restore CS1591
    }
}
