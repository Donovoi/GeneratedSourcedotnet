// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

#pragma warning disable CS1591,CS1573,CS0465,CS0649,CS8019,CS1570,CS1584,CS1658,CS0436,CS8981
using global::System;
using global::System.Diagnostics;
using global::System.Diagnostics.CodeAnalysis;
using global::System.Runtime.CompilerServices;
using global::System.Runtime.InteropServices;
using global::System.Runtime.Versioning;
using winmdroot = global::Windows.Win32;
namespace Windows.Win32
{
	namespace System.SystemInformation
	{
		/// <summary>Represents information about processor groups. This structure is used with the GetLogicalProcessorInformationEx function.</summary>
		/// <remarks>
		/// <para><see href="https://docs.microsoft.com/windows/win32/api//winnt/ns-winnt-group_relationship">Learn more about this API from docs.microsoft.com</see>.</para>
		/// </remarks>
		[global::System.CodeDom.Compiler.GeneratedCode("Microsoft.Windows.CsWin32", "0.2.104-beta+6d86f35b75")]
		internal partial struct GROUP_RELATIONSHIP
		{
			/// <summary>The maximum number of processor groups on the system.</summary>
			internal ushort MaximumGroupCount;
			/// <summary>The number of active groups on the system. This member indicates the number of <a href="https://docs.microsoft.com/windows/desktop/api/winnt/ns-winnt-processor_group_info">PROCESSOR_GROUP_INFO</a> structures in the <b>GroupInfo</b> array.</summary>
			internal ushort ActiveGroupCount;
			/// <summary>This member is reserved.</summary>
			internal winmdroot.__byte_20 Reserved;
			/// <summary>An array of <a href="https://docs.microsoft.com/windows/desktop/api/winnt/ns-winnt-processor_group_info">PROCESSOR_GROUP_INFO</a> structures. Each structure represents the number and affinity of processors in an active group on the system.</summary>
			internal winmdroot.System.SystemInformation.__PROCESSOR_GROUP_INFO_1 GroupInfo;
		}
	}
}
