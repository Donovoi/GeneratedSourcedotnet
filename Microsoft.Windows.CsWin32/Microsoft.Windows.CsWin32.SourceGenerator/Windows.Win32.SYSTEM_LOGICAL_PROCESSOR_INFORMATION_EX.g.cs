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
		/// <summary>Contains information about the relationships of logical processors and related hardware. The GetLogicalProcessorInformationEx function uses this structure.</summary>
		/// <remarks>
		/// <para><see href="https://docs.microsoft.com/windows/win32/api//winnt/ns-winnt-system_logical_processor_information_ex">Learn more about this API from docs.microsoft.com</see>.</para>
		/// </remarks>
		[global::System.CodeDom.Compiler.GeneratedCode("Microsoft.Windows.CsWin32", "0.2.104-beta+6d86f35b75")]
		internal partial struct SYSTEM_LOGICAL_PROCESSOR_INFORMATION_EX
		{
			/// <summary>
			/// <para>The type of relationship between the logical processors. This parameter can be one of the following <a href="https://docs.microsoft.com/windows/desktop/api/winnt/ne-winnt-logical_processor_relationship">LOGICAL_PROCESSOR_RELATIONSHIP</a> values. </para>
			/// <para>This doc was truncated.</para>
			/// <para><see href="https://docs.microsoft.com/windows/win32/api//winnt/ns-winnt-system_logical_processor_information_ex#members">Read more on docs.microsoft.com</see>.</para>
			/// </summary>
			internal winmdroot.System.SystemInformation.LOGICAL_PROCESSOR_RELATIONSHIP Relationship;
			/// <summary>The size of the structure.</summary>
			internal uint Size;
			internal winmdroot.System.SystemInformation.SYSTEM_LOGICAL_PROCESSOR_INFORMATION_EX._Anonymous_e__Union Anonymous;

			[StructLayout(LayoutKind.Explicit)]
			[global::System.CodeDom.Compiler.GeneratedCode("Microsoft.Windows.CsWin32", "0.2.104-beta+6d86f35b75")]
			internal partial struct _Anonymous_e__Union
			{
				[FieldOffset(0)]
				internal winmdroot.System.SystemInformation.PROCESSOR_RELATIONSHIP Processor;
				[FieldOffset(0)]
				internal winmdroot.System.SystemInformation.NUMA_NODE_RELATIONSHIP NumaNode;
				[FieldOffset(0)]
				internal winmdroot.System.SystemInformation.CACHE_RELATIONSHIP Cache;
				[FieldOffset(0)]
				internal winmdroot.System.SystemInformation.GROUP_RELATIONSHIP Group;
			}
		}
	}
}
