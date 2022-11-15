﻿// ------------------------------------------------------------------------------
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
	namespace System.Threading
	{
		/// <summary>Contains information about a power request. This structure is used by the PowerCreateRequest and SetWaitableTimerEx functions.</summary>
		/// <remarks>
		/// <para><see href="https://docs.microsoft.com/windows/win32/api//minwinbase/ns-minwinbase-reason_context">Learn more about this API from docs.microsoft.com</see>.</para>
		/// </remarks>
		[global::System.CodeDom.Compiler.GeneratedCode("Microsoft.Windows.CsWin32", "0.2.104-beta+6d86f35b75")]
		internal partial struct REASON_CONTEXT
		{
			/// <summary>
			/// <para>The version number of the structure. This parameter must be set to <b>POWER_REQUEST_CONTEXT_VERSION</b>.</para>
			/// <para><see href="https://docs.microsoft.com/windows/win32/api//minwinbase/ns-minwinbase-reason_context#members">Read more on docs.microsoft.com</see>.</para>
			/// </summary>
			internal uint Version;
			/// <summary></summary>
			internal winmdroot.System.Threading.POWER_REQUEST_CONTEXT_FLAGS Flags;
			/// <summary>A union that consists of either a <b>Detailed</b> structure or a string.</summary>
			internal winmdroot.System.Threading.REASON_CONTEXT._Reason_e__Union Reason;

			[StructLayout(LayoutKind.Explicit)]
			[global::System.CodeDom.Compiler.GeneratedCode("Microsoft.Windows.CsWin32", "0.2.104-beta+6d86f35b75")]
			internal partial struct _Reason_e__Union
			{
				[FieldOffset(0)]
				internal winmdroot.System.Threading.REASON_CONTEXT._Reason_e__Union._Detailed_e__Struct Detailed;
				[FieldOffset(0)]
				internal winmdroot.Foundation.PWSTR SimpleReasonString;

				[global::System.CodeDom.Compiler.GeneratedCode("Microsoft.Windows.CsWin32", "0.2.104-beta+6d86f35b75")]
				internal partial struct _Detailed_e__Struct
				{
					internal winmdroot.Foundation.HINSTANCE LocalizedReasonModule;
					internal uint LocalizedReasonId;
					internal uint ReasonStringCount;
					internal unsafe winmdroot.Foundation.PWSTR* ReasonStrings;
				}
			}
		}
	}
}