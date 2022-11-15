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
		/// <summary>Contains dynamic exception handling continuation targets.</summary>
		/// <remarks>
		/// <para><see href="https://docs.microsoft.com/windows/win32/api//winnt/ns-winnt-process_dynamic_eh_continuation_target#">Read more on docs.microsoft.com</see>.</para>
		/// </remarks>
		[global::System.CodeDom.Compiler.GeneratedCode("Microsoft.Windows.CsWin32", "0.2.104-beta+6d86f35b75")]
		internal partial struct PROCESS_DYNAMIC_EH_CONTINUATION_TARGET
		{
			/// <summary>The address of a dynamic exception handling continuation target.</summary>
			internal nuint TargetAddress;
			/// <summary>
			/// <para>Flags that apply to the dynamic exception handling continuation target in <i>TargetAddress</i>. </para>
			/// <para>This doc was truncated.</para>
			/// <para><see href="https://docs.microsoft.com/windows/win32/api//winnt/ns-winnt-process_dynamic_eh_continuation_target#members">Read more on docs.microsoft.com</see>.</para>
			/// </summary>
			internal nuint Flags;
		}
	}
}