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
	namespace System.Diagnostics.Debug
	{
		/// <summary>Contains information about a dynamic-link library (DLL) that has just been unloaded.</summary>
		/// <remarks>
		/// <para><see href="https://docs.microsoft.com/windows/win32/api//minwinbase/ns-minwinbase-unload_dll_debug_info">Learn more about this API from docs.microsoft.com</see>.</para>
		/// </remarks>
		[global::System.CodeDom.Compiler.GeneratedCode("Microsoft.Windows.CsWin32", "0.2.104-beta+6d86f35b75")]
		internal partial struct UNLOAD_DLL_DEBUG_INFO
		{
			/// <summary>A pointer to the base address of the DLL in the address space of the process unloading the DLL.</summary>
			internal unsafe void* lpBaseOfDll;
		}
	}
}
