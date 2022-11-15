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
	namespace System.Memory
	{
		/// <remarks>
		/// <para><see href="https://docs.microsoft.com/windows/win32/api//heapapi/ns-heapapi-heap_summary#">Read more on docs.microsoft.com</see>.</para>
		/// </remarks>
		[global::System.CodeDom.Compiler.GeneratedCode("Microsoft.Windows.CsWin32", "0.2.104-beta+6d86f35b75")]
		internal partial struct HEAP_SUMMARY
		{
			/// <summary>The size of this data structure, in bytes. Set this member to sizeof(HEAP_SUMMARY).</summary>
			internal uint cb;
			/// <summary>The size of the allocated memory.</summary>
			internal nuint cbAllocated;
			/// <summary>The size of the committed memory.</summary>
			internal nuint cbCommitted;
			/// <summary>The size of the reserved memory.</summary>
			internal nuint cbReserved;
			/// <summary>The size of the maximum reserved memory.</summary>
			internal nuint cbMaxReserve;
		}
	}
}